Public Enum BackgroundOperations
    JustShowScreen
    Login
    ResetPasswordEmail
    ValidateResetCode
    PasswordReset
    GetLatestEmployeeNumber
    EmployeeExits
    GetEmployeeInfo
    ValidateCURPandNSS
    ValidateEnPuSuTi
    ValidateReference
    AddReference
    GetReference
    ValidateIncome
    AddIncome
    GetIncome
    AddSocialEconomicStudy
    GetSocialEconomicStudy
    AddImage
    AddMedicalConditions
    GetMedicalConditions
    AddContact
    GetContact
    AddJobHistory
    GetJobHistory
    AddFamilyMember
    GetFamily
End Enum

Public Class Wait
    Public Operation As BackgroundOperations
    Public Result As New Object
    Public Parameters As Dictionary(Of String, Object)
    Private Sub wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dock = DockStyle.Fill
        TransparencyKey = Color.FromArgb(121, 121, 121)
        BwWait.RunWorkerAsync()
    End Sub

    Private Sub BwWait_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BwWait.DoWork
        Try
            Select Case Operation
                Case BackgroundOperations.Login
                    Result = New Consultas().Login(Parameters("Username"), Parameters("Password"))
                Case BackgroundOperations.ResetPasswordEmail
                    Dim EmailAddress As String = New Consultas().GetEmail(Parameters("Username"))
                    If EmailAddress IsNot Nothing Or Not String.IsNullOrWhiteSpace(EmailAddress) Then
                        Dim Email As New Email
                        Dim Code As String = Email.GenerateCode()
                        If Email.Send(EmailAddress, "Solicitud para restaurar su contraseña", "SOLICITUD RECIBIDA EL DIA:",
                            "Se ha solicitado restablecer su contraseña para ingresar al sistema EASY. Favor de ingresar el siguiente codigo en el campo correspondiente:",
                            Code, Date.Now.ToShortDateString(), "Si usted no solicitó el cambio de contraseña haga caso omiso de este correo.") = "Success" Then
                            Using Consulta As New Consultas
                                Code = Consulta.Encriptar(Code)
                                Consulta.SetResetKey(Parameters("Username"), Code)
                            End Using
                            Result = "Se le ha enviado un correo con un codigo que debera introducir en la siguiente pantalla."
                        Else
                            Result = "Hubo un problema, no se pudo enviar el correo. Intente mas tarde o notifique a su administrador."
                        End If
                    Else
                        Result = Nothing
                    End If
                Case BackgroundOperations.ValidateResetCode
                    Using Consulta As New Consultas
                        Result = Consulta.ValidResetKey(Parameters("Username"), Parameters("Code"))
                    End Using
                Case BackgroundOperations.PasswordReset
                    Using Consulta As New Consultas
                        Result = Consulta.ResetPassword(Parameters("Username"), Parameters("Password"))
                    End Using
                Case BackgroundOperations.GetLatestEmployeeNumber
                    Result = New Consultas().NUMERO_EMPLEADO()
                Case BackgroundOperations.EmployeeExits
                    Result = New Consultas().Emp_Exist(Parameters("EmployeeNumber"))
                Case BackgroundOperations.GetEmployeeInfo
                    Result = New Consultas().Consulta_empleado(Parameters("EmployeeNumber"))
                Case BackgroundOperations.ValidateCURPandNSS
                    Result = New Consultas().NUMERO_EXISTS_NSS_CURP(Parameters("CURPorNSS"))
                Case BackgroundOperations.ValidateEnPuSuTi
                    Result = New Consultas().S_catalago(Parameters("Field"), Parameters("Type"))
                Case BackgroundOperations.ValidateReference
                    Dim ResultDictionary As New Dictionary(Of String, Object) From {{"Valid", New Consultas().Add_Referencias(Parameters("REFID"), Parameters("ES"),
                        Parameters("Name"), Parameters("Ocupation"), Parameters("Relationship"), Parameters("Time"))}, {"Source", New Consultas().Consulta_REF(Parameters("ES"))}}
                    Result = ResultDictionary
                Case BackgroundOperations.AddReference
                    Result = New Consultas().Add_Referencias(0, Parameters("ES"), Parameters("Name"), Parameters("Ocupation"), Parameters("Relationship"), Parameters("Time"))
                Case BackgroundOperations.ValidateIncome
                    Dim ResultDictionary As New Dictionary(Of String, Object) From {{"Valid", New Consultas().Add_OtrosIngresos(Parameters("ICMID"), Parameters("ES"),
                        Parameters("Relationship"), Parameters("Amount"))}, {"Source", New Consultas().Consulta_OI(Parameters("ES"))}}
                    Result = ResultDictionary
                Case BackgroundOperations.AddIncome
                    Result = New Consultas().Add_OtrosIngresos(0, Parameters("ES"), Parameters("Relationship"), Parameters("Amount"))
                Case BackgroundOperations.AddSocialEconomicStudy
                    Dim Consultas As New Consultas()
                    Result = Consultas.Add_ES(Parameters("ES"))
                Case BackgroundOperations.AddImage
                    Dim Consultas As New Consultas()
                    Consultas.Add_Image(Parameters("Employee"), Parameters("HousePicture"), Parameters("EmployeePicture"))
                Case BackgroundOperations.AddMedicalConditions
                    Result = New Consultas().Add_MEDCONDITIONS(0, Parameters("Employee"), Parameters("Condition"))
                Case BackgroundOperations.AddContact
                    Result = New Consultas().Add_CONTACTS(0, Parameters("Employee"), Parameters("Name"), Parameters("FLastname"), Parameters("SLastname"),
                                                          Parameters("Relationship"), Parameters("Phone"), Parameters("Cellphone"))
                Case BackgroundOperations.AddJobHistory
                    Result = New Consultas().Add_JOBHISTORY(0, Parameters("Employee"), Parameters("Start"), Parameters("End"), Parameters("Company"), Parameters("Position"),
                                                           Parameters("Wage"), Parameters("Phone"), Parameters("Reason"), Parameters("Contact"))
                Case BackgroundOperations.AddFamilyMember
                    Result = New Consultas().Add_Family(0, Parameters("Employee"), Parameters("Type"), Parameters("Name"), Parameters("FLastname"), Parameters("SLastname"),
                                                        Parameters("Nationality"), Parameters("Birthday"), Parameters("Sex"))
                Case BackgroundOperations.GetFamily
                    Dim ResultDictionary As New Dictionary(Of String, Object) From {{"Spouse", New Consultas().Consulta_FamEsp(Parameters("Employee"))},
                        {"Offsprings", New Consultas().Consulta_FamHijos(Parameters("Employee"))}}
                    Result = ResultDictionary
                Case BackgroundOperations.GetJobHistory
                    Result = New Consultas().Consulta_AnteLab(Parameters("Employee"))
                Case BackgroundOperations.GetContact
                    Result = New Consultas().Consulta_CEmergencia(Parameters("Employee"))
                Case BackgroundOperations.GetMedicalConditions
                    Result = New Consultas().Consulta_Enf(Parameters("Employee"))
                Case BackgroundOperations.GetSocialEconomicStudy
                    Result = New Consultas().Consulta_ES(Parameters("Employee"))
                Case BackgroundOperations.GetIncome
                    Result = New Consultas().Consulta_OI(Parameters("ES"))
                Case BackgroundOperations.GetReference
                    Result = New Consultas().Consulta_REF(Parameters("ES"))
            End Select
        Catch ex As Exception
        Result = Nothing
        End Try
    End Sub

    Private Sub BwWait_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BwWait.RunWorkerCompleted
        Threading.Thread.Sleep(500)
        Hide()
    End Sub
End Class