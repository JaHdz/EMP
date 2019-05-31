Public Class frmAdministration
    Dim Resultado As Object
    Dim Usuario As Usuario
    Dim Capacitacion As Capacitacion
    Dim Departamento As Departamento
    Dim Equipo As Equipo
    Dim Evaluacion As Evaluacion
    Dim Puesto As Puesto
    Dim Supervisor As Supervisor
    Dim Tipo As Tipo

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = New Usuario().CargarListado(True)
        DGV_CAT.DataSource = New Capacitacion().CargarListado(True)
        dgv_depto.DataSource = New Departamento().CargarListado(True)
        dgv_eq.DataSource = New Equipo().CargarListado(True)
        dgv_eval.DataSource = New Evaluacion().CargarListado(True)
        dgv_Puesto.DataSource = New Puesto().CargarListado(True)
        dgv_super.DataSource = New Supervisor().CargarListado(True)
        dgv_te.DataSource = New Tipo().CargarListado(True)
    End Sub

    Private Sub LlenarBuscador(tipo As String)
        Dim popup As New frmPopUpCatalogo(tipo)
        Dim PopUpDialog As DialogResult = popup.ShowDialog()
        Resultado = popup.Result
        popup.Close()
    End Sub

    Private Sub Limpiar(sender As Object, e As EventArgs) Handles PictureBox2.Click, pb_cancelTE.Click, CANCEL_EVAL.Click, cancel_eq.Click, cancel_code.Click,
                                                                  CANCEL.Click, btn_cancelsuper.Click, btn_CancelPuesto.Click

        'Usuarios
        dgvUsuarios.Refresh()
        Usuario = Nothing
        txt_pass.Text = ""
        txt_pass2.Text = ""
        txt_numero.Text = ""
        txt_user.Text = ""
        txtEmpleado.Text = ""
    End Sub



