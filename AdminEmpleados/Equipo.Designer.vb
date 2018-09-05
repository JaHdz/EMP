<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_equipo_emp = New System.Windows.Forms.DataGridView()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.pnl_save = New System.Windows.Forms.Panel()
        Me.LBL_GUARDAR = New System.Windows.Forms.Label()
        Me.panel15 = New System.Windows.Forms.Panel()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Eq = New System.Windows.Forms.TextBox()
        Me.eq2 = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.ID_Assig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Regreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UPDATE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.buscar_eq = New System.Windows.Forms.PictureBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_save.SuspendLayout()
        Me.panel15.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1716, 962)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_equipo_emp)
        Me.GroupBox1.Controls.Add(Me.TXT_commen)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.lbl_ingreso)
        Me.GroupBox1.Controls.Add(Me.TXT_FECHA)
        Me.GroupBox1.Controls.Add(Me.pnl_save)
        Me.GroupBox1.Controls.Add(Me.buscar_eq)
        Me.GroupBox1.Controls.Add(Me.Eq)
        Me.GroupBox1.Controls.Add(Me.eq2)
        Me.GroupBox1.Controls.Add(Me.Label92)
        Me.GroupBox1.Controls.Add(Me.lbl_emp)
        Me.GroupBox1.Controls.Add(Me.Empleado)
        Me.GroupBox1.Controls.Add(Me.buscar_EN)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_num)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1560, 830)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar Equipo"
        '
        'dgv_equipo_emp
        '
        Me.dgv_equipo_emp.AllowUserToAddRows = False
        Me.dgv_equipo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATE, Me.ID_Assig, Me.ID_Equipo, Me.ID_Emp, Me.Fecha, Me.Regreso, Me.Fecha_R, Me.Comentario})
        Me.dgv_equipo_emp.Location = New System.Drawing.Point(27, 398)
        Me.dgv_equipo_emp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_equipo_emp.Name = "dgv_equipo_emp"
        Me.dgv_equipo_emp.RowHeadersVisible = False
        Me.dgv_equipo_emp.Size = New System.Drawing.Size(1511, 400)
        Me.dgv_equipo_emp.TabIndex = 71
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Location = New System.Drawing.Point(159, 210)
        Me.TXT_commen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(568, 101)
        Me.TXT_commen.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(53, 210)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(92, 27)
        Me.label8.TabIndex = 70
        Me.label8.Text = "Motivo: "
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(48, 165)
        Me.lbl_ingreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(89, 27)
        Me.lbl_ingreso.TabIndex = 67
        Me.lbl_ingreso.Text = "Ingreso:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Location = New System.Drawing.Point(159, 158)
        Me.TXT_FECHA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(325, 33)
        Me.TXT_FECHA.TabIndex = 2
        '
        'pnl_save
        '
        Me.pnl_save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_save.Controls.Add(Me.LBL_GUARDAR)
        Me.pnl_save.Controls.Add(Me.panel15)
        Me.pnl_save.Controls.Add(Me.Label5)
        Me.pnl_save.Controls.Add(Me.SAVE)
        Me.pnl_save.Controls.Add(Me.CANCEL)
        Me.pnl_save.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_save.Location = New System.Drawing.Point(1183, 32)
        Me.pnl_save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_save.Name = "pnl_save"
        Me.pnl_save.Size = New System.Drawing.Size(355, 223)
        Me.pnl_save.TabIndex = 66
        '
        'LBL_GUARDAR
        '
        Me.LBL_GUARDAR.AutoSize = True
        Me.LBL_GUARDAR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.LBL_GUARDAR.Location = New System.Drawing.Point(41, 174)
        Me.LBL_GUARDAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_GUARDAR.Name = "LBL_GUARDAR"
        Me.LBL_GUARDAR.Size = New System.Drawing.Size(117, 27)
        Me.LBL_GUARDAR.TabIndex = 40
        Me.LBL_GUARDAR.Text = "GUARDAR"
        '
        'panel15
        '
        Me.panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel15.Controls.Add(Me.label16)
        Me.panel15.Location = New System.Drawing.Point(-3, -2)
        Me.panel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel15.Name = "panel15"
        Me.panel15.Size = New System.Drawing.Size(393, 43)
        Me.panel15.TabIndex = 0
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(17, 7)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(90, 27)
        Me.label16.TabIndex = 0
        Me.label16.Text = "Guardar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(209, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 27)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CANCELAR"
        '
        'Eq
        '
        Me.Eq.Location = New System.Drawing.Point(159, 101)
        Me.Eq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eq.Name = "Eq"
        Me.Eq.Size = New System.Drawing.Size(51, 33)
        Me.Eq.TabIndex = 1
        '
        'eq2
        '
        Me.eq2.Enabled = False
        Me.eq2.Location = New System.Drawing.Point(219, 101)
        Me.eq2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.eq2.Name = "eq2"
        Me.eq2.Size = New System.Drawing.Size(217, 33)
        Me.eq2.TabIndex = 64
        Me.eq2.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(53, 110)
        Me.Label92.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(84, 27)
        Me.Label92.TabIndex = 63
        Me.Label92.Text = "Equipo:"
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(660, 49)
        Me.lbl_emp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 27)
        Me.lbl_emp.TabIndex = 55
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(518, 49)
        Me.Empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(124, 27)
        Me.Empleado.TabIndex = 54
        Me.Empleado.Text = "Empleado: "
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(159, 46)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(277, 33)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(40, 54)
        Me.lbl_num.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(96, 27)
        Me.lbl_num.TabIndex = 13
        Me.lbl_num.Text = "Numero:"
        '
        'ID_Assig
        '
        Me.ID_Assig.DataPropertyName = "ID_Assig"
        Me.ID_Assig.HeaderText = "ID"
        Me.ID_Assig.Name = "ID_Assig"
        Me.ID_Assig.Width = 50
        '
        'ID_Equipo
        '
        Me.ID_Equipo.DataPropertyName = "ID_Equipo"
        Me.ID_Equipo.HeaderText = "EQUIPO"
        Me.ID_Equipo.Name = "ID_Equipo"
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "EMPLEADO"
        Me.ID_Emp.Name = "ID_Emp"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "FECHA"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 200
        '
        'Regreso
        '
        Me.Regreso.DataPropertyName = "Regreso"
        Me.Regreso.HeaderText = "REGRESO?"
        Me.Regreso.Name = "Regreso"
        Me.Regreso.Width = 200
        '
        'Fecha_R
        '
        Me.Fecha_R.DataPropertyName = "Fecha_R"
        Me.Fecha_R.HeaderText = "FECHA REGRESO"
        Me.Fecha_R.Name = "Fecha_R"
        Me.Fecha_R.Width = 200
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        Me.Comentario.HeaderText = "COMENTARIO"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Width = 600
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Delete_Icon_e1409122560423
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'UPDATE
        '
        Me.UPDATE.HeaderText = "Regresar"
        Me.UPDATE.Image = Global.AdminEmpleados.My.Resources.Resources._return
        Me.UPDATE.Name = "UPDATE"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.disk_save_as_icon
        Me.SAVE.Location = New System.Drawing.Point(47, 68)
        Me.SAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(111, 102)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.cancel_icon
        Me.CANCEL.Location = New System.Drawing.Point(215, 68)
        Me.CANCEL.Margin = New System.Windows.Forms.Padding(4)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(111, 102)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'buscar_eq
        '
        Me.buscar_eq.BackgroundImage = CType(resources.GetObject("buscar_eq.BackgroundImage"), System.Drawing.Image)
        Me.buscar_eq.Image = CType(resources.GetObject("buscar_eq.Image"), System.Drawing.Image)
        Me.buscar_eq.Location = New System.Drawing.Point(445, 100)
        Me.buscar_eq.Margin = New System.Windows.Forms.Padding(4)
        Me.buscar_eq.Name = "buscar_eq"
        Me.buscar_eq.Size = New System.Drawing.Size(40, 34)
        Me.buscar_eq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_eq.TabIndex = 65
        Me.buscar_eq.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = CType(resources.GetObject("buscar_EN.Image"), System.Drawing.Image)
        Me.buscar_EN.Location = New System.Drawing.Point(445, 46)
        Me.buscar_EN.Margin = New System.Windows.Forms.Padding(4)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(40, 34)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 53
        Me.buscar_EN.TabStop = False
        '
        'Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1744, 1063)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipo"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_save.ResumeLayout(False)
        Me.pnl_save.PerformLayout()
        Me.panel15.ResumeLayout(False)
        Me.panel15.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_eq As PictureBox
    Friend WithEvents Eq As TextBox
    Friend WithEvents eq2 As TextBox
    Friend WithEvents Label92 As Label
    Private WithEvents pnl_save As Panel
    Friend WithEvents LBL_GUARDAR As Label
    Private WithEvents panel15 As Panel
    Private WithEvents label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Friend WithEvents dgv_equipo_emp As DataGridView
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents UPDATE As DataGridViewImageColumn
    Friend WithEvents ID_Assig As DataGridViewTextBoxColumn
    Friend WithEvents ID_Equipo As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Regreso As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_R As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
End Class
