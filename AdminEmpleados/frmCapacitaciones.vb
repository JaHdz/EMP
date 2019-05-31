Public Class frmCapacitaciones
    Dim Resultado As Object
    Public Sub Llenar_buscador(tipo As String)
        Dim popup As New frmPopUpCatalogo(tipo)
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Empleado)
        Dim loEmpleado As Empleado.Vista = CType(Resultado, Empleado.Vista)
        If loEmpleado IsNot Nothing Then
            txt_numero.Text = loEmpleado.ID.ToString()
            txtNombre.Text = String.Concat(loEmpleado.Nombre, " ", loEmpleado.ApellidoPaterno, " ", loEmpleado.ApellidoMaterno)
            dgvCapacitacion.DataSource = New ExamenMedico(0, txt_numero.Text, 0, 0, Now(), Now()).CargarListado(txt_numero.Text)
        End If
    End Sub


    Private Sub Buscar_CAP_Click(sender As Object, e As EventArgs) Handles buscar_CAP.Click
        Llenar_buscador(BuscarPor.Capacitacion)
        Dim Capacitacion As Capacitacion = CType(Resultado, Capacitacion)
        If Capacitacion IsNot Nothing Then
            txtCapNumero.Text = Capacitacion.ID.ToString()
            txtCapName.Text = Capacitacion.Codigo
        End If
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        Dim CapacitacionDeEmpleado As New CapacitacionDeEmpleado(0, txtCapNumero.Text, txt_numero.Text, TXT_FECHA.Value, TXT_commen.Text)
        If CapacitacionDeEmpleado.Registrar(dgvCapacitacion.DataSource) Then
            dgvCapacitacion.Refresh()
            txtCapNumero.Text = ""
            txtCapName.Text = ""
            TXT_FECHA.ResetText()
            TXT_commen.Text = ""
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txt_numero.Text = ""
        CAP.Text = ""
        txtCapNumero.Text = ""
        TXT_FECHA.ResetText()
        TXT_commen.Text = ""
        dgvCapacitacion.DataSource = Nothing
    End Sub

    Private Sub DgvCapacitacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCapacitacion.CellClick
        If e.ColumnIndex = 0 Then
            If MessageBox.Show("Esta a punto de eliminar una capacitación de este usuario, ¿Esta seguro que desea eliminar esta capacitación?",
                               "Eliminar capacitación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim Vista As CapacitacionDeEmpleado.Vista = CType(dgvCapacitacion.CurrentRow.DataBoundItem, CapacitacionDeEmpleado.Vista)
                Dim CapacitacionDeEmpleado As New CapacitacionDeEmpleado(Vista.ID, 0, Vista.Empleado, Vista.Fecha, Vista.Comentario)
                If CapacitacionDeEmpleado.Eliminar(dgvCapacitacion.DataSource) Then
                    dgvCapacitacion.Refresh()
                End If
            End If
        End If
    End Sub


End Class