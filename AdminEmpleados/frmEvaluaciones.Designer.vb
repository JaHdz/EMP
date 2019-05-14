<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvaluaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvaluaciones))
        Me.dgv_Evaluaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.buscar_EV = New System.Windows.Forms.PictureBox()
        Me.EV = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.EV2 = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_Evaluaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Evaluaciones
        '
        Me.dgv_Evaluaciones.AllowUserToAddRows = False
        Me.dgv_Evaluaciones.AllowUserToDeleteRows = False
        Me.dgv_Evaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Evaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Evaluaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE})
        Me.dgv_Evaluaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Evaluaciones.Location = New System.Drawing.Point(0, 358)
        Me.dgv_Evaluaciones.Name = "dgv_Evaluaciones"
        Me.dgv_Evaluaciones.ReadOnly = True
        Me.dgv_Evaluaciones.RowHeadersVisible = False
        Me.dgv_Evaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Evaluaciones.Size = New System.Drawing.Size(1078, 341)
        Me.dgv_Evaluaciones.TabIndex = 76
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label1)
        Me.Panel14.Controls.Add(Me.dtpFecha)
        Me.Panel14.Controls.Add(Me.txtEmpleado)
        Me.Panel14.Controls.Add(Me.dgv_Evaluaciones)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.TXT_commen)
        Me.Panel14.Controls.Add(Me.label8)
        Me.Panel14.Controls.Add(Me.buscar_EV)
        Me.Panel14.Controls.Add(Me.EV)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.EV2)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 699)
        Me.Panel14.TabIndex = 81
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleado.Location = New System.Drawing.Point(126, 59)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(294, 25)
        Me.txtEmpleado.TabIndex = 77
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
        Me.Label42.Size = New System.Drawing.Size(173, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Agregar Evaluaciones"
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
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(1043, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(35, 35)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.TXT_commen.Location = New System.Drawing.Point(126, 155)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(325, 83)
        Me.TXT_commen.TabIndex = 2
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.label8.Location = New System.Drawing.Point(23, 166)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(85, 18)
        Me.label8.TabIndex = 74
        Me.label8.Text = "Comentario:"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'buscar_EV
        '
        Me.buscar_EV.BackgroundImage = CType(resources.GetObject("buscar_EV.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EV.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EV.Location = New System.Drawing.Point(426, 90)
        Me.buscar_EV.Name = "buscar_EV"
        Me.buscar_EV.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EV.TabIndex = 69
        Me.buscar_EV.TabStop = False
        '
        'EV
        '
        Me.EV.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.EV.Location = New System.Drawing.Point(114, 90)
        Me.EV.Name = "EV"
        Me.EV.Size = New System.Drawing.Size(0, 25)
        Me.EV.TabIndex = 1
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_numero.Location = New System.Drawing.Point(114, 59)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(0, 25)
        Me.txt_numero.TabIndex = 0
        Me.txt_numero.Visible = False
        '
        'EV2
        '
        Me.EV2.Enabled = False
        Me.EV2.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.EV2.Location = New System.Drawing.Point(126, 90)
        Me.EV2.Name = "EV2"
        Me.EV2.Size = New System.Drawing.Size(294, 25)
        Me.EV2.TabIndex = 68
        Me.EV2.TabStop = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(32, 62)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(76, 18)
        Me.lbl_num.TabIndex = 57
        Me.lbl_num.Text = "Empleado:"
        Me.lbl_num.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label92.Location = New System.Drawing.Point(24, 93)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(84, 18)
        Me.Label92.TabIndex = 67
        Me.Label92.Text = "Evaluacion:"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(426, 59)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 58
        Me.buscar_EN.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(126, 121)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(325, 28)
        Me.dtpFecha.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DELETE.Name = "DELETE"
        Me.DELETE.ReadOnly = True
        '
        'frmEvaluaciones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 699)
        Me.Controls.Add(Me.Panel14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEvaluaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluaciones"
        CType(Me.dgv_Evaluaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents dgv_Evaluaciones As DataGridView
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents label8 As Label
    Friend WithEvents buscar_EV As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents EV As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents EV2 As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents DELETE As DataGridViewImageColumn
End Class
