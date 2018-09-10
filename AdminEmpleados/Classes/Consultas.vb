Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Net
Imports System.Data.SqlDbType
Public Class Consultas
    Public autenticado As Boolean
    Public user As String
    Public name As String

    'Empleados_________________________________________________________________________________________________________
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            Dim Bin As New MemoryStream
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function Autenticar(sUsr As String, sPass As String) As Boolean
        Dim sentencia As String
        Dim lector As SqlDataReader
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            sentencia = "SP_UserandPass '" & sUsr & "'"
            Dim cmd As New SqlCommand(sentencia, con)
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Dim pass As String
                pass = DesEncripta(lector("pass").ToString)
                If pass = sPass Then
                    user = lector("NoEmp").ToString
                    name = lector("name").ToString
                    autenticado = True
                    Return True
                Else
                    autenticado = False
                    Return False
                End If
            Else
                autenticado = False
                Return False
            End If
        End Using
    End Function

    Function DesEncripta(ByVal Pass As String) As String
        Dim Clave As String, i As Integer, Pass2 As String
        Dim CAR As String, Codigo As String
        Dim j As Integer
        Clave = "%ü&/@#$A"
        Pass2 = ""
        j = 1
        For i = 1 To Len(Pass) Step 2
            CAR = Mid(Pass, i, 2)
            Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        DesEncripta = Pass2
    End Function

    Public Sub UpInsert_colabora(ByVal infoEmp As Cls_Emp)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim Imag As Byte()
            Imag = Imagen_Bytes(infoEmp.Img)
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", infoEmp.ID_Emp))
            cmd.Parameters.Add(New SqlParameter("@NAME", infoEmp.Emp_Name))
            cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", infoEmp.Emp_APat))
            cmd.Parameters.Add(New SqlParameter("@M_LASTNAME", infoEmp.Emp_AMat))
            cmd.Parameters.Add(New SqlParameter("@COL", infoEmp.Emp_Col))
            cmd.Parameters.Add(New SqlParameter("@CITY", infoEmp.Emp_Ciudad))
            cmd.Parameters.Add(New SqlParameter("@ZIP", infoEmp.Emp_CP))
            cmd.Parameters.Add(New SqlParameter("@CELLPHONE", infoEmp.Emp_Cel))
            cmd.Parameters.Add(New SqlParameter("@PHONE", infoEmp.Emp_Tel))
            cmd.Parameters.Add(New SqlParameter("@C_STATUS", infoEmp.Emp_EdoCivil))
            cmd.Parameters.Add(New SqlParameter("@NATIONALITY", infoEmp.Emp_Nacionalidad))
            cmd.Parameters.Add(New SqlParameter("@WAGE", infoEmp.Emp_Salario))
            cmd.Parameters.Add(New SqlParameter("@EDUCATION", infoEmp.Emp_NEducativo))
            cmd.Parameters.Add(New SqlParameter("@EMAIL", infoEmp.Emp_Email))
            cmd.Parameters.Add(New SqlParameter("@BIRTHDATE", infoEmp.Emp_FNac))
            cmd.Parameters.Add(New SqlParameter("@RFC", infoEmp.Emp_RFC))
            cmd.Parameters.Add(New SqlParameter("@SSN", infoEmp.Emp_NSS))
            cmd.Parameters.Add(New SqlParameter("@REG_DATE", Date.Now))
            cmd.Parameters.Add(New SqlParameter("@GENDER", infoEmp.Emp_Sexo))
            cmd.Parameters.Add(New SqlParameter("@CURP", infoEmp.Emp_Curp))
            cmd.Parameters.Add(New SqlParameter("@ADDRESS", infoEmp.Emp_Domicilio))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", infoEmp.Emp_Activo))
            cmd.Parameters.Add(New SqlParameter("@TYPE", infoEmp.Emp_Tipo))
            cmd.Parameters.Add(New SqlParameter("@SUPERVISOR", infoEmp.Emp_Sup))
            cmd.Parameters.Add(New SqlParameter("@EF_DATE", infoEmp.Emp_FEfectiva))
            cmd.Parameters.Add(New SqlParameter("@DEPARTMENT", infoEmp.ID_Depto))
            cmd.Parameters.Add(New SqlParameter("@POSITION", infoEmp.ID_Puesto))
            cmd.Parameters.Add(New SqlParameter("@USER", infoEmp.ID_User))
            cmd.Parameters.Add(New SqlParameter("@Emp_EN", infoEmp.Emp_EN))
            cmd.Parameters.Add(New SqlParameter("@EMP_IMAGE", Imag))
            cmd.CommandText = "UDSP_EMPLOYEE"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Add_ES(ByVal ES As Cls_ES) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@SES_ID", ES.SES_ID))
            cmd.Parameters.Add(New SqlParameter("@EMP_ID", ES.EMP_ID))
            cmd.Parameters.Add(New SqlParameter("@H_TYPE", ES.H_TYPE))
            cmd.Parameters.Add(New SqlParameter("@H_CONDITION", ES.H_CONDITION))
            cmd.Parameters.Add(New SqlParameter("@H_ELEC", ES.H_ELEC))
            cmd.Parameters.Add(New SqlParameter("@H_PHONE", ES.H_PHONE))
            cmd.Parameters.Add(New SqlParameter("@H_WATER", ES.H_WATER))
            cmd.Parameters.Add(New SqlParameter("@H_SEWER", ES.H_SEWER))
            cmd.Parameters.Add(New SqlParameter("@H_GAS", ES.H_GAS))
            cmd.Parameters.Add(New SqlParameter("@H_TRASHREC", ES.H_TRASHREC))
            cmd.Parameters.Add(New SqlParameter("@H_CABLETV", ES.H_CABLETV))
            cmd.Parameters.Add(New SqlParameter("@H_INTERNET", ES.H_INTERNET))
            cmd.Parameters.Add(New SqlParameter("@H_SECURITY", ES.H_SECURITY))
            cmd.Parameters.Add(New SqlParameter("@T_METRO", ES.T_METRO))
            cmd.Parameters.Add(New SqlParameter("@T_PUBLIC", ES.T_PUBLIC))
            cmd.Parameters.Add(New SqlParameter("@T_CAR", ES.T_CAR))
            cmd.Parameters.Add(New SqlParameter("@T_TAX", ES.T_TAX))
            cmd.Parameters.Add(New SqlParameter("@A_SOCIAL", ES.A_SOCIAL))
            cmd.Parameters.Add(New SqlParameter("@A_COMUNITARY", ES.A_COMUNITARY))
            cmd.Parameters.Add(New SqlParameter("@A_MUSEUMS", ES.A_MUSEUMS))
            cmd.Parameters.Add(New SqlParameter("@A_THEATERS", ES.A_THEATERS))
            cmd.Parameters.Add(New SqlParameter("@A_MOVIES", ES.A_MOVIES))
            cmd.Parameters.Add(New SqlParameter("@A_FESTIVALS", ES.A_FESTIVALS))
            cmd.Parameters.Add(New SqlParameter("@A_ARCHE", ES.A_ARCHE))
            cmd.Parameters.Add(New SqlParameter("@A_VACATIONS", ES.A_VACATIONS))
            cmd.Parameters.Add(New SqlParameter("@A_PLAZAS", ES.A_PLAZAS))
            cmd.Parameters.Add(New SqlParameter("@A_APARK", ES.A_APARK))
            cmd.Parameters.Add(New SqlParameter("@A_NPARK", ES.A_NPARK))
            cmd.Parameters.Add(New SqlParameter("@FS_RENT", ES.FS_RENT))
            cmd.Parameters.Add(New SqlParameter("@FS_SCHOOL", ES.FS_SCHOOL))
            cmd.Parameters.Add(New SqlParameter("@FS_GROCERIES", ES.FS_GROCERIES))
            cmd.Parameters.Add(New SqlParameter("@FS_SERVICES", ES.FS_SERVICES))
            cmd.Parameters.Add(New SqlParameter("@SES_HOBBIES", ES.SES_HOBBIES))
            cmd.Parameters.Add(New SqlParameter("@SES_RELIGION", ES.SES_RELIGION))
            cmd.Parameters.Add(New SqlParameter("@SES_VERIFIER", ES.SES_VERIFIER))
            cmd.Parameters.Add(New SqlParameter("@SES_OBSERVATIONS", ES.SES_OBSERVATIONS))
            cmd.CommandText = "UDSP_SES"
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    If lector("ID_ESTSOCIO").ToString = "" Then
                        Return 0
                    Else
                        Return lector("ID_ESTSOCIO").ToString
                    End If
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    Public Function NUMERO_EMPLEADO() As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Ultimo_Emp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    If lector("ID_Emp").ToString = "" Then
                        Return 0
                    Else
                        Return lector("ID_Emp").ToString
                    End If
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    Public Function Emp_Exist(ByVal user As Integer) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Emp", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", user)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    If lector("ID_Emp").ToString = 0 Then
                        Return 0
                    Else
                        Return lector("ID_Emp").ToString
                    End If
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    Public Sub Altas(ByVal id As String, ACTIVO As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", id))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", ACTIVO))
            cmd.CommandText = "UDSP_EMPLOYEE_ALTA"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Add_Examenes_Medicos(ByVal id As Integer, Emp As Integer, EM_Estudio As String, EM_Resultado As String, EM_Fecha As DateTime, EM_FechaProximo As DateTime) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID_EM", id))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Emp))
            cmd.Parameters.Add(New SqlParameter("@EM_Estudio", EM_Estudio))
            cmd.Parameters.Add(New SqlParameter("@EM_Resultado", EM_Resultado))
            cmd.Parameters.Add(New SqlParameter("@EM_Fecha", EM_Fecha))
            cmd.Parameters.Add(New SqlParameter("@EM_FechaProximo", EM_FechaProximo))
            cmd.CommandText = "UDSP_EXAMENES_MED"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Sub Bajas(ByVal id As String, ACTIVO As Integer, comment As String, seguridad As Integer, user As Int64)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", id))
            cmd.Parameters.Add(New SqlParameter("@DIS_DATE", Date.Now))
            cmd.Parameters.Add(New SqlParameter("@REASON", comment))
            cmd.Parameters.Add(New SqlParameter("@ALERT", seguridad))
            cmd.Parameters.Add(New SqlParameter("@USER", user))
            cmd.CommandText = "UDSP_EMPLOYEE_DISCHARGE"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function NUMERO_EXISTS_NSS_CURP(X As String) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("USUARIO_EXIST_NSS", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", X)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    If lector("ID_Emp").ToString = 0 Then
                        Return 0
                    Else
                        Return lector("ID_Emp").ToString
                    End If
                Else
                    Return 0
                End If
            End Using
        End Using

    End Function

    Public Function consulta_empleado(user As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Emp", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", user)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function



    'Catalogo________________________________________________________________________________________________________
    Public Function Catalogo(ByVal tipo As String, ByVal cond As String) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim dt As New DataTable()
            Dim cmd As New SqlCommand("CATALOGOS", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@TIPO", tipo)
            cmd.Parameters.AddWithValue("@CONDICION", cond)
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function S_catalago(ByVal cond As String, ByVal tipo As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT_CATALOGOS", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@TIPO", tipo)
            cmd.Parameters.AddWithValue("@CONDICION", cond)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("Descripcion").ToString()
            End If
        End Using
    End Function

    Public Function Add_Referencias(ByVal REF As Integer, SES_ID As Integer, NAME As String, OCUPATION As String, RELATIONSHIP As String, TIME As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@REF", REF))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", SES_ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@OCUPATION", OCUPATION))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", RELATIONSHIP))
            cmd.Parameters.Add(New SqlParameter("@TIME", TIME))
            cmd.CommandText = "UDSP_SES_REFERENCES"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_OtrosIngresos(ByVal INCOME_ID As Integer, SES_ID As Integer, DESC As String, AMOUNT As Double) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@INCOME_ID", INCOME_ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", SES_ID))
            cmd.Parameters.Add(New SqlParameter("@DESC", DESC))
            cmd.Parameters.Add(New SqlParameter("@AMOUNT", AMOUNT))
            cmd.CommandText = "UDSP_SES_OTHER_INCOMES"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_UDSP_EMPLOYEE_EVALUATION(ByVal ID As Integer, EMPLOYEE As Integer, STATUS As String, USER As Integer, ID_Codigo As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID_EE", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.Parameters.Add(New SqlParameter("@USER", USER))
            cmd.Parameters.Add(New SqlParameter("@ID_Codigo", ID_Codigo))
            cmd.CommandText = "UDSP_EMPLOYEE_EVALUATION"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_Family(ByVal FAM_ID As Integer, EMPLOYEE As Integer, TYPE As String, NAME As String, P_LASTNAME As String, M_LASTMANEM As String,
                                 NATIONALITY As String, BIRTHDATE As DateTime, GENDER As String, C_STATUS As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@FAM_ID", FAM_ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@TYPE", TYPE))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", P_LASTNAME))
            cmd.Parameters.Add(New SqlParameter("@M_LASTMANEM", M_LASTMANEM))
            cmd.Parameters.Add(New SqlParameter("@NATIONALITY", NATIONALITY))
            cmd.Parameters.Add(New SqlParameter("@BIRTHDATE", BIRTHDATE))
            cmd.Parameters.Add(New SqlParameter("@GENDER", GENDER))
            cmd.Parameters.Add(New SqlParameter("@C_STATUS", C_STATUS))
            cmd.CommandText = "UDSP_EMPLOYEE_FAMILY"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Sub Add_Image(ByVal EMPLOYEE As Integer, HOU_IMAGE As Image, EMP As Image)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim Imag As Byte()
            Imag = Imagen_Bytes(HOU_IMAGE)
            Dim ImagEmp As Byte()
            ImagEmp = Imagen_Bytes(EMP)
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@EMP_IMAGE", ImagEmp))
            cmd.Parameters.Add(New SqlParameter("@HOU_IMAGE", Imag))
            cmd.CommandText = "UDSP_EMPLOYEE_IMAGE"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Add_JOBHISTORY(ByVal PREV_ID As Integer, EMPLOYEE As Integer, START As DateTime, ENDD As DateTime, COMPANY As String, POSITION As String, WAGE As Decimal,
            PHONE As String, REASON As String, CONTACT As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@PREV_ID", PREV_ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@START", START))
            cmd.Parameters.Add(New SqlParameter("@END", ENDD))
            cmd.Parameters.Add(New SqlParameter("@COMPANY", COMPANY))
            cmd.Parameters.Add(New SqlParameter("@POSITION", POSITION))
            cmd.Parameters.Add(New SqlParameter("@WAGE", WAGE))
            cmd.Parameters.Add(New SqlParameter("@PHONE", PHONE))
            cmd.Parameters.Add(New SqlParameter("@REASON", REASON))
            cmd.Parameters.Add(New SqlParameter("@CONTACT", CONTACT))
            cmd.CommandText = "UDSP_EMPLOYEE_JOBHISTORY"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_MEDCONDITIONS(ByVal CON_ID As Integer, EMPLOYEE As Integer, DESCRIPTION As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@CON_ID", CON_ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.CommandText = "UDSP_EMPLOYEE_MEDCONDITIONS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_TRAINING(ByVal ID As Integer, TRAINING As Integer, EMPLOYEE As Integer, DATEE As DateTime) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@TRAINING", TRAINING))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@DATEE", DATEE))
            cmd.CommandText = "UDSP_EMPLOYEE_TRAINING"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_EQUIPMENT(ByVal EQU_ID As Integer, NAME As String, DESCRIPTION As String, COST As Double, STATUS As Integer) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EQU_ID", EQU_ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.Parameters.Add(New SqlParameter("@COST", COST))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.CommandText = "UDSP_EQUIPMENT"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_EQUIPMENT_ASSIGNED(ByVal ASSIGNED As Integer, EQUIPMENT As String, EMPLOYEE As Integer, DATEE As DateTime, ISRETURNED As Integer,
                                           DATE_R As DateTime, COMMENTS As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ASSIGNED", ASSIGNED))
            cmd.Parameters.Add(New SqlParameter("@EQUIPMENT", EQUIPMENT))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@DATE", DATEE))
            cmd.Parameters.Add(New SqlParameter("@ISRETURNED", ISRETURNED))
            cmd.Parameters.Add(New SqlParameter("@DATE_R", DATE_R))
            cmd.Parameters.Add(New SqlParameter("@COMMENTS", COMMENTS))
            cmd.CommandText = "UDSP_EQUIPMENT_ASSIGNED"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_EVALUATIONS(ByVal EVAL_ID As Integer, CODE As String, DESCRIPTION As String, STATUS As Integer) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EVAL_ID", EVAL_ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", CODE))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.CommandText = "UDSP_EVALUATIONS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_POSITIONS(ByVal POSITION As Integer, NAME As String, DESCRIPTION As String, RISK As Integer, ESTATUS As Integer) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@POSITION", POSITION))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.Parameters.Add(New SqlParameter("@RISK", RISK))
            cmd.Parameters.Add(New SqlParameter("@STATUS", ESTATUS))
            cmd.CommandText = "UDSP_POSITIONS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function


    Public Function Add_TRANINGS(ByVal ID As Integer, CODE As String, DESCRIPTION As String, STATUS As Integer) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", CODE))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.CommandText = "UDSP_TRANINGS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_USERS(ByVal ID As Integer, USERNAME As String, PASSWORD As String, ACTIVE As Integer, ACCESS As Integer) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@USERNAME", USERNAME))
            cmd.Parameters.Add(New SqlParameter("@PASSWORD", PASSWORD))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", ACTIVE))
            cmd.Parameters.Add(New SqlParameter("@ACCESS", ACCESS))
            cmd.CommandText = "UDSP_USERS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_SUPER(ByVal ID As Integer, ID_EMP As Integer, NAME As String, ESTATUS As Integer) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@ID_Emp", ID_EMP))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", ESTATUS))
            cmd.CommandText = "UDSP_EMPLOYEE_SUPER"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_TE(ByVal ID As Integer, CODE As String, DESC As String, ESTATUS As Integer) As Integer
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@CODE", CODE))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESC))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", ESTATUS))
            cmd.CommandText = "UDSP_EMPLOYEE_TYPE"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_CONTACTS(ByVal CONTACT As Integer, EMPLOYEE As Integer, NAME As String, P_LASTNAME As String, M_LASTNAME As String,
        RELATIONSHIP As String, PHONE As String, CELLPHONE As String) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@CONTACT", CONTACT))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", P_LASTNAME))
            cmd.Parameters.Add(New SqlParameter("@M_LASTNAME", M_LASTNAME))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", RELATIONSHIP))
            cmd.Parameters.Add(New SqlParameter("@PHONE", PHONE))
            cmd.Parameters.Add(New SqlParameter("@CELLPHONE", CELLPHONE))
            cmd.CommandText = "UDSP_EMPLOYEE_CONTACTS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_DEPTO(ID As Integer, ByVal CODIGO As String, DESCRIPCION As String, STATUS As Integer) As String
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.Parameters.Add(New SqlParameter("@CODIGO", CODIGO))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPCION", DESCRIPCION))
            cmd.CommandText = "UDSP_DEPTO"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Consulta_AnteLab(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_AnteLab", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function
    Public Function Consulta_CAPACITACION(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_CAPACITACION", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_CEmergencia(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_CEmergencia", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_EAsignado(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_EAsignado", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_ES(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_ES", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_Evaluaciones(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Evaluaciones", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_FamEsp(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_FamEsp", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_Enf(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Enf", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function


    Public Function Consulta_USER() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_users", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_depto() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_depto", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_Cap() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_CAP", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_EQ() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_EQ", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_EV() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_EV", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function


    Public Function Consulta_PU() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_PU", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_TE() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_TE", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_SU() As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_SU", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_FamHijos(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_FamHijos", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_OI(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_OI", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_REF(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_REF", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Consulta_Examenes_Medicos(ByVal ID As Integer) As DataTable
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Examenes_Medicos", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim dt As New DataTable()
            Dim DataAdapter As SqlDataAdapter
            DataAdapter = New SqlDataAdapter
            DataAdapter.SelectCommand = cmd
            DataAdapter.Fill(dt)
            Return dt
        End Using
    End Function

    Public Sub DELETE_CEMERGENCIA(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "Emp_CEmergencia"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub DELETE_Enfermedades(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_Enfermedades"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DELETE_EXAMENES_MEDICOS(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_EXAMENES_MEDICOS"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DELETE_Evaluaciones(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_Evaluaciones"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub DELETE_Familia(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_Familia"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Sub DELETE_CAPACITACION(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_CAPACITACION"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DELETE_OI(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_OI"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub DELETE_REF(ByVal ID As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.CommandText = "DELETE_REF"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
