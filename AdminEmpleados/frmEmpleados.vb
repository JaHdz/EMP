Imports System.Text.RegularExpressions

Public Class frmEmpleados
    Dim V1 As String
    Dim V2 As String
    Dim aux As Integer
    Dim EXISTE As Boolean = False
    Dim objcon As New Consultas
    Dim EMPLEADO_ID As Int64
    Dim EMPLEADO_ES As Int64
    Dim id As Integer

    Dim ErrorProvider As New ErrorProvider
    Dim tooltip As New ToolTip
    Dim Resultado As Object
    Dim Empleado As Empleado
    Dim Familiares As List(Of Familiar.Vista)
    Sub New()
        InitializeComponent()
        CargarCombos()
        AsignarFechas()
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddToolTips()
        Dim Wait As New frmWait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
        Wait.ShowDialog()
        txtNumero.Text = Wait.Result.ToString()
        Wait.Close()
        txtNombres.Focus()
    End Sub

    Private Sub CargarCombos()
        cbSexo.DataSource = New Sexo().CargarListado()
        cbSexo.DisplayMember = "Nombre"
        cbSexo.ValueMember = "ID"

        cbConyugeSexo.DataSource = New Sexo().CargarListado()
        cbConyugeSexo.DisplayMember = "Nombre"
        cbConyugeSexo.ValueMember = "ID"

        cbHijosSexo.DataSource = New Sexo().CargarListado()
        cbHijosSexo.DisplayMember = "Nombre"
        cbHijosSexo.ValueMember = "ID"

        cbEstadoCivil.DataSource = EstadosCiviles
        cbEstadoCivil.DisplayMember = "Descripcion"
        cbEstadoCivil.ValueMember = "Descripcion"

        cbNivelEducativo.DataSource = NivelesEducativos
        cbNivelEducativo.DisplayMember = "Descripcion"
        cbNivelEducativo.ValueMember = "Descripcion"
    End Sub

    Private Sub AsignarFechas()
        dtpFechaDeNacimiento.MaxDate = New Date(Now.Year() - 16, 12, 31)
        dtpFechaDeNacimiento.Value = Today().AddYears(-16)
        txt_esFN.MaxDate = New Date(Now.Year() - 16, 12, 31)
        txt_esFN.Value = Today().AddYears(-16)
        txt_hijoFN.MaxDate = Today()
        txt_antFI.MaxDate = Today()
        txt_antFF.MaxDate = Today()
    End Sub

    Private Sub AddToolTips()
        tooltip.SetToolTip(SAVE, "Guardar Información de un nuevo empleado")
        tooltip.SetToolTip(CANCEL, "Cancelar operación")
        tooltip.SetToolTip(pbFotoEmpleado, "Haz doble clic para agregar una nueva imagen")
        tooltip.SetToolTip(PbOptions, "Dar de baja a este empleado")
        tooltip.SetToolTip(btn_esSAVE, "Agregar cónyuge")
        tooltip.SetToolTip(btn_hijoADD, "Agregar hijos")
        tooltip.SetToolTip(btn_antSave, "Agregar atecedentes laborales")
        tooltip.SetToolTip(btn_enfADD, "Agregar un nuevo registro de enfermedades")
        tooltip.SetToolTip(btn_conADD, "Agregar nuevo contacto de emergencia")
        tooltip.SetToolTip(PB_IMAGE_VIVIENDA, "Haz doble clic para agregar una nueva imagen")
        tooltip.SetToolTip(btn_OI, "Agregar otros ingresos")
        tooltip.SetToolTip(Btn_AddRef, "Agregar una nueva referencia")
        tooltip.SetToolTip(btn_SERPT, "Ver el reporte de Estudio Socioeconomico")
        tooltip.SetToolTip(btn_SESave, "Guardar Estudio Socioeconomico")
        tooltip.SetToolTip(btn_SECancel, "Cancelar operación")
    End Sub

    Public Sub Llenar_buscador(tipo As BuscarPor, Optional Otro As Object = Nothing)
        Dim popup As New frmPopUpCatalogo(tipo, True, Otro)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Public Sub CargarImagen(control As PictureBox)
        Dim IMAGEN As String
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" And OpenFileDialog1.FileName <> "OpenFileDialog1" Then
            IMAGEN = OpenFileDialog1.FileName
            Dim largo As Integer = IMAGEN.Length
            If IsValidFormat(Mid(RTrim(IMAGEN), largo - 2, largo).ToLower()) OrElse
                IsValidFormat(Mid(RTrim(IMAGEN), largo - 3, largo).ToLower()) Then
                control.Load(IMAGEN)
            Else
                MsgBox("Formato no valido") : Exit Sub
            End If
        End If
    End Sub

    Private Function IsValidFormat(Ext As String) As Boolean
        IsValidFormat = False
        If Ext <> "gif" And Ext <> "bmp" And Ext <> "jpg" And Ext <> "jpeg" And Ext <> "png" Then
            IsValidFormat = False
        Else
            IsValidFormat = True
        End If
    End Function

    Public Function EmailValido(Correo As String) As Boolean
        If String.IsNullOrWhiteSpace(Correo) Then
            Return True
        Else
            Dim IndiceArroba As Integer = Correo.IndexOf("@")
            If IndiceArroba > -1 Then
                If Correo.IndexOf(".", IndiceArroba) > IndiceArroba Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Sub MenuEmp_Selecting(sender As Object, e As TabControlCancelEventArgs)

    End Sub

    Private Sub LlenarDatosEstudioSocioeconomico()

    End Sub

