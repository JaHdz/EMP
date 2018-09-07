<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PNL_INFO = New System.Windows.Forms.Panel()
        Me.header = New System.Windows.Forms.Panel()
        Me.min = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.BTN_ADMIN = New System.Windows.Forms.Button()
        Me.BTN_MED = New System.Windows.Forms.Button()
        Me.BTN_EV = New System.Windows.Forms.Button()
        Me.BTN_CAP = New System.Windows.Forms.Button()
        Me.BTN_EQ = New System.Windows.Forms.Button()
        Me.btn_emp = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_INFO
        '
        Me.PNL_INFO.Location = New System.Drawing.Point(227, 67)
        Me.PNL_INFO.Margin = New System.Windows.Forms.Padding(2)
        Me.PNL_INFO.Name = "PNL_INFO"
        Me.PNL_INFO.Size = New System.Drawing.Size(1296, 857)
        Me.PNL_INFO.TabIndex = 7
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Black
        Me.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.header.Controls.Add(Me.min)
        Me.header.Controls.Add(Me.cerrar)
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1535, 29)
        Me.header.TabIndex = 5
        '
        'min
        '
        Me.min.Image = CType(resources.GetObject("min.Image"), System.Drawing.Image)
        Me.min.Location = New System.Drawing.Point(1477, 2)
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
        Me.cerrar.Location = New System.Drawing.Point(1506, 2)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(25, 22)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 0
        Me.cerrar.TabStop = False
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Menu.Controls.Add(Me.BTN_ADMIN)
        Me.Menu.Controls.Add(Me.BTN_MED)
        Me.Menu.Controls.Add(Me.BTN_EV)
        Me.Menu.Controls.Add(Me.BTN_CAP)
        Me.Menu.Controls.Add(Me.BTN_EQ)
        Me.Menu.Controls.Add(Me.btn_emp)
        Me.Menu.Location = New System.Drawing.Point(-2, 28)
        Me.Menu.Margin = New System.Windows.Forms.Padding(2)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(224, 896)
        Me.Menu.TabIndex = 6
        '
        'BTN_ADMIN
        '
        Me.BTN_ADMIN.FlatAppearance.BorderSize = 0
        Me.BTN_ADMIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_ADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADMIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADMIN.ForeColor = System.Drawing.Color.White
        Me.BTN_ADMIN.Location = New System.Drawing.Point(2, 351)
        Me.BTN_ADMIN.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_ADMIN.Name = "BTN_ADMIN"
        Me.BTN_ADMIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_ADMIN.Size = New System.Drawing.Size(224, 46)
        Me.BTN_ADMIN.TabIndex = 6
        Me.BTN_ADMIN.Text = "ADMIN"
        Me.BTN_ADMIN.UseCompatibleTextRendering = True
        Me.BTN_ADMIN.UseVisualStyleBackColor = True
        '
        'BTN_MED
        '
        Me.BTN_MED.FlatAppearance.BorderSize = 0
        Me.BTN_MED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_MED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MED.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MED.ForeColor = System.Drawing.Color.White
        Me.BTN_MED.Location = New System.Drawing.Point(0, 301)
        Me.BTN_MED.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_MED.Name = "BTN_MED"
        Me.BTN_MED.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_MED.Size = New System.Drawing.Size(224, 46)
        Me.BTN_MED.TabIndex = 4
        Me.BTN_MED.Text = "EX. MEDICOS"
        Me.BTN_MED.UseCompatibleTextRendering = True
        Me.BTN_MED.UseVisualStyleBackColor = True
        '
        'BTN_EV
        '
        Me.BTN_EV.FlatAppearance.BorderSize = 0
        Me.BTN_EV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_EV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EV.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EV.ForeColor = System.Drawing.Color.White
        Me.BTN_EV.Location = New System.Drawing.Point(0, 250)
        Me.BTN_EV.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EV.Name = "BTN_EV"
        Me.BTN_EV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_EV.Size = New System.Drawing.Size(224, 46)
        Me.BTN_EV.TabIndex = 3
        Me.BTN_EV.Text = "EVALUACIONES"
        Me.BTN_EV.UseCompatibleTextRendering = True
        Me.BTN_EV.UseVisualStyleBackColor = True
        '
        'BTN_CAP
        '
        Me.BTN_CAP.FlatAppearance.BorderSize = 0
        Me.BTN_CAP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_CAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CAP.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CAP.ForeColor = System.Drawing.Color.White
        Me.BTN_CAP.Location = New System.Drawing.Point(0, 200)
        Me.BTN_CAP.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_CAP.Name = "BTN_CAP"
        Me.BTN_CAP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_CAP.Size = New System.Drawing.Size(224, 46)
        Me.BTN_CAP.TabIndex = 2
        Me.BTN_CAP.Text = "CAPACITACIONES"
        Me.BTN_CAP.UseCompatibleTextRendering = True
        Me.BTN_CAP.UseVisualStyleBackColor = True
        '
        'BTN_EQ
        '
        Me.BTN_EQ.FlatAppearance.BorderSize = 0
        Me.BTN_EQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_EQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EQ.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EQ.ForeColor = System.Drawing.Color.White
        Me.BTN_EQ.Location = New System.Drawing.Point(0, 150)
        Me.BTN_EQ.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EQ.Name = "BTN_EQ"
        Me.BTN_EQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_EQ.Size = New System.Drawing.Size(224, 46)
        Me.BTN_EQ.TabIndex = 1
        Me.BTN_EQ.Text = "EQUIPO"
        Me.BTN_EQ.UseCompatibleTextRendering = True
        Me.BTN_EQ.UseVisualStyleBackColor = True
        '
        'btn_emp
        '
        Me.btn_emp.FlatAppearance.BorderSize = 0
        Me.btn_emp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_emp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emp.ForeColor = System.Drawing.Color.White
        Me.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_emp.Location = New System.Drawing.Point(0, 99)
        Me.btn_emp.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_emp.Size = New System.Drawing.Size(224, 46)
        Me.btn_emp.TabIndex = 0
        Me.btn_emp.Text = "EMPLEADOS"
        Me.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_emp.UseCompatibleTextRendering = True
        Me.btn_emp.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(227, 37)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(67, 19)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "Usuario:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1534, 935)
        Me.Controls.Add(Me.PNL_INFO)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.lbl_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.header.ResumeLayout(False)
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents PNL_INFO As Panel
    Private WithEvents header As Panel
    Private WithEvents min As PictureBox
    Private WithEvents cerrar As PictureBox
    Private WithEvents Menu As Panel
    Private WithEvents BTN_ADMIN As Button
    Private WithEvents BTN_MED As Button
    Private WithEvents BTN_EV As Button
    Private WithEvents BTN_CAP As Button
    Private WithEvents BTN_EQ As Button
    Private WithEvents btn_emp As Button
    Private WithEvents lbl_user As Label
End Class
