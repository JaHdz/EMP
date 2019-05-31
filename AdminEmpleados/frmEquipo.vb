Public Class FrmEquipo
    Dim Resultado As Object
    Dim loEmpleado As New Empleado.Vista()
    Dim loEquipoAsignado As New List(Of EquipoAsignado)
    Public Sub Llenar_buscador(tipo As String)
        Dim popup As New frmPopUpCatalogo(tipo)
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Public Sub ComentarioPopUp()
        Dim popup As New frmPopUpComentario()
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Empleado)
        dim loEmpleado = CType(Resultado, Empleado.Vista)
        If loEmpleado IsNot Nothing Then
            txtEmpleadoNumero.Text = loEmpleado.ID.ToString()
            txtEmpleadoNombre.Text = String.Concat(loEmpleado.Nombre, " ", loEmpleado.ApellidoPaterno, " ", loEmpleado.ApellidoMaterno)
            dgvEquipoEmp.DataSource = New EquipoAsignado().CargarListado(txtEmpleadoNumero.Text, True)
            pb_Report.Visible = True
        End If
    End Sub

    Private Sub Buscar_eq_Click(sender As Object, e As EventArgs) Handles buscar_eq.Click
        Llenar_buscador(BuscarPor.Equipo)
        Dim Equipo As Equipo.Vista = CType(Resultado, Equipo.Vista)
        If Equipo IsNot Nothing Then
            txtEquipoNumero.Text = Equipo.ID.ToString()
            txtEquipoNombre.Text = Equipo.Nombre + " : " + Equipo.Descripcion
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        Dim EquipoAsignado As New EquipoAsignado(0, txtEquipoNumero.Text, txtEmpleadoNumero.Text, TXT_FECHA.Value, False, "1753-01-01", TXT_commen.Text,
                                                 UsuarioLogeado.ID)
        If EquipoAsignado.Registrar(dgvEquipoEmp.DataSource) Then
            dgvEquipoEmp.Refresh()
            txtEquipoNombre.Text = ""
            txtEquipoNumero.Text = ""
            TXT_commen.Text = ""
            TXT_FECHA.ResetText()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txtEmpleadoNumero.Text = ""
        txtEmpleadoNombre.Text = ""
        TXT_FECHA.ResetText()
        txtEquipoNumero.Text = ""
        txtEquipoNombre.Text = ""
        TXT_commen.Text = ""
        loEmpleado = Nothing
        pb_Report.Visible = False
        dgvEquipoEmp.DataSource = Nothing
    End Sub

    Private Sub DgvEquipoEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipoEmp.CellClick
        If e.ColumnIndex = 0 Then
            If MessageBox.Show("Esta a punto de dar de baja una capacitación, ¿Esta seguro que desea continuar?", "Desactivar capacitación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim Vista As EquipoAsignado.Vista = CType(dgvEquipoEmp.CurrentRow.DataBoundItem, EquipoAsignado.Vista)
                Dim EquipoAsignado = New EquipoAsignado(Vista.ID, Vista.EquipoID, Vista.Empleado, Vista.Fecha, True, Now(), Vista.Comentario, UsuarioLogeado.ID)
                ComentarioPopUp()
                Dim loResultado = CType(Resultado, String)
                If Not String.IsNullOrWhiteSpace(loResultado) Then
                    If EquipoAsignado.Actualizar(dgvEquipoEmp.DataSource) Then
                        dgvEquipoEmp.Refresh()
                        Dim Observacion As New EquipoObservacion(0, Vista.Empleado, loResultado, Today())
                        Observacion.Registrar()
                    End If
                Else
                    MessageBox.Show("Se debe escribir un comentario con las observaciones del equipo retornado", "Observaciones", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub Pb_Report_Click(sender As Object, e As EventArgs) Handles pb_Report.Click
        Dim Parametros As New Dictionary(Of String, Object) From {{"Empleado", loEmpleado}, {"Equipo", New EquipoAsignado().CargarListado(loEmpleado.ID, True)}}
        Dim Reporte As New FrmReportes(Parametros, ReportOptions.AssignedEquipment)
        Reporte.ShowDialog()
    End Sub
End Class