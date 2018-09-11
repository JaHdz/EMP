<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RvReports = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvReports
        '
        Me.RvReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvReports.Location = New System.Drawing.Point(0, 0)
        Me.RvReports.Name = "RvReports"
        Me.RvReports.Size = New System.Drawing.Size(575, 726)
        Me.RvReports.TabIndex = 0
        Me.RvReports.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 726)
        Me.Controls.Add(Me.RvReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents RvReports As Microsoft.Reporting.WinForms.ReportViewer
End Class
