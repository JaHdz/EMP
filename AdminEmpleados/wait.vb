Public Class wait
    Private Sub wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Dock = DockStyle.Fill
        Me.TransparencyKey = System.Drawing.Color.FromArgb(121, 121, 121)
        Threading.Thread.Sleep(500)
        Me.Hide()
    End Sub
End Class