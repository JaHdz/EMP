<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEquipo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlEquipo = New System.Windows.Forms.Panel()
        Me.dgvEquipoEmp = New System.Windows.Forms.DataGridView()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtEmpleadoNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpleadoNumero = New System.Windows.Forms.TextBox()
        Me.txtEquipoNumero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.txtEquipoNombre = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.RegresarEquipo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pb_Report = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.buscar_eq = New System.Windows.Forms.PictureBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.gbComentarios = New System.Windows.Forms.GroupBox()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.dgvEquipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pb_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbComentarios.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1078, 699)
        Me.Panel1.TabIndex = 1
        '
        'pnlEquipo
        '
        Me.pnlEquipo.Controls.Add(Me.dgvEquipoEmp)
        Me.pnlEquipo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlEquipo.Location = New System.Drawing.Point(0, 300)
        Me.pnlEquipo.Name = "pnlEquipo"
        Me.pnlEquipo.Size = New System.Drawing.Size(1078, 399)
        Me.pnlEquipo.TabIndex = 81
        '
        'dgvEquipoEmp
        '
        Me.dgvEquipoEmp.AllowUserToAddRows = False
        Me.dgvEquipoEmp.AllowUserToDeleteRows = False
        Me.dgvEquipoEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEquipoEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipoEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegresarEquipo})
        Me.dgvEquipoEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEquipoEmp.Location = New System.Drawing.Point(0, 0)
        Me.dgvEquipoEmp.Name = "dgvEquipoEmp"
        Me.dgvEquipoEmp.ReadOnly = True
        Me.dgvEquipoEmp.RowHeadersVisible = False
        Me.dgvEquipoEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipoEmp.Size = New System.Drawing.Size(1078, 399)
        Me.dgvEquipoEmp.TabIndex = 71
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.gbComentarios)
        Me.Panel14.Controls.Add(Me.txtEmpleadoNombre)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.TXT_FECHA)
        Me.Panel14.Controls.Add(Me.buscar_eq)
        Me.Panel14.Controls.Add(Me.txtEmpleadoNumero)
        Me.Panel14.Controls.Add(Me.txtEquipoNumero)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.txtEquipoNombre)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 699)
        Me.Panel14.TabIndex = 80
        '
        'txtEmpleadoNombre
        '
        Me.txtEmpleadoNombre.Enabled = False
        Me.txtEmpleadoNombre.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNombre.Location = New System.Drawing.Point(171, 53)
        Me.txtEmpleadoNombre.Name = "txtEmpleadoNombre"
        Me.txtEmpleadoNombre.Size = New System.Drawing.Size(209, 25)
        Me.txtEmpleadoNombre.TabIndex = 73
        Me.txtEmpleadoNombre.TabStop = False
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
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lbl_ingreso.Location = New System.Drawing.Point(86, 121)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(71, 21)
        Me.lbl_ingreso.TabIndex = 67
        Me.lbl_ingreso.Text = "Ingreso:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(163, 119)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(240, 25)
        Me.TXT_FECHA.TabIndex = 2
        '
        'txtEmpleadoNumero
        '
        Me.txtEmpleadoNumero.Enabled = False
        Me.txtEmpleadoNumero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNumero.Location = New System.Drawing.Point(155, 53)
        Me.txtEmpleadoNumero.Name = "txtEmpleadoNumero"
        Me.txtEmpleadoNumero.Size = New System.Drawing.Size(10, 25)
        Me.txtEmpleadoNumero.TabIndex = 0
        Me.txtEmpleadoNumero.Visible = False
        '
        'txtEquipoNumero
        '
        Me.txtEquipoNumero.Enabled = False
        Me.txtEquipoNumero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEquipoNumero.Location = New System.Drawing.Point(155, 84)
        Me.txtEquipoNumero.Name = "txtEquipoNumero"
        Me.txtEquipoNumero.Size = New System.Drawing.Size(10, 25)
        Me.txtEquipoNumero.TabIndex = 1
        Me.txtEquipoNumero.Visible = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(67, 55)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(90, 21)
        Me.lbl_num.TabIndex = 13
        Me.lbl_num.Text = "Empleado:"
        '
        'txtEquipoNombre
        '
        Me.txtEquipoNombre.Enabled = False
        Me.txtEquipoNombre.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEquipoNombre.Location = New System.Drawing.Point(171, 84)
        Me.txtEquipoNombre.Name = "txtEquipoNombre"
        Me.txtEquipoNombre.Size = New System.Drawing.Size(209, 25)
        Me.txtEquipoNombre.TabIndex = 64
        Me.txtEquipoNombre.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Label92.Location = New System.Drawing.Point(90, 86)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(67, 21)
        Me.Label92.TabIndex = 63
        Me.Label92.Text = "Equipo:"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Regresar"
        Me.DataGridViewImageColumn2.Image = Global.AdminEmpleados.My.Resources.Resources.Undo_80px
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 1075
        '
        'RegresarEquipo
        '
        Me.RegresarEquipo.HeaderText = "Regresar"
        Me.RegresarEquipo.Image = Global.AdminEmpleados.My.Resources.Resources.Undo_80px
        Me.RegresarEquipo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.RegresarEquipo.Name = "RegresarEquipo"
        Me.RegresarEquipo.ReadOnly = True
        '
        'pb_Report
        '
        Me.pb_Report.Dock = System.Windows.Forms.DockStyle.Right
        Me.pb_Report.Image = Global.AdminEmpleados.My.Resources.Resources.AssignedTools_80px
        Me.pb_Report.Location = New System.Drawing.Point(969, 0)
        Me.pb_Report.Name = "pb_Report"
        Me.pb_Report.Size = New System.Drawing.Size(35, 35)
        Me.pb_Report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Report.TabIndex = 71
        Me.pb_Report.TabStop = False
        Me.pb_Report.Visible = False
        '
        'CANCEL
        '
        Me.CANCEL.Dock = System.Windows.Forms.DockStyle.Right
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1004, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'SAVE
        '
        Me.SAVE.Dock = System.Windows.Forms.DockStyle.Right
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Tools_80px
        Me.SAVE.Location = New System.Drawing.Point(1039, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(35, 35)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'buscar_eq
        '
        Me.buscar_eq.BackgroundImage = CType(resources.GetObject("buscar_eq.BackgroundImage"), System.Drawing.Image)
        Me.buscar_eq.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_eq.Location = New System.Drawing.Point(386, 84)
        Me.buscar_eq.Name = "buscar_eq"
        Me.buscar_eq.Size = New System.Drawing.Size(25, 25)
        Me.buscar_eq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_eq.TabIndex = 65
        Me.buscar_eq.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(386, 53)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 53
        Me.buscar_EN.TabStop = False
        '
        'gbComentarios
        '
        Me.gbComentarios.Controls.Add(Me.TXT_commen)
        Me.gbComentarios.Location = New System.Drawing.Point(423, 56)
        Me.gbComentarios.Name = "gbComentarios"
        Me.gbComentarios.Size = New System.Drawing.Size(531, 91)
        Me.gbComentarios.TabIndex = 74
        Me.gbComentarios.TabStop = False
        Me.gbComentarios.Text = "Comentarios:"
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_commen.Location = New System.Drawing.Point(3, 24)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(525, 64)
        Me.TXT_commen.TabIndex = 3
        '
        'FrmEquipo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1078, 699)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipo"
        Me.Panel1.ResumeLayout(False)
        Me.pnlEquipo.ResumeLayout(False)
        CType(Me.dgvEquipoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pb_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_eq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbComentarios.ResumeLayout(False)
        Me.gbComentarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmpleadoNumero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents buscar_eq As PictureBox
    Friend WithEvents txtEquipoNumero As TextBox
    Friend WithEvents txtEquipoNombre As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Friend WithEvents dgvEquipoEmp As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents pb_Report As PictureBox
    Friend WithEvents cUPDATE As DataGridViewImageColumn
    Friend WithEvents pnlEquipo As Panel
    Friend WithEvents RegresarEquipo As DataGridViewImageColumn
    Friend WithEvents txtEmpleadoNombre As TextBox
    Friend WithEvents gbComentarios As GroupBox
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
