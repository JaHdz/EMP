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
                objcon.Add_USERS(0, txt_user.Text, txt_pass.Text, 1, 1)
                dgv_equipo_emp.DataSource = objcon.Consulta_USER()
                txt_pass.Text = ""
                txt_pass2.Text = ""
                txt_numero.Enabled = ""
                txt_user.Text = ""
            End If
        End If
    End Sub
End Class