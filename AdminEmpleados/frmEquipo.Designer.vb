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
        Me.lblAsignar = New System.Windows.Forms.Label()
        Me.txtEmpleadoNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtEmpleadoNumero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAsignarEquipo = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.VerVale = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NumeroDeVale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignadoPorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignadoPor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnlEquipo.SuspendLayout()
        CType(Me.dgvEquipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnAsignarEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvEquipoEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VerVale, Me.NumeroDeVale, Me.EmpleadoID, Me.Empleado, Me.AsignadoPorID, Me.AsignadoPor, Me.Activo})
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
        Me.Panel14.Controls.Add(Me.lblAsignar)
        Me.Panel14.Controls.Add(Me.btnAsignarEquipo)
        Me.Panel14.Controls.Add(Me.txtEmpleadoNombre)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.txtEmpleadoNumero)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 699)
        Me.Panel14.TabIndex = 80
        '
        'lblAsignar
        '
        Me.lblAsignar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lblAsignar.Location = New System.Drawing.Point(363, 49)
        Me.lblAsignar.Name = "lblAsignar"
        Me.lblAsignar.Size = New System.Drawing.Size(144, 21)
        Me.lblAsignar.TabIndex = 75
        Me.lblAsignar.Text = "Asignar equipo "
        Me.lblAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAsignar.Visible = False
        '
        'txtEmpleadoNombre
        '
        Me.txtEmpleadoNombre.Enabled = False
        Me.txtEmpleadoNombre.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNombre.Location = New System.Drawing.Point(117, 47)
        Me.txtEmpleadoNombre.Name = "txtEmpleadoNombre"
        Me.txtEmpleadoNombre.Size = New System.Drawing.Size(209, 25)
        Me.txtEmpleadoNombre.TabIndex = 73
        Me.txtEmpleadoNombre.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.CANCEL)
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
        'txtEmpleadoNumero
        '
        Me.txtEmpleadoNumero.Enabled = False
        Me.txtEmpleadoNumero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNumero.Location = New System.Drawing.Point(101, 47)
        Me.txtEmpleadoNumero.Name = "txtEmpleadoNumero"
        Me.txtEmpleadoNumero.Size = New System.Drawing.Size(10, 25)
        Me.txtEmpleadoNumero.TabIndex = 0
        Me.txtEmpleadoNumero.Visible = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(13, 49)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(90, 21)
        Me.lbl_num.TabIndex = 13
        Me.lbl_num.Text = "Empleado:"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewImageColumn2.FillWeight = 291.8782!
        Me.DataGridViewImageColumn2.HeaderText = "Regresar"
        Me.DataGridViewImageColumn2.Image = Global.AdminEmpleados.My.Resources.Resources.Undo_80px
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 29
        '
        'btnAsignarEquipo
        '
        Me.btnAsignarEquipo.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Tools_80px
        Me.btnAsignarEquipo.Location = New System.Drawing.Point(513, 47)
        Me.btnAsignarEquipo.Name = "btnAsignarEquipo"
        Me.btnAsignarEquipo.Size = New System.Drawing.Size(25, 25)
        Me.btnAsignarEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAsignarEquipo.TabIndex = 74
        Me.btnAsignarEquipo.TabStop = False
        Me.btnAsignarEquipo.Visible = False
        '
        'CANCEL
        '
        Me.CANCEL.Dock = System.Windows.Forms.DockStyle.Right
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1039, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(332, 47)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 53
        Me.buscar_EN.TabStop = False
        '
        'VerVale
        '
        Me.VerVale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.VerVale.FillWeight = 291.8782!
        Me.VerVale.HeaderText = "Ver"
        Me.VerVale.Image = CType(resources.GetObject("VerVale.Image"), System.Drawing.Image)
        Me.VerVale.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.VerVale.Name = "VerVale"
        Me.VerVale.ReadOnly = True
        Me.VerVale.ToolTipText = "Ver vale de equipo asignado"
        Me.VerVale.Width = 42
        '
        'NumeroDeVale
        '
        Me.NumeroDeVale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroDeVale.DataPropertyName = "ID"
        Me.NumeroDeVale.FillWeight = 52.03046!
        Me.NumeroDeVale.HeaderText = "No. de vale"
        Me.NumeroDeVale.Name = "NumeroDeVale"
        Me.NumeroDeVale.ReadOnly = True
        '
        'EmpleadoID
        '
        Me.EmpleadoID.DataPropertyName = "EmpleadoID"
        Me.EmpleadoID.HeaderText = "EmpleadoID"
        Me.EmpleadoID.Name = "EmpleadoID"
        Me.EmpleadoID.ReadOnly = True
        Me.EmpleadoID.Visible = False
        '
        'Empleado
        '
        Me.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Empleado.DataPropertyName = "Empleado"
        Me.Empleado.FillWeight = 52.03046!
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'AsignadoPorID
        '
        Me.AsignadoPorID.DataPropertyName = "AsignadoPorID"
        Me.AsignadoPorID.HeaderText = "AsignadoPorID"
        Me.AsignadoPorID.Name = "AsignadoPorID"
        Me.AsignadoPorID.ReadOnly = True
        Me.AsignadoPorID.Visible = False
        '
        'AsignadoPor
        '
        Me.AsignadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AsignadoPor.DataPropertyName = "AsignadoPor"
        Me.AsignadoPor.FillWeight = 52.03046!
        Me.AsignadoPor.HeaderText = "Asignado Por"
        Me.AsignadoPor.Name = "AsignadoPor"
        Me.AsignadoPor.ReadOnly = True
        '
        'Activo
        '
        Me.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Activo.DataPropertyName = "Activo"
        Me.Activo.FillWeight = 52.03046!
        Me.Activo.HeaderText = "¿Esta Activo?"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Width = 134
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
        CType(Me.btnAsignarEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmpleadoNumero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents dgvEquipoEmp As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents cUPDATE As DataGridViewImageColumn
    Friend WithEvents pnlEquipo As Panel
    Friend WithEvents txtEmpleadoNombre As TextBox
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents lblAsignar As Label
    Friend WithEvents btnAsignarEquipo As PictureBox
    Friend WithEvents VerVale As DataGridViewImageColumn
    Friend WithEvents NumeroDeVale As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoID As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents AsignadoPorID As DataGridViewTextBoxColumn
    Friend WithEvents AsignadoPor As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
End Class