#Region "Usuarios"
    Private Sub DgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.ColumnIndex = 0 Then
            If MessageBox.Show("Esta a punto de eliminar un usuario, ¿Esta seguro que desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Usuario = CType(dgvUsuarios.CurrentRow.DataBoundItem, Usuario)
                If Usuario.Eliminar(dgvUsuarios.DataSource) Then
                    Limpiar(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If SAVE.Tag = Operacion.Registrar.ToString() Then
            Usuario = New Usuario(0, txt_numero.Text, txt_user.Text, Encrypt(txt_pass.Text), 1, 1, "", "", Encrypt(txt_pass2.Text))
            If Usuario.Registrar(dgvUsuarios.DataSource) Then
                Limpiar(sender, e)
                txt_numero.Focus()
            End If
        Else
            With Usuario
                Usuario = New Usuario(.ID, .NumeroDeEmpleado, .UserName, Encrypt(txt_pass.Text), .Activo, .Acceso, .Nombre, .ResetKey, Encrypt(txt_pass2.Text))
                If Usuario.Actualizar(dgvUsuarios.DataSource) Then
                    Usuario = Nothing
                    Limpiar(sender, e)
                    txt_user.Enabled = True
                    txt_numero.Focus()
                End If
            End With
        End If
    End Sub

    Private Sub Buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        LlenarBuscador(BuscarPor.Empleado)
        Dim Empleado As Empleado.Vista = CType(Resultado, Empleado.Vista)
        If Empleado IsNot Nothing Then
            txt_numero.Text = Empleado.ID.ToString()
            txtEmpleado.Text = String.Concat(Empleado.Nombre, " ", Empleado.ApellidoPaterno, " ", Empleado.ApellidoMaterno)
            Usuario = Empleado.Usuario
            If Usuario IsNot Nothing Then
                SAVE.Tag = Operacion.Actualizar.ToString()
                SAVE.Image = My.Resources.Updates_80
                txt_user.Enabled = False
                txt_user.Text = Usuario.UserName
                txt_pass.Text = Usuario.Password
                txt_pass2.Text = Usuario.Password
            Else
                SAVE.Tag = Operacion.Registrar.ToString()
                SAVE.Image = My.Resources.Save_80px
                txt_user.Enabled = True
                Limpiar(sender, e)
                txt_user.Focus()
            End If
        Else
            SAVE.Tag = Operacion.Registrar.ToString()
            SAVE.Image = My.Resources.Save_80px
            Usuario = Nothing
            Limpiar(sender, e)
        End If
    End Sub

#End Region

#Region "Capacitaciones"
    Private Sub PbGuardarCapacitaciones_Click(sender As Object, e As EventArgs) Handles PbGuardarCapacitaciones.Click
        Dim Capacitacion As New Capacitacion(0, TXT_CAPCODIGO.Text, TXT_CAP_DESC.Text, 1)
        If Capacitacion.Registrar(DGV_CAT.DataSource) Then
            Capacitacion = Nothing
            TXT_CAPCODIGO.Text = ""
            TXT_CAP_DESC.Text = ""
            TXT_CAPCODIGO.Focus()
        End If
    End Sub

    Private Sub DGV_CAT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CAT.CellClick
        If e.ColumnIndex = 0 Then
            Capacitacion = CType(DGV_CAT.CurrentRow.DataBoundItem, Capacitacion)
            If Capacitacion.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja una capacitación, ¿Esta seguro que desea continuar?", "Desactivar capacitación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Capacitacion.EstaActivo = False
                    If Capacitacion.Actualizar(DGV_CAT.DataSource) Then
                        DGV_CAT.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Departamentos"
    Private Sub Save_cod_Click(sender As Object, e As EventArgs) Handles save_cod.Click
        Dim Departamento As New Departamento(0, txt_depcod.Text, txt_coddes.Text, 1)
        If Departamento.Registrar(dgv_depto.DataSource) Then
            dgv_depto.Refresh()
            txt_depcod.Text = ""
            txt_coddes.Text = ""
            txt_depcod.Focus()
        End If
    End Sub

    Private Sub Dgv_depto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_depto.CellClick
        If e.ColumnIndex = 0 Then
            Departamento = CType(dgv_depto.CurrentRow.DataBoundItem, Departamento)
            If Departamento.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja un departamento, ¿Esta seguro que desea continuar?", "Desactivar departamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Departamento.EstaActivo = False
                    If Departamento.Actualizar(dgv_depto.DataSource) Then
                        DGV_CAT.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Equipo"
    Private Sub PbSearchDpto_Click(sender As Object, e As EventArgs) Handles pbSearchDpto.Click
        LlenarBuscador(BuscarPor.Departamento)
        Dim Departamento As Departamento = CType(Resultado, Departamento)
        If Departamento IsNot Nothing Then
            txtDeptoID.Text = Departamento.ID.ToString()
            txtDpto.Text = Departamento.Codigo
        End If
    End Sub

    Private Sub Save_eq_Click(sender As Object, e As EventArgs) Handles save_eq.Click
        Dim Equipo As New Equipo(0, txt_eqcod.Text, txt_eqdesc.Text, txt_eqcost.Text, 1, txtDeptoID.Text)
        If Equipo.Registrar(dgv_eq.DataSource) Then
            dgv_eq.Refresh()
            txtDeptoID.Text = ""
            txtDpto.Text = ""
            txt_eqdesc.Text = ""
            txt_eqcost.Text = ""
            txt_eqcod.Text = ""
            txt_eqcod.Focus()
        End If
    End Sub

    Private Sub dgv_eq_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eq.CellClick
        If e.ColumnIndex = 0 Then
            Equipo = CType(dgv_eq.CurrentRow.DataBoundItem, Equipo)
            If Equipo.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja un equipo, ¿Esta seguro que desea continuar?", "Desactivar equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Equipo.EstaActivo = False
                    If Equipo.Actualizar(dgv_eq.DataSource) Then
                        dgv_eq.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Txt_eqcost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_eqcost.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar)
    End Sub

#End Region

#Region "Evaluaciones"
    Private Sub SAVE_EVAL_Click(sender As Object, e As EventArgs) Handles SAVE_EVAL.Click
        Dim Evaluacion As New Evaluacion(0, txt_evalcod.Text, txt_eval_des.Text, 1)
        If Evaluacion.Registrar(dgv_eval.DataSource) Then
            dgv_eval.Refresh()
            txt_evalcod.Text = ""
            txt_eval_des.Text = ""
            txt_evalcod.Focus()
        End If
    End Sub

    Private Sub Dgv_eval_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_eval.CellClick
        If e.ColumnIndex = 0 Then
            Evaluacion = CType(dgv_eval.CurrentRow.DataBoundItem, Evaluacion)
            If Evaluacion.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja una evaluación, ¿Esta seguro que desea continuar?", "Desactivar evaluación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Evaluacion.EstaActivo = False
                    If Evaluacion.Actualizar(dgv_eval.DataSource) Then
                        dgv_eq.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Puestos"
    Private Sub Btn_SavePuesto_Click(sender As Object, e As EventArgs) Handles btn_SavePuesto.Click
        Dim Puesto As New Puesto(0, txt_PuestoNombre.Text, txt_PuestoDescripcion.Text, cb_PuestoRiesgo.Checked, 1)
        If Puesto.Registrar(dgv_Puesto.DataSource) Then
            dgv_Puesto.Refresh()
            txt_PuestoDescripcion.Text = ""
            txt_PuestoNombre.Text = ""
            txt_PuestoNombre.Focus()
        End If
    End Sub

    Private Sub Dgv_Puesto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Puesto.CellClick
        If e.ColumnIndex = 0 Then
            Puesto = CType(dgv_Puesto.CurrentRow.DataBoundItem, Puesto)
            If Puesto.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de desactivar un puesto, ¿Esta seguro que desea continuar?", "Desactivar Puesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Puesto.EstaActivo = False
                    If Puesto.Actualizar(dgv_Puesto.DataSource) Then
                        dgvUsuarios.Refresh()
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "Supervisor"
    Private Sub BUSCAR_EMP_SUPER_Click(sender As Object, e As EventArgs) Handles BUSCAR_EMP_SUPER.Click
        LlenarBuscador(BuscarPor.Empleado)
        Dim Empleado As Empleado.Vista = CType(Resultado, Empleado.Vista)
        If Empleado IsNot Nothing Then
            TXT_EMP_SUPER.Text = Empleado.ID.ToString()
            TxtEmpSuper.Text = String.Concat(Empleado.Nombre, " ", Empleado.ApellidoPaterno, " ", Empleado.ApellidoMaterno)
        End If
    End Sub

    Private Sub Btn_savesuper_Click(sender As Object, e As EventArgs) Handles btn_savesuper.Click
        Dim Supervisor As Supervisor = New Supervisor(0, TXT_EMP_SUPER.Text, 1, TxtEmpSuper.Text)
        If Supervisor.Registrar(dgv_super.DataSource) Then
            dgv_super.Refresh()
            TXT_EMP_SUPER.Text = ""
            TxtEmpSuper.Text = ""
        End If
    End Sub

    Private Sub Dgv_super_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_super.CellClick
        If e.ColumnIndex = 0 Then
            Supervisor = CType(dgv_super.CurrentRow.DataBoundItem, Supervisor)
            If Supervisor.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja un supervisor, ¿Esta seguro que desea continuar?", "Desactivar supervisor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Supervisor.EstaActivo = False
                    If Supervisor.Actualizar(dgv_super.DataSource) Then
                        dgvUsuarios.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Tipos de empleados"
    Private Sub Pb_saveTE_Click(sender As Object, e As EventArgs) Handles pb_saveTE.Click
        Tipo = New Tipo(0, txt_codigoTE.Text, txt_DescTE.Text, 1)
        If Tipo.Registrar(dgv_te.DataSource) Then
            dgv_te.Refresh()
            txt_codigoTE.Text = ""
            txt_DescTE.Text = ""
            txt_codigoTE.Focus()
        End If
    End Sub

    Private Sub dgv_te_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_te.CellClick
        If e.ColumnIndex = 0 Then
            Tipo = CType(dgv_te.CurrentRow.DataBoundItem, Tipo)
            If Tipo.EstaActivo = True Then
                If MessageBox.Show("Esta a punto de dar de baja un tipo de empleado, ¿Esta seguro que desea continuar?", "Desactivar tipo de empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Tipo.EstaActivo = False
                    If Tipo.Actualizar(dgv_te.DataSource) Then
                        dgvUsuarios.Refresh()
                    End If
                End If
            End If
        End If
    End Sub
#End Region





End Class