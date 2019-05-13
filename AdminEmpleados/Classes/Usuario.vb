Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Usuario
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property NumeroDeEmpleado As New Integer
    Public Property Nombre As String = ""
    Public Property UserName As String = ""
    <Browsable(False)>
    Public Property Password As String = ""
    <Browsable(False)>
    Public Property Activo As Boolean? = True
    <Browsable(False)>
    Public Property Acceso As New Integer
    <Browsable(False)>
    Public Property ResetKey As String = ""
    Private Property CorreoElectronico As String = ""
    Private Property Password2 As String = ""

#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer, ByVal lsUserName As String, ByVal lsPassword As String, ByVal lbActivo As Boolean?,
                   ByVal liAcceso As Integer?, ByVal lsNombre As String, ByVal lsResetKey As String, Optional ByRef lsPassword2 As String = "")
        ID = liID
        NumeroDeEmpleado = liEmpleado
        UserName = lsUserName
        Password = lsPassword
        Activo = lbActivo
        Acceso = liAcceso
        Nombre = lsNombre
        ResetKey = lsResetKey
        If Not String.IsNullOrWhiteSpace(lsPassword2) Then
            Password2 = lsPassword2
        End If
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Usuario)
        Dim Result As New List(Of Usuario)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_USERS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
            cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
            cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
            cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loUsuario As New Usuario(Reader("ID_User"), Reader("ID_Emp"), Reader("UserName"), Reader("Password"), Reader("Activo"), Reader("Acceso"), Reader("Nom"), Reader("ResetKey"))
                    Result.Add(loUsuario)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function IniciarSesion() As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        If Not String.IsNullOrWhiteSpace(UserName) AndAlso Not String.IsNullOrWhiteSpace(Password) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
                cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
                cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
                cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.IniciarSesion))
                cmd.CommandText = "UDSP_USERS"
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        If Password = Reader("pass").ToString Then
                            ID = Reader("ID_Emp")
                            NumeroDeEmpleado = Reader("NoEmp")
                            UserName = Reader("User")
                            Password = Reader("Pass")
                            Activo = Reader("Activo")
                            Acceso = Reader("Acceso")
                            Nombre = Reader("Nom")
                            ResetKey = Reader("ResetKey")
                            UsuarioLogeado = Me
                            Result = True
                        Else
                            Mensaje = "La contraseña ingresada es incorrecta"
                        End If
                    Else
                        Mensaje = "La usuario ingresado no existe"
                    End If
                End Using
            End Using
        Else
            Mensaje = "Los campos no pueden estar vacios"
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return Result
    End Function