#Region "Datos personales"

    Private Sub PbSearchEmployee_Click(sender As Object, e As EventArgs) Handles PbSearchEmployee.Click
        Llenar_buscador(BuscarPor.Empleado)
        If Resultado IsNot Nothing Then
            Dim vista = CType(Resultado, Empleado.Vista)
            Empleado = New Empleado().Buscar(vista.ID)
            LlenarDatosPersonales()
            pnl_estatus.Visible = True
            SAVE.Tag = Operacion.Actualizar
            SAVE.Image = My.Resources.Updates_80
            tooltip.SetToolTip(SAVE, "Actualizar Información del empleado")
            LlenarDatosFamiliares()
            LlenarDatosAntesedentesLaborales()
            LlenarDatosContactosDeEmergencia()
            LlenarDatosMedicos()
            LlenarDatosEstudioSocioeconomico()
        Else
            pnl_estatus.Visible = False
            SAVE.Image = My.Resources.Save_80px
            SAVE.Tag = Operacion.Registrar
            tooltip.SetToolTip(SAVE, "Guardar Información de un nuevo empleado")
        End If
    End Sub

    Private Sub LlenarDatosPersonales()
        With Empleado
            pbFotoEmpleado.Image = .Foto
            txtNumero.Text = .ID
            txtNombres.Text = .Nombre
            txtAPaterno.Text = .ApellidoPaterno
            txtAMaterno.Text = .ApellidoMaterno
            cbSexo.SelectedValue = .Sexo
            dtpFechaDeNacimiento.Value = .FechaDeNacimiento
            txtNacionalidad.Text = .Nacionalidad
            Dim Entidad As Entidad = New Entidad().Buscar(.EntidadNatal)
            txtEntidadCodigo.Text = Entidad.Codigo
            txtEntidad.Text = Entidad.Nombre
            Dim Ciudad As Ciudad = New Ciudad().Buscar(.CiudadNatal, Entidad.Codigo)
            txtCiudadCodigo.Text = Ciudad.Codigo
            txtCiudad.Text = Ciudad.Nombre
            txtCURP.Text = .CURP
            txtRFC.Text = .RFC
            cbEstadoCivil.SelectedValue = .EstadoCivil
            txtNSS.Text = .NSS
            txtDomicilio.Text = .Domicilio
            txtColonia.Text = .Colonia
            txtCdDomicilio.Text = .CiudadEstado
            txtCodigoPostal.Text = .CodigoPostal
            txtTelefono.Text = .Telefono
            txtCelular.Text = .Celular
            cbNivelEducativo.SelectedValue = .NivelEducativo
            dtpFechaDeIngreso.Value = .FechaEfectiva
            Dim Puesto As Puesto = .Puesto
            txtPuestoCodigo.Text = Puesto.ID
            txtPuesto.Text = Puesto.Nombre
            Dim Departamento As Departamento = .Departamento
            txtDeptoCodigo.Text = Departamento.ID
            txtDepto.Text = Departamento.Descripcion
            Dim Supervisor As Supervisor = .Supervisor
            txtSupervisorCodigo.Text = Supervisor.ID
            txtSupervisor.Text = Supervisor.Nombre
            Dim Tipo As Tipo = .Tipo
            txtTipoCodigo.Text = Tipo.ID
            txtTipo.Text = Tipo.Descripcion
            txtSalario.Text = .Salario
            txtCorreo.Text = .Email
            If .EsActivo Then
                txt_baja.Text = ""
                txt_activo.Text = "SI"
                lbl_option.Text = "BAJA"
                PbOptions.Image = My.Resources.Baja_80px
            Else
                txt_baja.Text = .FechaDeBaja.ToShortDateString()
                lbl_option.Text = "ALTA"
                PbOptions.Image = My.Resources.Alta_80px
                txt_activo.Text = "NO"
            End If
            seg.Checked = False
            CB_CLIENTE.Checked = .NotificarClientes
            CB_PROV.Checked = .NotificarProveedores
            commen.Text = .MotivoDeBaja
            lbl_option.Visible = True
            PbOptions.Tag = lbl_option.Text
            PbOptions.Visible = True
        End With
    End Sub

    Private Sub PbFotoEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles pbFotoEmpleado.DoubleClick
        CargarImagen(pbFotoEmpleado)
    End Sub

    Private Sub Buscar_PUESTO_Click(sender As Object, e As EventArgs) Handles Buscar_PUESTO.Click
        Llenar_buscador(BuscarPor.Puesto)
        If Resultado IsNot Nothing Then
            Dim Puesto As Puesto = CType(Resultado, Puesto)
            txtPuestoCodigo.Text = Puesto.ID
            txtPuesto.Text = Puesto.Nombre
        End If
    End Sub

    Private Sub Buscar_Super_Click(sender As Object, e As EventArgs) Handles Buscar_Super.Click
        Llenar_buscador(BuscarPor.Supervisor)
        If Resultado IsNot Nothing Then
            Dim Supervisor As Supervisor = CType(Resultado, Supervisor)
            txtSupervisorCodigo.Text = Supervisor.ID
            txtSupervisor.Text = Supervisor.Nombre
        End If
    End Sub

    Private Sub Buscar_tipo_Click(sender As Object, e As EventArgs) Handles Buscar_tipo.Click
        Llenar_buscador(BuscarPor.TipoDeEmpleado)
        If Resultado IsNot Nothing Then
            Dim Tipo As Tipo = CType(Resultado, Tipo)
            txtTipoCodigo.Text = Tipo.Codigo
            txtTipo.Text = Tipo.Descripcion
        End If
    End Sub

    Private Sub Buscar_depto_Click(sender As Object, e As EventArgs) Handles buscar_depto.Click
        Llenar_buscador(BuscarPor.Departamento)
        If Resultado IsNot Nothing Then
            Dim Departamento As Departamento = CType(Resultado, Departamento)
            txtDeptoCodigo.Text = Departamento.Codigo
            txtDepto.Text = Departamento.Descripcion
        End If
    End Sub

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Entidad)
        If Resultado IsNot Nothing Then
            Dim Entidad As Entidad = CType(Resultado, Entidad)
            txtEntidadCodigo.Text = Entidad.Codigo
            txtEntidad.Text = Entidad.Nombre
            txtCiudad.Text = ""
            txtCiudadCodigo.Text = ""
        End If
    End Sub

    Private Sub Buscar_ciudad_Click(sender As Object, e As EventArgs) Handles buscar_ciudad.Click
        If txtEntidadCodigo.Text = "" Then
            MessageBox.Show("Primero debe elegir una entidad.")
        Else
            Llenar_buscador(BuscarPor.Ciudad, txtEntidadCodigo.Text)
            If Resultado IsNot Nothing Then
                Dim Ciudad As Ciudad = CType(Resultado, Ciudad)
                txtCiudadCodigo.Text = Ciudad.Codigo
                txtCiudad.Text = Ciudad.Nombre
            End If
        End If
    End Sub

    Private Sub TxtCorreo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating
        If Not EmailValido(txtCorreo.Text) Then
            ErrorProvider.SetError(txtCorreo, "Correo electronico invalido")
        Else
            ErrorProvider.SetError(txtCorreo, String.Empty)
        End If
    End Sub

    Private Sub TxtNSS_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNSS.Validating
        If Not NSS.IsValid(txtNSS.Text) Then
            ErrorProvider.SetError(txtNSS, "Número de Seguro Social '" + txtNSS.Text + "' no valido, por favor verifique sea correcto")
        Else
            ErrorProvider.SetError(txtNSS, "")
        End If
    End Sub

    Private Sub TxtCURP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCURP.Validating
        If Not CURP.IsValid(txtCURP.Text) Then
            ErrorProvider.SetError(txtCURP, "Número de CURP :'" + txtCURP.Text + "' no valido, por favor verifique sea correcto")
        Else
            ErrorProvider.SetError(txtCURP, "")
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        Limp()
    End Sub

    Private Sub OptionPress(sender As Object, e As EventArgs) Handles PbOptions.Click
        If Empleado IsNot Nothing Then
            Select Case Empleado.EsActivo
                Case True
                    If Empleado.CambiarEstatus(Operacion.Baja) Then
                        LlenarDatosPersonales()
                    End If
                Case False
                    If Empleado.CambiarEstatus(Operacion.Alta) Then
                        LlenarDatosPersonales()
                    End If
            End Select
        End If
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If ErrorProvider.GetError(txtCorreo) = String.Empty Then
            Dim loEmpleado As New Empleado(0, txtNombres.Text, txtAPaterno.Text, txtAMaterno.Text, txtDomicilio.Text, txtColonia.Text, txtCdDomicilio.Text,
                               txtCodigoPostal.Text, txtCelular.Text, txtTelefono.Text, cbEstadoCivil.SelectedValue, txtNacionalidad.Text,
                               txtCiudadCodigo.Text, txtEntidadCodigo.Text, txtSalario.Text, cbNivelEducativo.SelectedValue, txtCorreo.Text,
                               dtpFechaDeNacimiento.Value, txtRFC.Text, txtNSS.Text, Today, cbSexo.SelectedValue, txtCURP.Text,
                               New Tipo().Buscar(txtTipoCodigo.Text), New Supervisor().Buscar(txtSupervisorCodigo.Text), dtpFechaDeIngreso.Value,
                               New Departamento().Buscar(txtDeptoCodigo.Text), New Puesto().Buscar(txtPuestoCodigo.Text), New Usuario(), True, False,
                               pbFotoEmpleado.Image, DateTimePicker.MinimumDateTime, String.Empty, False, False, False, False)
            Select Case SAVE.Tag
                Case Operacion.Registrar
                    If loEmpleado.Registrar() Then
                        Empleado = loEmpleado
                        LlenarDatosPersonales()
                    End If
                Case Operacion.Actualizar
                    loEmpleado.ID = Empleado.ID
                    loEmpleado.Usuario = Empleado.Usuario
                    loEmpleado.FechaDeAlta = Empleado.FechaDeAlta
                    If loEmpleado.Actualizar() Then
                        Empleado = loEmpleado
                        LlenarDatosPersonales()
                    End If
            End Select
        End If
    End Sub

    Private Sub Commen_TextChanged(sender As Object, e As EventArgs) Handles commen.TextChanged
        If Empleado IsNot Nothing Then
            If Not String.IsNullOrWhiteSpace(commen.Text) Then
                Empleado.MotivoDeBaja = commen.Text
            End If
        End If
    End Sub

    Private Sub CB_CLIENTE_CheckedChanged(sender As Object, e As EventArgs) Handles CB_CLIENTE.CheckedChanged
        If Empleado IsNot Nothing Then
            Empleado.NotificarClientes = CB_CLIENTE.Checked
        End If
    End Sub

    Private Sub CB_PROV_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PROV.CheckedChanged
        If Empleado IsNot Nothing Then
            Empleado.NotificarProveedores = CB_PROV.Checked
        End If
    End Sub

    Private Sub Seg_CheckedChanged(sender As Object, e As EventArgs) Handles seg.CheckedChanged
        If Empleado IsNot Nothing Then
            Empleado.NotificarSeguridad = seg.Checked
        End If
    End Sub
