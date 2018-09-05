<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Capacitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Capacitaciones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Cap_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_save = New System.Windows.Forms.Panel()
        Me.LBL_GUARDAR = New System.Windows.Forms.Label()
        Me.panel15 = New System.Windows.Forms.Panel()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.buscar_CAP = New System.Windows.Forms.PictureBox()
        Me.CAP = New System.Windows.Forms.TextBox()
        Me.CAP2 = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_save.SuspendLayout()
        Me.panel15.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_CAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(9, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 782)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_ingreso)
        Me.GroupBox1.Controls.Add(Me.TXT_FECHA)
        Me.GroupBox1.Controls.Add(Me.dgv_equipo_Eval)
        Me.GroupBox1.Controls.Add(Me.pnl_save)
        Me.GroupBox1.Controls.Add(Me.TXT_commen)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.buscar_CAP)
        Me.GroupBox1.Controls.Add(Me.CAP)
        Me.GroupBox1.Controls.Add(Me.CAP2)
        Me.GroupBox1.Controls.Add(Me.Label92)
        Me.GroupBox1.Controls.Add(Me.lbl_emp)
        Me.GroupBox1.Controls.Add(Me.Empleado)
        Me.GroupBox1.Controls.Add(Me.buscar_EN)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_num)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1170, 728)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Capacitaciones"
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(58, 144)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(59, 21)
        Me.lbl_ingreso.TabIndex = 91
        Me.lbl_ingreso.Text = "Fecha:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Location = New System.Drawing.Point(123, 138)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 28)
        Me.TXT_FECHA.TabIndex = 2
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_Cap_Emp, Me.ID_Cap, Me.ID_Emp, Me.Fecha, Me.Comentario})
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(14, 312)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(1133, 325)
        Me.dgv_equipo_Eval.TabIndex = 89
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Delete_Icon_e1409122560423
        Me.DELETE.Name = "DELETE"
        '
        'ID_Cap_Emp
        '
        Me.ID_Cap_Emp.DataPropertyName = "ID_Cap_Emp"
        Me.ID_Cap_Emp.HeaderText = "ID"
        Me.ID_Cap_Emp.Name = "ID_Cap_Emp"
        Me.ID_Cap_Emp.Width = 50
        '
        'ID_Cap
        '
        Me.ID_Cap.DataPropertyName = "ID_Cap"
        Me.ID_Cap.HeaderText = "CAPACITACION"
        Me.ID_Cap.Name = "ID_Cap"
        Me.ID_Cap.Width = 200
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "EMPLEADO"
        Me.ID_Emp.Name = "ID_Emp"
        Me.ID_Emp.Width = 200
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "FECHA"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 200
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        Me.Comentario.HeaderText = "COMENTARIO"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Width = 600
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
        Me.pnl_save.Location = New System.Drawing.Point(880, 41)
        Me.pnl_save.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_save.Name = "pnl_save"
        Me.pnl_save.Size = New System.Drawing.Size(267, 182)
        Me.pnl_save.TabIndex = 88
        '
        'LBL_GUARDAR
        '
        Me.LBL_GUARDAR.AutoSize = True
        Me.LBL_GUARDAR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.LBL_GUARDAR.Location = New System.Drawing.Point(31, 141)
        Me.LBL_GUARDAR.Name = "LBL_GUARDAR"
        Me.LBL_GUARDAR.Size = New System.Drawing.Size(93, 22)
        Me.LBL_GUARDAR.TabIndex = 40
        Me.LBL_GUARDAR.Text = "GUARDAR"
        '
        'panel15
        '
        Me.panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel15.Controls.Add(Me.label16)
        Me.panel15.Location = New System.Drawing.Point(-2, -2)
        Me.panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.panel15.Name = "panel15"
        Me.panel15.Size = New System.Drawing.Size(295, 35)
        Me.panel15.TabIndex = 0
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(13, 6)
        Me.label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(72, 21)
        Me.label16.TabIndex = 0
        Me.label16.Text = "Guardar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(157, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CANCELAR"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.disk_save_as_icon
        Me.SAVE.Location = New System.Drawing.Point(35, 55)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(83, 83)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.cancel_icon
        Me.CANCEL.Location = New System.Drawing.Point(161, 55)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(83, 83)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Location = New System.Drawing.Point(123, 181)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(427, 83)
        Me.TXT_commen.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(9, 181)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(109, 21)
        Me.label8.TabIndex = 87
        Me.label8.Text = "Comentario: "
        '
        'buscar_CAP
        '
        Me.buscar_CAP.BackgroundImage = CType(resources.GetObject("buscar_CAP.BackgroundImage"), System.Drawing.Image)
        Me.buscar_CAP.Image = CType(resources.GetObject("buscar_CAP.Image"), System.Drawing.Image)
        Me.buscar_CAP.Location = New System.Drawing.Point(337, 96)
        Me.buscar_CAP.Name = "buscar_CAP"
        Me.buscar_CAP.Size = New System.Drawing.Size(30, 28)
        Me.buscar_CAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_CAP.TabIndex = 85
        Me.buscar_CAP.TabStop = False
        '
        'CAP
        '
        Me.CAP.Location = New System.Drawing.Point(123, 97)
        Me.CAP.Name = "CAP"
        Me.CAP.Size = New System.Drawing.Size(39, 28)
        Me.CAP.TabIndex = 1
        '
        'CAP2
        '
        Me.CAP2.Enabled = False
        Me.CAP2.Location = New System.Drawing.Point(168, 97)
        Me.CAP2.Name = "CAP2"
        Me.CAP2.Size = New System.Drawing.Size(164, 28)
        Me.CAP2.TabIndex = 842
        Me.CAP2.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(5, 100)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(112, 21)
        Me.Label92.TabIndex = 83
        Me.Label92.Text = "Capacitacion:"
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(494, 61)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 81
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(387, 61)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(101, 22)
        Me.Empleado.TabIndex = 80
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = CType(resources.GetObject("buscar_EN.Image"), System.Drawing.Image)
        Me.buscar_EN.Location = New System.Drawing.Point(338, 56)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 79
        Me.buscar_EN.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(123, 56)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 28)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(40, 59)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 78
        Me.lbl_num.Text = "Numero:"
        '
        'Capacitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 864)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Capacitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacitaciones"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_save.ResumeLayout(False)
        Me.pnl_save.PerformLayout()
        Me.panel15.ResumeLayout(False)
        Me.panel15.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_CAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_equipo_Eval As DataGridView
    Private WithEvents pnl_save As Panel
    Friend WithEvents LBL_GUARDAR As Label
    Private WithEvents panel15 As Panel
    Private WithEvents label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents buscar_CAP As PictureBox
    Friend WithEvents CAP As TextBox
    Friend WithEvents CAP2 As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_Cap_Emp As DataGridViewTextBoxColumn
    Friend WithEvents ID_Cap As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
End Class
