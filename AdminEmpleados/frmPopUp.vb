Public Class frmPopUp
    Dim tipo As String
    Public Variable As String
    Public Variable2 As String

    Sub New(tipo2 As String)
        InitializeComponent()
        tipo = tipo2
    End Sub

    Private Sub btn_esSAVE_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim objcon As New Consultas()
        dgv_Pop.DataSource = objcon.Catalogo(tipo, txt_codi.Text)
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
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
End Class