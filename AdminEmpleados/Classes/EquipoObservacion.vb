Imports System.Data.SqlClient

Public Class EquipoObservacion
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Empleado As Integer
    Public Property Observacion As String
    Public Property Fecha As Date
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lsObservaciones As String, ByVal ldFecha As Date)
        ID = liID
        Empleado = liEmpleado
        Observacion = lsObservaciones
        Fecha = ldFecha
    End Sub

    Public Function Registrar() As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_OBSERVACIONES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID_EMP", Empleado))
            cmd.Parameters.Add(New SqlParameter("@OBSERVACIONES", Observacion))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function
#End Region
End Class

