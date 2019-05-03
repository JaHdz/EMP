Imports System.Data.SqlClient

Public Class Usuario
#Region "Propiedades"
    Public Property ID As Integer
    Public Property NumeroDeEmpleado As Integer
    Public Property UserName As String
    Public Property Password As String
    Public Property Activo As Boolean?
    Public Property Acceso As Integer?
    Public Property Nombre As String
    Public Property ResetKey As String
    Private Property CorreoElectronico As String
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer, ByVal lsUserName As String, ByVal lsPassword As String, ByVal lbActivo As Boolean?,
                   ByVal liAcceso As Integer?, ByVal lsResetKey As String)
        ID = liID
        NumeroDeEmpleado = liEmpleado
        UserName = lsUserName
        Password = lsPassword
        Activo = lbActivo
        Acceso = liAcceso
        ResetKey = lsResetKey
    End Sub

    Public Function IniciarSesion() As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        If Not String.IsNullOrWhiteSpace(UserName) AndAlso Not String.IsNullOrWhiteSpace(Password) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SP_UserandPass"
                cmd.Parameters.AddWithValue("@user", UserName)
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
            MsgBox(Mensaje, MsgBoxStyle.Exclamation, "Error al iniciar sesión")
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

#End Region
End Class

