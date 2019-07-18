<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPopUpValeDeEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopUpValeDeEquipo))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.btn_acep = New System.Windows.Forms.PictureBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.dgvEquipoAsignado = New System.Windows.Forms.DataGridView()
        Me.btnRemover = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDeVale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRetorno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEmpleadoNombre = New System.Windows.Forms.TextBox()
        Me.txtEmpleadoNumero = New System.Windows.Forms.TextBox()
        Me.lbl_num = New System.Windows.Forms.Label()
        Me.buscar_EN = New System.Windows.Forms.PictureBox()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquipoAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(12, 227)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(0, 13)
        Me.lbFecha.TabIndex = 49
        '
        'lblEmpleado
        '
        Me.lblEmpleado.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lblEmpleado.Location = New System.Drawing.Point(12, 9)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(383, 21)
        Me.lblEmpleado.TabIndex = 76
        Me.lblEmpleado.Text = "EMPLEADO:"
        Me.lblEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvEquipoAsignado
        '
        Me.dgvEquipoAsignado.AllowUserToAddRows = False
        Me.dgvEquipoAsignado.AllowUserToDeleteRows = False
        Me.dgvEquipoAsignado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEquipoAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipoAsignado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnRemover, Me.ID, Me.NumeroDeVale, Me.EquipoID, Me.Equipo, Me.FechaAsignado, Me.FechaRetorno})
        Me.dgvEquipoAsignado.Location = New System.Drawing.Point(16, 76)
        Me.dgvEquipoAsignado.Name = "dgvEquipoAsignado"
        Me.dgvEquipoAsignado.ReadOnly = True
        Me.dgvEquipoAsignado.RowHeadersVisible = False
        Me.dgvEquipoAsignado.Size = New System.Drawing.Size(379, 257)
        Me.dgvEquipoAsignado.TabIndex = 77
        '
        'btnRemover
        '
        Me.btnRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.btnRemover.HeaderText = "Remover"
        Me.btnRemover.Image = Global.AdminEmpleados.My.Resources.Resources.Minus_80px
        Me.btnRemover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.ReadOnly = True
        Me.btnRemover.Width = 56
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'NumeroDeVale
        '
        Me.NumeroDeVale.DataPropertyName = "NumeroDeVale"
        Me.NumeroDeVale.HeaderText = "NumeroDeVale"
        Me.NumeroDeVale.Name = "NumeroDeVale"
        Me.NumeroDeVale.ReadOnly = True
        Me.NumeroDeVale.Visible = False
        '
        'EquipoID
        '
        Me.EquipoID.DataPropertyName = "EquipoID"
        Me.EquipoID.HeaderText = "EquipoID"
        Me.EquipoID.Name = "EquipoID"
        Me.EquipoID.ReadOnly = True
        Me.EquipoID.Visible = False
        '
        'Equipo
        '
        Me.Equipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Equipo.DataPropertyName = "Equipo"
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'FechaAsignado
        '
        Me.FechaAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaAsignado.DataPropertyName = "FechaAsignado"
        Me.FechaAsignado.HeaderText = "Fecha Asignado"
        Me.FechaAsignado.Name = "FechaAsignado"
        Me.FechaAsignado.ReadOnly = True
        '
        'FechaRetorno
        '
        Me.FechaRetorno.DataPropertyName = "FechaRetorno"
        Me.FechaRetorno.HeaderText = "FechaRetorno"
        Me.FechaRetorno.Name = "FechaRetorno"
        Me.FechaRetorno.ReadOnly = True
        Me.FechaRetorno.Visible = False
        '
        'txtEmpleadoNombre
        '
        Me.txtEmpleadoNombre.Enabled = False
        Me.txtEmpleadoNombre.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNombre.Location = New System.Drawing.Point(110, 33)
        Me.txtEmpleadoNombre.Name = "txtEmpleadoNombre"
        Me.txtEmpleadoNombre.Size = New System.Drawing.Size(254, 25)
        Me.txtEmpleadoNombre.TabIndex = 81
        Me.txtEmpleadoNombre.TabStop = False
        '
        'txtEmpleadoNumero
        '
        Me.txtEmpleadoNumero.Enabled = False
        Me.txtEmpleadoNumero.Font = New System.Drawing.Font("Modern No. 20", 12.0!)
        Me.txtEmpleadoNumero.Location = New System.Drawing.Point(94, 33)
        Me.txtEmpleadoNumero.Name = "txtEmpleadoNumero"
        Me.txtEmpleadoNumero.Size = New System.Drawing.Size(10, 25)
        Me.txtEmpleadoNumero.TabIndex = 78
        Me.txtEmpleadoNumero.Visible = False
        '
        'lbl_num
        '
        Me.lbl_num.AutoSize = True
        Me.lbl_num.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.lbl_num.Location = New System.Drawing.Point(12, 35)
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(76, 21)
        Me.lbl_num.TabIndex = 79
        Me.lbl_num.Text = "EQUIPO:"
        '
        'buscar_EN
        '
        Me.buscar_EN.BackgroundImage = CType(resources.GetObject("buscar_EN.BackgroundImage"), System.Drawing.Image)
        Me.buscar_EN.Image = Global.AdminEmpleados.My.Resources.Resources.Search_80px
        Me.buscar_EN.Location = New System.Drawing.Point(370, 33)
        Me.buscar_EN.Name = "buscar_EN"
        Me.buscar_EN.Size = New System.Drawing.Size(25, 25)
        Me.buscar_EN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buscar_EN.TabIndex = 80
        Me.buscar_EN.TabStop = False
        '
        'frmPopUpValeDeEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 405)
        Me.Controls.Add(Me.txtEmpleadoNombre)
        Me.Controls.Add(Me.txtEmpleadoNumero)
        Me.Controls.Add(Me.lbl_num)
        Me.Controls.Add(Me.buscar_EN)
        Me.Controls.Add(Me.dgvEquipoAsignado)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_acep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPopUpValeDeEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPopUpComentario"
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_acep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquipoAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buscar_EN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents btn_acep As PictureBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents dgvEquipoAsignado As DataGridView
    Friend WithEvents txtEmpleadoNombre As TextBox
    Friend WithEvents txtEmpleadoNumero As TextBox
    Friend WithEvents lbl_num As Label
    Friend WithEvents buscar_EN As PictureBox
    Friend WithEvents btnRemover As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDeVale As DataGridViewTextBoxColumn
    Friend WithEvents EquipoID As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
    Friend WithEvents FechaAsignado As DataGridViewTextBoxColumn
    Friend WithEvents FechaRetorno As DataGridViewTextBoxColumn
End Class
