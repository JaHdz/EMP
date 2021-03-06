﻿Public Class Administration
    Dim NEmp As Integer
    Dim objcon As New Consultas
    Dim V1 As String
    Dim V2 As String
    Dim NEmpUser As Integer
    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Sub New(ByVal emp As Integer)
        InitializeComponent()
        NEmpUser = emp
    End Sub
    Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave
        If (txt_numero.Text <> "") Then
            NEmp = Convert.ToInt16(objcon.Emp_Exist(txt_numero.Text))
            If (NEmp > 0) Then
                Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", txt_numero.Text}}
                Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.GetEmployeeInfo
            }
                Wait.ShowDialog()
                Dim Result As Cls_Emp = Wait.Result
                Wait.Close()
                lbl_emp.Text = txt_numero.Text + " | " + Result.Emp_Name + " " + Result.Emp_APat + " " + Result.Emp_AMat
                dgv_equipo_emp.DataSource = objcon.Consulta_USER()
            Else
                MessageBox.Show("Numero de empleado no existe")
                txt_numero.Text = ""
                lbl_emp.Text = ""
                txt_numero.Focus()
            End If
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click, PictureBox2.Click, cancel_code.Click, cancel_eq.Click, CANCEL_EVAL.Click, btn_CancelPuesto.Click,
                                                                       btn_cancelsuper.Click, pb_cancelTE.Click
        For Each ctrl In Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.Text = ""
            End If
        Next
    End Sub

    Private Sub dgv_equipo_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipo_emp.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATE"
                            If MessageBox.Show("Seguro que desea desactivar este usuario?", "Desactivar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_equipo_emp.Rows(e.RowIndex).Cells(5).Value.ToString = "False" Then
                                    If objcon.Add_USERS(dgv_equipo_emp.Rows(e.RowIndex).Cells(1).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(3).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(4).Value, 1, 1, dgv_equipo_emp.Rows(e.RowIndex).Cells(2).Value) = True Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_USERS(dgv_equipo_emp.Rows(e.RowIndex).Cells(1).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(3).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(4).Value, 0, 0, dgv_equipo_emp.Rows(e.RowIndex).Cells(2).Value) = True Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_USER()
            dgv_equipo_emp.DataSource = dt
        End If
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If txt_numero.Text = "" Or txt_pass.Text = "" Or txt_user.Text = "" Or txt_pass2.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If txt_pass.Text <> txt_pass2.Text Then
                MessageBox.Show("Las conraseñas no coinciden.")
            Else
                If objcon.Add_USERS(0, txt_user.Text, txt_pass.Text, 1, 1, txt_numero.Text) = True Then
                Else
                    MessageBox.Show("Este registro ya Existe.")
                End If
                dgv_equipo_emp.DataSource = objcon.Consulta_USER()
                txt_pass.Text = ""
                txt_pass2.Text = ""
                txt_numero.Text = ""
                txt_user.Text = ""
                txt_numero.Focus()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TXT_CAPCODIGO.Text = "" Or TXT_CAP_DESC.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_TRANINGS(0, TXT_CAPCODIGO.Text, TXT_CAP_DESC.Text, 1) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            DGV_CAT.DataSource = objcon.Consulta_Cap()
            TXT_CAPCODIGO.Text = ""
            TXT_CAP_DESC.Text = ""
            TXT_CAPCODIGO.Focus()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub DGV_CAT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CAT.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEC"
                            If MessageBox.Show("Seguro que desea dar de baja esta capacitacion?", "Baja Capacitacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If objcon.DELETE_CAPACITACION_ADMIN(DGV_CAT.Rows(e.RowIndex).Cells(1).Value) = False Then
                                    MessageBox.Show("No se puede eliminar esta capacitación ya que fue impartida a uno o varios empleados")
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_Cap()
            DGV_CAT.DataSource = dt
        End If
    End Sub

    Private Sub save_cod_Click(sender As Object, e As EventArgs) Handles save_cod.Click
        If txt_depcod.Text = "" Or txt_coddes.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If (objcon.Add_DEPTO(0, txt_depcod.Text, txt_coddes.Text, 1) = True) Then
                dgv_depto.DataSource = objcon.Consulta_depto()
                txt_depcod.Text = ""
                txt_coddes.Text = ""
                txt_depcod.Focus()
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
        End If
    End Sub

    Private Sub cancel_code_Click(sender As Object, e As EventArgs) Handles cancel_code.Click
        Me.Close()
    End Sub

    Private Sub txt_eqcost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eqcost.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub save_eq_Click(sender As Object, e As EventArgs) Handles save_eq.Click
        If txt_eqcod.Text = "" Or txt_eqdesc.Text = "" Or txt_eqcost.Text = "" Or txtDpto.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_EQUIPMENT(0, txt_eqcod.Text, txt_eqdesc.Text, txt_eqcost.Text, True, lblDpto.Text) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_eq.DataSource = objcon.Consulta_EQ()
            txt_eqdesc.Text = ""
            txt_eqcost.Text = ""
            txt_eqcod.Text = ""
            txt_eqcod.Focus()
        End If
    End Sub

    Private Sub SAVE_EVAL_Click(sender As Object, e As EventArgs) Handles SAVE_EVAL.Click
        If txt_evalcod.Text = "" Or txt_eval_des.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_EVALUATIONS(0, txt_evalcod.Text, txt_eval_des.Text, 1) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_eval.DataSource = objcon.Consulta_EV()
            txt_evalcod.Text = ""
            txt_eval_des.Text = ""
            txt_evalcod.Focus()
        End If
    End Sub

    Private Sub CANCEL_EVAL_Click(sender As Object, e As EventArgs) Handles CANCEL_EVAL.Click
        Me.Close()
    End Sub

    Private Sub dgv_eval_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eval.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEE"
                            If MessageBox.Show("Seguro que desea dar de baja esta Evaluacion?", "Baja Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_eval.Rows(e.RowIndex).Cells(4).Value.ToString = "True" Then
                                    If objcon.DELETE_ADMIN_EVALUATIONS(gr(2, e.RowIndex()).Value.ToString()) = False Then
                                        MessageBox.Show("No se puede eliminar esta evaluación ya que fue impartida a uno o varios empleados")
                                    End If
                                Else
                                    'hacer algo aqui'
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_EV()
            dgv_eval.DataSource = dt
        End If
    End Sub

    Private Sub cancel_eq_Click(sender As Object, e As EventArgs) Handles cancel_eq.Click
        Me.Close()
    End Sub

    Private Sub dgv_depto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_depto.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATED"
                            If MessageBox.Show("Seguro que desea dar de baja este Departamento?", "Baja Departamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If objcon.DELETE_DEPTO_ADMIN(dgv_depto.Rows(e.RowIndex).Cells(1).Value) = False Then
                                    MessageBox.Show("No se puede eliminar este departamento ya que fue asignado a uno o varios empleados")
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_depto()
            dgv_depto.DataSource = dt
        End If
    End Sub

    Private Sub dgv_eq_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eq.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEEQ"
                            If MessageBox.Show("Seguro que desea dar de baja este Equipo?", "Baja Equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If CType(dgv_eq.Rows(e.RowIndex).Cells(5).Value.ToString, Boolean) = True Then
                                    If objcon.DELETE_EQUIPMENT_ADMIN(gr(2, e.RowIndex()).Value.ToString()) = False Then
                                        MessageBox.Show("No se puede eliminar este equipo ya que fue asignado a uno o varios empleados")
                                    End If
                                Else
                                    'If MessageBox.Show("Este equipo ya esta dado de baja, Deseas activarlo nuevamente?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                    '    'actualizar el registro para activarlo
                                    'End If
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_EQ()
            dgv_eq.DataSource = dt
        End If
    End Sub

    Private Sub btn_SavePuesto_Click(sender As Object, e As EventArgs) Handles btn_SavePuesto.Click
        If txt_PuestoNombre.Text = "" Or txt_PuestoDescripcion.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_POSITIONS(0, txt_PuestoNombre.Text, txt_PuestoDescripcion.Text, cb_PuestoRiesgo.CheckState, 1) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_Puesto.DataSource = objcon.Consulta_PU()
            txt_PuestoDescripcion.Text = ""
            txt_PuestoNombre.Text = ""
            txt_PuestoNombre.Focus()
        End If
    End Sub

    Private Sub btn_CancelPuesto_Click(sender As Object, e As EventArgs) Handles btn_CancelPuesto.Click
        Me.Close()
    End Sub

    Private Sub dgv_Puesto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Puesto.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEPU"
                            If MessageBox.Show("Seguro que desea dar de baja este puesto?", "Baja Puesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If gr(5, e.RowIndex).Value = True Then
                                    If objcon.DELETE_ADMIN_POSITIONS(gr(1, e.RowIndex).Value) = False Then
                                        MessageBox.Show("No se puede eliminar este puesto ya que fue asignado a uno o varios empleados")
                                    End If
                                Else
                                    'hacer algo aqui'
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_PU()
            dgv_Puesto.DataSource = dt
        End If
    End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        llenar_buscador("EMP")
        If (V1 <> "" And V2 <> "") Then
            txt_numero.Focus()
        Else
            txt_numero.Focus()
        End If
        txt_numero.Text = V1
    End Sub

    Private Sub TXT_EMP_SUPER_Leave(sender As Object, e As EventArgs) Handles TXT_EMP_SUPER.Leave
        If (TXT_EMP_SUPER.Text <> "") Then
            NEmp = Convert.ToInt16(objcon.Emp_Exist(TXT_EMP_SUPER.Text))
            If (NEmp > 0) Then
                Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", TXT_EMP_SUPER.Text}}
                Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.GetEmployeeInfo
            }
                Wait.ShowDialog()
                Dim Result As Cls_Emp = Wait.Result
                Wait.Close()
                TXT_EMP_SUPERname.Text = TXT_EMP_SUPER.Text + " | " + Result.Emp_Name + " " + Result.Emp_APat + " " + Result.Emp_AMat
                dgv_super.DataSource = objcon.Consulta_SU()
            Else
                MessageBox.Show("Numero de empleado no existe")
                TXT_EMP_SUPER.Text = ""
                TXT_EMP_SUPERname.Text = ""
            End If
        End If
    End Sub

    Public Sub llenar_buscador(tipo As String)
        Dim popup As New frmPopUp(tipo)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        V1 = popup.Variable
        V2 = popup.Variable2
        popup.Close()
    End Sub
    Private Sub BUSCAR_EMP_SUPER_Click(sender As Object, e As EventArgs) Handles BUSCAR_EMP_SUPER.Click
        llenar_buscador("EMP")
        If (V1 <> "" And V2 <> "") Then
            TXT_EMP_SUPER.Focus()
        Else
            TXT_EMP_SUPER.Focus()
        End If
        TXT_EMP_SUPER.Text = V1
    End Sub

    Private Sub TXT_EMP_SUPER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_EMP_SUPER.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btn_savesuper_Click(sender As Object, e As EventArgs) Handles btn_savesuper.Click
        If TXT_EMP_SUPER.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_SUPER(0, TXT_EMP_SUPER.Text, " ", 1) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_super.DataSource = objcon.Consulta_SU()
            TXT_EMP_SUPER.Text = ""
            TXT_EMP_SUPER.Focus()
        End If
    End Sub

    Private Sub btn_cancelsuper_Click(sender As Object, e As EventArgs) Handles btn_cancelsuper.Click
        Me.Close()
    End Sub

    Private Sub dgv_super_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_super.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATESU"
                            If MessageBox.Show("Seguro que desea dar de baja a este supervisor?", "Baja Supervisor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_super.Rows(e.RowIndex).Cells(5).Value.ToString = "True" Then
                                    If objcon.DELETE_ADMIN_SUPER((dgv_super.Rows(e.RowIndex).Cells(1).Value)) = False Then
                                        MessageBox.Show("No se puede eliminar este supervisor ya que fue asignado a uno o varios empleados")
                                    End If
                                Else
                                    'HACER ALGO'
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_SU()
            dgv_super.DataSource = dt
        End If
    End Sub

    Private Sub pb_saveTE_Click(sender As Object, e As EventArgs) Handles pb_saveTE.Click
        If txt_codigoTE.Text = "" Or txt_DescTE.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_TE(0, txt_codigoTE.Text, txt_DescTE.Text, 1) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_te.DataSource = objcon.Consulta_TE()
            txt_codigoTE.Text = ""
            txt_DescTE.Text = ""
            txt_codigoTE.Focus()
        End If
    End Sub

    Private Sub pb_cancelTE_Click(sender As Object, e As EventArgs) Handles pb_cancelTE.Click
        Me.Close()
    End Sub

    Private Sub dgv_te_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_te.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATETE"
                            If MessageBox.Show("Seguro que desea dar de baja a este tipo de empleado?", "Baja de tipo de empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_te.Rows(e.RowIndex).Cells(4).Value.ToString = "True" Then
                                    If objcon.DELETE_ADMIN_TE(dgv_te.Rows(e.RowIndex).Cells(1).Value) = False Then
                                        MessageBox.Show("No se puede eliminar este 'Tipo de Empleado' ya que fue asignado a uno o varios empleados")
                                    End If
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_TE()
            dgv_te.DataSource = dt
        End If
    End Sub

    Private Sub tab_admin_Click(sender As Object, e As EventArgs) Handles tab_admin.Click
        'DGV_CAT.DataSource = objcon.Consulta_Cap()
        'dgv_depto.DataSource = objcon.Consulta_depto()
        'dgv_eq.DataSource = objcon.Consulta_EQ()
        'dgv_eval.DataSource = objcon.Consulta_EV()
        'dgv_Puesto.DataSource = objcon.Consulta_PU()
        'dgv_super.DataSource = objcon.Consulta_SU()
        'dgv_te.DataSource = objcon.Consulta_TE()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_equipo_emp.DataSource = objcon.Consulta_USER()
        DGV_CAT.DataSource = objcon.Consulta_Cap()
        dgv_depto.DataSource = objcon.Consulta_depto()
        dgv_eq.DataSource = objcon.Consulta_EQ()
        dgv_eval.DataSource = objcon.Consulta_EV()
        dgv_Puesto.DataSource = objcon.Consulta_PU()
        dgv_super.DataSource = objcon.Consulta_SU()
        dgv_te.DataSource = objcon.Consulta_TE()
    End Sub

    Private Sub pbSearchDpto_Click(sender As Object, e As EventArgs) Handles pbSearchDpto.Click
        llenar_buscador("DE")
        If (V1 <> "" And V2 <> "") Then
            lblDpto.Text = V1
            txtDpto.Text = V2
        Else
            lblDpto.Text = ""
            txtDpto.Text = ""
            pbSearchDpto.Focus()
        End If

    End Sub
End Class