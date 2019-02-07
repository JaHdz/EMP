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
    Dim TabCollection As New Dictionary(Of String, TabPage)
    Sub New(ByVal emp As Integer, name As String)
        InitializeComponent()
        NEmp = emp
        NName = name
    End Sub
    Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave
        'Try
        Numeroleave()
            llenarFamilia()
            llenarAL()
            llenarContacto()
            llenarEnfermedades()
            llenarSE()
        'Catch ex As Exception
        '    MessageBox.Show("Numero de empleado no valido")
        'End Try
    End Sub
    Private Sub Numeroleave()
        Dim numero As String
        numero = txt_numero.Text
        txt_activo.Text = ""
        txt_baja.Text = ""
        lbl_option.Visible = True
        PbOptions.Visible = True

        If (txt_numero.Text <> "") Then
            Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", txt_numero.Text}}
            Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.EmployeeExits
            }
            Wait.ShowDialog()
            Dim Result = Wait.Result
            Wait.Close()
            If (Result = 1) Then
                Llenar()
                EXISTE = True
                lbl_emp.Text = txt_numero.Text + " | " + txt_NOM.Text + " " + txt_AP.Text + " " + txt_AM.Text
                EMPLEADO_ID = txt_numero.Text
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
        pnl_save.Text = ""
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
    Private Sub txt_SALARY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SALARY.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
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
        Try
            SAVE_F()
            lbl_emp.Text = ""
            lbl_emp.Text = txt_numero.Text + " | " + txt_NOM.Text + " " + txt_AP.Text + " " + txt_AM.Text
            EMPLEADO_ID = txt_numero.Text
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
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
            InfoEmp.Emp_CP = CP.Text
            InfoEmp.Emp_FEfectiva = Convert.ToDateTime(txt_FECHAINGRESO.Text)
            InfoEmp.ID_Puesto = Convert.ToInt64(txt_PUESTO.Text)
            InfoEmp.Emp_Salario = Convert.ToDouble(txt_SALARY.Text)
            InfoEmp.ID_Depto = depto.Text
            InfoEmp.Emp_Sup = Convert.ToInt64(txt_SUPER.Text)
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
        txt_hijoEC.SelectedIndex = -1
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
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
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
        Try
            txt_activo.Text = ""
            txt_baja.Text = ""
            lbl_option.Visible = False
            PbOptions.Visible = False
            PbOptions.Tag = ""
            pnl_save.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'HideTab("All")
        Dim Wait As New Wait With {
            .Operation = BackgroundOperations.GetLatestEmployeeNumber
        }
        Wait.ShowDialog()
        txt_AP.Focus()
        txt_numero.Text = Wait.Result.ToString()
        SAVE.Visible = True
        foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
        foto.Visible = True
        pnl_save.Text = "GUARDAR"
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)
        Wait.Close()
    End Sub

    Private Sub HideTab(TabName As String)
        If TabName <> "All" Then
            If TabName <> "Datos Personales" Then
                For Each SpedcificTab As TabPage In MenuEmp.TabPages
                    If SpedcificTab.Text = TabName Then
                        TabCollection.Add(TabName, SpedcificTab)
                        MenuEmp.TabPages.Remove(SpedcificTab)
                        Exit For
                    End If
                Next
            End If
        Else
            For Each Tab As TabPage In MenuEmp.TabPages
                If Tab.Text <> "Datos Personales" Then
                    TabCollection.Add(Tab.Text, Tab)
                    MenuEmp.TabPages.Remove(Tab)
                End If
            Next
        End If
    End Sub
    Private Sub ShowTab(TabName As String)
        If TabName <> "All" Then
            If TabCollection.ContainsKey(TabName) Then
                MenuEmp.TabPages.Add(TabCollection(TabName))
                TabCollection.Remove(TabName)
            End If
        Else
            For Each TabItem In TabCollection
                MenuEmp.TabPages.Add(TabItem.Value)
                TabCollection.Remove(TabItem.Key)
            Next
        End If
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
    Private Sub txt_antSALARIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_antSALARIO.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_OTCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_OTCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
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
        Close()
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
                If EMPLEADO_ES = 0 Then
                    dgv_Ref.Rows.Add(txt_RefNom.Text, txt_RefOcu.Text, Txt_TR.Text, txt_TC.Text)
                Else
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"Name", txt_RefNom.Text},
                        {"Ocupation", txt_RefNom.Text}, {"Relationship", txt_RefNom.Text}, {"Time", txt_RefNom.Text}}
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
                End If
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
                    Dim ldParameters As New Dictionary(Of String, Object) From {{"ES", EMPLEADO_ES}, {"Relationship", txt_RefNom.Text}, {"Amount", txt_RefNom.Text}}
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
            Dim cont As Integer = 0
            For Each ctrl In Panel1.Controls
                If (ctrl.GetType() Is GetType(CheckBox)) Then
                    Dim txt As CheckBox = CType(ctrl, CheckBox)
                    If txt.Checked = True Then
                        cont = cont + 1
                    End If
                End If
            Next
            If cont > 0 Then
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
                ES.A_SOCIAL = txt_SE__SOCIALE.Text
                ES.A_COMUNITARY = txt_SE_EVENTOS.Text
                ES.A_MUSEUMS = txt_SE_MUSEOS.Text
                ES.A_THEATERS = txt_SE_TEATROS.Text
                ES.A_MOVIES = txt_SE_CINES.Text
                ES.A_FESTIVALS = txt_SE_CULTURALES.Text
                ES.A_ARCHE = txt_SE_ZONAS.Text
                ES.A_VACATIONS = txt_SE_VACIONES.Text
                ES.A_PLAZAS = txt_SE_PLAZAS.Text
                ES.A_NPARK = txt_SE_NATURALES.Text
                ES.A_APARK = txt_se_diversiones.Text
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
                        .Operation = BackgroundOperations.ValidateIncome
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
                    If dgv_Ref.Rows.Count > 0 Then
                        For Each row As DataGridViewRow In dgv_Ref.Rows
                            If Not row.IsNewRow Then
                                ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"Name", row.Cells(0).Value.ToString},
                                           {"Ocupation", row.Cells(1).Value.ToString}, {"Relationship", row.Cells(2).Value.ToString}, {"Time", row.Cells(3).Value.ToString}}
                                Wait = New Wait With {
                                    .Parameters = ldParameters,
                                    .Operation = BackgroundOperations.ValidateReference
                                }
                                Dim loResult3 As Dictionary(Of String, Object) = Wait.Result
                                If loResult3("Valid") = False Then
                                    MessageBox.Show("Este registro ya Existe.")
                                End If
                            End If
                        Next
                    End If
                    If dgv_OI.Rows.Count > 0 Then
                        For Each row As DataGridViewRow In dgv_OI.Rows
                            If Not row.IsNewRow Then
                                ldParameters = New Dictionary(Of String, Object) From {{"ES", loResult}, {"Relationship", row.Cells(0).Value.ToString},
                                             {"Amount", Convert.ToDouble(row.Cells(1).Value.ToString)}}
                                Wait = New Wait With {
                                    .Parameters = ldParameters,
                                    .Operation = BackgroundOperations.ValidateIncome
                                }
                                Dim loResult4 As Dictionary(Of String, Object) = Wait.Result
                                Wait.Close()
                                If loResult4("Valid") = False Then
                                    MessageBox.Show("Este registro ya Existe.")
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_SECancel_Click(sender As Object, e As EventArgs) Handles btn_SECancel.Click
        Me.Close()
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
    End Sub
    Private Sub btn_hijoADD_Click(sender As Object, e As EventArgs) Handles btn_hijoADD.Click
        If EXISTE = True Then
            If txt_hijoAM.Text = "" Or txt_hijoAP.Text = "" Or txt_hijoNAME.Text = "" Or txt_hijoFN.Text = "" Or txt_hijoNACION.Text = "" Or
           txt_hijoSEXO.SelectedIndex = -1 Or txt_hijoEC.SelectedIndex = -1 Then
                MessageBox.Show("Favor de llenar todos los campos")
            Else
                Dim ldParameters As New Dictionary(Of String, Object) From {{"Employee", EMPLEADO_ID}, {"Type", "HIJO"}, {"Name", txt_hijoNAME.Text}, {"FLastname", txt_hijoAP.Text},
                    {"SLastname", txt_hijoAM.Text}, {"Nationality", txt_hijoNACION.Text}, {"Birthday", txt_hijoFN.Text}, {"Sex", txt_hijoSEXO.SelectedItem.ToString()}, {"CivilStatus", txt_hijoEC.SelectedItem.ToString}}
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
                txt_hijoEC.SelectedIndex = -1
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
        dgv_esposa.DataSource = objcon.Consulta_FamEsp(EMPLEADO_ID)
        dgv_Hijos.DataSource = objcon.Consulta_FamHijos(EMPLEADO_ID)
    End Sub
    Private Sub llenarAL()
        dgv_ant.DataSource = objcon.Consulta_AnteLab(EMPLEADO_ID)
    End Sub
    Private Sub llenarContacto()
        dgv_contacto.DataSource = objcon.Consulta_CEmergencia(EMPLEADO_ID)
    End Sub
    Private Sub llenarEnfermedades()
        dgv_Enf.DataSource = objcon.Consulta_Enf(EMPLEADO_ID)
    End Sub
    Private Sub llenarSE()
        Dim dt As DataTable = objcon.Consulta_ES(EMPLEADO_ID)
        pnl_save.Text = ""
        If (dt.Rows.Count <= 0) Then
        Else
            If dt.Rows(0).Item("Viv_Tipo").ToString() = "CASA PROPIA" Then
                cb_CasaP.Checked = True
            Else
                cb_CasaP.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Tipo").ToString() = "DEPARTAMENTO" Then
                cb_Depto.Checked = True
            Else
                cb_Depto.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Tipo").ToString() = "CASA DE RENTA" Then
                cb_Renta.Checked = True
            Else
                cb_Renta.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Tipo").ToString() = "TERRENO" Then
                cb_Terreno.Checked = True
            Else
                cb_Terreno.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Condiciones").ToString() = "ADOBE" Then
                cb_adobe.Checked = True
            Else
                cb_adobe.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Condiciones").ToString() = "BLOCK" Then
                cb_block.Checked = True
            Else
                cb_block.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Condiciones").ToString() = "MADERA" Then
                cb_Madera.Checked = True
            Else
                cb_Madera.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Condiciones").ToString() = "LADRILLO" Then
                cb_ladrillo.Checked = True
            Else
                cb_ladrillo.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Luz").ToString() = "True" Then
                cb_Luz.Checked = True
            Else
                cb_Luz.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Tel").ToString() = "True" Then
                cb_LineaTel.Checked = True
            Else
                cb_LineaTel.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Agua").ToString() = "True" Then
                cb_AguaP.Checked = True
            Else
                cb_AguaP.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Drenaje").ToString() = "True" Then
                cb_Drenaje.Checked = True
            Else
                cb_Drenaje.Checked = False
            End If
            If dt.Rows(0).Item("Viv_TubGas").ToString() = "True" Then
                cb_Tuberia.Checked = True
            Else
                cb_Tuberia.Checked = False
            End If
            If dt.Rows(0).Item("Viv_RecBasura").ToString() = "True" Then
                cb_Basura.Checked = True
            Else
                cb_Basura.Checked = False
            End If
            If dt.Rows(0).Item("Viv_TVCable").ToString() = "True" Then
                cb_TV.Checked = True
            Else
                cb_TV.Checked = False
            End If
            If dt.Rows(0).Item("Viv_Internet").ToString() = "True" Then
                cb_Internet.Checked = True
            Else
                cb_Internet.Checked = False
            End If
            If dt.Rows(0).Item("Viv_SisSeg").ToString() = "True" Then
                cb_SisSeg.Checked = True
            Else
                cb_SisSeg.Checked = False
            End If
            If dt.Rows(0).Item("Trasn_Metro").ToString() = "True" Then
                cb_Metro.Checked = True
            Else
                cb_Metro.Checked = False
            End If
            If dt.Rows(0).Item("Trans_Publico").ToString() = "True" Then
                cb_Trans.Checked = True
            Else
                cb_Trans.Checked = False
            End If
            If dt.Rows(0).Item("Trans_Taxi").ToString() = "True" Then
                cb_Taxi.Checked = True
            Else
                cb_Taxi.Checked = False
            End If
            If dt.Rows(0).Item("Trans_VehPropio").ToString() = "True" Then
                cb_Vehi.Checked = True
            Else
                cb_Vehi.Checked = False
            End If
            txt_SE__SOCIALE.Text = dt.Rows(0).Item("Act_EvSociales").ToString()
            txt_SE_EVENTOS.Text = dt.Rows(0).Item("Act_EvCominitarios").ToString()
            txt_SE_MUSEOS.Text = dt.Rows(0).Item("Act_Museos").ToString()
            txt_SE_TEATROS.Text = dt.Rows(0).Item("Act_Teatros").ToString()
            txt_SE_CINES.Text = dt.Rows(0).Item("Act_Cines").ToString()
            txt_SE_CULTURALES.Text = dt.Rows(0).Item("Act_FesCulturaes").ToString()
            txt_SE_ZONAS.Text = dt.Rows(0).Item("Act_ZonasArq").ToString()
            txt_SE_VACIONES.Text = dt.Rows(0).Item("Act_Vaciones").ToString()
            txt_SE_PLAZAS.Text = dt.Rows(0).Item("Act_PlazasPub").ToString()
            txt_SE_NATURALES.Text = dt.Rows(0).Item("Act_ParquesNat").ToString()
            txt_se_diversiones.Text = dt.Rows(0).Item("Act_PaquesDiv").ToString()
            txt_GFRenta.Text = dt.Rows(0).Item("GF_Renta").ToString()
            txt_GFCole.Text = dt.Rows(0).Item("GF_Colegio").ToString()
            Txt_GFDesp.Text = dt.Rows(0).Item("GF_Despensa").ToString()
            txt_GFServ.Text = dt.Rows(0).Item("GF_Servicios").ToString()
            Txt_pasatiempos.Text = dt.Rows(0).Item("ES_Pasatiempos").ToString()
            txt_Religion.Text = dt.Rows(0).Item("ES_Religion").ToString()
            txt_commen.Text = dt.Rows(0).Item("ES_Observaciones").ToString()
            If IsDBNull(dt.Rows(0).Item("Img_Dom")) Then
            Else
                Dim bytes As [Byte]() = dt.Rows(0).Item("Img_Dom")
                Dim ms As New MemoryStream(bytes)
                PB_IMAGE_VIVIENDA.Image = Image.FromStream(ms)
            End If
        End If
        EMPLEADO_ES = If(dt.Rows.Count > 0, Convert.ToInt64(dt.Rows(0).Item("ID_EstSocio").ToString()), 0)

        dgv_OI.DataSource = objcon.Consulta_OI(EMPLEADO_ES)
        dgv_Ref.DataSource = objcon.Consulta_REF(EMPLEADO_ES)
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
        If txt_numero.Text = "" Then
        Else
            Dim Wait As New Wait()
            Wait.Show()
            Dim Reportes As New Reportes With {
                    .ReportOption = Convert.ToInt64(1),
                    .Emp = Convert.ToInt64(txt_numero.Text),
                    .User = NName
                }
            Wait.Close()
            Reportes.ShowDialog()
        End If
    End Sub

    Private Sub foto_DoubleClick(sender As Object, e As EventArgs) Handles foto.DoubleClick
        cargarImagen(foto)
    End Sub

    Private Sub PB_IMAGE_VIVIENDA_DoubleClick(sender As Object, e As EventArgs) Handles PB_IMAGE_VIVIENDA.DoubleClick
        cargarImagen(PB_IMAGE_VIVIENDA)
    End Sub
End Class