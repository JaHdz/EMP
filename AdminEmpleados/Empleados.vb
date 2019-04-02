Imports System.IO
Imports System.Text.RegularExpressions

Public Class Empleados
    Dim V1 As String
    Dim V2 As String
    Dim aux As Integer
    Dim EXISTE As Boolean = False
    Dim objcon As New Consultas
    Dim EMPLEADO_ID As Int64
    Dim EMPLEADO_ES As Int64
    Dim id As Integer
    Dim NEmp As Integer
    Dim NName As String

    Sub New(ByVal emp As Integer, name As String)
        InitializeComponent()
        NEmp = emp
        NName = name
    End Sub

    Private Sub Numeroleave()
        Dim numero As String
        numero = txt_numero.Text
        txt_activo.Text = ""
        txt_baja.Text = ""
        lbl_option.Visible = True
        PbOptions.Visible = True

        If txt_numero.Text <> "" Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", numero}}
            Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.EmployeeExits
            }
            Wait.ShowDialog()
            Dim Result As Boolean = Wait.Result
            Wait.Close()
            If Result = True Then
                Llenar()
                EXISTE = True
                lbl_emp.Text = numero + " | " + txt_NOM.Text + " " + txt_AP.Text + " " + txt_AM.Text
                EMPLEADO_ID = numero
                PbOptions.Tag = "BAJA"

            Else
                limp()
                lbl_emp.Text = ""
                EMPLEADO_ID = 0
                txt_numero.Text = numero
                EXISTE = False
                PbOptions.Tag = "ALTA"
            End If
        Else
            txt_numero.Focus()
        End If
    End Sub
    Public Sub Llenar()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", txt_numero.Text}}
        Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.GetEmployeeInfo
            }
        Wait.ShowDialog()
        Dim Result As Cls_Emp = Wait.Result
        Wait.Close()
        If (Result IsNot Nothing) Then
            txt_AP.Text = Result.Emp_APat
            txt_AM.Text = Result.Emp_AMat
            txt_NOM.Text = Result.Emp_Name
            ddl_educacion.SelectedItem = Result.Emp_NEducativo
            txt_FECHA.Text = Result.Emp_FNac.ToShortDateString()
            txt_RFC.Text = Result.Emp_RFC
            txt_SS.Text = Result.Emp_NSS
            txt_CURP.Text = Result.Emp_Curp
            Celular.Text = Result.Emp_Cel
            txt_telefono.Text = Result.Emp_Tel
            EC.Text = Result.Emp_EdoCivil
            nacion.Text = Result.Emp_Nacionalidad
            domicilio.Text = Result.Emp_Domicilio
            colonia.Text = Result.Emp_Col
            txtCdDomicilio.Text = Result.Emp_CiudadEstado
            CP.Text = Result.Emp_CP
            txt_FECHAINGRESO.Text = Result.Emp_FEfectiva.ToShortDateString()
            txt_SALARY.Text = Result.Emp_Salario
            Txt_correo.Text = Result.Emp_Email
            txt_baja.Text = If(IsDBNull(Result.Emp_Activo), "", Result.Emp_Activo)
            seg.Checked = If(IsDBNull(Result.Baja.Alerta), False, True)
            CB_PROV.Checked = If(IsDBNull(Result.Baja.NotificarProveedores), False, True)
            CB_CLIENTE.Checked = If(IsDBNull(Result.Baja.NotificarClientes), False, True)
            commen.Text = Result.Baja.Motivo
            txt_EN.Text = Result.Emp_EN
            txt_PUESTO.Text = Result.ID_Puesto
            txt_tipo.Text = Result.Emp_Tipo
            txt_SUPER.Text = Result.Emp_Sup
            cuidad.Text = Result.Emp_Ciudad
            depto.Text = Result.ID_Depto
            foto.Image = Result.Img

            If txt_EN.Text <> "" Then
                V2 = objcon.S_catalago(txt_EN.Text, "EN")
                txt_EN2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If (cuidad.Text <> "") Then
                V2 = objcon.S_catalago(cuidad.Text, "CI")
                cuidad2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If (depto.Text <> "") Then
                V2 = objcon.S_catalago(depto.Text, "DE")
                depto2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If (txt_PUESTO.Text <> "") Then
                V2 = objcon.S_catalago(txt_PUESTO.Text, "PU")
                txt_PUESTO2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If (txt_SUPER.Text <> "") Then
                V2 = objcon.S_catalago(txt_SUPER.Text, "SU")
                txt_SUPER2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If (txt_tipo.Text <> "") Then
                V2 = objcon.S_catalago(txt_tipo.Text, "TI")
                txt_tipo2.Text = If(V2 = "" Or V2 Is Nothing, "", V2)
            End If

            If Result.Emp_Sexo = "M" Then
                CB_SEXO.SelectedIndex = 1
            End If

            If Result.Emp_Sexo = "F" Then
                CB_SEXO.SelectedIndex = 0
            End If

            txt_activo.Text = If(Result.Emp_Activo = True, "SI", "NO")

            If Result.Emp_Activo = True Then
                txt_baja.Text = ""
                seg.Checked = False
                CB_CLIENTE.Checked = False
                CB_PROV.Checked = False
                commen.Text = ""

                lbl_option.Text = "BAJA"
                PbOptions.Image = My.Resources.Baja_80px
            Else
                txt_baja.Text = Result.Baja.Fecha_Baja.ToShortDateString()
                lbl_option.Text = "ALTA"
                PbOptions.Image = My.Resources.Alta_80px
            End If
            lbl_option.Visible = True
            PbOptions.Tag = lbl_option.Text
            PbOptions.Visible = True
        End If
    End Sub
    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_PUESTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PUESTO.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_SUPER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SUPER.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_CLASE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tipo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub Txt_SALARY_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not txt_SALARY.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub
    Private Sub txt_SS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SS.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Public Function validateEmail(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If (Txt_correo.Text = "") Then
            Return True
        Else
            If email.IsMatch(emailAddress) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        'Try
        For Each ctrl In pnl_per.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    MessageBox.Show("Favor de llenar todos los campos en la seccion 'Personales'")
                    Exit Sub
                End If
            End If
        Next

        For Each ctrl In pnl_cont.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    MessageBox.Show("Favor de llenar todos los campos en la seccion 'Contratacion'")
                    Exit Sub
                End If
            End If
        Next
        SAVE_F()
        lbl_emp.Text = ""
        lbl_emp.Text = txt_numero.Text + " | " + txt_NOM.Text + " " + txt_AP.Text + " " + txt_AM.Text
        EMPLEADO_ID = txt_numero.Text
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        'End Try
    End Sub
    Private Sub SAVE_F()
        If validateEmail(Txt_correo.Text) = True Then
            Dim InfoEmp As New Cls_Emp
            Dim objEmp As New Consultas
            InfoEmp.Emp_AMat = txt_AM.Text
            InfoEmp.Emp_APat = txt_AP.Text
            InfoEmp.Emp_Name = txt_NOM.Text
            InfoEmp.Emp_Sexo = CB_SEXO.SelectedItem.ToString
            InfoEmp.Emp_NEducativo = ddl_educacion.SelectedItem.ToString
            InfoEmp.Emp_FNac = Convert.ToDateTime(txt_FECHA.Text)
            InfoEmp.Emp_EN = txt_EN.Text
            InfoEmp.Emp_RFC = txt_RFC.Text
            InfoEmp.Emp_NSS = txt_SS.Text
            InfoEmp.Emp_Curp = txt_CURP.Text
            InfoEmp.Emp_Cel = Celular.Text
            InfoEmp.Emp_Tel = txt_telefono.Text
            InfoEmp.Emp_EdoCivil = EC.SelectedItem.ToString
            InfoEmp.Emp_Nacionalidad = nacion.Text
            InfoEmp.Emp_Domicilio = domicilio.Text
            InfoEmp.Emp_Col = colonia.Text
            InfoEmp.Emp_CiudadEstado = txtCdDomicilio.Text
            InfoEmp.Emp_CP = CP.Text
            InfoEmp.Emp_FEfectiva = Convert.ToDateTime(txt_FECHAINGRESO.Text)
            InfoEmp.ID_Puesto = Convert.ToInt64(txt_PUESTO.Text)
            InfoEmp.Emp_Salario = Convert.ToDouble(txt_SALARY.Text)
            InfoEmp.ID_Depto = depto.Text
            InfoEmp.Emp_Sup = txt_SUPER.Text
            InfoEmp.Emp_Tipo = txt_tipo.Text
            InfoEmp.Emp_Activo = 1
            InfoEmp.Emp_Ciudad = cuidad.Text
            InfoEmp.Emp_Email = Txt_correo.Text
            InfoEmp.Img = foto.Image
            InfoEmp.Baja.NotificarClientes = CB_CLIENTE.Checked
            InfoEmp.Baja.NotificarProveedores = CB_PROV.Checked
            If (EXISTE = False) Then
                If (txt_numero.Text = "" Or txt_AP.Text = "" Or txt_NOM.Text = "" Or txt_EN.Text = "" Or txt_RFC.Text = "" Or txt_SS.Text = "" Or
                  txt_SALARY.Text = "" Or txt_CURP.Text = "" Or txt_FECHAINGRESO.Text = "" Or txt_tipo.Text = "" Or txt_PUESTO.Text = "" Or depto.Text = "" Or txt_SUPER.Text = "" Or txt_FECHA.Text = "") Then
                    MessageBox.Show("Favor de llenar todos los campos")
                Else
                    objEmp.UpInsert_colabora(InfoEmp)
                    limp()
                    MessageBox.Show("Empleado agregado satisfactoriamente")
                End If
            Else
                If MessageBox.Show("SE VA A MODIFICAR ESTE EMPLEADO", "My Application",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                      = DialogResult.Yes Then
                    InfoEmp.ID_Emp = txt_numero.Text
                    objEmp.UpInsert_colabora(InfoEmp)
                    limp()
                    MessageBox.Show("Empleado Actualizado Satisfactoriamente")
                End If
            End If
        Else
            MsgBox("Email no es Valido")
        End If
    End Sub
    Public Sub limp()

        Dim ctrl As Control
        For Each ctrl In Me.pnl_per.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
            End If
            If (ctrl.GetType() Is GetType(DateTimePicker)) Then
                Dim txt As DateTimePicker = CType(ctrl, DateTimePicker)
                txt.Text = Date.Now
            End If
        Next

        For Each ctrl In Me.pnl_cont.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
            End If
            If (ctrl.GetType() Is GetType(DateTimePicker)) Then
                Dim txt As DateTimePicker = CType(ctrl, DateTimePicker)
                txt.Text = Date.Now
            End If
        Next
        Dim Wait As New Wait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
        Wait.ShowDialog()
        txt_numero.Text = Wait.Result.ToString()
        Wait.Close()

        CB_SEXO.SelectedIndex = -1
        ddl_educacion.SelectedIndex = -1
        EC.SelectedIndex = -1
        txt_numero.Text = objcon.NUMERO_EMPLEADO.ToString()
        txt_numero.Focus()
        txt_activo.Text = ""
        txt_baja.Text = ""
        lbl_option.Visible = False
        PbOptions.Visible = False
        PbOptions.Tag = ""
        foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
        foto.Visible = True
        txt_esAM.Text = ""
        txt_esAP.Text = ""
        txt_esName.Text = ""
        txt_esFN.Text = ""
        txt_esNacion.Text = ""
        cb_esSexo.SelectedIndex = -1
        txt_hijoAM.Text = ""
        txt_hijoAP.Text = ""
        txt_hijoNAME.Text = ""
        txt_hijoFN.Text = ""
        txt_hijoNACION.Text = ""
        txt_hijoSEXO.SelectedIndex = -1
        llenarFamilia()
        txt_antFI.Text = ""
        txt_antFF.Text = ""
        txt_antEMP.Text = ""
        txt_antCARGO.Text = ""
        txt_antSALARIO.Text = ""
        txt_antTEL.Text = ""
        txt_antMT.Text = ""
        txt_antNAME.Text = ""
        llenarAL()
        txt_conAM.Text = ""
        txt_conAP.Text = ""
        txt_conCEL.Text = ""
        txt_conPAREN.Text = ""
        txt_conNAME.Text = ""
        txt_conTEL.Text = ""
        llenarContacto()
        txt_enfNAME.Text = ""
        llenarEnfermedades()
        txt_RefOcu.Text = ""
        txt_RefNom.Text = ""
        txt_TC.Text = ""
        Txt_TR.Text = ""
        txt_RefOcu.Text = ""
        txt_RefNom.Text = ""
        txt_TC.Text = ""
        Txt_TR.Text = ""
        cb_CasaP.Checked = False
        cb_Depto.Checked = False
        cb_Renta.Checked = False
        cb_Terreno.Checked = False
        cb_adobe.Checked = False
        cb_block.Checked = False
        cb_Madera.Checked = False
        cb_ladrillo.Checked = False
        cb_Luz.Checked = False
        cb_LineaTel.Checked = False
        cb_AguaP.Checked = False
        cb_Drenaje.Checked = False
        cb_Tuberia.Checked = False
        cb_Basura.Checked = False
        cb_TV.Checked = False
        cb_Internet.Checked = False
        cb_SisSeg.Checked = False
        cb_Metro.Checked = False
        cb_Trans.Checked = False
        cb_Taxi.Checked = False
        cb_Vehi.Checked = False
        CB_PROV.Checked = False
        CB_CLIENTE.Checked = False
        txt_SE__SOCIALE.Text = ""
        txt_SE_EVENTOS.Text = ""
        txt_SE_MUSEOS.Text = ""
        txt_SE_TEATROS.Text = ""
        txt_SE_CINES.Text = ""
        txt_SE_CULTURALES.Text = ""
        txt_SE_ZONAS.Text = ""
        txt_SE_VACIONES.Text = ""
        txt_SE_PLAZAS.Text = ""
        txt_SE_NATURALES.Text = ""
        txt_se_diversiones.Text = ""
        txt_GFRenta.Text = ""
        txt_GFCole.Text = ""
        Txt_GFDesp.Text = ""
        txt_GFServ.Text = ""
        Txt_pasatiempos.Text = ""
        txt_Religion.Text = ""
        txt_commen.Text = ""
        commen.Text = ""
        lbl_emp.Text = ""
        seg.Checked = False
        PB_IMAGE_VIVIENDA.Image = My.Resources.AddImage
        EMPLEADO_ES = 0
        dgv_OI.DataSource = objcon.Consulta_OI(0)
        dgv_Ref.DataSource = objcon.Consulta_REF(0)
    End Sub

    Private Sub Altas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then My.Computer.Keyboard.SendKeys("{tab}")
    End Sub

    Private Sub txt_SS_Leave(sender As Object, e As EventArgs) Handles txt_SS.Leave
        If (txt_SS.Text <> "" And txt_SS.Text <> "0") Then
            If Not NSS.IsValid(txt_SS.Text) Then
                MsgBox("Número de seguro social '" + txt_SS.Text + "' no valido, por favor verifique sea correcto")
                txt_SS.Text = ""
                txt_SS.Focus()
            Else
                If EXISTE = False Then
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"CURPorNSS", txt_SS.Text}}
                    Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateCURPandNSS
                    }
                    Wait.ShowDialog()
                    Dim loResult = Wait.Result
                    If loResult <> 0 Then
                        txt_numero.Text = loResult
                        Numeroleave()
                    End If
                    Wait.Close()
                End If
            End If
        End If
    End Sub
    Private Sub txt_CURP_Leave(sender As Object, e As EventArgs) Handles txt_CURP.Leave
        If (txt_CURP.Text <> "" And txt_CURP.Text <> "0") Then
            If Not CURP.IsValid(txt_CURP.Text) Then
                MsgBox("Número de CURP '" + txt_CURP.Text + "' no valido, por favor verifique sea correcto")
                txt_CURP.Text = ""
                txt_CURP.Focus()
            Else
                If EXISTE = False Then
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"CURPorNSS", txt_CURP.Text}}
                    Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateCURPandNSS
                    }
                    Wait.ShowDialog()
                    Dim loResult = Wait.Result
                    If loResult <> 0 Then
                        txt_numero.Text = loResult
                        Numeroleave()
                    End If
                    Wait.Close()
                End If
            End If
        End If
    End Sub

    Private Sub OptionPress(sender As Object, e As EventArgs) Handles PbOptions.Click
        'Try
        If txt_numero.Text <> "" Then
            Select Case PbOptions.Tag
                Case "Alta"
                    objcon.Altas(txt_numero.Text, 1)
                    MessageBox.Show("Se dio de Alta correctamente a este Empleado")
                    Llenar()
                    txt_activo.Text = ""
                    txt_baja.Text = ""
                    seg.Checked = True
                    CB_CLIENTE.Checked = False
                    CB_PROV.Checked = False
                Case "Baja"
                    objcon.Altas(txt_numero.Text, 0)
                    objcon.Bajas(txt_numero.Text, 0, commen.Text, seg.Checked, NEmp, CB_PROV.Checked, CB_CLIENTE.Checked)
                    MessageBox.Show("Se dio de Baja correctamente a este Empleado")
                    txt_activo.Text = ""
                    txt_baja.Text = ""
                    Llenar()
            End Select
        Else
            MessageBox.Show("Numero de Empleado invalido.")
        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        llenar_buscador("EN")
        If (V1 <> "" And V2 <> "") Then
            cuidad.Focus()
        Else
            txt_EN.Focus()
        End If
        txt_EN.Text = V1
        txt_EN2.Text = V2
    End Sub
    Private Sub Buscar_PUESTO_Click(sender As Object, e As EventArgs) Handles Buscar_PUESTO.Click
        llenar_buscador("PU")
        If (V1 <> "" And V2 <> "") Then
            txt_SALARY.Focus()
        Else
            txt_PUESTO.Focus()
        End If
        txt_PUESTO.Text = V1
        txt_PUESTO2.Text = V2
    End Sub
    Private Sub Buscar_Super_Click(sender As Object, e As EventArgs) Handles Buscar_Super.Click
        llenar_buscador("SU")
        If (V1 <> "" And V2 <> "") Then
            txt_tipo.Focus()
        Else
            txt_SUPER.Focus()
        End If
        txt_SUPER.Text = V1
        txt_SUPER2.Text = V2
    End Sub
    Private Sub Buscar_tipo_Click(sender As Object, e As EventArgs) Handles Buscar_tipo.Click
        llenar_buscador("TI")
        If (V1 <> "" And V2 <> "") Then
            SAVE.Focus()
        Else
            txt_tipo.Focus()
        End If
        txt_tipo.Text = V1
        txt_tipo2.Text = V2
    End Sub
    Public Sub llenar_buscador(tipo As String)
        Dim popup As New frmPopUp(tipo)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        V1 = popup.Variable
        V2 = popup.Variable2
        popup.Close()
    End Sub
    Public Sub Limpiartxt(ByVal form As Windows.Forms.Form)
        'Try
        txt_activo.Text = ""
        txt_baja.Text = ""
        lbl_option.Visible = False
        PbOptions.Visible = False
        PbOptions.Tag = ""
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        'End Try
    End Sub
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ResetTabs()
        Dim Wait As New Wait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
        Wait.ShowDialog()
        txt_numero.Text = Wait.Result.ToString()
        Wait.Close()
        txt_AP.Focus()

        SAVE.Visible = True
        foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
        foto.Visible = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)

    End Sub

    Sub cargarImagen(control As PictureBox)
        Dim IMAGEN As String
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" And Me.OpenFileDialog1.FileName <> "OpenFileDialog1" Then
            IMAGEN = OpenFileDialog1.FileName
            Dim largo As Integer = IMAGEN.Length
            Dim imagen2 As String
            imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
            If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                    MsgBox("Formato no valido") : Exit Sub
                    If imagen2 <> "log1" Then Exit Sub
                End If
            End If
            control.Load(IMAGEN)
        End If

    End Sub
    Private Sub ln_img_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        cargarImagen(foto)
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
    Private Sub CP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CP.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub Celular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Celular.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        limp()
    End Sub
    Private Sub txt_EN_Leave(sender As Object, e As EventArgs) Handles txt_EN.Leave
        If (txt_EN.Text <> "") Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"Field", txt_EN.Text}, {"Type", "EN"}}
            Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateEnPuSuTi
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            If loResult IsNot Nothing Or Not String.IsNullOrWhiteSpace(loResult) Then
                txt_EN2.Text = loResult
            Else
                MessageBox.Show("No existe")
                txt_EN.Text = ""
                txt_EN.Focus()
            End If
            Wait.Close()
        End If
    End Sub
    Private Sub txt_PUESTO_Leave(sender As Object, e As EventArgs) Handles txt_PUESTO.Leave
        If (txt_PUESTO.Text <> "") Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"Field", txt_PUESTO.Text}, {"Type", "PU"}}
            Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateEnPuSuTi
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            If loResult IsNot Nothing Or Not String.IsNullOrWhiteSpace(loResult) Then
                txt_PUESTO2.Text = loResult
            Else
                MessageBox.Show("No existe")
                txt_PUESTO.Text = ""
                txt_PUESTO.Focus()
            End If
            Wait.Close()
        End If
    End Sub
    Private Sub txt_SUPER_Leave(sender As Object, e As EventArgs) Handles txt_SUPER.Leave
        If (txt_SUPER.Text <> "") Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"Field", txt_SUPER.Text}, {"Type", "SU"}}
            Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateEnPuSuTi
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            If loResult IsNot Nothing Or Not String.IsNullOrWhiteSpace(loResult) Then
                txt_SUPER.Text = loResult
            Else
                MessageBox.Show("No existe")
                txt_SUPER.Text = ""
                txt_SUPER.Focus()
            End If
            Wait.Close()
        End If
    End Sub

    Private Sub txt_tipo_Leave(sender As Object, e As EventArgs) Handles txt_tipo.Leave
        If (txt_tipo.Text <> "") Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"Field", txt_tipo.Text}, {"Type", "TI"}}
            Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.ValidateEnPuSuTi
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            If loResult IsNot Nothing Or Not String.IsNullOrWhiteSpace(loResult) Then
                txt_SUPER.Text = loResult
            Else
                MessageBox.Show("No existe")
                txt_tipo.Text = ""
                txt_tipo.Focus()
            End If
            Wait.Close()
        End If
    End Sub

    Private Sub Btn_AddRef_Click(sender As Object, e As EventArgs) Handles Btn_AddRef.Click
        If EXISTE = True Then
            If txt_RefNom.Text = "" Or txt_RefOcu.Text = "" Or txt_TC.Text = "" Or Txt_TR.Text = "" Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"Name", txt_RefNom.Text},
                        {"Ocupation", txt_RefOcu.Text}, {"Relationship", Txt_TR.Text}, {"Time", txt_TC.Text}}
                Dim Wait As New Wait With {
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
                If EMPLEADO_ES = 0 Then
                    dgv_OI.Rows.Add(txt_OIParen.Text, txt_OTCantidad.Text)
                Else
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"Relationship", txt_OIParen.Text}, {"Amount", txt_OTCantidad.Text}}
                    Dim Wait As New Wait With {
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
                End If
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
            ES.SES_VERIFIER = NEmp
            ES.SES_OBSERVATIONS = txt_commen.Text
            ES.IMG = PB_IMAGE_VIVIENDA.Image

            Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", ES}}
            Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddSocialEconomicStudy
                    }
            Wait.ShowDialog()
            Dim loResult = Wait.Result
            Wait.Close()


            If loResult > 0 Then
                ldParameters = New Dictionary(Of String, Object) From {{"Employee", ES.EMP_ID}, {"HousePicture", ES.IMG}, {"EmployeePicture", foto.Image}}
                Wait = New Wait With {
                                    .Parameters = ldParameters,
                                    .Operation = BackgroundOperations.AddImage
                                }
                Wait.ShowDialog()
                Wait.Close()
                '    If dgv_Ref.Rows.Count > 0 Then
                '        For Each row As DataGridViewRow In dgv_Ref.Rows
                '            If Not row.IsNewRow Then
                '                'ES.SES_ID
                '                ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"Name", row.Cells(2).Value.ToString},
                '                           {"Ocupation", row.Cells(4).Value.ToString}, {"Relationship", row.Cells(3).Value.ToString}, {"Time", row.Cells(5).Value.ToString}}
                '                Wait = New Wait With {
                '                    .Parameters = ldParameters,
                '                    .Operation = BackgroundOperations.ValidateReference
                '                }
                '                Wait.ShowDialog()
                '                Dim loResult3 As Dictionary(Of String, Object) = Wait.Result
                '                Wait.Close()

                '                If loResult3("Valid") = False Then
                '                    MessageBox.Show("Este registro ya Existe.")
                '                End If
                '            End If
                '        Next
                '    End If
                'If dgv_OI.Rows.Count > 0 Then
                '    For Each row As DataGridViewRow In dgv_OI.Rows
                '        If Not row.IsNewRow Then
                '            ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"Relationship", row.Cells(0).Value.ToString},
                '                             {"Amount", Convert.ToDouble(row.Cells(1).Value.ToString)}}
                '            Wait = New Wait With {
                '                    .Parameters = ldParameters,
                '                    .Operation = BackgroundOperations.ValidateIncome
                '                }
                '            Dim loResult4 As Dictionary(Of String, Object) = Wait.Result
                '            Wait.Close()
                '            If loResult4("Valid") = False Then
                '                MessageBox.Show("Este registro ya Existe.")
                '            End If
                '        End If
                '    Next
                'End If
                limp()
            End If
        End If
    End Sub

    Private Sub btn_SECancel_Click(sender As Object, e As EventArgs) Handles btn_SECancel.Click
        limp()
    End Sub

    Private Sub btn_enfADD_Click(sender As Object, e As EventArgs) Handles btn_enfADD.Click
        If EXISTE = True Then
            If txt_enfNAME.Text = "" Then
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Condition", txt_enfNAME.Text}}
                Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddMedicalConditions
                    }
                Wait.ShowDialog()
                Wait.Close()
                Dim loResult = Wait.Result
                If loResult = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                txt_enfNAME.Text = ""
                llenarEnfermedades()
            End If
        End If
    End Sub

    Private Sub btn_conADD_Click(sender As Object, e As EventArgs) Handles btn_conADD.Click
        If EXISTE = True Then
            If txt_conAM.Text = "" Or txt_conAP.Text = "" Or txt_conCEL.Text = "" Or txt_conPAREN.Text = "" Or txt_conNAME.Text = "" Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Name", txt_conNAME.Text}, {"FLastname", txt_conAP.Text}, {"SLastname", txt_conAM.Text},
                 {"Relationship", txt_conPAREN.Text}, {"Phone", txt_conTEL.Text}, {"Cellphone", txt_conCEL.Text}}
                Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddContact
                    }
                Wait.ShowDialog()
                Dim loResult = Wait.Result
                Wait.Close()
                If loResult = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                txt_conAM.Text = ""
                txt_conAP.Text = ""
                txt_conCEL.Text = ""
                txt_conPAREN.Text = ""
                txt_conNAME.Text = ""
                txt_conTEL.Text = ""
                llenarContacto()
            End If
        End If
    End Sub

    Private Sub btn_antSave_Click(sender As Object, e As EventArgs) Handles btn_antSave.Click
        If EXISTE = True Then
            If txt_antCARGO.Text = "" Or txt_antEMP.Text = "" Or txt_antFF.Text = "" Or txt_antFI.Text = "" Or txt_antMT.Text = "" Or
            txt_antNAME.Text = "" Or txt_antTEL.Text = "" Or txt_antSALARIO.Text = "" Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Start", txt_antFI.Text}, {"End", txt_antFF.Text}, {"Company", txt_antEMP.Text},
                 {"Position", txt_antCARGO.Text}, {"Wage", txt_antSALARIO.Text}, {"Phone", txt_antTEL.Text}, {"Reason", txt_antMT.Text}, {"Contact", txt_antNAME.Text}}
                Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddJobHistory
                    }
                Wait.ShowDialog()
                Dim loResult = Wait.Result
                Wait.Close()
                If loResult = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                txt_antFI.Text = ""
                txt_antFF.Text = ""
                txt_antEMP.Text = ""
                txt_antCARGO.Text = ""
                txt_antSALARIO.Text = ""
                txt_antTEL.Text = ""
                txt_antMT.Text = ""
                txt_antNAME.Text = ""
                llenarAL()
            End If
        End If
    End Sub
    Private Sub btn_esSAVE_Click(sender As Object, e As EventArgs) Handles btn_esSAVE.Click
        If EXISTE = True Then
            If dgv_esposa.Rows.Count > 0 Then
                MessageBox.Show("Solo se puede agregar un registro a este campo.")
            Else
                If txt_esAM.Text = "" Or cb_esSexo.SelectedIndex = -1 Or txt_esAP.Text = "" Or txt_esFN.Text = "" Or txt_esNacion.Text = "" Or txt_esName.Text = "" Then
                    MessageBox.Show("Favor de llenar todos los campos")
                Else
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Type", "CONYUGE"}, {"Name", txt_esName.Text}, {"FLastname", txt_esAP.Text},
                        {"SLastname", txt_esAM.Text}, {"Nationality", txt_esNacion.Text}, {"Birthday", txt_esFN.Text}, {"Sex", cb_esSexo.SelectedItem.ToString()}, {"CivilStatus", EC.SelectedItem.ToString}}
                    Dim Wait As New Wait With {
                            .Parameters = ldParameters,
                            .Operation = BackgroundOperations.AddFamilyMember
                        }
                    Wait.ShowDialog()
                    Dim loResult = Wait.Result
                    Wait.Close()
                    If loResult = False Then
                        MessageBox.Show("Este registro ya Existe.")
                    End If
                    txt_esAM.Text = ""
                    txt_esAP.Text = ""
                    txt_esName.Text = ""
                    txt_esFN.Text = ""
                    txt_esNacion.Text = ""
                    cb_esSexo.SelectedIndex = -1
                    llenarFamilia()
                End If
            End If
        End If
    End Sub
    Private Sub btn_hijoADD_Click(sender As Object, e As EventArgs) Handles btn_hijoADD.Click
        If EXISTE = True Then
            If txt_hijoAM.Text = "" Or txt_hijoAP.Text = "" Or txt_hijoNAME.Text = "" Or txt_hijoFN.Text = "" Or txt_hijoNACION.Text = "" Or
           txt_hijoSEXO.SelectedIndex = -1 Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Type", "HIJO"}, {"Name", txt_hijoNAME.Text}, {"FLastname", txt_hijoAP.Text},
                    {"SLastname", txt_hijoAM.Text}, {"Nationality", txt_hijoNACION.Text}, {"Birthday", txt_hijoFN.Text}, {"Sex", txt_hijoSEXO.SelectedItem.ToString()}}
                Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.AddFamilyMember
                    }
                Wait.ShowDialog()
                Dim loResult = Wait.Result
                Wait.Close()
                If loResult = False Then
                    MessageBox.Show("Este registro ya Existe.")
                End If
                txt_hijoAM.Text = ""
                txt_hijoAP.Text = ""
                txt_hijoNAME.Text = ""
                txt_hijoFN.Text = ""
                txt_hijoNACION.Text = ""
                txt_hijoSEXO.SelectedIndex = -1
                llenarFamilia()
            End If
        End If
    End Sub
    Private Sub depto_Leave(sender As Object, e As EventArgs) Handles depto.Leave
        If (depto.Text <> "") Then
            V2 = objcon.S_catalago(depto.Text, "DE")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                depto.Text = ""
                depto.Focus()
            Else
                depto2.Text = V2
            End If
        End If
    End Sub
    Private Sub buscar_depto_Click(sender As Object, e As EventArgs) Handles buscar_depto.Click
        llenar_buscador("DE")
        If (V1 <> "" And V2 <> "") Then
            Txt_correo.Focus()
        Else
            depto.Focus()
        End If
        depto.Text = V1
        depto2.Text = V2
    End Sub
    Private Sub cuidad_Leave(sender As Object, e As EventArgs) Handles cuidad.Leave
        If (cuidad.Text <> "") Then
            V2 = objcon.S_catalago(cuidad.Text, "ci")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                cuidad.Text = ""
                cuidad.Focus()
            Else
                cuidad2.Text = V2
            End If
        End If
    End Sub
    Private Sub buscar_ciudad_Click(sender As Object, e As EventArgs) Handles buscar_ciudad.Click
        If txt_EN.Text = "" Then
            MessageBox.Show("Primero debe elegir una entidad.")
        Else
            llenar_buscador("CI," + txt_EN.Text)
            If (V1 <> "" And V2 <> "") Then
                txt_RFC.Focus()
            Else
                cuidad.Focus()
            End If
            cuidad.Text = V1
            cuidad2.Text = V2
        End If

    End Sub
    Private Sub llenarFamilia()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetFamily
                    }
        Wait.ShowDialog()
        Dim loResult As Dictionary(Of String, Object) = Wait.Result
        Wait.Close()
        dgv_esposa.DataSource = loResult("Spouse")
        dgv_Hijos.DataSource = loResult("Offsprings")
    End Sub
    Private Sub llenarAL()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetJobHistory
                    }
        Wait.ShowDialog()
        Wait.Close()
        Dim loResult = Wait.Result
        Wait.Close()
        dgv_ant.DataSource = loResult
    End Sub
    Private Sub llenarContacto()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetContact
                    }
        Wait.ShowDialog()
        Dim loResult = Wait.Result
        Wait.Close()
        dgv_contacto.DataSource = loResult
    End Sub
    Private Sub llenarEnfermedades()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetMedicalConditions
                    }
        Wait.ShowDialog()
        Dim loResult = Wait.Result
        Wait.Close()
        dgv_Enf.DataSource = loResult
    End Sub
    Private Sub llenarSE()
        Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}}
        Dim Wait As New Wait With {
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
        Else
            EMPLEADO_ES = 0
        End If
        ldParameters = New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}}
        Wait = New Wait With {
                        .Parameters = ldParameters,
                        .Operation = BackgroundOperations.GetIncome
                    }
        Wait.ShowDialog()
        Dim loResult2 = Wait.Result
        Wait.Close()
        dgv_OI.DataSource = loResult2
        Wait = New Wait With {
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
            Dim Wait As New Wait()
            Wait.Operation = BackgroundOperations.JustShowScreen
            Wait.Show()
            Dim Reportes As New Reportes With {
                    .ReportOption = ReportOptions.SocialeconomicStudy,
                    .Emp = Convert.ToInt64(txt_numero.Text),
                    .User = NName
                }
            Reportes.ShowDialog()
        End If
    End Sub

    Private Sub foto_DoubleClick(sender As Object, e As EventArgs) Handles foto.DoubleClick
        cargarImagen(foto)
    End Sub

    Private Sub PB_IMAGE_VIVIENDA_DoubleClick(sender As Object, e As EventArgs) Handles PB_IMAGE_VIVIENDA.DoubleClick
        cargarImagen(PB_IMAGE_VIVIENDA)
    End Sub

    Private Sub dgv_esposa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_esposa.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnCEliminar"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar Familiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_Familia(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            llenarFamilia()
        End If
    End Sub

    Private Sub dgv_Hijos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Hijos.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnHEliminar"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar Familiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_Familia(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            llenarFamilia()
        End If
    End Sub

    Private Sub dgv_ant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ant.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnAEliminar"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_ANTE(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            llenarAL()
        End If
    End Sub

    Private Sub dgv_contacto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_contacto.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnCOEliminar"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_CEMERGENCIA(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            llenarContacto()
        End If
    End Sub

    Private Sub dgv_Enf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Enf.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "btnEnELiminar"
                            If MessageBox.Show("Seguro que desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = gr.Rows(e.RowIndex).Cells(1).Value
                                objcon.DELETE_Enfermedades(Id)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            llenarEnfermedades()
        End If
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

    Private Sub PbSearchEmployee_Click(sender As Object, e As EventArgs) Handles PbSearchEmployee.Click
        llenar_buscador("EMP")
        If V1 <> "" And V2 <> "" Then
            txt_numero.Text = V1
            Numeroleave()
            llenarFamilia()
            llenarAL()
            llenarContacto()
            llenarEnfermedades()
            llenarSE()
            pnl_estatus.Visible = True
        Else
            Dim Wait As New Wait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
            Wait.ShowDialog()
            txt_numero.Text = Wait.Result.ToString()
            Wait.Close()
        End If
        pnl_estatus.Visible = False
        txt_NOM.Focus()
    End Sub

    Private Sub TxtMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_GFCole.KeyPress, Txt_GFDesp.KeyPress, txt_GFRenta.KeyPress, txt_GFServ.KeyPress,
                                                                                     txt_OTCantidad.KeyPress, txt_antSALARIO.KeyPress, txt_SALARY.KeyPress
        Dim TxtBoxMoney As TextBox = CType(sender, TextBox)
        If Not TxtBoxMoney.Text.Contains(".") Then
            e.Handled = Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
        Else
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
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