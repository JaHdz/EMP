<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Evaluaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evaluaciones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_EvEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
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
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgv_equipo_Eval)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1078, 412)
        Me.Panel1.TabIndex = 1
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_EvEmp, Me.ID_Codigo, Me.ID_Emp, Me.Fecha, Me.Estatus, Me.ID_User})
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(0, 0)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(1072, 412)
        Me.dgv_equipo_Eval.TabIndex = 76
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DELETE.Name = "DELETE"
        '
        'ID_EvEmp
        '
        Me.ID_EvEmp.DataPropertyName = "ID_EvEmp"
        Me.ID_EvEmp.HeaderText = "ID"
        Me.ID_EvEmp.Name = "ID_EvEmp"
        Me.ID_EvEmp.Width = 50
        '
        'ID_Codigo
        '
        Me.ID_Codigo.DataPropertyName = "ID_Codigo"
        Me.ID_Codigo.HeaderText = "EVALUACION"
        Me.ID_Codigo.Name = "ID_Codigo"
        Me.ID_Codigo.Width = 200
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
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "COMENTARIO"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Width = 600
        '
        'ID_User
        '
        Me.ID_User.DataPropertyName = "ID_User"
        Me.ID_User.HeaderText = "CAPTURO"
        Me.ID_User.Name = "ID_User"
        Me.ID_User.Width = 200
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Panel14
        '
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
        Me.Panel14.Controls.Add(Me.lbl_emp)
        Me.Panel14.Controls.Add(Me.Empleado)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1078, 287)
        Me.Panel14.TabIndex = 81
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
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1020, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(979, 0)
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
        Me.TXT_commen.Location = New System.Drawing.Point(126, 149)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(427, 83)
        Me.TXT_commen.TabIndex = 2
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.label8.Location = New System.Drawing.Point(26, 149)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(90, 18)
        Me.label8.TabIndex = 74
        Me.label8.Text = "Comentario: "
        '
        'buscar_EV
        '
        Me.buscar_EV.BackgroundImage = CType(resources.GetObject("buscar_EV.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EV.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EV.Location = New System.Drawing.Point(340, 89)
        Me.buscar_EV.Name = "buscar_EV"
        Me.buscar_EV.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EV.TabIndex = 69
        Me.buscar_EV.TabStop = False
        '
        'EV
        '
        Me.EV.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.EV.Location = New System.Drawing.Point(126, 90)
        Me.EV.Name = "EV"
        Me.EV.Size = New System.Drawing.Size(39, 25)
        Me.EV.TabIndex = 1
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_numero.Location = New System.Drawing.Point(126, 59)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 25)
        Me.txt_numero.TabIndex = 0
        '
        'EV2
        '
        Me.EV2.Enabled = False
        Me.EV2.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.EV2.Location = New System.Drawing.Point(171, 90)
        Me.EV2.Name = "EV2"
        Me.EV2.Size = New System.Drawing.Size(164, 25)
        Me.EV2.TabIndex = 68
        Me.EV2.TabStop = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(48, 61)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(62, 18)
        Me.lbl_num.TabIndex = 57
        Me.lbl_num.Text = "Numero:"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Label92.Location = New System.Drawing.Point(31, 93)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(84, 18)
        Me.Label92.TabIndex = 67
        Me.Label92.Text = "Evaluacion:"
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(341, 59)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 58
        Me.buscar_EN.TabStop = False
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(497, 64)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 18)
        Me.lbl_emp.TabIndex = 60
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(390, 64)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(81, 18)
        Me.Empleado.TabIndex = 59
        Me.Empleado.Text = "Empleado: "
        '
        'Evaluaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 699)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Evaluaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluaciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents dgv_equipo_Eval As DataGridView
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_EvEmp As DataGridViewTextBoxColumn
    Friend WithEvents ID_Codigo As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents ID_User As DataGridViewTextBoxColumn
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
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
End Class