#Region "Restablecer Contraseña"
    Public Function SolicitarCambioDeContraseña() As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(UserName) Then
            ObtenerCorreoElectronico()
            If Not String.IsNullOrWhiteSpace(CorreoElectronico) Then
                If EnviarCorreo() Then
                    Mensaje = "Se le ha enviado un correo con un codigo que debera introducir en la siguiente pantalla."
                    Encabezado = "Solicitud exitosa"
                End If
            Else
                Mensaje = "Este usuario no existe o no cuenta con un correo electronico registrado"
                Encabezado = "Error al enviar solicitud"
            End If
        Else
            Mensaje = "Para restaurar su contraseña debe ingresar su usuario y despues presionar 'Olvidé mi contraseña'"
            Encabezado = "Error al enviar solicitud"
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MsgBox(Mensaje, MsgBoxStyle.Exclamation, Encabezado)
        End If
        Return Result
    End Function

    Private Sub ObtenerCorreoElectronico()
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
            cmd.CommandText = "SP_GETUSEREMAIL"
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    CorreoElectronico = lector("EMP_EMAIL").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Function EnviarCorreo() As Boolean
        Dim Result As Boolean = False
        Dim Email As New Email
        Dim Code As String = Email.GenerateCode()
        If Email.Send(CorreoElectronico, "Solicitud para restaurar su contraseña", "SOLICITUD RECIBIDA EL DIA:",
                            "Se ha solicitado restablecer su contraseña para ingresar al sistema EASY. Favor de ingresar el siguiente codigo en el campo correspondiente:",
                            Code, Date.Now.ToShortDateString(), "Si usted no solicitó el cambio de contraseña haga caso omiso de este correo.") = "Success" Then
            ResetKey = Encrypt(Code)
            GuardarCodigoDeRestauracion()
            Result = True
        Else
            Result = "Hubo un problema, no se pudo enviar el correo. Intente mas tarde o notifique a su administrador."
        End If
        Return Result
    End Function

    Private Sub GuardarCodigoDeRestauracion()
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
            cmd.Parameters.Add(New SqlParameter("@RESETKEY", ResetKey))
            cmd.CommandText = "SP_SETRESETKEY"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ValidarCodigoDeRestauracion(Codigo As String) As Boolean
        Dim Result = False
        If Not String.IsNullOrWhiteSpace(Codigo) Then
            If Codigo = ResetKey Then
                Result = True
            Else
                MsgBox("Codigo invalido. Introduzca el codigo que se le envió a su correo.", MsgBoxStyle.Exclamation, "Error al validar codigo")
            End If
        Else
            MsgBox("Introduzca el codigo que se le envió a su correo.", MsgBoxStyle.Exclamation, "Error al validar codigo")
        End If
        Return Result
    End Function

    Public Function CambiarContraseña(Contraseña1 As String, Contraseña2 As String) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MsgBoxStyle
        Dim Encabezado = String.Empty
        Dim C1 = Trim(Contraseña1)
        Dim C2 = Trim(Contraseña2)
        If Not String.IsNullOrWhiteSpace(C1) AndAlso Not String.IsNullOrWhiteSpace(C2) Then
            If C1.Equals(C2) Then
                Password = Encrypt(C1)
                Try
                    Using con As New SqlConnection(ConnectionString())
                        con.Open()
                        Dim cmd As SqlCommand = con.CreateCommand
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
                        cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                        cmd.CommandText = "SP_RESETPASSWORD"
                        cmd.ExecuteNonQuery()
                        Result = True
                        Mensaje = "Su contraseña ha sido cambiada con exito."
                        Encabezado = "Operacion exitosa"
                        IconoDeMensaje = MsgBoxStyle.OkOnly
                    End Using
                Catch ex As Exception
                    Mensaje = "Hubo un problema al intentar restablecer su contraseña, intente de nuevo o contacte a su administrador."
                    Encabezado = "Error al restablecer contraseña"
                    IconoDeMensaje = MsgBoxStyle.Critical
                End Try
            Else
                Mensaje = "Las contraseñas no coinciden. Intente de nuevo."
                Encabezado = "Error al validar contraseña"
                IconoDeMensaje = MsgBoxStyle.Exclamation
            End If
        Else
            Mensaje = "Introduzca una contraseña en ambos campos."
            Encabezado = "Error al validar contraseña"
            IconoDeMensaje = MsgBoxStyle.Exclamation
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MsgBox(Mensaje, IconoDeMensaje, Encabezado)
        End If
        Return Result
    End Function

#End Region

    Public Function Registrar(ByRef Listado As List(Of Usuario)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not VerificarExistencia(Listado) Then
            If Password = Password2 Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_USERS", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
                    cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                    cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
                    cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
                    cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.CommandText = "UDSP_USERS"
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Las contraseñas no coinciden, Intente de nuevo."
                Encabezado = "Error de registro de usuario"
                IconoDeMensaje = MessageBoxIcon.Warning
            End If
        Else
            Mensaje = "Este nombre de usuario o empleado ya se encuentra registrado en el sistema."
            Encabezado = "Error de registro de usuario"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Usuario)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_USERS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
            cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
            cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
            cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.CommandText = "UDSP_USERS"
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of Usuario)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If UsuarioLogeado.UserName <> UserName Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_USERS", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
                cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
                cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
                cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
                cmd.CommandText = "UDSP_USERS"
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(True)
            End Using
        Else
            Mensaje = "No puedes eliminar tu propio usuario"
            Encabezado = "Error de eliminar usuario"
            IconoDeMensaje = MessageBoxIcon.Error
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Usuario)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(loUsuario) loUsuario.NumeroDeEmpleado = NumeroDeEmpleado OrElse loUsuario.UserName = UserName)
        Return Result
    End Function

    Private Function VerificarUsername(ByRef Listado As List(Of Usuario)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(loUsuario) loUsuario.UserName = UserName)
        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Usuario
        Dim Usuario As Usuario = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_USERS", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@USERNAME", UserName))
                cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                cmd.Parameters.Add(New SqlParameter("@ACTIVE", Activo))
                cmd.Parameters.Add(New SqlParameter("@ACCESS", Acceso))
                cmd.Parameters.Add(New SqlParameter("@ID_EMP", NumeroDeEmpleado))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Usuario = New Usuario(Reader("ID_User"), Reader("ID_Emp"), Reader("UserName"), Reader("Password"), Reader("Activo"), Reader("Acceso"), Reader("Nom"), Reader("ResetKey"))
                    End If
                End Using
            End Using
        End If
        Return Usuario
    End Function
#End Region
End Class

