Imports System.Data.SqlClient
Imports System.IO

Public Class Consultas
    Implements IDisposable

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

    Public Function Login(sUsr As String, sPass As String) As Dictionary(Of String, String)
        Dim lector As SqlDataReader
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SP_UserandPass"
            cmd.Parameters.AddWithValue("@user", sUsr)
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                If Encriptar(sPass) = lector("pass").ToString Then
                    Dim Result As New Dictionary(Of String, String) From {{"User", lector("NoEmp").ToString}, {"Name", lector("Nom").ToString}}
                    Return Result
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Function Encriptar(ByVal Pass As String) As String
        Dim Clave As String = "%ü&/@#$A"
        Dim Pass2 = ""
        For i = 1 To Len(Pass)
            Dim CAR = Mid(Pass, i, 1)
            Dim Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Return Pass2
    End Function

    Public Function Desencriptar(ByVal Pass As String) As String
        Dim Clave As String = "%ü&/@#$A"
        Dim Pass2 = ""
        Dim j = 1
        For i = 1 To Len(Pass) Step 2
            Dim CAR = Mid(Pass, i, 2)
            Dim Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        Return Pass2
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
            cmd.Parameters.Add(New SqlParameter("@CITYSTATE", infoEmp.Emp_Domicilio))
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
        NUMERO_EMPLEADO = 0
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Ultimo_Emp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return lector(0)
                End If
            End Using
        End Using
    End Function

    Public Function Emp_Exist(ByVal user As Integer) As Boolean
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Emp", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", user)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return 1
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
        Add_Examenes_Medicos = String.Empty
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

    Public Sub Bajas(ByVal id As String, ACTIVO As Integer, comment As String, seguridad As Integer, user As Int64, PROV As Integer, CLIENTE As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@DISCHARGE", 0))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", id))
            cmd.Parameters.Add(New SqlParameter("@DIS_DATE", Date.Now))
            cmd.Parameters.Add(New SqlParameter("@REASON", comment))
            cmd.Parameters.Add(New SqlParameter("@ALERT", seguridad))
            cmd.Parameters.Add(New SqlParameter("@USER", user))
            cmd.Parameters.Add(New SqlParameter("@PROV", PROV))
            cmd.Parameters.Add(New SqlParameter("@CLIENTE", CLIENTE))
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
                    Return lector("ID_Emp")
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    Public Function Consulta_empleado(user As Integer) As Cls_Emp
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("CONSULTA_EMP", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", user)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Dim loBaja As New Cls_Bajas With {
                        .Fecha_Baja = If(IsDBNull(lector("Fecha_Baja")), Date.MinValue, lector("Fecha_Baja")),
                        .Alerta = If(IsDBNull(lector("Alerta").ToString()), False, True),
                        .Motivo = lector("Motivo").ToString(),
                        .NotificarProveedores = If(IsDBNull(lector("NProv")), False, lector("NProv")),
                        .NotificarClientes = If(IsDBNull(lector("NClientes")), False, lector("NClientes"))
                    }
                    Dim Employee As New Cls_Emp With {
                        .Emp_APat = lector("Emp_APat"),
                        .Emp_AMat = lector("Emp_AMat"),
                        .Emp_Name = lector("Emp_Name"),
                        .Emp_NEducativo = lector("Emp_NEducativo"),
                        .Emp_FNac = lector("Emp_FNac"),
                        .Emp_RFC = lector("Emp_RFC"),
                        .Emp_NSS = lector("Emp_NSS"),
                        .Emp_Curp = lector("Emp_Curp"),
                        .Emp_Cel = lector("Emp_Cel"),
                        .Emp_Tel = lector("Emp_Tel"),
                        .Emp_EdoCivil = lector("Emp_EdoCivil"),
                        .Emp_Nacionalidad = lector("Emp_Nacionalidad"),
                        .Emp_Domicilio = lector("Emp_Domicilio"),
                        .Emp_Col = lector("Emp_Col"),
                        .Emp_CiudadEstado = lector("Emp_CiudadEstado"),
                        .Emp_CP = lector("Emp_CP"),
                        .Emp_FEfectiva = lector("Emp_FEfectiva"),
                        .Emp_Salario = lector("Emp_Salario"),
                        .Emp_Email = lector("Emp_Email"),
                        .Emp_Activo = lector("Emp_Activo"),
                        .Emp_Sup = lector("Emp_Sup"),
                        .Emp_EN = lector("Emp_EN"),
                        .ID_Puesto = lector("ID_Puesto"),
                        .Emp_Tipo = lector("Emp_Tipo"),
                        .Emp_Ciudad = lector("Emp_Ciudad"),
                        .ID_Depto = lector("ID_Depto"),
                        .Emp_Sexo = lector("Emp_Sexo"),
                        .ID_User = lector("ID_User"),
                        .ID_Emp = lector("ID_Emp"),
                        .Emp_FAlta = lector("Emp_FAlta"),
                        .Baja = loBaja
                    }
                    If (lector("Img_Emp").ToString() Is Nothing Or lector("Img_Emp").ToString() = "") Then
                        Employee.Img = My.Resources.photoNobody120
                    Else
                        Dim bytes As Byte() = lector("Img_Emp")
                        Dim ms As New MemoryStream(bytes)
                        Employee.Img = Image.FromStream(ms)
                    End If
                    Return Employee
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Sub Add_commen(user As Integer, text As String)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID_Emp", user))
            cmd.Parameters.Add(New SqlParameter("@Observaciones", text))
            cmd.Parameters.Add(New SqlParameter("@Fecha", Date.Now))
            cmd.CommandText = "UDSP_OBSERVACIONES"
            cmd.ExecuteNonQuery()
        End Using
    End Sub



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
        S_catalago = String.Empty
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
        Add_Referencias = String.Empty
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
        Add_OtrosIngresos = String.Empty
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
        Add_UDSP_EMPLOYEE_EVALUATION = String.Empty
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
                                 NATIONALITY As String, BIRTHDATE As DateTime, GENDER As String) As String
        Add_Family = String.Empty
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
        Add_JOBHISTORY = String.Empty
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
        Add_MEDCONDITIONS = String.Empty
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

    Public Function Add_TRAINING(ByVal ID As Integer, TRAINING As String, EMPLOYEE As Integer, DATEE As DateTime, COME As String) As String
        Add_TRAINING = String.Empty
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@TRAINING", TRAINING))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@DATE", DATEE))
            cmd.Parameters.Add(New SqlParameter("@COMENTARIO", COME))
            cmd.CommandText = "UDSP_EMPLOYEE_TRAINING"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_EQUIPMENT(ByVal EQU_ID As Integer, NAME As String, DESCRIPTION As String, COST As Double, STATUS As Integer, DEPTO As Integer) As String
        Add_EQUIPMENT = String.Empty
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@EQU_ID", EQU_ID))
            cmd.Parameters.Add(New SqlParameter("@NAME", NAME))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPTION))
            cmd.Parameters.Add(New SqlParameter("@COST", COST))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.Parameters.Add(New SqlParameter("@DEPTO", DEPTO))
            cmd.CommandText = "UDSP_EQUIPMENT"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function DELETE_EQUIPMENT_ADMIN(EQU_ID As Integer) As Boolean
        DELETE_EQUIPMENT_ADMIN = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_EQUIPMENT_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", EQU_ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function
    Public Function Add_EQUIPMENT_ASSIGNED(ByVal ASSIGNED As Integer, EQUIPMENT As String, EMPLOYEE As Integer, DATEE As DateTime, ISRETURNED As Integer,
                                           DATE_R As DateTime, USER As Integer, COMMENTS As String) As String
        Add_EQUIPMENT_ASSIGNED = String.Empty
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ASSIGNED", ASSIGNED))
            cmd.Parameters.Add(New SqlParameter("@EQUIPMENT", EQUIPMENT))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", EMPLOYEE))
            cmd.Parameters.Add(New SqlParameter("@DATE", DATEE))
            cmd.Parameters.Add(New SqlParameter("@ISRETURNED", ISRETURNED))
            cmd.Parameters.Add(New SqlParameter("@COMMENTS", COMMENTS))
            cmd.Parameters.Add(New SqlParameter("@DATE_R", DATE_R))
            cmd.Parameters.Add(New SqlParameter("@USER", USER))
            cmd.CommandText = "UDSP_EQUIPMENT_ASSIGNED"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_EVALUATIONS(ByVal EVAL_ID As Integer, CODE As String, DESCRIPTION As String, STATUS As Integer) As String
        Add_EVALUATIONS = String.Empty
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

    Public Function DELETE_ADMIN_EVALUATIONS(EV_ID As String) As Boolean
        DELETE_ADMIN_EVALUATIONS = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_EVALUATION_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", EV_ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function

    Public Function Add_POSITIONS(ByVal POSITION As Integer, NAME As String, DESCRIPTION As String, RISK As Integer, ESTATUS As Integer) As String
        Add_POSITIONS = String.Empty
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

    Public Function DELETE_ADMIN_POSITIONS(ID As Integer) As Boolean
        DELETE_ADMIN_POSITIONS = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_POSITIONS_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function

    Public Function Add_TRANINGS(ByVal ID As Integer, CODE As String, DESCRIPTION As String, STATUS As Integer) As String
        Add_TRANINGS = String.Empty
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

    Public Function Add_USERS(ByVal ID As Integer, USERNAME As String, PASSWORD As String, ACTIVE As Integer, ACCESS As Integer, EMP As Integer) As String
        Add_USERS = String.Empty
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@USERNAME", USERNAME))
            cmd.Parameters.Add(New SqlParameter("@PASSWORD", PASSWORD))
            cmd.Parameters.Add(New SqlParameter("@ACTIVE", ACTIVE))
            cmd.Parameters.Add(New SqlParameter("@ACCESS", ACCESS))
            cmd.Parameters.Add(New SqlParameter("@ID_EMP", EMP))
            cmd.CommandText = "UDSP_USERS"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function Add_SUPER(ByVal ID As Integer, ID_EMP As Integer, NAME As String, ESTATUS As Integer) As String
        Add_SUPER = String.Empty
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

    Public Function DELETE_ADMIN_SUPER(ID As Integer) As Boolean
        DELETE_ADMIN_SUPER = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_SUPERVISOR_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function

    Public Function Add_TE(ByVal ID As Integer, CODE As String, DESC As String, ESTATUS As Integer) As String
        Add_TE = String.Empty
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

    Public Function DELETE_ADMIN_TE(ID As Integer) As Boolean
        DELETE_ADMIN_TE = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_EMPTYPE_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function

    Public Function Add_CONTACTS(ByVal CONTACT As Integer, EMPLOYEE As Integer, NAME As String, P_LASTNAME As String, M_LASTNAME As String,
        RELATIONSHIP As String, PHONE As String, CELLPHONE As String) As String
        Add_CONTACTS = String.Empty
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
            Add_DEPTO = String.Empty
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@STATUS", STATUS))
            cmd.Parameters.Add(New SqlParameter("@CODIGO", CODIGO))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", DESCRIPCION))
            cmd.CommandText = "UDSP_DEPTO"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Return lector("RESULT").ToString()
            End If
        End Using
    End Function

    Public Function DELETE_DEPTO_ADMIN(ID As Integer) As Boolean
        DELETE_DEPTO_ADMIN = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_DEPTO_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
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

    Public Function Consulta_ES(ByVal ID As Integer) As Cls_ES
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Consulta_ES", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                Dim SES As New Cls_ES With
                {
                    .SES_ID = lector("ID_EstSocio"),
                    .EMP_ID = lector("ID_Emp"),
                    .H_TYPE = lector("Viv_Tipo"),
                    .H_CONDITION = lector("Viv_Condiciones"),
                    .H_ELEC = lector("Viv_Luz"),
                    .H_PHONE = lector("Viv_Luz"),
                    .H_WATER = lector("Viv_Agua"),
                    .H_SEWER = lector("Viv_Drenaje"),
                    .H_GAS = lector("Viv_TubGas"),
                    .H_TRASHREC = lector("Viv_RecBasura"),
                    .H_CABLETV = lector("Viv_TVCable"),
                    .H_INTERNET = lector("Viv_Internet"),
                    .H_SECURITY = lector("Viv_SisSeg"),
                    .T_METRO = lector("Trasn_Metro"),
                    .T_PUBLIC = lector("Trans_Publico"),
                    .T_TAX = lector("Trans_Taxi"),
                    .T_CAR = lector("Trans_VehPropio"),
                    .A_SOCIAL = lector("Act_EvSociales"),
                    .A_COMUNITARY = lector("Act_EvCominitarios"),
                    .A_MUSEUMS = lector("Act_Museos"),
                    .A_THEATERS = lector("Act_Teatros"),
                    .A_MOVIES = lector("Act_Cines"),
                    .A_FESTIVALS = lector("Act_FesCulturaes"),
                    .A_ARCHE = lector("Act_ZonasArq"),
                    .A_VACATIONS = lector("Act_Vaciones"),
                    .A_PLAZAS = lector("Act_PlazasPub"),
                    .A_NPARK = lector("Act_ParquesNat"),
                    .A_APARK = lector("Act_PaquesDiv"),
                    .FS_RENT = lector("GF_Renta"),
                    .FS_SCHOOL = lector("GF_Colegio"),
                    .FS_GROCERIES = lector("GF_Despensa"),
                    .FS_SERVICES = lector("GF_Servicios"),
                    .SES_HOBBIES = lector("ES_Pasatiempos"),
                    .SES_RELIGION = lector("ES_Religion"),
                    .SES_VERIFIER = lector("ES_Verificador"),
                    .SES_OBSERVATIONS = lector("ES_Observaciones")
                }
                If (lector("Img_Dom").ToString() Is Nothing Or lector("Img_Dom").ToString() = "") Then
                    SES.IMG = My.Resources.AddImage
                Else
                    Dim bytes As Byte() = lector("Img_Dom")
                    Dim ms As New MemoryStream(bytes)
                    SES.IMG = Image.FromStream(ms)
                End If
                Return SES
            Else
                Return Nothing
            End If
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
            cmd.CommandText = "DELETE_CEMERGENCIA"
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

    Public Function DELETE_CAPACITACION_ADMIN(ByVal ID As Integer) As Boolean
        DELETE_CAPACITACION_ADMIN = False
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("DELETE_CAPACITACION_ADMIN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", ID)
            Using lector As SqlDataReader = cmd.ExecuteReader()
                If lector.Read() Then
                    Return Convert.ToBoolean(lector(0))
                End If
            End Using
        End Using
    End Function

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

    Public Function GetEmail(Username As String) As String
        GetEmail = Nothing
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@USERNAME", Username))
            cmd.CommandText = "SP_GETUSEREMAIL"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                GetEmail = lector("EMP_EMAIL").ToString()
            End If
        End Using
    End Function

    Public Sub SetResetKey(Username As String, Resetkey As String)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@USERNAME", Username))
            cmd.Parameters.Add(New SqlParameter("@RESETKEY", Resetkey))
            cmd.CommandText = "SP_SETRESETKEY"
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ValidResetKey(Username As String, Resetkey As String) As Boolean
        ValidResetKey = New Boolean
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@USERNAME", Username))
            cmd.Parameters.Add(New SqlParameter("@RESETKEY", Resetkey))
            cmd.CommandText = "SP_VALIDRESETKEY"
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader()
            If lector.Read() Then
                ValidResetKey = Convert.ToBoolean(lector("RESULT"))
            End If
        End Using
    End Function

    Public Function ResetPassword(Username As String, Password As String) As String
        Try
            Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = con.CreateCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@USERNAME", Username))
                cmd.Parameters.Add(New SqlParameter("@PASSWORD", Password))
                cmd.CommandText = "SP_RESETPASSWORD"
                cmd.ExecuteNonQuery()
                Return "Su contraseña ha sido cambiada con exito."
            End Using
        Catch ex As Exception
            Return "Hubo un problema al intentar restablecer su contraseña, intente de nuevo o contacte a su administrador."
        End Try
    End Function
    Public Sub DELETE_ANTE(id As Integer)
        Using con As New SqlConnection(My.Settings.EmpleadosDBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = con.CreateCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@ID", id))
            cmd.CommandText = "DELETE_ANTE"
            cmd.ExecuteNonQuery()
        End Using
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub



    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
