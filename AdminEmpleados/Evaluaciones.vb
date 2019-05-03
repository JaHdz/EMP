Public Class Evaluaciones

    Dim objcon As New Consultas
    Dim V1 As String
    Dim V2 As String
    Dim NEmp As Integer
    Public Sub llenar_buscador(tipo As String)
        Dim popup As New frmPopUp(tipo)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        V1 = popup.Variable
        V2 = popup.Variable2
        popup.Close()
    End Sub
    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
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
                dgv_equipo_Eval.DataSource = objcon.Consulta_Evaluaciones(txt_numero.Text)
            Else
                MessageBox.Show("Numero de empleado no existe")
                txt_numero.Text = ""
                lbl_emp.Text = ""
            End If
        End If
    End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Eq_Leave(sender As Object, e As EventArgs) Handles EV.Leave
        If (EV.Text <> "") Then
            V2 = objcon.S_catalago(EV.Text, "EV")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                EV.Text = ""
                EV.Focus()
            Else
                EV2.Text = V2
            End If
        End If
    End Sub


    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If (EV.Text <> "" Or txt_numero.Text <> "") Then
            If objcon.Add_UDSP_EMPLOYEE_EVALUATION(0, txt_numero.Text, TXT_commen.Text, UsuarioLogeado.Nombre, EV.Text) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_equipo_Eval.DataSource = objcon.Consulta_Evaluaciones(txt_numero.Text)
            txt_numero.Text = ""
            EV.Text = ""
            EV2.Text = ""
            TXT_commen.Text = ""
            lbl_emp.Text = ""
        Else
            MessageBox.Show("Debe ingresar un numero de empleado valido y una evaluacion.")
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txt_numero.Text = ""
        TXT_commen.Text = ""
        EV.Text = ""
        EV2.Text = ""
        dgv_equipo_Eval.DataSource = Nothing
    End Sub


    Private Sub dgv_equipo_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipo_Eval.CellClick
        Dim id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "DELETE"
                            If MessageBox.Show("Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                id = dgv_equipo_Eval.Rows(e.RowIndex).Cells(3).Value
                                objcon.DELETE_Evaluaciones(dgv_equipo_Eval.Rows(e.RowIndex).Cells(1).Value)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            If txt_numero.Text <> "" Then
                dt = objcon.Consulta_Evaluaciones(txt_numero.Text)
            Else
                dt = objcon.Consulta_Evaluaciones(id)
            End If
            dgv_equipo_Eval.DataSource = dt
        End If
    End Sub

    Private Sub buscar_EN_Click_1(sender As Object, e As EventArgs) Handles buscar_EN.Click


        llenar_buscador("EMP")
        If (V1 <> "" And V2 <> "") Then
            txt_numero.Focus()
        Else
            txt_numero.Focus()
        End If
        txt_numero.Text = V1
    End Sub

    Private Sub buscar_EV_Click(sender As Object, e As EventArgs) Handles buscar_EV.Click
        llenar_buscador("EV")
        If (V1 <> "" And V2 <> "") Then
            EV.Focus()
        Else
            EV.Focus()
        End If
        EV.Text = V1
        EV2.Text = V2
    End Sub
End Class