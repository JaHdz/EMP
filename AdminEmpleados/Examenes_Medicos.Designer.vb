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
        Me.TXT_EST = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_EM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_FechaProximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fp = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.LBL_GUARDAR = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.dgv_equipo_Eval)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(9, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 782)
        Me.Panel1.TabIndex = 1
        '
        'TXT_EST
        '
        Me.TXT_EST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_EST.Location = New System.Drawing.Point(166, 83)
        Me.TXT_EST.Name = "TXT_EST"
        Me.TXT_EST.Size = New System.Drawing.Size(245, 28)
        Me.TXT_EST.TabIndex = 1
        '
        'txt_resultado
        '
        Me.txt_resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_resultado.Location = New System.Drawing.Point(166, 117)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(245, 28)
        Me.txt_resultado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Resultado:"
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_EM, Me.ID_Emp, Me.EM_Estudio, Me.EM_Resultado, Me.EM_Fecha, Me.EM_FechaProximo})
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(15, 300)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(1241, 370)
        Me.dgv_equipo_Eval.TabIndex = 89
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DELETE.Name = "DELETE"
        '
        'ID_EM
        '
        Me.ID_EM.DataPropertyName = "ID_EM"
        Me.ID_EM.HeaderText = "ID"
        Me.ID_EM.Name = "ID_EM"
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "EMPLEADO"
        Me.ID_Emp.Name = "ID_Emp"
        Me.ID_Emp.Width = 200
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
        Me.EM_Resultado.Width = 400
        '
        'EM_Fecha
        '
        Me.EM_Fecha.DataPropertyName = "EM_Fecha"
        Me.EM_Fecha.HeaderText = "FECHA"
        Me.EM_Fecha.Name = "EM_Fecha"
        Me.EM_Fecha.Width = 300
        '
        'EM_FechaProximo
        '
        Me.EM_FechaProximo.DataPropertyName = "EM_FechaProximo"
        Me.EM_FechaProximo.HeaderText = "FECHA PROXIMA"
        Me.EM_FechaProximo.Name = "EM_FechaProximo"
        Me.EM_FechaProximo.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Proxima:"
        '
        'txt_fp
        '
        Me.txt_fp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fp.Location = New System.Drawing.Point(166, 185)
        Me.txt_fp.Name = "txt_fp"
        Me.txt_fp.Size = New System.Drawing.Size(245, 28)
        Me.txt_fp.TabIndex = 4
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(101, 157)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(59, 21)
        Me.lbl_ingreso.TabIndex = 84
        Me.lbl_ingreso.Text = "Fecha:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(166, 151)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 28)
        Me.TXT_FECHA.TabIndex = 3
        '
        'LBL_GUARDAR
        '
        Me.LBL_GUARDAR.AutoSize = True
        Me.LBL_GUARDAR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.LBL_GUARDAR.Location = New System.Drawing.Point(977, 152)
        Me.LBL_GUARDAR.Name = "LBL_GUARDAR"
        Me.LBL_GUARDAR.Size = New System.Drawing.Size(93, 22)
        Me.LBL_GUARDAR.TabIndex = 40
        Me.LBL_GUARDAR.Text = "GUARDAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1103, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CANCELAR"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(981, 66)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(83, 83)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1107, 66)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(83, 83)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(90, 90)
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
        Me.lbl_emp.Location = New System.Drawing.Point(542, 52)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 79
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(435, 52)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(101, 22)
        Me.Empleado.TabIndex = 78
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(381, 49)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 77
        Me.buscar_EN.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(166, 49)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 28)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(83, 56)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 76
        Me.lbl_num.Text = "Numero:"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.TXT_EST)
        Me.Panel14.Controls.Add(Me.LBL_GUARDAR)
        Me.Panel14.Controls.Add(Me.txt_resultado)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.SAVE)
        Me.Panel14.Controls.Add(Me.Label5)
        Me.Panel14.Controls.Add(Me.Label1)
        Me.Panel14.Controls.Add(Me.CANCEL)
        Me.Panel14.Controls.Add(Me.txt_fp)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.TXT_FECHA)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Empleado)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Controls.Add(Me.lbl_emp)
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(15, 22)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1241, 250)
        Me.Panel14.TabIndex = 91
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1241, 35)
        Me.Panel2.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(13, 6)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(221, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Agregar Examenes Medicos"
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
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Friend WithEvents LBL_GUARDAR As Label
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
    Friend WithEvents TXT_EST As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_EM As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents EM_Estudio As DataGridViewTextBoxColumn
    Friend WithEvents EM_Resultado As DataGridViewTextBoxColumn
    Friend WithEvents EM_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents EM_FechaProximo As DataGridViewTextBoxColumn
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
End Class
