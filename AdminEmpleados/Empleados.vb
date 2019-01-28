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
        Try
            numeroleave()
            llenarFamilia()
            llenarAL()
            llenarContacto()
            llenarEnfermedades()
            llenarSE()
        Catch ex As Exception
            MessageBox.Show("Numero de empleado no valido")
        End Try
    End Sub
    Private Sub numeroleave()
        Dim numero As String
        numero = txt_numero.Text
        txt_activo.Text = ""
        txt_baja.Text = ""
        ALTA.Visible = False
        lbl_ALTA.Visible = False
        If (txt_numero.Text <> "") Then
            aux = objcon.Emp_Exist(txt_numero.Text)
            If (aux = 1) Then
                llenar()
                EXISTE = True
                lbl_emp.Text = txt_numero.Text + " | " + txt_NOM.Text + " " + txt_AP.Text + " " + txt_AM.Text
                EMPLEADO_ID = txt_numero.Text
            Else
                limp()
                lbl_emp.Text = ""
                EMPLEADO_ID = ""
                txt_numero.Text = numero
                EXISTE = False
                'pnl_save.Text = "GUARDAR"
            End If
        Else
            txt_numero.Focus()
        End If
    End Sub
    Public Sub llenar()
        Dim objCon As New Consultas()
        Dim objEmp As New Cls_Emp()
        Dim dt As DataTable = objCon.Consulta_empleado(Convert.ToInt64(txt_numero.Text))
        pnl_save.Text = ""
        If (dt.Rows.Count <= 0) Then
        Else
            txt_AP.Text = dt.Rows(0).Item("Emp_APat").ToString()
            txt_AM.Text = dt.Rows(0).Item("Emp_AMat").ToString()
            txt_NOM.Text = dt.Rows(0).Item("Emp_Name").ToString()
            ddl_educacion.SelectedItem = dt.Rows(0).Item("Emp_NEducativo").ToString()
            txt_FECHA.Text = dt.Rows(0).Item("Emp_FNac").ToString()
            txt_RFC.Text = dt.Rows(0).Item("Emp_RFC").ToString()
            txt_SS.Text = dt.Rows(0).Item("Emp_NSS").ToString()
            txt_CURP.Text = dt.Rows(0).Item("Emp_Curp").ToString()
            Celular.Text = dt.Rows(0).Item("Emp_Cel").ToString()
            txt_telefono.Text = dt.Rows(0).Item("Emp_Tel").ToString()
            EC.Text = dt.Rows(0).Item("Emp_EdoCivil").ToString()
            nacion.Text = dt.Rows(0).Item("Emp_Nacionalidad").ToString()
            domicilio.Text = dt.Rows(0).Item("Emp_Domicilio").ToString()
            colonia.Text = dt.Rows(0).Item("Emp_Col").ToString()
            CP.Text = dt.Rows(0).Item("Emp_CP").ToString()
            txt_FECHAINGRESO.Text = dt.Rows(0).Item("Emp_FEfectiva").ToString()
            txt_SALARY.Text = dt.Rows(0).Item("Emp_Salario").ToString()
            Txt_correo.Text = dt.Rows(0).Item("Emp_Email").ToString()
            If IsDBNull(dt.Rows(0).Item("Emp_Activo").ToString()) Then
                txt_baja.Text = ""
            Else
                txt_baja.Text = dt.Rows(0).Item("Emp_Activo").ToString()
            End If
            If dt.Rows(0).Item("Alerta").ToString() = True Then
                seg.Checked = True
            Else
                seg.Checked = False
            End If
            If dt.Rows(0).Item("NProv").ToString() = True Then
                CB_PROV.Checked = True
            Else
                CB_PROV.Checked = False
            End If
            If dt.Rows(0).Item("NClientes").ToString() = True Then
                CB_CLIENTE.Checked = True
            Else
                CB_CLIENTE.Checked = False
            End If
            commen.Text = dt.Rows(0).Item("Motivo").ToString()
            txt_EN.Text = dt.Rows(0).Item("Emp_EN").ToString()
            txt_PUESTO.Text = dt.Rows(0).Item("ID_Puesto").ToString()
            txt_tipo.Text = dt.Rows(0).Item("Emp_Tipo").ToString()
            txt_SUPER.Text = dt.Rows(0).Item("Emp_Sup").ToString()
            cuidad.Text = dt.Rows(0).Item("Emp_Ciudad").ToString()
            depto.Text = dt.Rows(0).Item("ID_Depto").ToString()
            If (dt.Rows(0).Item("Img_Emp").ToString() Is Nothing Or dt.Rows(0).Item("Img_Emp").ToString() = "") Then
                foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
            Else
                Dim bytes As [Byte]() = dt.Rows(0).Item("Img_Emp")
                Dim ms As New MemoryStream(bytes)
                foto.Image = Image.FromStream(ms)
                foto.Visible = True
            End If
            If (txt_EN.Text <> "") Then
                V2 = objCon.S_catalago(txt_EN.Text, "EN")
                If (V2 = "" Or V2 Is Nothing) Then
                    txt_EN2.Text = ""
                Else
                    txt_EN2.Text = V2
                End If
            End If

            If (cuidad.Text <> "") Then
                V2 = objCon.S_catalago(cuidad.Text, "CI")
                If (V2 = "" Or V2 Is Nothing) Then
                    cuidad2.Text = ""
                Else
                    cuidad2.Text = V2
                End If
            End If

            If (depto.Text <> "") Then
                V2 = objCon.S_catalago(depto.Text, "DE")
                If (V2 = "" Or V2 Is Nothing) Then
                    depto2.Text = ""
                Else
                    depto2.Text = V2
                End If
            End If
            If (txt_PUESTO.Text <> "") Then
                V2 = objCon.S_catalago(txt_PUESTO.Text, "PU")
                If (V2 = "" Or V2 Is Nothing) Then
                    txt_PUESTO2.Text = ""
                Else
                    txt_PUESTO2.Text = V2
                End If
            End If
            If (txt_SUPER.Text <> "") Then
                V2 = objCon.S_catalago(txt_SUPER.Text, "SU")
                If (V2 = "" Or V2 Is Nothing) Then
                    txt_SUPER2.Text = ""
                Else
                    txt_SUPER2.Text = V2
                End If
            End If
            If (txt_tipo.Text <> "") Then
                V2 = objCon.S_catalago(txt_tipo.Text, "TI")
                If (V2 = "" Or V2 Is Nothing) Then
                    txt_tipo2.Text = ""
                Else
                    txt_tipo2.Text = V2
                End If
            End If
            If (dt.Rows(0).Item("Emp_Sexo").ToString() = "M") Then
                CB_SEXO.SelectedIndex = 1
            End If
            If (dt.Rows(0).Item("Emp_Sexo").ToString() = "F") Then
                CB_SEXO.SelectedIndex = 0
            End If
            If dt.Rows(0).Item("Emp_Activo").ToString() = True Then
                txt_activo.Text = "SI"
            Else
                txt_activo.Text = "NO"
            End If
            If (dt.Rows(0).Item("Emp_Activo").ToString() = True) Then
                txt_baja.Text = "NULL"
                seg.Checked = False
                CB_CLIENTE.Checked = False
                CB_PROV.Checked = False
                commen.Text = ""
                ALTA.Visible = False
                lbl_ALTA.Visible = False
                BAJA.Visible = True
                LBL_BAJA.Visible = True
            Else
                txt_baja.Text = dt.Rows(0).Item("Fecha_Baja").ToString
                ALTA.Visible = True
                lbl_ALTA.Visible = True
                BAJA.Visible = False
                LBL_BAJA.Visible = False
            End If
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
            InfoEmp.NClientes = CB_CLIENTE.Checked
            InfoEmp.NProv = CB_PROV.Checked
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
        txt_numero.Text = Convert.ToString(Convert.ToInt64(objcon.NUMERO_EMPLEADO) + 1)
        txt_numero.Focus()
        txt_activo.Text = ""
        txt_baja.Text = ""
        ALTA.Visible = False
        lbl_ALTA.Visible = False
        foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
        foto.Visible = True
        txt_esAM.Text = ""
        txt_esAP.Text = ""
        txt_esName.Text = ""
        txt_esFN.Text = ""
        txt_esNacion.Text = ""
        cb_esSexo.SelectedIndex = -1
        llenarFamilia()
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
        PB_IMAGE_VIVIENDA.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
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
                    aux = objcon.NUMERO_EXISTS_NSS_CURP(txt_SS.Text)
                    If (aux <> 0) Then
                        txt_numero.Text = aux
                        numeroleave()
                    End If
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
                    aux = objcon.NUMERO_EXISTS_NSS_CURP(txt_CURP.Text)
                    If (aux <> 0) Then
                        txt_numero.Text = aux
                        numeroleave()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ALTA_Click(sender As Object, e As EventArgs) Handles ALTA.Click
        Try
            If (txt_numero.Text = "") Then
            Else
                objcon.Altas(txt_numero.Text, 1)
                MessageBox.Show("Se dio de Alta correctamente a este Empleado")
                llenar()
                txt_activo.Text = ""
                txt_baja.Text = ""
                seg.Checked = True
                CB_CLIENTE.Checked = False
                CB_PROV.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BAJA_Click(sender As Object, e As EventArgs) Handles BAJA.Click
        Try
            If (txt_numero.Text = "") Then
            Else
                objcon.Altas(txt_numero.Text, 0)
                objcon.Bajas(txt_numero.Text, 0, commen.Text, seg.Checked, NEmp, CB_PROV.Checked, CB_CLIENTE.Checked)
                MessageBox.Show("Se dio de Baja correctamente a este Empleado")
                txt_activo.Text = ""
                txt_baja.Text = ""
                llenar()
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
            ALTA.Visible = False
            lbl_ALTA.Visible = False
            pnl_save.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'HideTab("All")
        txt_AP.Focus()
        txt_numero.Text = Convert.ToString(Convert.ToInt64(objcon.NUMERO_EMPLEADO()) + 1)
        SAVE.Visible = True
        foto.Image = AdminEmpleados.My.Resources.Resources.photoNobody120
        foto.Visible = True
        pnl_save.Text = "GUARDAR"
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)
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
        Me.Close()
    End Sub
    Private Sub txt_EN_Leave(sender As Object, e As EventArgs) Handles txt_EN.Leave
        If (txt_EN.Text <> "") Then
            V2 = objcon.S_catalago(txt_EN.Text, "EN")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                txt_EN.Text = ""
                txt_EN.Focus()
            Else
                txt_EN2.Text = V2
            End If
        End If
    End Sub
    Private Sub txt_PUESTO_Leave(sender As Object, e As EventArgs) Handles txt_PUESTO.Leave
        If (txt_PUESTO.Text <> "") Then
            V2 = objcon.S_catalago(txt_PUESTO.Text, "PU")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                txt_PUESTO.Text = ""
                txt_PUESTO.Focus()
            Else
                txt_PUESTO2.Text = V2
            End If
        End If
    End Sub
    Private Sub txt_SUPER_Leave(sender As Object, e As EventArgs) Handles txt_SUPER.Leave
        If (txt_SUPER.Text <> "") Then
            V2 = objcon.S_catalago(txt_SUPER.Text, "SU")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                txt_SUPER.Text = ""
                txt_SUPER.Focus()
            Else
                txt_SUPER2.Text = V2
            End If
        End If
    End Sub
    Private Sub txt_tipo_Leave(sender As Object, e As EventArgs) Handles txt_tipo.Leave
        If (txt_tipo.Text <> "") Then
            V2 = objcon.S_catalago(txt_tipo.Text, "TI")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                txt_tipo.Text = ""
                txt_tipo.Focus()
            Else
                txt_tipo2.Text = V2
            End If
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
                    If objcon.Add_Referencias(0, EMPLEADO_ES, txt_RefNom.Text, txt_RefOcu.Text, Txt_TR.Text, txt_TC.Text) = True Then
                    Else
                        MessageBox.Show("Este registro ya Existe.")
                    End If
                    dgv_Ref.DataSource = objcon.Consulta_REF(EMPLEADO_ES)
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
                    If objcon.Add_OtrosIngresos(0, EMPLEADO_ES, txt_OIParen.Text, txt_OTCantidad.Text) = True Then
                    Else
                        MessageBox.Show("Este registro ya Existe.")
                    End If
                    dgv_OI.DataSource = objcon.Consulta_OI(EMPLEADO_ES)
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
            For Each ctrl In Me.Panel1.Controls
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
                id = objcon.Add_ES(ES)
                objcon.DELETE_OI(id)
                objcon.DELETE_REF(id)
                If id > 0 Then
                    objcon.Add_Image(EMPLEADO_ID, ES.IMG, foto.Image)
                    If dgv_Ref.Rows.Count > 0 Then
                        For Each row As DataGridViewRow In dgv_Ref.Rows
                            If Not row.IsNewRow Then
                                If objcon.Add_Referencias(0, id, row.Cells(0).Value.ToString, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString) = True Then
                                Else
                                    MessageBox.Show("Este registro ya Existe.")
                                End If
                            End If
                        Next
                    End If
                    If dgv_OI.Rows.Count > 0 Then
                        For Each row As DataGridViewRow In dgv_OI.Rows
                            If Not row.IsNewRow Then
                                If objcon.Add_OtrosIngresos(0, id, row.Cells(0).Value.ToString, Convert.ToDouble(row.Cells(1).Value.ToString)) = True Then
                                Else
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
                If objcon.Add_MEDCONDITIONS(0, EMPLEADO_ID, txt_enfNAME.Text) = True Then
                Else
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
                If objcon.Add_CONTACTS(0, EMPLEADO_ID, txt_conNAME.Text, txt_conAP.Text, txt_conAM.Text, txt_conPAREN.Text, txt_conTEL.Text, txt_conCEL.Text) = True Then
                Else
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
                If objcon.Add_JOBHISTORY(0, EMPLEADO_ID, txt_antFI.Text, txt_antFF.Text, txt_antEMP.Text, txt_antCARGO.Text,
                                      txt_antSALARIO.Text, txt_antTEL.Text, txt_antMT.Text, txt_antNAME.Text) = True Then
                Else
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
                If objcon.Add_Family(0, EMPLEADO_ID, "CONYUGE", txt_esName.Text, txt_esAP.Text, txt_esAM.Text, txt_esNacion.Text, txt_esFN.Text, cb_esSexo.SelectedItem.ToString(), EC.SelectedItem.ToString) = True Then
                Else
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
                If objcon.Add_Family(0, EMPLEADO_ID, "HIJO", txt_hijoNAME.Text, txt_hijoAP.Text, txt_hijoAM.Text, txt_hijoNACION.Text,
                                  txt_hijoFN.Text, txt_hijoSEXO.SelectedItem.ToString(), txt_hijoEC.SelectedItem.ToString) = True Then
                Else
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
        EMPLEADO_ES = Convert.ToInt64(dt.Rows(0).Item("ID_EstSocio").ToString())
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
            Dim Wait As New wait()
            Wait.Show()
            Dim Reportes As New Reportes With {
                    .ReportOption = Convert.ToInt64(1),
                    .Emp = Convert.ToInt64(txt_numero.Text),
                    .User = NName
                }
            Reportes.Show()
            Wait.Close()
        End If
    End Sub

    Private Sub foto_DoubleClick(sender As Object, e As EventArgs) Handles foto.DoubleClick
        cargarImagen(foto)
    End Sub

    Private Sub PB_IMAGE_VIVIENDA_DoubleClick(sender As Object, e As EventArgs) Handles PB_IMAGE_VIVIENDA.DoubleClick
        cargarImagen(PB_IMAGE_VIVIENDA)
    End Sub
End Class