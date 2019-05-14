<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenesMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamenesMedicos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgv_Examenes = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TXT_EST = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaProxima = New System.Windows.Forms.DateTimePicker()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.dgv_Examenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 699)
        Me.Panel1.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.txtNombre)
        Me.Panel14.Controls.Add(Me.dgv_Examenes)
        Me.Panel14.Controls.Add(Me.TXT_EST)
        Me.Panel14.Controls.Add(Me.txt_resultado)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.Label1)
        Me.Panel14.Controls.Add(Me.dtpFechaProxima)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.dtpFecha)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 699)
        Me.Panel14.TabIndex = 91
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(169, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 25)
        Me.txtNombre.TabIndex = 91
        '
        'dgv_Examenes
        '
        Me.dgv_Examenes.AllowUserToAddRows = False
        Me.dgv_Examenes.AllowUserToDeleteRows = False
        Me.dgv_Examenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Examenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE})
        Me.dgv_Examenes.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgv_Examenes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Examenes.Location = New System.Drawing.Point(0, 360)
        Me.dgv_Examenes.Name = "dgv_Examenes"
        Me.dgv_Examenes.ReadOnly = True
        Me.dgv_Examenes.RowHeadersVisible = False
        Me.dgv_Examenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Examenes.Size = New System.Drawing.Size(1078, 339)
        Me.dgv_Examenes.TabIndex = 89
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DELETE.Name = "DELETE"
        Me.DELETE.ReadOnly = True
        '
        'TXT_EST
        '
        Me.TXT_EST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_EST.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.TXT_EST.Location = New System.Drawing.Point(169, 92)
        Me.TXT_EST.Name = "TXT_EST"
        Me.TXT_EST.Size = New System.Drawing.Size(268, 25)
        Me.TXT_EST.TabIndex = 1
        '
        'txt_resultado
        '
        Me.txt_resultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_resultado.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_resultado.Location = New System.Drawing.Point(169, 126)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(268, 25)
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
        Me.Panel2.Size = New System.Drawing.Size(1078, 35)
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
        Me.Label42.UseWaitCursor = True
        '
        'CANCEL
        '
        Me.CANCEL.Dock = System.Windows.Forms.DockStyle.Right
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1008, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'SAVE
        '
        Me.SAVE.Dock = System.Windows.Forms.DockStyle.Right
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_checkup_80px
        Me.SAVE.Location = New System.Drawing.Point(1043, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(35, 35)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(76, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Resultado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(41, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Proxima:"
        '
        'dtpFechaProxima
        '
        Me.dtpFechaProxima.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.dtpFechaProxima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProxima.Location = New System.Drawing.Point(169, 194)
        Me.dtpFechaProxima.Name = "dtpFechaProxima"
        Me.dtpFechaProxima.Size = New System.Drawing.Size(268, 25)
        Me.dtpFechaProxima.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_numero.Location = New System.Drawing.Point(160, 58)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(0, 25)
        Me.txt_numero.TabIndex = 0
        Me.txt_numero.Visible = False
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_ingreso.Location = New System.Drawing.Point(101, 163)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(50, 18)
        Me.lbl_ingreso.TabIndex = 84
        Me.lbl_ingreso.Text = "Fecha:"
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(75, 61)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(76, 18)
        Me.lbl_num.TabIndex = 76
        Me.lbl_num.Text = "Empleado:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(169, 160)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(268, 25)
        Me.dtpFecha.TabIndex = 3
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(443, 58)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 77
        Me.buscar_EN.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label92.Location = New System.Drawing.Point(89, 95)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(62, 18)
        Me.Label92.TabIndex = 80
        Me.Label92.Text = "Estudio:"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'frmExamenesMedicos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1078, 699)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExamenesMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examenes_Medicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.dgv_Examenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents Label92 As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaProxima As DateTimePicker
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_EST As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents dgv_Examenes As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents DELETE As DataGridViewImageColumn
End Class
