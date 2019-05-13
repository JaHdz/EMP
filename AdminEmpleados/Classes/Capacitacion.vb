Imports System.Data.SqlClient

Public Class Capacitacion
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Codigo As String = String.Empty
    Public Property Descripcion As String = String.Empty
    Public Property EstaActivo As Boolean = True
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal lsCodigo As String, ByVal lsDescripcion As String, ByVal lbEstaActivo As Boolean?)
        ID = liID
        Codigo = lsCodigo
        Descripcion = lsDescripcion
        EstaActivo = lbEstaActivo
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Capacitacion)
        Dim Result As New List(Of Capacitacion)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_TRANINGS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loCapacitacion As New Capacitacion(Reader("ID_CAP"), Reader("CA_CODIGO"), Reader("CA_DESC"), Reader("CA_STATUS"))
                    Result.Add(loCapacitacion)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EstaActivo = True)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Capacitacion)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not VerificarExistencia(Listado) Then
            If Not String.IsNullOrWhiteSpace(Codigo) OrElse Not String.IsNullOrWhiteSpace(Descripcion) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_TRANINGS", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
                    cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                    cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Los campos no pueden estar vacios, Intente de nuevo."
                Encabezado = "Error de registro de Capacitacion"
                IconoDeMensaje = MessageBoxIcon.Warning
            End If
        Else
            Mensaje = "Esta capacitacion ya se encuentra registrado en el sistema."
            Encabezado = "Error de registro de Capacitacion"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Capacitacion)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_TRANINGS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    'Public Function Eliminar(ByRef Listado As List(Of Usuario)) As Boolean
    '    Dim Result As Boolean = False
    '    Dim Mensaje = String.Empty
    '    Dim IconoDeMensaje As MessageBoxIcon
    '    Dim Encabezado = String.Empty
    '    If UsuarioLogeado.UserName <> UserName Then
    '        Using con As New SqlConnection(ConnectionString())
    '            con.Open()
    '            Dim cmd As New SqlCommand("UDSP_TRANINGS", con) With {.CommandType = CommandType.StoredProcedure}
    '            cmd.Parameters.Add(New SqlParameter("@ID", ID))
    '            cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
    '            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
    '            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
    '            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
    '            cmd.ExecuteNonQuery()
    '            Result = True
    '            Listado = CargarListado()
    '        End Using
    '    Else
    '        Mensaje = "No puedes eliminar tu propio usuario"
    '        Encabezado = "Error de eliminar usuario"
    '        IconoDeMensaje = MessageBoxIcon.Error
    '    End If

    '    If Not String.IsNullOrWhiteSpace(Mensaje) Then
    '        MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
    '    End If
    '    Return Result
    'End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Capacitacion)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Codigo)
        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Capacitacion
        Dim Capacitacion As Capacitacion = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_TRANINGS", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
                cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Capacitacion = New Capacitacion(Reader("ID_CAP"), Reader("CA_CODIGO"), Reader("CA_DESC"), Reader("CA_STATUS"))
                    End If
                End Using
            End Using
        End If
        Return Capacitacion
    End Function
#End Region
End Class

