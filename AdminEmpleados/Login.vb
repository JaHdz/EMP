Public Class Login
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Dim AUTENTICADO As Boolean = False
    Dim objcon As New Consultas

    Private Sub Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cerrar.Click
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

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
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
                Dim ObjEdit2 As New Principal With {
                    .NEmp = Convert.ToInt64(objcon.user),
                    .NName = objcon.name
                }
                If chkRecordar.Checked Then
                    If My.Settings.LastDate = Date.MinValue Then
                        My.Settings.Username = user.Text
                        My.Settings.Password = New Consultas().Encriptar(pass.Text)
                        My.Settings.LastDate = Now.ToShortDateString()
                        My.Settings.RememberMe = True
                        My.Settings.Save()
                    End If
                End If
                Wait.Close()
                Me.Hide()
                ObjEdit2.ShowDialog(Me)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Lnk_Password_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Password.LinkClicked
        Dim Wait As New wait()
        Wait.Show()
        Clear()
        If Not String.IsNullOrWhiteSpace(user.Text) Then
            Dim EmailAddress As String = New Consultas().GetEmail(user.Text)
            If EmailAddress IsNot Nothing Or Not String.IsNullOrWhiteSpace(EmailAddress) Then
                Dim Email As New Email
                Dim Code As String = Email.GenerateCode()
                If Email.Send(EmailAddress, "Solicitud para restaurar su contraseña", "SOLICITUD RECIBIDA EL DIA:",
                "Se ha solicitado restablecer su contraseña para ingresar al sistema EASY. Favor de ingresar el siguiente codigo en el campo correspondiente:",
                Code, Date.Now.ToShortDateString(), "Si usted no solicitó el cambio de contraseña haga caso omiso de este correo.") = "Success" Then
                    Using Consulta As New Consultas
                        Code = Consulta.Encriptar(Code)
                        Consulta.SetResetKey(user.Text, Code)
                    End Using

                    PnlResetKey.Visible = True
                    PnlLogin.Visible = False
                    PnlResetKey.Location = New Point(8, 128)
                End If
            Else
                ErrorProvider.SetError(user, "No se tiene registro para este usuario")
            End If
        Else
            ErrorProvider.SetError(user, "Para restaurar su contraseña debe ingresar su usuario y despues precionar 'Olvide Mi Contraseña'")
        End If
        Threading.Thread.Sleep(500)
        Wait.Close()
    End Sub

    Private Sub Clear()
        ErrorProvider.Clear()
        pass.Text = Nothing
        TxtCode.Text = Nothing
        TxtOlvPass1.Text = Nothing
        TxtOlvPass2.Text = Nothing
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.RememberMe = True Then
            Dim LastDate = CType(My.Settings.LastDate, Date)
            If LastDate <> Date.MinValue Then
                If DateDiff(DateInterval.Day, LastDate, Now) <= 30 Then
                    user.Text = My.Settings.Username
                    pass.Text = New Consultas().Desencriptar(My.Settings.Password)
                    chkRecordar.Checked = True
                Else
                    My.Settings.Username = ""
                    My.Settings.Password = ""
                    My.Settings.LastDate = Date.MinValue
                    My.Settings.RememberMe = False
                    My.Settings.Save()
                End If
            End If
        Else
            user.Text = ""
            pass.Text = ""
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If Not String.IsNullOrWhiteSpace(TxtCode.Text) Then
            Dim Code As String
            Using Consulta As New Consultas
                Code = Consulta.Encriptar(Trim(TxtCode.Text))
                If Consulta.ValidResetKey(user.Text, Code) Then
                    ErrorProvider.Clear()
                    Dim Wait As New wait()
                    Wait.Show()
                    PnlResetKey.Visible = False
                    PnlNewPassword.Visible = True
                    PnlNewPassword.Location = New Point(8, 128)
                    Threading.Thread.Sleep(500)
                    Wait.Close()
                Else
                    ErrorProvider.SetError(TxtCode, "Codigo invalido. Introduzca el codigo que se le envió a su correo.")
                End If
            End Using
        Else
            ErrorProvider.SetError(TxtCode, "Introduzca el codigo que se le envió a su correo.")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
        PnlResetKey.Visible = False
        PnlLogin.Visible = True
        PnlLogin.Location = New Point(8, 128)
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        If Not String.IsNullOrWhiteSpace(TxtOlvPass1.Text) Then
            If Not String.IsNullOrWhiteSpace(TxtOlvPass2.Text) Then
                If TxtOlvPass1.Text = TxtOlvPass2.Text Then
                    Using Consulta As New Consultas
                        Consulta.ResetPassword(user.Text, Consulta.Encriptar(TxtOlvPass1.Text))
                    End Using
                    Clear()
                    PnlNewPassword.Visible = False
                    PnlLogin.Visible = True
                    PnlLogin.Location = New Point(8, 128)
                Else
                    ErrorProvider.SetError(TxtOlvPass2, "Las contraseñas coinciden. Intente de nuevo.")
                    TxtOlvPass1.Text = ""
                    TxtOlvPass2.Text = ""
                End If
            Else
                ErrorProvider.SetError(TxtOlvPass2, "El campo no puede estar vacio.")
            End If
        Else
            ErrorProvider.SetError(TxtOlvPass1, "El campo no puede estar vacio.")
        End If

    End Sub

    Private Sub Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles pass.KeyDown, user.KeyDown, Me.KeyDown
        btn_login.PerformClick()
    End Sub
End Class