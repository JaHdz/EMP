<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.tab_admin = New System.Windows.Forms.TabControl()
        Me.tab_capacitaciones = New System.Windows.Forms.TabPage()
        Me.tab_users = New System.Windows.Forms.TabPage()
        Me.tab_depto = New System.Windows.Forms.TabPage()
        Me.tab_Equipo = New System.Windows.Forms.TabPage()
        Me.tab_evaluacion = New System.Windows.Forms.TabPage()
        Me.tab_puesto = New System.Windows.Forms.TabPage()
        Me.tsb_super = New System.Windows.Forms.TabPage()
        Me.tab_tipo = New System.Windows.Forms.TabPage()
        Me.pnl_per = New System.Windows.Forms.Panel()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_pass2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBL_GUARDAR = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.dgv_equipo_emp = New System.Windows.Forms.DataGridView()
        Me.UPDATE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_admin.SuspendLayout()
        Me.tab_capacitaciones.SuspendLayout()
        Me.tab_users.SuspendLayout()
        Me.tab_depto.SuspendLayout()
        Me.tab_Equipo.SuspendLayout()
        Me.tab_evaluacion.SuspendLayout()
        Me.tab_puesto.SuspendLayout()
        Me.tsb_super.SuspendLayout()
        Me.tab_tipo.SuspendLayout()
        Me.pnl_per.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tab_admin.Location = New System.Drawing.Point(12, 53)
        Me.tab_admin.Name = "tab_admin"
        Me.tab_admin.SelectedIndex = 0
        Me.tab_admin.Size = New System.Drawing.Size(1709, 973)
        Me.tab_admin.TabIndex = 0
        '
        'tab_capacitaciones
        '
        Me.tab_capacitaciones.Controls.Add(Me.Panel1)
        Me.tab_capacitaciones.Location = New System.Drawing.Point(4, 36)
        Me.tab_capacitaciones.Name = "tab_capacitaciones"
        Me.tab_capacitaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_capacitaciones.Size = New System.Drawing.Size(1701, 933)
        Me.tab_capacitaciones.TabIndex = 1
        Me.tab_capacitaciones.Text = "Capacitaciones"
        Me.tab_capacitaciones.UseVisualStyleBackColor = True
        '
        'tab_users
        '
        Me.tab_users.Controls.Add(Me.dgv_equipo_emp)
        Me.tab_users.Controls.Add(Me.pnl_per)
        Me.tab_users.Location = New System.Drawing.Point(4, 36)
        Me.tab_users.Name = "tab_users"
        Me.tab_users.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_users.Size = New System.Drawing.Size(1701, 933)
        Me.tab_users.TabIndex = 0
        Me.tab_users.Text = "Usuarios"
        Me.tab_users.UseVisualStyleBackColor = True
        '
        'tab_depto
        '
        Me.tab_depto.Controls.Add(Me.Panel3)
        Me.tab_depto.Location = New System.Drawing.Point(4, 36)
        Me.tab_depto.Name = "tab_depto"
        Me.tab_depto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_depto.Size = New System.Drawing.Size(1701, 933)
        Me.tab_depto.TabIndex = 2
        Me.tab_depto.Text = "Departamentos"
        Me.tab_depto.UseVisualStyleBackColor = True
        '
        'tab_Equipo
        '
        Me.tab_Equipo.Controls.Add(Me.Panel5)
        Me.tab_Equipo.Location = New System.Drawing.Point(4, 36)
        Me.tab_Equipo.Name = "tab_Equipo"
        Me.tab_Equipo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Equipo.Size = New System.Drawing.Size(1701, 933)
        Me.tab_Equipo.TabIndex = 3
        Me.tab_Equipo.Text = "Equipo"
        Me.tab_Equipo.UseVisualStyleBackColor = True
        '
        'tab_evaluacion
        '
        Me.tab_evaluacion.Controls.Add(Me.Panel8)
        Me.tab_evaluacion.Location = New System.Drawing.Point(4, 36)
        Me.tab_evaluacion.Name = "tab_evaluacion"
        Me.tab_evaluacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_evaluacion.Size = New System.Drawing.Size(1701, 933)
        Me.tab_evaluacion.TabIndex = 4
        Me.tab_evaluacion.Text = "Evaluaciones"
        Me.tab_evaluacion.UseVisualStyleBackColor = True
        '
        'tab_puesto
        '
        Me.tab_puesto.Controls.Add(Me.Panel10)
        Me.tab_puesto.Location = New System.Drawing.Point(4, 36)
        Me.tab_puesto.Name = "tab_puesto"
        Me.tab_puesto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_puesto.Size = New System.Drawing.Size(1701, 933)
        Me.tab_puesto.TabIndex = 5
        Me.tab_puesto.Text = "Puesto"
        Me.tab_puesto.UseVisualStyleBackColor = True
        '
        'tsb_super
        '
        Me.tsb_super.Controls.Add(Me.Panel12)
        Me.tsb_super.Location = New System.Drawing.Point(4, 36)
        Me.tsb_super.Name = "tsb_super"
        Me.tsb_super.Padding = New System.Windows.Forms.Padding(3)
        Me.tsb_super.Size = New System.Drawing.Size(1701, 933)
        Me.tsb_super.TabIndex = 6
        Me.tsb_super.Text = "Supervisor"
        Me.tsb_super.UseVisualStyleBackColor = True
        '
        'tab_tipo
        '
        Me.tab_tipo.Controls.Add(Me.Panel14)
        Me.tab_tipo.Location = New System.Drawing.Point(4, 36)
        Me.tab_tipo.Name = "tab_tipo"
        Me.tab_tipo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_tipo.Size = New System.Drawing.Size(1701, 933)
        Me.tab_tipo.TabIndex = 7
        Me.tab_tipo.Text = "Tipo de Empleados"
        Me.tab_tipo.UseVisualStyleBackColor = True
        '
        'pnl_per
        '
        Me.pnl_per.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_per.Controls.Add(Me.LBL_GUARDAR)
        Me.pnl_per.Controls.Add(Me.Label11)
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
        Me.pnl_per.Location = New System.Drawing.Point(21, 39)
        Me.pnl_per.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_per.Name = "pnl_per"
        Me.pnl_per.Size = New System.Drawing.Size(1653, 241)
        Me.pnl_per.TabIndex = 32
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel7.Controls.Add(Me.label12)
        Me.panel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel7.Location = New System.Drawing.Point(-3, -2)
        Me.panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1655, 43)
        Me.panel7.TabIndex = 0
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(17, 7)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(67, 27)
        Me.label12.TabIndex = 0
        Me.label12.Text = "Datos"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(15, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1653, 366)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-3, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1655, 43)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(15, 39)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1653, 366)
        Me.Panel3.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(-3, -2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1655, 43)
        Me.Panel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(15, 39)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1653, 366)
        Me.Panel5.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(-3, -2)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1655, 43)
        Me.Panel6.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(15, 39)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1653, 366)
        Me.Panel8.TabIndex = 33
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(-3, -2)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1655, 43)
        Me.Panel9.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Datos"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(15, 39)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1653, 366)
        Me.Panel10.TabIndex = 33
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(-3, -2)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1655, 43)
        Me.Panel11.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Datos"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(15, 39)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1653, 366)
        Me.Panel12.TabIndex = 33
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label6)
        Me.Panel13.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(-3, -2)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1655, 43)
        Me.Panel13.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Datos"
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(15, 39)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1653, 366)
        Me.Panel14.TabIndex = 33
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label7)
        Me.Panel15.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel15.Location = New System.Drawing.Point(-3, -2)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1655, 43)
        Me.Panel15.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Datos"
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(719, 65)
        Me.lbl_emp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 27)
        Me.lbl_emp.TabIndex = 86
        '
        'Empleado
        '
        Me.Empleado.AutoSize = True
        Me.Empleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empleado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Empleado.Location = New System.Drawing.Point(576, 65)
        Me.Empleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(124, 27)
        Me.Empleado.TabIndex = 85
        Me.Empleado.Text = "Empleado: "
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = CType(resources.GetObject("buscar_EN.Image"), System.Drawing.Image)
        Me.buscar_EN.Location = New System.Drawing.Point(511, 59)
        Me.buscar_EN.Margin = New System.Windows.Forms.Padding(4)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(40, 34)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 84
        Me.buscar_EN.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(224, 59)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(277, 33)
        Me.txt_numero.TabIndex = 0
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(120, 66)
        Me.lbl_num.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(96, 27)
        Me.lbl_num.TabIndex = 83
        Me.lbl_num.Text = "Numero:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 114)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 27)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Usuario:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 27)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Contrasena:"
        '
        'txt_user
        '
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Location = New System.Drawing.Point(224, 108)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(334, 33)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(224, 153)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(334, 33)
        Me.txt_pass.TabIndex = 2
        '
        'txt_pass2
        '
        Me.txt_pass2.Location = New System.Drawing.Point(224, 199)
        Me.txt_pass2.Name = "txt_pass2"
        Me.txt_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2.Size = New System.Drawing.Size(334, 33)
        Me.txt_pass2.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 201)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 27)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Repita Contrasena:"
        '
        'LBL_GUARDAR
        '
        Me.LBL_GUARDAR.AutoSize = True
        Me.LBL_GUARDAR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.LBL_GUARDAR.Location = New System.Drawing.Point(1317, 181)
        Me.LBL_GUARDAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_GUARDAR.Name = "LBL_GUARDAR"
        Me.LBL_GUARDAR.Size = New System.Drawing.Size(117, 27)
        Me.LBL_GUARDAR.TabIndex = 95
        Me.LBL_GUARDAR.Text = "GUARDAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(1485, 181)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 27)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "CANCELAR"
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(1323, 75)
        Me.SAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(111, 102)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 92
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1491, 75)
        Me.CANCEL.Margin = New System.Windows.Forms.Padding(4)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(111, 102)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 93
        Me.CANCEL.TabStop = False
        '
        'dgv_equipo_emp
        '
        Me.dgv_equipo_emp.AllowUserToAddRows = False
        Me.dgv_equipo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_equipo_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPDATE, Me.ID_User, Me.UserName, Me.Activo})
        Me.dgv_equipo_emp.Location = New System.Drawing.Point(20, 327)
        Me.dgv_equipo_emp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_equipo_emp.Name = "dgv_equipo_emp"
        Me.dgv_equipo_emp.RowHeadersVisible = False
        Me.dgv_equipo_emp.Size = New System.Drawing.Size(1654, 493)
        Me.dgv_equipo_emp.TabIndex = 72
        '
        'UPDATE
        '
        Me.UPDATE.HeaderText = "Regresar"
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
        Me.UserName.Width = 700
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        Me.Activo.HeaderText = "ESTATUS"
        Me.Activo.Name = "Activo"
        Me.Activo.Width = 700
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1744, 1063)
        Me.Controls.Add(Me.tab_admin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.tab_admin.ResumeLayout(False)
        Me.tab_capacitaciones.ResumeLayout(False)
        Me.tab_users.ResumeLayout(False)
        Me.tab_depto.ResumeLayout(False)
        Me.tab_Equipo.ResumeLayout(False)
        Me.tab_evaluacion.ResumeLayout(False)
        Me.tab_puesto.ResumeLayout(False)
        Me.tsb_super.ResumeLayout(False)
        Me.tab_tipo.ResumeLayout(False)
        Me.pnl_per.ResumeLayout(False)
        Me.pnl_per.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_equipo_emp, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents Panel4 As Panel
    Private WithEvents Label2 As Label
    Private WithEvents Panel5 As Panel
    Private WithEvents Panel6 As Panel
    Private WithEvents Label3 As Label
    Private WithEvents Panel8 As Panel
    Private WithEvents Panel9 As Panel
    Private WithEvents Label4 As Label
    Private WithEvents Panel10 As Panel
    Private WithEvents Panel11 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents Panel12 As Panel
    Private WithEvents Panel13 As Panel
    Private WithEvents Label6 As Label
    Private WithEvents Panel14 As Panel
    Private WithEvents Panel15 As Panel
    Private WithEvents Label7 As Label
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
    Friend WithEvents LBL_GUARDAR As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents dgv_equipo_emp As DataGridView
    Friend WithEvents UPDATE As DataGridViewImageColumn
    Friend WithEvents ID_User As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
End Class
