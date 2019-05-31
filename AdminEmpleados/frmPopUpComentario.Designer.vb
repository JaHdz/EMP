<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPopUpComentario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.btn_acep = New System.Windows.Forms.PictureBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(345, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "SALIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(272, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ACEPTAR"
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_salir.Location = New System.Drawing.Point(348, 339)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(37, 36)
        Me.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_salir.TabIndex = 44
        Me.btn_salir.TabStop = False
        Me.btn_salir.Tag = "CANCELAR"
        '
        'btn_acep
        '
        Me.btn_acep.Image = Global.AdminEmpleados.My.Resources.Resources.Checked_80px
        Me.btn_acep.Location = New System.Drawing.Point(286, 339)
        Me.btn_acep.Name = "btn_acep"
        Me.btn_acep.Size = New System.Drawing.Size(37, 36)
        Me.btn_acep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_acep.TabIndex = 43
        Me.btn_acep.TabStop = False
        Me.btn_acep.Tag = "ACEPTAR"
        '
        'txtComentario
        '
        Me.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComentario.Location = New System.Drawing.Point(13, 70)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(382, 196)
        Me.txtComentario.TabIndex = 48
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(12, 227)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(0, 13)
        Me.lbFecha.TabIndex = 49
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(383, 42)
        Me.lblTitulo.TabIndex = 50
        Me.lblTitulo.Text = "Escribe una pequeña descripción del estado en el que recibes el equipo."
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPopUpComentario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 405)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_acep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPopUpComentario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPopUpComentario"
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents btn_acep As PictureBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents lblTitulo As Label
End Class
