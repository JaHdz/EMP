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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.header = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.min = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Black
        Me.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.header.Controls.Add(Me.min)
        Me.header.Controls.Add(Me.cerrar)
        Me.header.Location = New System.Drawing.Point(-4, -2)
        Me.header.Margin = New System.Windows.Forms.Padding(2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(390, 39)
        Me.header.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-2, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 14)
        Me.Panel1.TabIndex = 7
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(56, 254)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(259, 63)
        Me.btn_login.TabIndex = 17
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.user.Location = New System.Drawing.Point(101, 138)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(214, 35)
        Me.user.TabIndex = 0
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!)
        Me.pass.Location = New System.Drawing.Point(101, 186)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(214, 35)
        Me.pass.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminEmpleados.My.Resources.Resources.Password_80px
        Me.PictureBox1.Location = New System.Drawing.Point(56, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AdminEmpleados.My.Resources.Resources.User_80px
        Me.PictureBox2.Location = New System.Drawing.Point(56, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'min
        '
        Me.min.Image = CType(resources.GetObject("min.Image"), System.Drawing.Image)
        Me.min.Location = New System.Drawing.Point(317, 8)
        Me.min.Margin = New System.Windows.Forms.Padding(2)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(25, 22)
        Me.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.min.TabIndex = 1
        Me.min.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(346, 8)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(25, 22)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 0
        Me.cerrar.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 351)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.header.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents header As Panel
    Private WithEvents Panel1 As Panel
    Private WithEvents min As PictureBox
    Private WithEvents cerrar As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents user As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pass As TextBox
End Class
