﻿Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Net
Imports System.Data.SqlDbType

Public Class Cls_Emp
#Region "Properties"
    Public Property ID_Emp As Integer
    Public Property Emp_Name As String
    Public Property Emp_APat As String
    Public Property Emp_AMat As String
    Public Property Emp_Col As String
    Public Property Emp_Ciudad As String
    Public Property Emp_CP As String
    Public Property Emp_Cel As String
    Public Property Emp_Tel As String
    Public Property Emp_EdoCivil As String
    Public Property Emp_Nacionalidad As String
    Public Property Emp_Salario As Decimal
    Public Property Emp_NEducativo As String
    Public Property Emp_Email As String
    Public Property Emp_FNac As DateTime
    Public Property Emp_RFC As String
    Public Property Emp_NSS As Double
    Public Property Emp_FAlta As DateTime
    Public Property Emp_Sexo As String
    Public Property Emp_Curp As String
    Public Property Emp_Domicilio As String
    Public Property Emp_Activo As Integer
    Public Property Emp_Tipo As String
    Public Property Emp_Sup As Int64
    Public Property Emp_FEfectiva As DateTime
    Public Property ID_Depto As String
    Public Property ID_Puesto As String
    Public Property ID_User As Int64
    Public Property Img As Image
    Public Property Emp_EN As String
    Public Property NProv As Boolean
    Public Property NClientes As Boolean
#End Region

    Public Function GetAssignedEquipment(Employee As Integer) As DataTable
        GetAssignedEquipment = New DataTable()
        Using connection As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM ASSIGNED_EQUIPMENT WHERE ID_EMPLEADO=@EMPLOYEE"
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
