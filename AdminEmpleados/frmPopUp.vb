Public Class frmPopUp
    Dim tipo As String
    Public Variable As String
    Public Variable2 As String
    Dim dt As New DataTable

    Sub New(tipo2 As String)
        InitializeComponent()
        tipo = tipo2
    End Sub

    Private Sub Btn_esSAVE_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim bs As New BindingSource
        bs.DataSource = dt
        bs.Filter = dt.Columns(1).ColumnName + " like '" + txt_codi.Text + "%'"
        dgv_Pop.DataSource = bs
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_acep_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
        If (dgv_Pop.RowCount = 0) Then
        Else
            Me.Close()
            If (dgv_Pop.CurrentRow.Index < 0) Then
            Else
                Variable = dgv_Pop.Item(0, dgv_Pop.CurrentRow.Index).Value
                Variable2 = dgv_Pop.Item(1, dgv_Pop.CurrentRow.Index).Value
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmPopUp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then My.Computer.Keyboard.SendKeys("{tab}")
    End Sub

    Private Sub dgv_Pop_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pop.CellContentDoubleClick
        If dgv_Pop.Rows.Count > 0 Then
            Btn_acep_Click(sender, e)
        End If

    End Sub

    Private Sub frmPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objcon As New Consultas()
        dt = objcon.Catalogo(tipo, txt_codi.Text)
        dgv_Pop.DataSource = dt
    End Sub

    'Private Sub dgv_Pop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pop.CellContentClick
    '    If dgv_Pop.Rows.Count > 0 Then
    '        Btn_acep_Click(sender, e)
    '    End If
    'End Sub
End Class