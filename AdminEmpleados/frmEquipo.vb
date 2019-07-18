Imports AdminEmpleados.ValeDeEquipo

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

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Empleado)
        loEmpleado = CType(Resultado, Empleado.Vista)
        If loEmpleado IsNot Nothing Then
            txtEmpleadoNumero.Text = loEmpleado.ID.ToString()
            txtEmpleadoNombre.Text = String.Concat(loEmpleado.Nombre, " ", loEmpleado.ApellidoPaterno, " ", loEmpleado.ApellidoMaterno)
            lblAsignar.Visible = True
            btnAsignarEquipo.Visible = True

            Dim ListaDeEncabezados As New List(Of ValeDeEquipoEncabezado)

            For Each Vale In New ValeDeEquipo(loEmpleado.ID).CargarListado(True)
                With Vale.Encabezado
                    ListaDeEncabezados.Add(New ValeDeEquipoEncabezado(.ID, .EmpleadoID, .AsignadoPorID, .Activo))
                End With
            Next
            dgvEquipoEmp.DataSource = ListaDeEncabezados
        Else
            lblAsignar.Visible = True
            btnAsignarEquipo.Visible = True
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        txtEmpleadoNumero.Text = ""
        txtEmpleadoNombre.Text = ""
        lblAsignar.Visible = False
        btnAsignarEquipo.Visible = False
        loEmpleado = Nothing
        dgvEquipoEmp.DataSource = Nothing
    End Sub

    Private Sub DgvEquipoEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipoEmp.CellClick
        Select Case e.ColumnIndex
            Case 0
                Dim Vale As New ValeDeEquipo With {.Encabezado = CType(dgvEquipoEmp.CurrentRow.DataBoundItem, ValeDeEquipoEncabezado)}
                Vale.Buscar()
                Dim Parametros As New Dictionary(Of String, Object) From {{"ValeDeEquipo", Vale}}
                Dim Reporte As New FrmReportes(Parametros, ReportOptions.AssignedEquipment)
                Reporte.ShowDialog()
        End Select
    End Sub

    Private Sub Pb_Report_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAsignarEquipo_Click(sender As Object, e As EventArgs) Handles btnAsignarEquipo.Click
        Dim popup As frmPopUpValeDeEquipo = New frmPopUpValeDeEquipo(txtEmpleadoNumero.Text)
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Resultado
        popup.Close()
        If Resultado = True Then
            Dim ListaDeEncabezados As New List(Of ValeDeEquipoEncabezado)
            For Each Vale In New ValeDeEquipo(loEmpleado.ID).CargarListado()
                ListaDeEncabezados.Add(Vale.Encabezado)
            Next
            dgvEquipoEmp.DataSource = ListaDeEncabezados
        End If
    End Sub
End Class