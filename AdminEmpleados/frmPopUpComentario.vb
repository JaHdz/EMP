Public Class frmPopUpComentario
    Public Result As Object

    Private Sub Btn_acep_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
        If Not String.IsNullOrWhiteSpace(txtComentario.Text) Then
            Result = txtComentario.Text
            Close()
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Result = String.Empty
        Close()
    End Sub
End Class