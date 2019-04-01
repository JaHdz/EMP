<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PNL_INFO = New System.Windows.Forms.Panel()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.Panel()
        Me.BTN_CERRARSESION = New System.Windows.Forms.Button()
        Me.Pb_Logo = New System.Windows.Forms.PictureBox()
        Me.BTN_ADMIN = New System.Windows.Forms.Button()
        Me.BTN_MED = New System.Windows.Forms.Button()
        Me.BTN_EV = New System.Windows.Forms.Button()
        Me.BTN_CAP = New System.Windows.Forms.Button()
        Me.BTN_EQ = New System.Windows.Forms.Button()
        Me.btn_emp = New System.Windows.Forms.Button()
        Me.Menu.SuspendLayout()
        CType(Me.Pb_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL_INFO
        '
        Me.PNL_INFO.Dock = System.Windows.Forms.DockStyle.Right
        Me.PNL_INFO.Location = New System.Drawing.Point(-50, 0)
        Me.PNL_INFO.Margin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.PNL_INFO.Name = "PNL_INFO"
        Me.PNL_INFO.Size = New System.Drawing.Size(1078, 551)
        Me.PNL_INFO.TabIndex = 7
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(4, 612)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(67, 19)
        Me.lbl_user.TabIndex = 8
        Me.lbl_user.Text = "Usuario:"
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Menu.Controls.Add(Me.BTN_CERRARSESION)
        Me.Menu.Controls.Add(Me.Pb_Logo)
        Me.Menu.Controls.Add(Me.BTN_ADMIN)
        Me.Menu.Controls.Add(Me.lbl_user)
        Me.Menu.Controls.Add(Me.BTN_MED)
        Me.Menu.Controls.Add(Me.BTN_EV)
        Me.Menu.Controls.Add(Me.BTN_CAP)
        Me.Menu.Controls.Add(Me.BTN_EQ)
        Me.Menu.Controls.Add(Me.btn_emp)
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Margin = New System.Windows.Forms.Padding(2)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(205, 551)
        Me.Menu.TabIndex = 9
        '
        'BTN_CERRARSESION
        '
        Me.BTN_CERRARSESION.FlatAppearance.BorderSize = 0
        Me.BTN_CERRARSESION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_CERRARSESION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CERRARSESION.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CERRARSESION.ForeColor = System.Drawing.Color.Black
        Me.BTN_CERRARSESION.Location = New System.Drawing.Point(0, 399)
        Me.BTN_CERRARSESION.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_CERRARSESION.Name = "BTN_CERRARSESION"
        Me.BTN_CERRARSESION.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_CERRARSESION.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_CERRARSESION.Size = New System.Drawing.Size(205, 50)
        Me.BTN_CERRARSESION.TabIndex = 8
        Me.BTN_CERRARSESION.Text = "CERRAR SESION"
        Me.BTN_CERRARSESION.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_CERRARSESION.UseCompatibleTextRendering = True
        Me.BTN_CERRARSESION.UseVisualStyleBackColor = True
        '
        'Pb_Logo
        '
        Me.Pb_Logo.Image = Global.AdminEmpleados.My.Resources.Resources.EASY_Full
        Me.Pb_Logo.Location = New System.Drawing.Point(2, 0)
        Me.Pb_Logo.Name = "Pb_Logo"
        Me.Pb_Logo.Size = New System.Drawing.Size(202, 94)
        Me.Pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pb_Logo.TabIndex = 7
        Me.Pb_Logo.TabStop = False
        '
        'BTN_ADMIN
        '
        Me.BTN_ADMIN.FlatAppearance.BorderSize = 0
        Me.BTN_ADMIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_ADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADMIN.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADMIN.ForeColor = System.Drawing.Color.Black
        Me.BTN_ADMIN.Location = New System.Drawing.Point(0, 349)
        Me.BTN_ADMIN.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_ADMIN.Name = "BTN_ADMIN"
        Me.BTN_ADMIN.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_ADMIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_ADMIN.Size = New System.Drawing.Size(205, 50)
        Me.BTN_ADMIN.TabIndex = 6
        Me.BTN_ADMIN.Tag = "Administration"
        Me.BTN_ADMIN.Text = "ADMIN"
        Me.BTN_ADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_ADMIN.UseCompatibleTextRendering = True
        Me.BTN_ADMIN.UseVisualStyleBackColor = True
        '
        'BTN_MED
        '
        Me.BTN_MED.FlatAppearance.BorderSize = 0
        Me.BTN_MED.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_MED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MED.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MED.ForeColor = System.Drawing.Color.Black
        Me.BTN_MED.Location = New System.Drawing.Point(0, 299)
        Me.BTN_MED.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_MED.Name = "BTN_MED"
        Me.BTN_MED.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_MED.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_MED.Size = New System.Drawing.Size(205, 50)
        Me.BTN_MED.TabIndex = 4
        Me.BTN_MED.Tag = "Examenes_Medicos"
        Me.BTN_MED.Text = "EX. MEDICOS"
        Me.BTN_MED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MED.UseCompatibleTextRendering = True
        Me.BTN_MED.UseVisualStyleBackColor = True
        '
        'BTN_EV
        '
        Me.BTN_EV.FlatAppearance.BorderSize = 0
        Me.BTN_EV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_EV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EV.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EV.ForeColor = System.Drawing.Color.Black
        Me.BTN_EV.Location = New System.Drawing.Point(0, 249)
        Me.BTN_EV.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EV.Name = "BTN_EV"
        Me.BTN_EV.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_EV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_EV.Size = New System.Drawing.Size(205, 50)
        Me.BTN_EV.TabIndex = 3
        Me.BTN_EV.Tag = "Evaluaciones"
        Me.BTN_EV.Text = "EVALUACIONES"
        Me.BTN_EV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_EV.UseCompatibleTextRendering = True
        Me.BTN_EV.UseVisualStyleBackColor = True
        '
        'BTN_CAP
        '
        Me.BTN_CAP.FlatAppearance.BorderSize = 0
        Me.BTN_CAP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_CAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CAP.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CAP.ForeColor = System.Drawing.Color.Black
        Me.BTN_CAP.Location = New System.Drawing.Point(0, 199)
        Me.BTN_CAP.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_CAP.Name = "BTN_CAP"
        Me.BTN_CAP.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_CAP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_CAP.Size = New System.Drawing.Size(205, 50)
        Me.BTN_CAP.TabIndex = 2
        Me.BTN_CAP.Tag = "Capacitaciones"
        Me.BTN_CAP.Text = "CAPACITACIONES"
        Me.BTN_CAP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_CAP.UseCompatibleTextRendering = True
        Me.BTN_CAP.UseVisualStyleBackColor = True
        '
        'BTN_EQ
        '
        Me.BTN_EQ.FlatAppearance.BorderSize = 0
        Me.BTN_EQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_EQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EQ.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EQ.ForeColor = System.Drawing.Color.Black
        Me.BTN_EQ.Location = New System.Drawing.Point(0, 149)
        Me.BTN_EQ.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EQ.Name = "BTN_EQ"
        Me.BTN_EQ.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.BTN_EQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTN_EQ.Size = New System.Drawing.Size(205, 50)
        Me.BTN_EQ.TabIndex = 1
        Me.BTN_EQ.Tag = "Equipo"
        Me.BTN_EQ.Text = "EQUIPO"
        Me.BTN_EQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btn_emp.ForeColor = System.Drawing.Color.Black
        Me.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_emp.Location = New System.Drawing.Point(0, 99)
        Me.btn_emp.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btn_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_emp.Size = New System.Drawing.Size(205, 50)
        Me.btn_emp.TabIndex = 0
        Me.btn_emp.Tag = "Empleados"
        Me.btn_emp.Text = "EMPLEADOS"
        Me.btn_emp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_emp.UseCompatibleTextRendering = True
        Me.btn_emp.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 551)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.PNL_INFO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Principal"
        Me.Text = "EASY - Employee Administrator System"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.Pb_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PNL_INFO As Panel
    Private WithEvents lbl_user As Label
    Private WithEvents Menu As Panel
    Private WithEvents BTN_CERRARSESION As Button
    Friend WithEvents Pb_Logo As PictureBox
    Private WithEvents BTN_ADMIN As Button
    Private WithEvents BTN_MED As Button
    Private WithEvents BTN_EV As Button
    Private WithEvents BTN_CAP As Button
    Private WithEvents BTN_EQ As Button
    Private WithEvents btn_emp As Button
End Class
