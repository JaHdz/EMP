Imports AdminEmpleados.ValeDeEquipo

Public Class frmPopUpValeDeEquipo
    Public Resultado As Object
    Private Empleado As Empleado
    Private Encabezado As ValeDeEquipoEncabezado
    Private Vale As ValeDeEquipo

    Public Sub Llenar_buscador(tipo As String)
        Dim popup As New frmPopUpCatalogo(tipo, True, dgvEquipoAsignado.DataSource)
        Dim dialogresult As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Public Sub New(pEmpleado As Integer)
        InitializeComponent()
        Empleado = New Empleado().Buscar(pEmpleado)
        CrearVale()
    End Sub

    Private Sub CrearVale()
        With Empleado
            lblEmpleado.Text = String.Concat(lblEmpleado.Text, " (", String.Format("{0:D4}", .ID), ") ", .NombreCompleto)
            Vale = New ValeDeEquipo(Empleado.ID)
        End With
    End Sub

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        Llenar_buscador(BuscarPor.Equipo)
        Dim Equipo As Equipo.Vista = CType(Resultado, Equipo.Vista)
        If Equipo IsNot Nothing Then
            Dim itemCount = dgvEquipoAsignado.Rows.Count() + 1
            Dim NuevoDetalle As New ValeDeEquipoDetalle(itemCount, 0, Equipo.ID, Today, FechaMinima)
            NuevoDetalle.Agregar(dgvEquipoAsignado.DataSource)
            dgvEquipoAsignado.Refresh()
        End If
    End Sub

    Private Sub Btn_acep_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
        Dim llst As List(Of ValeDeEquipoDetalle) = dgvEquipoAsignado.DataSource
        If llst.Count > 0 Then
            Vale.Detalle = llst
            If Vale.Registrar() Then
                Resultado = True
                Close()
            End If
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Resultado = False
        Close()
    End Sub

    Private Sub dgvEquipoAsignado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipoAsignado.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim Equipo = CType(dgvEquipoAsignado.CurrentRow.DataBoundItem, ValeDeEquipoDetalle)
            If Equipo.Eliminar(dgvEquipoAsignado.DataSource) Then
                dgvEquipoAsignado.Refresh()
            End If
        End If
    End Sub
End Class