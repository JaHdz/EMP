
Imports System.Deployment.Application

Public Class frmPrincipal
    Public ObLogout As Boolean = False
    Private Dictionary As Dictionary(Of Integer, Form)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        LoadHeader()
        LoadMenu()
    End Sub
    Private Sub LoadHeader()
        If Debugger.IsAttached Then
            Text = "EASY - Employee Administrator System     --Development Mode--"
        Else
            Text = "EASY - Employee Administrator System v" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If
        lbl_user.Text = UsuarioLogeado.NumeroDeEmpleado.ToString() + " | " + UsuarioLogeado.Nombre
    End Sub

    Public Sub LoadMenu()
        Dictionary = New Dictionary(Of Integer, Form)
        For i = 1 To 6
            Dim f As New Form
            Select Case i
                Case 1
                    f = New frmEmpleados() With {.TopLevel = False, .AutoSize = True}
                Case 2
                    f = New FrmEquipo() With {.TopLevel = False, .AutoSize = False}
                Case 3
                    f = New frmCapacitaciones() With {.TopLevel = False, .AutoSize = False}
                Case 4
                    f = New frmEvaluaciones() With {.TopLevel = False, .AutoSize = False}
                Case 5
                    f = New frmExamenesMedicos() With {.TopLevel = False, .AutoSize = False}
                Case 6
                    f = New frmAdministration() With {.TopLevel = False, .AutoSize = False}
            End Select
            Dictionary.Add(i, f)
        Next
        Elmhst.Child = New CstmTabControl(Dictionary) With {.ParentForm = Me, .RedirectToForm = New frmLogin}
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
