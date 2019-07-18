<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BwEmpleados = New System.ComponentModel.BackgroundWorker()
        Me.datosFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEnELiminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID_Enf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tam_Es = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlRow8 = New System.Windows.Forms.Panel()
        Me.btn_SERPT = New System.Windows.Forms.PictureBox()
        Me.btn_SECancel = New System.Windows.Forms.PictureBox()
        Me.btn_SESave = New System.Windows.Forms.PictureBox()
        Me.pnlRow7 = New System.Windows.Forms.Panel()
        Me.PnlObservaciones = New System.Windows.Forms.Panel()
        Me.txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.pnlRow6 = New System.Windows.Forms.Panel()
        Me.PnlGastos = New System.Windows.Forms.Panel()
        Me.txt_GFRenta = New AdminEmpleados.NumericTextbox()
        Me.txt_GFCole = New AdminEmpleados.NumericTextbox()
        Me.Txt_GFDesp = New AdminEmpleados.NumericTextbox()
        Me.txt_GFServ = New AdminEmpleados.NumericTextbox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.pnlRow5 = New System.Windows.Forms.Panel()
        Me.PnlReferencias = New System.Windows.Forms.Panel()
        Me.dgv_Ref = New System.Windows.Forms.DataGridView()
        Me.btnEReferencia = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_TiempoDeConocerse = New System.Windows.Forms.TextBox()
        Me.txt_RefOcu = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Txt_TipoDeRelacion = New System.Windows.Forms.TextBox()
        Me.txt_RefNom = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Btn_AddRef = New System.Windows.Forms.PictureBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.pnlRow4 = New System.Windows.Forms.Panel()
        Me.PnlIngresos = New System.Windows.Forms.Panel()
        Me.txt_OICantidad = New AdminEmpleados.NumericTextbox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_OIParen = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.dgv_OI = New System.Windows.Forms.DataGridView()
        Me.btnEIngresos = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.btn_OI = New System.Windows.Forms.PictureBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.pnlRow3 = New System.Windows.Forms.Panel()
        Me.PnlActividades = New System.Windows.Forms.Panel()
        Me.txt_EventosSociales = New AdminEmpleados.NumericTextbox()
        Me.txt_teatros = New AdminEmpleados.NumericTextbox()
        Me.txt_ParquesNaturales = New AdminEmpleados.NumericTextbox()
        Me.txt_Cines = New AdminEmpleados.NumericTextbox()
        Me.txt_PlazasPublicas = New AdminEmpleados.NumericTextbox()
        Me.txt_ParqueDeDiversiones = New AdminEmpleados.NumericTextbox()
        Me.txt_ZonasArquelogicas = New AdminEmpleados.NumericTextbox()
        Me.txt_Museos = New AdminEmpleados.NumericTextbox()
        Me.txt_Vacaciones = New AdminEmpleados.NumericTextbox()
        Me.txt_FestivalesCulturales = New AdminEmpleados.NumericTextbox()
        Me.txt_EventosComunitarios = New AdminEmpleados.NumericTextbox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.pnlRow2 = New System.Windows.Forms.Panel()
        Me.PnlTransporte = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.cb_Metro = New System.Windows.Forms.CheckBox()
        Me.cb_Trans = New System.Windows.Forms.CheckBox()
        Me.cb_Taxi = New System.Windows.Forms.CheckBox()
        Me.cb_Vehi = New System.Windows.Forms.CheckBox()
        Me.PnlDatos = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_Religion = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Txt_pasatiempos = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.pnlRow1 = New System.Windows.Forms.Panel()
        Me.GrpServicios = New System.Windows.Forms.GroupBox()
        Me.cb_Luz = New System.Windows.Forms.CheckBox()
        Me.cb_Drenaje = New System.Windows.Forms.CheckBox()
        Me.cb_SisSeg = New System.Windows.Forms.CheckBox()
        Me.cb_LineaTel = New System.Windows.Forms.CheckBox()
        Me.cb_TV = New System.Windows.Forms.CheckBox()
        Me.cb_Internet = New System.Windows.Forms.CheckBox()
        Me.cb_AguaP = New System.Windows.Forms.CheckBox()
        Me.cb_Tuberia = New System.Windows.Forms.CheckBox()
        Me.cb_Basura = New System.Windows.Forms.CheckBox()
        Me.pbVivienda = New System.Windows.Forms.PictureBox()
        Me.GrpMaterial = New System.Windows.Forms.GroupBox()
        Me.rbtnMaterial = New AdminEmpleados.RadioButtonList()
        Me.GrpTIpo = New System.Windows.Forms.GroupBox()
        Me.rbtnTipoDeVivienda = New AdminEmpleados.RadioButtonList()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tab_Enfer = New System.Windows.Forms.TabPage()
        Me.panel20 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dgvEnfermedades = New System.Windows.Forms.DataGridView()
        Me.txt_enfNAME = New System.Windows.Forms.TextBox()
        Me.label47 = New System.Windows.Forms.Label()
        Me.panel21 = New System.Windows.Forms.Panel()
        Me.btn_enfADD = New System.Windows.Forms.PictureBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.Tab_Cont = New System.Windows.Forms.TabPage()
        Me.panel18 = New System.Windows.Forms.Panel()
        Me.txt_conTEL = New AdminEmpleados.NumericTextbox()
        Me.txt_conCEL = New AdminEmpleados.NumericTextbox()
        Me.PnlContacto = New System.Windows.Forms.Panel()
        Me.dgvContactos = New System.Windows.Forms.DataGridView()
        Me.btnCOEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.label45 = New System.Windows.Forms.Label()
        Me.txt_conPAREN = New System.Windows.Forms.TextBox()
        Me.label41 = New System.Windows.Forms.Label()
        Me.label40 = New System.Windows.Forms.Label()
        Me.txt_conNAME = New System.Windows.Forms.TextBox()
        Me.txt_conAM = New System.Windows.Forms.TextBox()
        Me.txt_conAP = New System.Windows.Forms.TextBox()
        Me.label42 = New System.Windows.Forms.Label()
        Me.label43 = New System.Windows.Forms.Label()
        Me.label44 = New System.Windows.Forms.Label()
        Me.panel19 = New System.Windows.Forms.Panel()
        Me.btn_conADD = New System.Windows.Forms.PictureBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.Tab_AL = New System.Windows.Forms.TabPage()
        Me.panel16 = New System.Windows.Forms.Panel()
        Me.txt_antSALARIO = New AdminEmpleados.NumericTextbox()
        Me.pnlAntecedentes = New System.Windows.Forms.Panel()
        Me.dgvAntecedentesLaborales = New System.Windows.Forms.DataGridView()
        Me.btnAEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_antMT = New System.Windows.Forms.TextBox()
        Me.txt_antNAME = New System.Windows.Forms.TextBox()
        Me.txt_antTEL = New System.Windows.Forms.TextBox()
        Me.label37 = New System.Windows.Forms.Label()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label39 = New System.Windows.Forms.Label()
        Me.txt_antCARGO = New System.Windows.Forms.TextBox()
        Me.txt_antEMP = New System.Windows.Forms.TextBox()
        Me.label34 = New System.Windows.Forms.Label()
        Me.label35 = New System.Windows.Forms.Label()
        Me.label36 = New System.Windows.Forms.Label()
        Me.txt_antFF = New System.Windows.Forms.DateTimePicker()
        Me.label33 = New System.Windows.Forms.Label()
        Me.txt_antFI = New System.Windows.Forms.DateTimePicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.panel17 = New System.Windows.Forms.Panel()
        Me.btn_antSave = New System.Windows.Forms.PictureBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.Tab_Familia = New System.Windows.Forms.TabPage()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.PnlOffsprings = New System.Windows.Forms.Panel()
        Me.dgvHijos = New System.Windows.Forms.DataGridView()
        Me.btnHEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.label26 = New System.Windows.Forms.Label()
        Me.txt_hijoNACION = New System.Windows.Forms.TextBox()
        Me.txt_hijoFN = New System.Windows.Forms.DateTimePicker()
        Me.label27 = New System.Windows.Forms.Label()
        Me.txt_hijoNAME = New System.Windows.Forms.TextBox()
        Me.txt_hijoAM = New System.Windows.Forms.TextBox()
        Me.txt_hijoAP = New System.Windows.Forms.TextBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.cbHijosSexo = New System.Windows.Forms.ComboBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label31 = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.btn_hijoADD = New System.Windows.Forms.PictureBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.btn_esSAVE = New System.Windows.Forms.PictureBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.txt_esNacion = New System.Windows.Forms.TextBox()
        Me.dgvEsposa = New System.Windows.Forms.DataGridView()
        Me.btnCEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_esName = New System.Windows.Forms.TextBox()
        Me.txt_esAM = New System.Windows.Forms.TextBox()
        Me.txt_esFN = New System.Windows.Forms.DateTimePicker()
        Me.txt_esAP = New System.Windows.Forms.TextBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.cbConyugeSexo = New System.Windows.Forms.ComboBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Tab_DP = New System.Windows.Forms.TabPage()
        Me.pnl_estatus = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB_CLIENTE = New System.Windows.Forms.CheckBox()
        Me.seg = New System.Windows.Forms.CheckBox()
        Me.CB_PROV = New System.Windows.Forms.CheckBox()
        Me.panel13 = New System.Windows.Forms.Panel()
        Me.label15 = New System.Windows.Forms.Label()
        Me.PbOptions = New System.Windows.Forms.PictureBox()
        Me.lbl_option = New System.Windows.Forms.Label()
        Me.commen = New System.Windows.Forms.TextBox()
        Me.txt_activo = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txt_baja = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnl_cont = New System.Windows.Forms.Panel()
        Me.txtSalario = New AdminEmpleados.NumericTextbox()
        Me.buscar_depto = New System.Windows.Forms.PictureBox()
        Me.txtDeptoCodigo = New System.Windows.Forms.TextBox()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.Buscar_PUESTO = New System.Windows.Forms.PictureBox()
        Me.panel11 = New System.Windows.Forms.Panel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.Buscar_tipo = New System.Windows.Forms.PictureBox()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lbl_clase = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.lbl_super = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.Label()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.txtTipoCodigo = New System.Windows.Forms.TextBox()
        Me.lbl_sali = New System.Windows.Forms.Label()
        Me.dtpFechaDeIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Buscar_Super = New System.Windows.Forms.PictureBox()
        Me.txtPuestoCodigo = New System.Windows.Forms.TextBox()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.txtSupervisor = New System.Windows.Forms.TextBox()
        Me.txtSupervisorCodigo = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.pnl_per = New System.Windows.Forms.Panel()
        Me.Buscar_nac = New System.Windows.Forms.PictureBox()
        Me.txtTelefono = New AdminEmpleados.NumericTextbox()
        Me.txtCodigoPostal = New AdminEmpleados.NumericTextbox()
        Me.txtNSS = New AdminEmpleados.NumericTextbox()
        Me.txtCelular = New AdminEmpleados.NumericTextbox()
        Me.txtCdDomicilio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PbSearchEmployee = New System.Windows.Forms.PictureBox()
        Me.buscar_ciudad = New System.Windows.Forms.PictureBox()
        Me.pbFotoEmpleado = New System.Windows.Forms.PictureBox()
        Me.txtCiudadCodigo = New System.Windows.Forms.TextBox()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.lbl_ss = New System.Windows.Forms.Label()
        Me.LBL_CP = New System.Windows.Forms.Label()
        Me.txtCURP = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.cbNivelEducativo = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lbl_curp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_sex = New System.Windows.Forms.Label()
        Me.LBL_ESTADOCIVIL = New System.Windows.Forms.Label()
        Me.lbl_fn = New System.Windows.Forms.Label()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.lbl_nac = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtEntidad = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtEntidadCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtAMaterno = New System.Windows.Forms.TextBox()
        Me.txtAPaterno = New System.Windows.Forms.TextBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.lbl_ap = New System.Windows.Forms.Label()
        Me.lbl_am = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.MenuEmp = New System.Windows.Forms.TabControl()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.datosFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tam_Es.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlRow8.SuspendLayout()
        CType(Me.btn_SERPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SECancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SESave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRow7.SuspendLayout()
        Me.PnlObservaciones.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.pnlRow6.SuspendLayout()
        Me.PnlGastos.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.pnlRow5.SuspendLayout()
        Me.PnlReferencias.SuspendLayout()
        CType(Me.dgv_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.Btn_AddRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRow4.SuspendLayout()
        Me.PnlIngresos.SuspendLayout()
        CType(Me.dgv_OI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        CType(Me.btn_OI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRow3.SuspendLayout()
        Me.PnlActividades.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.pnlRow2.SuspendLayout()
        Me.PnlTransporte.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.PnlDatos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlRow1.SuspendLayout()
        Me.GrpServicios.SuspendLayout()
        CType(Me.pbVivienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpMaterial.SuspendLayout()
        Me.GrpTIpo.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Tab_Enfer.SuspendLayout()
        Me.panel20.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dgvEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel21.SuspendLayout()
        CType(Me.btn_enfADD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Cont.SuspendLayout()
        Me.panel18.SuspendLayout()
        Me.PnlContacto.SuspendLayout()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel19.SuspendLayout()
        CType(Me.btn_conADD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_AL.SuspendLayout()
        Me.panel16.SuspendLayout()
        Me.pnlAntecedentes.SuspendLayout()
        CType(Me.dgvAntecedentesLaborales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel17.SuspendLayout()
        CType(Me.btn_antSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Familia.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.PnlOffsprings.SuspendLayout()
        CType(Me.dgvHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel5.SuspendLayout()
        CType(Me.btn_hijoADD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.panel4.SuspendLayout()
        CType(Me.btn_esSAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEsposa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_DP.SuspendLayout()
        Me.pnl_estatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panel13.SuspendLayout()
        CType(Me.PbOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cont.SuspendLayout()
        CType(Me.buscar_depto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar_PUESTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel11.SuspendLayout()
        CType(Me.Buscar_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar_Super, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_per.SuspendLayout()
        CType(Me.Buscar_nac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbSearchEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_ciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFotoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuEmp.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'datosFamiliaBindingSource
        '
        Me.datosFamiliaBindingSource.DataMember = "Datos_Familia"
        '
        'btnEnELiminar
        '
        Me.btnEnELiminar.FillWeight = 18.13706!
        Me.btnEnELiminar.HeaderText = ""
        Me.btnEnELiminar.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.btnEnELiminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnEnELiminar.Name = "btnEnELiminar"
        Me.btnEnELiminar.Width = 48
        '
        'ID_Enf
        '
        Me.ID_Enf.DataPropertyName = "ID_Enf"
        Me.ID_Enf.HeaderText = "ID"
        Me.ID_Enf.Name = "ID_Enf"
        Me.ID_Enf.Visible = False
        '
        'Tam_Es
        '
        Me.Tam_Es.AutoScroll = True
        Me.Tam_Es.Controls.Add(Me.Panel1)
        Me.Tam_Es.Location = New System.Drawing.Point(4, 27)
        Me.Tam_Es.Name = "Tam_Es"
        Me.Tam_Es.Padding = New System.Windows.Forms.Padding(3)
        Me.Tam_Es.Size = New System.Drawing.Size(1070, 598)
        Me.Tam_Es.TabIndex = 5
        Me.Tam_Es.Text = "ESTUDIO SOCIOECONOMICO"
        Me.Tam_Es.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pnlRow8)
        Me.Panel1.Controls.Add(Me.pnlRow7)
        Me.Panel1.Controls.Add(Me.pnlRow6)
        Me.Panel1.Controls.Add(Me.pnlRow5)
        Me.Panel1.Controls.Add(Me.pnlRow4)
        Me.Panel1.Controls.Add(Me.pnlRow3)
        Me.Panel1.Controls.Add(Me.pnlRow2)
        Me.Panel1.Controls.Add(Me.pnlRow1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 592)
        Me.Panel1.TabIndex = 4
        '
        'pnlRow8
        '
        Me.pnlRow8.Controls.Add(Me.btn_SERPT)
        Me.pnlRow8.Controls.Add(Me.btn_SECancel)
        Me.pnlRow8.Controls.Add(Me.btn_SESave)
        Me.pnlRow8.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow8.Location = New System.Drawing.Point(0, 1250)
        Me.pnlRow8.Name = "pnlRow8"
        Me.pnlRow8.Size = New System.Drawing.Size(1043, 50)
        Me.pnlRow8.TabIndex = 83
        '
        'btn_SERPT
        '
        Me.btn_SERPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SERPT.Image = Global.AdminEmpleados.My.Resources.Resources.Accounting_80px
        Me.btn_SERPT.Location = New System.Drawing.Point(922, 3)
        Me.btn_SERPT.Name = "btn_SERPT"
        Me.btn_SERPT.Size = New System.Drawing.Size(35, 35)
        Me.btn_SERPT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SERPT.TabIndex = 76
        Me.btn_SERPT.TabStop = False
        '
        'btn_SECancel
        '
        Me.btn_SECancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SECancel.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_SECancel.Location = New System.Drawing.Point(998, 3)
        Me.btn_SECancel.Name = "btn_SECancel"
        Me.btn_SECancel.Size = New System.Drawing.Size(35, 35)
        Me.btn_SECancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SECancel.TabIndex = 75
        Me.btn_SECancel.TabStop = False
        '
        'btn_SESave
        '
        Me.btn_SESave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SESave.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.btn_SESave.Location = New System.Drawing.Point(960, 3)
        Me.btn_SESave.Name = "btn_SESave"
        Me.btn_SESave.Size = New System.Drawing.Size(35, 35)
        Me.btn_SESave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SESave.TabIndex = 74
        Me.btn_SESave.TabStop = False
        '
        'pnlRow7
        '
        Me.pnlRow7.Controls.Add(Me.PnlObservaciones)
        Me.pnlRow7.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow7.Location = New System.Drawing.Point(0, 1134)
        Me.pnlRow7.Name = "pnlRow7"
        Me.pnlRow7.Size = New System.Drawing.Size(1043, 116)
        Me.pnlRow7.TabIndex = 82
        '
        'PnlObservaciones
        '
        Me.PnlObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlObservaciones.Controls.Add(Me.txt_Observaciones)
        Me.PnlObservaciones.Controls.Add(Me.Panel26)
        Me.PnlObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlObservaciones.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlObservaciones.Location = New System.Drawing.Point(0, 0)
        Me.PnlObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlObservaciones.Name = "PnlObservaciones"
        Me.PnlObservaciones.Size = New System.Drawing.Size(1043, 111)
        Me.PnlObservaciones.TabIndex = 73
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Observaciones.Location = New System.Drawing.Point(0, 35)
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(1041, 74)
        Me.txt_Observaciones.TabIndex = 31
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel26.Controls.Add(Me.Label71)
        Me.Panel26.Controls.Add(Me.Label76)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(0, 0)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1041, 35)
        Me.Panel26.TabIndex = 0
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.White
        Me.Label71.Location = New System.Drawing.Point(2, 6)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(120, 21)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Observaciones"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.White
        Me.Label76.Location = New System.Drawing.Point(13, 6)
        Me.Label76.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(0, 21)
        Me.Label76.TabIndex = 0
        '
        'pnlRow6
        '
        Me.pnlRow6.Controls.Add(Me.PnlGastos)
        Me.pnlRow6.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow6.Location = New System.Drawing.Point(0, 1051)
        Me.pnlRow6.Name = "pnlRow6"
        Me.pnlRow6.Size = New System.Drawing.Size(1043, 83)
        Me.pnlRow6.TabIndex = 81
        '
        'PnlGastos
        '
        Me.PnlGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlGastos.Controls.Add(Me.txt_GFRenta)
        Me.PnlGastos.Controls.Add(Me.txt_GFCole)
        Me.PnlGastos.Controls.Add(Me.Txt_GFDesp)
        Me.PnlGastos.Controls.Add(Me.txt_GFServ)
        Me.PnlGastos.Controls.Add(Me.Label64)
        Me.PnlGastos.Controls.Add(Me.Label73)
        Me.PnlGastos.Controls.Add(Me.Panel30)
        Me.PnlGastos.Controls.Add(Me.Label72)
        Me.PnlGastos.Controls.Add(Me.Label62)
        Me.PnlGastos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlGastos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlGastos.Location = New System.Drawing.Point(0, 0)
        Me.PnlGastos.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlGastos.Name = "PnlGastos"
        Me.PnlGastos.Size = New System.Drawing.Size(1043, 78)
        Me.PnlGastos.TabIndex = 72
        '
        'txt_GFRenta
        '
        Me.txt_GFRenta.AcceptsDecimals = True
        Me.txt_GFRenta.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_GFRenta.Location = New System.Drawing.Point(94, 40)
        Me.txt_GFRenta.Name = "txt_GFRenta"
        Me.txt_GFRenta.Size = New System.Drawing.Size(95, 25)
        Me.txt_GFRenta.TabIndex = 98
        '
        'txt_GFCole
        '
        Me.txt_GFCole.AcceptsDecimals = True
        Me.txt_GFCole.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_GFCole.Location = New System.Drawing.Point(290, 40)
        Me.txt_GFCole.Name = "txt_GFCole"
        Me.txt_GFCole.Size = New System.Drawing.Size(95, 25)
        Me.txt_GFCole.TabIndex = 97
        '
        'Txt_GFDesp
        '
        Me.Txt_GFDesp.AcceptsDecimals = True
        Me.Txt_GFDesp.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.Txt_GFDesp.Location = New System.Drawing.Point(465, 40)
        Me.Txt_GFDesp.Name = "Txt_GFDesp"
        Me.Txt_GFDesp.Size = New System.Drawing.Size(95, 25)
        Me.Txt_GFDesp.TabIndex = 96
        '
        'txt_GFServ
        '
        Me.txt_GFServ.AcceptsDecimals = True
        Me.txt_GFServ.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_GFServ.Location = New System.Drawing.Point(644, 40)
        Me.txt_GFServ.Name = "txt_GFServ"
        Me.txt_GFServ.Size = New System.Drawing.Size(95, 25)
        Me.txt_GFServ.TabIndex = 95
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(570, 43)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(68, 18)
        Me.Label64.TabIndex = 66
        Me.Label64.Text = "Servicios:"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(37, 43)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(50, 18)
        Me.Label73.TabIndex = 57
        Me.Label73.Text = "Renta:"
        '
        'Panel30
        '
        Me.Panel30.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel30.Controls.Add(Me.Label74)
        Me.Panel30.Controls.Add(Me.Label75)
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel30.Location = New System.Drawing.Point(0, 0)
        Me.Panel30.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1041, 35)
        Me.Panel30.TabIndex = 0
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(2, 6)
        Me.Label74.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(100, 21)
        Me.Label74.TabIndex = 1
        Me.Label74.Text = "Gastos Fijos"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.White
        Me.Label75.Location = New System.Drawing.Point(13, 6)
        Me.Label75.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(0, 21)
        Me.Label75.TabIndex = 0
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(194, 43)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(90, 18)
        Me.Label72.TabIndex = 62
        Me.Label72.Text = "Colegiaturas:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(391, 43)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(72, 18)
        Me.Label62.TabIndex = 64
        Me.Label62.Text = "Despensa:"
        '
        'pnlRow5
        '
        Me.pnlRow5.Controls.Add(Me.PnlReferencias)
        Me.pnlRow5.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow5.Location = New System.Drawing.Point(0, 830)
        Me.pnlRow5.Name = "pnlRow5"
        Me.pnlRow5.Size = New System.Drawing.Size(1043, 221)
        Me.pnlRow5.TabIndex = 80
        '
        'PnlReferencias
        '
        Me.PnlReferencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlReferencias.Controls.Add(Me.dgv_Ref)
        Me.PnlReferencias.Controls.Add(Me.Label52)
        Me.PnlReferencias.Controls.Add(Me.txt_TiempoDeConocerse)
        Me.PnlReferencias.Controls.Add(Me.txt_RefOcu)
        Me.PnlReferencias.Controls.Add(Me.Label56)
        Me.PnlReferencias.Controls.Add(Me.Label46)
        Me.PnlReferencias.Controls.Add(Me.Txt_TipoDeRelacion)
        Me.PnlReferencias.Controls.Add(Me.txt_RefNom)
        Me.PnlReferencias.Controls.Add(Me.Label48)
        Me.PnlReferencias.Controls.Add(Me.Panel10)
        Me.PnlReferencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlReferencias.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlReferencias.Location = New System.Drawing.Point(0, 0)
        Me.PnlReferencias.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlReferencias.Name = "PnlReferencias"
        Me.PnlReferencias.Size = New System.Drawing.Size(1043, 216)
        Me.PnlReferencias.TabIndex = 71
        '
        'dgv_Ref
        '
        Me.dgv_Ref.AllowUserToAddRows = False
        Me.dgv_Ref.AllowUserToDeleteRows = False
        Me.dgv_Ref.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ref.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnEReferencia})
        Me.dgv_Ref.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Ref.Location = New System.Drawing.Point(0, 116)
        Me.dgv_Ref.Name = "dgv_Ref"
        Me.dgv_Ref.ReadOnly = True
        Me.dgv_Ref.RowHeadersVisible = False
        Me.dgv_Ref.Size = New System.Drawing.Size(1041, 98)
        Me.dgv_Ref.TabIndex = 55
        '
        'btnEReferencia
        '
        Me.btnEReferencia.FillWeight = 11.0!
        Me.btnEReferencia.HeaderText = ""
        Me.btnEReferencia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnEReferencia.Name = "btnEReferencia"
        Me.btnEReferencia.ReadOnly = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(664, 74)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(60, 18)
        Me.Label52.TabIndex = 53
        Me.Label52.Text = "Tiempo:"
        '
        'txt_TiempoDeConocerse
        '
        Me.txt_TiempoDeConocerse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TiempoDeConocerse.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TiempoDeConocerse.Location = New System.Drawing.Point(730, 71)
        Me.txt_TiempoDeConocerse.Name = "txt_TiempoDeConocerse"
        Me.txt_TiempoDeConocerse.Size = New System.Drawing.Size(208, 25)
        Me.txt_TiempoDeConocerse.TabIndex = 5
        '
        'txt_RefOcu
        '
        Me.txt_RefOcu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefOcu.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefOcu.Location = New System.Drawing.Point(233, 71)
        Me.txt_RefOcu.Name = "txt_RefOcu"
        Me.txt_RefOcu.Size = New System.Drawing.Size(209, 25)
        Me.txt_RefOcu.TabIndex = 4
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(602, 43)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(122, 18)
        Me.Label56.TabIndex = 51
        Me.Label56.Text = "Tipo de Relacion:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(149, 74)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(78, 18)
        Me.Label46.TabIndex = 44
        Me.Label46.Text = "Ocupacion:"
        '
        'Txt_TipoDeRelacion
        '
        Me.Txt_TipoDeRelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TipoDeRelacion.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TipoDeRelacion.Location = New System.Drawing.Point(730, 40)
        Me.Txt_TipoDeRelacion.Name = "Txt_TipoDeRelacion"
        Me.Txt_TipoDeRelacion.Size = New System.Drawing.Size(209, 25)
        Me.Txt_TipoDeRelacion.TabIndex = 3
        '
        'txt_RefNom
        '
        Me.txt_RefNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefNom.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RefNom.Location = New System.Drawing.Point(233, 40)
        Me.txt_RefNom.Name = "txt_RefNom"
        Me.txt_RefNom.Size = New System.Drawing.Size(363, 25)
        Me.txt_RefNom.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(165, 43)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(62, 18)
        Me.Label48.TabIndex = 37
        Me.Label48.Text = "Nombre:"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Btn_AddRef)
        Me.Panel10.Controls.Add(Me.Label51)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1041, 35)
        Me.Panel10.TabIndex = 0
        '
        'Btn_AddRef
        '
        Me.Btn_AddRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddRef.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddRef.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Reference_80px
        Me.Btn_AddRef.Location = New System.Drawing.Point(985, 0)
        Me.Btn_AddRef.Name = "Btn_AddRef"
        Me.Btn_AddRef.Size = New System.Drawing.Size(35, 35)
        Me.Btn_AddRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_AddRef.TabIndex = 63
        Me.Btn_AddRef.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(2, 6)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(97, 21)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Referencias"
        '
        'pnlRow4
        '
        Me.pnlRow4.Controls.Add(Me.PnlIngresos)
        Me.pnlRow4.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow4.Location = New System.Drawing.Point(0, 643)
        Me.pnlRow4.Name = "pnlRow4"
        Me.pnlRow4.Size = New System.Drawing.Size(1043, 187)
        Me.pnlRow4.TabIndex = 79
        '
        'PnlIngresos
        '
        Me.PnlIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlIngresos.Controls.Add(Me.txt_OICantidad)
        Me.PnlIngresos.Controls.Add(Me.Label63)
        Me.PnlIngresos.Controls.Add(Me.txt_OIParen)
        Me.PnlIngresos.Controls.Add(Me.Label65)
        Me.PnlIngresos.Controls.Add(Me.dgv_OI)
        Me.PnlIngresos.Controls.Add(Me.Panel14)
        Me.PnlIngresos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlIngresos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlIngresos.Location = New System.Drawing.Point(0, 0)
        Me.PnlIngresos.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlIngresos.Name = "PnlIngresos"
        Me.PnlIngresos.Size = New System.Drawing.Size(1043, 182)
        Me.PnlIngresos.TabIndex = 51
        '
        'txt_OICantidad
        '
        Me.txt_OICantidad.AcceptsDecimals = True
        Me.txt_OICantidad.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_OICantidad.Location = New System.Drawing.Point(515, 40)
        Me.txt_OICantidad.Name = "txt_OICantidad"
        Me.txt_OICantidad.Size = New System.Drawing.Size(209, 25)
        Me.txt_OICantidad.TabIndex = 94
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(440, 43)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(70, 18)
        Me.Label63.TabIndex = 62
        Me.Label63.Text = "Cantidad:"
        '
        'txt_OIParen
        '
        Me.txt_OIParen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OIParen.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OIParen.Location = New System.Drawing.Point(222, 40)
        Me.txt_OIParen.Name = "txt_OIParen"
        Me.txt_OIParen.Size = New System.Drawing.Size(212, 25)
        Me.txt_OIParen.TabIndex = 15
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(136, 43)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(80, 18)
        Me.Label65.TabIndex = 57
        Me.Label65.Text = "Parentesco:"
        '
        'dgv_OI
        '
        Me.dgv_OI.AllowUserToAddRows = False
        Me.dgv_OI.AllowUserToDeleteRows = False
        Me.dgv_OI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_OI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_OI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnEIngresos})
        Me.dgv_OI.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_OI.Location = New System.Drawing.Point(0, 73)
        Me.dgv_OI.Name = "dgv_OI"
        Me.dgv_OI.ReadOnly = True
        Me.dgv_OI.RowHeadersVisible = False
        Me.dgv_OI.Size = New System.Drawing.Size(1041, 107)
        Me.dgv_OI.TabIndex = 55
        '
        'btnEIngresos
        '
        Me.btnEIngresos.FillWeight = 11.0!
        Me.btnEIngresos.HeaderText = ""
        Me.btnEIngresos.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnEIngresos.Name = "btnEIngresos"
        Me.btnEIngresos.ReadOnly = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel14.Controls.Add(Me.btn_OI)
        Me.Panel14.Controls.Add(Me.Label60)
        Me.Panel14.Controls.Add(Me.Label61)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1041, 35)
        Me.Panel14.TabIndex = 0
        '
        'btn_OI
        '
        Me.btn_OI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_OI.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Income_80px
        Me.btn_OI.Location = New System.Drawing.Point(985, 0)
        Me.btn_OI.Name = "btn_OI"
        Me.btn_OI.Size = New System.Drawing.Size(35, 35)
        Me.btn_OI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_OI.TabIndex = 55
        Me.btn_OI.TabStop = False
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(2, 6)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(121, 21)
        Me.Label60.TabIndex = 1
        Me.Label60.Text = "Otros Ingresos"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(13, 6)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(0, 21)
        Me.Label61.TabIndex = 0
        '
        'pnlRow3
        '
        Me.pnlRow3.Controls.Add(Me.PnlActividades)
        Me.pnlRow3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow3.Location = New System.Drawing.Point(0, 393)
        Me.pnlRow3.Name = "pnlRow3"
        Me.pnlRow3.Size = New System.Drawing.Size(1043, 250)
        Me.pnlRow3.TabIndex = 78
        '
        'PnlActividades
        '
        Me.PnlActividades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlActividades.Controls.Add(Me.txt_EventosSociales)
        Me.PnlActividades.Controls.Add(Me.txt_teatros)
        Me.PnlActividades.Controls.Add(Me.txt_ParquesNaturales)
        Me.PnlActividades.Controls.Add(Me.txt_Cines)
        Me.PnlActividades.Controls.Add(Me.txt_PlazasPublicas)
        Me.PnlActividades.Controls.Add(Me.txt_ParqueDeDiversiones)
        Me.PnlActividades.Controls.Add(Me.txt_ZonasArquelogicas)
        Me.PnlActividades.Controls.Add(Me.txt_Museos)
        Me.PnlActividades.Controls.Add(Me.txt_Vacaciones)
        Me.PnlActividades.Controls.Add(Me.txt_FestivalesCulturales)
        Me.PnlActividades.Controls.Add(Me.txt_EventosComunitarios)
        Me.PnlActividades.Controls.Add(Me.Label90)
        Me.PnlActividades.Controls.Add(Me.Label88)
        Me.PnlActividades.Controls.Add(Me.Label89)
        Me.PnlActividades.Controls.Add(Me.Label83)
        Me.PnlActividades.Controls.Add(Me.Label85)
        Me.PnlActividades.Controls.Add(Me.Label87)
        Me.PnlActividades.Controls.Add(Me.Label80)
        Me.PnlActividades.Controls.Add(Me.Label86)
        Me.PnlActividades.Controls.Add(Me.Label81)
        Me.PnlActividades.Controls.Add(Me.Label78)
        Me.PnlActividades.Controls.Add(Me.Label79)
        Me.PnlActividades.Controls.Add(Me.Panel36)
        Me.PnlActividades.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlActividades.Location = New System.Drawing.Point(0, 0)
        Me.PnlActividades.Name = "PnlActividades"
        Me.PnlActividades.Size = New System.Drawing.Size(1043, 245)
        Me.PnlActividades.TabIndex = 51
        '
        'txt_EventosSociales
        '
        Me.txt_EventosSociales.AcceptsDecimals = False
        Me.txt_EventosSociales.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_EventosSociales.Location = New System.Drawing.Point(800, 40)
        Me.txt_EventosSociales.Name = "txt_EventosSociales"
        Me.txt_EventosSociales.Size = New System.Drawing.Size(209, 25)
        Me.txt_EventosSociales.TabIndex = 93
        '
        'txt_teatros
        '
        Me.txt_teatros.AcceptsDecimals = False
        Me.txt_teatros.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_teatros.Location = New System.Drawing.Point(800, 71)
        Me.txt_teatros.Name = "txt_teatros"
        Me.txt_teatros.Size = New System.Drawing.Size(209, 25)
        Me.txt_teatros.TabIndex = 92
        '
        'txt_ParquesNaturales
        '
        Me.txt_ParquesNaturales.AcceptsDecimals = False
        Me.txt_ParquesNaturales.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_ParquesNaturales.Location = New System.Drawing.Point(800, 102)
        Me.txt_ParquesNaturales.Name = "txt_ParquesNaturales"
        Me.txt_ParquesNaturales.Size = New System.Drawing.Size(209, 25)
        Me.txt_ParquesNaturales.TabIndex = 91
        '
        'txt_Cines
        '
        Me.txt_Cines.AcceptsDecimals = False
        Me.txt_Cines.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_Cines.Location = New System.Drawing.Point(800, 133)
        Me.txt_Cines.Name = "txt_Cines"
        Me.txt_Cines.Size = New System.Drawing.Size(209, 25)
        Me.txt_Cines.TabIndex = 90
        '
        'txt_PlazasPublicas
        '
        Me.txt_PlazasPublicas.AcceptsDecimals = False
        Me.txt_PlazasPublicas.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_PlazasPublicas.Location = New System.Drawing.Point(800, 164)
        Me.txt_PlazasPublicas.Name = "txt_PlazasPublicas"
        Me.txt_PlazasPublicas.Size = New System.Drawing.Size(209, 25)
        Me.txt_PlazasPublicas.TabIndex = 89
        '
        'txt_ParqueDeDiversiones
        '
        Me.txt_ParqueDeDiversiones.AcceptsDecimals = False
        Me.txt_ParqueDeDiversiones.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_ParqueDeDiversiones.Location = New System.Drawing.Point(233, 195)
        Me.txt_ParqueDeDiversiones.Name = "txt_ParqueDeDiversiones"
        Me.txt_ParqueDeDiversiones.Size = New System.Drawing.Size(209, 25)
        Me.txt_ParqueDeDiversiones.TabIndex = 88
        '
        'txt_ZonasArquelogicas
        '
        Me.txt_ZonasArquelogicas.AcceptsDecimals = False
        Me.txt_ZonasArquelogicas.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_ZonasArquelogicas.Location = New System.Drawing.Point(234, 164)
        Me.txt_ZonasArquelogicas.Name = "txt_ZonasArquelogicas"
        Me.txt_ZonasArquelogicas.Size = New System.Drawing.Size(209, 25)
        Me.txt_ZonasArquelogicas.TabIndex = 87
        '
        'txt_Museos
        '
        Me.txt_Museos.AcceptsDecimals = False
        Me.txt_Museos.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_Museos.Location = New System.Drawing.Point(234, 133)
        Me.txt_Museos.Name = "txt_Museos"
        Me.txt_Museos.Size = New System.Drawing.Size(209, 25)
        Me.txt_Museos.TabIndex = 86
        '
        'txt_Vacaciones
        '
        Me.txt_Vacaciones.AcceptsDecimals = False
        Me.txt_Vacaciones.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_Vacaciones.Location = New System.Drawing.Point(233, 102)
        Me.txt_Vacaciones.Name = "txt_Vacaciones"
        Me.txt_Vacaciones.Size = New System.Drawing.Size(209, 25)
        Me.txt_Vacaciones.TabIndex = 85
        '
        'txt_FestivalesCulturales
        '
        Me.txt_FestivalesCulturales.AcceptsDecimals = False
        Me.txt_FestivalesCulturales.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_FestivalesCulturales.Location = New System.Drawing.Point(233, 71)
        Me.txt_FestivalesCulturales.Name = "txt_FestivalesCulturales"
        Me.txt_FestivalesCulturales.Size = New System.Drawing.Size(209, 25)
        Me.txt_FestivalesCulturales.TabIndex = 84
        '
        'txt_EventosComunitarios
        '
        Me.txt_EventosComunitarios.AcceptsDecimals = False
        Me.txt_EventosComunitarios.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_EventosComunitarios.Location = New System.Drawing.Point(233, 40)
        Me.txt_EventosComunitarios.Name = "txt_EventosComunitarios"
        Me.txt_EventosComunitarios.Size = New System.Drawing.Size(209, 25)
        Me.txt_EventosComunitarios.TabIndex = 83
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(72, 198)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(156, 18)
        Me.Label90.TabIndex = 82
        Me.Label90.Text = "Parque de Diversiones:"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(665, 105)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(129, 18)
        Me.Label88.TabIndex = 79
        Me.Label88.Text = "Parques Naturales:"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(680, 167)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(114, 18)
        Me.Label89.TabIndex = 81
        Me.Label89.Text = "Plazas Publicas:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(83, 74)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(145, 18)
        Me.Label83.TabIndex = 71
        Me.Label83.Text = "Festivales Culturales:"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(747, 136)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(47, 18)
        Me.Label85.TabIndex = 77
        Me.Label85.Text = "Cines:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(84, 167)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(144, 18)
        Me.Label87.TabIndex = 80
        Me.Label87.Text = "Zonas Arqueologicas:"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(735, 74)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(59, 18)
        Me.Label80.TabIndex = 70
        Me.Label80.Text = "Teatros:"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(146, 105)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(82, 18)
        Me.Label86.TabIndex = 78
        Me.Label86.Text = "Vacaciones:"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(169, 136)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(59, 18)
        Me.Label81.TabIndex = 76
        Me.Label81.Text = "Museos:"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(567, 43)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(227, 18)
        Me.Label78.TabIndex = 69
        Me.Label78.Text = "Eventos sociales (Fam o Amigos):"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(74, 43)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(154, 18)
        Me.Label79.TabIndex = 68
        Me.Label79.Text = "Eventos Comunitarios:"
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel36.Controls.Add(Me.Label84)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel36.Location = New System.Drawing.Point(0, 0)
        Me.Panel36.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(1041, 35)
        Me.Panel36.TabIndex = 28
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.White
        Me.Label84.Location = New System.Drawing.Point(2, 6)
        Me.Label84.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(96, 21)
        Me.Label84.TabIndex = 0
        Me.Label84.Text = "Actividades"
        '
        'pnlRow2
        '
        Me.pnlRow2.Controls.Add(Me.PnlTransporte)
        Me.pnlRow2.Controls.Add(Me.PnlDatos)
        Me.pnlRow2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow2.Location = New System.Drawing.Point(0, 283)
        Me.pnlRow2.Name = "pnlRow2"
        Me.pnlRow2.Size = New System.Drawing.Size(1043, 110)
        Me.pnlRow2.TabIndex = 77
        '
        'PnlTransporte
        '
        Me.PnlTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTransporte.Controls.Add(Me.Panel22)
        Me.PnlTransporte.Controls.Add(Me.cb_Metro)
        Me.PnlTransporte.Controls.Add(Me.cb_Trans)
        Me.PnlTransporte.Controls.Add(Me.cb_Taxi)
        Me.PnlTransporte.Controls.Add(Me.cb_Vehi)
        Me.PnlTransporte.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlTransporte.Location = New System.Drawing.Point(0, 0)
        Me.PnlTransporte.Name = "PnlTransporte"
        Me.PnlTransporte.Size = New System.Drawing.Size(512, 110)
        Me.PnlTransporte.TabIndex = 1
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel22.Controls.Add(Me.Label57)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(510, 35)
        Me.Panel22.TabIndex = 2
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(2, 6)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(92, 21)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Transporte"
        '
        'cb_Metro
        '
        Me.cb_Metro.AutoSize = True
        Me.cb_Metro.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Metro.Location = New System.Drawing.Point(23, 54)
        Me.cb_Metro.Name = "cb_Metro"
        Me.cb_Metro.Size = New System.Drawing.Size(65, 22)
        Me.cb_Metro.TabIndex = 7
        Me.cb_Metro.Text = "Metro"
        Me.cb_Metro.UseVisualStyleBackColor = True
        '
        'cb_Trans
        '
        Me.cb_Trans.AutoSize = True
        Me.cb_Trans.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Trans.Location = New System.Drawing.Point(94, 54)
        Me.cb_Trans.Name = "cb_Trans"
        Me.cb_Trans.Size = New System.Drawing.Size(151, 22)
        Me.cb_Trans.TabIndex = 8
        Me.cb_Trans.Text = "Transporte Publico"
        Me.cb_Trans.UseVisualStyleBackColor = True
        '
        'cb_Taxi
        '
        Me.cb_Taxi.AutoSize = True
        Me.cb_Taxi.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Taxi.Location = New System.Drawing.Point(251, 54)
        Me.cb_Taxi.Name = "cb_Taxi"
        Me.cb_Taxi.Size = New System.Drawing.Size(57, 22)
        Me.cb_Taxi.TabIndex = 9
        Me.cb_Taxi.Text = "Taxi"
        Me.cb_Taxi.UseVisualStyleBackColor = True
        '
        'cb_Vehi
        '
        Me.cb_Vehi.AutoSize = True
        Me.cb_Vehi.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Vehi.Location = New System.Drawing.Point(314, 54)
        Me.cb_Vehi.Name = "cb_Vehi"
        Me.cb_Vehi.Size = New System.Drawing.Size(132, 22)
        Me.cb_Vehi.TabIndex = 10
        Me.cb_Vehi.Text = "Vehiculo Propio"
        Me.cb_Vehi.UseVisualStyleBackColor = True
        '
        'PnlDatos
        '
        Me.PnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDatos.Controls.Add(Me.Panel6)
        Me.PnlDatos.Controls.Add(Me.txt_Religion)
        Me.PnlDatos.Controls.Add(Me.Label50)
        Me.PnlDatos.Controls.Add(Me.Txt_pasatiempos)
        Me.PnlDatos.Controls.Add(Me.Label49)
        Me.PnlDatos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlDatos.Location = New System.Drawing.Point(531, 0)
        Me.PnlDatos.Name = "PnlDatos"
        Me.PnlDatos.Size = New System.Drawing.Size(512, 110)
        Me.PnlDatos.TabIndex = 50
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label53)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(510, 35)
        Me.Panel6.TabIndex = 0
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(2, 6)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(54, 21)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Datos"
        '
        'txt_Religion
        '
        Me.txt_Religion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Religion.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Religion.Location = New System.Drawing.Point(121, 40)
        Me.txt_Religion.Name = "txt_Religion"
        Me.txt_Religion.Size = New System.Drawing.Size(293, 25)
        Me.txt_Religion.TabIndex = 0
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(48, 43)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(67, 18)
        Me.Label50.TabIndex = 37
        Me.Label50.Text = "Religion:"
        '
        'Txt_pasatiempos
        '
        Me.Txt_pasatiempos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_pasatiempos.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pasatiempos.Location = New System.Drawing.Point(121, 71)
        Me.Txt_pasatiempos.Name = "Txt_pasatiempos"
        Me.Txt_pasatiempos.Size = New System.Drawing.Size(293, 25)
        Me.Txt_pasatiempos.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(24, 74)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 18)
        Me.Label49.TabIndex = 44
        Me.Label49.Text = "Pasatiempos:"
        '
        'pnlRow1
        '
        Me.pnlRow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRow1.Controls.Add(Me.GrpServicios)
        Me.pnlRow1.Controls.Add(Me.pbVivienda)
        Me.pnlRow1.Controls.Add(Me.GrpMaterial)
        Me.pnlRow1.Controls.Add(Me.GrpTIpo)
        Me.pnlRow1.Controls.Add(Me.Panel15)
        Me.pnlRow1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRow1.Location = New System.Drawing.Point(0, 0)
        Me.pnlRow1.Name = "pnlRow1"
        Me.pnlRow1.Size = New System.Drawing.Size(1043, 283)
        Me.pnlRow1.TabIndex = 0
        '
        'GrpServicios
        '
        Me.GrpServicios.Controls.Add(Me.cb_Luz)
        Me.GrpServicios.Controls.Add(Me.cb_Drenaje)
        Me.GrpServicios.Controls.Add(Me.cb_SisSeg)
        Me.GrpServicios.Controls.Add(Me.cb_LineaTel)
        Me.GrpServicios.Controls.Add(Me.cb_TV)
        Me.GrpServicios.Controls.Add(Me.cb_Internet)
        Me.GrpServicios.Controls.Add(Me.cb_AguaP)
        Me.GrpServicios.Controls.Add(Me.cb_Tuberia)
        Me.GrpServicios.Controls.Add(Me.cb_Basura)
        Me.GrpServicios.Location = New System.Drawing.Point(465, 155)
        Me.GrpServicios.Name = "GrpServicios"
        Me.GrpServicios.Size = New System.Drawing.Size(544, 120)
        Me.GrpServicios.TabIndex = 16
        Me.GrpServicios.TabStop = False
        Me.GrpServicios.Text = "Servicios"
        '
        'cb_Luz
        '
        Me.cb_Luz.AutoSize = True
        Me.cb_Luz.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Luz.Location = New System.Drawing.Point(37, 27)
        Me.cb_Luz.Name = "cb_Luz"
        Me.cb_Luz.Size = New System.Drawing.Size(53, 22)
        Me.cb_Luz.TabIndex = 18
        Me.cb_Luz.Text = "Luz"
        Me.cb_Luz.UseVisualStyleBackColor = True
        '
        'cb_Drenaje
        '
        Me.cb_Drenaje.AutoSize = True
        Me.cb_Drenaje.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Drenaje.Location = New System.Drawing.Point(96, 27)
        Me.cb_Drenaje.Name = "cb_Drenaje"
        Me.cb_Drenaje.Size = New System.Drawing.Size(78, 22)
        Me.cb_Drenaje.TabIndex = 21
        Me.cb_Drenaje.Text = "Drenaje"
        Me.cb_Drenaje.UseVisualStyleBackColor = True
        '
        'cb_SisSeg
        '
        Me.cb_SisSeg.AutoSize = True
        Me.cb_SisSeg.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_SisSeg.Location = New System.Drawing.Point(37, 83)
        Me.cb_SisSeg.Name = "cb_SisSeg"
        Me.cb_SisSeg.Size = New System.Drawing.Size(163, 22)
        Me.cb_SisSeg.TabIndex = 26
        Me.cb_SisSeg.Text = "Sistema de Seguridad"
        Me.cb_SisSeg.UseVisualStyleBackColor = True
        '
        'cb_LineaTel
        '
        Me.cb_LineaTel.AutoSize = True
        Me.cb_LineaTel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_LineaTel.Location = New System.Drawing.Point(192, 55)
        Me.cb_LineaTel.Name = "cb_LineaTel"
        Me.cb_LineaTel.Size = New System.Drawing.Size(137, 22)
        Me.cb_LineaTel.TabIndex = 19
        Me.cb_LineaTel.Text = "Linea Telefonica"
        Me.cb_LineaTel.UseVisualStyleBackColor = True
        '
        'cb_TV
        '
        Me.cb_TV.AutoSize = True
        Me.cb_TV.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_TV.Location = New System.Drawing.Point(338, 55)
        Me.cb_TV.Name = "cb_TV"
        Me.cb_TV.Size = New System.Drawing.Size(114, 22)
        Me.cb_TV.TabIndex = 24
        Me.cb_TV.Text = "TV por Cable"
        Me.cb_TV.UseVisualStyleBackColor = True
        '
        'cb_Internet
        '
        Me.cb_Internet.AutoSize = True
        Me.cb_Internet.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Internet.Location = New System.Drawing.Point(430, 27)
        Me.cb_Internet.Name = "cb_Internet"
        Me.cb_Internet.Size = New System.Drawing.Size(80, 22)
        Me.cb_Internet.TabIndex = 25
        Me.cb_Internet.Text = "Internet"
        Me.cb_Internet.UseVisualStyleBackColor = True
        '
        'cb_AguaP
        '
        Me.cb_AguaP.AutoSize = True
        Me.cb_AguaP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_AguaP.Location = New System.Drawing.Point(180, 27)
        Me.cb_AguaP.Name = "cb_AguaP"
        Me.cb_AguaP.Size = New System.Drawing.Size(113, 22)
        Me.cb_AguaP.TabIndex = 20
        Me.cb_AguaP.Text = "Agua Potable"
        Me.cb_AguaP.UseVisualStyleBackColor = True
        '
        'cb_Tuberia
        '
        Me.cb_Tuberia.AutoSize = True
        Me.cb_Tuberia.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Tuberia.Location = New System.Drawing.Point(299, 27)
        Me.cb_Tuberia.Name = "cb_Tuberia"
        Me.cb_Tuberia.Size = New System.Drawing.Size(125, 22)
        Me.cb_Tuberia.TabIndex = 22
        Me.cb_Tuberia.Text = "Tuberia de Gas"
        Me.cb_Tuberia.UseVisualStyleBackColor = True
        '
        'cb_Basura
        '
        Me.cb_Basura.AutoSize = True
        Me.cb_Basura.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Basura.Location = New System.Drawing.Point(37, 55)
        Me.cb_Basura.Name = "cb_Basura"
        Me.cb_Basura.Size = New System.Drawing.Size(151, 22)
        Me.cb_Basura.TabIndex = 23
        Me.cb_Basura.Text = "Recoleccion Basura"
        Me.cb_Basura.UseVisualStyleBackColor = True
        '
        'pbVivienda
        '
        Me.pbVivienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbVivienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVivienda.Image = CType(resources.GetObject("pbVivienda.Image"), System.Drawing.Image)
        Me.pbVivienda.Location = New System.Drawing.Point(6, 40)
        Me.pbVivienda.Name = "pbVivienda"
        Me.pbVivienda.Size = New System.Drawing.Size(450, 235)
        Me.pbVivienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbVivienda.TabIndex = 32
        Me.pbVivienda.TabStop = False
        '
        'GrpMaterial
        '
        Me.GrpMaterial.Controls.Add(Me.rbtnMaterial)
        Me.GrpMaterial.Location = New System.Drawing.Point(465, 95)
        Me.GrpMaterial.Name = "GrpMaterial"
        Me.GrpMaterial.Size = New System.Drawing.Size(544, 54)
        Me.GrpMaterial.TabIndex = 15
        Me.GrpMaterial.TabStop = False
        Me.GrpMaterial.Text = "Material"
        '
        'rbtnMaterial
        '
        Me.rbtnMaterial.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.rbtnMaterial.ListOfItems = New String() {"Adobe", "Block", "Ladrillo", "Madera", "Lamina"}
        Me.rbtnMaterial.Location = New System.Drawing.Point(6, 18)
        Me.rbtnMaterial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnMaterial.Name = "rbtnMaterial"
        Me.rbtnMaterial.SelectedValue = ""
        Me.rbtnMaterial.Size = New System.Drawing.Size(536, 27)
        Me.rbtnMaterial.TabIndex = 83
        '
        'GrpTIpo
        '
        Me.GrpTIpo.Controls.Add(Me.rbtnTipoDeVivienda)
        Me.GrpTIpo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.GrpTIpo.Location = New System.Drawing.Point(465, 40)
        Me.GrpTIpo.Name = "GrpTIpo"
        Me.GrpTIpo.Size = New System.Drawing.Size(544, 51)
        Me.GrpTIpo.TabIndex = 2
        Me.GrpTIpo.TabStop = False
        Me.GrpTIpo.Text = "Tipo"
        '
        'rbtnTipoDeVivienda
        '
        Me.rbtnTipoDeVivienda.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.rbtnTipoDeVivienda.ListOfItems = New String() {"Casa Propia", "Renta", "Departamento", "Terreno"}
        Me.rbtnTipoDeVivienda.Location = New System.Drawing.Point(6, 18)
        Me.rbtnTipoDeVivienda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtnTipoDeVivienda.Name = "rbtnTipoDeVivienda"
        Me.rbtnTipoDeVivienda.SelectedValue = ""
        Me.rbtnTipoDeVivienda.Size = New System.Drawing.Size(536, 27)
        Me.rbtnTipoDeVivienda.TabIndex = 0
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1041, 35)
        Me.Panel15.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vivienda"
        '
        'Tab_Enfer
        '
        Me.Tab_Enfer.Controls.Add(Me.panel20)
        Me.Tab_Enfer.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Enfer.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Enfer.Name = "Tab_Enfer"
        Me.Tab_Enfer.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Enfer.Size = New System.Drawing.Size(1070, 598)
        Me.Tab_Enfer.TabIndex = 4
        Me.Tab_Enfer.Text = "ENFERMEDADES"
        Me.Tab_Enfer.UseVisualStyleBackColor = True
        '
        'panel20
        '
        Me.panel20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel20.Controls.Add(Me.Panel8)
        Me.panel20.Controls.Add(Me.txt_enfNAME)
        Me.panel20.Controls.Add(Me.label47)
        Me.panel20.Controls.Add(Me.panel21)
        Me.panel20.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel20.ForeColor = System.Drawing.Color.White
        Me.panel20.Location = New System.Drawing.Point(0, 0)
        Me.panel20.Margin = New System.Windows.Forms.Padding(2)
        Me.panel20.Name = "panel20"
        Me.panel20.Size = New System.Drawing.Size(1070, 591)
        Me.panel20.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dgvEnfermedades)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 197)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1066, 390)
        Me.Panel8.TabIndex = 35
        '
        'dgvEnfermedades
        '
        Me.dgvEnfermedades.AllowUserToAddRows = False
        Me.dgvEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnfermedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnfermedades.Location = New System.Drawing.Point(0, 0)
        Me.dgvEnfermedades.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEnfermedades.Name = "dgvEnfermedades"
        Me.dgvEnfermedades.RowHeadersVisible = False
        Me.dgvEnfermedades.RowTemplate.Height = 24
        Me.dgvEnfermedades.Size = New System.Drawing.Size(1066, 390)
        Me.dgvEnfermedades.TabIndex = 34
        '
        'txt_enfNAME
        '
        Me.txt_enfNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_enfNAME.Location = New System.Drawing.Point(123, 54)
        Me.txt_enfNAME.Name = "txt_enfNAME"
        Me.txt_enfNAME.Size = New System.Drawing.Size(209, 28)
        Me.txt_enfNAME.TabIndex = 28
        '
        'label47
        '
        Me.label47.AutoSize = True
        Me.label47.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label47.ForeColor = System.Drawing.Color.Black
        Me.label47.Location = New System.Drawing.Point(10, 58)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(107, 21)
        Me.label47.TabIndex = 27
        Me.label47.Text = "Enfermedad:"
        '
        'panel21
        '
        Me.panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel21.Controls.Add(Me.btn_enfADD)
        Me.panel21.Controls.Add(Me.label19)
        Me.panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel21.Location = New System.Drawing.Point(0, 0)
        Me.panel21.Margin = New System.Windows.Forms.Padding(2)
        Me.panel21.Name = "panel21"
        Me.panel21.Size = New System.Drawing.Size(1066, 35)
        Me.panel21.TabIndex = 0
        '
        'btn_enfADD
        '
        Me.btn_enfADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_enfADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enfADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_MedicalCondition_80px
        Me.btn_enfADD.Location = New System.Drawing.Point(1020, 0)
        Me.btn_enfADD.Name = "btn_enfADD"
        Me.btn_enfADD.Size = New System.Drawing.Size(35, 35)
        Me.btn_enfADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_enfADD.TabIndex = 46
        Me.btn_enfADD.TabStop = False
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(2, 6)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(119, 21)
        Me.label19.TabIndex = 0
        Me.label19.Text = "Enfermedades"
        '
        'Tab_Cont
        '
        Me.Tab_Cont.Controls.Add(Me.panel18)
        Me.Tab_Cont.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Cont.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Cont.Name = "Tab_Cont"
        Me.Tab_Cont.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Cont.Size = New System.Drawing.Size(1070, 598)
        Me.Tab_Cont.TabIndex = 3
        Me.Tab_Cont.Text = "CONTACTO"
        Me.Tab_Cont.UseVisualStyleBackColor = True
        '
        'panel18
        '
        Me.panel18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel18.Controls.Add(Me.txt_conTEL)
        Me.panel18.Controls.Add(Me.txt_conCEL)
        Me.panel18.Controls.Add(Me.PnlContacto)
        Me.panel18.Controls.Add(Me.label45)
        Me.panel18.Controls.Add(Me.txt_conPAREN)
        Me.panel18.Controls.Add(Me.label41)
        Me.panel18.Controls.Add(Me.label40)
        Me.panel18.Controls.Add(Me.txt_conNAME)
        Me.panel18.Controls.Add(Me.txt_conAM)
        Me.panel18.Controls.Add(Me.txt_conAP)
        Me.panel18.Controls.Add(Me.label42)
        Me.panel18.Controls.Add(Me.label43)
        Me.panel18.Controls.Add(Me.label44)
        Me.panel18.Controls.Add(Me.panel19)
        Me.panel18.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel18.Location = New System.Drawing.Point(0, 0)
        Me.panel18.Margin = New System.Windows.Forms.Padding(2)
        Me.panel18.Name = "panel18"
        Me.panel18.Size = New System.Drawing.Size(1070, 581)
        Me.panel18.TabIndex = 1
        '
        'txt_conTEL
        '
        Me.txt_conTEL.AcceptsDecimals = False
        Me.txt_conTEL.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_conTEL.Location = New System.Drawing.Point(471, 90)
        Me.txt_conTEL.Name = "txt_conTEL"
        Me.txt_conTEL.Size = New System.Drawing.Size(209, 25)
        Me.txt_conTEL.TabIndex = 53
        '
        'txt_conCEL
        '
        Me.txt_conCEL.AcceptsDecimals = False
        Me.txt_conCEL.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_conCEL.Location = New System.Drawing.Point(794, 90)
        Me.txt_conCEL.Name = "txt_conCEL"
        Me.txt_conCEL.Size = New System.Drawing.Size(209, 25)
        Me.txt_conCEL.TabIndex = 52
        '
        'PnlContacto
        '
        Me.PnlContacto.Controls.Add(Me.dgvContactos)
        Me.PnlContacto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlContacto.Location = New System.Drawing.Point(0, 191)
        Me.PnlContacto.Name = "PnlContacto"
        Me.PnlContacto.Size = New System.Drawing.Size(1066, 386)
        Me.PnlContacto.TabIndex = 51
        '
        'dgvContactos
        '
        Me.dgvContactos.AllowUserToAddRows = False
        Me.dgvContactos.AllowUserToDeleteRows = False
        Me.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContactos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnCOEliminar})
        Me.dgvContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContactos.Location = New System.Drawing.Point(0, 0)
        Me.dgvContactos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvContactos.Name = "dgvContactos"
        Me.dgvContactos.ReadOnly = True
        Me.dgvContactos.RowHeadersVisible = False
        Me.dgvContactos.RowTemplate.Height = 24
        Me.dgvContactos.Size = New System.Drawing.Size(1066, 386)
        Me.dgvContactos.TabIndex = 50
        '
        'btnCOEliminar
        '
        Me.btnCOEliminar.FillWeight = 18.13706!
        Me.btnCOEliminar.HeaderText = ""
        Me.btnCOEliminar.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.btnCOEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnCOEliminar.Name = "btnCOEliminar"
        Me.btnCOEliminar.ReadOnly = True
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label45.Location = New System.Drawing.Point(66, 93)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(80, 18)
        Me.label45.TabIndex = 48
        Me.label45.Text = "Parentesco:"
        '
        'txt_conPAREN
        '
        Me.txt_conPAREN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conPAREN.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conPAREN.Location = New System.Drawing.Point(152, 90)
        Me.txt_conPAREN.Name = "txt_conPAREN"
        Me.txt_conPAREN.Size = New System.Drawing.Size(209, 25)
        Me.txt_conPAREN.TabIndex = 47
        '
        'label41
        '
        Me.label41.AutoSize = True
        Me.label41.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label41.Location = New System.Drawing.Point(730, 93)
        Me.label41.Name = "label41"
        Me.label41.Size = New System.Drawing.Size(58, 18)
        Me.label41.TabIndex = 46
        Me.label41.Text = "Celular:"
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label40.Location = New System.Drawing.Point(397, 93)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(68, 18)
        Me.label40.TabIndex = 44
        Me.label40.Text = "Telefono:"
        '
        'txt_conNAME
        '
        Me.txt_conNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conNAME.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conNAME.Location = New System.Drawing.Point(152, 59)
        Me.txt_conNAME.Name = "txt_conNAME"
        Me.txt_conNAME.Size = New System.Drawing.Size(209, 25)
        Me.txt_conNAME.TabIndex = 35
        '
        'txt_conAM
        '
        Me.txt_conAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conAM.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conAM.Location = New System.Drawing.Point(794, 59)
        Me.txt_conAM.Name = "txt_conAM"
        Me.txt_conAM.Size = New System.Drawing.Size(209, 25)
        Me.txt_conAM.TabIndex = 34
        '
        'txt_conAP
        '
        Me.txt_conAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conAP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conAP.Location = New System.Drawing.Point(471, 59)
        Me.txt_conAP.Name = "txt_conAP"
        Me.txt_conAP.Size = New System.Drawing.Size(209, 25)
        Me.txt_conAP.TabIndex = 33
        '
        'label42
        '
        Me.label42.AutoSize = True
        Me.label42.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label42.Location = New System.Drawing.Point(367, 62)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(98, 18)
        Me.label42.TabIndex = 37
        Me.label42.Text = "Apellido Pat.:"
        '
        'label43
        '
        Me.label43.AutoSize = True
        Me.label43.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label43.Location = New System.Drawing.Point(686, 62)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(102, 18)
        Me.label43.TabIndex = 38
        Me.label43.Text = "Apellido Mat.:"
        '
        'label44
        '
        Me.label44.AutoSize = True
        Me.label44.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label44.Location = New System.Drawing.Point(66, 62)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(80, 18)
        Me.label44.TabIndex = 39
        Me.label44.Text = "Nombre(s):"
        '
        'panel19
        '
        Me.panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel19.Controls.Add(Me.btn_conADD)
        Me.panel19.Controls.Add(Me.label18)
        Me.panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel19.Location = New System.Drawing.Point(0, 0)
        Me.panel19.Margin = New System.Windows.Forms.Padding(2)
        Me.panel19.Name = "panel19"
        Me.panel19.Size = New System.Drawing.Size(1066, 35)
        Me.panel19.TabIndex = 0
        '
        'btn_conADD
        '
        Me.btn_conADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_conADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_conADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Contact_80px
        Me.btn_conADD.Location = New System.Drawing.Point(1020, 0)
        Me.btn_conADD.Name = "btn_conADD"
        Me.btn_conADD.Size = New System.Drawing.Size(35, 35)
        Me.btn_conADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_conADD.TabIndex = 55
        Me.btn_conADD.TabStop = False
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(2, 6)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(198, 21)
        Me.label18.TabIndex = 0
        Me.label18.Text = "Contacto de Emergencia"
        '
        'Tab_AL
        '
        Me.Tab_AL.Controls.Add(Me.panel16)
        Me.Tab_AL.Location = New System.Drawing.Point(4, 27)
        Me.Tab_AL.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_AL.Name = "Tab_AL"
        Me.Tab_AL.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_AL.Size = New System.Drawing.Size(1070, 598)
        Me.Tab_AL.TabIndex = 2
        Me.Tab_AL.Text = "ANTECEDENTES LABORALES"
        Me.Tab_AL.UseVisualStyleBackColor = True
        '
        'panel16
        '
        Me.panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel16.Controls.Add(Me.txt_antSALARIO)
        Me.panel16.Controls.Add(Me.pnlAntecedentes)
        Me.panel16.Controls.Add(Me.txt_antMT)
        Me.panel16.Controls.Add(Me.txt_antNAME)
        Me.panel16.Controls.Add(Me.txt_antTEL)
        Me.panel16.Controls.Add(Me.label37)
        Me.panel16.Controls.Add(Me.label38)
        Me.panel16.Controls.Add(Me.label39)
        Me.panel16.Controls.Add(Me.txt_antCARGO)
        Me.panel16.Controls.Add(Me.txt_antEMP)
        Me.panel16.Controls.Add(Me.label34)
        Me.panel16.Controls.Add(Me.label35)
        Me.panel16.Controls.Add(Me.label36)
        Me.panel16.Controls.Add(Me.txt_antFF)
        Me.panel16.Controls.Add(Me.label33)
        Me.panel16.Controls.Add(Me.txt_antFI)
        Me.panel16.Controls.Add(Me.label9)
        Me.panel16.Controls.Add(Me.panel17)
        Me.panel16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel16.Location = New System.Drawing.Point(0, 0)
        Me.panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.panel16.Name = "panel16"
        Me.panel16.Size = New System.Drawing.Size(1070, 548)
        Me.panel16.TabIndex = 1
        '
        'txt_antSALARIO
        '
        Me.txt_antSALARIO.AcceptsDecimals = True
        Me.txt_antSALARIO.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txt_antSALARIO.Location = New System.Drawing.Point(184, 102)
        Me.txt_antSALARIO.Name = "txt_antSALARIO"
        Me.txt_antSALARIO.Size = New System.Drawing.Size(209, 25)
        Me.txt_antSALARIO.TabIndex = 53
        '
        'pnlAntecedentes
        '
        Me.pnlAntecedentes.Controls.Add(Me.dgvAntecedentesLaborales)
        Me.pnlAntecedentes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAntecedentes.Location = New System.Drawing.Point(0, 207)
        Me.pnlAntecedentes.Name = "pnlAntecedentes"
        Me.pnlAntecedentes.Size = New System.Drawing.Size(1066, 337)
        Me.pnlAntecedentes.TabIndex = 52
        '
        'dgvAntecedentesLaborales
        '
        Me.dgvAntecedentesLaborales.AllowUserToAddRows = False
        Me.dgvAntecedentesLaborales.AllowUserToDeleteRows = False
        Me.dgvAntecedentesLaborales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAntecedentesLaborales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAntecedentesLaborales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnAEliminar})
        Me.dgvAntecedentesLaborales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAntecedentesLaborales.Location = New System.Drawing.Point(0, 0)
        Me.dgvAntecedentesLaborales.Name = "dgvAntecedentesLaborales"
        Me.dgvAntecedentesLaborales.ReadOnly = True
        Me.dgvAntecedentesLaborales.RowHeadersVisible = False
        Me.dgvAntecedentesLaborales.Size = New System.Drawing.Size(1066, 337)
        Me.dgvAntecedentesLaborales.TabIndex = 51
        '
        'btnAEliminar
        '
        Me.btnAEliminar.FillWeight = 18.13706!
        Me.btnAEliminar.HeaderText = ""
        Me.btnAEliminar.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.btnAEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnAEliminar.Name = "btnAEliminar"
        Me.btnAEliminar.ReadOnly = True
        '
        'txt_antMT
        '
        Me.txt_antMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antMT.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antMT.Location = New System.Drawing.Point(515, 102)
        Me.txt_antMT.Multiline = True
        Me.txt_antMT.Name = "txt_antMT"
        Me.txt_antMT.Size = New System.Drawing.Size(498, 47)
        Me.txt_antMT.TabIndex = 29
        '
        'txt_antNAME
        '
        Me.txt_antNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antNAME.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antNAME.Location = New System.Drawing.Point(515, 71)
        Me.txt_antNAME.Name = "txt_antNAME"
        Me.txt_antNAME.Size = New System.Drawing.Size(209, 25)
        Me.txt_antNAME.TabIndex = 28
        '
        'txt_antTEL
        '
        Me.txt_antTEL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antTEL.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antTEL.Location = New System.Drawing.Point(184, 71)
        Me.txt_antTEL.Name = "txt_antTEL"
        Me.txt_antTEL.Size = New System.Drawing.Size(209, 25)
        Me.txt_antTEL.TabIndex = 27
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label37.Location = New System.Drawing.Point(103, 74)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(68, 18)
        Me.label37.TabIndex = 30
        Me.label37.Text = "Telefono:"
        '
        'label38
        '
        Me.label38.AutoSize = True
        Me.label38.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label38.Location = New System.Drawing.Point(442, 74)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(67, 18)
        Me.label38.TabIndex = 31
        Me.label38.Text = "Contacto:"
        '
        'label39
        '
        Me.label39.AutoSize = True
        Me.label39.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label39.Location = New System.Drawing.Point(452, 102)
        Me.label39.Name = "label39"
        Me.label39.Size = New System.Drawing.Size(57, 18)
        Me.label39.TabIndex = 32
        Me.label39.Text = "Motivo:"
        '
        'txt_antCARGO
        '
        Me.txt_antCARGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antCARGO.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antCARGO.Location = New System.Drawing.Point(804, 71)
        Me.txt_antCARGO.Name = "txt_antCARGO"
        Me.txt_antCARGO.Size = New System.Drawing.Size(209, 25)
        Me.txt_antCARGO.TabIndex = 22
        '
        'txt_antEMP
        '
        Me.txt_antEMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antEMP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antEMP.Location = New System.Drawing.Point(804, 40)
        Me.txt_antEMP.Name = "txt_antEMP"
        Me.txt_antEMP.Size = New System.Drawing.Size(209, 25)
        Me.txt_antEMP.TabIndex = 21
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label34.Location = New System.Drawing.Point(730, 43)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(68, 18)
        Me.label34.TabIndex = 24
        Me.label34.Text = "Empresa:"
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label35.Location = New System.Drawing.Point(750, 74)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(48, 18)
        Me.label35.TabIndex = 25
        Me.label35.Text = "Cargo:"
        '
        'label36
        '
        Me.label36.AutoSize = True
        Me.label36.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label36.Location = New System.Drawing.Point(114, 105)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(57, 18)
        Me.label36.TabIndex = 26
        Me.label36.Text = "Salario:"
        '
        'txt_antFF
        '
        Me.txt_antFF.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_antFF.Location = New System.Drawing.Point(515, 40)
        Me.txt_antFF.Name = "txt_antFF"
        Me.txt_antFF.Size = New System.Drawing.Size(209, 25)
        Me.txt_antFF.TabIndex = 19
        '
        'label33
        '
        Me.label33.AutoSize = True
        Me.label33.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label33.Location = New System.Drawing.Point(399, 43)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(110, 18)
        Me.label33.TabIndex = 20
        Me.label33.Text = "Fecha de Final:"
        '
        'txt_antFI
        '
        Me.txt_antFI.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antFI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_antFI.Location = New System.Drawing.Point(184, 40)
        Me.txt_antFI.Name = "txt_antFI"
        Me.txt_antFI.Size = New System.Drawing.Size(209, 25)
        Me.txt_antFI.TabIndex = 17
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(65, 43)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(113, 18)
        Me.label9.TabIndex = 18
        Me.label9.Text = "Fecha de Inicio:"
        '
        'panel17
        '
        Me.panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel17.Controls.Add(Me.btn_antSave)
        Me.panel17.Controls.Add(Me.label17)
        Me.panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel17.Location = New System.Drawing.Point(0, 0)
        Me.panel17.Margin = New System.Windows.Forms.Padding(2)
        Me.panel17.Name = "panel17"
        Me.panel17.Size = New System.Drawing.Size(1066, 35)
        Me.panel17.TabIndex = 0
        '
        'btn_antSave
        '
        Me.btn_antSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_antSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_antSave.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Job_80px
        Me.btn_antSave.Location = New System.Drawing.Point(1020, 0)
        Me.btn_antSave.Name = "btn_antSave"
        Me.btn_antSave.Size = New System.Drawing.Size(35, 35)
        Me.btn_antSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_antSave.TabIndex = 54
        Me.btn_antSave.TabStop = False
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(2, 6)
        Me.label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(147, 21)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Datos por Empleo"
        '
        'Tab_Familia
        '
        Me.Tab_Familia.Controls.Add(Me.panel3)
        Me.Tab_Familia.Controls.Add(Me.panel2)
        Me.Tab_Familia.Location = New System.Drawing.Point(4, 27)
        Me.Tab_Familia.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Familia.Name = "Tab_Familia"
        Me.Tab_Familia.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Familia.Size = New System.Drawing.Size(1070, 598)
        Me.Tab_Familia.TabIndex = 1
        Me.Tab_Familia.Text = "FAMILIA"
        Me.Tab_Familia.UseVisualStyleBackColor = True
        '
        'panel3
        '
        Me.panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel3.Controls.Add(Me.PnlOffsprings)
        Me.panel3.Controls.Add(Me.label26)
        Me.panel3.Controls.Add(Me.txt_hijoNACION)
        Me.panel3.Controls.Add(Me.txt_hijoFN)
        Me.panel3.Controls.Add(Me.label27)
        Me.panel3.Controls.Add(Me.txt_hijoNAME)
        Me.panel3.Controls.Add(Me.txt_hijoAM)
        Me.panel3.Controls.Add(Me.txt_hijoAP)
        Me.panel3.Controls.Add(Me.label28)
        Me.panel3.Controls.Add(Me.label29)
        Me.panel3.Controls.Add(Me.cbHijosSexo)
        Me.panel3.Controls.Add(Me.label30)
        Me.panel3.Controls.Add(Me.label31)
        Me.panel3.Controls.Add(Me.panel5)
        Me.panel3.Location = New System.Drawing.Point(2, 280)
        Me.panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1070, 287)
        Me.panel3.TabIndex = 1
        '
        'PnlOffsprings
        '
        Me.PnlOffsprings.Controls.Add(Me.dgvHijos)
        Me.PnlOffsprings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlOffsprings.Location = New System.Drawing.Point(0, 101)
        Me.PnlOffsprings.Name = "PnlOffsprings"
        Me.PnlOffsprings.Size = New System.Drawing.Size(1066, 182)
        Me.PnlOffsprings.TabIndex = 53
        '
        'dgvHijos
        '
        Me.dgvHijos.AllowUserToAddRows = False
        Me.dgvHijos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHijos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnHEliminar})
        Me.dgvHijos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHijos.Location = New System.Drawing.Point(0, 0)
        Me.dgvHijos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvHijos.Name = "dgvHijos"
        Me.dgvHijos.RowHeadersVisible = False
        Me.dgvHijos.RowTemplate.Height = 24
        Me.dgvHijos.Size = New System.Drawing.Size(1066, 182)
        Me.dgvHijos.TabIndex = 52
        '
        'btnHEliminar
        '
        Me.btnHEliminar.FillWeight = 18.13706!
        Me.btnHEliminar.HeaderText = ""
        Me.btnHEliminar.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.btnHEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnHEliminar.Name = "btnHEliminar"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label26.Location = New System.Drawing.Point(706, 74)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(97, 18)
        Me.label26.TabIndex = 44
        Me.label26.Text = "Nacionalidad:"
        '
        'txt_hijoNACION
        '
        Me.txt_hijoNACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoNACION.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hijoNACION.Location = New System.Drawing.Point(809, 71)
        Me.txt_hijoNACION.Name = "txt_hijoNACION"
        Me.txt_hijoNACION.Size = New System.Drawing.Size(192, 25)
        Me.txt_hijoNACION.TabIndex = 43
        '
        'txt_hijoFN
        '
        Me.txt_hijoFN.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hijoFN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_hijoFN.Location = New System.Drawing.Point(493, 71)
        Me.txt_hijoFN.Name = "txt_hijoFN"
        Me.txt_hijoFN.Size = New System.Drawing.Size(200, 25)
        Me.txt_hijoFN.TabIndex = 41
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label27.Location = New System.Drawing.Point(384, 74)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(102, 18)
        Me.label27.TabIndex = 42
        Me.label27.Text = "Fecha de Nac.:"
        '
        'txt_hijoNAME
        '
        Me.txt_hijoNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoNAME.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hijoNAME.Location = New System.Drawing.Point(176, 40)
        Me.txt_hijoNAME.Name = "txt_hijoNAME"
        Me.txt_hijoNAME.Size = New System.Drawing.Size(200, 25)
        Me.txt_hijoNAME.TabIndex = 35
        '
        'txt_hijoAM
        '
        Me.txt_hijoAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoAM.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hijoAM.Location = New System.Drawing.Point(809, 40)
        Me.txt_hijoAM.Name = "txt_hijoAM"
        Me.txt_hijoAM.Size = New System.Drawing.Size(192, 25)
        Me.txt_hijoAM.TabIndex = 34
        '
        'txt_hijoAP
        '
        Me.txt_hijoAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoAP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hijoAP.Location = New System.Drawing.Point(492, 40)
        Me.txt_hijoAP.Name = "txt_hijoAP"
        Me.txt_hijoAP.Size = New System.Drawing.Size(201, 25)
        Me.txt_hijoAP.TabIndex = 33
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.Location = New System.Drawing.Point(388, 43)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(98, 18)
        Me.label28.TabIndex = 37
        Me.label28.Text = "Apellido Pat.:"
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.Location = New System.Drawing.Point(701, 43)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(102, 18)
        Me.label29.TabIndex = 38
        Me.label29.Text = "Apellido Mat.:"
        '
        'cbHijosSexo
        '
        Me.cbHijosSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHijosSexo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHijosSexo.FormattingEnabled = True
        Me.cbHijosSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cbHijosSexo.Location = New System.Drawing.Point(176, 70)
        Me.cbHijosSexo.Name = "cbHijosSexo"
        Me.cbHijosSexo.Size = New System.Drawing.Size(200, 26)
        Me.cbHijosSexo.TabIndex = 36
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label30.Location = New System.Drawing.Point(90, 43)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(80, 18)
        Me.label30.TabIndex = 39
        Me.label30.Text = "Nombre(s):"
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label31.Location = New System.Drawing.Point(129, 74)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(41, 18)
        Me.label31.TabIndex = 40
        Me.label31.Text = "Sexo:"
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel5.Controls.Add(Me.btn_hijoADD)
        Me.panel5.Controls.Add(Me.label11)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel5.Location = New System.Drawing.Point(0, 0)
        Me.panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(1066, 35)
        Me.panel5.TabIndex = 1
        '
        'btn_hijoADD
        '
        Me.btn_hijoADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hijoADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_hijoADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Family_80px
        Me.btn_hijoADD.Location = New System.Drawing.Point(1020, 0)
        Me.btn_hijoADD.Name = "btn_hijoADD"
        Me.btn_hijoADD.Size = New System.Drawing.Size(35, 35)
        Me.btn_hijoADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_hijoADD.TabIndex = 53
        Me.btn_hijoADD.TabStop = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(2, 6)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(47, 21)
        Me.label11.TabIndex = 2
        Me.label11.Text = "Hijos"
        '
        'panel2
        '
        Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.panel4)
        Me.panel2.Controls.Add(Me.label25)
        Me.panel2.Controls.Add(Me.txt_esNacion)
        Me.panel2.Controls.Add(Me.dgvEsposa)
        Me.panel2.Controls.Add(Me.txt_esName)
        Me.panel2.Controls.Add(Me.txt_esAM)
        Me.panel2.Controls.Add(Me.txt_esFN)
        Me.panel2.Controls.Add(Me.txt_esAP)
        Me.panel2.Controls.Add(Me.label24)
        Me.panel2.Controls.Add(Me.label23)
        Me.panel2.Controls.Add(Me.label20)
        Me.panel2.Controls.Add(Me.label21)
        Me.panel2.Controls.Add(Me.cbConyugeSexo)
        Me.panel2.Controls.Add(Me.label22)
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1070, 278)
        Me.panel2.TabIndex = 1
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel4.Controls.Add(Me.label10)
        Me.panel4.Controls.Add(Me.btn_esSAVE)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel4.Location = New System.Drawing.Point(0, 0)
        Me.panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(1066, 35)
        Me.panel4.TabIndex = 1
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(2, 6)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(78, 21)
        Me.label10.TabIndex = 1
        Me.label10.Text = "Cónyuge"
        '
        'btn_esSAVE
        '
        Me.btn_esSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_esSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_esSAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_marriage_80px
        Me.btn_esSAVE.Location = New System.Drawing.Point(1020, 0)
        Me.btn_esSAVE.Name = "btn_esSAVE"
        Me.btn_esSAVE.Size = New System.Drawing.Size(35, 35)
        Me.btn_esSAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_esSAVE.TabIndex = 52
        Me.btn_esSAVE.TabStop = False
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label25.Location = New System.Drawing.Point(708, 74)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(97, 18)
        Me.label25.TabIndex = 32
        Me.label25.Text = "Nacionalidad:"
        '
        'txt_esNacion
        '
        Me.txt_esNacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esNacion.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_esNacion.Location = New System.Drawing.Point(811, 71)
        Me.txt_esNacion.Name = "txt_esNacion"
        Me.txt_esNacion.Size = New System.Drawing.Size(192, 25)
        Me.txt_esNacion.TabIndex = 31
        '
        'dgvEsposa
        '
        Me.dgvEsposa.AllowUserToAddRows = False
        Me.dgvEsposa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEsposa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEsposa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnCEliminar})
        Me.dgvEsposa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvEsposa.Location = New System.Drawing.Point(0, 129)
        Me.dgvEsposa.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEsposa.Name = "dgvEsposa"
        Me.dgvEsposa.RowHeadersVisible = False
        Me.dgvEsposa.RowTemplate.Height = 24
        Me.dgvEsposa.Size = New System.Drawing.Size(1066, 145)
        Me.dgvEsposa.TabIndex = 51
        '
        'btnCEliminar
        '
        Me.btnCEliminar.FillWeight = 11.02631!
        Me.btnCEliminar.HeaderText = ""
        Me.btnCEliminar.Image = Global.AdminEmpleados.My.Resources.Resources.Trash_Can_80px
        Me.btnCEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnCEliminar.Name = "btnCEliminar"
        '
        'txt_esName
        '
        Me.txt_esName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esName.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_esName.Location = New System.Drawing.Point(178, 40)
        Me.txt_esName.Name = "txt_esName"
        Me.txt_esName.Size = New System.Drawing.Size(200, 25)
        Me.txt_esName.TabIndex = 18
        '
        'txt_esAM
        '
        Me.txt_esAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esAM.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_esAM.Location = New System.Drawing.Point(811, 40)
        Me.txt_esAM.Name = "txt_esAM"
        Me.txt_esAM.Size = New System.Drawing.Size(192, 25)
        Me.txt_esAM.TabIndex = 17
        '
        'txt_esFN
        '
        Me.txt_esFN.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_esFN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_esFN.Location = New System.Drawing.Point(495, 71)
        Me.txt_esFN.Name = "txt_esFN"
        Me.txt_esFN.Size = New System.Drawing.Size(200, 25)
        Me.txt_esFN.TabIndex = 24
        '
        'txt_esAP
        '
        Me.txt_esAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esAP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_esAP.Location = New System.Drawing.Point(494, 40)
        Me.txt_esAP.Name = "txt_esAP"
        Me.txt_esAP.Size = New System.Drawing.Size(200, 25)
        Me.txt_esAP.TabIndex = 16
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label24.Location = New System.Drawing.Point(386, 74)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(102, 18)
        Me.label24.TabIndex = 25
        Me.label24.Text = "Fecha de Nac.:"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label23.Location = New System.Drawing.Point(131, 74)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(41, 18)
        Me.label23.TabIndex = 23
        Me.label23.Text = "Sexo:"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.Location = New System.Drawing.Point(390, 43)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(98, 18)
        Me.label20.TabIndex = 20
        Me.label20.Text = "Apellido Pat.:"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.Location = New System.Drawing.Point(703, 43)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(102, 18)
        Me.label21.TabIndex = 21
        Me.label21.Text = "Apellido Mat.:"
        '
        'cbConyugeSexo
        '
        Me.cbConyugeSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConyugeSexo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConyugeSexo.FormattingEnabled = True
        Me.cbConyugeSexo.Location = New System.Drawing.Point(178, 70)
        Me.cbConyugeSexo.Name = "cbConyugeSexo"
        Me.cbConyugeSexo.Size = New System.Drawing.Size(200, 26)
        Me.cbConyugeSexo.TabIndex = 19
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.Location = New System.Drawing.Point(92, 43)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(80, 18)
        Me.label22.TabIndex = 22
        Me.label22.Text = "Nombre(s):"
        '
        'Tab_DP
        '
        Me.Tab_DP.Controls.Add(Me.pnl_estatus)
        Me.Tab_DP.Controls.Add(Me.pnl_cont)
        Me.Tab_DP.Controls.Add(Me.pnl_per)
        Me.Tab_DP.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_DP.Location = New System.Drawing.Point(4, 27)
        Me.Tab_DP.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_DP.Name = "Tab_DP"
        Me.Tab_DP.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_DP.Size = New System.Drawing.Size(1070, 598)
        Me.Tab_DP.TabIndex = 0
        Me.Tab_DP.Text = "DATOS PERSONALES"
        Me.Tab_DP.UseVisualStyleBackColor = True
        '
        'pnl_estatus
        '
        Me.pnl_estatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_estatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estatus.Controls.Add(Me.GroupBox1)
        Me.pnl_estatus.Controls.Add(Me.panel13)
        Me.pnl_estatus.Controls.Add(Me.commen)
        Me.pnl_estatus.Controls.Add(Me.txt_activo)
        Me.pnl_estatus.Controls.Add(Me.label8)
        Me.pnl_estatus.Controls.Add(Me.txt_baja)
        Me.pnl_estatus.Controls.Add(Me.Label6)
        Me.pnl_estatus.Controls.Add(Me.Label7)
        Me.pnl_estatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_estatus.Location = New System.Drawing.Point(2, 497)
        Me.pnl_estatus.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_estatus.Name = "pnl_estatus"
        Me.pnl_estatus.Size = New System.Drawing.Size(1068, 97)
        Me.pnl_estatus.TabIndex = 34
        Me.pnl_estatus.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_CLIENTE)
        Me.GroupBox1.Controls.Add(Me.seg)
        Me.GroupBox1.Controls.Add(Me.CB_PROV)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(627, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 50)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notificar a :"
        '
        'CB_CLIENTE
        '
        Me.CB_CLIENTE.AutoSize = True
        Me.CB_CLIENTE.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CLIENTE.Location = New System.Drawing.Point(5, 18)
        Me.CB_CLIENTE.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_CLIENTE.Name = "CB_CLIENTE"
        Me.CB_CLIENTE.Size = New System.Drawing.Size(78, 22)
        Me.CB_CLIENTE.TabIndex = 4
        Me.CB_CLIENTE.Text = "Clientes"
        Me.CB_CLIENTE.UseVisualStyleBackColor = True
        '
        'seg
        '
        Me.seg.AutoSize = True
        Me.seg.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seg.Location = New System.Drawing.Point(197, 18)
        Me.seg.Margin = New System.Windows.Forms.Padding(2)
        Me.seg.Name = "seg"
        Me.seg.Size = New System.Drawing.Size(90, 22)
        Me.seg.TabIndex = 5
        Me.seg.Text = "Seguridad"
        Me.seg.UseVisualStyleBackColor = True
        '
        'CB_PROV
        '
        Me.CB_PROV.AutoSize = True
        Me.CB_PROV.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PROV.Location = New System.Drawing.Point(91, 18)
        Me.CB_PROV.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_PROV.Name = "CB_PROV"
        Me.CB_PROV.Size = New System.Drawing.Size(102, 22)
        Me.CB_PROV.TabIndex = 8
        Me.CB_PROV.Text = "Proveedores"
        Me.CB_PROV.UseVisualStyleBackColor = True
        '
        'panel13
        '
        Me.panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel13.Controls.Add(Me.label15)
        Me.panel13.Controls.Add(Me.PbOptions)
        Me.panel13.Controls.Add(Me.lbl_option)
        Me.panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel13.Location = New System.Drawing.Point(0, 0)
        Me.panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.panel13.Name = "panel13"
        Me.panel13.Size = New System.Drawing.Size(1064, 35)
        Me.panel13.TabIndex = 0
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(2, 6)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 21)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Estatus"
        '
        'PbOptions
        '
        Me.PbOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.PbOptions.Image = Global.AdminEmpleados.My.Resources.Resources.Alta_80px
        Me.PbOptions.Location = New System.Drawing.Point(980, 0)
        Me.PbOptions.Name = "PbOptions"
        Me.PbOptions.Size = New System.Drawing.Size(35, 35)
        Me.PbOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbOptions.TabIndex = 41
        Me.PbOptions.TabStop = False
        Me.PbOptions.Visible = False
        '
        'lbl_option
        '
        Me.lbl_option.AutoSize = True
        Me.lbl_option.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_option.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_option.ForeColor = System.Drawing.Color.White
        Me.lbl_option.Location = New System.Drawing.Point(1015, 0)
        Me.lbl_option.Name = "lbl_option"
        Me.lbl_option.Size = New System.Drawing.Size(49, 21)
        Me.lbl_option.TabIndex = 45
        Me.lbl_option.Tag = ""
        Me.lbl_option.Text = "ALTA"
        Me.lbl_option.Visible = False
        '
        'commen
        '
        Me.commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.commen.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commen.Location = New System.Drawing.Point(116, 70)
        Me.commen.Multiline = True
        Me.commen.Name = "commen"
        Me.commen.Size = New System.Drawing.Size(505, 20)
        Me.commen.TabIndex = 7
        '
        'txt_activo
        '
        Me.txt_activo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_activo.Enabled = False
        Me.txt_activo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_activo.Location = New System.Drawing.Point(116, 39)
        Me.txt_activo.Name = "txt_activo"
        Me.txt_activo.Size = New System.Drawing.Size(213, 25)
        Me.txt_activo.TabIndex = 1
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(46, 71)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(62, 18)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Motivo: "
        '
        'txt_baja
        '
        Me.txt_baja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_baja.Enabled = False
        Me.txt_baja.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_baja.Location = New System.Drawing.Point(457, 39)
        Me.txt_baja.Name = "txt_baja"
        Me.txt_baja.Size = New System.Drawing.Size(164, 25)
        Me.txt_baja.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Activo: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(342, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha de Baja: "
        '
        'pnl_cont
        '
        Me.pnl_cont.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_cont.Controls.Add(Me.txtSalario)
        Me.pnl_cont.Controls.Add(Me.buscar_depto)
        Me.pnl_cont.Controls.Add(Me.txtDeptoCodigo)
        Me.pnl_cont.Controls.Add(Me.txtDepto)
        Me.pnl_cont.Controls.Add(Me.Buscar_PUESTO)
        Me.pnl_cont.Controls.Add(Me.panel11)
        Me.pnl_cont.Controls.Add(Me.Buscar_tipo)
        Me.pnl_cont.Controls.Add(Me.lbl_ingreso)
        Me.pnl_cont.Controls.Add(Me.txtCorreo)
        Me.pnl_cont.Controls.Add(Me.lbl_clase)
        Me.pnl_cont.Controls.Add(Me.txtTipo)
        Me.pnl_cont.Controls.Add(Me.lbl_super)
        Me.pnl_cont.Controls.Add(Me.correo)
        Me.pnl_cont.Controls.Add(Me.lbl_puesto)
        Me.pnl_cont.Controls.Add(Me.txtTipoCodigo)
        Me.pnl_cont.Controls.Add(Me.lbl_sali)
        Me.pnl_cont.Controls.Add(Me.dtpFechaDeIngreso)
        Me.pnl_cont.Controls.Add(Me.Buscar_Super)
        Me.pnl_cont.Controls.Add(Me.txtPuestoCodigo)
        Me.pnl_cont.Controls.Add(Me.txtPuesto)
        Me.pnl_cont.Controls.Add(Me.txtSupervisor)
        Me.pnl_cont.Controls.Add(Me.txtSupervisorCodigo)
        Me.pnl_cont.Controls.Add(Me.lbl_depto)
        Me.pnl_cont.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_cont.Location = New System.Drawing.Point(2, 359)
        Me.pnl_cont.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_cont.Name = "pnl_cont"
        Me.pnl_cont.Size = New System.Drawing.Size(1068, 134)
        Me.pnl_cont.TabIndex = 1
        '
        'txtSalario
        '
        Me.txtSalario.AcceptsDecimals = True
        Me.txtSalario.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtSalario.Location = New System.Drawing.Point(788, 71)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(238, 25)
        Me.txtSalario.TabIndex = 61
        '
        'buscar_depto
        '
        Me.buscar_depto.BackgroundImage = CType(resources.GetObject("buscar_depto.BackgroundImage"), System.Drawing.Image)
        Me.buscar_depto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscar_depto.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_depto.Location = New System.Drawing.Point(1001, 40)
        Me.buscar_depto.Name = "buscar_depto"
        Me.buscar_depto.Size = New System.Drawing.Size(25, 25)
        Me.buscar_depto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_depto.TabIndex = 60
        Me.buscar_depto.TabStop = False
        '
        'txtDeptoCodigo
        '
        Me.txtDeptoCodigo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeptoCodigo.Location = New System.Drawing.Point(782, 40)
        Me.txtDeptoCodigo.Name = "txtDeptoCodigo"
        Me.txtDeptoCodigo.Size = New System.Drawing.Size(1, 25)
        Me.txtDeptoCodigo.TabIndex = 7
        '
        'txtDepto
        '
        Me.txtDepto.Enabled = False
        Me.txtDepto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepto.Location = New System.Drawing.Point(788, 40)
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.Size = New System.Drawing.Size(213, 25)
        Me.txtDepto.TabIndex = 3
        Me.txtDepto.TabStop = False
        '
        'Buscar_PUESTO
        '
        Me.Buscar_PUESTO.BackgroundImage = CType(resources.GetObject("Buscar_PUESTO.BackgroundImage"), System.Drawing.Image)
        Me.Buscar_PUESTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar_PUESTO.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_PUESTO.Location = New System.Drawing.Point(670, 40)
        Me.Buscar_PUESTO.Name = "Buscar_PUESTO"
        Me.Buscar_PUESTO.Size = New System.Drawing.Size(25, 25)
        Me.Buscar_PUESTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_PUESTO.TabIndex = 57
        Me.Buscar_PUESTO.TabStop = False
        '
        'panel11
        '
        Me.panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel11.Controls.Add(Me.label14)
        Me.panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel11.Location = New System.Drawing.Point(0, 0)
        Me.panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(1064, 35)
        Me.panel11.TabIndex = 0
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(2, 6)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(109, 21)
        Me.label14.TabIndex = 0
        Me.label14.Text = "Contratacion"
        '
        'Buscar_tipo
        '
        Me.Buscar_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar_tipo.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_tipo.Location = New System.Drawing.Point(670, 71)
        Me.Buscar_tipo.Name = "Buscar_tipo"
        Me.Buscar_tipo.Size = New System.Drawing.Size(25, 25)
        Me.Buscar_tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_tipo.TabIndex = 54
        Me.Buscar_tipo.TabStop = False
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingreso.Location = New System.Drawing.Point(62, 43)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(60, 18)
        Me.lbl_ingreso.TabIndex = 0
        Me.lbl_ingreso.Text = "Ingreso:"
        '
        'txtCorreo
        '
        Me.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(127, 102)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(238, 25)
        Me.txtCorreo.TabIndex = 15
        '
        'lbl_clase
        '
        Me.lbl_clase.AutoSize = True
        Me.lbl_clase.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clase.Location = New System.Drawing.Point(409, 74)
        Me.lbl_clase.Name = "lbl_clase"
        Me.lbl_clase.Size = New System.Drawing.Size(42, 18)
        Me.lbl_clase.TabIndex = 10
        Me.lbl_clase.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(457, 71)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(213, 25)
        Me.txtTipo.TabIndex = 11
        Me.txtTipo.TabStop = False
        '
        'lbl_super
        '
        Me.lbl_super.AutoSize = True
        Me.lbl_super.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_super.Location = New System.Drawing.Point(62, 74)
        Me.lbl_super.Name = "lbl_super"
        Me.lbl_super.Size = New System.Drawing.Size(59, 18)
        Me.lbl_super.TabIndex = 8
        Me.lbl_super.Text = "Superv.:"
        '
        'correo
        '
        Me.correo.AutoSize = True
        Me.correo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correo.Location = New System.Drawing.Point(62, 105)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(57, 18)
        Me.correo.TabIndex = 14
        Me.correo.Text = "E-mail:"
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_puesto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_puesto.Location = New System.Drawing.Point(397, 43)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(54, 18)
        Me.lbl_puesto.TabIndex = 2
        Me.lbl_puesto.Text = "Puesto:"
        '
        'txtTipoCodigo
        '
        Me.txtTipoCodigo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCodigo.Location = New System.Drawing.Point(452, 71)
        Me.txtTipoCodigo.Name = "txtTipoCodigo"
        Me.txtTipoCodigo.Size = New System.Drawing.Size(1, 25)
        Me.txtTipoCodigo.TabIndex = 25
        '
        'lbl_sali
        '
        Me.lbl_sali.AutoSize = True
        Me.lbl_sali.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sali.Location = New System.Drawing.Point(727, 74)
        Me.lbl_sali.Name = "lbl_sali"
        Me.lbl_sali.Size = New System.Drawing.Size(57, 18)
        Me.lbl_sali.TabIndex = 12
        Me.lbl_sali.Text = "Salario:"
        '
        'dtpFechaDeIngreso
        '
        Me.dtpFechaDeIngreso.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeIngreso.Location = New System.Drawing.Point(127, 40)
        Me.dtpFechaDeIngreso.Name = "dtpFechaDeIngreso"
        Me.dtpFechaDeIngreso.Size = New System.Drawing.Size(238, 25)
        Me.dtpFechaDeIngreso.TabIndex = 1
        '
        'Buscar_Super
        '
        Me.Buscar_Super.BackgroundImage = CType(resources.GetObject("Buscar_Super.BackgroundImage"), System.Drawing.Image)
        Me.Buscar_Super.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar_Super.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_Super.Location = New System.Drawing.Point(340, 71)
        Me.Buscar_Super.Name = "Buscar_Super"
        Me.Buscar_Super.Size = New System.Drawing.Size(25, 25)
        Me.Buscar_Super.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_Super.TabIndex = 51
        Me.Buscar_Super.TabStop = False
        '
        'txtPuestoCodigo
        '
        Me.txtPuestoCodigo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuestoCodigo.Location = New System.Drawing.Point(447, 40)
        Me.txtPuestoCodigo.Name = "txtPuestoCodigo"
        Me.txtPuestoCodigo.Size = New System.Drawing.Size(1, 25)
        Me.txtPuestoCodigo.TabIndex = 4
        '
        'txtPuesto
        '
        Me.txtPuesto.Enabled = False
        Me.txtPuesto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuesto.Location = New System.Drawing.Point(457, 40)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(213, 25)
        Me.txtPuesto.TabIndex = 5
        Me.txtPuesto.TabStop = False
        '
        'txtSupervisor
        '
        Me.txtSupervisor.Enabled = False
        Me.txtSupervisor.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisor.Location = New System.Drawing.Point(127, 71)
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.Size = New System.Drawing.Size(213, 25)
        Me.txtSupervisor.TabIndex = 9
        Me.txtSupervisor.TabStop = False
        '
        'txtSupervisorCodigo
        '
        Me.txtSupervisorCodigo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervisorCodigo.Location = New System.Drawing.Point(121, 73)
        Me.txtSupervisorCodigo.Name = "txtSupervisorCodigo"
        Me.txtSupervisorCodigo.Size = New System.Drawing.Size(1, 25)
        Me.txtSupervisorCodigo.TabIndex = 24
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_depto.Location = New System.Drawing.Point(732, 43)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(50, 18)
        Me.lbl_depto.TabIndex = 6
        Me.lbl_depto.Text = "Depto:"
        '
        'pnl_per
        '
        Me.pnl_per.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_per.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_per.Controls.Add(Me.Buscar_nac)
        Me.pnl_per.Controls.Add(Me.txtTelefono)
        Me.pnl_per.Controls.Add(Me.txtCodigoPostal)
        Me.pnl_per.Controls.Add(Me.txtNSS)
        Me.pnl_per.Controls.Add(Me.txtCelular)
        Me.pnl_per.Controls.Add(Me.txtCdDomicilio)
        Me.pnl_per.Controls.Add(Me.Label13)
        Me.pnl_per.Controls.Add(Me.PbSearchEmployee)
        Me.pnl_per.Controls.Add(Me.buscar_ciudad)
        Me.pnl_per.Controls.Add(Me.pbFotoEmpleado)
        Me.pnl_per.Controls.Add(Me.txtCiudadCodigo)
        Me.pnl_per.Controls.Add(Me.lbl_rfc)
        Me.pnl_per.Controls.Add(Me.lbl_ss)
        Me.pnl_per.Controls.Add(Me.LBL_CP)
        Me.pnl_per.Controls.Add(Me.txtCURP)
        Me.pnl_per.Controls.Add(Me.txtCiudad)
        Me.pnl_per.Controls.Add(Me.cbEstadoCivil)
        Me.pnl_per.Controls.Add(Me.Label92)
        Me.pnl_per.Controls.Add(Me.cbNivelEducativo)
        Me.pnl_per.Controls.Add(Me.Label54)
        Me.pnl_per.Controls.Add(Me.lbl_curp)
        Me.pnl_per.Controls.Add(Me.Label1)
        Me.pnl_per.Controls.Add(Me.txtColonia)
        Me.pnl_per.Controls.Add(Me.Label55)
        Me.pnl_per.Controls.Add(Me.txtDomicilio)
        Me.pnl_per.Controls.Add(Me.Label2)
        Me.pnl_per.Controls.Add(Me.txtRFC)
        Me.pnl_per.Controls.Add(Me.Label4)
        Me.pnl_per.Controls.Add(Me.lbl_sex)
        Me.pnl_per.Controls.Add(Me.LBL_ESTADOCIVIL)
        Me.pnl_per.Controls.Add(Me.lbl_fn)
        Me.pnl_per.Controls.Add(Me.txtNacionalidad)
        Me.pnl_per.Controls.Add(Me.Label3)
        Me.pnl_per.Controls.Add(Me.dtpFechaDeNacimiento)
        Me.pnl_per.Controls.Add(Me.cbSexo)
        Me.pnl_per.Controls.Add(Me.lbl_nac)
        Me.pnl_per.Controls.Add(Me.panel7)
        Me.pnl_per.Controls.Add(Me.txtEntidad)
        Me.pnl_per.Controls.Add(Me.txtNumero)
        Me.pnl_per.Controls.Add(Me.txtEntidadCodigo)
        Me.pnl_per.Controls.Add(Me.txtNombres)
        Me.pnl_per.Controls.Add(Me.txtAMaterno)
        Me.pnl_per.Controls.Add(Me.txtAPaterno)
        Me.pnl_per.Controls.Add(Me.buscar_EN)
        Me.pnl_per.Controls.Add(Me.lbl_num)
        Me.pnl_per.Controls.Add(Me.lbl_ap)
        Me.pnl_per.Controls.Add(Me.lbl_am)
        Me.pnl_per.Controls.Add(Me.lbl_nom)
        Me.pnl_per.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_per.Location = New System.Drawing.Point(0, 0)
        Me.pnl_per.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_per.Name = "pnl_per"
        Me.pnl_per.Size = New System.Drawing.Size(1070, 485)
        Me.pnl_per.TabIndex = 1
        '
        'Buscar_nac
        '
        Me.Buscar_nac.BackgroundImage = CType(resources.GetObject("Buscar_nac.BackgroundImage"), System.Drawing.Image)
        Me.Buscar_nac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar_nac.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_nac.Location = New System.Drawing.Point(1006, 102)
        Me.Buscar_nac.Name = "Buscar_nac"
        Me.Buscar_nac.Size = New System.Drawing.Size(25, 25)
        Me.Buscar_nac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_nac.TabIndex = 67
        Me.Buscar_nac.TabStop = False
        '
        'txtTelefono
        '
        Me.txtTelefono.AcceptsDecimals = False
        Me.txtTelefono.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(378, 289)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(238, 25)
        Me.txtTelefono.TabIndex = 66
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.AcceptsDecimals = False
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtCodigoPostal.Location = New System.Drawing.Point(793, 258)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(238, 25)
        Me.txtCodigoPostal.TabIndex = 65
        '
        'txtNSS
        '
        Me.txtNSS.AcceptsDecimals = False
        Me.txtNSS.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtNSS.Location = New System.Drawing.Point(793, 195)
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Size = New System.Drawing.Size(238, 25)
        Me.txtNSS.TabIndex = 64
        '
        'txtCelular
        '
        Me.txtCelular.AcceptsDecimals = False
        Me.txtCelular.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtCelular.Location = New System.Drawing.Point(793, 289)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(238, 25)
        Me.txtCelular.TabIndex = 63
        '
        'txtCdDomicilio
        '
        Me.txtCdDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCdDomicilio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCdDomicilio.Location = New System.Drawing.Point(378, 258)
        Me.txtCdDomicilio.Name = "txtCdDomicilio"
        Me.txtCdDomicilio.Size = New System.Drawing.Size(238, 25)
        Me.txtCdDomicilio.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(254, 261)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Ciudad y Estado:"
        '
        'PbSearchEmployee
        '
        Me.PbSearchEmployee.BackgroundImage = CType(resources.GetObject("PbSearchEmployee.BackgroundImage"), System.Drawing.Image)
        Me.PbSearchEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbSearchEmployee.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.PbSearchEmployee.Location = New System.Drawing.Point(201, 56)
        Me.PbSearchEmployee.Name = "PbSearchEmployee"
        Me.PbSearchEmployee.Size = New System.Drawing.Size(25, 25)
        Me.PbSearchEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSearchEmployee.TabIndex = 62
        Me.PbSearchEmployee.TabStop = False
        '
        'buscar_ciudad
        '
        Me.buscar_ciudad.BackgroundImage = CType(resources.GetObject("buscar_ciudad.BackgroundImage"), System.Drawing.Image)
        Me.buscar_ciudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscar_ciudad.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_ciudad.Location = New System.Drawing.Point(1006, 133)
        Me.buscar_ciudad.Name = "buscar_ciudad"
        Me.buscar_ciudad.Size = New System.Drawing.Size(25, 25)
        Me.buscar_ciudad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_ciudad.TabIndex = 61
        Me.buscar_ciudad.TabStop = False
        '
        'pbFotoEmpleado
        '
        Me.pbFotoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFotoEmpleado.Image = CType(resources.GetObject("pbFotoEmpleado.Image"), System.Drawing.Image)
        Me.pbFotoEmpleado.Location = New System.Drawing.Point(47, 87)
        Me.pbFotoEmpleado.Name = "pbFotoEmpleado"
        Me.pbFotoEmpleado.Size = New System.Drawing.Size(179, 210)
        Me.pbFotoEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbFotoEmpleado.TabIndex = 29
        Me.pbFotoEmpleado.TabStop = False
        '
        'txtCiudadCodigo
        '
        Me.txtCiudadCodigo.Location = New System.Drawing.Point(788, 132)
        Me.txtCiudadCodigo.Name = "txtCiudadCodigo"
        Me.txtCiudadCodigo.Size = New System.Drawing.Size(1, 28)
        Me.txtCiudadCodigo.TabIndex = 17
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rfc.Location = New System.Drawing.Point(733, 167)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(54, 18)
        Me.lbl_rfc.TabIndex = 20
        Me.lbl_rfc.Text = "R.F.C.:"
        '
        'lbl_ss
        '
        Me.lbl_ss.AutoSize = True
        Me.lbl_ss.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ss.Location = New System.Drawing.Point(695, 199)
        Me.lbl_ss.Name = "lbl_ss"
        Me.lbl_ss.Size = New System.Drawing.Size(92, 18)
        Me.lbl_ss.TabIndex = 24
        Me.lbl_ss.Text = "# Seg. Social:"
        '
        'LBL_CP
        '
        Me.LBL_CP.AutoSize = True
        Me.LBL_CP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CP.Location = New System.Drawing.Point(687, 261)
        Me.LBL_CP.Name = "LBL_CP"
        Me.LBL_CP.Size = New System.Drawing.Size(100, 18)
        Me.LBL_CP.TabIndex = 32
        Me.LBL_CP.Text = "Codigo Postal:"
        '
        'txtCURP
        '
        Me.txtCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCURP.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCURP.Location = New System.Drawing.Point(378, 164)
        Me.txtCURP.Name = "txtCURP"
        Me.txtCURP.Size = New System.Drawing.Size(238, 25)
        Me.txtCURP.TabIndex = 19
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(793, 133)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(215, 25)
        Me.txtCiudad.TabIndex = 9
        Me.txtCiudad.TabStop = False
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.Items.AddRange(New Object() {"SOLTERO", "CASADO", "DIVORCIADO", "VIUDO", "UNION LIBRE"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(378, 195)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(238, 26)
        Me.cbEstadoCivil.TabIndex = 23
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(697, 136)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(90, 18)
        Me.Label92.TabIndex = 16
        Me.Label92.Text = "Cd. de Naci.:"
        '
        'cbNivelEducativo
        '
        Me.cbNivelEducativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNivelEducativo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNivelEducativo.FormattingEnabled = True
        Me.cbNivelEducativo.Items.AddRange(New Object() {"PRIMARIA", "SECUNDARIA", "PREPARATOIA", "LICENCIATURA"})
        Me.cbNivelEducativo.Location = New System.Drawing.Point(378, 320)
        Me.cbNivelEducativo.Name = "cbNivelEducativo"
        Me.cbNivelEducativo.Size = New System.Drawing.Size(238, 26)
        Me.cbNivelEducativo.TabIndex = 39
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(293, 324)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(79, 18)
        Me.Label54.TabIndex = 38
        Me.Label54.Text = "Educacion:"
        '
        'lbl_curp
        '
        Me.lbl_curp.AutoSize = True
        Me.lbl_curp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curp.Location = New System.Drawing.Point(303, 167)
        Me.lbl_curp.Name = "lbl_curp"
        Me.lbl_curp.Size = New System.Drawing.Size(69, 18)
        Me.lbl_curp.TabIndex = 18
        Me.lbl_curp.Text = "C.U.R.P.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(726, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Colonia:"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(793, 227)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(238, 25)
        Me.txtColonia.TabIndex = 29
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(292, 292)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(80, 18)
        Me.Label55.TabIndex = 34
        Me.Label55.Text = "# Telefono:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(378, 227)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(238, 25)
        Me.txtDomicilio.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Domicilio:"
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFC.Location = New System.Drawing.Point(793, 164)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(238, 25)
        Me.txtRFC.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(717, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "# Celular:"
        '
        'lbl_sex
        '
        Me.lbl_sex.AutoSize = True
        Me.lbl_sex.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sex.Location = New System.Drawing.Point(746, 74)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(41, 18)
        Me.lbl_sex.TabIndex = 8
        Me.lbl_sex.Text = "Sexo:"
        '
        'LBL_ESTADOCIVIL
        '
        Me.LBL_ESTADOCIVIL.AutoSize = True
        Me.LBL_ESTADOCIVIL.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ESTADOCIVIL.Location = New System.Drawing.Point(280, 199)
        Me.LBL_ESTADOCIVIL.Name = "LBL_ESTADOCIVIL"
        Me.LBL_ESTADOCIVIL.Size = New System.Drawing.Size(92, 18)
        Me.LBL_ESTADOCIVIL.TabIndex = 22
        Me.LBL_ESTADOCIVIL.Text = "Estado Civil:"
        '
        'lbl_fn
        '
        Me.lbl_fn.AutoSize = True
        Me.lbl_fn.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fn.Location = New System.Drawing.Point(265, 105)
        Me.lbl_fn.Name = "lbl_fn"
        Me.lbl_fn.Size = New System.Drawing.Size(107, 18)
        Me.lbl_fn.TabIndex = 10
        Me.lbl_fn.Text = "Fecha de Naci.:"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNacionalidad.Enabled = False
        Me.txtNacionalidad.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNacionalidad.Location = New System.Drawing.Point(793, 102)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(215, 25)
        Me.txtNacionalidad.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(690, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nacionalidad:"
        '
        'dtpFechaDeNacimiento
        '
        Me.dtpFechaDeNacimiento.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeNacimiento.Location = New System.Drawing.Point(378, 102)
        Me.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento"
        Me.dtpFechaDeNacimiento.Size = New System.Drawing.Size(238, 25)
        Me.dtpFechaDeNacimiento.TabIndex = 11
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(793, 70)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(238, 26)
        Me.cbSexo.TabIndex = 9
        '
        'lbl_nac
        '
        Me.lbl_nac.AutoSize = True
        Me.lbl_nac.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nac.Location = New System.Drawing.Point(269, 136)
        Me.lbl_nac.Name = "lbl_nac"
        Me.lbl_nac.Size = New System.Drawing.Size(103, 18)
        Me.lbl_nac.TabIndex = 14
        Me.lbl_nac.Text = "Enti. de Naci.:"
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel7.Controls.Add(Me.SAVE)
        Me.panel7.Controls.Add(Me.CANCEL)
        Me.panel7.Controls.Add(Me.lbl_emp)
        Me.panel7.Controls.Add(Me.label12)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel7.Location = New System.Drawing.Point(0, 0)
        Me.panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(1066, 35)
        Me.panel7.TabIndex = 0
        '
        'SAVE
        '
        Me.SAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(976, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(35, 35)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(1017, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(35, 35)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.White
        Me.lbl_emp.Location = New System.Drawing.Point(109, 6)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 1
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(2, 6)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(91, 21)
        Me.label12.TabIndex = 0
        Me.label12.Text = "Personales"
        '
        'txtEntidad
        '
        Me.txtEntidad.Enabled = False
        Me.txtEntidad.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntidad.Location = New System.Drawing.Point(378, 133)
        Me.txtEntidad.Name = "txtEntidad"
        Me.txtEntidad.Size = New System.Drawing.Size(215, 25)
        Me.txtEntidad.TabIndex = 15
        Me.txtEntidad.TabStop = False
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(115, 56)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(80, 25)
        Me.txtNumero.TabIndex = 1
        '
        'txtEntidadCodigo
        '
        Me.txtEntidadCodigo.Location = New System.Drawing.Point(373, 133)
        Me.txtEntidadCodigo.Name = "txtEntidadCodigo"
        Me.txtEntidadCodigo.Size = New System.Drawing.Size(1, 28)
        Me.txtEntidadCodigo.TabIndex = 7
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(378, 40)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(238, 25)
        Me.txtNombres.TabIndex = 3
        '
        'txtAMaterno
        '
        Me.txtAMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAMaterno.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMaterno.Location = New System.Drawing.Point(378, 71)
        Me.txtAMaterno.Name = "txtAMaterno"
        Me.txtAMaterno.Size = New System.Drawing.Size(238, 25)
        Me.txtAMaterno.TabIndex = 7
        '
        'txtAPaterno
        '
        Me.txtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAPaterno.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPaterno.Location = New System.Drawing.Point(793, 40)
        Me.txtAPaterno.Name = "txtAPaterno"
        Me.txtAPaterno.Size = New System.Drawing.Size(238, 25)
        Me.txtAPaterno.TabIndex = 5
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(594, 133)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 52
        Me.buscar_EN.TabStop = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num.Location = New System.Drawing.Point(47, 59)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(62, 18)
        Me.lbl_num.TabIndex = 0
        Me.lbl_num.Text = "Numero:"
        '
        'lbl_ap
        '
        Me.lbl_ap.AutoSize = True
        Me.lbl_ap.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ap.Location = New System.Drawing.Point(689, 43)
        Me.lbl_ap.Name = "lbl_ap"
        Me.lbl_ap.Size = New System.Drawing.Size(98, 18)
        Me.lbl_ap.TabIndex = 4
        Me.lbl_ap.Text = "Apellido Pat.:"
        '
        'lbl_am
        '
        Me.lbl_am.AutoSize = True
        Me.lbl_am.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_am.Location = New System.Drawing.Point(270, 74)
        Me.lbl_am.Name = "lbl_am"
        Me.lbl_am.Size = New System.Drawing.Size(102, 18)
        Me.lbl_am.TabIndex = 6
        Me.lbl_am.Text = "Apellido Mat.:"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(292, 43)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(80, 18)
        Me.lbl_nom.TabIndex = 2
        Me.lbl_nom.Text = "Nombre(s):"
        '
        'MenuEmp
        '
        Me.MenuEmp.Controls.Add(Me.Tab_DP)
        Me.MenuEmp.Controls.Add(Me.Tab_Familia)
        Me.MenuEmp.Controls.Add(Me.Tab_AL)
        Me.MenuEmp.Controls.Add(Me.Tab_Cont)
        Me.MenuEmp.Controls.Add(Me.Tab_Enfer)
        Me.MenuEmp.Controls.Add(Me.Tam_Es)
        Me.MenuEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuEmp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEmp.Location = New System.Drawing.Point(0, 0)
        Me.MenuEmp.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuEmp.Name = "MenuEmp"
        Me.MenuEmp.SelectedIndex = 0
        Me.MenuEmp.Size = New System.Drawing.Size(1078, 629)
        Me.MenuEmp.TabIndex = 6
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataSource = GetType(AdminEmpleados.Empleado)
        '
        'frmEmpleados
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1078, 629)
        Me.Controls.Add(Me.MenuEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datosFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tam_Es.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlRow8.ResumeLayout(False)
        CType(Me.btn_SERPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SECancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SESave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRow7.ResumeLayout(False)
        Me.PnlObservaciones.ResumeLayout(False)
        Me.PnlObservaciones.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.pnlRow6.ResumeLayout(False)
        Me.PnlGastos.ResumeLayout(False)
        Me.PnlGastos.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.pnlRow5.ResumeLayout(False)
        Me.PnlReferencias.ResumeLayout(False)
        Me.PnlReferencias.PerformLayout()
        CType(Me.dgv_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.Btn_AddRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRow4.ResumeLayout(False)
        Me.PnlIngresos.ResumeLayout(False)
        Me.PnlIngresos.PerformLayout()
        CType(Me.dgv_OI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.btn_OI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRow3.ResumeLayout(False)
        Me.PnlActividades.ResumeLayout(False)
        Me.PnlActividades.PerformLayout()
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.pnlRow2.ResumeLayout(False)
        Me.PnlTransporte.ResumeLayout(False)
        Me.PnlTransporte.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.PnlDatos.ResumeLayout(False)
        Me.PnlDatos.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlRow1.ResumeLayout(False)
        Me.GrpServicios.ResumeLayout(False)
        Me.GrpServicios.PerformLayout()
        CType(Me.pbVivienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpMaterial.ResumeLayout(False)
        Me.GrpTIpo.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Tab_Enfer.ResumeLayout(False)
        Me.panel20.ResumeLayout(False)
        Me.panel20.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.dgvEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel21.ResumeLayout(False)
        Me.panel21.PerformLayout()
        CType(Me.btn_enfADD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Cont.ResumeLayout(False)
        Me.panel18.ResumeLayout(False)
        Me.panel18.PerformLayout()
        Me.PnlContacto.ResumeLayout(False)
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel19.ResumeLayout(False)
        Me.panel19.PerformLayout()
        CType(Me.btn_conADD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_AL.ResumeLayout(False)
        Me.panel16.ResumeLayout(False)
        Me.panel16.PerformLayout()
        Me.pnlAntecedentes.ResumeLayout(False)
        CType(Me.dgvAntecedentesLaborales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel17.ResumeLayout(False)
        Me.panel17.PerformLayout()
        CType(Me.btn_antSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Familia.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.PnlOffsprings.ResumeLayout(False)
        CType(Me.dgvHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        CType(Me.btn_hijoADD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        CType(Me.btn_esSAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEsposa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_DP.ResumeLayout(False)
        Me.pnl_estatus.ResumeLayout(False)
        Me.pnl_estatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel13.ResumeLayout(False)
        Me.panel13.PerformLayout()
        CType(Me.PbOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cont.ResumeLayout(False)
        Me.pnl_cont.PerformLayout()
        CType(Me.buscar_depto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar_PUESTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel11.ResumeLayout(False)
        Me.panel11.PerformLayout()
        CType(Me.Buscar_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar_Super, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_per.ResumeLayout(False)
        Me.pnl_per.PerformLayout()
        CType(Me.Buscar_nac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbSearchEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_ciudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFotoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuEmp.ResumeLayout(False)
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents datosFamiliaBindingSource As BindingSource
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents cText As DataGridViewTextBoxColumn
    Friend WithEvents BwEmpleados As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnEnELiminar As DataGridViewImageColumn
    Friend WithEvents ID_Enf As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents Tam_Es As TabPage
    Private WithEvents Panel1 As Panel
    Friend WithEvents btn_SERPT As PictureBox
    Friend WithEvents btn_SESave As PictureBox
    Friend WithEvents btn_SECancel As PictureBox
    Private WithEvents PnlObservaciones As Panel
    Friend WithEvents txt_Observaciones As TextBox
    Private WithEvents Panel26 As Panel
    Private WithEvents Label71 As Label
    Private WithEvents Label76 As Label
    Private WithEvents PnlGastos As Panel
    Friend WithEvents txt_GFRenta As NumericTextbox
    Friend WithEvents txt_GFCole As NumericTextbox
    Friend WithEvents Txt_GFDesp As NumericTextbox
    Friend WithEvents txt_GFServ As NumericTextbox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label73 As Label
    Private WithEvents Panel30 As Panel
    Private WithEvents Label74 As Label
    Private WithEvents Label75 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label62 As Label
    Private WithEvents PnlReferencias As Panel
    Friend WithEvents Label52 As Label
    Friend WithEvents txt_TiempoDeConocerse As TextBox
    Friend WithEvents txt_RefOcu As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Txt_TipoDeRelacion As TextBox
    Friend WithEvents txt_RefNom As TextBox
    Friend WithEvents Label48 As Label
    Private WithEvents Panel10 As Panel
    Friend WithEvents Btn_AddRef As PictureBox
    Private WithEvents Label51 As Label
    Friend WithEvents PnlActividades As Panel
    Friend WithEvents txt_EventosSociales As NumericTextbox
    Friend WithEvents txt_teatros As NumericTextbox
    Friend WithEvents txt_ParquesNaturales As NumericTextbox
    Friend WithEvents txt_Cines As NumericTextbox
    Friend WithEvents txt_PlazasPublicas As NumericTextbox
    Friend WithEvents txt_ParqueDeDiversiones As NumericTextbox
    Friend WithEvents txt_ZonasArquelogicas As NumericTextbox
    Friend WithEvents txt_Museos As NumericTextbox
    Friend WithEvents txt_Vacaciones As NumericTextbox
    Friend WithEvents txt_FestivalesCulturales As NumericTextbox
    Friend WithEvents txt_EventosComunitarios As NumericTextbox
    Friend WithEvents Label90 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Private WithEvents Panel36 As Panel
    Private WithEvents Label84 As Label
    Private WithEvents PnlIngresos As Panel
    Friend WithEvents txt_OICantidad As NumericTextbox
    Friend WithEvents Label63 As Label
    Friend WithEvents txt_OIParen As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents dgv_OI As DataGridView
    Private WithEvents Panel14 As Panel
    Friend WithEvents btn_OI As PictureBox
    Private WithEvents Label60 As Label
    Private WithEvents Label61 As Label
    Friend WithEvents PnlDatos As Panel
    Private WithEvents Panel6 As Panel
    Private WithEvents Label53 As Label
    Friend WithEvents txt_Religion As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Txt_pasatiempos As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents PnlTransporte As Panel
    Private WithEvents Panel22 As Panel
    Private WithEvents Label57 As Label
    Friend WithEvents cb_Metro As CheckBox
    Friend WithEvents cb_Trans As CheckBox
    Friend WithEvents cb_Taxi As CheckBox
    Friend WithEvents cb_Vehi As CheckBox
    Friend WithEvents pnlRow1 As Panel
    Friend WithEvents GrpServicios As GroupBox
    Friend WithEvents cb_Luz As CheckBox
    Friend WithEvents cb_Drenaje As CheckBox
    Friend WithEvents cb_SisSeg As CheckBox
    Friend WithEvents cb_LineaTel As CheckBox
    Friend WithEvents cb_TV As CheckBox
    Friend WithEvents cb_Internet As CheckBox
    Friend WithEvents cb_AguaP As CheckBox
    Friend WithEvents cb_Tuberia As CheckBox
    Friend WithEvents cb_Basura As CheckBox
    Friend WithEvents pbVivienda As PictureBox
    Friend WithEvents GrpMaterial As GroupBox
    Friend WithEvents rbtnMaterial As RadioButtonList
    Friend WithEvents GrpTIpo As GroupBox
    Friend WithEvents rbtnTipoDeVivienda As RadioButtonList
    Private WithEvents Panel15 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents Tab_Enfer As TabPage
    Private WithEvents panel20 As Panel
    Friend WithEvents Panel8 As Panel
    Private WithEvents dgvEnfermedades As DataGridView
    Friend WithEvents txt_enfNAME As TextBox
    Friend WithEvents label47 As Label
    Private WithEvents panel21 As Panel
    Friend WithEvents btn_enfADD As PictureBox
    Private WithEvents label19 As Label
    Private WithEvents Tab_Cont As TabPage
    Private WithEvents panel18 As Panel
    Friend WithEvents txt_conTEL As NumericTextbox
    Friend WithEvents txt_conCEL As NumericTextbox
    Friend WithEvents PnlContacto As Panel
    Private WithEvents dgvContactos As DataGridView
    Friend WithEvents btnCOEliminar As DataGridViewImageColumn
    Friend WithEvents label45 As Label
    Friend WithEvents txt_conPAREN As TextBox
    Friend WithEvents label41 As Label
    Friend WithEvents label40 As Label
    Friend WithEvents txt_conNAME As TextBox
    Friend WithEvents txt_conAM As TextBox
    Friend WithEvents txt_conAP As TextBox
    Friend WithEvents label42 As Label
    Friend WithEvents label43 As Label
    Friend WithEvents label44 As Label
    Private WithEvents panel19 As Panel
    Friend WithEvents btn_conADD As PictureBox
    Private WithEvents label18 As Label
    Private WithEvents Tab_AL As TabPage
    Private WithEvents panel16 As Panel
    Friend WithEvents txt_antSALARIO As NumericTextbox
    Friend WithEvents pnlAntecedentes As Panel
    Friend WithEvents dgvAntecedentesLaborales As DataGridView
    Friend WithEvents btnAEliminar As DataGridViewImageColumn
    Friend WithEvents txt_antMT As TextBox
    Friend WithEvents txt_antNAME As TextBox
    Friend WithEvents txt_antTEL As TextBox
    Friend WithEvents label37 As Label
    Friend WithEvents label38 As Label
    Friend WithEvents label39 As Label
    Friend WithEvents txt_antCARGO As TextBox
    Friend WithEvents txt_antEMP As TextBox
    Friend WithEvents label34 As Label
    Friend WithEvents label35 As Label
    Friend WithEvents label36 As Label
    Friend WithEvents txt_antFF As DateTimePicker
    Friend WithEvents label33 As Label
    Friend WithEvents txt_antFI As DateTimePicker
    Friend WithEvents label9 As Label
    Private WithEvents panel17 As Panel
    Friend WithEvents btn_antSave As PictureBox
    Private WithEvents label17 As Label
    Private WithEvents Tab_Familia As TabPage
    Private WithEvents panel3 As Panel
    Friend WithEvents PnlOffsprings As Panel
    Private WithEvents dgvHijos As DataGridView
    Friend WithEvents btnHEliminar As DataGridViewImageColumn
    Friend WithEvents label26 As Label
    Friend WithEvents txt_hijoNACION As TextBox
    Friend WithEvents txt_hijoFN As DateTimePicker
    Friend WithEvents label27 As Label
    Friend WithEvents txt_hijoNAME As TextBox
    Friend WithEvents txt_hijoAM As TextBox
    Friend WithEvents txt_hijoAP As TextBox
    Friend WithEvents label28 As Label
    Friend WithEvents label29 As Label
    Friend WithEvents cbHijosSexo As ComboBox
    Friend WithEvents label30 As Label
    Friend WithEvents label31 As Label
    Private WithEvents panel5 As Panel
    Friend WithEvents btn_hijoADD As PictureBox
    Private WithEvents label11 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents panel4 As Panel
    Private WithEvents label10 As Label
    Friend WithEvents btn_esSAVE As PictureBox
    Friend WithEvents label25 As Label
    Friend WithEvents txt_esNacion As TextBox
    Private WithEvents dgvEsposa As DataGridView
    Friend WithEvents btnCEliminar As DataGridViewImageColumn
    Friend WithEvents txt_esName As TextBox
    Friend WithEvents txt_esAM As TextBox
    Friend WithEvents txt_esFN As DateTimePicker
    Friend WithEvents txt_esAP As TextBox
    Friend WithEvents label24 As Label
    Friend WithEvents label23 As Label
    Friend WithEvents label20 As Label
    Friend WithEvents label21 As Label
    Friend WithEvents cbConyugeSexo As ComboBox
    Friend WithEvents label22 As Label
    Private WithEvents Tab_DP As TabPage
    Private WithEvents pnl_estatus As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents CB_CLIENTE As CheckBox
    Private WithEvents seg As CheckBox
    Private WithEvents CB_PROV As CheckBox
    Private WithEvents panel13 As Panel
    Private WithEvents label15 As Label
    Friend WithEvents PbOptions As PictureBox
    Friend WithEvents lbl_option As Label
    Friend WithEvents commen As TextBox
    Friend WithEvents txt_activo As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents txt_baja As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents pnl_cont As Panel
    Friend WithEvents txtSalario As NumericTextbox
    Friend WithEvents buscar_depto As PictureBox
    Friend WithEvents txtDeptoCodigo As TextBox
    Friend WithEvents txtDepto As TextBox
    Friend WithEvents Buscar_PUESTO As PictureBox
    Private WithEvents panel11 As Panel
    Private WithEvents label14 As Label
    Friend WithEvents Buscar_tipo As PictureBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lbl_clase As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents lbl_super As Label
    Friend WithEvents correo As Label
    Friend WithEvents lbl_puesto As Label
    Friend WithEvents txtTipoCodigo As TextBox
    Friend WithEvents lbl_sali As Label
    Friend WithEvents dtpFechaDeIngreso As DateTimePicker
    Friend WithEvents Buscar_Super As PictureBox
    Friend WithEvents txtPuestoCodigo As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtSupervisor As TextBox
    Friend WithEvents txtSupervisorCodigo As TextBox
    Friend WithEvents lbl_depto As Label
    Private WithEvents pnl_per As Panel
    Friend WithEvents txtTelefono As NumericTextbox
    Friend WithEvents txtCodigoPostal As NumericTextbox
    Friend WithEvents txtNSS As NumericTextbox
    Friend WithEvents txtCelular As NumericTextbox
    Friend WithEvents txtCdDomicilio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PbSearchEmployee As PictureBox
    Friend WithEvents buscar_ciudad As PictureBox
    Friend WithEvents pbFotoEmpleado As PictureBox
    Friend WithEvents txtCiudadCodigo As TextBox
    Friend WithEvents lbl_rfc As Label
    Friend WithEvents lbl_ss As Label
    Friend WithEvents LBL_CP As Label
    Friend WithEvents txtCURP As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents cbEstadoCivil As ComboBox
    Friend WithEvents Label92 As Label
    Friend WithEvents cbNivelEducativo As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents lbl_curp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_sex As Label
    Friend WithEvents LBL_ESTADOCIVIL As Label
    Friend WithEvents lbl_fn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaDeNacimiento As DateTimePicker
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents lbl_nac As Label
    Private WithEvents panel7 As Panel
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Friend WithEvents lbl_emp As Label
    Private WithEvents label12 As Label
    Friend WithEvents txtEntidad As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtEntidadCodigo As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtAMaterno As TextBox
    Friend WithEvents txtAPaterno As TextBox
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents lbl_ap As Label
    Friend WithEvents lbl_am As Label
    Friend WithEvents lbl_nom As Label
    Private WithEvents MenuEmp As TabControl
    Friend WithEvents dgv_Ref As DataGridView
    Friend WithEvents btnEIngresos As DataGridViewImageColumn
    Friend WithEvents btnEReferencia As DataGridViewImageColumn
    Friend WithEvents pnlRow2 As Panel
    Friend WithEvents pnlRow4 As Panel
    Friend WithEvents pnlRow3 As Panel
    Friend WithEvents pnlRow7 As Panel
    Friend WithEvents pnlRow6 As Panel
    Friend WithEvents pnlRow5 As Panel
    Friend WithEvents pnlRow8 As Panel
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents Buscar_nac As PictureBox
End Class
