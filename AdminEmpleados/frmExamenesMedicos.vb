Public Class frmExamenesMedicos
    Dim Resultado As Object
    Public Sub Llenarbuscador(tipo As Integer)
        Dim popup As New frmPopUpCatalogo(tipo)
        Dim PopUpDialog As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenarbuscador(BuscarPor.Empleado)
        Dim Empleado As Empleado.Vista = CType(Resultado, Empleado.Vista)
        If Empleado IsNot Nothing Then
            txt_numero.Text = Empleado.ID.ToString()
            txtNombre.Text = String.Concat(Empleado.Nombre, " ", Empleado.ApellidoPaterno, " ", Empleado.ApellidoMaterno)
            dgv_Examenes.DataSource = New ExamenMedico(0, txt_numero.Text, 0, 0, Now(), Now()).CargarListado(txt_numero.Text)
        End If
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        Dim ExamenMedico As New ExamenMedico(0, txt_numero.Text, TXT_EST.Text, txt_resultado.Text, dtpFecha.Value, dtpFechaProxima.Value)
        If ExamenMedico.Registrar(dgv_Examenes.DataSource) Then
            dgv_Examenes.Refresh()
            dtpFecha.ResetText()
            dtpFechaProxima.ResetText()
            TXT_EST.Text = ""
            txt_resultado.Text = ""
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txt_numero.Text = ""
        TXT_EST.Text = ""
        txt_resultado.Text = ""
        dtpFecha.ResetText()
        dtpFechaProxima.ResetText()
        dgv_Examenes.DataSource = Nothing
    End Sub


    Private Sub Dgv_Examenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Examenes.CellClick
        If e.ColumnIndex = 0 Then
            If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminar este registro?", "Eliminar examen medico", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim ExamenMedico = CType(dgv_Examenes.CurrentRow.DataBoundItem, ExamenMedico)
                If ExamenMedico.Eliminar(dgv_Examenes.DataSource) Then
                    dgv_Examenes.Refresh()
                End If
            End If
        End If
    End Sub
End Class