Imports System.Data.SqlClient

Public Class Estatus
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Empleado As New Integer
    Public Property FechaDeBaja As Date = DateTimePicker.MinimumDateTime
    Public Property Motivo As String = String.Empty
    Public Property Alerta As Boolean = False
    Public Property NotificarProveedores As Boolean = False
    Public Property NotificarClientes As Boolean = False
    Public Property NotificarSeguridad As Boolean = False
    Public Property Usuario As New Integer

#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer, ByVal ldFechaDeBaja As Date, ByVal lsMotivo As String, ByVal lbAlerta As Boolean,
                    ByVal lbNotificarProveedores As Boolean, ByVal lbNotificarClientes As Boolean, ByVal lbNotificarSeguridad As Boolean, ByVal liUsuario As Integer)
        ID = liID
        Empleado = liEmpleado
        FechaDeBaja = ldFechaDeBaja
        Motivo = lsMotivo
        Alerta = lbAlerta
        NotificarProveedores = lbNotificarProveedores
        NotificarClientes = lbNotificarClientes
        NotificarSeguridad = lbNotificarSeguridad
        Usuario = liUsuario
    End Sub

    Public Function Registrar() As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_ALTA", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DISDATE", FechaDeBaja))
            cmd.Parameters.Add(New SqlParameter("@REASON", Motivo))
            cmd.Parameters.Add(New SqlParameter("@ALERT", Alerta))
            cmd.Parameters.Add(New SqlParameter("@NPROV", NotificarProveedores))
            cmd.Parameters.Add(New SqlParameter("@NCLIENT", NotificarClientes))
            cmd.Parameters.Add(New SqlParameter("@NSECU", NotificarSeguridad))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function

    Public Function Eliminar() As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_ALTA", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DISDATE", FechaDeBaja))
            cmd.Parameters.Add(New SqlParameter("@REASON", Motivo))
            cmd.Parameters.Add(New SqlParameter("@ALERT", Alerta))
            cmd.Parameters.Add(New SqlParameter("@NPROV", NotificarProveedores))
            cmd.Parameters.Add(New SqlParameter("@NCLIENT", NotificarClientes))
            cmd.Parameters.Add(New SqlParameter("@NSECU", NotificarSeguridad))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function
#End Region
End Class

