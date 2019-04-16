
Imports System.Deployment.Application

Public Class Principal
    Public NEmp As String
    Public NName As String
    Public ObLogout As Boolean = False
    Private Dictionary As Dictionary(Of Integer, Form)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(EmpNumber As Integer, EmpName As String)
        MyClass.New()
        NEmp = EmpNumber
        NName = EmpName
        LoadHeader()
        LoadMenu()
    End Sub
    Private Sub LoadHeader()
        If Debugger.IsAttached Then
            Text = "EASY - Employee Administrator System     --Development Mode--"
        Else
            Text = "EASY - Employee Administrator System v" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If
        lbl_user.Text = NEmp + " | " + NName
    End Sub

    Public Sub LoadMenu()
        Dictionary = New Dictionary(Of Integer, Form)
        For i = 1 To 6
            Dim f As New Form
            Select Case i
                Case 1
                    f = New Empleados(NEmp, NName) With {.TopLevel = False, .AutoSize = True}
                Case 2
                    f = New Equipo(NEmp, NName) With {.TopLevel = False, .AutoSize = False}
                Case 3
                    f = New Capacitaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
                Case 4
                    f = New Evaluaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
                Case 5
                    f = New Examenes_Medicos(NEmp) With {.TopLevel = False, .AutoSize = False}
                Case 6
                    f = New Administration(NEmp) With {.TopLevel = False, .AutoSize = False}
            End Select
            Dictionary.Add(i, f)
        Next
        Elmhst.Child = New CstmTabControl(Dictionary) With {.ParentForm = Me, .RedirectToForm = New Login}
    End Sub


    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ObLogout Then
            Dim FormCount = Application.OpenForms.Count - 1
            For index = 0 To FormCount
                Dim frm As Form = Application.OpenForms(FormCount - index)
                If frm IsNot Me Then
                    frm.Close()
                End If
            Next
        End If
    End Sub
End Class
