Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Tipo
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property Codigo As String = ""
    Public Property Descripcion As String = ""
    Public Property EstaActivo As Boolean? = True
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID_TE As Integer, ByVal lsCodigo As String, ByVal lsDescripcion As String, ByVal lbEstatus As Boolean?)
        ID = liID_TE
        Codigo = lsCodigo
        Descripcion = lsDescripcion
        EstaActivo = lbEstatus
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Tipo)
        Dim Result As New List(Of Tipo)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TYPE", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loTipo As New Tipo(Reader("ID_TE"), Reader("Codigo"), Reader("Descripcion"), Reader("Estatus"))
                    Result.Add(loTipo)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EstaActivo = True)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Tipo)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(Codigo) AndAlso Not String.IsNullOrWhiteSpace(Descripcion) Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TYPE", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
                    cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                    cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Este Tipo ya se encuentra registrado en el sistema."
                Encabezado = "Error de registro de tipo de empleado"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de tipo de empleado"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Tipo)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TYPE", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Tipo)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Codigo = Codigo)
        Return Result
    End Function

    Public Function Buscar(ByVal pID As String) As Tipo
        Dim Result As Tipo = Nothing
        If Not String.IsNullOrWhiteSpace(pID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TYPE", con) With {
                .CommandType = CommandType.StoredProcedure
            }
                If IsNumeric(pID) Then
                    cmd.Parameters.Add(New SqlParameter("@ID", pID))
                    cmd.Parameters.Add(New SqlParameter("@CODE", Codigo))
                Else
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@CODE", pID))
                End If
                cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Descripcion))
                cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New Tipo(Reader("ID_TE"), Reader("Codigo"), Reader("Descripcion"), Reader("Estatus"))
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function
#End Region
End Class

