﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empleados
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tam_Es = New System.Windows.Forms.TabPage()
        Me.PnlDatos = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txt_Religion = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Txt_pasatiempos = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PnlIngresos = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_OTCantidad = New System.Windows.Forms.TextBox()
        Me.txt_OIParen = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.dgv_OI = New System.Windows.Forms.DataGridView()
        Me.PARENTESCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrpServicios = New System.Windows.Forms.GroupBox()
        Me.cb_Luz = New System.Windows.Forms.CheckBox()
        Me.cb_Drenaje = New System.Windows.Forms.CheckBox()
        Me.cb_AguaP = New System.Windows.Forms.CheckBox()
        Me.cb_SisSeg = New System.Windows.Forms.CheckBox()
        Me.cb_Tuberia = New System.Windows.Forms.CheckBox()
        Me.cb_Basura = New System.Windows.Forms.CheckBox()
        Me.cb_TV = New System.Windows.Forms.CheckBox()
        Me.cb_Internet = New System.Windows.Forms.CheckBox()
        Me.cb_LineaTel = New System.Windows.Forms.CheckBox()
        Me.PnlVivienda = New System.Windows.Forms.Panel()
        Me.GrpMaterial = New System.Windows.Forms.GroupBox()
        Me.cb_block = New System.Windows.Forms.CheckBox()
        Me.cb_adobe = New System.Windows.Forms.CheckBox()
        Me.cb_ladrillo = New System.Windows.Forms.CheckBox()
        Me.cb_Madera = New System.Windows.Forms.CheckBox()
        Me.GrpTIpo = New System.Windows.Forms.GroupBox()
        Me.cb_CasaP = New System.Windows.Forms.CheckBox()
        Me.cb_Renta = New System.Windows.Forms.CheckBox()
        Me.cb_Depto = New System.Windows.Forms.CheckBox()
        Me.cb_Terreno = New System.Windows.Forms.CheckBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Metro = New System.Windows.Forms.CheckBox()
        Me.cb_Taxi = New System.Windows.Forms.CheckBox()
        Me.cb_Trans = New System.Windows.Forms.CheckBox()
        Me.cb_Vehi = New System.Windows.Forms.CheckBox()
        Me.Tab_Enfer = New System.Windows.Forms.TabPage()
        Me.panel20 = New System.Windows.Forms.Panel()
        Me.dgv_Enf = New System.Windows.Forms.DataGridView()
        Me.ID_Enf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Text = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_enfNAME = New System.Windows.Forms.TextBox()
        Me.label47 = New System.Windows.Forms.Label()
        Me.panel21 = New System.Windows.Forms.Panel()
        Me.label19 = New System.Windows.Forms.Label()
        Me.Tab_Cont = New System.Windows.Forms.TabPage()
        Me.panel18 = New System.Windows.Forms.Panel()
        Me.dgv_contacto = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label45 = New System.Windows.Forms.Label()
        Me.txt_conPAREN = New System.Windows.Forms.TextBox()
        Me.label41 = New System.Windows.Forms.Label()
        Me.txt_conCEL = New System.Windows.Forms.TextBox()
        Me.label40 = New System.Windows.Forms.Label()
        Me.txt_conTEL = New System.Windows.Forms.TextBox()
        Me.txt_conNAME = New System.Windows.Forms.TextBox()
        Me.txt_conAM = New System.Windows.Forms.TextBox()
        Me.txt_conAP = New System.Windows.Forms.TextBox()
        Me.label42 = New System.Windows.Forms.Label()
        Me.label43 = New System.Windows.Forms.Label()
        Me.label44 = New System.Windows.Forms.Label()
        Me.panel19 = New System.Windows.Forms.Panel()
        Me.label18 = New System.Windows.Forms.Label()
        Me.Tab_AL = New System.Windows.Forms.TabPage()
        Me.panel16 = New System.Windows.Forms.Panel()
        Me.dgv_ant = New System.Windows.Forms.DataGridView()
        Me.ID_Ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID__Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_FInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_FFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_NEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_Salario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ant_Contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_antMT = New System.Windows.Forms.TextBox()
        Me.txt_antNAME = New System.Windows.Forms.TextBox()
        Me.txt_antTEL = New System.Windows.Forms.TextBox()
        Me.label37 = New System.Windows.Forms.Label()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label39 = New System.Windows.Forms.Label()
        Me.txt_antSALARIO = New System.Windows.Forms.TextBox()
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
        Me.label17 = New System.Windows.Forms.Label()
        Me.Tab_Familia = New System.Windows.Forms.TabPage()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Hijos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_hijoEC = New System.Windows.Forms.ComboBox()
        Me.label32 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.txt_hijoNACION = New System.Windows.Forms.TextBox()
        Me.txt_hijoFN = New System.Windows.Forms.DateTimePicker()
        Me.label27 = New System.Windows.Forms.Label()
        Me.txt_hijoNAME = New System.Windows.Forms.TextBox()
        Me.txt_hijoAM = New System.Windows.Forms.TextBox()
        Me.txt_hijoAP = New System.Windows.Forms.TextBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.txt_hijoSEXO = New System.Windows.Forms.ComboBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label31 = New System.Windows.Forms.Label()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label25 = New System.Windows.Forms.Label()
        Me.txt_esNacion = New System.Windows.Forms.TextBox()
        Me.dgv_esposa = New System.Windows.Forms.DataGridView()
        Me.ID_Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_APat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_AMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_Nacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_FNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fam_EdoCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_esName = New System.Windows.Forms.TextBox()
        Me.txt_esAM = New System.Windows.Forms.TextBox()
        Me.txt_esFN = New System.Windows.Forms.DateTimePicker()
        Me.txt_esAP = New System.Windows.Forms.TextBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label21 = New System.Windows.Forms.Label()
        Me.cb_esSexo = New System.Windows.Forms.ComboBox()
        Me.label22 = New System.Windows.Forms.Label()
        Me.Tab_DP = New System.Windows.Forms.TabPage()
        Me.lbl_emp = New System.Windows.Forms.Label()
        Me.pnl_estatus = New System.Windows.Forms.Panel()
        Me.CB_CLIENTE = New System.Windows.Forms.CheckBox()
        Me.CB_PROV = New System.Windows.Forms.CheckBox()
        Me.seg = New System.Windows.Forms.CheckBox()
        Me.panel13 = New System.Windows.Forms.Panel()
        Me.LBL_BAJA = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.lbl_ALTA = New System.Windows.Forms.Label()
        Me.commen = New System.Windows.Forms.TextBox()
        Me.txt_activo = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txt_baja = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnl_cont = New System.Windows.Forms.Panel()
        Me.depto = New System.Windows.Forms.TextBox()
        Me.depto2 = New System.Windows.Forms.TextBox()
        Me.panel11 = New System.Windows.Forms.Panel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.lbl_ingreso = New System.Windows.Forms.Label()
        Me.Txt_correo = New System.Windows.Forms.TextBox()
        Me.lbl_clase = New System.Windows.Forms.Label()
        Me.txt_tipo2 = New System.Windows.Forms.TextBox()
        Me.lbl_super = New System.Windows.Forms.Label()
        Me.correo = New System.Windows.Forms.Label()
        Me.txt_SALARY = New System.Windows.Forms.TextBox()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.lbl_sali = New System.Windows.Forms.Label()
        Me.txt_FECHAINGRESO = New System.Windows.Forms.DateTimePicker()
        Me.txt_PUESTO = New System.Windows.Forms.TextBox()
        Me.txt_PUESTO2 = New System.Windows.Forms.TextBox()
        Me.txt_SUPER2 = New System.Windows.Forms.TextBox()
        Me.txt_SUPER = New System.Windows.Forms.TextBox()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.pnl_per = New System.Windows.Forms.Panel()
        Me.cuidad = New System.Windows.Forms.TextBox()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.lbl_ss = New System.Windows.Forms.Label()
        Me.CP = New System.Windows.Forms.TextBox()
        Me.LBL_CP = New System.Windows.Forms.Label()
        Me.txt_CURP = New System.Windows.Forms.TextBox()
        Me.cuidad2 = New System.Windows.Forms.TextBox()
        Me.EC = New System.Windows.Forms.ComboBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txt_SS = New System.Windows.Forms.TextBox()
        Me.ddl_educacion = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lbl_curp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.colonia = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.domicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_RFC = New System.Windows.Forms.TextBox()
        Me.Celular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_sex = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.LBL_ESTADOCIVIL = New System.Windows.Forms.Label()
        Me.lbl_fn = New System.Windows.Forms.Label()
        Me.nacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.CB_SEXO = New System.Windows.Forms.ComboBox()
        Me.lbl_nac = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.label12 = New System.Windows.Forms.Label()
        Me.pnl_save = New System.Windows.Forms.Panel()
        Me.txt_EN2 = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_EN = New System.Windows.Forms.TextBox()
        Me.txt_NOM = New System.Windows.Forms.TextBox()
        Me.txt_AM = New System.Windows.Forms.TextBox()
        Me.txt_AP = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.lbl_ap = New System.Windows.Forms.Label()
        Me.lbl_am = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.MenuEmp = New System.Windows.Forms.TabControl()
        Me.PnlTransporte = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ALTA = New System.Windows.Forms.PictureBox()
        Me.BAJA = New System.Windows.Forms.PictureBox()
        Me.buscar_depto = New System.Windows.Forms.PictureBox()
        Me.Buscar_PUESTO = New System.Windows.Forms.PictureBox()
        Me.Buscar_tipo = New System.Windows.Forms.PictureBox()
        Me.Buscar_Super = New System.Windows.Forms.PictureBox()
        Me.buscar_ciudad = New System.Windows.Forms.PictureBox()
        Me.foto = New System.Windows.Forms.PictureBox()
        Me.CANCEL = New System.Windows.Forms.PictureBox()
        Me.SAVE = New System.Windows.Forms.PictureBox()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        Me.btn_hijoADD = New System.Windows.Forms.PictureBox()
        Me.btn_esSAVE = New System.Windows.Forms.PictureBox()
        Me.btn_antSave = New System.Windows.Forms.PictureBox()
        Me.btn_conADD = New System.Windows.Forms.PictureBox()
        Me.btn_enfADD = New System.Windows.Forms.PictureBox()
        Me.btn_OI = New System.Windows.Forms.PictureBox()
        Me.PB_IMAGE_VIVIENDA = New System.Windows.Forms.PictureBox()
        Me.datosFamiliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlActividades = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txt_SE_CULTURALES = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txt_SE_TEATROS = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txt_SE__SOCIALE = New System.Windows.Forms.TextBox()
        Me.txt_SE_EVENTOS = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txt_SE_NATURALES = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.txt_SE_VACIONES = New System.Windows.Forms.TextBox()
        Me.txt_SE_CINES = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txt_SE_MUSEOS = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txt_se_diversiones = New System.Windows.Forms.TextBox()
        Me.txt_SE_PLAZAS = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txt_SE_ZONAS = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.PnlReferencias = New System.Windows.Forms.Panel()
        Me.Btn_AddRef = New System.Windows.Forms.PictureBox()
        Me.dgv_Ref = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCUPACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_TC = New System.Windows.Forms.TextBox()
        Me.txt_RefOcu = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Txt_TR = New System.Windows.Forms.TextBox()
        Me.txt_RefNom = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.PnlGastos = New System.Windows.Forms.Panel()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_GFServ = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Txt_GFDesp = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txt_GFRenta = New System.Windows.Forms.TextBox()
        Me.txt_GFCole = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.PnlObservaciones = New System.Windows.Forms.Panel()
        Me.txt_commen = New System.Windows.Forms.TextBox()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.btn_SERPT = New System.Windows.Forms.PictureBox()
        Me.btn_SESave = New System.Windows.Forms.PictureBox()
        Me.btn_SECancel = New System.Windows.Forms.PictureBox()
        Me.Tam_Es.SuspendLayout()
        Me.PnlDatos.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PnlIngresos.SuspendLayout()
        CType(Me.dgv_OI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpServicios.SuspendLayout()
        Me.PnlVivienda.SuspendLayout()
        Me.GrpMaterial.SuspendLayout()
        Me.GrpTIpo.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Tab_Enfer.SuspendLayout()
        Me.panel20.SuspendLayout()
        CType(Me.dgv_Enf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel21.SuspendLayout()
        Me.Tab_Cont.SuspendLayout()
        Me.panel18.SuspendLayout()
        CType(Me.dgv_contacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel19.SuspendLayout()
        Me.Tab_AL.SuspendLayout()
        Me.panel16.SuspendLayout()
        CType(Me.dgv_ant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel17.SuspendLayout()
        Me.Tab_Familia.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.dgv_Hijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel5.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel4.SuspendLayout()
        CType(Me.dgv_esposa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_DP.SuspendLayout()
        Me.pnl_estatus.SuspendLayout()
        Me.panel13.SuspendLayout()
        Me.pnl_cont.SuspendLayout()
        Me.panel11.SuspendLayout()
        Me.pnl_per.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.pnl_save.SuspendLayout()
        Me.MenuEmp.SuspendLayout()
        Me.PnlTransporte.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.ALTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_depto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar_PUESTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar_Super, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_ciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_hijoADD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_esSAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_antSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_conADD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_enfADD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_OI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_IMAGE_VIVIENDA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datosFamiliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlActividades.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.PnlReferencias.SuspendLayout()
        CType(Me.Btn_AddRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.PnlGastos.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.PnlObservaciones.SuspendLayout()
        Me.Panel26.SuspendLayout()
        CType(Me.btn_SERPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SESave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SECancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tam_Es
        '
        Me.Tam_Es.AutoScroll = True
        Me.Tam_Es.Controls.Add(Me.Panel1)
        Me.Tam_Es.Location = New System.Drawing.Point(4, 30)
        Me.Tam_Es.Name = "Tam_Es"
        Me.Tam_Es.Padding = New System.Windows.Forms.Padding(3)
        Me.Tam_Es.Size = New System.Drawing.Size(950, 1066)
        Me.Tam_Es.TabIndex = 5
        Me.Tam_Es.Text = "Estudio SocioEconomico"
        Me.Tam_Es.UseVisualStyleBackColor = True
        '
        'PnlDatos
        '
        Me.PnlDatos.Controls.Add(Me.Panel6)
        Me.PnlDatos.Controls.Add(Me.txt_Religion)
        Me.PnlDatos.Controls.Add(Me.Label50)
        Me.PnlDatos.Controls.Add(Me.Txt_pasatiempos)
        Me.PnlDatos.Controls.Add(Me.Label49)
        Me.PnlDatos.Location = New System.Drawing.Point(491, 314)
        Me.PnlDatos.Name = "PnlDatos"
        Me.PnlDatos.Size = New System.Drawing.Size(429, 110)
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
        Me.Panel6.Size = New System.Drawing.Size(429, 35)
        Me.Panel6.TabIndex = 0
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(13, 6)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(54, 21)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Datos"
        '
        'txt_Religion
        '
        Me.txt_Religion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Religion.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Religion.Location = New System.Drawing.Point(124, 40)
        Me.txt_Religion.Name = "txt_Religion"
        Me.txt_Religion.Size = New System.Drawing.Size(293, 28)
        Me.txt_Religion.TabIndex = 0
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(43, 43)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(75, 21)
        Me.Label50.TabIndex = 37
        Me.Label50.Text = "Religion:"
        '
        'Txt_pasatiempos
        '
        Me.Txt_pasatiempos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_pasatiempos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pasatiempos.Location = New System.Drawing.Point(124, 72)
        Me.Txt_pasatiempos.Name = "Txt_pasatiempos"
        Me.Txt_pasatiempos.Size = New System.Drawing.Size(293, 28)
        Me.Txt_pasatiempos.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(8, 77)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(110, 21)
        Me.Label49.TabIndex = 44
        Me.Label49.Text = "Pasatiempos:"
        '
        'PnlIngresos
        '
        Me.PnlIngresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlIngresos.Controls.Add(Me.Label63)
        Me.PnlIngresos.Controls.Add(Me.txt_OTCantidad)
        Me.PnlIngresos.Controls.Add(Me.txt_OIParen)
        Me.PnlIngresos.Controls.Add(Me.Label65)
        Me.PnlIngresos.Controls.Add(Me.dgv_OI)
        Me.PnlIngresos.Controls.Add(Me.Panel14)
        Me.PnlIngresos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlIngresos.Location = New System.Drawing.Point(0, 680)
        Me.PnlIngresos.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlIngresos.Name = "PnlIngresos"
        Me.PnlIngresos.Size = New System.Drawing.Size(920, 182)
        Me.PnlIngresos.TabIndex = 51
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(327, 48)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(83, 21)
        Me.Label63.TabIndex = 62
        Me.Label63.Text = "Cantidad:"
        '
        'txt_OTCantidad
        '
        Me.txt_OTCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OTCantidad.Location = New System.Drawing.Point(416, 45)
        Me.txt_OTCantidad.Name = "txt_OTCantidad"
        Me.txt_OTCantidad.Size = New System.Drawing.Size(208, 28)
        Me.txt_OTCantidad.TabIndex = 16
        '
        'txt_OIParen
        '
        Me.txt_OIParen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OIParen.Location = New System.Drawing.Point(109, 45)
        Me.txt_OIParen.Name = "txt_OIParen"
        Me.txt_OIParen.Size = New System.Drawing.Size(212, 28)
        Me.txt_OIParen.TabIndex = 15
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(5, 48)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(98, 21)
        Me.Label65.TabIndex = 57
        Me.Label65.Text = "Parentesco:"
        '
        'dgv_OI
        '
        Me.dgv_OI.AllowUserToAddRows = False
        Me.dgv_OI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_OI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PARENTESCO, Me.CANTIDAD})
        Me.dgv_OI.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_OI.Location = New System.Drawing.Point(0, 80)
        Me.dgv_OI.Name = "dgv_OI"
        Me.dgv_OI.RowHeadersVisible = False
        Me.dgv_OI.Size = New System.Drawing.Size(916, 98)
        Me.dgv_OI.TabIndex = 55
        '
        'PARENTESCO
        '
        Me.PARENTESCO.DataPropertyName = "OIng_Desc"
        Me.PARENTESCO.HeaderText = "PARENTESCO"
        Me.PARENTESCO.Name = "PARENTESCO"
        Me.PARENTESCO.Width = 500
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "OIng_Cantidad"
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 600
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
        Me.Panel14.Size = New System.Drawing.Size(916, 40)
        Me.Panel14.TabIndex = 0
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(13, 6)
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_SERPT)
        Me.Panel1.Controls.Add(Me.btn_SESave)
        Me.Panel1.Controls.Add(Me.btn_SECancel)
        Me.Panel1.Controls.Add(Me.PnlObservaciones)
        Me.Panel1.Controls.Add(Me.PnlGastos)
        Me.Panel1.Controls.Add(Me.PnlReferencias)
        Me.Panel1.Controls.Add(Me.PnlActividades)
        Me.Panel1.Controls.Add(Me.PnlIngresos)
        Me.Panel1.Controls.Add(Me.PnlDatos)
        Me.Panel1.Controls.Add(Me.PnlTransporte)
        Me.Panel1.Controls.Add(Me.PnlVivienda)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 1400)
        Me.Panel1.TabIndex = 2
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
        Me.GrpServicios.Location = New System.Drawing.Point(465, 182)
        Me.GrpServicios.Name = "GrpServicios"
        Me.GrpServicios.Size = New System.Drawing.Size(448, 120)
        Me.GrpServicios.TabIndex = 16
        Me.GrpServicios.TabStop = False
        Me.GrpServicios.Text = "Servicios"
        '
        'cb_Luz
        '
        Me.cb_Luz.AutoSize = True
        Me.cb_Luz.Location = New System.Drawing.Point(6, 27)
        Me.cb_Luz.Name = "cb_Luz"
        Me.cb_Luz.Size = New System.Drawing.Size(55, 25)
        Me.cb_Luz.TabIndex = 18
        Me.cb_Luz.Text = "Luz"
        Me.cb_Luz.UseVisualStyleBackColor = True
        '
        'cb_Drenaje
        '
        Me.cb_Drenaje.AutoSize = True
        Me.cb_Drenaje.Location = New System.Drawing.Point(67, 27)
        Me.cb_Drenaje.Name = "cb_Drenaje"
        Me.cb_Drenaje.Size = New System.Drawing.Size(88, 25)
        Me.cb_Drenaje.TabIndex = 21
        Me.cb_Drenaje.Text = "Drenaje"
        Me.cb_Drenaje.UseVisualStyleBackColor = True
        '
        'cb_AguaP
        '
        Me.cb_AguaP.AutoSize = True
        Me.cb_AguaP.Location = New System.Drawing.Point(161, 27)
        Me.cb_AguaP.Name = "cb_AguaP"
        Me.cb_AguaP.Size = New System.Drawing.Size(132, 25)
        Me.cb_AguaP.TabIndex = 20
        Me.cb_AguaP.Text = "Agua Potable"
        Me.cb_AguaP.UseVisualStyleBackColor = True
        '
        'cb_SisSeg
        '
        Me.cb_SisSeg.AutoSize = True
        Me.cb_SisSeg.Location = New System.Drawing.Point(145, 89)
        Me.cb_SisSeg.Name = "cb_SisSeg"
        Me.cb_SisSeg.Size = New System.Drawing.Size(194, 25)
        Me.cb_SisSeg.TabIndex = 26
        Me.cb_SisSeg.Text = "Sistema de Seguridad"
        Me.cb_SisSeg.UseVisualStyleBackColor = True
        '
        'cb_Tuberia
        '
        Me.cb_Tuberia.AutoSize = True
        Me.cb_Tuberia.Location = New System.Drawing.Point(299, 27)
        Me.cb_Tuberia.Name = "cb_Tuberia"
        Me.cb_Tuberia.Size = New System.Drawing.Size(143, 25)
        Me.cb_Tuberia.TabIndex = 22
        Me.cb_Tuberia.Text = "Tuberia de Gas"
        Me.cb_Tuberia.UseVisualStyleBackColor = True
        '
        'cb_Basura
        '
        Me.cb_Basura.AutoSize = True
        Me.cb_Basura.Location = New System.Drawing.Point(6, 58)
        Me.cb_Basura.Name = "cb_Basura"
        Me.cb_Basura.Size = New System.Drawing.Size(175, 25)
        Me.cb_Basura.TabIndex = 23
        Me.cb_Basura.Text = "Recoleccion Basura"
        Me.cb_Basura.UseVisualStyleBackColor = True
        '
        'cb_TV
        '
        Me.cb_TV.AutoSize = True
        Me.cb_TV.Location = New System.Drawing.Point(6, 89)
        Me.cb_TV.Name = "cb_TV"
        Me.cb_TV.Size = New System.Drawing.Size(128, 25)
        Me.cb_TV.TabIndex = 24
        Me.cb_TV.Text = "TV por Cable"
        Me.cb_TV.UseVisualStyleBackColor = True
        '
        'cb_Internet
        '
        Me.cb_Internet.AutoSize = True
        Me.cb_Internet.Location = New System.Drawing.Point(345, 58)
        Me.cb_Internet.Name = "cb_Internet"
        Me.cb_Internet.Size = New System.Drawing.Size(90, 25)
        Me.cb_Internet.TabIndex = 25
        Me.cb_Internet.Text = "Internet"
        Me.cb_Internet.UseVisualStyleBackColor = True
        '
        'cb_LineaTel
        '
        Me.cb_LineaTel.AutoSize = True
        Me.cb_LineaTel.Location = New System.Drawing.Point(187, 58)
        Me.cb_LineaTel.Name = "cb_LineaTel"
        Me.cb_LineaTel.Size = New System.Drawing.Size(152, 25)
        Me.cb_LineaTel.TabIndex = 19
        Me.cb_LineaTel.Text = "Linea Telefonica"
        Me.cb_LineaTel.UseVisualStyleBackColor = True
        '
        'PnlVivienda
        '
        Me.PnlVivienda.Controls.Add(Me.GrpServicios)
        Me.PnlVivienda.Controls.Add(Me.PB_IMAGE_VIVIENDA)
        Me.PnlVivienda.Controls.Add(Me.GrpMaterial)
        Me.PnlVivienda.Controls.Add(Me.GrpTIpo)
        Me.PnlVivienda.Controls.Add(Me.Panel15)
        Me.PnlVivienda.Location = New System.Drawing.Point(0, 0)
        Me.PnlVivienda.Name = "PnlVivienda"
        Me.PnlVivienda.Size = New System.Drawing.Size(920, 308)
        Me.PnlVivienda.TabIndex = 0
        '
        'GrpMaterial
        '
        Me.GrpMaterial.Controls.Add(Me.cb_block)
        Me.GrpMaterial.Controls.Add(Me.cb_adobe)
        Me.GrpMaterial.Controls.Add(Me.cb_ladrillo)
        Me.GrpMaterial.Controls.Add(Me.cb_Madera)
        Me.GrpMaterial.Location = New System.Drawing.Point(465, 111)
        Me.GrpMaterial.Name = "GrpMaterial"
        Me.GrpMaterial.Size = New System.Drawing.Size(448, 65)
        Me.GrpMaterial.TabIndex = 15
        Me.GrpMaterial.TabStop = False
        Me.GrpMaterial.Text = "Material"
        '
        'cb_block
        '
        Me.cb_block.AutoSize = True
        Me.cb_block.Location = New System.Drawing.Point(91, 27)
        Me.cb_block.Name = "cb_block"
        Me.cb_block.Size = New System.Drawing.Size(70, 25)
        Me.cb_block.TabIndex = 48
        Me.cb_block.Text = "Block"
        Me.cb_block.UseVisualStyleBackColor = True
        '
        'cb_adobe
        '
        Me.cb_adobe.AutoSize = True
        Me.cb_adobe.Location = New System.Drawing.Point(6, 27)
        Me.cb_adobe.Name = "cb_adobe"
        Me.cb_adobe.Size = New System.Drawing.Size(79, 25)
        Me.cb_adobe.TabIndex = 46
        Me.cb_adobe.Text = "Adobe"
        Me.cb_adobe.UseVisualStyleBackColor = True
        '
        'cb_ladrillo
        '
        Me.cb_ladrillo.AutoSize = True
        Me.cb_ladrillo.Location = New System.Drawing.Point(167, 27)
        Me.cb_ladrillo.Name = "cb_ladrillo"
        Me.cb_ladrillo.Size = New System.Drawing.Size(84, 25)
        Me.cb_ladrillo.TabIndex = 47
        Me.cb_ladrillo.Text = "Ladrillo"
        Me.cb_ladrillo.UseVisualStyleBackColor = True
        '
        'cb_Madera
        '
        Me.cb_Madera.AutoSize = True
        Me.cb_Madera.Location = New System.Drawing.Point(257, 27)
        Me.cb_Madera.Name = "cb_Madera"
        Me.cb_Madera.Size = New System.Drawing.Size(88, 25)
        Me.cb_Madera.TabIndex = 49
        Me.cb_Madera.Text = "Madera"
        Me.cb_Madera.UseVisualStyleBackColor = True
        '
        'GrpTIpo
        '
        Me.GrpTIpo.Controls.Add(Me.cb_CasaP)
        Me.GrpTIpo.Controls.Add(Me.cb_Renta)
        Me.GrpTIpo.Controls.Add(Me.cb_Depto)
        Me.GrpTIpo.Controls.Add(Me.cb_Terreno)
        Me.GrpTIpo.Location = New System.Drawing.Point(465, 40)
        Me.GrpTIpo.Name = "GrpTIpo"
        Me.GrpTIpo.Size = New System.Drawing.Size(448, 65)
        Me.GrpTIpo.TabIndex = 2
        Me.GrpTIpo.TabStop = False
        Me.GrpTIpo.Text = "Tipo"
        '
        'cb_CasaP
        '
        Me.cb_CasaP.AutoSize = True
        Me.cb_CasaP.Location = New System.Drawing.Point(6, 27)
        Me.cb_CasaP.Name = "cb_CasaP"
        Me.cb_CasaP.Size = New System.Drawing.Size(119, 25)
        Me.cb_CasaP.TabIndex = 11
        Me.cb_CasaP.Text = "Casa Propia"
        Me.cb_CasaP.UseVisualStyleBackColor = True
        '
        'cb_Renta
        '
        Me.cb_Renta.AutoSize = True
        Me.cb_Renta.Location = New System.Drawing.Point(131, 27)
        Me.cb_Renta.Name = "cb_Renta"
        Me.cb_Renta.Size = New System.Drawing.Size(73, 25)
        Me.cb_Renta.TabIndex = 12
        Me.cb_Renta.Text = "Renta"
        Me.cb_Renta.UseVisualStyleBackColor = True
        '
        'cb_Depto
        '
        Me.cb_Depto.AutoSize = True
        Me.cb_Depto.Location = New System.Drawing.Point(304, 27)
        Me.cb_Depto.Name = "cb_Depto"
        Me.cb_Depto.Size = New System.Drawing.Size(140, 25)
        Me.cb_Depto.TabIndex = 14
        Me.cb_Depto.Text = "Departamento"
        Me.cb_Depto.UseVisualStyleBackColor = True
        '
        'cb_Terreno
        '
        Me.cb_Terreno.AutoSize = True
        Me.cb_Terreno.Location = New System.Drawing.Point(210, 27)
        Me.cb_Terreno.Name = "cb_Terreno"
        Me.cb_Terreno.Size = New System.Drawing.Size(88, 25)
        Me.cb_Terreno.TabIndex = 13
        Me.cb_Terreno.Text = "Terreno"
        Me.cb_Terreno.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label5)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(920, 35)
        Me.Panel15.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vivienda"
        '
        'cb_Metro
        '
        Me.cb_Metro.AutoSize = True
        Me.cb_Metro.Location = New System.Drawing.Point(6, 45)
        Me.cb_Metro.Name = "cb_Metro"
        Me.cb_Metro.Size = New System.Drawing.Size(76, 25)
        Me.cb_Metro.TabIndex = 7
        Me.cb_Metro.Text = "Metro"
        Me.cb_Metro.UseVisualStyleBackColor = True
        '
        'cb_Taxi
        '
        Me.cb_Taxi.AutoSize = True
        Me.cb_Taxi.Location = New System.Drawing.Point(266, 45)
        Me.cb_Taxi.Name = "cb_Taxi"
        Me.cb_Taxi.Size = New System.Drawing.Size(59, 25)
        Me.cb_Taxi.TabIndex = 9
        Me.cb_Taxi.Text = "Taxi"
        Me.cb_Taxi.UseVisualStyleBackColor = True
        '
        'cb_Trans
        '
        Me.cb_Trans.AutoSize = True
        Me.cb_Trans.Location = New System.Drawing.Point(88, 45)
        Me.cb_Trans.Name = "cb_Trans"
        Me.cb_Trans.Size = New System.Drawing.Size(172, 25)
        Me.cb_Trans.TabIndex = 8
        Me.cb_Trans.Text = "Transporte Publico"
        Me.cb_Trans.UseVisualStyleBackColor = True
        '
        'cb_Vehi
        '
        Me.cb_Vehi.AutoSize = True
        Me.cb_Vehi.Location = New System.Drawing.Point(331, 45)
        Me.cb_Vehi.Name = "cb_Vehi"
        Me.cb_Vehi.Size = New System.Drawing.Size(150, 25)
        Me.cb_Vehi.TabIndex = 10
        Me.cb_Vehi.Text = "Vehiculo Propio"
        Me.cb_Vehi.UseVisualStyleBackColor = True
        '
        'Tab_Enfer
        '
        Me.Tab_Enfer.Controls.Add(Me.panel20)
        Me.Tab_Enfer.Location = New System.Drawing.Point(4, 30)
        Me.Tab_Enfer.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Enfer.Name = "Tab_Enfer"
        Me.Tab_Enfer.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Enfer.Size = New System.Drawing.Size(950, 1066)
        Me.Tab_Enfer.TabIndex = 4
        Me.Tab_Enfer.Text = "Enfermedades"
        Me.Tab_Enfer.UseVisualStyleBackColor = True
        '
        'panel20
        '
        Me.panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel20.Controls.Add(Me.dgv_Enf)
        Me.panel20.Controls.Add(Me.txt_enfNAME)
        Me.panel20.Controls.Add(Me.label47)
        Me.panel20.Controls.Add(Me.panel21)
        Me.panel20.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel20.ForeColor = System.Drawing.Color.White
        Me.panel20.Location = New System.Drawing.Point(0, 0)
        Me.panel20.Margin = New System.Windows.Forms.Padding(2)
        Me.panel20.Name = "panel20"
        Me.panel20.Size = New System.Drawing.Size(962, 653)
        Me.panel20.TabIndex = 1
        '
        'dgv_Enf
        '
        Me.dgv_Enf.AllowUserToAddRows = False
        Me.dgv_Enf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Enf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Enf, Me.Text})
        Me.dgv_Enf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Enf.Location = New System.Drawing.Point(0, 280)
        Me.dgv_Enf.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Enf.Name = "dgv_Enf"
        Me.dgv_Enf.ReadOnly = True
        Me.dgv_Enf.RowHeadersVisible = False
        Me.dgv_Enf.RowTemplate.Height = 24
        Me.dgv_Enf.Size = New System.Drawing.Size(958, 369)
        Me.dgv_Enf.TabIndex = 34
        '
        'ID_Enf
        '
        Me.ID_Enf.DataPropertyName = "ID_Enf"
        Me.ID_Enf.HeaderText = "ID"
        Me.ID_Enf.Name = "ID_Enf"
        Me.ID_Enf.ReadOnly = True
        Me.ID_Enf.Visible = False
        '
        'Text
        '
        Me.Text.DataPropertyName = "Text"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Text.DefaultCellStyle = DataGridViewCellStyle3
        Me.Text.HeaderText = "Enfermedad"
        Me.Text.Name = "Text"
        Me.Text.ReadOnly = True
        Me.Text.Width = 1400
        '
        'txt_enfNAME
        '
        Me.txt_enfNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_enfNAME.Location = New System.Drawing.Point(140, 85)
        Me.txt_enfNAME.Name = "txt_enfNAME"
        Me.txt_enfNAME.Size = New System.Drawing.Size(209, 28)
        Me.txt_enfNAME.TabIndex = 28
        '
        'label47
        '
        Me.label47.AutoSize = True
        Me.label47.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label47.ForeColor = System.Drawing.Color.Black
        Me.label47.Location = New System.Drawing.Point(34, 90)
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
        Me.panel21.Size = New System.Drawing.Size(958, 40)
        Me.panel21.TabIndex = 0
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(13, 6)
        Me.label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(119, 21)
        Me.label19.TabIndex = 0
        Me.label19.Text = "Enfermedades"
        '
        'Tab_Cont
        '
        Me.Tab_Cont.Controls.Add(Me.panel18)
        Me.Tab_Cont.Location = New System.Drawing.Point(4, 30)
        Me.Tab_Cont.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Cont.Name = "Tab_Cont"
        Me.Tab_Cont.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Cont.Size = New System.Drawing.Size(950, 1066)
        Me.Tab_Cont.TabIndex = 3
        Me.Tab_Cont.Text = "Contacto"
        Me.Tab_Cont.UseVisualStyleBackColor = True
        '
        'panel18
        '
        Me.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel18.Controls.Add(Me.dgv_contacto)
        Me.panel18.Controls.Add(Me.label45)
        Me.panel18.Controls.Add(Me.txt_conPAREN)
        Me.panel18.Controls.Add(Me.label41)
        Me.panel18.Controls.Add(Me.txt_conCEL)
        Me.panel18.Controls.Add(Me.label40)
        Me.panel18.Controls.Add(Me.txt_conTEL)
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
        Me.panel18.Size = New System.Drawing.Size(962, 653)
        Me.panel18.TabIndex = 1
        '
        'dgv_contacto
        '
        Me.dgv_contacto.AllowUserToAddRows = False
        Me.dgv_contacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contacto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv_contacto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_contacto.Location = New System.Drawing.Point(0, 296)
        Me.dgv_contacto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_contacto.Name = "dgv_contacto"
        Me.dgv_contacto.ReadOnly = True
        Me.dgv_contacto.RowHeadersVisible = False
        Me.dgv_contacto.RowTemplate.Height = 24
        Me.dgv_contacto.Size = New System.Drawing.Size(958, 353)
        Me.dgv_contacto.TabIndex = 50
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ID_CEmergencia"
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ID_Emp"
        Me.Column4.HeaderText = "Empleado"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CE_Nombre"
        Me.Column5.HeaderText = "Nombre"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "CE_APat"
        Me.Column6.HeaderText = "Apellido Paterno"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CE_AMat"
        Me.Column7.HeaderText = "Apellido Materno"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "CE_Parentesco"
        Me.Column8.HeaderText = "Parentesco"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "CE_Telefono"
        Me.Column9.HeaderText = "Telefono"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 200
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CE_Celular"
        Me.Column10.HeaderText = "Celular"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 200
        '
        'label45
        '
        Me.label45.AutoSize = True
        Me.label45.Location = New System.Drawing.Point(375, 116)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(98, 21)
        Me.label45.TabIndex = 48
        Me.label45.Text = "Parentesco:"
        '
        'txt_conPAREN
        '
        Me.txt_conPAREN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conPAREN.Location = New System.Drawing.Point(479, 113)
        Me.txt_conPAREN.Name = "txt_conPAREN"
        Me.txt_conPAREN.Size = New System.Drawing.Size(209, 28)
        Me.txt_conPAREN.TabIndex = 47
        '
        'label41
        '
        Me.label41.AutoSize = True
        Me.label41.Location = New System.Drawing.Point(406, 82)
        Me.label41.Name = "label41"
        Me.label41.Size = New System.Drawing.Size(67, 21)
        Me.label41.TabIndex = 46
        Me.label41.Text = "Celular:"
        '
        'txt_conCEL
        '
        Me.txt_conCEL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conCEL.Location = New System.Drawing.Point(479, 79)
        Me.txt_conCEL.Name = "txt_conCEL"
        Me.txt_conCEL.Size = New System.Drawing.Size(209, 28)
        Me.txt_conCEL.TabIndex = 45
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Location = New System.Drawing.Point(392, 51)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(81, 21)
        Me.label40.TabIndex = 44
        Me.label40.Text = "Telefono:"
        '
        'txt_conTEL
        '
        Me.txt_conTEL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conTEL.Location = New System.Drawing.Point(479, 45)
        Me.txt_conTEL.Name = "txt_conTEL"
        Me.txt_conTEL.Size = New System.Drawing.Size(209, 28)
        Me.txt_conTEL.TabIndex = 43
        '
        'txt_conNAME
        '
        Me.txt_conNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conNAME.Location = New System.Drawing.Point(155, 113)
        Me.txt_conNAME.Name = "txt_conNAME"
        Me.txt_conNAME.Size = New System.Drawing.Size(209, 28)
        Me.txt_conNAME.TabIndex = 35
        '
        'txt_conAM
        '
        Me.txt_conAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conAM.Location = New System.Drawing.Point(155, 79)
        Me.txt_conAM.Name = "txt_conAM"
        Me.txt_conAM.Size = New System.Drawing.Size(209, 28)
        Me.txt_conAM.TabIndex = 34
        '
        'txt_conAP
        '
        Me.txt_conAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_conAP.Location = New System.Drawing.Point(155, 45)
        Me.txt_conAP.Name = "txt_conAP"
        Me.txt_conAP.Size = New System.Drawing.Size(209, 28)
        Me.txt_conAP.TabIndex = 33
        '
        'label42
        '
        Me.label42.AutoSize = True
        Me.label42.Location = New System.Drawing.Point(8, 51)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(141, 21)
        Me.label42.TabIndex = 37
        Me.label42.Text = "Apellido Paterno:"
        '
        'label43
        '
        Me.label43.AutoSize = True
        Me.label43.Location = New System.Drawing.Point(2, 82)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(147, 21)
        Me.label43.TabIndex = 38
        Me.label43.Text = "Apellido Materno:"
        '
        'label44
        '
        Me.label44.AutoSize = True
        Me.label44.Location = New System.Drawing.Point(55, 118)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(94, 21)
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
        Me.panel19.Size = New System.Drawing.Size(958, 40)
        Me.panel19.TabIndex = 0
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(13, 6)
        Me.label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(198, 21)
        Me.label18.TabIndex = 0
        Me.label18.Text = "Contacto de Emergencia"
        '
        'Tab_AL
        '
        Me.Tab_AL.Controls.Add(Me.panel16)
        Me.Tab_AL.Location = New System.Drawing.Point(4, 30)
        Me.Tab_AL.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_AL.Name = "Tab_AL"
        Me.Tab_AL.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_AL.Size = New System.Drawing.Size(950, 1066)
        Me.Tab_AL.TabIndex = 2
        Me.Tab_AL.Text = "Antecedentes Laborales"
        Me.Tab_AL.UseVisualStyleBackColor = True
        '
        'panel16
        '
        Me.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel16.Controls.Add(Me.dgv_ant)
        Me.panel16.Controls.Add(Me.txt_antMT)
        Me.panel16.Controls.Add(Me.txt_antNAME)
        Me.panel16.Controls.Add(Me.txt_antTEL)
        Me.panel16.Controls.Add(Me.label37)
        Me.panel16.Controls.Add(Me.label38)
        Me.panel16.Controls.Add(Me.label39)
        Me.panel16.Controls.Add(Me.txt_antSALARIO)
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
        Me.panel16.Size = New System.Drawing.Size(962, 653)
        Me.panel16.TabIndex = 1
        '
        'dgv_ant
        '
        Me.dgv_ant.AllowUserToAddRows = False
        Me.dgv_ant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Ant, Me.ID__Emp, Me.Ant_FInicio, Me.Ant_FFin, Me.Ant_NEmpresa, Me.Ant_Cargo, Me.Ant_Salario, Me.Ant_Tel, Me.Ant_Motivo, Me.Ant_Contacto})
        Me.dgv_ant.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_ant.Location = New System.Drawing.Point(0, 339)
        Me.dgv_ant.Name = "dgv_ant"
        Me.dgv_ant.RowHeadersVisible = False
        Me.dgv_ant.Size = New System.Drawing.Size(958, 310)
        Me.dgv_ant.TabIndex = 51
        '
        'ID_Ant
        '
        Me.ID_Ant.DataPropertyName = "ID_Ant"
        Me.ID_Ant.HeaderText = "ID"
        Me.ID_Ant.Name = "ID_Ant"
        Me.ID_Ant.Visible = False
        '
        'ID__Emp
        '
        Me.ID__Emp.DataPropertyName = "ID_Emp"
        Me.ID__Emp.HeaderText = "Empleado"
        Me.ID__Emp.Name = "ID__Emp"
        '
        'Ant_FInicio
        '
        Me.Ant_FInicio.DataPropertyName = "Ant_FInicio"
        Me.Ant_FInicio.HeaderText = "Fecha Inicio"
        Me.Ant_FInicio.Name = "Ant_FInicio"
        Me.Ant_FInicio.Width = 200
        '
        'Ant_FFin
        '
        Me.Ant_FFin.DataPropertyName = "Ant_FFin"
        Me.Ant_FFin.HeaderText = "Fecha Final"
        Me.Ant_FFin.Name = "Ant_FFin"
        Me.Ant_FFin.Width = 200
        '
        'Ant_NEmpresa
        '
        Me.Ant_NEmpresa.DataPropertyName = "Ant_NEmpresa"
        Me.Ant_NEmpresa.HeaderText = "Empresa"
        Me.Ant_NEmpresa.Name = "Ant_NEmpresa"
        '
        'Ant_Cargo
        '
        Me.Ant_Cargo.DataPropertyName = "Ant_Cargo"
        Me.Ant_Cargo.HeaderText = "Cargo"
        Me.Ant_Cargo.Name = "Ant_Cargo"
        '
        'Ant_Salario
        '
        Me.Ant_Salario.DataPropertyName = "Ant_Salario"
        Me.Ant_Salario.HeaderText = "Salario"
        Me.Ant_Salario.Name = "Ant_Salario"
        '
        'Ant_Tel
        '
        Me.Ant_Tel.DataPropertyName = "Ant_Tel"
        Me.Ant_Tel.HeaderText = "Telefono"
        Me.Ant_Tel.Name = "Ant_Tel"
        '
        'Ant_Motivo
        '
        Me.Ant_Motivo.DataPropertyName = "Ant_Motivo"
        Me.Ant_Motivo.HeaderText = "Motivo"
        Me.Ant_Motivo.Name = "Ant_Motivo"
        '
        'Ant_Contacto
        '
        Me.Ant_Contacto.DataPropertyName = "Ant_Contacto"
        Me.Ant_Contacto.HeaderText = "Contacto"
        Me.Ant_Contacto.Name = "Ant_Contacto"
        '
        'txt_antMT
        '
        Me.txt_antMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antMT.Location = New System.Drawing.Point(440, 113)
        Me.txt_antMT.Multiline = True
        Me.txt_antMT.Name = "txt_antMT"
        Me.txt_antMT.Size = New System.Drawing.Size(208, 47)
        Me.txt_antMT.TabIndex = 29
        '
        'txt_antNAME
        '
        Me.txt_antNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antNAME.Location = New System.Drawing.Point(439, 79)
        Me.txt_antNAME.Name = "txt_antNAME"
        Me.txt_antNAME.Size = New System.Drawing.Size(209, 28)
        Me.txt_antNAME.TabIndex = 28
        '
        'txt_antTEL
        '
        Me.txt_antTEL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antTEL.Location = New System.Drawing.Point(439, 46)
        Me.txt_antTEL.Name = "txt_antTEL"
        Me.txt_antTEL.Size = New System.Drawing.Size(209, 28)
        Me.txt_antTEL.TabIndex = 27
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Location = New System.Drawing.Point(358, 51)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(81, 21)
        Me.label37.TabIndex = 30
        Me.label37.Text = "Telefono:"
        '
        'label38
        '
        Me.label38.AutoSize = True
        Me.label38.Location = New System.Drawing.Point(357, 79)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(84, 21)
        Me.label38.TabIndex = 31
        Me.label38.Text = "Contacto:"
        '
        'label39
        '
        Me.label39.AutoSize = True
        Me.label39.Location = New System.Drawing.Point(369, 108)
        Me.label39.Name = "label39"
        Me.label39.Size = New System.Drawing.Size(68, 21)
        Me.label39.TabIndex = 32
        Me.label39.Text = "Motivo:"
        '
        'txt_antSALARIO
        '
        Me.txt_antSALARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antSALARIO.Location = New System.Drawing.Point(139, 181)
        Me.txt_antSALARIO.Name = "txt_antSALARIO"
        Me.txt_antSALARIO.Size = New System.Drawing.Size(208, 28)
        Me.txt_antSALARIO.TabIndex = 23
        '
        'txt_antCARGO
        '
        Me.txt_antCARGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antCARGO.Location = New System.Drawing.Point(138, 147)
        Me.txt_antCARGO.Name = "txt_antCARGO"
        Me.txt_antCARGO.Size = New System.Drawing.Size(209, 28)
        Me.txt_antCARGO.TabIndex = 22
        '
        'txt_antEMP
        '
        Me.txt_antEMP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_antEMP.Location = New System.Drawing.Point(138, 113)
        Me.txt_antEMP.Name = "txt_antEMP"
        Me.txt_antEMP.Size = New System.Drawing.Size(209, 28)
        Me.txt_antEMP.TabIndex = 21
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Location = New System.Drawing.Point(53, 116)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(79, 21)
        Me.label34.TabIndex = 24
        Me.label34.Text = "Empresa:"
        '
        'label35
        '
        Me.label35.AutoSize = True
        Me.label35.Location = New System.Drawing.Point(72, 150)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(60, 21)
        Me.label35.TabIndex = 25
        Me.label35.Text = "Cargo:"
        '
        'label36
        '
        Me.label36.AutoSize = True
        Me.label36.Location = New System.Drawing.Point(68, 184)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(65, 21)
        Me.label36.TabIndex = 26
        Me.label36.Text = "Salario:"
        '
        'txt_antFF
        '
        Me.txt_antFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_antFF.Location = New System.Drawing.Point(138, 79)
        Me.txt_antFF.Name = "txt_antFF"
        Me.txt_antFF.Size = New System.Drawing.Size(209, 28)
        Me.txt_antFF.TabIndex = 19
        '
        'label33
        '
        Me.label33.AutoSize = True
        Me.label33.Location = New System.Drawing.Point(8, 81)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(124, 21)
        Me.label33.TabIndex = 20
        Me.label33.Text = "Fecha de Final:"
        '
        'txt_antFI
        '
        Me.txt_antFI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_antFI.Location = New System.Drawing.Point(138, 45)
        Me.txt_antFI.Name = "txt_antFI"
        Me.txt_antFI.Size = New System.Drawing.Size(209, 28)
        Me.txt_antFI.TabIndex = 17
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(3, 49)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(129, 21)
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
        Me.panel17.Size = New System.Drawing.Size(958, 40)
        Me.panel17.TabIndex = 0
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(13, 6)
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
        Me.Tab_Familia.Location = New System.Drawing.Point(4, 30)
        Me.Tab_Familia.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_Familia.Name = "Tab_Familia"
        Me.Tab_Familia.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_Familia.Size = New System.Drawing.Size(950, 1066)
        Me.Tab_Familia.TabIndex = 1
        Me.Tab_Familia.Text = "Familia"
        Me.Tab_Familia.UseVisualStyleBackColor = True
        '
        'panel3
        '
        Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel3.Controls.Add(Me.dgv_Hijos)
        Me.panel3.Controls.Add(Me.txt_hijoEC)
        Me.panel3.Controls.Add(Me.label32)
        Me.panel3.Controls.Add(Me.label26)
        Me.panel3.Controls.Add(Me.txt_hijoNACION)
        Me.panel3.Controls.Add(Me.txt_hijoFN)
        Me.panel3.Controls.Add(Me.label27)
        Me.panel3.Controls.Add(Me.txt_hijoNAME)
        Me.panel3.Controls.Add(Me.txt_hijoAM)
        Me.panel3.Controls.Add(Me.txt_hijoAP)
        Me.panel3.Controls.Add(Me.label28)
        Me.panel3.Controls.Add(Me.label29)
        Me.panel3.Controls.Add(Me.txt_hijoSEXO)
        Me.panel3.Controls.Add(Me.label30)
        Me.panel3.Controls.Add(Me.label31)
        Me.panel3.Controls.Add(Me.panel5)
        Me.panel3.Location = New System.Drawing.Point(0, 262)
        Me.panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(962, 396)
        Me.panel3.TabIndex = 1
        '
        'dgv_Hijos
        '
        Me.dgv_Hijos.AllowUserToAddRows = False
        Me.dgv_Hijos.AllowUserToOrderColumns = True
        Me.dgv_Hijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Hijos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgv_Hijos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Hijos.Location = New System.Drawing.Point(0, 243)
        Me.dgv_Hijos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Hijos.Name = "dgv_Hijos"
        Me.dgv_Hijos.ReadOnly = True
        Me.dgv_Hijos.RowHeadersVisible = False
        Me.dgv_Hijos.RowTemplate.Height = 24
        Me.dgv_Hijos.Size = New System.Drawing.Size(958, 149)
        Me.dgv_Hijos.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Persona"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Emp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fam_Tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fam_Nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fam_APat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellido Paterno"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fam_AMat"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Apellido Materno"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fam_Nacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nacionalidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fam_FNac"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Nacimiento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fam_Genero"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Genero"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fam_EdoCivil"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado Civil"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'txt_hijoEC
        '
        Me.txt_hijoEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_hijoEC.FormattingEnabled = True
        Me.txt_hijoEC.Items.AddRange(New Object() {"SOLTERO", "CASADO", "DIVORCIADO", "VIUDO", "UNION LIBRE"})
        Me.txt_hijoEC.Location = New System.Drawing.Point(637, 63)
        Me.txt_hijoEC.Name = "txt_hijoEC"
        Me.txt_hijoEC.Size = New System.Drawing.Size(209, 29)
        Me.txt_hijoEC.TabIndex = 45
        '
        'label32
        '
        Me.label32.AutoSize = True
        Me.label32.Location = New System.Drawing.Point(530, 71)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(101, 21)
        Me.label32.TabIndex = 46
        Me.label32.Text = "Estado Civil:"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(518, 140)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(114, 21)
        Me.label26.TabIndex = 44
        Me.label26.Text = "Nacionalidad:"
        '
        'txt_hijoNACION
        '
        Me.txt_hijoNACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoNACION.Location = New System.Drawing.Point(637, 133)
        Me.txt_hijoNACION.Name = "txt_hijoNACION"
        Me.txt_hijoNACION.Size = New System.Drawing.Size(209, 28)
        Me.txt_hijoNACION.TabIndex = 43
        '
        'txt_hijoFN
        '
        Me.txt_hijoFN.Location = New System.Drawing.Point(249, 158)
        Me.txt_hijoFN.Name = "txt_hijoFN"
        Me.txt_hijoFN.Size = New System.Drawing.Size(209, 28)
        Me.txt_hijoFN.TabIndex = 41
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(67, 165)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(176, 21)
        Me.label27.TabIndex = 42
        Me.label27.Text = "Fecha de Nacimiento:"
        '
        'txt_hijoNAME
        '
        Me.txt_hijoNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoNAME.Location = New System.Drawing.Point(249, 124)
        Me.txt_hijoNAME.Name = "txt_hijoNAME"
        Me.txt_hijoNAME.Size = New System.Drawing.Size(209, 28)
        Me.txt_hijoNAME.TabIndex = 35
        '
        'txt_hijoAM
        '
        Me.txt_hijoAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoAM.Location = New System.Drawing.Point(249, 91)
        Me.txt_hijoAM.Name = "txt_hijoAM"
        Me.txt_hijoAM.Size = New System.Drawing.Size(209, 28)
        Me.txt_hijoAM.TabIndex = 34
        '
        'txt_hijoAP
        '
        Me.txt_hijoAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_hijoAP.Location = New System.Drawing.Point(249, 58)
        Me.txt_hijoAP.Name = "txt_hijoAP"
        Me.txt_hijoAP.Size = New System.Drawing.Size(209, 28)
        Me.txt_hijoAP.TabIndex = 33
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(102, 63)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(141, 21)
        Me.label28.TabIndex = 37
        Me.label28.Text = "Apellido Paterno:"
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Location = New System.Drawing.Point(96, 94)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(147, 21)
        Me.label29.TabIndex = 38
        Me.label29.Text = "Apellido Materno:"
        '
        'txt_hijoSEXO
        '
        Me.txt_hijoSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_hijoSEXO.FormattingEnabled = True
        Me.txt_hijoSEXO.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.txt_hijoSEXO.Location = New System.Drawing.Point(637, 98)
        Me.txt_hijoSEXO.Name = "txt_hijoSEXO"
        Me.txt_hijoSEXO.Size = New System.Drawing.Size(209, 29)
        Me.txt_hijoSEXO.TabIndex = 36
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(149, 131)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(94, 21)
        Me.label30.TabIndex = 39
        Me.label30.Text = "Nombre(s):"
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.Location = New System.Drawing.Point(582, 105)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(50, 21)
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
        Me.panel5.Size = New System.Drawing.Size(958, 40)
        Me.panel5.TabIndex = 1
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(13, 6)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(47, 21)
        Me.label11.TabIndex = 2
        Me.label11.Text = "Hijos"
        '
        'panel2
        '
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel2.Controls.Add(Me.panel4)
        Me.panel2.Controls.Add(Me.label25)
        Me.panel2.Controls.Add(Me.txt_esNacion)
        Me.panel2.Controls.Add(Me.dgv_esposa)
        Me.panel2.Controls.Add(Me.txt_esName)
        Me.panel2.Controls.Add(Me.txt_esAM)
        Me.panel2.Controls.Add(Me.txt_esFN)
        Me.panel2.Controls.Add(Me.txt_esAP)
        Me.panel2.Controls.Add(Me.label24)
        Me.panel2.Controls.Add(Me.label23)
        Me.panel2.Controls.Add(Me.label20)
        Me.panel2.Controls.Add(Me.label21)
        Me.panel2.Controls.Add(Me.cb_esSexo)
        Me.panel2.Controls.Add(Me.label22)
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(962, 258)
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
        Me.panel4.Size = New System.Drawing.Size(958, 40)
        Me.panel4.TabIndex = 1
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(13, 7)
        Me.label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(78, 21)
        Me.label10.TabIndex = 1
        Me.label10.Text = "Cónyuge"
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Location = New System.Drawing.Point(633, 82)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(114, 21)
        Me.label25.TabIndex = 32
        Me.label25.Text = "Nacionalidad:"
        '
        'txt_esNacion
        '
        Me.txt_esNacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esNacion.Location = New System.Drawing.Point(753, 79)
        Me.txt_esNacion.Name = "txt_esNacion"
        Me.txt_esNacion.Size = New System.Drawing.Size(200, 28)
        Me.txt_esNacion.TabIndex = 31
        '
        'dgv_esposa
        '
        Me.dgv_esposa.AllowUserToAddRows = False
        Me.dgv_esposa.AllowUserToOrderColumns = True
        Me.dgv_esposa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_esposa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Persona, Me.ID_Emp, Me.Fam_Tipo, Me.Fam_Nombre, Me.Fam_APat, Me.Fam_AMat, Me.Fam_Nacion, Me.Fam_FNac, Me.Fam_Genero, Me.Fam_EdoCivil})
        Me.dgv_esposa.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_esposa.Location = New System.Drawing.Point(0, 134)
        Me.dgv_esposa.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_esposa.Name = "dgv_esposa"
        Me.dgv_esposa.ReadOnly = True
        Me.dgv_esposa.RowHeadersVisible = False
        Me.dgv_esposa.RowTemplate.Height = 24
        Me.dgv_esposa.Size = New System.Drawing.Size(958, 120)
        Me.dgv_esposa.TabIndex = 51
        '
        'ID_Persona
        '
        Me.ID_Persona.DataPropertyName = "ID_Persona"
        Me.ID_Persona.HeaderText = "ID"
        Me.ID_Persona.Name = "ID_Persona"
        Me.ID_Persona.ReadOnly = True
        Me.ID_Persona.Visible = False
        '
        'ID_Emp
        '
        Me.ID_Emp.DataPropertyName = "ID_Emp"
        Me.ID_Emp.HeaderText = "Empleado"
        Me.ID_Emp.Name = "ID_Emp"
        Me.ID_Emp.ReadOnly = True
        '
        'Fam_Tipo
        '
        Me.Fam_Tipo.DataPropertyName = "Fam_Tipo"
        Me.Fam_Tipo.HeaderText = "Tipo"
        Me.Fam_Tipo.Name = "Fam_Tipo"
        Me.Fam_Tipo.ReadOnly = True
        '
        'Fam_Nombre
        '
        Me.Fam_Nombre.DataPropertyName = "Fam_Nombre"
        Me.Fam_Nombre.HeaderText = "Nombre"
        Me.Fam_Nombre.Name = "Fam_Nombre"
        Me.Fam_Nombre.ReadOnly = True
        '
        'Fam_APat
        '
        Me.Fam_APat.DataPropertyName = "Fam_APat"
        Me.Fam_APat.HeaderText = "Apellido Paterno"
        Me.Fam_APat.Name = "Fam_APat"
        Me.Fam_APat.ReadOnly = True
        Me.Fam_APat.Width = 150
        '
        'Fam_AMat
        '
        Me.Fam_AMat.DataPropertyName = "Fam_AMat"
        Me.Fam_AMat.HeaderText = "Apellido Materno"
        Me.Fam_AMat.Name = "Fam_AMat"
        Me.Fam_AMat.ReadOnly = True
        Me.Fam_AMat.Width = 150
        '
        'Fam_Nacion
        '
        Me.Fam_Nacion.DataPropertyName = "Fam_Nacion"
        Me.Fam_Nacion.HeaderText = "Nacionalidad"
        Me.Fam_Nacion.Name = "Fam_Nacion"
        Me.Fam_Nacion.ReadOnly = True
        '
        'Fam_FNac
        '
        Me.Fam_FNac.DataPropertyName = "Fam_FNac"
        Me.Fam_FNac.HeaderText = "Fecha Nacimiento"
        Me.Fam_FNac.Name = "Fam_FNac"
        Me.Fam_FNac.ReadOnly = True
        Me.Fam_FNac.Width = 150
        '
        'Fam_Genero
        '
        Me.Fam_Genero.DataPropertyName = "Fam_Genero"
        Me.Fam_Genero.HeaderText = "Genero"
        Me.Fam_Genero.Name = "Fam_Genero"
        Me.Fam_Genero.ReadOnly = True
        '
        'Fam_EdoCivil
        '
        Me.Fam_EdoCivil.DataPropertyName = "Fam_EdoCivil"
        Me.Fam_EdoCivil.HeaderText = "Estado Civil"
        Me.Fam_EdoCivil.Name = "Fam_EdoCivil"
        Me.Fam_EdoCivil.ReadOnly = True
        Me.Fam_EdoCivil.Width = 200
        '
        'txt_esName
        '
        Me.txt_esName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esName.Location = New System.Drawing.Point(103, 45)
        Me.txt_esName.Name = "txt_esName"
        Me.txt_esName.Size = New System.Drawing.Size(200, 28)
        Me.txt_esName.TabIndex = 18
        '
        'txt_esAM
        '
        Me.txt_esAM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esAM.Location = New System.Drawing.Point(753, 45)
        Me.txt_esAM.Name = "txt_esAM"
        Me.txt_esAM.Size = New System.Drawing.Size(200, 28)
        Me.txt_esAM.TabIndex = 17
        '
        'txt_esFN
        '
        Me.txt_esFN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_esFN.Location = New System.Drawing.Point(425, 79)
        Me.txt_esFN.Name = "txt_esFN"
        Me.txt_esFN.Size = New System.Drawing.Size(200, 28)
        Me.txt_esFN.TabIndex = 24
        '
        'txt_esAP
        '
        Me.txt_esAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_esAP.Location = New System.Drawing.Point(425, 45)
        Me.txt_esAP.Name = "txt_esAP"
        Me.txt_esAP.Size = New System.Drawing.Size(200, 28)
        Me.txt_esAP.TabIndex = 16
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(297, 82)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(122, 21)
        Me.label24.TabIndex = 25
        Me.label24.Text = "Fecha de Nac.:"
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(50, 82)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(50, 21)
        Me.label23.TabIndex = 23
        Me.label23.Text = "Sexo:"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(309, 48)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(110, 21)
        Me.label20.TabIndex = 20
        Me.label20.Text = "Apellido Pat.:"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(631, 48)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(116, 21)
        Me.label21.TabIndex = 21
        Me.label21.Text = "Apellido Mat.:"
        '
        'cb_esSexo
        '
        Me.cb_esSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_esSexo.FormattingEnabled = True
        Me.cb_esSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.cb_esSexo.Location = New System.Drawing.Point(103, 79)
        Me.cb_esSexo.Name = "cb_esSexo"
        Me.cb_esSexo.Size = New System.Drawing.Size(188, 29)
        Me.cb_esSexo.TabIndex = 19
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(3, 48)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(94, 21)
        Me.label22.TabIndex = 22
        Me.label22.Text = "Nombre(s):"
        '
        'Tab_DP
        '
        Me.Tab_DP.Controls.Add(Me.lbl_emp)
        Me.Tab_DP.Controls.Add(Me.pnl_estatus)
        Me.Tab_DP.Controls.Add(Me.pnl_cont)
        Me.Tab_DP.Controls.Add(Me.pnl_per)
        Me.Tab_DP.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_DP.Location = New System.Drawing.Point(4, 30)
        Me.Tab_DP.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab_DP.Name = "Tab_DP"
        Me.Tab_DP.Padding = New System.Windows.Forms.Padding(2)
        Me.Tab_DP.Size = New System.Drawing.Size(950, 1066)
        Me.Tab_DP.TabIndex = 0
        Me.Tab_DP.Text = "Datos Personales"
        Me.Tab_DP.UseVisualStyleBackColor = True
        '
        'lbl_emp
        '
        Me.lbl_emp.AutoSize = True
        Me.lbl_emp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_emp.Location = New System.Drawing.Point(842, 8)
        Me.lbl_emp.Name = "lbl_emp"
        Me.lbl_emp.Size = New System.Drawing.Size(0, 22)
        Me.lbl_emp.TabIndex = 40
        '
        'pnl_estatus
        '
        Me.pnl_estatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_estatus.Controls.Add(Me.CB_CLIENTE)
        Me.pnl_estatus.Controls.Add(Me.CB_PROV)
        Me.pnl_estatus.Controls.Add(Me.seg)
        Me.pnl_estatus.Controls.Add(Me.panel13)
        Me.pnl_estatus.Controls.Add(Me.commen)
        Me.pnl_estatus.Controls.Add(Me.txt_activo)
        Me.pnl_estatus.Controls.Add(Me.label8)
        Me.pnl_estatus.Controls.Add(Me.txt_baja)
        Me.pnl_estatus.Controls.Add(Me.Label6)
        Me.pnl_estatus.Controls.Add(Me.Label7)
        Me.pnl_estatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_estatus.Location = New System.Drawing.Point(0, 508)
        Me.pnl_estatus.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_estatus.Name = "pnl_estatus"
        Me.pnl_estatus.Size = New System.Drawing.Size(950, 196)
        Me.pnl_estatus.TabIndex = 34
        '
        'CB_CLIENTE
        '
        Me.CB_CLIENTE.AutoSize = True
        Me.CB_CLIENTE.Location = New System.Drawing.Point(537, 56)
        Me.CB_CLIENTE.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_CLIENTE.Name = "CB_CLIENTE"
        Me.CB_CLIENTE.Size = New System.Drawing.Size(186, 25)
        Me.CB_CLIENTE.TabIndex = 44
        Me.CB_CLIENTE.Text = "Notificacion Clientes"
        Me.CB_CLIENTE.UseVisualStyleBackColor = True
        '
        'CB_PROV
        '
        Me.CB_PROV.AutoSize = True
        Me.CB_PROV.Location = New System.Drawing.Point(537, 85)
        Me.CB_PROV.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_PROV.Name = "CB_PROV"
        Me.CB_PROV.Size = New System.Drawing.Size(204, 25)
        Me.CB_PROV.TabIndex = 43
        Me.CB_PROV.Text = "Notificacion Proveedor"
        Me.CB_PROV.UseVisualStyleBackColor = True
        '
        'seg
        '
        Me.seg.AutoSize = True
        Me.seg.Location = New System.Drawing.Point(727, 56)
        Me.seg.Margin = New System.Windows.Forms.Padding(2)
        Me.seg.Name = "seg"
        Me.seg.Size = New System.Drawing.Size(165, 25)
        Me.seg.TabIndex = 27
        Me.seg.Text = "Motivo Seguridad"
        Me.seg.UseVisualStyleBackColor = True
        '
        'panel13
        '
        Me.panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel13.Controls.Add(Me.label15)
        Me.panel13.Controls.Add(Me.ALTA)
        Me.panel13.Controls.Add(Me.BAJA)
        Me.panel13.Controls.Add(Me.lbl_ALTA)
        Me.panel13.Controls.Add(Me.LBL_BAJA)
        Me.panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel13.Location = New System.Drawing.Point(0, 0)
        Me.panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.panel13.Name = "panel13"
        Me.panel13.Size = New System.Drawing.Size(946, 40)
        Me.panel13.TabIndex = 0
        '
        'LBL_BAJA
        '
        Me.LBL_BAJA.AutoSize = True
        Me.LBL_BAJA.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BAJA.ForeColor = System.Drawing.Color.White
        Me.LBL_BAJA.Location = New System.Drawing.Point(833, 9)
        Me.LBL_BAJA.Name = "LBL_BAJA"
        Me.LBL_BAJA.Size = New System.Drawing.Size(53, 22)
        Me.LBL_BAJA.TabIndex = 45
        Me.LBL_BAJA.Text = "BAJA"
        Me.LBL_BAJA.Visible = False
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(13, 6)
        Me.label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 21)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Estatus"
        '
        'lbl_ALTA
        '
        Me.lbl_ALTA.AutoSize = True
        Me.lbl_ALTA.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ALTA.ForeColor = System.Drawing.Color.White
        Me.lbl_ALTA.Location = New System.Drawing.Point(833, 9)
        Me.lbl_ALTA.Name = "lbl_ALTA"
        Me.lbl_ALTA.Size = New System.Drawing.Size(53, 22)
        Me.lbl_ALTA.TabIndex = 37
        Me.lbl_ALTA.Text = "ALTA"
        Me.lbl_ALTA.Visible = False
        '
        'commen
        '
        Me.commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.commen.Location = New System.Drawing.Point(85, 88)
        Me.commen.Multiline = True
        Me.commen.Name = "commen"
        Me.commen.Size = New System.Drawing.Size(442, 84)
        Me.commen.TabIndex = 28
        '
        'txt_activo
        '
        Me.txt_activo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_activo.Enabled = False
        Me.txt_activo.Location = New System.Drawing.Point(85, 54)
        Me.txt_activo.Name = "txt_activo"
        Me.txt_activo.Size = New System.Drawing.Size(155, 28)
        Me.txt_activo.TabIndex = 25
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 88)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(73, 21)
        Me.label8.TabIndex = 38
        Me.label8.Text = "Motivo: "
        '
        'txt_baja
        '
        Me.txt_baja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_baja.Enabled = False
        Me.txt_baja.Location = New System.Drawing.Point(372, 54)
        Me.txt_baja.Name = "txt_baja"
        Me.txt_baja.Size = New System.Drawing.Size(155, 28)
        Me.txt_baja.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Activo: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha de Baja: "
        '
        'pnl_cont
        '
        Me.pnl_cont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_cont.Controls.Add(Me.buscar_depto)
        Me.pnl_cont.Controls.Add(Me.depto)
        Me.pnl_cont.Controls.Add(Me.depto2)
        Me.pnl_cont.Controls.Add(Me.Buscar_PUESTO)
        Me.pnl_cont.Controls.Add(Me.panel11)
        Me.pnl_cont.Controls.Add(Me.Buscar_tipo)
        Me.pnl_cont.Controls.Add(Me.lbl_ingreso)
        Me.pnl_cont.Controls.Add(Me.Txt_correo)
        Me.pnl_cont.Controls.Add(Me.lbl_clase)
        Me.pnl_cont.Controls.Add(Me.txt_tipo2)
        Me.pnl_cont.Controls.Add(Me.lbl_super)
        Me.pnl_cont.Controls.Add(Me.correo)
        Me.pnl_cont.Controls.Add(Me.txt_SALARY)
        Me.pnl_cont.Controls.Add(Me.lbl_puesto)
        Me.pnl_cont.Controls.Add(Me.txt_tipo)
        Me.pnl_cont.Controls.Add(Me.lbl_sali)
        Me.pnl_cont.Controls.Add(Me.txt_FECHAINGRESO)
        Me.pnl_cont.Controls.Add(Me.Buscar_Super)
        Me.pnl_cont.Controls.Add(Me.txt_PUESTO)
        Me.pnl_cont.Controls.Add(Me.txt_PUESTO2)
        Me.pnl_cont.Controls.Add(Me.txt_SUPER2)
        Me.pnl_cont.Controls.Add(Me.txt_SUPER)
        Me.pnl_cont.Controls.Add(Me.lbl_depto)
        Me.pnl_cont.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_cont.Location = New System.Drawing.Point(0, 355)
        Me.pnl_cont.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_cont.Name = "pnl_cont"
        Me.pnl_cont.Size = New System.Drawing.Size(948, 149)
        Me.pnl_cont.TabIndex = 33
        '
        'depto
        '
        Me.depto.Location = New System.Drawing.Point(686, 39)
        Me.depto.Name = "depto"
        Me.depto.Size = New System.Drawing.Size(37, 28)
        Me.depto.TabIndex = 22
        '
        'depto2
        '
        Me.depto2.Enabled = False
        Me.depto2.Location = New System.Drawing.Point(729, 39)
        Me.depto2.Name = "depto2"
        Me.depto2.Size = New System.Drawing.Size(171, 28)
        Me.depto2.TabIndex = 59
        Me.depto2.TabStop = False
        '
        'panel11
        '
        Me.panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel11.Controls.Add(Me.label14)
        Me.panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel11.Location = New System.Drawing.Point(0, 0)
        Me.panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(944, 35)
        Me.panel11.TabIndex = 0
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(13, 6)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(109, 21)
        Me.label14.TabIndex = 0
        Me.label14.Text = "Contratacion"
        '
        'lbl_ingreso
        '
        Me.lbl_ingreso.AutoSize = True
        Me.lbl_ingreso.Location = New System.Drawing.Point(8, 46)
        Me.lbl_ingreso.Name = "lbl_ingreso"
        Me.lbl_ingreso.Size = New System.Drawing.Size(71, 21)
        Me.lbl_ingreso.TabIndex = 11
        Me.lbl_ingreso.Text = "Ingreso:"
        '
        'Txt_correo
        '
        Me.Txt_correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_correo.Location = New System.Drawing.Point(85, 108)
        Me.Txt_correo.Name = "Txt_correo"
        Me.Txt_correo.Size = New System.Drawing.Size(422, 28)
        Me.Txt_correo.TabIndex = 23
        '
        'lbl_clase
        '
        Me.lbl_clase.AutoSize = True
        Me.lbl_clase.Location = New System.Drawing.Point(327, 77)
        Me.lbl_clase.Name = "lbl_clase"
        Me.lbl_clase.Size = New System.Drawing.Size(47, 21)
        Me.lbl_clase.TabIndex = 24
        Me.lbl_clase.Text = "Tipo:"
        '
        'txt_tipo2
        '
        Me.txt_tipo2.Enabled = False
        Me.txt_tipo2.Location = New System.Drawing.Point(423, 74)
        Me.txt_tipo2.Name = "txt_tipo2"
        Me.txt_tipo2.Size = New System.Drawing.Size(130, 28)
        Me.txt_tipo2.TabIndex = 56
        Me.txt_tipo2.TabStop = False
        '
        'lbl_super
        '
        Me.lbl_super.AutoSize = True
        Me.lbl_super.Location = New System.Drawing.Point(9, 77)
        Me.lbl_super.Name = "lbl_super"
        Me.lbl_super.Size = New System.Drawing.Size(70, 21)
        Me.lbl_super.TabIndex = 23
        Me.lbl_super.Text = "Superv.:"
        '
        'correo
        '
        Me.correo.AutoSize = True
        Me.correo.Location = New System.Drawing.Point(17, 111)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(62, 21)
        Me.correo.TabIndex = 55
        Me.correo.Text = "E-mail:"
        '
        'txt_SALARY
        '
        Me.txt_SALARY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SALARY.Location = New System.Drawing.Point(687, 71)
        Me.txt_SALARY.Name = "txt_SALARY"
        Me.txt_SALARY.Size = New System.Drawing.Size(213, 28)
        Me.txt_SALARY.TabIndex = 21
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_puesto.Location = New System.Drawing.Point(310, 46)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(66, 21)
        Me.lbl_puesto.TabIndex = 16
        Me.lbl_puesto.Text = "Puesto:"
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(380, 74)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(37, 28)
        Me.txt_tipo.TabIndex = 25
        '
        'lbl_sali
        '
        Me.lbl_sali.AutoSize = True
        Me.lbl_sali.Location = New System.Drawing.Point(615, 77)
        Me.lbl_sali.Name = "lbl_sali"
        Me.lbl_sali.Size = New System.Drawing.Size(65, 21)
        Me.lbl_sali.TabIndex = 19
        Me.lbl_sali.Text = "Salario:"
        '
        'txt_FECHAINGRESO
        '
        Me.txt_FECHAINGRESO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_FECHAINGRESO.Location = New System.Drawing.Point(85, 40)
        Me.txt_FECHAINGRESO.Name = "txt_FECHAINGRESO"
        Me.txt_FECHAINGRESO.Size = New System.Drawing.Size(209, 28)
        Me.txt_FECHAINGRESO.TabIndex = 19
        '
        'txt_PUESTO
        '
        Me.txt_PUESTO.Location = New System.Drawing.Point(383, 40)
        Me.txt_PUESTO.Name = "txt_PUESTO"
        Me.txt_PUESTO.Size = New System.Drawing.Size(37, 28)
        Me.txt_PUESTO.TabIndex = 20
        '
        'txt_PUESTO2
        '
        Me.txt_PUESTO2.Enabled = False
        Me.txt_PUESTO2.Location = New System.Drawing.Point(426, 40)
        Me.txt_PUESTO2.Name = "txt_PUESTO2"
        Me.txt_PUESTO2.Size = New System.Drawing.Size(127, 28)
        Me.txt_PUESTO2.TabIndex = 41
        Me.txt_PUESTO2.TabStop = False
        '
        'txt_SUPER2
        '
        Me.txt_SUPER2.Enabled = False
        Me.txt_SUPER2.Location = New System.Drawing.Point(128, 74)
        Me.txt_SUPER2.Name = "txt_SUPER2"
        Me.txt_SUPER2.Size = New System.Drawing.Size(130, 28)
        Me.txt_SUPER2.TabIndex = 53
        Me.txt_SUPER2.TabStop = False
        '
        'txt_SUPER
        '
        Me.txt_SUPER.Location = New System.Drawing.Point(85, 74)
        Me.txt_SUPER.Name = "txt_SUPER"
        Me.txt_SUPER.Size = New System.Drawing.Size(37, 28)
        Me.txt_SUPER.TabIndex = 24
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.Location = New System.Drawing.Point(619, 43)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(61, 21)
        Me.lbl_depto.TabIndex = 18
        Me.lbl_depto.Text = "Depto:"
        '
        'pnl_per
        '
        Me.pnl_per.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_per.Controls.Add(Me.buscar_ciudad)
        Me.pnl_per.Controls.Add(Me.foto)
        Me.pnl_per.Controls.Add(Me.cuidad)
        Me.pnl_per.Controls.Add(Me.lbl_rfc)
        Me.pnl_per.Controls.Add(Me.lbl_ss)
        Me.pnl_per.Controls.Add(Me.CP)
        Me.pnl_per.Controls.Add(Me.LBL_CP)
        Me.pnl_per.Controls.Add(Me.txt_CURP)
        Me.pnl_per.Controls.Add(Me.cuidad2)
        Me.pnl_per.Controls.Add(Me.EC)
        Me.pnl_per.Controls.Add(Me.Label92)
        Me.pnl_per.Controls.Add(Me.txt_SS)
        Me.pnl_per.Controls.Add(Me.ddl_educacion)
        Me.pnl_per.Controls.Add(Me.Label54)
        Me.pnl_per.Controls.Add(Me.lbl_curp)
        Me.pnl_per.Controls.Add(Me.Label1)
        Me.pnl_per.Controls.Add(Me.colonia)
        Me.pnl_per.Controls.Add(Me.Label55)
        Me.pnl_per.Controls.Add(Me.domicilio)
        Me.pnl_per.Controls.Add(Me.Label2)
        Me.pnl_per.Controls.Add(Me.txt_RFC)
        Me.pnl_per.Controls.Add(Me.Celular)
        Me.pnl_per.Controls.Add(Me.Label4)
        Me.pnl_per.Controls.Add(Me.lbl_sex)
        Me.pnl_per.Controls.Add(Me.txt_telefono)
        Me.pnl_per.Controls.Add(Me.LBL_ESTADOCIVIL)
        Me.pnl_per.Controls.Add(Me.lbl_fn)
        Me.pnl_per.Controls.Add(Me.nacion)
        Me.pnl_per.Controls.Add(Me.Label3)
        Me.pnl_per.Controls.Add(Me.txt_FECHA)
        Me.pnl_per.Controls.Add(Me.CB_SEXO)
        Me.pnl_per.Controls.Add(Me.lbl_nac)
        Me.pnl_per.Controls.Add(Me.panel7)
        Me.pnl_per.Controls.Add(Me.txt_EN2)
        Me.pnl_per.Controls.Add(Me.txt_numero)
        Me.pnl_per.Controls.Add(Me.txt_EN)
        Me.pnl_per.Controls.Add(Me.txt_NOM)
        Me.pnl_per.Controls.Add(Me.txt_AM)
        Me.pnl_per.Controls.Add(Me.txt_AP)
        Me.pnl_per.Controls.Add(Me.buscar_EN)
        Me.pnl_per.Controls.Add(Me.lbl_num)
        Me.pnl_per.Controls.Add(Me.lbl_ap)
        Me.pnl_per.Controls.Add(Me.lbl_am)
        Me.pnl_per.Controls.Add(Me.lbl_nom)
        Me.pnl_per.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_per.Location = New System.Drawing.Point(0, 0)
        Me.pnl_per.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_per.Name = "pnl_per"
        Me.pnl_per.Size = New System.Drawing.Size(950, 351)
        Me.pnl_per.TabIndex = 31
        '
        'cuidad
        '
        Me.cuidad.Location = New System.Drawing.Point(317, 314)
        Me.cuidad.Name = "cuidad"
        Me.cuidad.Size = New System.Drawing.Size(39, 28)
        Me.cuidad.TabIndex = 8
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.Location = New System.Drawing.Point(624, 185)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(56, 21)
        Me.lbl_rfc.TabIndex = 19
        Me.lbl_rfc.Text = "R.F.C.:"
        '
        'lbl_ss
        '
        Me.lbl_ss.AutoSize = True
        Me.lbl_ss.Location = New System.Drawing.Point(583, 217)
        Me.lbl_ss.Name = "lbl_ss"
        Me.lbl_ss.Size = New System.Drawing.Size(97, 21)
        Me.lbl_ss.TabIndex = 20
        Me.lbl_ss.Text = "# Seg. Soc.:"
        '
        'CP
        '
        Me.CP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CP.Location = New System.Drawing.Point(686, 316)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(250, 28)
        Me.CP.TabIndex = 18
        '
        'LBL_CP
        '
        Me.LBL_CP.AutoSize = True
        Me.LBL_CP.Location = New System.Drawing.Point(637, 319)
        Me.LBL_CP.Name = "LBL_CP"
        Me.LBL_CP.Size = New System.Drawing.Size(43, 21)
        Me.LBL_CP.TabIndex = 34
        Me.LBL_CP.Text = "C.p.:"
        '
        'txt_CURP
        '
        Me.txt_CURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CURP.Location = New System.Drawing.Point(314, 214)
        Me.txt_CURP.Name = "txt_CURP"
        Me.txt_CURP.Size = New System.Drawing.Size(250, 28)
        Me.txt_CURP.TabIndex = 11
        '
        'cuidad2
        '
        Me.cuidad2.Enabled = False
        Me.cuidad2.Location = New System.Drawing.Point(359, 314)
        Me.cuidad2.Name = "cuidad2"
        Me.cuidad2.Size = New System.Drawing.Size(168, 28)
        Me.cuidad2.TabIndex = 60
        Me.cuidad2.TabStop = False
        '
        'EC
        '
        Me.EC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EC.FormattingEnabled = True
        Me.EC.Items.AddRange(New Object() {"SOLTERO", "CASADO", "DIVORCIADO", "VIUDO", "UNION LIBRE"})
        Me.EC.Location = New System.Drawing.Point(314, 179)
        Me.EC.Name = "EC"
        Me.EC.Size = New System.Drawing.Size(250, 29)
        Me.EC.TabIndex = 14
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(243, 321)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(68, 21)
        Me.Label92.TabIndex = 59
        Me.Label92.Text = "Ciudad:"
        '
        'txt_SS
        '
        Me.txt_SS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SS.Location = New System.Drawing.Point(686, 214)
        Me.txt_SS.Name = "txt_SS"
        Me.txt_SS.Size = New System.Drawing.Size(250, 28)
        Me.txt_SS.TabIndex = 10
        '
        'ddl_educacion
        '
        Me.ddl_educacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl_educacion.FormattingEnabled = True
        Me.ddl_educacion.Items.AddRange(New Object() {"PRIMARIA", "SECUNDARIA", "PREPARATOIA", "LICENCIATURA"})
        Me.ddl_educacion.Location = New System.Drawing.Point(686, 145)
        Me.ddl_educacion.Name = "ddl_educacion"
        Me.ddl_educacion.Size = New System.Drawing.Size(250, 29)
        Me.ddl_educacion.TabIndex = 5
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(591, 150)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(92, 21)
        Me.Label54.TabIndex = 54
        Me.Label54.Text = "Educacion:"
        '
        'lbl_curp
        '
        Me.lbl_curp.AutoSize = True
        Me.lbl_curp.Location = New System.Drawing.Point(235, 217)
        Me.lbl_curp.Name = "lbl_curp"
        Me.lbl_curp.Size = New System.Drawing.Size(73, 21)
        Me.lbl_curp.TabIndex = 21
        Me.lbl_curp.Text = "C.U.R.P.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(608, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Colonia:"
        '
        'colonia
        '
        Me.colonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.colonia.Location = New System.Drawing.Point(686, 282)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(250, 28)
        Me.colonia.TabIndex = 17
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(584, 251)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(96, 21)
        Me.Label55.TabIndex = 57
        Me.Label55.Text = "# Telefono:"
        '
        'domicilio
        '
        Me.domicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.domicilio.Location = New System.Drawing.Point(314, 282)
        Me.domicilio.Name = "domicilio"
        Me.domicilio.Size = New System.Drawing.Size(250, 28)
        Me.domicilio.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Domicilio:"
        '
        'txt_RFC
        '
        Me.txt_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RFC.Location = New System.Drawing.Point(686, 180)
        Me.txt_RFC.Name = "txt_RFC"
        Me.txt_RFC.Size = New System.Drawing.Size(250, 28)
        Me.txt_RFC.TabIndex = 9
        '
        'Celular
        '
        Me.Celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Celular.Location = New System.Drawing.Point(314, 248)
        Me.Celular.Name = "Celular"
        Me.Celular.Size = New System.Drawing.Size(250, 28)
        Me.Celular.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "# Celular:"
        '
        'lbl_sex
        '
        Me.lbl_sex.AutoSize = True
        Me.lbl_sex.Location = New System.Drawing.Point(630, 80)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(50, 21)
        Me.lbl_sex.TabIndex = 15
        Me.lbl_sex.Text = "Sexo:"
        '
        'txt_telefono
        '
        Me.txt_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_telefono.Location = New System.Drawing.Point(686, 249)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(250, 28)
        Me.txt_telefono.TabIndex = 13
        '
        'LBL_ESTADOCIVIL
        '
        Me.LBL_ESTADOCIVIL.AutoSize = True
        Me.LBL_ESTADOCIVIL.Location = New System.Drawing.Point(207, 182)
        Me.LBL_ESTADOCIVIL.Name = "LBL_ESTADOCIVIL"
        Me.LBL_ESTADOCIVIL.Size = New System.Drawing.Size(101, 21)
        Me.LBL_ESTADOCIVIL.TabIndex = 25
        Me.LBL_ESTADOCIVIL.Text = "Estado Civil:"
        '
        'lbl_fn
        '
        Me.lbl_fn.AutoSize = True
        Me.lbl_fn.Location = New System.Drawing.Point(182, 117)
        Me.lbl_fn.Name = "lbl_fn"
        Me.lbl_fn.Size = New System.Drawing.Size(126, 21)
        Me.lbl_fn.TabIndex = 16
        Me.lbl_fn.Text = "Fecha de Naci.:"
        '
        'nacion
        '
        Me.nacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nacion.Location = New System.Drawing.Point(686, 110)
        Me.nacion.Name = "nacion"
        Me.nacion.Size = New System.Drawing.Size(250, 28)
        Me.nacion.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(566, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nacionalidad:"
        '
        'txt_FECHA
        '
        Me.txt_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_FECHA.Location = New System.Drawing.Point(314, 111)
        Me.txt_FECHA.Name = "txt_FECHA"
        Me.txt_FECHA.Size = New System.Drawing.Size(250, 28)
        Me.txt_FECHA.TabIndex = 6
        '
        'CB_SEXO
        '
        Me.CB_SEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SEXO.FormattingEnabled = True
        Me.CB_SEXO.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.CB_SEXO.Location = New System.Drawing.Point(686, 77)
        Me.CB_SEXO.Name = "CB_SEXO"
        Me.CB_SEXO.Size = New System.Drawing.Size(250, 29)
        Me.CB_SEXO.TabIndex = 4
        '
        'lbl_nac
        '
        Me.lbl_nac.AutoSize = True
        Me.lbl_nac.Location = New System.Drawing.Point(194, 148)
        Me.lbl_nac.Name = "lbl_nac"
        Me.lbl_nac.Size = New System.Drawing.Size(114, 21)
        Me.lbl_nac.TabIndex = 18
        Me.lbl_nac.Text = "Enti. de Naci.:"
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panel7.Controls.Add(Me.label12)
        Me.panel7.Controls.Add(Me.pnl_save)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel7.Location = New System.Drawing.Point(0, 0)
        Me.panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(946, 40)
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
        Me.label12.Size = New System.Drawing.Size(91, 21)
        Me.label12.TabIndex = 0
        Me.label12.Text = "Personales"
        '
        'pnl_save
        '
        Me.pnl_save.Controls.Add(Me.CANCEL)
        Me.pnl_save.Controls.Add(Me.SAVE)
        Me.pnl_save.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_save.Location = New System.Drawing.Point(693, 0)
        Me.pnl_save.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_save.Name = "pnl_save"
        Me.pnl_save.Size = New System.Drawing.Size(267, 40)
        Me.pnl_save.TabIndex = 35
        '
        'txt_EN2
        '
        Me.txt_EN2.Enabled = False
        Me.txt_EN2.Location = New System.Drawing.Point(359, 145)
        Me.txt_EN2.Name = "txt_EN2"
        Me.txt_EN2.Size = New System.Drawing.Size(169, 28)
        Me.txt_EN2.TabIndex = 22
        Me.txt_EN2.TabStop = False
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(85, 43)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(101, 28)
        Me.txt_numero.TabIndex = 0
        '
        'txt_EN
        '
        Me.txt_EN.Location = New System.Drawing.Point(314, 145)
        Me.txt_EN.Name = "txt_EN"
        Me.txt_EN.Size = New System.Drawing.Size(39, 28)
        Me.txt_EN.TabIndex = 7
        '
        'txt_NOM
        '
        Me.txt_NOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NOM.Location = New System.Drawing.Point(314, 43)
        Me.txt_NOM.Name = "txt_NOM"
        Me.txt_NOM.Size = New System.Drawing.Size(250, 28)
        Me.txt_NOM.TabIndex = 3
        '
        'txt_AM
        '
        Me.txt_AM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AM.Location = New System.Drawing.Point(314, 77)
        Me.txt_AM.Name = "txt_AM"
        Me.txt_AM.Size = New System.Drawing.Size(250, 28)
        Me.txt_AM.TabIndex = 2
        '
        'txt_AP
        '
        Me.txt_AP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AP.Location = New System.Drawing.Point(686, 43)
        Me.txt_AP.Name = "txt_AP"
        Me.txt_AP.Size = New System.Drawing.Size(250, 28)
        Me.txt_AP.TabIndex = 1
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Location = New System.Drawing.Point(2, 46)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(77, 21)
        Me.lbl_num.TabIndex = 11
        Me.lbl_num.Text = "Numero:"
        '
        'lbl_ap
        '
        Me.lbl_ap.AutoSize = True
        Me.lbl_ap.Location = New System.Drawing.Point(570, 46)
        Me.lbl_ap.Name = "lbl_ap"
        Me.lbl_ap.Size = New System.Drawing.Size(110, 21)
        Me.lbl_ap.TabIndex = 12
        Me.lbl_ap.Text = "Apellido Pat.:"
        '
        'lbl_am
        '
        Me.lbl_am.AutoSize = True
        Me.lbl_am.Location = New System.Drawing.Point(192, 80)
        Me.lbl_am.Name = "lbl_am"
        Me.lbl_am.Size = New System.Drawing.Size(116, 21)
        Me.lbl_am.TabIndex = 13
        Me.lbl_am.Text = "Apellido Mat.:"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(214, 46)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(94, 21)
        Me.lbl_nom.TabIndex = 14
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
        Me.MenuEmp.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEmp.Location = New System.Drawing.Point(0, 0)
        Me.MenuEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuEmp.Name = "MenuEmp"
        Me.MenuEmp.SelectedIndex = 0
        Me.MenuEmp.Size = New System.Drawing.Size(958, 1100)
        Me.MenuEmp.TabIndex = 1
        '
        'PnlTransporte
        '
        Me.PnlTransporte.Controls.Add(Me.Panel22)
        Me.PnlTransporte.Controls.Add(Me.cb_Metro)
        Me.PnlTransporte.Controls.Add(Me.cb_Trans)
        Me.PnlTransporte.Controls.Add(Me.cb_Taxi)
        Me.PnlTransporte.Controls.Add(Me.cb_Vehi)
        Me.PnlTransporte.Location = New System.Drawing.Point(0, 314)
        Me.PnlTransporte.Name = "PnlTransporte"
        Me.PnlTransporte.Size = New System.Drawing.Size(485, 110)
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
        Me.Panel22.Size = New System.Drawing.Size(485, 40)
        Me.Panel22.TabIndex = 2
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(13, 6)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(92, 21)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Transporte"
        '
        'ALTA
        '
        Me.ALTA.Image = Global.AdminEmpleados.My.Resources.Resources.Alta_80px
        Me.ALTA.Location = New System.Drawing.Point(892, 0)
        Me.ALTA.Name = "ALTA"
        Me.ALTA.Size = New System.Drawing.Size(45, 40)
        Me.ALTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ALTA.TabIndex = 24
        Me.ALTA.TabStop = False
        Me.ALTA.Visible = False
        '
        'BAJA
        '
        Me.BAJA.Image = Global.AdminEmpleados.My.Resources.Resources.Baja_80px
        Me.BAJA.Location = New System.Drawing.Point(892, 0)
        Me.BAJA.Name = "BAJA"
        Me.BAJA.Size = New System.Drawing.Size(45, 40)
        Me.BAJA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BAJA.TabIndex = 41
        Me.BAJA.TabStop = False
        Me.BAJA.Visible = False
        '
        'buscar_depto
        '
        Me.buscar_depto.BackgroundImage = CType(resources.GetObject("buscar_depto.BackgroundImage"), System.Drawing.Image)
        Me.buscar_depto.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_depto.Location = New System.Drawing.Point(906, 39)
        Me.buscar_depto.Name = "buscar_depto"
        Me.buscar_depto.Size = New System.Drawing.Size(30, 28)
        Me.buscar_depto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_depto.TabIndex = 60
        Me.buscar_depto.TabStop = False
        '
        'Buscar_PUESTO
        '
        Me.Buscar_PUESTO.BackgroundImage = CType(resources.GetObject("Buscar_PUESTO.BackgroundImage"), System.Drawing.Image)
        Me.Buscar_PUESTO.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_PUESTO.Location = New System.Drawing.Point(559, 40)
        Me.Buscar_PUESTO.Name = "Buscar_PUESTO"
        Me.Buscar_PUESTO.Size = New System.Drawing.Size(30, 28)
        Me.Buscar_PUESTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_PUESTO.TabIndex = 57
        Me.Buscar_PUESTO.TabStop = False
        '
        'Buscar_tipo
        '
        Me.Buscar_tipo.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_tipo.Location = New System.Drawing.Point(558, 74)
        Me.Buscar_tipo.Name = "Buscar_tipo"
        Me.Buscar_tipo.Size = New System.Drawing.Size(30, 28)
        Me.Buscar_tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_tipo.TabIndex = 54
        Me.Buscar_tipo.TabStop = False
        '
        'Buscar_Super
        '
        Me.Buscar_Super.BackgroundImage = CType(resources.GetObject("Buscar_Super.BackgroundImage"), System.Drawing.Image)
        Me.Buscar_Super.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.Buscar_Super.Location = New System.Drawing.Point(264, 74)
        Me.Buscar_Super.Name = "Buscar_Super"
        Me.Buscar_Super.Size = New System.Drawing.Size(30, 28)
        Me.Buscar_Super.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buscar_Super.TabIndex = 51
        Me.Buscar_Super.TabStop = False
        '
        'buscar_ciudad
        '
        Me.buscar_ciudad.BackgroundImage = CType(resources.GetObject("buscar_ciudad.BackgroundImage"), System.Drawing.Image)
        Me.buscar_ciudad.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_ciudad.Location = New System.Drawing.Point(534, 314)
        Me.buscar_ciudad.Name = "buscar_ciudad"
        Me.buscar_ciudad.Size = New System.Drawing.Size(30, 28)
        Me.buscar_ciudad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_ciudad.TabIndex = 61
        Me.buscar_ciudad.TabStop = False
        '
        'foto
        '
        Me.foto.Image = Global.AdminEmpleados.My.Resources.Resources.photoNobody120
        Me.foto.Location = New System.Drawing.Point(6, 77)
        Me.foto.Name = "foto"
        Me.foto.Size = New System.Drawing.Size(180, 200)
        Me.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto.TabIndex = 29
        Me.foto.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.CANCEL.Location = New System.Drawing.Point(199, 0)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(45, 40)
        Me.CANCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CANCEL.TabIndex = 1
        Me.CANCEL.TabStop = False
        '
        'SAVE
        '
        Me.SAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.SAVE.Location = New System.Drawing.Point(148, 0)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(45, 40)
        Me.SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAVE.TabIndex = 0
        Me.SAVE.TabStop = False
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(534, 145)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(30, 28)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 52
        Me.buscar_EN.TabStop = False
        '
        'btn_hijoADD
        '
        Me.btn_hijoADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Family_80px
        Me.btn_hijoADD.Location = New System.Drawing.Point(892, 0)
        Me.btn_hijoADD.Name = "btn_hijoADD"
        Me.btn_hijoADD.Size = New System.Drawing.Size(45, 40)
        Me.btn_hijoADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_hijoADD.TabIndex = 53
        Me.btn_hijoADD.TabStop = False
        '
        'btn_esSAVE
        '
        Me.btn_esSAVE.Image = Global.AdminEmpleados.My.Resources.Resources.Add_marriage_80px
        Me.btn_esSAVE.Location = New System.Drawing.Point(892, 0)
        Me.btn_esSAVE.Name = "btn_esSAVE"
        Me.btn_esSAVE.Size = New System.Drawing.Size(45, 40)
        Me.btn_esSAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_esSAVE.TabIndex = 52
        Me.btn_esSAVE.TabStop = False
        '
        'btn_antSave
        '
        Me.btn_antSave.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Job_80px
        Me.btn_antSave.Location = New System.Drawing.Point(892, 0)
        Me.btn_antSave.Name = "btn_antSave"
        Me.btn_antSave.Size = New System.Drawing.Size(45, 40)
        Me.btn_antSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_antSave.TabIndex = 54
        Me.btn_antSave.TabStop = False
        '
        'btn_conADD
        '
        Me.btn_conADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Contact_80px
        Me.btn_conADD.Location = New System.Drawing.Point(892, 0)
        Me.btn_conADD.Name = "btn_conADD"
        Me.btn_conADD.Size = New System.Drawing.Size(45, 40)
        Me.btn_conADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_conADD.TabIndex = 55
        Me.btn_conADD.TabStop = False
        '
        'btn_enfADD
        '
        Me.btn_enfADD.Image = Global.AdminEmpleados.My.Resources.Resources.Add_MedicalCondition_80px
        Me.btn_enfADD.Location = New System.Drawing.Point(892, 0)
        Me.btn_enfADD.Name = "btn_enfADD"
        Me.btn_enfADD.Size = New System.Drawing.Size(45, 40)
        Me.btn_enfADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_enfADD.TabIndex = 46
        Me.btn_enfADD.TabStop = False
        '
        'btn_OI
        '
        Me.btn_OI.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Income_80px
        Me.btn_OI.Location = New System.Drawing.Point(846, 0)
        Me.btn_OI.Name = "btn_OI"
        Me.btn_OI.Size = New System.Drawing.Size(45, 40)
        Me.btn_OI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_OI.TabIndex = 55
        Me.btn_OI.TabStop = False
        '
        'PB_IMAGE_VIVIENDA
        '
        Me.PB_IMAGE_VIVIENDA.Image = Global.AdminEmpleados.My.Resources.Resources.AddImage
        Me.PB_IMAGE_VIVIENDA.Location = New System.Drawing.Point(6, 40)
        Me.PB_IMAGE_VIVIENDA.Name = "PB_IMAGE_VIVIENDA"
        Me.PB_IMAGE_VIVIENDA.Size = New System.Drawing.Size(450, 262)
        Me.PB_IMAGE_VIVIENDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_IMAGE_VIVIENDA.TabIndex = 32
        Me.PB_IMAGE_VIVIENDA.TabStop = False
        '
        'datosFamiliaBindingSource
        '
        Me.datosFamiliaBindingSource.DataMember = "Datos_Familia"
        '
        'PnlActividades
        '
        Me.PnlActividades.Controls.Add(Me.Label90)
        Me.PnlActividades.Controls.Add(Me.Label88)
        Me.PnlActividades.Controls.Add(Me.txt_se_diversiones)
        Me.PnlActividades.Controls.Add(Me.txt_SE_NATURALES)
        Me.PnlActividades.Controls.Add(Me.Label89)
        Me.PnlActividades.Controls.Add(Me.txt_SE_PLAZAS)
        Me.PnlActividades.Controls.Add(Me.Label83)
        Me.PnlActividades.Controls.Add(Me.txt_SE_CINES)
        Me.PnlActividades.Controls.Add(Me.txt_SE_ZONAS)
        Me.PnlActividades.Controls.Add(Me.Label85)
        Me.PnlActividades.Controls.Add(Me.Label87)
        Me.PnlActividades.Controls.Add(Me.txt_SE_CULTURALES)
        Me.PnlActividades.Controls.Add(Me.Label80)
        Me.PnlActividades.Controls.Add(Me.txt_SE_TEATROS)
        Me.PnlActividades.Controls.Add(Me.Label86)
        Me.PnlActividades.Controls.Add(Me.Label81)
        Me.PnlActividades.Controls.Add(Me.txt_SE_MUSEOS)
        Me.PnlActividades.Controls.Add(Me.txt_SE_VACIONES)
        Me.PnlActividades.Controls.Add(Me.Label78)
        Me.PnlActividades.Controls.Add(Me.txt_SE__SOCIALE)
        Me.PnlActividades.Controls.Add(Me.txt_SE_EVENTOS)
        Me.PnlActividades.Controls.Add(Me.Label79)
        Me.PnlActividades.Controls.Add(Me.Panel36)
        Me.PnlActividades.Location = New System.Drawing.Point(0, 430)
        Me.PnlActividades.Name = "PnlActividades"
        Me.PnlActividades.Size = New System.Drawing.Size(920, 245)
        Me.PnlActividades.TabIndex = 51
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel36.Controls.Add(Me.Label84)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel36.Location = New System.Drawing.Point(0, 0)
        Me.Panel36.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(920, 35)
        Me.Panel36.TabIndex = 28
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.White
        Me.Label84.Location = New System.Drawing.Point(13, 6)
        Me.Label84.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(96, 21)
        Me.Label84.TabIndex = 0
        Me.Label84.Text = "Actividades"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(15, 77)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(167, 21)
        Me.Label83.TabIndex = 71
        Me.Label83.Text = "Festivales Culturales:"
        '
        'txt_SE_CULTURALES
        '
        Me.txt_SE_CULTURALES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_CULTURALES.Location = New System.Drawing.Point(188, 74)
        Me.txt_SE_CULTURALES.Name = "txt_SE_CULTURALES"
        Me.txt_SE_CULTURALES.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_CULTURALES.TabIndex = 67
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(624, 77)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(70, 21)
        Me.Label80.TabIndex = 70
        Me.Label80.Text = "Teatros:"
        '
        'txt_SE_TEATROS
        '
        Me.txt_SE_TEATROS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_TEATROS.Location = New System.Drawing.Point(700, 74)
        Me.txt_SE_TEATROS.Name = "txt_SE_TEATROS"
        Me.txt_SE_TEATROS.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_TEATROS.TabIndex = 65
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(433, 43)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(261, 21)
        Me.Label78.TabIndex = 69
        Me.Label78.Text = "Eventos sociales (Fam o Amigos):"
        '
        'txt_SE__SOCIALE
        '
        Me.txt_SE__SOCIALE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE__SOCIALE.Location = New System.Drawing.Point(700, 40)
        Me.txt_SE__SOCIALE.Name = "txt_SE__SOCIALE"
        Me.txt_SE__SOCIALE.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE__SOCIALE.TabIndex = 66
        '
        'txt_SE_EVENTOS
        '
        Me.txt_SE_EVENTOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_EVENTOS.Location = New System.Drawing.Point(188, 40)
        Me.txt_SE_EVENTOS.Name = "txt_SE_EVENTOS"
        Me.txt_SE_EVENTOS.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_EVENTOS.TabIndex = 64
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(2, 43)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(180, 21)
        Me.Label79.TabIndex = 68
        Me.Label79.Text = "Eventos Comunitarios:"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(541, 108)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(153, 21)
        Me.Label88.TabIndex = 79
        Me.Label88.Text = "Parques Naturales:"
        '
        'txt_SE_NATURALES
        '
        Me.txt_SE_NATURALES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_NATURALES.Location = New System.Drawing.Point(700, 108)
        Me.txt_SE_NATURALES.Name = "txt_SE_NATURALES"
        Me.txt_SE_NATURALES.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_NATURALES.TabIndex = 73
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(83, 111)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(99, 21)
        Me.Label86.TabIndex = 78
        Me.Label86.Text = "Vacaciones:"
        '
        'txt_SE_VACIONES
        '
        Me.txt_SE_VACIONES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_VACIONES.Location = New System.Drawing.Point(188, 108)
        Me.txt_SE_VACIONES.Name = "txt_SE_VACIONES"
        Me.txt_SE_VACIONES.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_VACIONES.TabIndex = 72
        '
        'txt_SE_CINES
        '
        Me.txt_SE_CINES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_CINES.Location = New System.Drawing.Point(700, 142)
        Me.txt_SE_CINES.Name = "txt_SE_CINES"
        Me.txt_SE_CINES.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_CINES.TabIndex = 75
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(639, 145)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(55, 21)
        Me.Label85.TabIndex = 77
        Me.Label85.Text = "Cines:"
        '
        'txt_SE_MUSEOS
        '
        Me.txt_SE_MUSEOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_MUSEOS.Location = New System.Drawing.Point(188, 142)
        Me.txt_SE_MUSEOS.Name = "txt_SE_MUSEOS"
        Me.txt_SE_MUSEOS.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_MUSEOS.TabIndex = 74
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(109, 145)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(73, 21)
        Me.Label81.TabIndex = 76
        Me.Label81.Text = "Museos:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(-1, 210)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(183, 21)
        Me.Label90.TabIndex = 82
        Me.Label90.Text = "Parque de Diversiones:"
        '
        'txt_se_diversiones
        '
        Me.txt_se_diversiones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_se_diversiones.Location = New System.Drawing.Point(188, 210)
        Me.txt_se_diversiones.Name = "txt_se_diversiones"
        Me.txt_se_diversiones.Size = New System.Drawing.Size(209, 28)
        Me.txt_se_diversiones.TabIndex = 79
        '
        'txt_SE_PLAZAS
        '
        Me.txt_SE_PLAZAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_PLAZAS.Location = New System.Drawing.Point(700, 176)
        Me.txt_SE_PLAZAS.Name = "txt_SE_PLAZAS"
        Me.txt_SE_PLAZAS.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_PLAZAS.TabIndex = 78
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(566, 179)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(128, 21)
        Me.Label89.TabIndex = 81
        Me.Label89.Text = "Plazas Publicas:"
        '
        'txt_SE_ZONAS
        '
        Me.txt_SE_ZONAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SE_ZONAS.Location = New System.Drawing.Point(188, 176)
        Me.txt_SE_ZONAS.Name = "txt_SE_ZONAS"
        Me.txt_SE_ZONAS.Size = New System.Drawing.Size(209, 28)
        Me.txt_SE_ZONAS.TabIndex = 77
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(9, 179)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(173, 21)
        Me.Label87.TabIndex = 80
        Me.Label87.Text = "Zonas Arqueologicas:"
        '
        'PnlReferencias
        '
        Me.PnlReferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlReferencias.Controls.Add(Me.dgv_Ref)
        Me.PnlReferencias.Controls.Add(Me.Label52)
        Me.PnlReferencias.Controls.Add(Me.txt_TC)
        Me.PnlReferencias.Controls.Add(Me.txt_RefOcu)
        Me.PnlReferencias.Controls.Add(Me.Label56)
        Me.PnlReferencias.Controls.Add(Me.Label46)
        Me.PnlReferencias.Controls.Add(Me.Txt_TR)
        Me.PnlReferencias.Controls.Add(Me.txt_RefNom)
        Me.PnlReferencias.Controls.Add(Me.Label48)
        Me.PnlReferencias.Controls.Add(Me.Panel10)
        Me.PnlReferencias.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlReferencias.Location = New System.Drawing.Point(0, 866)
        Me.PnlReferencias.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlReferencias.Name = "PnlReferencias"
        Me.PnlReferencias.Size = New System.Drawing.Size(918, 216)
        Me.PnlReferencias.TabIndex = 71
        '
        'Btn_AddRef
        '
        Me.Btn_AddRef.Image = Global.AdminEmpleados.My.Resources.Resources.Add_Reference_80px
        Me.Btn_AddRef.Location = New System.Drawing.Point(846, 0)
        Me.Btn_AddRef.Name = "Btn_AddRef"
        Me.Btn_AddRef.Size = New System.Drawing.Size(45, 40)
        Me.Btn_AddRef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_AddRef.TabIndex = 63
        Me.Btn_AddRef.TabStop = False
        '
        'dgv_Ref
        '
        Me.dgv_Ref.AllowUserToAddRows = False
        Me.dgv_Ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ref.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.TIPO, Me.OCUPACION, Me.TIEMPO})
        Me.dgv_Ref.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Ref.Location = New System.Drawing.Point(0, 114)
        Me.dgv_Ref.Name = "dgv_Ref"
        Me.dgv_Ref.RowHeadersVisible = False
        Me.dgv_Ref.Size = New System.Drawing.Size(914, 98)
        Me.dgv_Ref.TabIndex = 54
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "Ref_Nombre"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 200
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "Ref_TRelacion"
        Me.TIPO.HeaderText = "TIPO DE RELACION"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.Width = 300
        '
        'OCUPACION
        '
        Me.OCUPACION.DataPropertyName = "Ref_Ocupacion"
        Me.OCUPACION.HeaderText = "OCUPACION"
        Me.OCUPACION.Name = "OCUPACION"
        Me.OCUPACION.Width = 200
        '
        'TIEMPO
        '
        Me.TIEMPO.DataPropertyName = "Ref_TiempoC"
        Me.TIEMPO.HeaderText = "TIEMPO DE CONOCERLO"
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.Width = 400
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(327, 82)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(71, 21)
        Me.Label52.TabIndex = 53
        Me.Label52.Text = "Tiempo:"
        '
        'txt_TC
        '
        Me.txt_TC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TC.Location = New System.Drawing.Point(404, 79)
        Me.txt_TC.Name = "txt_TC"
        Me.txt_TC.Size = New System.Drawing.Size(208, 28)
        Me.txt_TC.TabIndex = 5
        '
        'txt_RefOcu
        '
        Me.txt_RefOcu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefOcu.Location = New System.Drawing.Point(109, 79)
        Me.txt_RefOcu.Name = "txt_RefOcu"
        Me.txt_RefOcu.Size = New System.Drawing.Size(209, 28)
        Me.txt_RefOcu.TabIndex = 4
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(478, 52)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(140, 21)
        Me.Label56.TabIndex = 51
        Me.Label56.Text = "Tipo de Relacion:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(7, 82)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 21)
        Me.Label46.TabIndex = 44
        Me.Label46.Text = "Ocupacion:"
        '
        'Txt_TR
        '
        Me.Txt_TR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TR.Location = New System.Drawing.Point(624, 49)
        Me.Txt_TR.Name = "Txt_TR"
        Me.Txt_TR.Size = New System.Drawing.Size(209, 28)
        Me.Txt_TR.TabIndex = 3
        '
        'txt_RefNom
        '
        Me.txt_RefNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RefNom.Location = New System.Drawing.Point(109, 45)
        Me.txt_RefNom.Name = "txt_RefNom"
        Me.txt_RefNom.Size = New System.Drawing.Size(363, 28)
        Me.txt_RefNom.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(26, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(77, 21)
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
        Me.Panel10.Size = New System.Drawing.Size(914, 40)
        Me.Panel10.TabIndex = 0
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(13, 6)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(97, 21)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Referencias"
        '
        'PnlGastos
        '
        Me.PnlGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlGastos.Controls.Add(Me.Label64)
        Me.PnlGastos.Controls.Add(Me.txt_GFServ)
        Me.PnlGastos.Controls.Add(Me.Label73)
        Me.PnlGastos.Controls.Add(Me.Panel30)
        Me.PnlGastos.Controls.Add(Me.txt_GFRenta)
        Me.PnlGastos.Controls.Add(Me.Label72)
        Me.PnlGastos.Controls.Add(Me.Label62)
        Me.PnlGastos.Controls.Add(Me.Txt_GFDesp)
        Me.PnlGastos.Controls.Add(Me.txt_GFCole)
        Me.PnlGastos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlGastos.Location = New System.Drawing.Point(0, 1086)
        Me.PnlGastos.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlGastos.Name = "PnlGastos"
        Me.PnlGastos.Size = New System.Drawing.Size(918, 86)
        Me.PnlGastos.TabIndex = 72
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(620, 48)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(79, 21)
        Me.Label64.TabIndex = 66
        Me.Label64.Text = "Servicios:"
        '
        'txt_GFServ
        '
        Me.txt_GFServ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GFServ.Location = New System.Drawing.Point(705, 45)
        Me.txt_GFServ.Name = "txt_GFServ"
        Me.txt_GFServ.Size = New System.Drawing.Size(95, 28)
        Me.txt_GFServ.TabIndex = 30
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(426, 48)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(87, 21)
        Me.Label62.TabIndex = 64
        Me.Label62.Text = "Despensa:"
        '
        'Txt_GFDesp
        '
        Me.Txt_GFDesp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_GFDesp.Location = New System.Drawing.Point(519, 45)
        Me.Txt_GFDesp.Name = "Txt_GFDesp"
        Me.Txt_GFDesp.Size = New System.Drawing.Size(95, 28)
        Me.Txt_GFDesp.TabIndex = 29
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(210, 48)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(109, 21)
        Me.Label72.TabIndex = 62
        Me.Label72.Text = "Colegiaturas:"
        '
        'txt_GFRenta
        '
        Me.txt_GFRenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GFRenta.Location = New System.Drawing.Point(109, 45)
        Me.txt_GFRenta.Name = "txt_GFRenta"
        Me.txt_GFRenta.Size = New System.Drawing.Size(95, 28)
        Me.txt_GFRenta.TabIndex = 27
        '
        'txt_GFCole
        '
        Me.txt_GFCole.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GFCole.Location = New System.Drawing.Point(325, 45)
        Me.txt_GFCole.Name = "txt_GFCole"
        Me.txt_GFCole.Size = New System.Drawing.Size(95, 28)
        Me.txt_GFCole.TabIndex = 28
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(45, 48)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(58, 21)
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
        Me.Panel30.Size = New System.Drawing.Size(914, 40)
        Me.Panel30.TabIndex = 0
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(13, 6)
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
        'PnlObservaciones
        '
        Me.PnlObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlObservaciones.Controls.Add(Me.txt_commen)
        Me.PnlObservaciones.Controls.Add(Me.Panel26)
        Me.PnlObservaciones.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlObservaciones.Location = New System.Drawing.Point(0, 1176)
        Me.PnlObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlObservaciones.Name = "PnlObservaciones"
        Me.PnlObservaciones.Size = New System.Drawing.Size(918, 166)
        Me.PnlObservaciones.TabIndex = 73
        '
        'txt_commen
        '
        Me.txt_commen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_commen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_commen.Location = New System.Drawing.Point(0, 40)
        Me.txt_commen.Multiline = True
        Me.txt_commen.Name = "txt_commen"
        Me.txt_commen.Size = New System.Drawing.Size(914, 122)
        Me.txt_commen.TabIndex = 31
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
        Me.Panel26.Size = New System.Drawing.Size(914, 40)
        Me.Panel26.TabIndex = 0
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.White
        Me.Label71.Location = New System.Drawing.Point(13, 6)
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
        'btn_SERPT
        '
        Me.btn_SERPT.Image = Global.AdminEmpleados.My.Resources.Resources.Accounting_80px
        Me.btn_SERPT.Location = New System.Drawing.Point(769, 1346)
        Me.btn_SERPT.Name = "btn_SERPT"
        Me.btn_SERPT.Size = New System.Drawing.Size(45, 40)
        Me.btn_SERPT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SERPT.TabIndex = 76
        Me.btn_SERPT.TabStop = False
        '
        'btn_SESave
        '
        Me.btn_SESave.Image = Global.AdminEmpleados.My.Resources.Resources.Save_80px
        Me.btn_SESave.Location = New System.Drawing.Point(820, 1346)
        Me.btn_SESave.Name = "btn_SESave"
        Me.btn_SESave.Size = New System.Drawing.Size(45, 40)
        Me.btn_SESave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SESave.TabIndex = 74
        Me.btn_SESave.TabStop = False
        '
        'btn_SECancel
        '
        Me.btn_SECancel.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_SECancel.Location = New System.Drawing.Point(871, 1346)
        Me.btn_SECancel.Name = "btn_SECancel"
        Me.btn_SECancel.Size = New System.Drawing.Size(45, 40)
        Me.btn_SECancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SECancel.TabIndex = 75
        Me.btn_SECancel.TabStop = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 1100)
        Me.Controls.Add(Me.MenuEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tam_Es.ResumeLayout(False)
        Me.PnlDatos.ResumeLayout(False)
        Me.PnlDatos.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PnlIngresos.ResumeLayout(False)
        Me.PnlIngresos.PerformLayout()
        CType(Me.dgv_OI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpServicios.ResumeLayout(False)
        Me.GrpServicios.PerformLayout()
        Me.PnlVivienda.ResumeLayout(False)
        Me.GrpMaterial.ResumeLayout(False)
        Me.GrpMaterial.PerformLayout()
        Me.GrpTIpo.ResumeLayout(False)
        Me.GrpTIpo.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Tab_Enfer.ResumeLayout(False)
        Me.panel20.ResumeLayout(False)
        Me.panel20.PerformLayout()
        CType(Me.dgv_Enf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel21.ResumeLayout(False)
        Me.panel21.PerformLayout()
        Me.Tab_Cont.ResumeLayout(False)
        Me.panel18.ResumeLayout(False)
        Me.panel18.PerformLayout()
        CType(Me.dgv_contacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel19.ResumeLayout(False)
        Me.panel19.PerformLayout()
        Me.Tab_AL.ResumeLayout(False)
        Me.panel16.ResumeLayout(False)
        Me.panel16.PerformLayout()
        CType(Me.dgv_ant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel17.ResumeLayout(False)
        Me.panel17.PerformLayout()
        Me.Tab_Familia.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.dgv_Hijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel5.ResumeLayout(False)
        Me.panel5.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        CType(Me.dgv_esposa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_DP.ResumeLayout(False)
        Me.Tab_DP.PerformLayout()
        Me.pnl_estatus.ResumeLayout(False)
        Me.pnl_estatus.PerformLayout()
        Me.panel13.ResumeLayout(False)
        Me.panel13.PerformLayout()
        Me.pnl_cont.ResumeLayout(False)
        Me.pnl_cont.PerformLayout()
        Me.panel11.ResumeLayout(False)
        Me.panel11.PerformLayout()
        Me.pnl_per.ResumeLayout(False)
        Me.pnl_per.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        Me.pnl_save.ResumeLayout(False)
        Me.MenuEmp.ResumeLayout(False)
        Me.PnlTransporte.ResumeLayout(False)
        Me.PnlTransporte.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        CType(Me.ALTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAJA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_depto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar_PUESTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar_Super, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_ciudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_hijoADD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_esSAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_antSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_conADD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_enfADD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_OI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_IMAGE_VIVIENDA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datosFamiliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlActividades.ResumeLayout(False)
        Me.PnlActividades.PerformLayout()
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.PnlReferencias.ResumeLayout(False)
        Me.PnlReferencias.PerformLayout()
        CType(Me.Btn_AddRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PnlGastos.ResumeLayout(False)
        Me.PnlGastos.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.PnlObservaciones.ResumeLayout(False)
        Me.PnlObservaciones.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        CType(Me.btn_SERPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SESave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SECancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents datosFamiliaBindingSource As BindingSource
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents Tam_Es As TabPage
    Private WithEvents PnlIngresos As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents txt_OTCantidad As TextBox
    Friend WithEvents txt_OIParen As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents dgv_OI As DataGridView
    Private WithEvents Panel14 As Panel
    Private WithEvents Label60 As Label
    Private WithEvents Label61 As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents cb_block As CheckBox
    Friend WithEvents cb_ladrillo As CheckBox
    Friend WithEvents cb_Madera As CheckBox
    Friend WithEvents cb_adobe As CheckBox
    Friend WithEvents txt_Religion As TextBox
    Friend WithEvents cb_SisSeg As CheckBox
    Friend WithEvents cb_TV As CheckBox
    Friend WithEvents cb_Basura As CheckBox
    Friend WithEvents cb_Internet As CheckBox
    Friend WithEvents cb_Trans As CheckBox
    Friend WithEvents cb_Tuberia As CheckBox
    Friend WithEvents cb_AguaP As CheckBox
    Friend WithEvents cb_LineaTel As CheckBox
    Friend WithEvents cb_Drenaje As CheckBox
    Friend WithEvents cb_Luz As CheckBox
    Friend WithEvents cb_Terreno As CheckBox
    Friend WithEvents cb_Renta As CheckBox
    Friend WithEvents cb_Depto As CheckBox
    Friend WithEvents cb_Vehi As CheckBox
    Friend WithEvents cb_CasaP As CheckBox
    Friend WithEvents cb_Taxi As CheckBox
    Friend WithEvents cb_Metro As CheckBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Txt_pasatiempos As TextBox
    Friend WithEvents Label50 As Label
    Private WithEvents Panel6 As Panel
    Private WithEvents Label53 As Label
    Private WithEvents Tab_Enfer As TabPage
    Private WithEvents panel20 As Panel
    Private WithEvents dgv_Enf As DataGridView
    Friend WithEvents txt_enfNAME As TextBox
    Friend WithEvents label47 As Label
    Private WithEvents panel21 As Panel
    Private WithEvents label19 As Label
    Private WithEvents Tab_Cont As TabPage
    Private WithEvents Tab_AL As TabPage
    Private WithEvents panel16 As Panel
    Friend WithEvents dgv_ant As DataGridView
    Friend WithEvents txt_antMT As TextBox
    Friend WithEvents txt_antNAME As TextBox
    Friend WithEvents txt_antTEL As TextBox
    Friend WithEvents label37 As Label
    Friend WithEvents label38 As Label
    Friend WithEvents label39 As Label
    Friend WithEvents txt_antSALARIO As TextBox
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
    Private WithEvents label17 As Label
    Private WithEvents Tab_Familia As TabPage
    Private WithEvents panel4 As Panel
    Private WithEvents label10 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents dgv_Hijos As DataGridView
    Friend WithEvents txt_hijoEC As ComboBox
    Friend WithEvents label32 As Label
    Friend WithEvents label26 As Label
    Friend WithEvents txt_hijoNACION As TextBox
    Friend WithEvents txt_hijoFN As DateTimePicker
    Friend WithEvents label27 As Label
    Friend WithEvents txt_hijoNAME As TextBox
    Friend WithEvents txt_hijoAM As TextBox
    Friend WithEvents txt_hijoAP As TextBox
    Friend WithEvents label28 As Label
    Friend WithEvents label29 As Label
    Friend WithEvents txt_hijoSEXO As ComboBox
    Friend WithEvents label30 As Label
    Friend WithEvents label31 As Label
    Private WithEvents panel5 As Panel
    Private WithEvents label11 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents dgv_esposa As DataGridView
    Friend WithEvents label25 As Label
    Friend WithEvents txt_esNacion As TextBox
    Friend WithEvents txt_esFN As DateTimePicker
    Friend WithEvents label24 As Label
    Friend WithEvents txt_esName As TextBox
    Friend WithEvents txt_esAM As TextBox
    Friend WithEvents txt_esAP As TextBox
    Friend WithEvents label20 As Label
    Friend WithEvents label21 As Label
    Friend WithEvents cb_esSexo As ComboBox
    Friend WithEvents label22 As Label
    Friend WithEvents label23 As Label
    Private WithEvents Tab_DP As TabPage
    Friend WithEvents lbl_emp As Label
    Friend WithEvents SAVE As PictureBox
    Friend WithEvents CANCEL As PictureBox
    Private WithEvents pnl_estatus As Panel
    Friend WithEvents BAJA As PictureBox
    Private WithEvents seg As CheckBox
    Private WithEvents panel13 As Panel
    Private WithEvents label15 As Label
    Friend WithEvents commen As TextBox
    Friend WithEvents txt_activo As TextBox
    Friend WithEvents label8 As Label
    Friend WithEvents ALTA As PictureBox
    Friend WithEvents txt_baja As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_ALTA As Label
    Private WithEvents pnl_cont As Panel
    Friend WithEvents buscar_depto As PictureBox
    Friend WithEvents depto As TextBox
    Friend WithEvents depto2 As TextBox
    Friend WithEvents Buscar_PUESTO As PictureBox
    Private WithEvents panel11 As Panel
    Private WithEvents label14 As Label
    Friend WithEvents Buscar_tipo As PictureBox
    Friend WithEvents lbl_ingreso As Label
    Friend WithEvents Txt_correo As TextBox
    Friend WithEvents lbl_clase As Label
    Friend WithEvents txt_tipo2 As TextBox
    Friend WithEvents lbl_super As Label
    Friend WithEvents correo As Label
    Friend WithEvents txt_SALARY As TextBox
    Friend WithEvents lbl_puesto As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents lbl_sali As Label
    Friend WithEvents txt_FECHAINGRESO As DateTimePicker
    Friend WithEvents Buscar_Super As PictureBox
    Friend WithEvents txt_PUESTO As TextBox
    Friend WithEvents txt_PUESTO2 As TextBox
    Friend WithEvents txt_SUPER2 As TextBox
    Friend WithEvents txt_SUPER As TextBox
    Friend WithEvents lbl_depto As Label
    Friend WithEvents foto As PictureBox
    Private WithEvents pnl_per As Panel
    Friend WithEvents buscar_ciudad As PictureBox
    Friend WithEvents cuidad As TextBox
    Friend WithEvents cuidad2 As TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents EC As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents ddl_educacion As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents buscar_EN As PictureBox
    Private WithEvents panel7 As Panel
    Private WithEvents label12 As Label
    Friend WithEvents LBL_CP As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents CP As TextBox
    Friend WithEvents txt_NOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_AM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_AP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_EN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents colonia As TextBox
    Friend WithEvents txt_RFC As TextBox
    Friend WithEvents domicilio As TextBox
    Friend WithEvents txt_SS As TextBox
    Friend WithEvents Celular As TextBox
    Friend WithEvents nacion As TextBox
    Friend WithEvents txt_CURP As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents LBL_ESTADOCIVIL As Label
    Friend WithEvents lbl_ap As Label
    Friend WithEvents txt_FECHA As DateTimePicker
    Friend WithEvents lbl_am As Label
    Friend WithEvents CB_SEXO As ComboBox
    Friend WithEvents lbl_nom As Label
    Friend WithEvents txt_EN2 As TextBox
    Friend WithEvents lbl_sex As Label
    Friend WithEvents lbl_curp As Label
    Friend WithEvents lbl_fn As Label
    Friend WithEvents lbl_ss As Label
    Friend WithEvents lbl_nac As Label
    Friend WithEvents lbl_rfc As Label
    Private WithEvents MenuEmp As TabControl
    Friend WithEvents PARENTESCO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents btn_esSAVE As PictureBox
    Friend WithEvents btn_hijoADD As PictureBox
    Private WithEvents panel18 As Panel
    Friend WithEvents btn_conADD As PictureBox
    Private WithEvents dgv_contacto As DataGridView
    Friend WithEvents label45 As Label
    Friend WithEvents txt_conPAREN As TextBox
    Friend WithEvents label41 As Label
    Friend WithEvents txt_conCEL As TextBox
    Friend WithEvents label40 As Label
    Friend WithEvents txt_conTEL As TextBox
    Friend WithEvents txt_conNAME As TextBox
    Friend WithEvents txt_conAM As TextBox
    Friend WithEvents txt_conAP As TextBox
    Friend WithEvents label42 As Label
    Friend WithEvents label43 As Label
    Friend WithEvents label44 As Label
    Private WithEvents panel19 As Panel
    Private WithEvents label18 As Label
    Friend WithEvents btn_antSave As PictureBox
    Friend WithEvents btn_enfADD As PictureBox
    Friend WithEvents btn_OI As PictureBox
    Private WithEvents CB_CLIENTE As CheckBox
    Private WithEvents CB_PROV As CheckBox
    Friend WithEvents LBL_BAJA As Label
    Friend WithEvents ID_Enf As DataGridViewTextBoxColumn
    Friend WithEvents Text As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Ant As DataGridViewTextBoxColumn
    Friend WithEvents ID__Emp As DataGridViewTextBoxColumn
    Friend WithEvents Ant_FInicio As DataGridViewTextBoxColumn
    Friend WithEvents Ant_FFin As DataGridViewTextBoxColumn
    Friend WithEvents Ant_NEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents Ant_Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Ant_Salario As DataGridViewTextBoxColumn
    Friend WithEvents Ant_Tel As DataGridViewTextBoxColumn
    Friend WithEvents Ant_Motivo As DataGridViewTextBoxColumn
    Friend WithEvents Ant_Contacto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ID_Persona As DataGridViewTextBoxColumn
    Friend WithEvents ID_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Fam_Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Fam_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fam_APat As DataGridViewTextBoxColumn
    Friend WithEvents Fam_AMat As DataGridViewTextBoxColumn
    Friend WithEvents Fam_Nacion As DataGridViewTextBoxColumn
    Friend WithEvents Fam_FNac As DataGridViewTextBoxColumn
    Friend WithEvents Fam_Genero As DataGridViewTextBoxColumn
    Friend WithEvents Fam_EdoCivil As DataGridViewTextBoxColumn
    Private WithEvents pnl_save As Panel
    Friend WithEvents PnlDatos As Panel
    Friend WithEvents GrpServicios As GroupBox
    Friend WithEvents PnlVivienda As Panel
    Friend WithEvents GrpMaterial As GroupBox
    Friend WithEvents GrpTIpo As GroupBox
    Private WithEvents Panel15 As Panel
    Private WithEvents Label5 As Label
    Friend WithEvents PnlTransporte As Panel
    Private WithEvents Panel22 As Panel
    Private WithEvents Label57 As Label
    Friend WithEvents PB_IMAGE_VIVIENDA As PictureBox
    Friend WithEvents PnlActividades As Panel
    Friend WithEvents Label90 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents txt_se_diversiones As TextBox
    Friend WithEvents txt_SE_NATURALES As TextBox
    Friend WithEvents Label89 As Label
    Friend WithEvents txt_SE_PLAZAS As TextBox
    Friend WithEvents Label83 As Label
    Friend WithEvents txt_SE_CINES As TextBox
    Friend WithEvents txt_SE_ZONAS As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents txt_SE_CULTURALES As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents txt_SE_TEATROS As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents txt_SE_MUSEOS As TextBox
    Friend WithEvents txt_SE_VACIONES As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents txt_SE__SOCIALE As TextBox
    Friend WithEvents txt_SE_EVENTOS As TextBox
    Friend WithEvents Label79 As Label
    Private WithEvents Panel36 As Panel
    Private WithEvents Label84 As Label
    Private WithEvents PnlObservaciones As Panel
    Friend WithEvents txt_commen As TextBox
    Private WithEvents Panel26 As Panel
    Private WithEvents Label71 As Label
    Private WithEvents Label76 As Label
    Private WithEvents PnlGastos As Panel
    Friend WithEvents Label64 As Label
    Friend WithEvents txt_GFServ As TextBox
    Friend WithEvents Label73 As Label
    Private WithEvents Panel30 As Panel
    Private WithEvents Label74 As Label
    Private WithEvents Label75 As Label
    Friend WithEvents txt_GFRenta As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Txt_GFDesp As TextBox
    Friend WithEvents txt_GFCole As TextBox
    Private WithEvents PnlReferencias As Panel
    Friend WithEvents dgv_Ref As DataGridView
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents OCUPACION As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPO As DataGridViewTextBoxColumn
    Friend WithEvents Label52 As Label
    Friend WithEvents txt_TC As TextBox
    Friend WithEvents txt_RefOcu As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Txt_TR As TextBox
    Friend WithEvents txt_RefNom As TextBox
    Friend WithEvents Label48 As Label
    Private WithEvents Panel10 As Panel
    Friend WithEvents Btn_AddRef As PictureBox
    Private WithEvents Label51 As Label
    Friend WithEvents btn_SERPT As PictureBox
    Friend WithEvents btn_SESave As PictureBox
    Friend WithEvents btn_SECancel As PictureBox
End Class
