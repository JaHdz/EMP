﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administration))
        Me.tab_admin = New System.Windows.Forms.TabControl()
        Me.tab_users = New System.Windows.Forms.TabPage()
        Me.dgv_equipo_emp = New System.Windows.Forms.DataGridView()
        Me.UPDATE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp_US = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_per = New System.Windows.Forms.Panel()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.txt_pass2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.tab_capacitaciones = New System.Windows.Forms.TabPage()
        Me.DGV_CAT = New System.Windows.Forms.DataGridView()
        Me.UPDATEC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Cap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CA_Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CA_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CA_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_CAP_DESC = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TXT_CAPCODIGO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tab_depto = New System.Windows.Forms.TabPage()
        Me.dgv_depto = New System.Windows.Forms.DataGridView()
        Me.UPDATED = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Depto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_coddes = New System.Windows.Forms.TextBox()
        Me.save_cod = New System.Windows.Forms.PictureBox()
        Me.cancel_code = New System.Windows.Forms.PictureBox()
        Me.txt_depcod = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tab_Equipo = New System.Windows.Forms.TabPage()
        Me.dgv_eq = New System.Windows.Forms.DataGridView()
        Me.UPDATEEQ = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatuse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_eqcost = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_eqdesc = New System.Windows.Forms.TextBox()
        Me.save_eq = New System.Windows.Forms.PictureBox()
        Me.cancel_eq = New System.Windows.Forms.PictureBox()
        Me.txt_eqcod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tab_evaluacion = New System.Windows.Forms.TabPage()
        Me.dgv_eval = New System.Windows.Forms.DataGridView()
        Me.UPDATEE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Evalua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EV_Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EV_Descipcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EV_Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_eval_des = New System.Windows.Forms.TextBox()
        Me.SAVE_EVAL = New System.Windows.Forms.PictureBox()
        Me.CANCEL_EVAL = New System.Windows.Forms.PictureBox()
        Me.txt_evalcod = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tab_puesto = New System.Windows.Forms.TabPage()
        Me.dgv_Puesto = New System.Windows.Forms.DataGridView()
        Me.UPDATEPU = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombrep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcionp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Riesgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatusp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cb_PuestoRiesgo = New System.Windows.Forms.CheckBox()
        Me.txt_PuestoDescripcion = New System.Windows.Forms.TextBox()
        Me.btn_SavePuesto = New System.Windows.Forms.PictureBox()
        Me.btn_CancelPuesto = New System.Windows.Forms.PictureBox()
        Me.txt_PuestoNombre = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tsb_super = New System.Windows.Forms.TabPage()
        Me.dgv_super = New System.Windows.Forms.DataGridView()
        Me.UPDATESU = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Super = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btn_savesuper = New System.Windows.Forms.PictureBox()
        Me.btn_cancelsuper = New System.Windows.Forms.PictureBox()
        Me.TXT_EMP_SUPERname = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.BUSCAR_EMP_SUPER = New System.Windows.Forms.PictureBox()
        Me.TXT_EMP_SUPER = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.tab_tipo = New System.Windows.Forms.TabPage()
        Me.dgv_te = New System.Windows.Forms.DataGridView()
        Me.UPDATETE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_TE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcionte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatuste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txt_DescTE = New System.Windows.Forms.TextBox()
        Me.pb_saveTE = New System.Windows.Forms.PictureBox()
        Me.pb_cancelTE = New System.Windows.Forms.PictureBox()
        Me.txt_codigoTE = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tab_admin.SuspendLayout()
        Me.tab_users.SuspendLayout()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_per.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        Me.tab_capacitaciones.SuspendLayout()
        CType(Me.DGV_CAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tab_depto.SuspendLayout()
        CType(Me.dgv_depto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.save_cod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancel_code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tab_Equipo.SuspendLayout()
        CType(Me.dgv_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.save_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancel_eq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.tab_evaluacion.SuspendLayout()
        CType(Me.dgv_eval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.SAVE_EVAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL_EVAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.tab_puesto.SuspendLayout()
        CType(Me.dgv_Puesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.btn_SavePuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_CancelPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.tsb_super.SuspendLayout()
        CType(Me.dgv_super, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        CType(Me.btn_savesuper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancelsuper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSCAR_EMP_SUPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.tab_tipo.SuspendLayout()
        CType(Me.dgv_te, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.pb_saveTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_cancelTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_admin
        '
        Me.tab_admin.Controls.Add(Me.tab_users)
        Me.tab_admin.Controls.Add(Me.tab_capacitaciones)
        Me.tab_admin.Controls.Add(Me.tab_depto)
        Me.tab_admin.Controls.Add(Me.tab_Equipo)
        Me.tab_admin.Controls.Add(Me.tab_evaluacion)
        Me.tab_admin.Controls.Add(Me.tab_puesto)
        Me.tab_admin.Controls.Add(Me.tsb_super)
        Me.tab_admin.Controls.Add(Me.tab_tipo)
        Me.tab_admin.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.tab_admin.Location = New System.Drawing.Point(15, 24)
        Me.tab_admin.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_admin.Name = "tab_admin"
        Me.tab_admin.SelectedIndex = 0
        Me.tab_admin.Size = New System.Drawing.Size(1282, 791)
        Me.tab_admin.TabIndex = 0
        '
        'tab_users
        '
        Me.tab_users.Controls.Add(Me.dgv_equipo_emp)
        Me.tab_users.Controls.Add(Me.pnl_per)
        Me.tab_users.Location = New System.Drawing.Point(4, 30)
        Me.tab_users.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_users.Name = "tab_users"
        Me.tab_users.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_users.Size = New System.Drawing.Size(1274, 757)
        Me.tab_users.TabIndex = 0
        Me.tab_users.Text = "Usuarios"
        Me.tab_users.UseVisualStyleBackColor = True
        '
        'dgv_equipo_emp
        '
        Me.dgv_equipo_emp.AllowUserToAddRows = False
        Me.dgv_equipo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATE, Me.ID_User, Me.UserName, Me.Activo, Me.ID_Emp_US})
        Me.dgv_equipo_emp.Location = New System.Drawing.Point(-4, 258)
        Me.dgv_equipo_emp.Name = "dgv_equipo_emp"
        Me.dgv_equipo_emp.RowHeadersVisible = False
        Me.dgv_equipo_emp.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_equipo_emp.TabIndex = 72
        '
        'UPDATE
        '
        Me.UPDATE.HeaderText = "Baja"
        Me.UPDATE.Name = "UPDATE"
        '
        'ID_User
        '
        Me.ID_User.DataPropertyName = "ID_User"
        Me.ID_User.HeaderText = "ID"
        Me.ID_User.Name = "ID_User"
        Me.ID_User.Width = 200
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "USUARIO"
        Me.UserName.Name = "UserName"
        Me.UserName.Width = 500
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        Me.Activo.HeaderText = "ESTATUS"
        Me.Activo.Name = "Activo"
        Me.Activo.Width = 200
        '
        'ID_Emp_US
        '
        Me.ID_Emp_US.DataPropertyName = "ID_Emp"
        Me.ID_Emp_US.HeaderText = "NO EMPLEADO"
        Me.ID_Emp_US.Name = "ID_Emp_US"
        Me.ID_Emp_US.Width = 300
        '
        'pnl_per
        '
        Me.pnl_per.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_per.Controls.Add(Me.SAVE)
        Me.pnl_per.Controls.Add(Me.CANCEL)
        Me.pnl_per.Controls.Add(Me.txt_pass2)
        Me.pnl_per.Controls.Add(Me.Label10)
        Me.pnl_per.Controls.Add(Me.txt_pass)
        Me.pnl_per.Controls.Add(Me.txt_user)
        Me.pnl_per.Controls.Add(Me.Label9)
        Me.pnl_per.Controls.Add(Me.Label8)
        Me.pnl_per.Controls.Add(Me.lbl_emp)
        Me.pnl_per.Controls.Add(Me.Empleado)
        Me.pnl_per.Controls.Add(Me.buscar_EN)
        Me.pnl_per.Controls.Add(Me.txt_numero)
        Me.pnl_per.Controls.Add(Me.lbl_num)
        Me.pnl_per.Controls.Add(Me.panel7)
        Me.pnl_per.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_per.Location = New System.Drawing.Point(15, 24)
        Me.pnl_per.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_per.Name = "pnl_per"
        Me.pnl_per.Size = New System.Drawing.Size(1241, 217)
        Me.pnl_per.TabIndex = 32
        '
        'SAVE
        '
        Me.SAVE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(1138, 38)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(45, 40)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 92
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1189, 38)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(45, 40)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 93
        Me.CANCEL.TabStop = False
        '
        'txt_pass2
        '
        Me.txt_pass2.Location = New System.Drawing.Point(168, 162)
        Me.txt_pass2.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pass2.Name = "txt_pass2"
        Me.txt_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2.Size = New System.Drawing.Size(252, 28)
        Me.txt_pass2.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 21)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Repita Contrasena:"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(168, 124)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(252, 28)
        Me.txt_pass.TabIndex = 2
        '
        'txt_user
        '
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Location = New System.Drawing.Point(168, 88)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(252, 28)
        Me.txt_user.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 21)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Contrasena:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Usuario:"
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(539, 53)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 86
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(432, 53)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(101, 22)
        Me.Empleado.TabIndex = 85
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = CType(resources.GetObject("buscar_EN.Image"), System.Drawing.Image)
        Me.buscar_EN.Location = New System.Drawing.Point(390, 48)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 84
        Me.buscar_EN.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(168, 48)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(216, 28)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(90, 54)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 83
        Me.lbl_num.Text = "Numero:"
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel7.Controls.Add(Me.label12)
        Me.panel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel7.Location = New System.Drawing.Point(-2, -2)
        Me.panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1241, 35)
        Me.panel7.TabIndex = 0
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(13, 6)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(54, 21)
        Me.label12.TabIndex = 0
        Me.label12.Text = "Datos"
        '
        'tab_capacitaciones
        '
        Me.tab_capacitaciones.Controls.Add(Me.DGV_CAT)
        Me.tab_capacitaciones.Controls.Add(Me.Panel1)
        Me.tab_capacitaciones.Location = New System.Drawing.Point(4, 30)
        Me.tab_capacitaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_capacitaciones.Name = "tab_capacitaciones"
        Me.tab_capacitaciones.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_capacitaciones.Size = New System.Drawing.Size(1274, 757)
        Me.tab_capacitaciones.TabIndex = 1
        Me.tab_capacitaciones.Text = "Capacitaciones"
        Me.tab_capacitaciones.UseVisualStyleBackColor = True
        '
        'DGV_CAT
        '
        Me.DGV_CAT.AllowUserToAddRows = False
        Me.DGV_CAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CAT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATEC, Me.ID_Cap, Me.CA_Codigo, Me.CA_Desc, Me.CA_Status})
        Me.DGV_CAT.Location = New System.Drawing.Point(14, 258)
        Me.DGV_CAT.Name = "DGV_CAT"
        Me.DGV_CAT.RowHeadersVisible = False
        Me.DGV_CAT.Size = New System.Drawing.Size(1240, 401)
        Me.DGV_CAT.TabIndex = 74
        '
        'UPDATEC
        '
        Me.UPDATEC.HeaderText = "Baja"
        Me.UPDATEC.Name = "UPDATEC"
        '
        'ID_Cap
        '
        Me.ID_Cap.DataPropertyName = "ID_Cap"
        Me.ID_Cap.HeaderText = "ID"
        Me.ID_Cap.Name = "ID_Cap"
        '
        'CA_Codigo
        '
        Me.CA_Codigo.DataPropertyName = "CA_Codigo"
        Me.CA_Codigo.HeaderText = "CODIGO"
        Me.CA_Codigo.Name = "CA_Codigo"
        Me.CA_Codigo.Width = 200
        '
        'CA_Desc
        '
        Me.CA_Desc.DataPropertyName = "CA_Desc"
        Me.CA_Desc.HeaderText = "DESCRIPCION"
        Me.CA_Desc.Name = "CA_Desc"
        Me.CA_Desc.Width = 700
        '
        'CA_Status
        '
        Me.CA_Status.DataPropertyName = "CA_Status"
        Me.CA_Status.HeaderText = "ESTATUS"
        Me.CA_Status.Name = "CA_Status"
        Me.CA_Status.Width = 700
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TXT_CAP_DESC)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.TXT_CAPCODIGO)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(15, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 217)
        Me.Panel1.TabIndex = 73
        '
        'TXT_CAP_DESC
        '
        Me.TXT_CAP_DESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CAP_DESC.Location = New System.Drawing.Point(588, 102)
        Me.TXT_CAP_DESC.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_CAP_DESC.Name = "TXT_CAP_DESC"
        Me.TXT_CAP_DESC.Size = New System.Drawing.Size(252, 28)
        Me.TXT_CAP_DESC.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.PictureBox1.Location = New System.Drawing.Point(1138, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.PictureBox2.Location = New System.Drawing.Point(1189, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 93
        Me.PictureBox2.TabStop = False
        '
        'TXT_CAPCODIGO
        '
        Me.TXT_CAPCODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CAPCODIGO.Location = New System.Drawing.Point(147, 102)
        Me.TXT_CAPCODIGO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_CAPCODIGO.Name = "TXT_CAPCODIGO"
        Me.TXT_CAPCODIGO.Size = New System.Drawing.Size(252, 28)
        Me.TXT_CAPCODIGO.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(471, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 21)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Descripcion:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(59, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 21)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Codigo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1241, 35)
        Me.Panel2.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(13, 6)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Datos"
        '
        'tab_depto
        '
        Me.tab_depto.Controls.Add(Me.dgv_depto)
        Me.tab_depto.Controls.Add(Me.Panel3)
        Me.tab_depto.Location = New System.Drawing.Point(4, 30)
        Me.tab_depto.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_depto.Name = "tab_depto"
        Me.tab_depto.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_depto.Size = New System.Drawing.Size(1274, 757)
        Me.tab_depto.TabIndex = 2
        Me.tab_depto.Text = "Departamentos"
        Me.tab_depto.UseVisualStyleBackColor = True
        '
        'dgv_depto
        '
        Me.dgv_depto.AllowUserToAddRows = False
        Me.dgv_depto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_depto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATED, Me.ID_Depto, Me.Codigo, Me.Descripcion, Me.Estatus})
        Me.dgv_depto.Location = New System.Drawing.Point(14, 258)
        Me.dgv_depto.Name = "dgv_depto"
        Me.dgv_depto.RowHeadersVisible = False
        Me.dgv_depto.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_depto.TabIndex = 76
        '
        'UPDATED
        '
        Me.UPDATED.HeaderText = "Baja"
        Me.UPDATED.Name = "UPDATED"
        '
        'ID_Depto
        '
        Me.ID_Depto.DataPropertyName = "ID_Depto"
        Me.ID_Depto.HeaderText = "ID"
        Me.ID_Depto.Name = "ID_Depto"
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "CODIGO"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 700
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "ESTATUS"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.Width = 700
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txt_coddes)
        Me.Panel3.Controls.Add(Me.save_cod)
        Me.Panel3.Controls.Add(Me.cancel_code)
        Me.Panel3.Controls.Add(Me.txt_depcod)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(15, 24)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1241, 217)
        Me.Panel3.TabIndex = 75
        '
        'txt_coddes
        '
        Me.txt_coddes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_coddes.Location = New System.Drawing.Point(588, 102)
        Me.txt_coddes.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_coddes.Name = "txt_coddes"
        Me.txt_coddes.Size = New System.Drawing.Size(252, 28)
        Me.txt_coddes.TabIndex = 1
        '
        'save_cod
        '
        Me.save_cod.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.save_cod.Location = New System.Drawing.Point(1138, 38)
        Me.save_cod.Name = "save_cod"
        Me.save_cod.Size = New System.Drawing.Size(45, 40)
        Me.save_cod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.save_cod.TabIndex = 92
        Me.save_cod.TabStop = False
        '
        'cancel_code
        '
        Me.cancel_code.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.cancel_code.Location = New System.Drawing.Point(1189, 38)
        Me.cancel_code.Name = "cancel_code"
        Me.cancel_code.Size = New System.Drawing.Size(45, 40)
        Me.cancel_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancel_code.TabIndex = 93
        Me.cancel_code.TabStop = False
        '
        'txt_depcod
        '
        Me.txt_depcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_depcod.Location = New System.Drawing.Point(147, 102)
        Me.txt_depcod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_depcod.Name = "txt_depcod"
        Me.txt_depcod.Size = New System.Drawing.Size(252, 28)
        Me.txt_depcod.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(471, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 21)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Descripcion:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(59, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 21)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Codigo:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(-2, -2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1241, 35)
        Me.Panel4.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(13, 6)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 21)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Datos"
        '
        'tab_Equipo
        '
        Me.tab_Equipo.Controls.Add(Me.dgv_eq)
        Me.tab_Equipo.Controls.Add(Me.Panel5)
        Me.tab_Equipo.Location = New System.Drawing.Point(4, 30)
        Me.tab_Equipo.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_Equipo.Name = "tab_Equipo"
        Me.tab_Equipo.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_Equipo.Size = New System.Drawing.Size(1274, 757)
        Me.tab_Equipo.TabIndex = 3
        Me.tab_Equipo.Text = "Equipo"
        Me.tab_Equipo.UseVisualStyleBackColor = True
        '
        'dgv_eq
        '
        Me.dgv_eq.AllowUserToAddRows = False
        Me.dgv_eq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_eq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATEEQ, Me.ID_Equipo, Me.Nombre, Me.Descripcione, Me.Costo, Me.Estatuse})
        Me.dgv_eq.Location = New System.Drawing.Point(14, 258)
        Me.dgv_eq.Name = "dgv_eq"
        Me.dgv_eq.RowHeadersVisible = False
        Me.dgv_eq.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_eq.TabIndex = 77
        '
        'UPDATEEQ
        '
        Me.UPDATEEQ.HeaderText = "Baja"
        Me.UPDATEEQ.Name = "UPDATEEQ"
        '
        'ID_Equipo
        '
        Me.ID_Equipo.DataPropertyName = "ID_Equipo"
        Me.ID_Equipo.HeaderText = "ID"
        Me.ID_Equipo.Name = "ID_Equipo"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "CODIGO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Descripcione
        '
        Me.Descripcione.DataPropertyName = "Descripcion"
        Me.Descripcione.HeaderText = "DESCRIPCION"
        Me.Descripcione.Name = "Descripcione"
        Me.Descripcione.Width = 500
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.HeaderText = "COSTO"
        Me.Costo.Name = "Costo"
        Me.Costo.Width = 200
        '
        'Estatuse
        '
        Me.Estatuse.DataPropertyName = "Estatus"
        Me.Estatuse.HeaderText = "ESTATUS"
        Me.Estatuse.Name = "Estatuse"
        Me.Estatuse.Width = 200
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.txt_eqcost)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.txt_eqdesc)
        Me.Panel5.Controls.Add(Me.save_eq)
        Me.Panel5.Controls.Add(Me.cancel_eq)
        Me.Panel5.Controls.Add(Me.txt_eqcod)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(15, 24)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1241, 217)
        Me.Panel5.TabIndex = 75
        '
        'txt_eqcost
        '
        Me.txt_eqcost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eqcost.Location = New System.Drawing.Point(146, 147)
        Me.txt_eqcost.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_eqcost.Name = "txt_eqcost"
        Me.txt_eqcost.Size = New System.Drawing.Size(252, 28)
        Me.txt_eqcost.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(69, 150)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 21)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "Costo:"
        '
        'txt_eqdesc
        '
        Me.txt_eqdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eqdesc.Location = New System.Drawing.Point(146, 105)
        Me.txt_eqdesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_eqdesc.Name = "txt_eqdesc"
        Me.txt_eqdesc.Size = New System.Drawing.Size(252, 28)
        Me.txt_eqdesc.TabIndex = 1
        '
        'save_eq
        '
        Me.save_eq.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.save_eq.Location = New System.Drawing.Point(1138, 38)
        Me.save_eq.Name = "save_eq"
        Me.save_eq.Size = New System.Drawing.Size(45, 40)
        Me.save_eq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.save_eq.TabIndex = 92
        Me.save_eq.TabStop = False
        '
        'cancel_eq
        '
        Me.cancel_eq.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.cancel_eq.Location = New System.Drawing.Point(1189, 38)
        Me.cancel_eq.Name = "cancel_eq"
        Me.cancel_eq.Size = New System.Drawing.Size(45, 40)
        Me.cancel_eq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancel_eq.TabIndex = 93
        Me.cancel_eq.TabStop = False
        '
        'txt_eqcod
        '
        Me.txt_eqcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eqcod.Location = New System.Drawing.Point(146, 61)
        Me.txt_eqcod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_eqcod.Name = "txt_eqcod"
        Me.txt_eqcod.Size = New System.Drawing.Size(252, 28)
        Me.txt_eqcod.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 21)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Codigo:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(-2, -2)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1241, 35)
        Me.Panel6.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Datos"
        '
        'tab_evaluacion
        '
        Me.tab_evaluacion.Controls.Add(Me.dgv_eval)
        Me.tab_evaluacion.Controls.Add(Me.Panel8)
        Me.tab_evaluacion.Location = New System.Drawing.Point(4, 30)
        Me.tab_evaluacion.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_evaluacion.Name = "tab_evaluacion"
        Me.tab_evaluacion.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_evaluacion.Size = New System.Drawing.Size(1274, 757)
        Me.tab_evaluacion.TabIndex = 4
        Me.tab_evaluacion.Text = "Evaluaciones"
        Me.tab_evaluacion.UseVisualStyleBackColor = True
        '
        'dgv_eval
        '
        Me.dgv_eval.AllowUserToAddRows = False
        Me.dgv_eval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_eval.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATEE, Me.ID_Evalua, Me.EV_Codigo, Me.EV_Descipcion, Me.EV_Estatus})
        Me.dgv_eval.Location = New System.Drawing.Point(14, 258)
        Me.dgv_eval.Name = "dgv_eval"
        Me.dgv_eval.RowHeadersVisible = False
        Me.dgv_eval.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_eval.TabIndex = 76
        '
        'UPDATEE
        '
        Me.UPDATEE.HeaderText = "Baja"
        Me.UPDATEE.Name = "UPDATEE"
        '
        'ID_Evalua
        '
        Me.ID_Evalua.DataPropertyName = "ID_Evalua"
        Me.ID_Evalua.HeaderText = "ID"
        Me.ID_Evalua.Name = "ID_Evalua"
        '
        'EV_Codigo
        '
        Me.EV_Codigo.DataPropertyName = "EV_Codigo"
        Me.EV_Codigo.HeaderText = "CODIGO"
        Me.EV_Codigo.Name = "EV_Codigo"
        Me.EV_Codigo.Width = 200
        '
        'EV_Descipcion
        '
        Me.EV_Descipcion.DataPropertyName = "EV_Descipcion"
        Me.EV_Descipcion.HeaderText = "DESCRIPCION"
        Me.EV_Descipcion.Name = "EV_Descipcion"
        Me.EV_Descipcion.Width = 700
        '
        'EV_Estatus
        '
        Me.EV_Estatus.DataPropertyName = "EV_Estatus"
        Me.EV_Estatus.HeaderText = "ESTATUS"
        Me.EV_Estatus.Name = "EV_Estatus"
        Me.EV_Estatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EV_Estatus.Width = 200
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.txt_eval_des)
        Me.Panel8.Controls.Add(Me.SAVE_EVAL)
        Me.Panel8.Controls.Add(Me.CANCEL_EVAL)
        Me.Panel8.Controls.Add(Me.txt_evalcod)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Controls.Add(Me.Label25)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(15, 24)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1241, 217)
        Me.Panel8.TabIndex = 75
        '
        'txt_eval_des
        '
        Me.txt_eval_des.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eval_des.Location = New System.Drawing.Point(588, 102)
        Me.txt_eval_des.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_eval_des.Name = "txt_eval_des"
        Me.txt_eval_des.Size = New System.Drawing.Size(252, 28)
        Me.txt_eval_des.TabIndex = 1
        '
        'SAVE_EVAL
        '
        Me.SAVE_EVAL.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE_EVAL.Location = New System.Drawing.Point(1138, 38)
        Me.SAVE_EVAL.Name = "SAVE_EVAL"
        Me.SAVE_EVAL.Size = New System.Drawing.Size(45, 40)
        Me.SAVE_EVAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE_EVAL.TabIndex = 92
        Me.SAVE_EVAL.TabStop = False
        '
        'CANCEL_EVAL
        '
        Me.CANCEL_EVAL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL_EVAL.Location = New System.Drawing.Point(1189, 38)
        Me.CANCEL_EVAL.Name = "CANCEL_EVAL"
        Me.CANCEL_EVAL.Size = New System.Drawing.Size(45, 40)
        Me.CANCEL_EVAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL_EVAL.TabIndex = 93
        Me.CANCEL_EVAL.TabStop = False
        '
        'txt_evalcod
        '
        Me.txt_evalcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_evalcod.Location = New System.Drawing.Point(147, 102)
        Me.txt_evalcod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_evalcod.Name = "txt_evalcod"
        Me.txt_evalcod.Size = New System.Drawing.Size(252, 28)
        Me.txt_evalcod.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(471, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 21)
        Me.Label24.TabIndex = 88
        Me.Label24.Text = "Descripcion:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(59, 109)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 21)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Codigo:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label26)
        Me.Panel9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(-2, -2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1241, 35)
        Me.Panel9.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(13, 6)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 21)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Datos"
        '
        'tab_puesto
        '
        Me.tab_puesto.Controls.Add(Me.dgv_Puesto)
        Me.tab_puesto.Controls.Add(Me.Panel10)
        Me.tab_puesto.Location = New System.Drawing.Point(4, 30)
        Me.tab_puesto.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_puesto.Name = "tab_puesto"
        Me.tab_puesto.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_puesto.Size = New System.Drawing.Size(1274, 757)
        Me.tab_puesto.TabIndex = 5
        Me.tab_puesto.Text = "Puesto"
        Me.tab_puesto.UseVisualStyleBackColor = True
        '
        'dgv_Puesto
        '
        Me.dgv_Puesto.AllowUserToAddRows = False
        Me.dgv_Puesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Puesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATEPU, Me.ID_Puesto, Me.Nombrep, Me.Descripcionp, Me.Riesgo, Me.Estatusp})
        Me.dgv_Puesto.Location = New System.Drawing.Point(14, 258)
        Me.dgv_Puesto.Name = "dgv_Puesto"
        Me.dgv_Puesto.RowHeadersVisible = False
        Me.dgv_Puesto.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_Puesto.TabIndex = 78
        '
        'UPDATEPU
        '
        Me.UPDATEPU.HeaderText = "Baja"
        Me.UPDATEPU.Name = "UPDATEPU"
        '
        'ID_Puesto
        '
        Me.ID_Puesto.DataPropertyName = "ID_Puesto"
        Me.ID_Puesto.HeaderText = "ID"
        Me.ID_Puesto.Name = "ID_Puesto"
        '
        'Nombrep
        '
        Me.Nombrep.DataPropertyName = "Nombre"
        Me.Nombrep.HeaderText = "CODIGO"
        Me.Nombrep.Name = "Nombrep"
        Me.Nombrep.Width = 200
        '
        'Descripcionp
        '
        Me.Descripcionp.DataPropertyName = "Descripcion"
        Me.Descripcionp.HeaderText = "DESCRIPCION"
        Me.Descripcionp.Name = "Descripcionp"
        Me.Descripcionp.Width = 500
        '
        'Riesgo
        '
        Me.Riesgo.DataPropertyName = "Riesgo"
        Me.Riesgo.HeaderText = "RIESGO"
        Me.Riesgo.Name = "Riesgo"
        Me.Riesgo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Riesgo.Width = 200
        '
        'Estatusp
        '
        Me.Estatusp.DataPropertyName = "Estatus"
        Me.Estatusp.HeaderText = "ESTATUS"
        Me.Estatusp.Name = "Estatusp"
        Me.Estatusp.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estatusp.Width = 200
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.cb_PuestoRiesgo)
        Me.Panel10.Controls.Add(Me.txt_PuestoDescripcion)
        Me.Panel10.Controls.Add(Me.btn_SavePuesto)
        Me.Panel10.Controls.Add(Me.btn_CancelPuesto)
        Me.Panel10.Controls.Add(Me.txt_PuestoNombre)
        Me.Panel10.Controls.Add(Me.Label29)
        Me.Panel10.Controls.Add(Me.Label30)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(15, 24)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1241, 217)
        Me.Panel10.TabIndex = 77
        '
        'cb_PuestoRiesgo
        '
        Me.cb_PuestoRiesgo.AutoSize = True
        Me.cb_PuestoRiesgo.Location = New System.Drawing.Point(147, 147)
        Me.cb_PuestoRiesgo.Name = "cb_PuestoRiesgo"
        Me.cb_PuestoRiesgo.Size = New System.Drawing.Size(125, 25)
        Me.cb_PuestoRiesgo.TabIndex = 96
        Me.cb_PuestoRiesgo.Text = "Es Riesgoso?"
        Me.cb_PuestoRiesgo.UseVisualStyleBackColor = True
        '
        'txt_PuestoDescripcion
        '
        Me.txt_PuestoDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PuestoDescripcion.Location = New System.Drawing.Point(588, 102)
        Me.txt_PuestoDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_PuestoDescripcion.Name = "txt_PuestoDescripcion"
        Me.txt_PuestoDescripcion.Size = New System.Drawing.Size(252, 28)
        Me.txt_PuestoDescripcion.TabIndex = 1
        '
        'btn_SavePuesto
        '
        Me.btn_SavePuesto.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.btn_SavePuesto.Location = New System.Drawing.Point(1138, 38)
        Me.btn_SavePuesto.Name = "btn_SavePuesto"
        Me.btn_SavePuesto.Size = New System.Drawing.Size(45, 40)
        Me.btn_SavePuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SavePuesto.TabIndex = 92
        Me.btn_SavePuesto.TabStop = False
        '
        'btn_CancelPuesto
        '
        Me.btn_CancelPuesto.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_CancelPuesto.Location = New System.Drawing.Point(1189, 38)
        Me.btn_CancelPuesto.Name = "btn_CancelPuesto"
        Me.btn_CancelPuesto.Size = New System.Drawing.Size(45, 40)
        Me.btn_CancelPuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_CancelPuesto.TabIndex = 93
        Me.btn_CancelPuesto.TabStop = False
        '
        'txt_PuestoNombre
        '
        Me.txt_PuestoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PuestoNombre.Location = New System.Drawing.Point(147, 102)
        Me.txt_PuestoNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_PuestoNombre.Name = "txt_PuestoNombre"
        Me.txt_PuestoNombre.Size = New System.Drawing.Size(252, 28)
        Me.txt_PuestoNombre.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(471, 109)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(102, 21)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "Descripcion:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(59, 109)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 21)
        Me.Label30.TabIndex = 87
        Me.Label30.Text = "Codigo:"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(-2, -2)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1241, 35)
        Me.Panel11.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(13, 6)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 21)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Datos"
        '
        'tsb_super
        '
        Me.tsb_super.Controls.Add(Me.dgv_super)
        Me.tsb_super.Controls.Add(Me.Panel12)
        Me.tsb_super.Location = New System.Drawing.Point(4, 30)
        Me.tsb_super.Margin = New System.Windows.Forms.Padding(2)
        Me.tsb_super.Name = "tsb_super"
        Me.tsb_super.Padding = New System.Windows.Forms.Padding(2)
        Me.tsb_super.Size = New System.Drawing.Size(1274, 757)
        Me.tsb_super.TabIndex = 6
        Me.tsb_super.Text = "Supervisor"
        Me.tsb_super.UseVisualStyleBackColor = True
        '
        'dgv_super
        '
        Me.dgv_super.AllowUserToAddRows = False
        Me.dgv_super.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_super.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATESU, Me.ID_Super, Me.ID_Emp, Me.Name, Me.ActivoS})
        Me.dgv_super.Location = New System.Drawing.Point(14, 258)
        Me.dgv_super.Name = "dgv_super"
        Me.dgv_super.RowHeadersVisible = False
        Me.dgv_super.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_super.TabIndex = 74
        '
        'UPDATESU
        '
        Me.UPDATESU.HeaderText = "Baja"
        Me.UPDATESU.Name = "UPDATESU"
        '
        'ID_Super
        '
        Me.ID_Super.DataPropertyName = "ID_Super"
        Me.ID_Super.HeaderText = "ID"
        Me.ID_Super.Name = "ID_Super"
        Me.ID_Super.Width = 200
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "NO.EMPLEADO"
        Me.ID_Emp.Name = "ID_Emp"
        Me.ID_Emp.Width = 200
        '
        'Name
        '
        Me.Name.DataPropertyName = "Name"
        Me.Name.HeaderText = "NOMBRE"
        Me.Name.Name = "Name"
        Me.Name.Width = 600
        '
        'ActivoS
        '
        Me.ActivoS.DataPropertyName = "Activo"
        Me.ActivoS.HeaderText = "ESTATUS"
        Me.ActivoS.Name = "ActivoS"
        Me.ActivoS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivoS.Width = 200
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.btn_savesuper)
        Me.Panel12.Controls.Add(Me.btn_cancelsuper)
        Me.Panel12.Controls.Add(Me.TXT_EMP_SUPERname)
        Me.Panel12.Controls.Add(Me.Label38)
        Me.Panel12.Controls.Add(Me.BUSCAR_EMP_SUPER)
        Me.Panel12.Controls.Add(Me.TXT_EMP_SUPER)
        Me.Panel12.Controls.Add(Me.Label39)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(15, 24)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1241, 217)
        Me.Panel12.TabIndex = 73
        '
        'btn_savesuper
        '
        Me.btn_savesuper.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_savesuper.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.btn_savesuper.Location = New System.Drawing.Point(1138, 38)
        Me.btn_savesuper.Name = "btn_savesuper"
        Me.btn_savesuper.Size = New System.Drawing.Size(45, 40)
        Me.btn_savesuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_savesuper.TabIndex = 92
        Me.btn_savesuper.TabStop = False
        '
        'btn_cancelsuper
        '
        Me.btn_cancelsuper.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_cancelsuper.Location = New System.Drawing.Point(1189, 38)
        Me.btn_cancelsuper.Name = "btn_cancelsuper"
        Me.btn_cancelsuper.Size = New System.Drawing.Size(45, 40)
        Me.btn_cancelsuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cancelsuper.TabIndex = 93
        Me.btn_cancelsuper.TabStop = False
        '
        'TXT_EMP_SUPERname
        '
        Me.TXT_EMP_SUPERname.AutoSize = True
        Me.TXT_EMP_SUPERname.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EMP_SUPERname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TXT_EMP_SUPERname.Location = New System.Drawing.Point(539, 53)
        Me.TXT_EMP_SUPERname.Name = "TXT_EMP_SUPERname"
        Me.TXT_EMP_SUPERname.Size = New System.Drawing.Size(0, 22)
        Me.TXT_EMP_SUPERname.TabIndex = 86
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label38.Location = New System.Drawing.Point(432, 53)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(101, 22)
        Me.Label38.TabIndex = 85
        Me.Label38.Text = "Empleado: "
        '
        'BUSCAR_EMP_SUPER
        '
        Me.BUSCAR_EMP_SUPER.BackgroundImage = CType(resources.GetObject("BUSCAR_EMP_SUPER.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR_EMP_SUPER.Image = CType(resources.GetObject("BUSCAR_EMP_SUPER.Image"), System.Drawing.Image)
        Me.BUSCAR_EMP_SUPER.Location = New System.Drawing.Point(383, 48)
        Me.BUSCAR_EMP_SUPER.Name = "BUSCAR_EMP_SUPER"
        Me.BUSCAR_EMP_SUPER.Size = New System.Drawing.Size(30, 28)
        Me.BUSCAR_EMP_SUPER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BUSCAR_EMP_SUPER.TabIndex = 84
        Me.BUSCAR_EMP_SUPER.TabStop = False
        '
        'TXT_EMP_SUPER
        '
        Me.TXT_EMP_SUPER.Location = New System.Drawing.Point(168, 48)
        Me.TXT_EMP_SUPER.Name = "TXT_EMP_SUPER"
        Me.TXT_EMP_SUPER.Size = New System.Drawing.Size(209, 28)
        Me.TXT_EMP_SUPER.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(90, 54)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(77, 21)
        Me.Label39.TabIndex = 83
        Me.Label39.Text = "Numero:"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label40)
        Me.Panel13.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(-2, -2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1241, 35)
        Me.Panel13.TabIndex = 0
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(13, 6)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(54, 21)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Datos"
        '
        'tab_tipo
        '
        Me.tab_tipo.Controls.Add(Me.dgv_te)
        Me.tab_tipo.Controls.Add(Me.Panel14)
        Me.tab_tipo.Location = New System.Drawing.Point(4, 30)
        Me.tab_tipo.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_tipo.Name = "tab_tipo"
        Me.tab_tipo.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_tipo.Size = New System.Drawing.Size(1274, 757)
        Me.tab_tipo.TabIndex = 7
        Me.tab_tipo.Text = "Tipo de Empleados"
        Me.tab_tipo.UseVisualStyleBackColor = True
        '
        'dgv_te
        '
        Me.dgv_te.AllowUserToAddRows = False
        Me.dgv_te.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_te.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATETE, Me.ID_TE, Me.Codigote, Me.Descripcionte, Me.Estatuste})
        Me.dgv_te.Location = New System.Drawing.Point(14, 258)
        Me.dgv_te.Name = "dgv_te"
        Me.dgv_te.RowHeadersVisible = False
        Me.dgv_te.Size = New System.Drawing.Size(1240, 401)
        Me.dgv_te.TabIndex = 80
        '
        'UPDATETE
        '
        Me.UPDATETE.HeaderText = "Baja"
        Me.UPDATETE.Name = "UPDATETE"
        '
        'ID_TE
        '
        Me.ID_TE.DataPropertyName = "ID_TE"
        Me.ID_TE.HeaderText = "ID"
        Me.ID_TE.Name = "ID_TE"
        '
        'Codigote
        '
        Me.Codigote.DataPropertyName = "Codigo"
        Me.Codigote.HeaderText = "CODIGO"
        Me.Codigote.Name = "Codigote"
        Me.Codigote.Width = 200
        '
        'Descripcionte
        '
        Me.Descripcionte.DataPropertyName = "Descripcion"
        Me.Descripcionte.HeaderText = "DESCRIPCION"
        Me.Descripcionte.Name = "Descripcionte"
        Me.Descripcionte.Width = 700
        '
        'Estatuste
        '
        Me.Estatuste.DataPropertyName = "Estatus"
        Me.Estatuste.HeaderText = "ESTATUS"
        Me.Estatuste.Name = "Estatuste"
        Me.Estatuste.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Estatuste.Width = 200
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.txt_DescTE)
        Me.Panel14.Controls.Add(Me.pb_saveTE)
        Me.Panel14.Controls.Add(Me.pb_cancelTE)
        Me.Panel14.Controls.Add(Me.txt_codigoTE)
        Me.Panel14.Controls.Add(Me.Label36)
        Me.Panel14.Controls.Add(Me.Label41)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(15, 24)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1241, 217)
        Me.Panel14.TabIndex = 79
        '
        'txt_DescTE
        '
        Me.txt_DescTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DescTE.Location = New System.Drawing.Point(588, 102)
        Me.txt_DescTE.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_DescTE.Name = "txt_DescTE"
        Me.txt_DescTE.Size = New System.Drawing.Size(252, 28)
        Me.txt_DescTE.TabIndex = 1
        '
        'pb_saveTE
        '
        Me.pb_saveTE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.pb_saveTE.Location = New System.Drawing.Point(1138, 38)
        Me.pb_saveTE.Name = "pb_saveTE"
        Me.pb_saveTE.Size = New System.Drawing.Size(45, 40)
        Me.pb_saveTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_saveTE.TabIndex = 92
        Me.pb_saveTE.TabStop = False
        '
        'pb_cancelTE
        '
        Me.pb_cancelTE.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.pb_cancelTE.Location = New System.Drawing.Point(1189, 38)
        Me.pb_cancelTE.Name = "pb_cancelTE"
        Me.pb_cancelTE.Size = New System.Drawing.Size(45, 40)
        Me.pb_cancelTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_cancelTE.TabIndex = 93
        Me.pb_cancelTE.TabStop = False
        '
        'txt_codigoTE
        '
        Me.txt_codigoTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigoTE.Location = New System.Drawing.Point(147, 102)
        Me.txt_codigoTE.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigoTE.Name = "txt_codigoTE"
        Me.txt_codigoTE.Size = New System.Drawing.Size(252, 28)
        Me.txt_codigoTE.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(471, 109)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 21)
        Me.Label36.TabIndex = 88
        Me.Label36.Text = "Descripcion:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(59, 109)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(69, 21)
        Me.Label41.TabIndex = 87
        Me.Label41.Text = "Codigo:"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label42)
        Me.Panel15.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel15.Location = New System.Drawing.Point(-2, -2)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1241, 35)
        Me.Panel15.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(13, 6)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(54, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Datos"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 864)
        Me.Controls.Add(Me.tab_admin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.tab_admin.ResumeLayout(False)
        Me.tab_users.ResumeLayout(False)
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_per.ResumeLayout(False)
        Me.pnl_per.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.tab_capacitaciones.ResumeLayout(False)
        CType(Me.DGV_CAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tab_depto.ResumeLayout(False)
        CType(Me.dgv_depto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.save_cod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancel_code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tab_Equipo.ResumeLayout(False)
        CType(Me.dgv_eq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.save_eq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancel_eq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.tab_evaluacion.ResumeLayout(False)
        CType(Me.dgv_eval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.SAVE_EVAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL_EVAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.tab_puesto.ResumeLayout(False)
        CType(Me.dgv_Puesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.btn_SavePuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_CancelPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.tsb_super.ResumeLayout(False)
        CType(Me.dgv_super, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.btn_savesuper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancelsuper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSCAR_EMP_SUPER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.tab_tipo.ResumeLayout(False)
        CType(Me.dgv_te, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.pb_saveTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_cancelTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_admin As TabControl
    Friend WithEvents tab_users As TabPage
    Friend WithEvents tab_capacitaciones As TabPage
    Friend WithEvents tab_depto As TabPage
    Friend WithEvents tab_Equipo As TabPage
    Friend WithEvents tab_evaluacion As TabPage
    Friend WithEvents tab_puesto As TabPage
    Friend WithEvents tsb_super As TabPage
    Friend WithEvents tab_tipo As TabPage
    Private WithEvents pnl_per As Panel
    Private WithEvents panel7 As Panel
    Private WithEvents label12 As Label
    Friend WithEvents lbl_emp As Label
    Friend WithEvents Empleado As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents txt_pass2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents dgv_equipo_emp As DataGridView
    Friend WithEvents DGV_CAT As DataGridView
    Private WithEvents Panel1 As Panel
    Friend WithEvents TXT_CAP_DESC As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TXT_CAPCODIGO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents Panel2 As Panel
    Private WithEvents Label20 As Label
    Private WithEvents Panel3 As Panel
    Friend WithEvents txt_coddes As TextBox
    Friend WithEvents save_cod As PictureBox
    Friend WithEvents cancel_code As PictureBox
    Friend WithEvents txt_depcod As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents Label19 As Label
    Private WithEvents Panel5 As Panel
    Friend WithEvents txt_eqcost As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_eqdesc As TextBox
    Friend WithEvents save_eq As PictureBox
    Friend WithEvents cancel_eq As PictureBox
    Friend WithEvents txt_eqcod As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents Panel6 As Panel
    Private WithEvents Label7 As Label
    Friend WithEvents dgv_eval As DataGridView
    Private WithEvents Panel8 As Panel
    Friend WithEvents txt_eval_des As TextBox
    Friend WithEvents SAVE_EVAL As PictureBox
    Friend WithEvents CANCEL_EVAL As PictureBox
    Friend WithEvents txt_evalcod As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Private WithEvents Panel9 As Panel
    Private WithEvents Label26 As Label
    Friend WithEvents UPDATEC As DataGridViewImageColumn
    Friend WithEvents ID_Cap As DataGridViewTextBoxColumn
    Friend WithEvents CA_Codigo As DataGridViewTextBoxColumn
    Friend WithEvents CA_Desc As DataGridViewTextBoxColumn
    Friend WithEvents CA_Status As DataGridViewTextBoxColumn
    Friend WithEvents dgv_depto As DataGridView
    Friend WithEvents UPDATED As DataGridViewImageColumn
    Friend WithEvents ID_Depto As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents dgv_eq As DataGridView
    Friend WithEvents dgv_Puesto As DataGridView
    Private WithEvents Panel10 As Panel
    Friend WithEvents txt_PuestoDescripcion As TextBox
    Friend WithEvents btn_SavePuesto As PictureBox
    Friend WithEvents btn_CancelPuesto As PictureBox
    Friend WithEvents txt_PuestoNombre As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Private WithEvents Panel11 As Panel
    Private WithEvents Label31 As Label
    Friend WithEvents cb_PuestoRiesgo As CheckBox
    Friend WithEvents UPDATEEQ As DataGridViewImageColumn
    Friend WithEvents ID_Equipo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcione As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Estatuse As DataGridViewTextBoxColumn
    Friend WithEvents dgv_super As DataGridView
    Private WithEvents Panel12 As Panel
    Friend WithEvents btn_savesuper As PictureBox
    Friend WithEvents btn_cancelsuper As PictureBox
    Friend WithEvents TXT_EMP_SUPERname As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents BUSCAR_EMP_SUPER As PictureBox
    Friend WithEvents TXT_EMP_SUPER As TextBox
    Friend WithEvents Label39 As Label
    Private WithEvents Panel13 As Panel
    Private WithEvents Label40 As Label
    Friend WithEvents dgv_te As DataGridView
    Private WithEvents Panel14 As Panel
    Friend WithEvents txt_DescTE As TextBox
    Friend WithEvents pb_saveTE As PictureBox
    Friend WithEvents pb_cancelTE As PictureBox
    Friend WithEvents txt_codigoTE As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label41 As Label
    Private WithEvents Panel15 As Panel
    Private WithEvents Label42 As Label
    Friend WithEvents UPDATE As DataGridViewImageColumn
    Friend WithEvents ID_User As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp_US As DataGridViewTextBoxColumn
    Friend WithEvents UPDATEE As DataGridViewImageColumn
    Friend WithEvents ID_Evalua As DataGridViewTextBoxColumn
    Friend WithEvents EV_Codigo As DataGridViewTextBoxColumn
    Friend WithEvents EV_Descipcion As DataGridViewTextBoxColumn
    Friend WithEvents EV_Estatus As DataGridViewTextBoxColumn
    Friend WithEvents UPDATEPU As DataGridViewImageColumn
    Friend WithEvents ID_Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Nombrep As DataGridViewTextBoxColumn
    Friend WithEvents Descripcionp As DataGridViewTextBoxColumn
    Friend WithEvents Riesgo As DataGridViewTextBoxColumn
    Friend WithEvents Estatusp As DataGridViewTextBoxColumn
    Friend WithEvents UPDATESU As DataGridViewImageColumn
    Friend WithEvents ID_Super As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents ActivoS As DataGridViewTextBoxColumn
    Friend WithEvents UPDATETE As DataGridViewImageColumn
    Friend WithEvents ID_TE As DataGridViewTextBoxColumn
    Friend WithEvents Codigote As DataGridViewTextBoxColumn
    Friend WithEvents Descripcionte As DataGridViewTextBoxColumn
    Friend WithEvents Estatuste As DataGridViewTextBoxColumn
End Class