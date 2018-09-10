Public Class Login
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Dim AUTENTICADO As Boolean = False
    Dim objcon As New Consultas

    Private Sub cerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cerrar.Click
        Me.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If user.Text = "" Or pass.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            Dim Wait As New wait()
            Wait.Show()
            Application.DoEvents()
            AUTENTICADO = objcon.Autenticar(user.Text, pass.Text)
            If AUTENTICADO = False Then
                Wait.Close()
                MessageBox.Show("Datos incorrectos")
            Else
                Dim ObjEdit2 As New Main(Convert.ToInt64(objcon.user), objcon.name)
                Wait.Close()
                Me.Hide()
                ObjEdit2.ShowDialog(Me)
                Me.Close()
            End If
        End If
    End Sub
End Class