#End Region

#Region "Datos Familiares"

    Private Sub LlenarDatosFamiliares()
        Familiares = New Familiar().CargarListado(Empleado.ID)
        RefrescarFamiliares()
    End Sub

    Private Sub RefrescarFamiliares()
        dgvEsposa.DataSource = Familiares.FindAll(Function(x) x.Tipo = "CONYUGE")
        dgvHijos.DataSource = Familiares.FindAll(Function(x) x.Tipo = "HIJO")
    End Sub

    Private Sub Btn_esSAVE_Click(sender As Object, e As EventArgs) Handles btn_esSAVE.Click
        If Empleado IsNot Nothing Then
            If New Familiar(0, Empleado.ID, "CONYUGE", txt_esName.Text, txt_esAP.Text, txt_esAM.Text, txtNacionalidad.Text,
                                                    txt_esFN.Value, cbConyugeSexo.SelectedValue).Registrar(Familiares) Then
                RefrescarFamiliares()
                txt_esName.Text = ""
                txt_esAP.Text = ""
                txt_esAM.Text = ""
                txtNacionalidad.Text = ""
                txt_esFN.ResetText()
                cbConyugeSexo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub Btn_hijoADD_Click(sender As Object, e As EventArgs) Handles btn_hijoADD.Click
        If Empleado IsNot Nothing Then
            If New Familiar(0, Empleado.ID, "HIJO", txt_hijoNAME.Text, txt_hijoAP.Text, txt_hijoAM.Text, txt_hijoNACION.Text,
                                            txt_hijoFN.Value, cbHijosSexo.SelectedValue).Registrar(Familiares) Then
                RefrescarFamiliares()
                txt_hijoNAME.Text = ""
                txt_hijoAP.Text = ""
                txt_hijoAM.Text = ""
                txt_hijoNACION.Text = ""
                txt_hijoFN.ResetText()
                cbHijosSexo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub EliminarFamiliar(pFamiliar As Familiar.Vista)
        With pFamiliar
            Dim loFamiliar As Familiar = New Familiar(.ID, .Empleado, .Tipo, .Nombre, .ApellidoPaterno, .ApellidoMaterno, .Nacionalidad, .FechaDeNacimineto, .Sexo)
            If loFamiliar.Eliminar(Familiares) Then
                RefrescarFamiliares()
            End If
        End With
    End Sub

    Private Sub dgv_esposa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEsposa.CellClick
        If e.ColumnIndex = 0 Then
            EliminarFamiliar(CType(dgvEsposa.CurrentRow.DataBoundItem, Familiar.Vista))
        End If
    End Sub

    Private Sub dgv_Hijos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHijos.CellClick
        If e.ColumnIndex = 0 Then
            EliminarFamiliar(CType(dgvHijos.CurrentRow.DataBoundItem, Familiar.Vista))
        End If
    End Sub

