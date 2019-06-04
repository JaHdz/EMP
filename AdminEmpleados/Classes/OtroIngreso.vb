Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class OtroIngreso
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property EstudioSocioeconomico As New Integer
    Public Property Descripcion As String = String.Empty
    Public Property Monto As New Decimal
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEstudioSocioeconomico As Integer, ByVal lsDescripcion As String, ByVal ldMonto As Decimal)
        ID = liID
        EstudioSocioeconomico = liEstudioSocioeconomico
        Descripcion = lsDescripcion
        Monto = ldMonto
    End Sub

    Public Function CargarListado(piEstudioSocioeconomico As Integer) As List(Of OtroIngreso)
        Dim Result As New List(Of OtroIngreso)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_OTHER_INCOMES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", piEstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@DESC", Descripcion))
            cmd.Parameters.Add(New SqlParameter("@AMOUNT", Monto))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loOtroIngreso As New OtroIngreso(Reader("ID"), Reader("ES"), Reader("DESCR"), Reader("CANT"))
                    Result.Add(loOtroIngreso)
                End While
            End Using
        End Using
        Return Result
    End Function
#End Region
End Class

