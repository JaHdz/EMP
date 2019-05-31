Public Class frmPopUpCatalogo
    Private Buscar As Integer
    Dim FiltrarInactivos As Boolean
    Dim OtroFiltro As Object
    Public Result As Object
    Dim ListadoDeObjetos As IEnumerable(Of Object)
    Dim ListadoFiltrado As IEnumerable(Of Object)

    Public Sub New(ObjetoABuscar As Integer, Optional Filtrar As Boolean = False, Optional Otro As Object = Nothing)
        InitializeComponent()
        Buscar = ObjetoABuscar
        FiltrarInactivos = Filtrar
        OtroFiltro = Otro
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Btn_acep_Click(sender As Object, e As EventArgs) Handles btn_acep.Click
        If (dgv_Pop.RowCount > 0) Then
            If (dgv_Pop.CurrentRow.Index >= 0) Then
                Select Case Buscar
                    Case BuscarPor.Empleado
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Empleado.Vista)
                    Case BuscarPor.Departamento
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Departamento)
                    Case BuscarPor.Evaluacion
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Evaluacion)
                    Case BuscarPor.Equipo
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Equipo.Vista)
                    Case BuscarPor.Entidad
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Entidad)
                    Case BuscarPor.Ciudad
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Ciudad)
                    Case BuscarPor.Puesto
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Puesto)
                    Case BuscarPor.Supervisor
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Supervisor)
                    Case BuscarPor.TipoDeEmpleado
                        Result = CType(dgv_Pop.CurrentRow.DataBoundItem, Tipo)
                End Select
                Close()
            End If
        End If
    End Sub

    Private Sub FrmPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Buscar
            Case BuscarPor.Empleado
                ListadoDeObjetos = New Empleado().CargarListado(FiltrarInactivos)
            Case BuscarPor.Departamento
                ListadoDeObjetos = New Departamento().CargarListado(FiltrarInactivos)
            Case BuscarPor.Evaluacion
                ListadoDeObjetos = New Evaluacion().CargarListado(FiltrarInactivos)
            Case BuscarPor.Equipo
                Dim Equipos = New Equipo().CargarListado(FiltrarInactivos)
                Dim Asignados = New EquipoAsignado().CargarListado().FindAll(Function(X) X.Regreso = False)
                ListadoDeObjetos = Equipos.Where(Function(a) Not Asignados.Any(Function(b) b.EquipoID = a.ID)).ToList()
            Case BuscarPor.Entidad
                ListadoDeObjetos = Entidades
            Case BuscarPor.Ciudad
                Dim Entidad As Integer = OtroFiltro
                ListadoDeObjetos = Ciudades.FindAll(Function(x) x.Estado = Entidad)
            Case BuscarPor.Puesto
                ListadoDeObjetos = New Puesto().CargarListado(FiltrarInactivos)
            Case BuscarPor.Supervisor
                ListadoDeObjetos = New Supervisor().CargarListado(FiltrarInactivos)
            Case BuscarPor.TipoDeEmpleado
                ListadoDeObjetos = New Tipo().CargarListado(FiltrarInactivos)
        End Select
        dgv_Pop.DataSource = ListadoDeObjetos
    End Sub

    Private Sub FiltrarListado()
        If ListadoDeObjetos.Count > 0 Then
            Select Case Buscar
                Case BuscarPor.Empleado
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Empleado.Vista)).FindAll(Function(X) X.ID Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.NombreCompleto.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Departamento
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Departamento)).FindAll(Function(X) X.ID Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Codigo.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Evaluacion
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Evaluacion)).FindAll(Function(X) X.ID Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Codigo.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Equipo
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Equipo)).FindAll(Function(X) X.ID Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Nombre.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Entidad
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Entidad)).FindAll(Function(X) X.Abreviacion Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Nombre.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Ciudad
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Ciudad)).FindAll(Function(X) X.Codigo Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Nombre.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Puesto
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Puesto)).FindAll(Function(X) X.Nombre Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Descripcion.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.Supervisor
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Supervisor)).FindAll(Function(X) X.Empleado Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Nombre.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
                Case BuscarPor.TipoDeEmpleado
                    ListadoFiltrado = CType(ListadoDeObjetos, List(Of Tipo)).FindAll(Function(X) X.Codigo Like "*" + txt_codi.Text.ToUpper + "*" OrElse X.Descripcion.ToUpper() Like "*" + txt_codi.Text.ToUpper + "*")
            End Select
            dgv_Pop.DataSource = ListadoFiltrado
        Else
            MessageBox.Show("No se puede filtrar ya que no existen registros")
        End If
    End Sub

    Private Sub FrmPopUp_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then My.Computer.Keyboard.SendKeys("{tab}")
    End Sub

    Private Sub dgv_Pop_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pop.CellContentDoubleClick
        If dgv_Pop.Rows.Count > 0 Then
            Btn_acep_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_codi_TextChanged(sender As Object, e As EventArgs) Handles txt_codi.TextChanged
        FiltrarListado()
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        FiltrarListado()
    End Sub
End Class