#End Region

#Region "Antesedentes Laborales"

    Private Sub LlenarDatosAntesedentesLaborales()
        dgvAntecedentesLaborales.DataSource = New AntecedenteLaboral().CargarListado(Empleado.ID)
    End Sub

    Private Sub Btn_antSave_Click(sender As Object, e As EventArgs) Handles btn_antSave.Click
        If Empleado IsNot Nothing Then
            If New AntecedenteLaboral(0, Empleado.ID, txt_antFI.Value, txt_antFF.Value, txt_antEMP.Text, txt_antCARGO.Text,
                                     txt_antSALARIO.Text, txt_antTEL.Text, txt_antMT.Text,
                                     txt_antNAME.Text).Registrar(dgvAntecedentesLaborales.DataSource) Then
                dgvAntecedentesLaborales.Refresh()
                txt_antFI.ResetText()
                txt_antFF.ResetText()
                txt_antEMP.Text = ""
                txt_antCARGO.Text = ""
                txt_antSALARIO.Text = ""
                txt_antTEL.Text = ""
                txt_antMT.Text = ""
                txt_antNAME.Text = ""
            End If
        End If
    End Sub

    Private Sub dgv_ant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAntecedentesLaborales.CellClick
        If e.ColumnIndex = 0 Then
            If CType(dgvAntecedentesLaborales.CurrentRow.DataBoundItem, AntecedenteLaboral).Eliminar(dgvAntecedentesLaborales.DataSource) Then
                dgvAntecedentesLaborales.Refresh()
            End If
        End If

    End Sub

#End Region

#Region "Contactos"
    Private Sub LlenarDatosContactosDeEmergencia()
        dgvContactos.DataSource = New ContactoDeEmergencia().CargarListado(Empleado.ID)
    End Sub

    Private Sub Btn_conADD_Click(sender As Object, e As EventArgs) Handles btn_conADD.Click
        If Empleado IsNot Nothing Then
            If New ContactoDeEmergencia(0, Empleado.ID, txt_conNAME.Text, txt_conAP.Text, txt_conAM.Text, txt_conPAREN.Text,
                                                       txt_conTEL.Text, txt_conCEL.Text).Registrar(dgvContactos.DataSource) Then
                dgvContactos.Refresh()
                txt_conAM.Text = ""
                txt_conAP.Text = ""
                txt_conCEL.Text = ""
                txt_conPAREN.Text = ""
                txt_conNAME.Text = ""
                txt_conTEL.Text = ""
            End If
        End If

    End Sub

    Private Sub dgv_contacto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContactos.CellClick
        If e.ColumnIndex = 0 Then
            If CType(dgvContactos.CurrentRow.DataBoundItem, ContactoDeEmergencia).Eliminar(dgvContactos.DataSource) Then
                dgvContactos.Refresh()
            End If
        End If
    End Sub

#End Region

#Region "Datos Medicos"
    Private Sub LlenarDatosMedicos()
        dgvEnfermedades.DataSource = New Enfermedad().CargarListado(Empleado.ID)
    End Sub

    Private Sub Btn_enfADD_Click(sender As Object, e As EventArgs) Handles btn_enfADD.Click
        If Empleado IsNot Nothing Then
            If New Enfermedad(0, Empleado.ID, txt_enfNAME.Text).Registrar(dgvEnfermedades.DataSource) Then
                dgvEnfermedades.Refresh()
                txt_enfNAME.Text = ""
            End If
        End If
    End Sub

    Private Sub Dgv_Enf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnfermedades.CellClick
        If e.ColumnIndex = 0 Then
            If CType(dgvContactos.CurrentRow.DataBoundItem, Enfermedad).Eliminar(dgvEnfermedades.DataSource) Then
                dgvEnfermedades.Refresh()
            End If
        End If
    End Sub

#End Region

#Region "Estudio Socioeconomico"

