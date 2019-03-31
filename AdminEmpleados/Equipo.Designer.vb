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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Equipo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.dgv_equipo_emp = New System.Windows.Forms.DataGridView()
        Me.UPDATE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Assig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Regreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.pnl_comen = New System.Windows.Forms.Panel()
        Me.gbComentarios = New System.Windows.Forms.GroupBox()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.pb_Report = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.buscar_eq = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Eq = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.eq2 = New System.Windows.Forms.TextBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.pnl_comen.SuspendLayout()
        Me.gbComentarios.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pb_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.pnlEquipo)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 730)
        Me.Panel1.TabIndex = 1
        '
        'pnlEquipo
        '
        Me.pnlEquipo.Controls.Add(Me.dgv_equipo_emp)
        Me.pnlEquipo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlEquipo.Location = New System.Drawing.Point(0, 331)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(1078, 399)
        Me.pnlEquipo.TabIndex = 81
        '
        'dgv_equipo_emp
        '
        Me.dgv_equipo_emp.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_equipo_emp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_equipo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATE, Me.ID_Assig, Me.ID_Equipo, Me.ID_Emp, Me.Fecha, Me.Regreso, Me.Fecha_R, Me.Comentario, Me.ID_User})
        Me.dgv_equipo_emp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_equipo_emp.Location = New System.Drawing.Point(0, 0)
        Me.dgv_equipo_emp.Name = "dgv_equipo_emp"
        Me.dgv_equipo_emp.RowHeadersVisible = False
        Me.dgv_equipo_emp.Size = New System.Drawing.Size(1078, 399)
        Me.dgv_equipo_emp.TabIndex = 71
        '
        'UPDATE
        '
        Me.UPDATE.HeaderText = "Regresar"
        Me.UPDATE.Name = "UPDATE"
        '
        'ID_Assig
        '
        Me.ID_Assig.DataPropertyName = "ID_Assig"
        Me.ID_Assig.HeaderText = "ID"
        Me.ID_Assig.Name = "ID_Assig"
        Me.ID_Assig.Visible = False
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
        Me.Fecha.Width = 150
        '
        'Regreso
        '
        Me.Regreso.DataPropertyName = "Regreso"
        Me.Regreso.HeaderText = "REGRESO?"
        Me.Regreso.Name = "Regreso"
        Me.Regreso.Width = 150
        '
        'Fecha_R
        '
        Me.Fecha_R.DataPropertyName = "Fecha_R"
        Me.Fecha_R.HeaderText = "FECHA REGRESO"
        Me.Fecha_R.Name = "Fecha_R"
        Me.Fecha_R.Width = 150
        '
        'Comentario
        '
        Me.Comentario.DataPropertyName = "Comentario"
        Me.Comentario.HeaderText = "COMENTARIO"
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Width = 300
        '
        'ID_User
        '
        Me.ID_User.DataPropertyName = "ID_User"
        Me.ID_User.HeaderText = "NO EMPLEADO"
        Me.ID_User.Name = "ID_User"
        Me.ID_User.Width = 150
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.pnl_comen)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.TXT_FECHA)
        Me.Panel14.Controls.Add(Me.buscar_eq)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.Eq)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.eq2)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Controls.Add(Me.Empleado)
        Me.Panel14.Controls.Add(Me.lbl_emp)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 730)
        Me.Panel14.TabIndex = 80
        '
        'pnl_comen
        '
        Me.pnl_comen.Controls.Add(Me.gbComentarios)
        Me.pnl_comen.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.pnl_comen.Location = New System.Drawing.Point(32, 190)
        Me.pnl_comen.Name = "pnl_comen"
        Me.pnl_comen.Size = New System.Drawing.Size(931, 130)
        Me.pnl_comen.TabIndex = 72
        Me.pnl_comen.Visible = False
        '
        'gbComentarios
        '
        Me.gbComentarios.Controls.Add(Me.TXT_commen)
        Me.gbComentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbComentarios.Location = New System.Drawing.Point(0, 0)
        Me.gbComentarios.Name = "gbComentarios"
        Me.gbComentarios.Size = New System.Drawing.Size(931, 130)
        Me.gbComentarios.TabIndex = 73
        Me.gbComentarios.TabStop = False
        Me.gbComentarios.Text = "Comentarios"
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_commen.Location = New System.Drawing.Point(3, 21)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(925, 106)
        Me.TXT_commen.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.pb_Report)
        Me.Panel2.Controls.Add(Me.CANCEL)
        Me.Panel2.Controls.Add(Me.SAVE)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1074, 35)
        Me.Panel2.TabIndex = 0
        Me.Panel2.UseWaitCursor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(13, 6)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(125, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Asignar Equipo"
        Me.Label42.UseWaitCursor = True
        '
        'pb_Report
        '
        Me.pb_Report.Image = Global.AdminEmpleados.My.Resources.Resources.AssignedTools_80px
        Me.pb_Report.Location = New System.Drawing.Point(942, -2)
        Me.pb_Report.Name = "pb_Report"
        Me.pb_Report.Size = New System.Drawing.Size(35, 35)
        Me.pb_Report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Report.TabIndex = 71
        Me.pb_Report.TabStop = False
        Me.pb_Report.UseWaitCursor = True
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1024, -3)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        Me.CANCEL.UseWaitCursor = True
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Tools_80px
        Me.SAVE.Location = New System.Drawing.Point(983, -3)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(35, 35)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        Me.SAVE.UseWaitCursor = True
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_ingreso.Location = New System.Drawing.Point(38, 119)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(60, 18)
        Me.lbl_ingreso.TabIndex = 67
        Me.lbl_ingreso.Text = "Ingreso:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(117, 114)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 25)
        Me.TXT_FECHA.TabIndex = 2
        '
        'buscar_eq
        '
        Me.buscar_eq.BackgroundImage = CType(resources.GetObject("buscar_eq.BackgroundImage"), System.Drawing.Image)
        Me.buscar_eq.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_eq.Location = New System.Drawing.Point(332, 82)
        Me.buscar_eq.Name = "buscar_eq"
        Me.buscar_eq.Size = New System.Drawing.Size(30, 28)
        Me.buscar_eq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_eq.TabIndex = 65
        Me.buscar_eq.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_numero.Location = New System.Drawing.Point(117, 52)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 25)
        Me.txt_numero.TabIndex = 0
        '
        'Eq
        '
        Me.Eq.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Eq.Location = New System.Drawing.Point(117, 83)
        Me.Eq.Name = "Eq"
        Me.Eq.Size = New System.Drawing.Size(39, 25)
        Me.Eq.TabIndex = 1
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(35, 55)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(62, 18)
        Me.lbl_num.TabIndex = 13
        Me.lbl_num.Text = "Numero:"
        '
        'eq2
        '
        Me.eq2.Enabled = False
        Me.eq2.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.eq2.Location = New System.Drawing.Point(162, 83)
        Me.eq2.Name = "eq2"
        Me.eq2.Size = New System.Drawing.Size(164, 25)
        Me.eq2.TabIndex = 64
        Me.eq2.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(332, 52)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 53
        Me.buscar_EN.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label92.Location = New System.Drawing.Point(38, 90)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(59, 18)
        Me.Label92.TabIndex = 63
        Me.Label92.Text = "Equipo:"
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(386, 55)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(81, 18)
        Me.Empleado.TabIndex = 54
        Me.Empleado.Text = "Empleado: "
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(493, 55)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 18)
        Me.lbl_emp.TabIndex = 55
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 730)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Equipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipo"
        Me.Panel1.ResumeLayout(False)
        Me.pnlEquipo.ResumeLayout(False)
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.pnl_comen.ResumeLayout(False)
        Me.gbComentarios.ResumeLayout(False)
        Me.gbComentarios.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pb_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_eq As PictureBox
    Friend WithEvents Eq As TextBox
    Friend WithEvents eq2 As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Friend WithEvents dgv_equipo_emp As DataGridView
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents pb_Report As PictureBox
    Friend WithEvents pnl_comen As Panel
    Friend WithEvents cUPDATE As DataGridViewImageColumn
    Friend WithEvents ID_Assig As DataGridViewTextBoxColumn
    Friend WithEvents ID_Equipo As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Regreso As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_R As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Friend WithEvents ID_User As DataGridViewTextBoxColumn
    Friend WithEvents pnlEquipo As Panel
    Friend WithEvents gbComentarios As GroupBox
    Friend WithEvents UPDATE As DataGridViewImageColumn
End Class
