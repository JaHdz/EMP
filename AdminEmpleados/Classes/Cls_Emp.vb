Imports System.Data.SqlClient

Public Class Cls_Emp
#Region "Properties"
    Public Property ID_Emp As New Integer
    Public Property Emp_Name As String = ""
    Public Property Emp_APat As String = ""
    Public Property Emp_AMat As String = ""
    Public Property Emp_Col As String = ""
    Public Property Emp_Ciudad As String = ""
    Public Property Emp_CP As String = ""
    Public Property Emp_Cel As String = ""
    Public Property Emp_Tel As String = ""
    Public Property Emp_EdoCivil As String = ""
    Public Property Emp_Nacionalidad As String = ""
    Public Property Emp_Salario As New Decimal
    Public Property Emp_NEducativo As String = ""
    Public Property Emp_Email As String = ""
    Public Property Emp_FNac As New DateTime
    Public Property Emp_RFC As String = ""
    Public Property Emp_NSS As New Double
    Public Property Emp_FAlta As New DateTime
    Public Property Emp_Sexo As String = ""
    Public Property Emp_Curp As String = ""
    Public Property Emp_Domicilio As String = ""
    Public Property Emp_CiudadEstado As String = ""
    Public Property Emp_Activo As New Integer
    Public Property Emp_Tipo As String = ""
    Public Property Emp_Sup As New Integer
    Public Property Emp_FEfectiva As New DateTime
    Public Property ID_Depto As String = ""
    Public Property ID_Puesto As String = ""
    Public Property ID_User As New Integer
    Public Property Img As Image = Nothing
    Public Property Emp_EN As String = ""
    Public Property Baja As New Cls_Bajas


#End Region

    Public Function GetAssignedEquipment(Employee As Integer) As DataTable
        GetAssignedEquipment = New DataTable()
        Using connection As New SqlConnection(ConnectionString())
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Equipo_Asignado WHERE ID_Emp=@EMPLOYEE"
            cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Employee
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            GetAssignedEquipment.Load(dr)
        End Using
    End Function
    Public Function GetEquipmentReceiver(ID As Integer, Name As String) As DataTable
        GetEquipmentReceiver = New DataTable("RECEIVER")
        GetEquipmentReceiver.Columns.AddRange(New DataColumn() {
            New DataColumn("ID_Emp"),
            New DataColumn("Emp_Name")
            })
        GetEquipmentReceiver.Rows.Add({ID, Name.ToUpper()})
    End Function
End Class
Public Class Cls_Bajas
    Public Property ID() As New Integer
    Public Property Empleado() As New Integer
    Public Property Fecha_Baja() As New DateTime
    Public Property Motivo() As String = ""
    Public Property Alerta() As Boolean
    Public Property Username() As String = ""
    Public Property NotificarProveedores() As New Boolean
    Public Property NotificarClientes() As New Boolean
End Class
