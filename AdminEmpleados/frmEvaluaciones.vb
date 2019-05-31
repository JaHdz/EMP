Public Class frmEvaluaciones
    Dim Resultado As Object
    Public Sub Llenar_buscador(tipo As String)
        Dim popup As New frmPopUpCatalogo(tipo)
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        Dim Evaluacion As New EvaluacionDeEmpleado(0, EV.Text, txt_numero.Text, dtpFecha.Value, TXT_commen.Text, UsuarioLogeado.ID)
        If Evaluacion.Registrar(dgv_Evaluaciones.DataSource) Then
            dgv_Evaluaciones.Refresh()
            EV.Text = ""
            EV2.Text = ""
            dtpFecha.ResetText()
            TXT_commen.Text = ""
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txt_numero.Text = ""
        EV.Text = ""
        EV2.Text = ""
        dtpFecha.ResetText()
        TXT_commen.Text = ""
        txtEmpleado.Text = ""
        dgv_Evaluaciones.DataSource = Nothing
    End Sub


    Private Sub Dgv_Evaluaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Evaluaciones.CellClick
        If e.ColumnIndex = 0 Then
            If MessageBox.Show("Esta a punto de eliminar una evaluacion de este empleado, ¿Esta seguro que desea eliminar este registro?", "Eliminar evaluacion de empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim Vista = CType(dgv_Evaluaciones.CurrentRow.DataBoundItem, EvaluacionDeEmpleado.EvaluacionEmpleadoVista)
                Dim EvaluacionDeEmpleado = New EvaluacionDeEmpleado(Vista.ID, 0, Vista.Empleado, Vista.Fecha, Vista.Comentario, 0)
                If EvaluacionDeEmpleado.Eliminar(dgv_Evaluaciones.DataSource) Then
                    dgv_Evaluaciones.Refresh()
                End If
            End If
        End If
    End Sub

    Private Sub Buscar_EN_Click_1(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Empleado)
        Dim Empleado As Empleado.Vista = CType(Resultado, Empleado.Vista)
        If Empleado IsNot Nothing Then
            txt_numero.Text = Empleado.ID.ToString()
            txtEmpleado.Text = String.Concat(Empleado.Nombre, " ", Empleado.ApellidoPaterno, " ", Empleado.ApellidoMaterno)
            dgv_Evaluaciones.DataSource = New EvaluacionDeEmpleado(0, 0, txt_numero.Text, Now(), "", UsuarioLogeado.ID).CargarListado(txt_numero.Text)
        End If
    End Sub

    Private Sub Buscar_EV_Click(sender As Object, e As EventArgs) Handles buscar_EV.Click
        Llenar_buscador(BuscarPor.Evaluacion)
        Dim Evaluacion As Evaluacion = CType(Resultado, Evaluacion)
        If Evaluacion IsNot Nothing Then
            EV.Text = Evaluacion.ID
            EV2.Text = Evaluacion.Codigo
        End If
    End Sub
End Class