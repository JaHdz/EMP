Public Class FrmPopUp
    Dim tipo As String
    Dim FiltrarInactivos As Boolean
    Public Variable As String
    Public Variable2 As String
    Public Result As Object
    Dim dt As New DataTable
    Dim ListadoDeObjetos As IEnumerable(Of Object)
    Dim ListadoFiltrado As IEnumerable(Of Object)
    Sub New(tipo2 As String, Optional Filtrar As Boolean = False)
        InitializeComponent()
        tipo = tipo2
        FiltrarInactivos = Filtrar
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_acep_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
        If (dgv_Pop.RowCount = 0) Then
        Else
            If (dgv_Pop.CurrentRow.Index < 0) Then
            Else
                Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Empleado)
                'Variable = dgv_Pop.Item(0, dgv_Pop.CurrentRow.Index).Value
                'If tipo = "EMPLEADOS" Then
                '    Variable2 = dgv_Pop.Item(1, dgv_Pop.CurrentRow.Index).Value + " " + dgv_Pop.Item(2, dgv_Pop.CurrentRow.Index).Value + " " + dgv_Pop.Item(3, dgv_Pop.CurrentRow.Index).Value
                'Else
                '    Variable2 = dgv_Pop.Item(1, dgv_Pop.CurrentRow.Index).Value
                'End If

                Me.Close()
            End If
        End If
    End Sub

    Private Sub FrmPopUp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then My.Computer.Keyboard.SendKeys("{tab}")
    End Sub

    Private Sub dgv_Pop_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pop.CellContentDoubleClick
        If dgv_Pop.Rows.Count > 0 Then
            Btn_acep_Click(sender, e)
        End If
    End Sub

    Private Sub FrmPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case tipo
            Case "EMP"
                ListadoDeObjetos = New Empleado().CargarListado(FiltrarInactivos)
        End Select
        dgv_Pop.DataSource = ListadoDeObjetos
    End Sub

    Private Sub FiltrarListado()
        If ListadoDeObjetos.Count > 0 Then
            Select Case tipo
                Case "EMP"
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Empleado)).FindAll(Function(X) X.ID Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.NombreCompleto.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
            End Select
            dgv_Pop.DataSource = ListadoFiltrado
        Else
            MessageBox.Show("No se puede filtrar ya que no existen registros")
        End If
    End Sub

    Private Sub Txt_codi_TextChanged(sender As Object, e As EventArgs) Handles txt_codi.TextChanged
        FiltrarListado()
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        FiltrarListado()
    End Sub
End Class