Public Class frmLogin
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer

    Private Usuario As Usuario
    'Dim objcon As New Consultas

    Private Sub Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cerrar.Click
        Application.Exit()
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

    Private Sub Header_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseDown
        bit = True
        X = e.X
        Y = e.Y
    End Sub

    Private Sub Header_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles header.MouseUp
        bit = False
    End Sub

    Private Sub min_Click(ByVal sender As Object, ByVal e As EventArgs) Handles min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.RememberMe = True Then
            Dim LastDate = My.Settings.LastDate
            If LastDate <> Date.MinValue Then
                If DateDiff(DateInterval.Day, LastDate, Now) <= 30 Then
                    user.Text = My.Settings.Username
                    pass.Text = Decrypt(My.Settings.Password)
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

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Usuario = New Usuario(0, 0, user.Text, Encrypt(pass.Text), 1, 1, "", "")
        If Usuario.IniciarSesion() Then
            If chkRecordar.Checked Then
                If My.Settings.LastDate = Date.MinValue Then
                    My.Settings.Username = user.Text
                    My.Settings.Password = Encrypt(pass.Text)
                    My.Settings.LastDate = Now.ToShortDateString()
                    My.Settings.RememberMe = True
                    My.Settings.Save()
                End If
            Else
                My.Settings.Username = Nothing
                My.Settings.Password = Nothing
                My.Settings.LastDate = Nothing
                My.Settings.RememberMe = False
                My.Settings.Save()
            End If
            CargarCatalogos()
            Dim Main As New frmPrincipal()
            Main.Show()
            Close()
        End If
    End Sub

    Private Sub Clear()
        ErrorProvider.Clear()
        pass.Text = Nothing
        TxtCode.Text = Nothing
        TxtOlvPass1.Text = Nothing
        TxtOlvPass2.Text = Nothing
    End Sub

    Private Sub Lnk_Password_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Password.LinkClicked
        Clear()
        Usuario = New Usuario(0, 0, user.Text, pass.Text, Nothing, Nothing, "", "")
        If Usuario.SolicitarCambioDeContraseña() Then
            PnlResetKey.Visible = True
            PnlLogin.Visible = False
            PnlResetKey.Location = New Point(8, 128)
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If Usuario.ValidarCodigoDeRestauracion(Encrypt(Trim(TxtCode.Text))) Then
            PnlResetKey.Visible = False
            PnlNewPassword.Visible = True
            PnlNewPassword.Location = New Point(8, 128)
        End If
        'If Not String.IsNullOrWhiteSpace(TxtCode.Text) Then
        '    Dim ldParameters As New Dictionary(Of String, Object) From {{"Username", user.Text}, {"Code", New Consultas().Encriptar(Trim(TxtCode.Text))}}
        '    Dim Wait As New Wait With {
        '        .Parameters = ldParameters,
        '        .Operation = BackgroundOperations.ValidateResetCode
        '    }
        '    Wait.ShowDialog()
        '    If Wait.Result = True Then
        '        ErrorProvider.Clear()

        '    Else
        '        ErrorProvider.SetError(TxtCode, "Codigo invalido. Introduzca el codigo que se le envió a su correo.")
        '    End If
        '    Wait.Close()
        'Else
        '    ErrorProvider.SetError(TxtCode, "Introduzca el codigo que se le envió a su correo.")
        'End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
        Usuario = Nothing
        PnlResetKey.Visible = False
        PnlLogin.Visible = True
        PnlLogin.Location = New Point(8, 128)
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        If Usuario.CambiarContraseña(TxtOlvPass1.Text, TxtOlvPass2.Text) Then
            Clear()
            chkRecordar.Enabled = False
            PnlNewPassword.Visible = False
            PnlLogin.Visible = True
            PnlLogin.Location = New Point(8, 128)
        Else
            TxtOlvPass1.Text = ""
            TxtOlvPass2.Text = ""
        End If
    End Sub

    Private Sub Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles pass.KeyDown, user.KeyDown, Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged
        If user.TextLength > 3 And user.Text.ToUpper() <> "ADMIN" Then
            lnk_Password.Visible = True
            chkRecordar.Visible = True
        Else
            lnk_Password.Visible = False
            chkRecordar.Visible = False
        End If
    End Sub
End Class