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
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.PnlDetails = New System.Windows.Forms.Panel()
        Me.RvReports = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PnlHeader.Controls.Add(Me.Lbl_Title)
        Me.PnlHeader.Controls.Add(Me.PictureBox1)
        Me.PnlHeader.Controls.Add(Me.cerrar)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(600, 30)
        Me.PnlHeader.TabIndex = 1
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.White
        Me.Lbl_Title.Location = New System.Drawing.Point(33, 3)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(0, 23)
        Me.Lbl_Title.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdminEmpleados.My.Resources.Resources.EASY_Small
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.Image = Global.AdminEmpleados.My.Resources.Resources.Close_80px
        Me.cerrar.Location = New System.Drawing.Point(571, 3)
        Me.cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(25, 22)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 11
        Me.cerrar.TabStop = False
        '
        'PnlDetails
        '
        Me.PnlDetails.Controls.Add(Me.RvReports)
        Me.PnlDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDetails.Location = New System.Drawing.Point(0, 30)
        Me.PnlDetails.Name = "PnlDetails"
        Me.PnlDetails.Size = New System.Drawing.Size(600, 696)
        Me.PnlDetails.TabIndex = 2
        '
        'RvReports
        '
        Me.RvReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvReports.Location = New System.Drawing.Point(0, 0)
        Me.RvReports.Name = "RvReports"
        Me.RvReports.ServerReport.BearerToken = Nothing
        Me.RvReports.Size = New System.Drawing.Size(600, 696)
        Me.RvReports.TabIndex = 1
        Me.RvReports.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 726)
        Me.Controls.Add(Me.PnlDetails)
        Me.Controls.Add(Me.PnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reportes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents PnlDetails As Panel
    Private WithEvents RvReports As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents cerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_Title As Label
End Class
