Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Referencia
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property EstudioSocioeconomico As New Integer
    Public Property Nombre As String = String.Empty
    Public Property Ocupacion As String = String.Empty
    Public Property TipoDeRelacion As String = String.Empty
    Public Property TiempoDeConocerse As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEstudioSocioeconomico As Integer, ByVal lsNombre As String, ByVal lsOcupacion As String,
                   ByVal lsTipoDeRelacion As String, ByVal lsTiempoDeConocerse As String)
        ID = liID
        EstudioSocioeconomico = liEstudioSocioeconomico
        Nombre = lsNombre
        Ocupacion = lsOcupacion
        TipoDeRelacion = lsTipoDeRelacion
        TiempoDeConocerse = lsTiempoDeConocerse
    End Sub

    Public Function CargarListado(EstudioSocioeconomico As Integer) As List(Of Referencia)
        Dim Result As New List(Of Referencia)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_JOBHISTORY", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@OCUPATION", Ocupacion))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", TipoDeRelacion))
            cmd.Parameters.Add(New SqlParameter("@TIME", TipoDeRelacion))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loReferencia As New Referencia(Reader("ID"), Reader("ES"), Reader("NAME"), Reader("OCU"), Reader("TDR"), Reader("TDC"))
                    Result.Add(loReferencia)
                End While
            End Using
        End Using
        Return Result
    End Function
#End Region
End Class

