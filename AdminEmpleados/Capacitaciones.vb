Public Class Capacitaciones

    Dim objcon As New Consultas
    Dim V1 As String
    Dim V2 As String
    Dim NEmp As Integer
    Dim NEmpUser As Integer
    Sub New(ByVal emp As Integer)
        InitializeComponent()
        NEmpUser = emp
    End Sub
    Public Sub llenar_buscador(tipo As String)
        Dim popup As New frmPopUp(tipo)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        V1 = popup.Variable
        V2 = popup.Variable2
        popup.Close()
    End Sub
    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    'Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave


    'End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        llenar_buscador("EMP")
        If (V1 <> "" And V2 <> "") Then
            txt_numero.Text = V1
        Else
            txt_numero.Focus()
        End If

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
                dgv_capacitacion.DataSource = objcon.Consulta_CAPACITACION(txt_numero.Text)
            Else
                MessageBox.Show("Numero de empleado no existe")
                txt_numero.Text = ""
                lbl_emp.Text = ""
            End If
        End If
    End Sub

    Private Sub Eq_Leave(sender As Object, e As EventArgs) Handles CAP.Leave
        If (CAP.Text <> "") Then
            V2 = objcon.S_catalago(CAP.Text, "CAT")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                CAP.Text = ""
                CAP.Focus()
            Else
                CAP2.Text = V2
            End If
        End If
    End Sub

    Private Sub buscar_eq_Click(sender As Object, e As EventArgs) Handles buscar_CAP.Click
        llenar_buscador("CAT")
        If (V1 <> "" And V2 <> "") Then
            CAP.Focus()
        Else
            CAP.Focus()
        End If
        CAP.Text = V1
        CAP2.Text = V2

    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If (CAP.Text <> "" Or txt_numero.Text <> "") Then
            If objcon.Add_TRAINING(0, CAP.Text, txt_numero.Text, TXT_FECHA.Text, TXT_commen.Text) = False Then
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_capacitacion.DataSource = objcon.Consulta_CAPACITACION(txt_numero.Text)
            CAP.Text = ""
            CAP2.Text = ""
            TXT_FECHA.Text = Date.Now.ToShortDateString
            TXT_commen.Text = ""
        Else
            MessageBox.Show("Debe ingresar un numero de empleado valido y una Capacitacion.")
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txt_numero.Text = ""
        CAP.Text = ""
        CAP2.Text = ""
        TXT_FECHA.ResetText()
        TXT_commen.Text = ""
        dgv_capacitacion.DataSource = Nothing
    End Sub


    Private Sub dgv_capacitacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_capacitacion.CellClick
        Dim id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.ColumnIndex = 0 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "DELETE"
                            If MessageBox.Show("Seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                id = dgv_capacitacion.Rows(e.RowIndex).Cells(3).Value
                                objcon.DELETE_CAPACITACION(dgv_capacitacion.Rows(e.RowIndex).Cells(1).Value)
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            If txt_numero.Text <> "" Then
                dt = objcon.Consulta_CAPACITACION(txt_numero.Text)
            Else
                dt = objcon.Consulta_CAPACITACION(id)
            End If
            dgv_capacitacion.DataSource = dt
        End If
    End Sub

End Class