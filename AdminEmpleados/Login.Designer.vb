<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.header = New System.Windows.Forms.Panel()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.PnlLogin = New System.Windows.Forms.Panel()
        Me.lnk_Password = New System.Windows.Forms.LinkLabel()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PnlNewPassword = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TxtOlvPass2 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TxtOlvPass1 = New System.Windows.Forms.TextBox()
        Me.PnlResetKey = New System.Windows.Forms.Panel()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.PictureBox()
        Me.BtnNext = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkRecordar = New System.Windows.Forms.CheckBox()
        Me.header.SuspendLayout()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlNewPassword.SuspendLayout()
        CType(Me.BtnCambiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlResetKey.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.header.Controls.Add(Me.Lbl_Title)
        Me.header.Controls.Add(Me.min)
        Me.header.Controls.Add(Me.cerrar)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(384, 34)
        Me.header.TabIndex = 6
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(6, 7)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(306, 23)
        Me.Lbl_Title.TabIndex = 19
        Me.Lbl_Title.Text = "EASY - Employee Administrator System"
        '
        'min
        '
        Me.min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.min.Image = Global.AdminEmpleados.My.Resources.Resources.Minimize_80px
        Me.min.Location = New System.Drawing.Point(322, 8)
        Me.min.Margin = New System.Windows.Forms.Padding(2)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(25, 22)
        Me.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.min.TabIndex = 1
        Me.min.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Image = Global.AdminEmpleados.My.Resources.Resources.Close_80px
        Me.cerrar.Location = New System.Drawing.Point(351, 8)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(25, 22)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 0
        Me.cerrar.TabStop = False
        '
        'PnlLogin
        '
        Me.PnlLogin.Controls.Add(Me.chkRecordar)
        Me.PnlLogin.Controls.Add(Me.lnk_Password)
        Me.PnlLogin.Controls.Add(Me.btn_login)
        Me.PnlLogin.Controls.Add(Me.user)
        Me.PnlLogin.Controls.Add(Me.PictureBox1)
        Me.PnlLogin.Controls.Add(Me.PictureBox2)
        Me.PnlLogin.Controls.Add(Me.pass)
        Me.PnlLogin.Location = New System.Drawing.Point(8, 128)
        Me.PnlLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(363, 241)
        Me.PnlLogin.TabIndex = 7
        '
        'lnk_Password
        '
        Me.lnk_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Password.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lnk_Password.Location = New System.Drawing.Point(47, 201)
        Me.lnk_Password.Name = "lnk_Password"
        Me.lnk_Password.Size = New System.Drawing.Size(262, 23)
        Me.lnk_Password.TabIndex = 32
        Me.lnk_Password.TabStop = True
        Me.lnk_Password.Text = "Olvide mi contraseña"
        Me.lnk_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(50, 136)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(259, 63)
        Me.btn_login.TabIndex = 31
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.user.Location = New System.Drawing.Point(95, 19)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(214, 35)
        Me.user.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminEmpleados.My.Resources.Resources.Password_80px
        Me.PictureBox1.Location = New System.Drawing.Point(50, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AdminEmpleados.My.Resources.Resources.User_80px
        Me.PictureBox2.Location = New System.Drawing.Point(50, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.pass.Location = New System.Drawing.Point(95, 68)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(214, 35)
        Me.pass.TabIndex = 28
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AdminEmpleados.My.Resources.Resources.EASY_Small
        Me.PictureBox3.Location = New System.Drawing.Point(99, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(182, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PnlNewPassword
        '
        Me.PnlNewPassword.Controls.Add(Me.Label1)
        Me.PnlNewPassword.Controls.Add(Me.BtnCambiar)
        Me.PnlNewPassword.Controls.Add(Me.PictureBox6)
        Me.PnlNewPassword.Controls.Add(Me.TxtOlvPass2)
        Me.PnlNewPassword.Controls.Add(Me.PictureBox4)
        Me.PnlNewPassword.Controls.Add(Me.TxtOlvPass1)
        Me.PnlNewPassword.Location = New System.Drawing.Point(742, 128)
        Me.PnlNewPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlNewPassword.Name = "PnlNewPassword"
        Me.PnlNewPassword.Size = New System.Drawing.Size(363, 241)
        Me.PnlNewPassword.TabIndex = 33
        Me.PnlNewPassword.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 81)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Introduzca una nueva contraseña en el primer campo y repitala en el segundo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Image = Global.AdminEmpleados.My.Resources.Resources.Checked_80px
        Me.BtnCambiar.Location = New System.Drawing.Point(311, 190)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(37, 36)
        Me.BtnCambiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCambiar.TabIndex = 41
        Me.BtnCambiar.TabStop = False
        Me.BtnCambiar.Tag = "ACEPTAR"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.AdminEmpleados.My.Resources.Resources.Password_80px
        Me.PictureBox6.Location = New System.Drawing.Point(46, 136)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'TxtOlvPass2
        '
        Me.TxtOlvPass2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.TxtOlvPass2.Location = New System.Drawing.Point(92, 136)
        Me.TxtOlvPass2.Name = "TxtOlvPass2"
        Me.TxtOlvPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOlvPass2.Size = New System.Drawing.Size(214, 35)
        Me.TxtOlvPass2.TabIndex = 31
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AdminEmpleados.My.Resources.Resources.Password_80px
        Me.PictureBox4.Location = New System.Drawing.Point(45, 84)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'TxtOlvPass1
        '
        Me.TxtOlvPass1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.TxtOlvPass1.Location = New System.Drawing.Point(90, 84)
        Me.TxtOlvPass1.Name = "TxtOlvPass1"
        Me.TxtOlvPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOlvPass1.Size = New System.Drawing.Size(214, 35)
        Me.TxtOlvPass1.TabIndex = 28
        '
        'PnlResetKey
        '
        Me.PnlResetKey.Controls.Add(Me.lblInstructions)
        Me.PnlResetKey.Controls.Add(Me.TxtCode)
        Me.PnlResetKey.Controls.Add(Me.PictureBox5)
        Me.PnlResetKey.Controls.Add(Me.BtnCancel)
        Me.PnlResetKey.Controls.Add(Me.BtnNext)
        Me.PnlResetKey.Location = New System.Drawing.Point(375, 128)
        Me.PnlResetKey.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlResetKey.Name = "PnlResetKey"
        Me.PnlResetKey.Size = New System.Drawing.Size(363, 241)
        Me.PnlResetKey.TabIndex = 34
        Me.PnlResetKey.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(3, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(357, 88)
        Me.lblInstructions.TabIndex = 45
        Me.lblInstructions.Text = "Se le ha enviado un correo electronico que contiene un codigo. Ingrese dicho codi" &
    "go en el cuadro de texto."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.TxtCode.Location = New System.Drawing.Point(103, 110)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(214, 35)
        Me.TxtCode.TabIndex = 43
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.AdminEmpleados.My.Resources.Resources.User_80px
        Me.PictureBox5.Location = New System.Drawing.Point(58, 110)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 44
        Me.PictureBox5.TabStop = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.BtnCancel.Location = New System.Drawing.Point(306, 190)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(37, 36)
        Me.BtnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCancel.TabIndex = 42
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Tag = "CANCELAR"
        '
        'BtnNext
        '
        Me.BtnNext.Image = Global.AdminEmpleados.My.Resources.Resources.Checked_80px
        Me.BtnNext.Location = New System.Drawing.Point(244, 190)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(37, 36)
        Me.BtnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnNext.TabIndex = 41
        Me.BtnNext.TabStop = False
        Me.BtnNext.Tag = "ACEPTAR"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'chkRecordar
        '
        Me.chkRecordar.AutoSize = True
        Me.chkRecordar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkRecordar.Location = New System.Drawing.Point(91, 110)
        Me.chkRecordar.Name = "chkRecordar"
        Me.chkRecordar.Size = New System.Drawing.Size(197, 21)
        Me.chkRecordar.TabIndex = 33
        Me.chkRecordar.Text = "¿Recordar datos de inicio?"
        Me.chkRecordar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(384, 379)
        Me.Controls.Add(Me.PnlResetKey)
        Me.Controls.Add(Me.PnlNewPassword)
        Me.Controls.Add(Me.PnlLogin)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlNewPassword.ResumeLayout(False)
        Me.PnlNewPassword.PerformLayout()
        CType(Me.BtnCambiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlResetKey.ResumeLayout(False)
        Me.PnlResetKey.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents header As Panel
    Private WithEvents min As PictureBox
    Private WithEvents cerrar As PictureBox
    Friend WithEvents Lbl_Title As Label
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lnk_Password As LinkLabel
    Friend WithEvents btn_login As Button
    Friend WithEvents user As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pass As TextBox
    Friend WithEvents PnlNewPassword As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TxtOlvPass1 As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TxtOlvPass2 As TextBox
    Friend WithEvents BtnCambiar As PictureBox
    Friend WithEvents PnlResetKey As Panel
    Friend WithEvents BtnCancel As PictureBox
    Friend WithEvents BtnNext As PictureBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRecordar As CheckBox
End Class
