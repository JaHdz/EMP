<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPopUp
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.btn_acep = New System.Windows.Forms.PictureBox()
        Me.txt_codi = New System.Windows.Forms.TextBox()
        Me.dgv_Pop = New System.Windows.Forms.DataGridView()
        Me.Panel8.SuspendLayout()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Pop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Panel8.Controls.Add(Me.btn_buscar)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.btn_salir)
        Me.Panel8.Controls.Add(Me.btn_acep)
        Me.Panel8.Controls.Add(Me.txt_codi)
        Me.Panel8.Controls.Add(Me.dgv_Pop)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(407, 405)
        Me.Panel8.TabIndex = 40
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_buscar.BackgroundImage = Global.AdminEmpleados.My.Resources.Resources.Blue_button
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(286, 16)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(98, 41)
        Me.btn_buscar.TabIndex = 51
        Me.btn_buscar.Text = "Buscar  "
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(349, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "SALIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(277, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "ACEPTAR"
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.AdminEmpleados.My.Resources.Resources.Cancel_80px
        Me.btn_salir.Location = New System.Drawing.Point(348, 339)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(37, 36)
        Me.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_salir.TabIndex = 40
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
        Me.btn_acep.TabIndex = 39
        Me.btn_acep.TabStop = False
        Me.btn_acep.Tag = "ACEPTAR"
        '
        'txt_codi
        '
        Me.txt_codi.Location = New System.Drawing.Point(22, 24)
        Me.txt_codi.Name = "txt_codi"
        Me.txt_codi.Size = New System.Drawing.Size(260, 28)
        Me.txt_codi.TabIndex = 37
        '
        'dgv_Pop
        '
        Me.dgv_Pop.AllowUserToAddRows = False
        Me.dgv_Pop.AllowUserToDeleteRows = False
        Me.dgv_Pop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_Pop.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dgv_Pop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_Pop.Location = New System.Drawing.Point(22, 63)
        Me.dgv_Pop.MultiSelect = False
        Me.dgv_Pop.Name = "dgv_Pop"
        Me.dgv_Pop.ReadOnly = True
        Me.dgv_Pop.RowHeadersVisible = False
        Me.dgv_Pop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Pop.Size = New System.Drawing.Size(363, 258)
        Me.dgv_Pop.TabIndex = 36
        '
        'FrmPopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 405)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPopUp"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Pop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents btn_acep As PictureBox
    Friend WithEvents txt_codi As TextBox
    Friend WithEvents dgv_Pop As DataGridView
    Private WithEvents btn_buscar As Button
End Class
