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
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_EM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EM_FechaProximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.TXT_EST = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.txt_fp = New System.Windows.Forms.DateTimePicker()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PnlExamenes = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlExamenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PnlExamenes)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 730)
        Me.Panel1.TabIndex = 1
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_EM, Me.ID_Emp, Me.EM_Estudio, Me.EM_Resultado, Me.EM_Fecha, Me.EM_FechaProximo})
        Me.dgv_equipo_Eval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(0, 0)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(962, 475)
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
        Me.ID_EM.Visible = False
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
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.TXT_EST)
        Me.Panel14.Controls.Add(Me.txt_resultado)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Label1)
        Me.Panel14.Controls.Add(Me.txt_fp)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.TXT_FECHA)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Empleado)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Controls.Add(Me.lbl_emp)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(962, 250)
        Me.Panel14.TabIndex = 91
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.CANCEL)
        Me.Panel2.Controls.Add(Me.SAVE)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 40)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Resultado:"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_checkup_80px
        Me.SAVE.Location = New System.Drawing.Point(864, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(40, 40)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
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
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(910, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(40, 40)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'txt_fp
        '
        Me.txt_fp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fp.Location = New System.Drawing.Point(166, 185)
        Me.txt_fp.Name = "txt_fp"
        Me.txt_fp.Size = New System.Drawing.Size(245, 28)
        Me.txt_fp.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(166, 49)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 28)
        Me.txt_numero.TabIndex = 0
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
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(83, 56)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 76
        Me.lbl_num.Text = "Numero:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(166, 151)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 28)
        Me.TXT_FECHA.TabIndex = 3
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'PnlExamenes
        '
        Me.PnlExamenes.Controls.Add(Me.dgv_equipo_Eval)
        Me.PnlExamenes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlExamenes.Location = New System.Drawing.Point(0, 255)
        Me.PnlExamenes.Name = "PnlExamenes"
        Me.PnlExamenes.Size = New System.Drawing.Size(962, 475)
        Me.PnlExamenes.TabIndex = 92
        '
        'Examenes_Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 730)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Examenes_Medicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examenes_Medicos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlExamenes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
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
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_EM As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents EM_Estudio As DataGridViewTextBoxColumn
    Friend WithEvents EM_Resultado As DataGridViewTextBoxColumn
    Friend WithEvents EM_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents EM_FechaProximo As DataGridViewTextBoxColumn
    Friend WithEvents PnlExamenes As Panel
End Class