#End Region



    Private Sub SAVE_F()
        ''If ValidateEmail(txtCorreo.Text) = True Then
        'Dim InfoEmp As New Cls_Emp
        'Dim objEmp As New Consultas
        'InfoEmp.Emp_AMat = txtAMaterno.Text
        'InfoEmp.Emp_APat = txtAPaterno.Text
        'InfoEmp.Emp_Name = txtNombres.Text
        'InfoEmp.Emp_Sexo = cbSexo.SelectedItem.ToString
        'InfoEmp.Emp_NEducativo = cbNivelEducativo.SelectedItem.ToString
        'InfoEmp.Emp_FNac = Convert.ToDateTime(dtpFechaDeNacimiento.Text)
        'InfoEmp.Emp_EN = txtEntidadCodigo.Text
        'InfoEmp.Emp_RFC = txtRFC.Text
        'InfoEmp.Emp_NSS = txtNSS.Text
        'InfoEmp.Emp_Curp = txtCURP.Text
        'InfoEmp.Emp_Cel = txtCelular.Text
        'InfoEmp.Emp_Tel = txtTelefono.Text
        'InfoEmp.Emp_EdoCivil = cbEstadoCivil.SelectedItem.ToString
        'InfoEmp.Emp_Nacionalidad = txtNacionalidad.Text
        'InfoEmp.Emp_Domicilio = txtDomicilio.Text
        'InfoEmp.Emp_Col = txtColonia.Text
        'InfoEmp.Emp_CiudadEstado = txtCdDomicilio.Text
        'InfoEmp.Emp_CP = txtCodigoPostal.Text
        'InfoEmp.Emp_FEfectiva = Convert.ToDateTime(dtpFechaDeIngreso.Text)
        'InfoEmp.ID_Puesto = Convert.ToInt64(txtPuestoCodigo.Text)
        'InfoEmp.Emp_Salario = Convert.ToDouble(txtSalario.Text)
        'InfoEmp.ID_Depto = txtDeptoCodigo.Text
        'InfoEmp.Emp_Sup = txtSupervisorCodigo.Text
        'InfoEmp.Emp_Tipo = txtTipoCodigo.Text
        'InfoEmp.Emp_Activo = 1
        'InfoEmp.Emp_Ciudad = txtCiudadCodigo.Text
        'InfoEmp.Emp_Email = txtCorreo.Text
        'InfoEmp.Img = pbFotoEmpleado.Image
        'InfoEmp.Baja.NotificarClientes = CB_CLIENTE.Checked
        'InfoEmp.Baja.NotificarProveedores = CB_PROV.Checked
        'If (EXISTE = False) Then
        '    If (txtNumero.Text = "" Or txtAPaterno.Text = "" Or txtNombres.Text = "" Or txtEntidadCodigo.Text = "" Or txtRFC.Text = "" Or txtNSS.Text = "" Or
        '          txtSalario.Text = "" Or txtCURP.Text = "" Or dtpFechaDeIngreso.Text = "" Or txtTipoCodigo.Text = "" Or txtPuestoCodigo.Text = "" Or txtDeptoCodigo.Text = "" Or txtSupervisorCodigo.Text = "" Or dtpFechaDeNacimiento.Text = "") Then
        '        MessageBox.Show("Favor de llenar todos los campos")
        '    Else
        '        objEmp.UpInsert_colabora(InfoEmp)
        '        Limp()
        '        MessageBox.Show("Empleado agregado satisfactoriamente")
        '    End If
        'Else
        '    If MessageBox.Show("SE VA A MODIFICAR ESTE EMPLEADO", "My Application",
        '              MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        '              = DialogResult.Yes Then
        '        InfoEmp.ID_Emp = txtNumero.Text
        '        objEmp.UpInsert_colabora(InfoEmp)
        '        Limp()
        '        MessageBox.Show("Empleado Actualizado Satisfactoriamente")
        '    End If
        'End If
        ''Else
        ''    MsgBox("Email no es Valido")
        ''End If
    End Sub

    Private Sub ClearSubControls(Parent As Control)
        For Each ctrl As Control In Parent.Controls
            If ctrl.GetType() Is GetType(TextBox) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
                Continue For
            End If
            If ctrl.GetType() Is GetType(DateTimePicker) Then
                Dim dt As DateTimePicker = CType(ctrl, DateTimePicker)
                dt.Text = Date.Now
                Continue For
            End If
            If ctrl.GetType() Is GetType(ComboBox) Then
                Dim cb As ComboBox = CType(ctrl, ComboBox)
                cb.SelectedIndex = -1
                Continue For
            End If
            If ctrl.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                chk.Checked = False
                Continue For
            End If
            If ctrl.GetType() Is GetType(DataGrid) Then
                Dim dg As DataGrid = CType(ctrl, DataGrid)
                dg.DataSource = Nothing
                Continue For
            End If
            If ctrl.GetType() Is GetType(Panel) Then
                Dim pnl As Panel = CType(ctrl, Panel)
                ClearSubControls(pnl)
                Continue For
            End If
            If ctrl.GetType() Is GetType(GroupBox) Then
                Dim gb As GroupBox = CType(ctrl, GroupBox)
                ClearSubControls(gb)
                Continue For
            End If
        Next
    End Sub
    Public Sub Limp()
        MenuEmp.SelectedIndex = 0
        EMPLEADO_ID = 0
        For Each Tab As TabPage In MenuEmp.TabPages
            For Each Container As Control In Tab.Controls
                If Container.GetType() Is GetType(Panel) Then
                    ClearSubControls(Tab)
                End If
            Next
        Next
        pnl_estatus.Visible = False

        Dim Wait As New frmWait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
        Wait.ShowDialog()
        txtNumero.Text = Wait.Result.ToString()
        Wait.Close()

        txtNumero.Text = objcon.NUMERO_EMPLEADO.ToString()
        txtNumero.Focus()

        lbl_emp.Text = ""
        PbOptions.Tag = ""
        pbFotoEmpleado.Image = My.Resources.photoNobody120
        pbFotoEmpleado.Visible = True
        'llenarFamilia()
        'llenarAL()
        'llenarContacto()
        'llenarEnfermedades()
        PB_IMAGE_VIVIENDA.Image = My.Resources.AddImage
        EMPLEADO_ES = 0
        dgv_OI.DataSource = objcon.Consulta_OI(0)
        dgv_Ref.DataSource = objcon.Consulta_REF(0)
        SAVE.Image = My.Resources.Save_80px
        btn_SESave.Image = My.Resources.Save_80px
        AddToolTips()
    End Sub















    Private Sub txt_OTCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_OTCantidad.KeyPress
        If Not txt_OTCantidad.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_GFRenta_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txt_GFCole_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Txt_GFDesp_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txt_GFServ_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Btn_AddRef_Click(sender As Object, e As EventArgs) Handles Btn_AddRef.Click
        If EXISTE = True Then
            If txt_RefNom.Text = "" Or txt_RefOcu.Text = "" Or txt_TC.Text = "" Or Txt_TR.Text = "" Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"REFID", 0}, {"Name", txt_RefNom.Text},
                        {"Ocupation", txt_RefOcu.Text}, {"Relationship", Txt_TR.Text}, {"Time", txt_TC.Text}}
                Dim Wait As New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateReference
                    }
                Wait.ShowDialog()
                Dim loResult As Dictionary(Of String, Object) = Wait.Result
                If loResult("Valid") = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                dgv_Ref.DataSource = loResult("Source")
                Wait.Close()

                txt_RefOcu.Text = ""
                txt_RefNom.Text = ""
                txt_TC.Text = ""
                Txt_TR.Text = ""
            End If
        End If
    End Sub

    Private Sub btn_OI_Click(sender As Object, e As EventArgs) Handles btn_OI.Click
        If EXISTE = True Then
            If txt_OTCantidad.Text = "" Or txt_OIParen.Text = "" Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"ICMID", 0}, {"Relationship", txt_OIParen.Text}, {"Amount", txt_OTCantidad.Text}}
                Dim Wait As New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateIncome
                    }
                Wait.ShowDialog()
                Dim loResult As Dictionary(Of String, Object) = Wait.Result
                If loResult("Valid") = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                dgv_OI.DataSource = loResult("Source")
                Wait.Close()

                txt_RefOcu.Text = ""
                txt_RefNom.Text = ""
                txt_TC.Text = ""
                Txt_TR.Text = ""
            End If
        End If
    End Sub

    Private Sub btn_SESave_Click(sender As Object, e As EventArgs) Handles btn_SESave.Click
        If EXISTE = True Then
            Dim ES As New Cls_ES()
            ES.SES_ID = EMPLEADO_ES
            ES.EMP_ID = EMPLEADO_ID
            If cb_CasaP.Checked = True Then
                ES.H_TYPE = "CASA PROPIA"
            End If
            If cb_Depto.Checked = True Then
                ES.H_TYPE = "DEPARTAMENTO"
            End If
            If cb_Renta.Checked = True Then
                ES.H_TYPE = "CASA DE RENTA"
            End If
            If cb_Terreno.Checked = True Then
                ES.H_TYPE = "TERRENO"
            End If
            If cb_adobe.Checked = True Then
                ES.H_CONDITION = "ADOBE"
            End If
            If cb_block.Checked = True Then
                ES.H_CONDITION = "BLOCK"
            End If
            If cb_Madera.Checked = True Then
                ES.H_CONDITION = "MADERA"
            End If
            If cb_ladrillo.Checked = True Then
                ES.H_CONDITION = "LADRILLO"
            End If
            ES.H_ELEC = cb_Luz.Checked
            ES.H_PHONE = cb_LineaTel.Checked
            ES.H_WATER = cb_AguaP.Checked
            ES.H_SEWER = cb_Drenaje.Checked
            ES.H_GAS = cb_Tuberia.Checked
            ES.H_TRASHREC = cb_Basura.Checked
            ES.H_CABLETV = cb_Internet.Checked
            ES.H_INTERNET = cb_Internet.Checked
            ES.H_SECURITY = cb_SisSeg.Checked
            ES.T_METRO = cb_Metro.Checked
            ES.T_PUBLIC = cb_Trans.Checked
            ES.T_TAX = cb_Taxi.Checked
            ES.T_CAR = cb_Vehi.Checked
            If txt_SE__SOCIALE.Text = "" Then
                ES.A_SOCIAL = "0"
            Else
                ES.A_SOCIAL = txt_SE__SOCIALE.Text
            End If
            If txt_SE_EVENTOS.Text = "" Then
                ES.A_COMUNITARY = "0"
            Else
                ES.A_COMUNITARY = txt_SE_EVENTOS.Text
            End If
            If txt_SE_MUSEOS.Text = "" Then
                ES.A_COMUNITARY = "0"
            Else
                ES.A_COMUNITARY = txt_SE_MUSEOS.Text
            End If
            If txt_SE_TEATROS.Text = "" Then
                ES.A_THEATERS = "0"
            Else
                ES.A_THEATERS = txt_SE_TEATROS.Text
            End If
            If txt_SE_CINES.Text = "" Then
                ES.A_MOVIES = "0"
            Else
                ES.A_MOVIES = txt_SE_CINES.Text
            End If
            If txt_SE_CULTURALES.Text = "" Then
                ES.A_FESTIVALS = "0"
            Else
                ES.A_FESTIVALS = txt_SE_CULTURALES.Text
            End If
            If txt_SE_ZONAS.Text = "" Then
                ES.A_ARCHE = "0"
            Else
                ES.A_ARCHE = txt_SE_ZONAS.Text
            End If
            If txt_SE_VACIONES.Text = "" Then
                ES.A_VACATIONS = "0"
            Else
                ES.A_VACATIONS = txt_SE_VACIONES.Text
            End If
            If txt_SE_PLAZAS.Text = "" Then
                ES.A_PLAZAS = "0"
            Else
                ES.A_PLAZAS = txt_SE_PLAZAS.Text
            End If
            If txt_SE_NATURALES.Text = "" Then
                ES.A_NPARK = "0"
            Else
                ES.A_NPARK = txt_SE_NATURALES.Text
            End If
            If txt_se_diversiones.Text = "" Then
                ES.A_APARK = "0"
            Else
                ES.A_APARK = txt_se_diversiones.Text
            End If
            ES.FS_RENT = txt_GFRenta.Text
            ES.FS_SCHOOL = txt_GFCole.Text
            ES.FS_GROCERIES = Txt_GFDesp.Text
            ES.FS_SERVICES = txt_GFServ.Text
            ES.SES_HOBBIES = Txt_pasatiempos.Text
            ES.SES_RELIGION = txt_Religion.Text
            ES.SES_VERIFIER = UsuarioLogeado.Nombre
            ES.SES_OBSERVATIONS = txt_commen.Text
            ES.IMG = PB_IMAGE_VIVIENDA.Image

            Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", ES}}
            Dim Wait As New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddSocialEconomicStudy
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            Wait.Close()


            If loResult > 0 Then
                If Not ReferenceEquals(PB_IMAGE_VIVIENDA.Image, My.Resources.AddImage) Then
                    ldParameters = New Dictionary(Of String, Object) From {{"Employee", ES.EMP_ID}, {"HousePicture", ES.IMG}, {"EmployeePicture", pbFotoEmpleado.Image}}
                    Wait = New frmWait With {.Parameters = ldParameters, .Operation = BackgroundOperations.AddImage}
                    Wait.ShowDialog()
                    Wait.Close()
                End If

                If dgv_Ref.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgv_Ref.Rows
                        If Not row.IsNewRow Then
                            ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"REFID", row.Cells(1).Value.ToString}, {"Name", row.Cells(2).Value.ToString},
                                       {"Ocupation", row.Cells(3).Value.ToString}, {"Relationship", row.Cells(4).Value.ToString}, {"Time", row.Cells(5).Value.ToString}}
                            Wait = New frmWait With {
                                .Parameters = ldParameters,
                                .Operation = BackgroundOperations.ValidateReference
                            }
                            Wait.ShowDialog()
                            Dim loResult3 As Dictionary(Of String, Object) = Wait.Result
                            Wait.Close()

                            If loResult3("Valid") = False Then
                                MessageBox.Show("Este registro ya Existe.")
                            End If
                        End If
                    Next
                End If
                If dgv_OI.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgv_OI.Rows
                        If Not row.IsNewRow Then
                            ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"ICMID", row.Cells(1).Value.ToString}, {"Relationship", row.Cells(2).Value.ToString},
                                             {"Amount", Convert.ToDouble(row.Cells(3).Value.ToString)}}
                            Wait = New frmWait With {
                                    .Parameters = ldParameters,
                                    .Operation = BackgroundOperations.ValidateIncome
                                }
                            Wait.ShowDialog()
                            Dim loResult4 As Dictionary(Of String, Object) = Wait.Result
                            Wait.Close()
                            If loResult4("Valid") = False Then
                                MessageBox.Show("Este registro ya Existe.")
                            End If
                        End If
                    Next
                End If
                If MessageBox.Show("Se ha guardado el Estudio Socioeconomico con exito ¿Desea ver el reporte?",
                                   "Estudio Socioeconomico guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    btn_SERPT_Click(sender, e)
                End If
                Limp()
            End If
        End If
    End Sub

    Private Sub btn_SECancel_Click(sender As Object, e As EventArgs) Handles btn_SECancel.Click
        Limp()
    End Sub











    Private Sub llenarSE()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetSocialEconomicStudy
                    }
        Wait.ShowDialog()
        Dim loResult As Cls_ES = Wait.Result
        Wait.Close()
        If loResult IsNot Nothing Then
            Select Case loResult.H_TYPE
                Case "CASA PROPIA"
                    cb_CasaP.Checked = True
                Case "DEPARTAMENTO"
                    cb_Depto.Checked = True
                Case "CASA DE RENTA"
                    cb_Renta.Checked = True
                Case "TERRENO"
                    cb_Terreno.Checked = True
            End Select
            Select Case loResult.H_CONDITION
                Case "ADOBE"
                    cb_adobe.Checked = True
                Case "BLOCK"
                    cb_block.Checked = True
                Case "MADERA"
                    cb_Madera.Checked = True
                Case "LADRILLO"
                    cb_ladrillo.Checked = True
            End Select
            cb_Luz.Checked = loResult.H_ELEC
            cb_LineaTel.Checked = loResult.H_PHONE
            cb_AguaP.Checked = loResult.H_WATER
            cb_Drenaje.Checked = loResult.H_SEWER
            cb_Tuberia.Checked = loResult.H_GAS
            cb_Basura.Checked = loResult.H_TRASHREC
            cb_TV.Checked = loResult.H_CABLETV
            cb_Internet.Checked = loResult.H_INTERNET
            cb_SisSeg.Checked = loResult.H_SECURITY
            cb_Metro.Checked = loResult.T_METRO
            cb_Trans.Checked = loResult.T_PUBLIC
            cb_Taxi.Checked = loResult.T_TAX
            cb_Vehi.Checked = loResult.T_CAR

            txt_SE__SOCIALE.Text = loResult.A_SOCIAL.ToString()
            txt_SE_EVENTOS.Text = loResult.A_COMUNITARY.ToString()
            txt_SE_MUSEOS.Text = loResult.A_MUSEUMS.ToString()
            txt_SE_CINES.Text = loResult.A_THEATERS.ToString()
            txt_SE_CULTURALES.Text = loResult.A_FESTIVALS.ToString()
            txt_SE_ZONAS.Text = loResult.A_ARCHE.ToString()
            txt_SE_VACIONES.Text = loResult.A_VACATIONS.ToString()
            txt_SE_PLAZAS.Text = loResult.A_PLAZAS.ToString()
            txt_SE_NATURALES.Text = loResult.A_NPARK.ToString()
            txt_se_diversiones.Text = loResult.A_APARK.ToString()
            txt_GFRenta.Text = loResult.FS_RENT.ToString()
            txt_GFCole.Text = loResult.FS_SCHOOL.ToString()
            Txt_GFDesp.Text = loResult.FS_GROCERIES.ToString()
            txt_GFServ.Text = loResult.FS_SERVICES.ToString()
            Txt_pasatiempos.Text = loResult.SES_HOBBIES
            txt_Religion.Text = loResult.SES_RELIGION
            txt_commen.Text = loResult.SES_OBSERVATIONS
            PB_IMAGE_VIVIENDA.Image = loResult.IMG
            EMPLEADO_ES = loResult.SES_ID
            btn_SESave.Image = My.Resources.Updates_80
            tooltip.SetToolTip(btn_SESave, "Actualizar Estudio Socioeconomico")
        Else
            btn_SESave.Image = My.Resources.Save_80px
            EMPLEADO_ES = 0
        End If
        ldParameters = New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}}
        Wait = New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetIncome
                    }
        Wait.ShowDialog()
        Dim loResult2 = Wait.Result
        Wait.Close()
        dgv_OI.DataSource = loResult2
        Wait = New frmWait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetReference
                    }
        Wait.ShowDialog()
        Dim loResult3 = Wait.Result
        Wait.Close()
        dgv_Ref.DataSource = loResult3
    End Sub
    Private Sub cb_CasaP_CheckedChanged(sender As Object, e As EventArgs) Handles cb_CasaP.CheckedChanged
        If cb_CasaP.Checked = True Then
            cb_Renta.Checked = False
            cb_Terreno.Checked = False
            cb_Depto.Checked = False
        End If
    End Sub
    Private Sub cb_Renta_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Renta.CheckedChanged
        If cb_Renta.Checked = True Then
            cb_CasaP.Checked = False
            cb_Terreno.Checked = False
            cb_Depto.Checked = False
        End If
    End Sub
    Private Sub cb_Terreno_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Terreno.CheckedChanged
        If cb_Terreno.Checked = True Then
            cb_Renta.Checked = False
            cb_CasaP.Checked = False
            cb_Depto.Checked = False
        End If
    End Sub
    Private Sub cb_Depto_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Depto.CheckedChanged
        If cb_Depto.Checked = True Then
            cb_Renta.Checked = False
            cb_Terreno.Checked = False
            cb_CasaP.Checked = False
        End If
    End Sub
    Private Sub cb_adobe_CheckedChanged(sender As Object, e As EventArgs) Handles cb_adobe.CheckedChanged
        If cb_adobe.Checked = True Then
            cb_ladrillo.Checked = False
            cb_block.Checked = False
            cb_Madera.Checked = False
        End If
    End Sub
    Private Sub cb_ladrillo_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ladrillo.CheckedChanged
        If cb_ladrillo.Checked = True Then
            cb_adobe.Checked = False
            cb_block.Checked = False
            cb_Madera.Checked = False
        End If
    End Sub
    Private Sub cb_block_CheckedChanged(sender As Object, e As EventArgs) Handles cb_block.CheckedChanged
        If cb_block.Checked = True Then
            cb_ladrillo.Checked = False
            cb_adobe.Checked = False
            cb_Madera.Checked = False
        End If
    End Sub
    Private Sub cb_Madera_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Madera.CheckedChanged
        If cb_Madera.Checked = True Then
            cb_ladrillo.Checked = False
            cb_block.Checked = False
            cb_adobe.Checked = False
        End If
    End Sub

    Private Sub btn_SERPT_Click(sender As Object, e As EventArgs) Handles btn_SERPT.Click
        If txt_numero.Text <> "" Then
            Dim Wait As New frmWait()
            Wait.Operation = BackgroundOperations.JustShowScreen
            Wait.Show()
            Dim Reportes As New FrmReportes With( {
                    .Opcion = ReportOptions.SocialeconomicStudy,
                    .Emp = Convert.ToInt64(txt_numero.Text),
                    .User = UsuarioLogeado.Nombre
                }
            Reportes.ShowDialog()
        End If
    End Sub



    Private Sub PB_IMAGE_VIVIENDA_DoubleClick(sender As Object, e As EventArgs) Handles PB_IMAGE_VIVIENDA.DoubleClick
        CargarImagen(PB_IMAGE_VIVIENDA)
    End Sub








    Private Sub dgv_OI_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_OI.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnEIngresos"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_OI(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            If EMPLEADO_ES <> 0 Then
                dgv_OI.DataSource = objcon.Consulta_OI(EMPLEADO_ES)
            End If

        End If
    End Sub

    Private Sub dgv_Ref_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Ref.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnEReferencia"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_REF(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            If EMPLEADO_ES <> 0 Then
                dgv_Ref.DataSource = objcon.Consulta_REF(EMPLEADO_ES)
            End If
        End If
    End Sub

    Private Sub txt_SE__SOCIALE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE__SOCIALE.KeyPress
        Dim txt_SE__SOCIALE As TextBox = CType(sender, TextBox)
        If Not txt_SE__SOCIALE.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_TEATROS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_TEATROS.KeyPress
        Dim txt_SE_TEATROS As TextBox = CType(sender, TextBox)
        If Not txt_SE_TEATROS.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_NATURALES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_NATURALES.KeyPress
        Dim txt_SE_NATURALES As TextBox = CType(sender, TextBox)
        If Not txt_SE_NATURALES.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_CINES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_CINES.KeyPress
        Dim txt_SE_CINES As TextBox = CType(sender, TextBox)
        If Not txt_SE_CINES.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_PLAZAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_PLAZAS.KeyPress
        Dim txt_SE_PLAZAS As TextBox = CType(sender, TextBox)
        If Not txt_SE_PLAZAS.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_EVENTOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_EVENTOS.KeyPress
        Dim txt_SE_EVENTOS As TextBox = CType(sender, TextBox)
        If Not txt_SE_EVENTOS.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_CULTURALES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_CULTURALES.KeyPress
        Dim txt_SE_CULTURALES As TextBox = CType(sender, TextBox)
        If Not txt_SE_CULTURALES.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_VACIONES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_VACIONES.KeyPress
        Dim txt_SE_VACIONES As TextBox = CType(sender, TextBox)
        If Not txt_SE_VACIONES.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_MUSEOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_MUSEOS.KeyPress
        Dim txt_SE_MUSEOS As TextBox = CType(sender, TextBox)
        If Not txt_SE_MUSEOS.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_SE_ZONAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SE_ZONAS.KeyPress
        Dim txt_SE_ZONAS As TextBox = CType(sender, TextBox)
        If Not txt_SE_ZONAS.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txt_se_diversiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_se_diversiones.KeyPress
        Dim txt_se_diversiones As TextBox = CType(sender, TextBox)
        If Not txt_se_diversiones.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub


End Class