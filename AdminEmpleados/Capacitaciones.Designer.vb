﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.dgv_equipo_Eval = New System.Windows.Forms.DataGridView()
        Me.DELETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Cap_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.TXT_commen = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_CAP = New System.Windows.Forms.PictureBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.CAP = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.CAP2 = New System.Windows.Forms.TextBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_CAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgv_equipo_Eval)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 412)
        Me.Panel1.TabIndex = 1
        '
        'dgv_equipo_Eval
        '
        Me.dgv_equipo_Eval.AllowUserToAddRows = False
        Me.dgv_equipo_Eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_Eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DELETE, Me.ID_Cap_Emp, Me.ID_Cap, Me.ID_Emp, Me.Fecha, Me.Comentario})
        Me.dgv_equipo_Eval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_equipo_Eval.Location = New System.Drawing.Point(0, 0)
        Me.dgv_equipo_Eval.Name = "dgv_equipo_Eval"
        Me.dgv_equipo_Eval.RowHeadersVisible = False
        Me.dgv_equipo_Eval.Size = New System.Drawing.Size(962, 412)
        Me.dgv_equipo_Eval.TabIndex = 90
        '
        'DELETE
        '
        Me.DELETE.HeaderText = "Eliminar"
        Me.DELETE.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
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
        Me.Comentario.Width = 800
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Eliminar"
        Me.DataGridViewImageColumn1.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.lbl_ingreso)
        Me.Panel14.Controls.Add(Me.TXT_FECHA)
        Me.Panel14.Controls.Add(Me.Panel2)
        Me.Panel14.Controls.Add(Me.TXT_commen)
        Me.Panel14.Controls.Add(Me.label8)
        Me.Panel14.Controls.Add(Me.Empleado)
        Me.Panel14.Controls.Add(Me.buscar_CAP)
        Me.Panel14.Controls.Add(Me.lbl_num)
        Me.Panel14.Controls.Add(Me.CAP)
        Me.Panel14.Controls.Add(Me.txt_numero)
        Me.Panel14.Controls.Add(Me.CAP2)
        Me.Panel14.Controls.Add(Me.buscar_EN)
        Me.Panel14.Controls.Add(Me.Label92)
        Me.Panel14.Controls.Add(Me.lbl_emp)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(962, 313)
        Me.Panel14.TabIndex = 844
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(87, 151)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(59, 21)
        Me.lbl_ingreso.TabIndex = 91
        Me.lbl_ingreso.Text = "Fecha:"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(152, 145)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(245, 28)
        Me.TXT_FECHA.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Controls.Add(Me.SAVE)
        Me.Panel2.Controls.Add(Me.CANCEL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(962, 40)
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
        Me.Label42.Size = New System.Drawing.Size(190, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Agregar Capacitaciones"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Training_80px
        Me.SAVE.Location = New System.Drawing.Point(854, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(45, 40)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(905, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(45, 40)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'TXT_commen
        '
        Me.TXT_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_commen.Location = New System.Drawing.Point(152, 188)
        Me.TXT_commen.Multiline = True
        Me.TXT_commen.Name = "TXT_commen"
        Me.TXT_commen.Size = New System.Drawing.Size(427, 83)
        Me.TXT_commen.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(38, 188)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(109, 21)
        Me.label8.TabIndex = 87
        Me.label8.Text = "Comentario: "
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(416, 68)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(101, 22)
        Me.Empleado.TabIndex = 80
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_CAP
        '
        Me.buscar_CAP.BackgroundImage = CType(resources.GetObject("buscar_CAP.BackgroundImage"), System.Drawing.Image)
        Me.buscar_CAP.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_CAP.Location = New System.Drawing.Point(366, 103)
        Me.buscar_CAP.Name = "buscar_CAP"
        Me.buscar_CAP.Size = New System.Drawing.Size(30, 28)
        Me.buscar_CAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_CAP.TabIndex = 85
        Me.buscar_CAP.TabStop = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(69, 66)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 78
        Me.lbl_num.Text = "Numero:"
        '
        'CAP
        '
        Me.CAP.Location = New System.Drawing.Point(152, 104)
        Me.CAP.Name = "CAP"
        Me.CAP.Size = New System.Drawing.Size(39, 28)
        Me.CAP.TabIndex = 1
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(152, 63)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 28)
        Me.txt_numero.TabIndex = 0
        '
        'CAP2
        '
        Me.CAP2.Enabled = False
        Me.CAP2.Location = New System.Drawing.Point(197, 104)
        Me.CAP2.Name = "CAP2"
        Me.CAP2.Size = New System.Drawing.Size(164, 28)
        Me.CAP2.TabIndex = 842
        Me.CAP2.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(367, 63)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 79
        Me.buscar_EN.TabStop = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(34, 107)
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
        Me.lbl_emp.Location = New System.Drawing.Point(523, 54)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 81
        '
        'Capacitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 730)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Capacitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacitaciones"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_equipo_Eval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_CAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents dgv_equipo_Eval As DataGridView
    Friend WithEvents DELETE As DataGridViewImageColumn
    Friend WithEvents ID_Cap_Emp As DataGridViewTextBoxColumn
    Friend WithEvents ID_Cap As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Comentario As DataGridViewTextBoxColumn
    Private WithEvents Panel14 As Panel
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents TXT_FECHA As DateTimePicker
    Private WithEvents Panel2 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents TXT_commen As TextBox
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents label8 As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_CAP As PictureBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents CAP As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents CAP2 As TextBox
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents Label92 As Label
    Friend WithEvents lbl_emp As Label
End Class
