Imports System.Data.SqlClient

Public Class Equipo
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Nombre As String = String.Empty
    Public Property Descripcion As String = String.Empty
    Public Property Costo As New Decimal
    Public Property EstaActivo As Boolean = 1
    Public Property Departamento As New Integer
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal lsNombre As String, ByVal lsDescripcion As String, ByVal ldCosto As Decimal?, ByVal lbEstatus As Boolean?,
                   ByVal liDepartamento As Integer)
        ID = liID
        Nombre = lsNombre
        Descripcion = lsDescripcion
        Costo = ldCosto
        EstaActivo = lbEstatus
        Departamento = liDepartamento
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Equipo)
        Dim Result As New List(Of Equipo)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EQUIPMENT", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@COST", Costo))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@DEPTO", Departamento))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEquipo As New Equipo(Reader("ID_EQUIPO"), Reader("NOMBRE"), Reader("DESCRIPCION"), Reader("COSTO"), Reader("ESTATUS"), Reader("COSTO"))
                    Result.Add(loEquipo)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EstaActivo = True)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Equipo)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(Nombre) AndAlso Not String.IsNullOrWhiteSpace(Descripcion) AndAlso
           Not String.IsNullOrWhiteSpace(Costo) Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EQUIPMENT", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                    cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                    cmd.Parameters.Add(New SqlParameter("@COST", Costo))
                    cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                    cmd.Parameters.Add(New SqlParameter("@DEPTO", Departamento))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Este equipo ya existe en el departamento seleccionado."
                Encabezado = "Error de registro de equipo"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de equipo"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Equipo)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EQUIPMENT", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@COST", Costo))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@DEPTO", Departamento))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Equipo)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Nombre = Nombre And X.Departamento = Departamento)
        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Equipo
        Dim Result As Equipo = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EQUIPMENT", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                cmd.Parameters.Add(New SqlParameter("@COST", Costo))
                cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                cmd.Parameters.Add(New SqlParameter("@DEPTO", Departamento))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New Equipo(Reader("ID_EQUIPO"), Reader("NOMBRE"), Reader("DESCRIPCION"), Reader("COSTO"), Reader("ESTATUS"), Reader("ID_DEPTO"))
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function
#End Region
End Class

