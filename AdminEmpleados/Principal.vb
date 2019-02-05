
Public Class Principal
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Public NEmp As String
    Public NName As String
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_emp.PerformClick()
        lbl_user.Text = NEmp + " | " + NName
    End Sub

    Private Sub Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseMove
        If bit Then
            Me.WindowState = FormWindowState.Normal
            If Me.Left + e.X - X >= 0 AndAlso Me.Top + e.Y - Y > 10 Then
                Me.Location = New Point(Me.Left + e.X - X, Me.Top + e.Y - Y)
            Else
                Me.Location = New Point(Me.Left + e.X - X, 10)
            End If
        End If
    End Sub

    Private Sub header_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseDown
        bit = True
        X = e.X
        Y = e.Y
    End Sub

    Private Sub header_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseUp
        bit = False
    End Sub

    Private Sub Min_Click(ByVal sender As Object, ByVal e As EventArgs) Handles min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_emp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_emp.Click
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Empleados(NEmp, NName) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
        SelectButton(sender)
    End Sub

    Private Sub BTN_EQ_Click(sender As Object, e As EventArgs) Handles BTN_EQ.Click
        SelectButton(sender)
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Equipo(NEmp, NName) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()

    End Sub

    Private Sub BTN_CAP_Click(sender As Object, e As EventArgs) Handles BTN_CAP.Click
        SelectButton(sender)
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Capacitaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()

    End Sub

    Private Sub BTN_EV_Click(sender As Object, e As EventArgs) Handles BTN_EV.Click
        SelectButton(sender)
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Evaluaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()

    End Sub

    Private Sub BTN_MED_Click(sender As Object, e As EventArgs) Handles BTN_MED.Click
        SelectButton(sender)
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Examenes_Medicos(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()

    End Sub

    Private Sub BTN_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_ADMIN.Click
        SelectButton(sender)
        Dim Wait As Wait = New Wait()
        Wait.Show()
        'Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Administration(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()

    End Sub

    Private Sub SelectButton(btn As Button)
        For Each ctrl As Control In Menu.Controls
            If TypeOf ctrl Is Button Then
                If ctrl.Name <> btn.Name Then
                    ctrl.BackColor = Color.FromArgb(207, 209, 210)
                    ctrl.Font = New Font(ctrl.Font, FontStyle.Regular)
                Else
                    ctrl.BackColor = SystemColors.Control
                    ctrl.Font = New Font(ctrl.Font, FontStyle.Bold)
                End If
            End If

        Next
    End Sub


End Class
