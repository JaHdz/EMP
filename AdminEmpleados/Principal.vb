
Imports System.Deployment.Application

Public Class Principal
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Public NEmp As String
    Public NName As String
    Private CurrentMenu As New Dictionary(Of String, Form)
    Private SelectedOption As String = ""
    Private CurrentOption As String = ""
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Debugger.IsAttached Then
            Text = "EASY - Employee Administrator System     --Development Mode--"
        Else
            Text = "EASY - Employee Administrator System v" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If
        LoadMenu()
        Dim x = Pnl_Info.Controls
        SelectedOption = "Empleados"
        btn_emp.PerformClick()
        lbl_user.Text = NEmp + " | " + NName
    End Sub

    Private Sub Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If bit Then
            Me.WindowState = FormWindowState.Normal
            If Me.Left + e.X - X >= 0 AndAlso Me.Top + e.Y - Y > 10 Then
                Me.Location = New Point(Me.Left + e.X - X, Me.Top + e.Y - Y)
            Else
                Me.Location = New Point(Me.Left + e.X - X, 10)
            End If
        End If
    End Sub

    Private Sub header_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        bit = True
        X = e.X
        Y = e.Y
    End Sub

    Private Sub header_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        bit = False
    End Sub

    Private Sub Min_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoadMenu()
        For i = 0 To 5
            Dim f As New Form
            Dim fName As String = ""
            Select Case i
                Case 0
                    f = New Empleados(NEmp, NName) With {.TopLevel = False, .AutoSize = False}
                    fName = "Empleados"
                Case 1
                    f = New Equipo(NEmp, NName) With {.TopLevel = False, .AutoSize = False}
                    fName = "Equipo"
                Case 2
                    f = New Capacitaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
                    fName = "Capacitaciones"
                Case 3
                    f = New Evaluaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
                    fName = "Evaluaciones"
                Case 4
                    f = New Examenes_Medicos(NEmp) With {.TopLevel = False, .AutoSize = False}
                    fName = "Examenes_Medicos"
                Case 5
                    f = New Administration(NEmp) With {.TopLevel = False, .AutoSize = False}
                    fName = "Administration"
            End Select
            CurrentMenu.Add(fName, f)
            Pnl_Info.Controls.Add(f)
        Next
    End Sub

    Private Sub MenuShow()
        If SelectedOption <> CurrentOption Then
            CurrentMenu(SelectedOption).Show()
            Try
                CurrentMenu(CurrentOption).Hide()
            Catch
            End Try
            CurrentOption = SelectedOption
            SelectedOption = ""
        End If
    End Sub

    Private Sub SelectButton(btn As Button)
        For Each ctrl As Control In Menu.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name <> btn.Name Then
                    ctrl.BackColor = Color.FromArgb(207, 209, 210)
                    'ctrl.Font = New Font(ctrl.Font, FontStyle.Regular)
                Else
                    ctrl.BackColor = SystemColors.Control
                    'ctrl.Font = New Font(ctrl.Font, FontStyle.Bold)
                End If
            End If

        Next
    End Sub

    Private Sub MenuOptionClick(ByVal sender As Object, ByVal e As EventArgs) Handles btn_emp.Click, BTN_MED.Click, BTN_EV.Click, BTN_EQ.Click, BTN_CAP.Click, BTN_ADMIN.Click
        Dim Wait As Wait = New Wait()
        Wait.Show()
        SelectedOption = CType(sender, Button).Tag
        MenuShow()
        SelectButton(sender)
        Wait.Close()
    End Sub

    Private Sub BTN_CERRARSESION_Click(sender As Object, e As EventArgs) Handles BTN_CERRARSESION.Click
        If MessageBox.Show("¿Desea cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Dim Login As New Login
            Login.Show()
            Close()
        End If
    End Sub


End Class
