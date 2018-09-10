
Public Class Main
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Public NEmp As String
    Public NName As String

    Private Sub cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Sub New(ByVal emp As Integer, ByVal name As String)
        InitializeComponent()
        NEmp = emp
        NName = name
        lbl_user.Text = lbl_user.Text = " | " + NName
    End Sub

    Private Sub header_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseMove
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

    Private Sub min_Click(ByVal sender As Object, ByVal e As EventArgs) Handles min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_emp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_emp.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Empleados(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub

    Private Sub cerrar_Click_1(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub BTN_EQ_Click(sender As Object, e As EventArgs) Handles BTN_EQ.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Equipo(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub

    Private Sub BTN_CAP_Click(sender As Object, e As EventArgs) Handles BTN_CAP.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Capacitaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub

    Private Sub BTN_EV_Click(sender As Object, e As EventArgs) Handles BTN_EV.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Evaluaciones(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub

    Private Sub BTN_MED_Click(sender As Object, e As EventArgs) Handles BTN_MED.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Examenes_Medicos(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub

    Private Sub BTN_ADMIN_Click(sender As Object, e As EventArgs) Handles BTN_ADMIN.Click
        Dim Wait As wait = New wait()
        Wait.Show()
        Application.DoEvents()
        If PNL_INFO.Controls.Count > 0 Then
            PNL_INFO.Controls.RemoveAt(PNL_INFO.Controls.Count - 1)
        End If
        Dim f As New Admin(NEmp) With {.TopLevel = False, .AutoSize = False}
        PNL_INFO.Controls.Add(f)
        f.Show()
        Wait.Close()
    End Sub
End Class
