<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examenes_Medicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Examenes_Medicos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fp = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.pnl_save = New System.Windows.Forms.Panel()
        Me.LBL_GUARDAR = New System.Windows.Forms.Label()
        Me.panel15 = New System.Windows.Forms.Panel()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_EM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_FechaProximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXT_EST = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_save.SuspendLayout()
        Me.panel15.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.TXT_EST)
        Me.GroupBox1.Controls.Add(Me.txt_resultado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgv_equipo_Eval)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_fp)
        Me.GroupBox1.Controls.Add(Me.lbl_ingreso)
        Me.GroupBox1.Controls.Add(Me.TXT_FECHA)
        Me.GroupBox1.Controls.Add(Me.pnl_save)
        Me.GroupBox1.Controls.Add(Me.Label92)
        Me.GroupBox1.Controls.Add(Me.lbl_emp)
        Me.GroupBox1.Controls.Add(Me.Empleado)
        Me.GroupBox1.Controls.Add(Me.buscar_EN)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.lbl_num)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1170, 720)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Examenes Medicos"
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_EM, Me.ID_Emp, Me.EM_Estudio, Me.EM_Resultado, Me.EM_Fecha, Me.EM_FechaProximo})
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(16, 252)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(1133, 325)
        Me.dgv_equipo_Eval.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Proxima:"
        '
        'txt_fp
        '
        Me.txt_fp.Location = New System.Drawing.Point(144, 183)
        Me.txt_fp.Name = "txt_fp"
        Me.txt_fp.Size = New System.Drawing.Size(245, 28)
        Me.txt_fp.TabIndex = 4
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(79, 155)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(59, 21)
        Me.lbl_ingreso.TabIndex = 84
        Me.lbl_ingreso.Text = "Fecha:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Location = New System.Drawing.Point(144, 149)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 28)
        Me.TXT_FECHA.TabIndex = 3
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
        Me.pnl_save.Location = New System.Drawing.Point(876, 36)
        Me.pnl_save.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_save.Name = "pnl_save"
        Me.pnl_save.Size = New System.Drawing.Size(267, 182)
        Me.pnl_save.TabIndex = 83
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
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(68, 88)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(70, 21)
        Me.Label92.TabIndex = 80
        Me.Label92.Text = "Estudio:"
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(520, 50)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 79
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(413, 50)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(101, 22)
        Me.Empleado.TabIndex = 78
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = CType(resources.GetObject("buscar_EN.Image"), System.Drawing.Image)
        Me.buscar_EN.Location = New System.Drawing.Point(359, 47)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 77
        Me.buscar_EN.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(144, 47)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 28)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(61, 54)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 76
        Me.lbl_num.Text = "Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Resultado:"
        '
        'txt_resultado
        '
        Me.txt_resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_resultado.Location = New System.Drawing.Point(144, 115)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(245, 28)
        Me.txt_resultado.TabIndex = 2
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Delete_Icon_e1409122560423
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Width = 50
        '
        'ID_EM
        '
        Me.ID_EM.DataPropertyName = "ID_EM"
        Me.ID_EM.HeaderText = "ID"
        Me.ID_EM.Name = "ID_EM"
        Me.ID_EM.Width = 50
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "EMPLEADO"
        Me.ID_Emp.Name = "ID_Emp"
        Me.ID_Emp.Width = 150
        '
        'EM_Estudio
        '
        Me.EM_Estudio.DataPropertyName = "EM_Estudio"
        Me.EM_Estudio.HeaderText = "ESTUDIO"
        Me.EM_Estudio.Name = "EM_Estudio"
        Me.EM_Estudio.Width = 200
        '
        'EM_Resultado
        '
        Me.EM_Resultado.DataPropertyName = "EM_Resultado"
        Me.EM_Resultado.HeaderText = "RESULTADO"
        Me.EM_Resultado.Name = "EM_Resultado"
        Me.EM_Resultado.Width = 300
        '
        'EM_Fecha
        '
        Me.EM_Fecha.DataPropertyName = "EM_Fecha"
        Me.EM_Fecha.HeaderText = "FECHA"
        Me.EM_Fecha.Name = "EM_Fecha"
        Me.EM_Fecha.Width = 200
        '
        'EM_FechaProximo
        '
        Me.EM_FechaProximo.DataPropertyName = "EM_FechaProximo"
        Me.EM_FechaProximo.HeaderText = "FECHA PROXIMA"
        Me.EM_FechaProximo.Name = "EM_FechaProximo"
        Me.EM_FechaProximo.Width = 200
        '
        'TXT_EST
        '
        Me.TXT_EST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_EST.Location = New System.Drawing.Point(144, 81)
        Me.TXT_EST.Name = "TXT_EST"
        Me.TXT_EST.Size = New System.Drawing.Size(245, 28)
        Me.TXT_EST.TabIndex = 1
        '
        'Examenes_Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 864)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Examenes_Medicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examenes_Medicos"
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
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Private WithEvents pnl_save As Panel
    Friend WithEvents LBL_GUARDAR As Label
    Private WithEvents panel15 As Panel
    Private WithEvents label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents Label92 As Label
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fp As DateTimePicker
    Friend WithEvents dgv_equipo_Eval As DataGridView
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_EM As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents EM_Estudio As DataGridViewTextBoxColumn
    Friend WithEvents EM_Resultado As DataGridViewTextBoxColumn
    Friend WithEvents EM_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents EM_FechaProximo As DataGridViewTextBoxColumn
    Friend WithEvents TXT_EST As TextBox
End Class
