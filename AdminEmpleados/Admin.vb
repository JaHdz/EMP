Public Class Admin
    Dim Emp As Integer = 40606
    Dim objcon As New Consultas
    Dim V1 As String
    Dim V2 As String

    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave
        If (txt_numero.Text <> "") Then
            Emp = objcon.Emp_Exist(txt_numero.Text)
            If (Emp = 1) Then
                Dim dt As DataTable
                dt = objcon.consulta_empleado(txt_numero.Text)
                lbl_emp.Text = txt_numero.Text + " | " + dt.Rows(0).Item("Emp_Name").ToString() + " " + dt.Rows(0).Item("Emp_APat").ToString() + " " + dt.Rows(0).Item("Emp_AMat").ToString()
                dgv_equipo_emp.DataSource = objcon.Consulta_USER()
            Else
                MessageBox.Show("Numero de empleado no existe")
                txt_numero.Text = ""
                lbl_emp.Text = ""
            End If
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

    Private Sub tab_users_Click(sender As Object, e As EventArgs) Handles tab_users.Click

    End Sub

    Private Sub dgv_equipo_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipo_emp.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATE"
                            If MessageBox.Show("Seguro que desea desactivar este usuario?", "Desactivar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_equipo_emp.Rows(e.RowIndex).Cells(3).Value.ToString = "False" Then
                                    If objcon.Add_USERS(dgv_equipo_emp.Rows(e.RowIndex).Cells(1).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(2).Value, "", True, True) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_USERS(dgv_equipo_emp.Rows(e.RowIndex).Cells(1).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(2).Value, "", 0, 0) = "0" Then
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
                MessageBox.Show("Las conrasenas no coinciden.")
            Else
                If objcon.Add_USERS(0, txt_user.Text, txt_pass.Text, 1, 1) = "0" Then
                Else
                    MessageBox.Show("Este registro ya Existe.")
                End If
                dgv_equipo_emp.DataSource = objcon.Consulta_USER()
                txt_pass.Text = ""
                txt_pass2.Text = ""
                txt_numero.Enabled = ""
                txt_user.Text = ""
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TXT_CAPCODIGO.Text = "" Or TXT_CAP_DESC.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_TRANINGS(0, TXT_CAPCODIGO.Text, TXT_CAP_DESC.Text, 1) = "0" Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            DGV_CAT.DataSource = objcon.Consulta_Cap()
            TXT_CAPCODIGO.Text = ""
            TXT_CAP_DESC.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub DGV_CAT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CAT.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEC"
                            If MessageBox.Show("Seguro que desea dar de baja esta capacitacion?", "Baja Capacitacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If DGV_CAT.Rows(e.RowIndex).Cells(4).Value.ToString = "False" Then
                                    If objcon.Add_TRANINGS(DGV_CAT.Rows(e.RowIndex).Cells(1).Value, DGV_CAT.Rows(e.RowIndex).Cells(2).Value, DGV_CAT.Rows(e.RowIndex).Cells(3).Value, 1) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_TRANINGS(DGV_CAT.Rows(e.RowIndex).Cells(1).Value, DGV_CAT.Rows(e.RowIndex).Cells(2).Value, DGV_CAT.Rows(e.RowIndex).Cells(3).Value, 0) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
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
            If objcon.Add_DEPTO(0, txt_depcod.Text, txt_coddes.Text, 1) = "0" Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_depto.DataSource = objcon.Consulta_depto()
            txt_depcod.Text = ""
            txt_coddes.Text = ""
        End If
    End Sub

    Private Sub cancel_code_Click(sender As Object, e As EventArgs) Handles cancel_code.Click
        Me.Close()
    End Sub

    Private Sub txt_eqcost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eqcost.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub save_eq_Click(sender As Object, e As EventArgs) Handles save_eq.Click
        If txt_eqcod.Text = "" Or txt_eqdesc.Text = "" Or txt_eqcost.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_EQUIPMENT(0, txt_eqcod.Text, txt_eqdesc.Text, txt_eqcost.Text, 1) = "0" Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_eq.DataSource = objcon.Consulta_EQ()
            txt_eqdesc.Text = ""
            txt_eqcost.Text = ""
        End If
    End Sub

    Private Sub SAVE_EVAL_Click(sender As Object, e As EventArgs) Handles SAVE_EVAL.Click
        If txt_evalcod.Text = "" Or txt_eval_des.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If objcon.Add_EVALUATIONS(0, txt_evalcod.Text, txt_eval_des.Text, 1) = "0" Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_eval.DataSource = objcon.Consulta_EV()
            txt_evalcod.Text = ""
            txt_eval_des.Text = ""
        End If
    End Sub

    Private Sub CANCEL_EVAL_Click(sender As Object, e As EventArgs) Handles CANCEL_EVAL.Click
        Me.Close()
    End Sub

    Private Sub dgv_eval_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eval.CellClick
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEE"
                            If MessageBox.Show("Seguro que desea dar de baja esta Evaluacion?", "Baja Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_eval.Rows(e.RowIndex).Cells(4).Value.ToString = "False" Then
                                    If objcon.Add_EVALUATIONS(dgv_eval.Rows(e.RowIndex).Cells(1).Value, dgv_eval.Rows(e.RowIndex).Cells(2).Value, dgv_eval.Rows(e.RowIndex).Cells(3).Value, 1) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_EVALUATIONS(dgv_eval.Rows(e.RowIndex).Cells(1).Value, dgv_eval.Rows(e.RowIndex).Cells(2).Value, dgv_eval.Rows(e.RowIndex).Cells(3).Value, 0) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
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
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATED"
                            If MessageBox.Show("Seguro que desea dar de baja esta Evaluacion?", "Baja Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_depto.Rows(e.RowIndex).Cells(4).Value.ToString = "False" Then
                                    If objcon.Add_DEPTO(dgv_depto.Rows(e.RowIndex).Cells(1).Value, dgv_depto.Rows(e.RowIndex).Cells(2).Value, dgv_depto.Rows(e.RowIndex).Cells(3).Value, 1) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_DEPTO(dgv_depto.Rows(e.RowIndex).Cells(1).Value, dgv_depto.Rows(e.RowIndex).Cells(2).Value, dgv_depto.Rows(e.RowIndex).Cells(3).Value, 0) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
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
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATEEQ"
                            If MessageBox.Show("Seguro que desea dar de baja esta Evaluacion?", "Baja Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                If dgv_eq.Rows(e.RowIndex).Cells(5).Value.ToString = "False" Then
                                    If objcon.Add_EQUIPMENT(dgv_eq.Rows(e.RowIndex).Cells(1).Value, dgv_eq.Rows(e.RowIndex).Cells(2).Value, dgv_eq.Rows(e.RowIndex).Cells(3).Value, dgv_eq.Rows(e.RowIndex).Cells(4).Value, 0) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                Else
                                    If objcon.Add_EQUIPMENT(dgv_eq.Rows(e.RowIndex).Cells(1).Value, dgv_eq.Rows(e.RowIndex).Cells(2).Value, dgv_eq.Rows(e.RowIndex).Cells(3).Value, dgv_eq.Rows(e.RowIndex).Cells(4).Value, 1) = "0" Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            dt = objcon.Consulta_EQ()
            dgv_eq.DataSource = dt
        End If
    End Sub
End Class