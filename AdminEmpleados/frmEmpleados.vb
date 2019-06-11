Imports System.Text.RegularExpressions

Public Class frmEmpleados
    Dim ErrorProvider As New ErrorProvider
    Dim tooltip As New ToolTip
    Dim Resultado As Object
    Dim Empleado As Empleado = Nothing
    Dim EstudioSocioeconomico As EstudioSocioeconomico
    Dim Familiares As List(Of Familiar.Vista)
    Dim OtrosIngresos As List(Of OtroIngreso)
    Dim OtrosIngresosLocal As List(Of OtroIngreso)
    Dim Referencias As List(Of Referencia)
    Dim ReferenciasLocal As List(Of Referencia)
    Private EstudioSocioeconomicoOpcion As Operacion

    Sub New()
        InitializeComponent()
        CargarCombos()
        AsignarFechas()
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AddToolTips()
        'Dim Wait As New frmWait With {
        '    .Operation = BackgroundOperations.GetLatestEmployeeNumber
        '}
        'Wait.ShowDialog()
        'txtNumero.Text = Wait.Result.ToString()
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
        tooltip.SetToolTip(pbVivienda, "Haz doble clic para agregar una nueva imagen")
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

    Private Sub MenuEmp_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles MenuEmp.Selecting
        If MenuEmp.SelectedIndex <> 0 Then
            If Empleado Is Nothing Then
                MenuEmp.SelectedIndex = 0
                MessageBox.Show("No se encontro un empleado, intente dar de alta uno nuevo o seleccionar uno existente.", "Empleado no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub ClearSubControls(Parent As Control)
        Empleado = Nothing
        For Each ctrl As Control In Parent.Controls
            If ctrl.GetType() Is GetType(TextBox) Or ctrl.GetType() Is GetType(NumericTextbox) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
                Continue For
            End If
            If ctrl.GetType() Is GetType(DateTimePicker) Then
                Dim dt As DateTimePicker = CType(ctrl, DateTimePicker)
                If dt.MaxDate = DateTimePicker.MaximumDateTime Then
                    dt.Value = Today()
                Else
                    dt.Value = dt.MaxDate
                End If

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
        'MenuEmp.SelectedIndex = 0
        'EMPLEADO_ID = 0
        'For Each Tab As TabPage In MenuEmp.TabPages
        '    For Each Container As Control In Tab.Controls
        '        If Container.GetType() Is GetType(Panel) Then
        '            ClearSubControls(Tab)
        '        End If
        '    Next
        'Next
        'pnl_estatus.Visible = False

        'Dim Wait As New frmWait With {
        '    .Operation = BackgroundOperations.GetLatestEmployeeNumber
        '}
        'Wait.ShowDialog()
        'txtNumero.Text = Wait.Result.ToString()
        'Wait.Close()

        'txtNumero.Text = objcon.NUMERO_EMPLEADO.ToString()
        'txtNumero.Focus()

        'lbl_emp.Text = ""
        'PbOptions.Tag = ""
        'pbFotoEmpleado.Image = My.Resources.AddImage_80px
        'pbFotoEmpleado.Visible = True
        ''llenarFamilia()
        ''llenarAL()
        ''llenarContacto()
        ''llenarEnfermedades()
        'pbVivienda.Image = My.Resources.AddImage_80px
        'EMPLEADO_ES = 0
        'dgv_OI.DataSource = objcon.Consulta_OI(0)
        'dgv_Ref.DataSource = objcon.Consulta_REF(0)
        'SAVE.Image = My.Resources.Save_80px
        'btn_SESave.Image = My.Resources.Save_80px
        'AddToolTips()
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
        If Empleado IsNot Nothing Then
            SAVE.Image = My.Resources.Updates_80
            SAVE.Tag = Operacion.Actualizar
            With Empleado
                If .Foto IsNot My.Resources.AddImage_80px Then
                    pbFotoEmpleado.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pbFotoEmpleado.SizeMode = PictureBoxSizeMode.CenterImage
                End If
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
        Else
            SAVE.Image = My.Resources.Save_80px
            SAVE.Tag = Operacion.Registrar
        End If

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

    Private Sub Dgv_esposa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEsposa.CellClick
        If e.ColumnIndex = 0 Then
            EliminarFamiliar(CType(dgvEsposa.CurrentRow.DataBoundItem, Familiar.Vista))
        End If
    End Sub

    Private Sub Dgv_Hijos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHijos.CellClick
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

    Private Sub Dgv_ant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAntecedentesLaborales.CellClick
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

    Private Sub Dgv_contacto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContactos.CellClick
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
    Private Sub LlenarDatosEstudioSocioeconomico()
        EstudioSocioeconomico = New EstudioSocioeconomico().Buscar(Empleado.ID)
        If EstudioSocioeconomico IsNot Nothing Then
            btn_SESave.Image = My.Resources.Updates_80
            EstudioSocioeconomicoOpcion = Operacion.Actualizar
            tooltip.SetToolTip(btn_SESave, "Actualizar Estudio Socioeconomico")
            With EstudioSocioeconomico

                If .FotoVivienda IsNot Nothing Then
                    pbVivienda.Image = EstudioSocioeconomico.FotoVivienda
                    pbVivienda.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    pbVivienda.Image = My.Resources.AddImage_80px
                    pbVivienda.SizeMode = PictureBoxSizeMode.CenterImage
                End If
                rbtnTipoDeVivienda.SelectedValue = .TipoDeVivienda
                rbtnMaterial.SelectedValue = .CondicionesDeVivienda
                cb_Luz.Checked = .ServicioLuz
                cb_Drenaje.Checked = .ServicioDrenaje
                cb_Basura.Checked = .ServicioRecoleccionDeBasura
                cb_AguaP.Checked = .ServicioAgua
                cb_Tuberia.Checked = .ServicioGas
                cb_Internet.Checked = .ServicioDeInternet
                cb_LineaTel.Checked = .ServicioTelefono
                cb_TV.Checked = .ServicioTVCable
                cb_SisSeg.Checked = .ServicioSistemaDeSeguridad

                cb_Metro.Checked = .TransporteMetro
                cb_Trans.Checked = .TransportePublico
                cb_Taxi.Checked = .TransporteTaxi
                cb_Vehi.Checked = .TransporteVehiculoPropio

                Txt_pasatiempos.Text = .Pasatiempos
                txt_Religion.Text = .Religion

                txt_EventosComunitarios.Text = .ActividadEventosCominitarios
                txt_EventosSociales.Text = .ActividadEventosSociales
                txt_FestivalesCulturales.Text = .ActividadFestivalesCulturales
                txt_teatros.Text = .ActividadTeatros
                txt_Vacaciones.Text = .ActividadVaciones
                txt_ParquesNaturales.Text = .ActividadParquesNaturales
                txt_Museos.Text = .ActividadMuseos
                txt_Cines.Text = .ActividadCines
                txt_ZonasArquelogicas.Text = .ActividadZonasArqueologicas
                txt_PlazasPublicas.Text = .ActividadPlazasPublicas
                txt_ParqueDeDiversiones.Text = .ActividadParquesDeDiversiones

                txt_GFCole.Text = .GastosFijosColegio
                Txt_GFDesp.Text = .GastosFijosDespensa
                txt_GFRenta.Text = .GastosFijosRenta
                txt_GFServ.Text = .GastosFijosServicios

                txt_Observaciones.Text = .Observaciones

                LlenarOtrosIngresos(.ID)
                LlenarReferencias(.ID)
            End With
        Else
            EstudioSocioeconomico = New EstudioSocioeconomico()
            btn_SESave.Image = My.Resources.Save_80px
            EstudioSocioeconomicoOpcion = Operacion.Registrar
            tooltip.SetToolTip(btn_SESave, "Guardar Estudio Socioeconomico")
        End If
    End Sub

    Private Sub Btn_SESave_Click(sender As Object, e As EventArgs) Handles btn_SESave.Click
        With EstudioSocioeconomico
            With EstudioSocioeconomico
                .Empleado = Empleado.ID
                .FotoVivienda = pbVivienda.Image
                .TipoDeVivienda = rbtnTipoDeVivienda.SelectedValue
                .CondicionesDeVivienda = rbtnMaterial.SelectedValue
                .ServicioLuz = cb_Luz.Checked
                .ServicioDrenaje = cb_Drenaje.Checked
                .ServicioRecoleccionDeBasura = cb_Basura.Checked
                .ServicioAgua = cb_AguaP.Checked
                .ServicioGas = cb_Tuberia.Checked
                .ServicioDeInternet = cb_Internet.Checked
                .ServicioTelefono = cb_LineaTel.Checked
                .ServicioTVCable = cb_TV.Checked
                .ServicioSistemaDeSeguridad = cb_SisSeg.Checked

                .TransporteMetro = cb_Metro.Checked
                .TransportePublico = cb_Trans.Checked
                .TransporteTaxi = cb_Taxi.Checked
                .TransporteVehiculoPropio = cb_Vehi.Checked

                .Pasatiempos = Txt_pasatiempos.Text
                .Religion = txt_Religion.Text

                .ActividadEventosCominitarios = txt_EventosComunitarios.Text
                .ActividadEventosSociales = txt_EventosSociales.Text
                .ActividadFestivalesCulturales = txt_FestivalesCulturales.Text
                .ActividadTeatros = txt_teatros.Text
                .ActividadVaciones = txt_Vacaciones.Text
                .ActividadParquesNaturales = txt_ParquesNaturales.Text
                .ActividadMuseos = txt_Museos.Text
                .ActividadCines = txt_Cines.Text
                .ActividadZonasArqueologicas = txt_ZonasArquelogicas.Text
                .ActividadPlazasPublicas = txt_PlazasPublicas.Text
                .ActividadParquesDeDiversiones = txt_ParqueDeDiversiones.Text

                .GastosFijosColegio = txt_GFCole.Text
                .GastosFijosDespensa = Txt_GFDesp.Text
                .GastosFijosRenta = txt_GFRenta.Text
                .GastosFijosServicios = txt_GFServ.Text

                .Observaciones = txt_Observaciones.Text

                If EstudioSocioeconomicoOpcion = Operacion.Registrar Then
                    If Not .Registrar() Then
                        Exit Sub
                    End If
                Else
                    If Not .Actualizar() Then
                        Exit Sub
                    End If
                End If
                OtrosIngresos = New OtroIngreso().CargarListado(.ID)
                .OperacionDeOtrosIngresos(OtrosIngresos, OtrosIngresosLocal)
                dgv_OI.Refresh()

                Referencias = New Referencia().CargarListado(.ID)
                .OperacionDeReferencias(Referencias, ReferenciasLocal)
                dgv_Ref.Refresh()
            End With
        End With

    End Sub

    Private Sub Btn_SECancel_Click(sender As Object, e As EventArgs) Handles btn_SECancel.Click
        Limp()
    End Sub

    Private Sub Btn_SERPT_Click(sender As Object, e As EventArgs) Handles btn_SERPT.Click
        'If txt_numero.Text <> "" Then
        '    Dim Wait As New frmWait()
        '    Wait.Operation = BackgroundOperations.JustShowScreen
        '    Wait.Show()
        '    Dim Reportes As New FrmReportes With( {
        '            .Opcion = ReportOptions.SocialeconomicStudy,
        '            .Emp = Convert.ToInt64(txt_numero.Text),
        '            .User = UsuarioLogeado.Nombre
        '        }
        '    Reportes.ShowDialog()
        'End If
    End Sub

    Private Sub PbVivienda_DoubleClick(sender As Object, e As EventArgs) Handles pbVivienda.DoubleClick
        CargarImagen(pbVivienda)
    End Sub


#Region "Otros Ingresos"

    Private Sub LlenarOtrosIngresos(ESID As Integer)
        OtrosIngresos = New OtroIngreso().CargarListado(ESID)
        OtrosIngresosLocal = New OtroIngreso().CargarListado(ESID)
        dgv_OI.DataSource = OtrosIngresosLocal
    End Sub

    Private Sub Btn_OI_Click(sender As Object, e As EventArgs) Handles btn_OI.Click
        Dim ESID As Integer = 0
        If EstudioSocioeconomico.ID <> 0 Then
            ESID = EstudioSocioeconomico.ID
        End If
        Dim loOtroIngreso As New OtroIngreso(0, ESID, txt_OIParen.Text, txt_OICantidad.Text)
        If loOtroIngreso.RegistrarLocal(OtrosIngresosLocal) Then
            dgv_OI.DataSource = Nothing
            dgv_OI.DataSource = OtrosIngresosLocal
            txt_OIParen.Text = ""
            txt_OICantidad.Text = ""
        End If
    End Sub

    Private Sub Dgv_OI_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_OI.CellClick
        If e.ColumnIndex = 0 Then
            Dim loLista As List(Of OtroIngreso) = dgv_OI.DataSource
            If CType(dgv_OI.CurrentRow.DataBoundItem, OtroIngreso).EliminarLocal(loLista) Then
                dgv_OI.DataSource = Nothing
                dgv_OI.DataSource = loLista
            End If
        End If
    End Sub
#End Region

#Region "Referencias"
    Private Sub LlenarReferencias(ESID As Integer)
        Referencias = New Referencia().CargarListado(ESID)
        ReferenciasLocal = New Referencia().CargarListado(ESID)
        dgv_Ref.DataSource = ReferenciasLocal
    End Sub

    Private Sub Btn_AddRef_Click(sender As Object, e As EventArgs) Handles Btn_AddRef.Click
        Dim ESID As Integer = 0
        If EstudioSocioeconomico.ID <> 0 Then
            ESID = EstudioSocioeconomico.ID
        End If
        Dim loReferencia As New Referencia(0, ESID, txt_RefNom.Text, txt_RefOcu.Text, Txt_TipoDeRelacion.Text, txt_TiempoDeConocerse.Text)
        If loReferencia.RegistrarLocal(ReferenciasLocal) Then
            dgv_Ref.DataSource = Nothing
            dgv_Ref.DataSource = ReferenciasLocal
            txt_RefNom.Text = ""
            txt_RefOcu.Text = ""
            Txt_TipoDeRelacion.Text = ""
            txt_TiempoDeConocerse.Text = ""
        End If
    End Sub

    Private Sub Dgv_Ref_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Ref.CellClick
        If e.ColumnIndex = 0 Then
            Dim loLista As List(Of Referencia) = dgv_Ref.DataSource
            If CType(dgv_Ref.CurrentRow.DataBoundItem, Referencia).EliminarLocal(dgv_Ref.DataSource) Then
                dgv_Ref.DataSource = Nothing
                dgv_Ref.DataSource = loLista
            End If
        End If
    End Sub


#End Region

#End Region

















End Class