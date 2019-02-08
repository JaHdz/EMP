Imports System.Data.SqlClient

Public Class Cls_ES
#Region "Properties"
    Public Property SES_ID As Integer
    Public Property EMP_ID As Integer
    Public Property H_TYPE As String
    Public Property H_CONDITION As String
    Public Property H_ELEC As New Boolean
    Public Property H_PHONE As New Boolean
    Public Property H_WATER As New Boolean
    Public Property H_SEWER As New Boolean
    Public Property H_GAS As New Boolean
    Public Property H_TRASHREC As New Boolean
    Public Property H_CABLETV As New Boolean
    Public Property H_INTERNET As New Boolean
    Public Property H_SECURITY As New Boolean
    Public Property T_METRO As New Boolean
    Public Property T_PUBLIC As New Boolean
    Public Property T_TAX As New Boolean
    Public Property T_CAR As New Boolean
    Public Property A_SOCIAL As Integer
    Public Property A_COMUNITARY As Integer
    Public Property A_MUSEUMS As Integer
    Public Property A_THEATERS As Integer
    Public Property A_MOVIES As Integer
    Public Property A_FESTIVALS As Integer
    Public Property A_ARCHE As Integer
    Public Property A_VACATIONS As Integer
    Public Property A_PLAZAS As Integer
    Public Property A_NPARK As Integer
    Public Property A_APARK As Integer
    Public Property FS_RENT As Decimal
    Public Property FS_SCHOOL As Decimal
    Public Property FS_GROCERIES As Decimal
    Public Property FS_SERVICES As Decimal
    Public Property SES_HOBBIES As String
    Public Property SES_RELIGION As String
    Public Property SES_VERIFIER As String
    Public Property SES_OBSERVATIONS As String
    Public Property IMG As Image
#End Region


    Public Function GetInfo(Employee As Integer) As DataTable
        GetInfo = New DataTable()
        Using connection As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "UDSP_SES_RPT_1OF4"
            cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Employee
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            GetInfo.Load(dr)
        End Using
    End Function
    Public Function GetReferences(SESID As Integer) As DataTable
        GetReferences = New DataTable()
        Using connection As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "UDSP_SES_RPT_2OF4"
            cmd.Parameters.Add("@ID_SES", SqlDbType.Int).Value = SESID
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            GetReferences.Load(dr)
        End Using
    End Function
    Public Function GetFamily(Employee As Integer) As DataTable
        GetFamily = New DataTable()
        Using connection As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "UDSP_SES_RPT_3OF4"
            cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Employee
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            GetFamily.Load(dr)
        End Using
    End Function
    Public Function GetOtherIncomes(SESID As Integer) As DataTable
        GetOtherIncomes = New DataTable()
        Using connection As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            connection.Open()
            Dim cmd As SqlCommand = connection.CreateCommand()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "UDSP_SES_RPT_4OF4"
            cmd.Parameters.Add("@ID_SES", SqlDbType.Int).Value = SESID
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            GetOtherIncomes.Load(dr)
        End Using
    End Function
End Class
