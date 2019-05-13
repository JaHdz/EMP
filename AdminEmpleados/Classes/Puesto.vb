Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Puesto
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property Nombre As String = ""
    Public Property Descripcion As String = ""
    Public Property EsRiesgoso As Boolean? = False
    Public Property EstaActivo As Boolean? = True
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal lsNombre As String, ByVal lsDescripcion As String, ByVal lbRiesgo As Boolean?, ByVal lbEstatus As Boolean?)
        ID = liID
        Nombre = lsNombre
        Descripcion = lsDescripcion
        EsRiesgoso = lbRiesgo
        EstaActivo = lbEstatus
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Puesto)
        Dim Result As New List(Of Puesto)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_POSITIONS", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@RISK", EsRiesgoso))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loPuesto As New Puesto(Reader("ID_Puesto"), Reader("Nombre"), Reader("Descripcion"), Reader("Riesgo"), Reader("Estatus"))
                    Result.Add(loPuesto)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EstaActivo = True)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Puesto)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(Nombre) AndAlso Not String.IsNullOrWhiteSpace(Descripcion) Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As SqlCommand = con.CreateCommand
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                    cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                    cmd.Parameters.Add(New SqlParameter("@RISK", EsRiesgoso))
                    cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.CommandText = "UDSP_POSITIONS"
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Este Puesto ya se encuentra registrado en el sistema."
                Encabezado = "Error de registro de puesto"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de puesto"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Puesto)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@RISK", EsRiesgoso))
            cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.CommandText = "UDSP_POSITIONS"
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Puesto)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Nombre = Nombre)
        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Puesto
        Dim Result As Puesto = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_POSITIONS", con) With {
                    .CommandType = CommandType.StoredProcedure
                }
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                cmd.Parameters.Add(New SqlParameter("@RISK", EsRiesgoso))
                cmd.Parameters.Add(New SqlParameter("@STATUS", EstaActivo))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New Puesto(Reader("ID_Puesto"), Reader("Nombre"), Reader("Descripcion"), Reader("Riesgo"), Reader("Estatus"))
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function
#End Region
End Class

