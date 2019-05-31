Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class Empleado
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Nombre As String = String.Empty
    Public Property ApellidoPaterno As String = String.Empty
    Public Property ApellidoMaterno As String = String.Empty
    Public Property Domicilio As String = String.Empty
    Public Property Colonia As String = String.Empty
    Public Property CiudadEstado As String = String.Empty
    Public Property CodigoPostal As String = String.Empty
    Public Property Celular As String = String.Empty
    Public Property Telefono As String = String.Empty
    Public Property EstadoCivil As String = String.Empty
    Public Property Nacionalidad As String = String.Empty
    Public Property CiudadNatal As String = String.Empty
    Public Property EntidadNatal As String = String.Empty
    Public Property Salario As New Decimal
    Public Property NivelEducativo As String = String.Empty
    Public Property Email As String = String.Empty
    Public Property FechaDeNacimiento As Date = DateTimePicker.MinimumDateTime
    Public Property RFC As String = String.Empty
    Public Property NSS As String = String.Empty
    Public Property Sexo As String = String.Empty
    Public Property FechaDeAlta As Date = DateTimePicker.MinimumDateTime
    Public Property CURP As String = String.Empty
    Public Property Tipo As New Tipo
    Public Property Supervisor As New Supervisor
    Public Property FechaEfectiva As Date = DateTimePicker.MinimumDateTime
    Public Property Departamento As New Departamento
    Public Property Puesto As New Puesto
    Public Property Usuario As New Usuario
    Public Property EsActivo As Boolean = True
    Public Property EsSupervisor As Boolean = True
    Public Property Foto As Image = Nothing
    Public Property FechaDeBaja As Date = DateTimePicker.MinimumDateTime
    Public Property MotivoDeBaja As String = String.Empty
    Public Property Alerta As Boolean = False
    Public Property NotificarProveedores As Boolean = False
    Public Property NotificarClientes As Boolean = False
    Public Property NotificarSeguridad As Boolean = False
    Public Property NombreCompleto As String = String.Empty

#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal lsNombre As String, ByVal lsApellidoPaterno As String, ByVal lsApellidoMaterno As String, ByVal lsDomicilio As String,
                   ByVal lsColonia As String, ByVal lsCiudadEstado As String, ByVal lsCodigoPostal As String, ByVal lsCelular As String, ByVal lsTelefono As String,
                   ByVal lsEstadoCivil As String, ByVal lsNacionalidad As String, ByVal lsCiudadNatal As String, ByVal lsEntidadNatal As String,
                   ByVal lsSalario As String, ByVal lsNivelEducativo As String, ByVal lsEmail As String, ByVal ldFechaDeNacimiento As Date,
                   ByVal lsRFC As String, ByVal lsNSS As String, ByVal ldFechaDeAlta As Date, ByVal lsSexo As String, ByVal lsCURP As String,
                   ByVal loTipo As Tipo, ByVal loSupervisor As Supervisor, ByVal ldFechaEfectiva As Date, ByVal loDepartamento As Departamento, ByVal loPuesto As Puesto,
                   ByVal loUsuario As Usuario, ByVal lbEsActivo As Boolean, ByVal lbEsSupervisor As Boolean, ByVal liFoto As Image, ByVal ldFechaDeBaja As Date, ByVal lsMotivoDeBaja As String,
                   ByVal lbAlerta As Boolean, ByVal lbNotificarProveedores As Boolean, ByVal lbNotificarSeguridad As Boolean, ByVal lbNotificarClientes As Boolean)
        ID = liID
        Nombre = Trim(lsNombre)
        ApellidoPaterno = Trim(lsApellidoPaterno)
        ApellidoMaterno = Trim(lsApellidoMaterno)
        Domicilio = lsDomicilio
        Colonia = lsColonia
        CiudadEstado = lsCiudadEstado
        CodigoPostal = lsCodigoPostal
        Celular = lsCelular
        Telefono = lsTelefono
        EstadoCivil = lsEstadoCivil
        Nacionalidad = lsNacionalidad
        CiudadNatal = lsCiudadNatal
        EntidadNatal = lsEntidadNatal
        If String.IsNullOrWhiteSpace(lsSalario) Then
            lsSalario = 0
        End If
        Salario = lsSalario
        NivelEducativo = lsNivelEducativo
        Email = lsEmail
        FechaDeNacimiento = ldFechaDeNacimiento
        RFC = lsRFC
        NSS = lsNSS
        FechaDeAlta = ldFechaDeAlta
        Sexo = lsSexo
        CURP = lsCURP
        Tipo = loTipo
        Supervisor = loSupervisor
        FechaEfectiva = ldFechaEfectiva
        Departamento = loDepartamento
        Puesto = loPuesto
        Usuario = loUsuario
        EsActivo = lbEsActivo
        EsSupervisor = lbEsSupervisor
        Foto = liFoto
        FechaDeBaja = ldFechaDeBaja
        MotivoDeBaja = lsMotivoDeBaja
        Alerta = lbAlerta
        NotificarProveedores = lbNotificarProveedores
        NotificarClientes = lbNotificarClientes
        NotificarSeguridad = lbNotificarSeguridad
        NombreCompleto = lsNombre + " " + lsApellidoPaterno + " " + lsApellidoMaterno
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Vista)
        Dim Result As New List(Of Vista)
        Dim listado As New List(Of Empleado)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = Nombre
            cmd.Parameters.Add("@F_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoPaterno
            cmd.Parameters.Add("@M_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoMaterno
            cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar, 50).Value = Domicilio
            cmd.Parameters.Add("@NEIGHBORHOOD", SqlDbType.NVarChar, 20).Value = Colonia
            cmd.Parameters.Add("@CITYSTATE", SqlDbType.NVarChar, 50).Value = CiudadEstado
            cmd.Parameters.Add("@ZIP", SqlDbType.NVarChar, 20).Value = CodigoPostal
            cmd.Parameters.Add("@CELL", SqlDbType.NVarChar, 20).Value = Celular
            cmd.Parameters.Add("@TEL", SqlDbType.NVarChar, 20).Value = Telefono
            cmd.Parameters.Add("@CIVIL", SqlDbType.NVarChar, 20).Value = EstadoCivil
            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
            cmd.Parameters.Add("@CITY", SqlDbType.NVarChar, 20).Value = CiudadNatal
            cmd.Parameters.Add("@STATE", SqlDbType.NVarChar, 10).Value = EntidadNatal
            cmd.Parameters.Add("@WAGE", SqlDbType.Decimal).Value = Salario
            cmd.Parameters.Add("@STUDIES", SqlDbType.NVarChar, 20).Value = NivelEducativo
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 20).Value = Email
            cmd.Parameters.Add("@BIRTHDAY", SqlDbType.DateTime).Value = FechaDeNacimiento
            cmd.Parameters.Add("@RFC", SqlDbType.NVarChar, 20).Value = RFC
            cmd.Parameters.Add("@SSN", SqlDbType.NVarChar, 20).Value = NSS
            cmd.Parameters.Add("@HIRING", SqlDbType.DateTime).Value = FechaDeAlta
            cmd.Parameters.Add("@SEX", SqlDbType.NVarChar, 1).Value = Sexo
            cmd.Parameters.Add("@CURP", SqlDbType.NVarChar, 20).Value = CURP
            cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo.ID
            cmd.Parameters.Add("@SUPERVISOR", SqlDbType.Int).Value = Supervisor.ID
            cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = FechaEfectiva
            cmd.Parameters.Add("@DEPARMENT", SqlDbType.NVarChar, 10).Value = Departamento.ID
            cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar, 10).Value = Puesto.ID
            cmd.Parameters.Add("@USER", SqlDbType.Int).Value = Usuario.ID
            cmd.Parameters.Add("@ACTIVE", SqlDbType.Bit).Value = EsActivo
            cmd.Parameters.Add("@ISSUPERVISOR", SqlDbType.Bit).Value = EsSupervisor
            If Foto Is Nothing OrElse Foto Is My.Resources.photoNobody120 Then
                cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = DBNull.Value
            Else
                cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = ImagenABytes(Foto)
            End If

            cmd.Parameters.Add("@OPTION", SqlDbType.Int).Value = Operacion.BuscarTodos

            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEmpleado As New Empleado(Reader("ID_Emp"), Reader("Emp_Name"), Reader("Emp_APat"), Reader("Emp_AMat"), Reader("Emp_Domicilio"), Reader("Emp_Col"),
                            Reader("Emp_CiudadEstado"), Reader("Emp_CP"), Reader("Emp_Cel"), Reader("Emp_Tel"), Reader("Emp_EdoCivil"), Reader("Emp_Nacionalidad"),
                            Reader("Emp_Ciudad"), Reader("Emp_EN"), Reader("Emp_Salario"), Reader("Emp_NEducativo"), Reader("Emp_Email"), Reader("Emp_FNac"),
                            Reader("Emp_RFC"), Reader("Emp_NSS"), Reader("Emp_FAlta"), Reader("Emp_Sexo"), Reader("Emp_Curp"), New Tipo().Buscar(Reader("Emp_Tipo").ToString()),
                            New Supervisor().Buscar(Reader("Emp_Sup").ToString()), Reader("Emp_FEfectiva"), New Departamento().Buscar(Reader("ID_Depto").ToString()),
                            New Puesto().Buscar(Reader("ID_Puesto").ToString()), New Usuario().Buscar(Reader("ID_User").ToString()), Reader("Emp_Activo"),
                            Reader("EsSupervisor"), CargarImagen(Reader("Img_Emp")), Reader("Fecha_Baja"), Reader("Motivo"), Reader("Alerta"), Reader("NProv"),
                            Reader("NClientes"), Reader("NClientes")
                            )
                    listado.Add(loEmpleado)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = New Vista().GenerarVista(listado.FindAll(Function(X) X.EsActivo = FiltrarInactivos))
        Else
            Result = New Vista().GenerarVista(listado)
        End If
        Return Result
    End Function

    Public Function Registrar() As Boolean
        Dim Result As Boolean = False
        Dim Mensaje As String = String.Empty
        'Verificar campos de Datos Personales
        If Not DatosPersonalesEnBlanco() Then
            'Verificar campos de datos de contratacion
            If Not DatosDeCOntratacionEnBlanco() Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = Nombre
                    cmd.Parameters.Add("@F_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoPaterno
                    cmd.Parameters.Add("@M_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoMaterno
                    cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar, 50).Value = Domicilio
                    cmd.Parameters.Add("@NEIGHBORHOOD", SqlDbType.NVarChar, 20).Value = Colonia
                    cmd.Parameters.Add("@CITYSTATE", SqlDbType.NVarChar, 50).Value = CiudadEstado
                    cmd.Parameters.Add("@ZIP", SqlDbType.NVarChar, 20).Value = CodigoPostal
                    cmd.Parameters.Add("@CELL", SqlDbType.NVarChar, 20).Value = Celular
                    cmd.Parameters.Add("@TEL", SqlDbType.NVarChar, 20).Value = Telefono
                    cmd.Parameters.Add("@CIVIL", SqlDbType.NVarChar, 20).Value = EstadoCivil
                    cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
                    cmd.Parameters.Add("@CITY", SqlDbType.NVarChar, 20).Value = CiudadNatal
                    cmd.Parameters.Add("@STATE", SqlDbType.NVarChar, 10).Value = EntidadNatal
                    cmd.Parameters.Add("@WAGE", SqlDbType.Decimal).Value = Salario
                    cmd.Parameters.Add("@STUDIES", SqlDbType.NVarChar, 20).Value = NivelEducativo
                    cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 20).Value = Email
                    cmd.Parameters.Add("@BIRTHDAY", SqlDbType.DateTime).Value = FechaDeNacimiento
                    cmd.Parameters.Add("@RFC", SqlDbType.NVarChar, 20).Value = RFC
                    cmd.Parameters.Add("@SSN", SqlDbType.NVarChar, 20).Value = NSS
                    cmd.Parameters.Add("@HIRING", SqlDbType.DateTime).Value = FechaDeAlta
                    cmd.Parameters.Add("@SEX", SqlDbType.NVarChar, 1).Value = Sexo
                    cmd.Parameters.Add("@CURP", SqlDbType.NVarChar, 20).Value = CURP
                    cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo.ID
                    cmd.Parameters.Add("@SUPERVISOR", SqlDbType.Int).Value = Supervisor.ID
                    cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = FechaEfectiva
                    cmd.Parameters.Add("@DEPARMENT", SqlDbType.NVarChar, 10).Value = Departamento.ID
                    cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar, 10).Value = Puesto.ID
                    cmd.Parameters.Add("@USER", SqlDbType.Int).Value = Usuario.ID
                    cmd.Parameters.Add("@ACTIVE", SqlDbType.Bit).Value = EsActivo
                    cmd.Parameters.Add("@ISSUPERVISOR", SqlDbType.Bit).Value = EsSupervisor
                    If Foto Is Nothing OrElse Foto Is My.Resources.photoNobody120 Then
                        cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = ImagenABytes(Foto)
                    End If
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True

                End Using
            Else
                Mensaje = "Debe llenar todos los campos en la seccion 'Contratación' para poder continuar"
            End If
        Else
            Mensaje = "Debe llenar todos los campos en la seccion 'Personales' para poder continuar"
        End If
        If Not String.IsNullOrEmpty(Mensaje) Then
            MessageBox.Show(Mensaje, "Error al registrar empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Function Actualizar() As Boolean
        Dim Result As Boolean = False
        Dim Mensaje As String = String.Empty
        'Verificar campos de Datos Personales
        If Not DatosPersonalesEnBlanco() Then
            'Verificar campos de datos de contratacion
            If Not DatosDeCOntratacionEnBlanco() Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = Nombre
                    cmd.Parameters.Add("@F_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoPaterno
                    cmd.Parameters.Add("@M_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoMaterno
                    cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar, 50).Value = Domicilio
                    cmd.Parameters.Add("@NEIGHBORHOOD", SqlDbType.NVarChar, 20).Value = Colonia
                    cmd.Parameters.Add("@CITYSTATE", SqlDbType.NVarChar, 50).Value = CiudadEstado
                    cmd.Parameters.Add("@ZIP", SqlDbType.NVarChar, 20).Value = CodigoPostal
                    cmd.Parameters.Add("@CELL", SqlDbType.NVarChar, 20).Value = Celular
                    cmd.Parameters.Add("@TEL", SqlDbType.NVarChar, 20).Value = Telefono
                    cmd.Parameters.Add("@CIVIL", SqlDbType.NVarChar, 20).Value = EstadoCivil
                    cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
                    cmd.Parameters.Add("@CITY", SqlDbType.NVarChar, 20).Value = CiudadNatal
                    cmd.Parameters.Add("@STATE", SqlDbType.NVarChar, 10).Value = EntidadNatal
                    cmd.Parameters.Add("@WAGE", SqlDbType.Decimal).Value = Salario
                    cmd.Parameters.Add("@STUDIES", SqlDbType.NVarChar, 20).Value = NivelEducativo
                    cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 20).Value = Email
                    cmd.Parameters.Add("@BIRTHDAY", SqlDbType.DateTime).Value = FechaDeNacimiento
                    cmd.Parameters.Add("@RFC", SqlDbType.NVarChar, 20).Value = RFC
                    cmd.Parameters.Add("@SSN", SqlDbType.NVarChar, 20).Value = NSS
                    cmd.Parameters.Add("@HIRING", SqlDbType.DateTime).Value = FechaDeAlta
                    cmd.Parameters.Add("@SEX", SqlDbType.NVarChar, 1).Value = Sexo
                    cmd.Parameters.Add("@CURP", SqlDbType.NVarChar, 20).Value = CURP
                    cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo.ID
                    cmd.Parameters.Add("@SUPERVISOR", SqlDbType.Int).Value = Supervisor.ID
                    cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = FechaEfectiva
                    cmd.Parameters.Add("@DEPARMENT", SqlDbType.NVarChar, 10).Value = Departamento.ID
                    cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar, 10).Value = Puesto.ID
                    cmd.Parameters.Add("@USER", SqlDbType.Int).Value = Usuario.ID
                    cmd.Parameters.Add("@ACTIVE", SqlDbType.Bit).Value = EsActivo
                    cmd.Parameters.Add("@ISSUPERVISOR", SqlDbType.Bit).Value = EsSupervisor
                    If Foto Is Nothing OrElse Foto Is My.Resources.photoNobody120 Then
                        cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = DBNull.Value
                    Else
                        cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = ImagenABytes(Foto)
                    End If
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
                    cmd.ExecuteNonQuery()
                    Result = True

                End Using
            Else
                Mensaje = "Debe llenar todos los campos en la seccion 'Contratación' para poder continuar"
            End If
        Else
            Mensaje = "Debe llenar todos los campos en la seccion 'Personales' para poder continuar"
        End If
        If Not String.IsNullOrEmpty(Mensaje) Then
            MessageBox.Show(Mensaje, "Error al registrar empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Private Function DatosPersonalesEnBlanco() As Boolean
        If Not String.IsNullOrWhiteSpace(Nombre) AndAlso Not String.IsNullOrWhiteSpace(ApellidoPaterno) AndAlso Not String.IsNullOrWhiteSpace(ApellidoMaterno) AndAlso
           Not String.IsNullOrWhiteSpace(Sexo) AndAlso Not String.IsNullOrWhiteSpace(Nacionalidad) AndAlso Not String.IsNullOrWhiteSpace(CiudadNatal) AndAlso
           Not String.IsNullOrWhiteSpace(EntidadNatal) AndAlso Not String.IsNullOrWhiteSpace(CURP) AndAlso Not String.IsNullOrWhiteSpace(RFC) AndAlso
           Not String.IsNullOrWhiteSpace(EstadoCivil) AndAlso Not String.IsNullOrWhiteSpace(NSS) AndAlso Not String.IsNullOrWhiteSpace(Domicilio) AndAlso
           Not String.IsNullOrWhiteSpace(Colonia) AndAlso Not String.IsNullOrWhiteSpace(CiudadEstado) AndAlso Not String.IsNullOrWhiteSpace(CodigoPostal) AndAlso
           Not String.IsNullOrWhiteSpace(NivelEducativo) Then
            Return False
        End If
        Return True
    End Function

    Private Function DatosDeCOntratacionEnBlanco() As Boolean
        If Puesto IsNot Nothing AndAlso Not Departamento IsNot Nothing AndAlso Supervisor IsNot Nothing AndAlso Tipo IsNot Nothing AndAlso Not Salario.Equals(0) Then
            Return False
        End If
        Return True
    End Function

    Public Function CambiarEstatus(Opcion As Operacion) As Boolean
        Dim Result As Boolean = False
        Select Case Opcion
            Case Operacion.Baja
                If MessageBox.Show("¿Esta seguro que dar de baja a este empleado?", "Dar de baja empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Select
                If String.IsNullOrWhiteSpace(MotivoDeBaja) Then
                    MessageBox.Show("Debe introducir un motivo de baja para continuar con esta acción", "Error al dar de baja empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Select
                End If
                EsActivo = False
                If Actualizar() Then
                    Dim Estatus As New Estatus(0, ID, Today(), MotivoDeBaja, Alerta, NotificarProveedores, NotificarClientes, NotificarSeguridad, UsuarioLogeado.ID)
                    If Estatus.Registrar() Then
                        Result = True
                    End If
                End If
            Case Operacion.Alta
                If MessageBox.Show("¿Esta seguro de que quieres dar reingreso a este empleado?", "Dar de alta empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Exit Select
                EsActivo = True
                If Actualizar() Then
                    Dim Estatus As New Estatus(0, ID, Today(), MotivoDeBaja, Alerta, NotificarProveedores, NotificarClientes, NotificarSeguridad, UsuarioLogeado.ID)
                    If Estatus.Eliminar() Then
                        Result = True
                    End If
                End If
        End Select

        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Empleado
        Dim Result As Empleado = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = Nombre
                cmd.Parameters.Add("@F_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoPaterno
                cmd.Parameters.Add("@M_LASTNAME", SqlDbType.NVarChar, 50).Value = ApellidoMaterno
                cmd.Parameters.Add("@ADDRESS", SqlDbType.NVarChar, 50).Value = Domicilio
                cmd.Parameters.Add("@NEIGHBORHOOD", SqlDbType.NVarChar, 20).Value = Colonia
                cmd.Parameters.Add("@CITYSTATE", SqlDbType.NVarChar, 50).Value = CiudadEstado
                cmd.Parameters.Add("@ZIP", SqlDbType.NVarChar, 20).Value = CodigoPostal
                cmd.Parameters.Add("@CELL", SqlDbType.NVarChar, 20).Value = Celular
                cmd.Parameters.Add("@TEL", SqlDbType.NVarChar, 20).Value = Telefono
                cmd.Parameters.Add("@CIVIL", SqlDbType.NVarChar, 20).Value = EstadoCivil
                cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
                cmd.Parameters.Add("@CITY", SqlDbType.NVarChar, 20).Value = CiudadNatal
                cmd.Parameters.Add("@STATE", SqlDbType.NVarChar, 10).Value = EntidadNatal
                cmd.Parameters.Add("@WAGE", SqlDbType.Decimal).Value = Salario
                cmd.Parameters.Add("@STUDIES", SqlDbType.NVarChar, 20).Value = NivelEducativo
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 20).Value = Email
                cmd.Parameters.Add("@BIRTHDAY", SqlDbType.DateTime).Value = FechaDeNacimiento
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar, 20).Value = RFC
                cmd.Parameters.Add("@SSN", SqlDbType.NVarChar, 20).Value = NSS
                cmd.Parameters.Add("@HIRING", SqlDbType.DateTime).Value = FechaDeAlta
                cmd.Parameters.Add("@SEX", SqlDbType.NVarChar, 1).Value = Sexo
                cmd.Parameters.Add("@CURP", SqlDbType.NVarChar, 20).Value = CURP
                cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo.ID
                cmd.Parameters.Add("@SUPERVISOR", SqlDbType.Int).Value = Supervisor.ID
                cmd.Parameters.Add("@START", SqlDbType.DateTime).Value = FechaEfectiva
                cmd.Parameters.Add("@DEPARMENT", SqlDbType.NVarChar, 10).Value = Departamento.ID
                cmd.Parameters.Add("@POSITION", SqlDbType.NVarChar, 10).Value = Puesto.ID
                cmd.Parameters.Add("@USER", SqlDbType.Int).Value = Usuario.ID
                cmd.Parameters.Add("@ACTIVE", SqlDbType.Bit).Value = EsActivo
                cmd.Parameters.Add("@ISSUPERVISOR", SqlDbType.Bit).Value = EsSupervisor
                If Foto Is Nothing Then
                    cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@PHOTO", SqlDbType.Image).Value = ImagenABytes(Foto)
                End If

                cmd.Parameters.Add("@OPTION", SqlDbType.Int).Value = Operacion.BuscarTodos

                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New Empleado(Reader("ID_Emp"), Reader("Emp_Name"), Reader("Emp_APat"), Reader("Emp_AMat"), Reader("Emp_Domicilio"), Reader("Emp_Col"),
                            Reader("Emp_CiudadEstado"), Reader("Emp_CP"), Reader("Emp_Cel"), Reader("Emp_Tel"), Reader("Emp_EdoCivil"), Reader("Emp_Nacionalidad"),
                            Reader("Emp_Ciudad"), Reader("Emp_EN"), Reader("Emp_Salario"), Reader("Emp_NEducativo"), Reader("Emp_Email"), Reader("Emp_FNac"),
                            Reader("Emp_RFC"), Reader("Emp_NSS"), Reader("Emp_FAlta"), Reader("Emp_Sexo"), Reader("Emp_Curp"), New Tipo().Buscar(Reader("Emp_Tipo").ToString()),
                            New Supervisor().Buscar(Reader("Emp_Sup").ToString()), Reader("Emp_FEfectiva"), New Departamento().Buscar(Reader("ID_Depto").ToString()),
                            New Puesto().Buscar(Reader("ID_Puesto").ToString()), New Usuario().Buscar(Reader("ID_User").ToString()), Reader("Emp_Activo"),
                            Reader("EsSupervisor"), CargarImagen(Reader("Img_Emp")), Reader("Fecha_Baja"), Reader("Motivo"), Reader("Alerta"), Reader("NProv"),
                            Reader("NClientes"), Reader("NClientes")
                            )
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function

    Private Function CargarImagen(ArregloDeBytes As Byte()) As Image
        Dim Result As Image
        If ArregloDeBytes.Length > 0 Then
            Dim ms As New MemoryStream(ArregloDeBytes)
            Result = Image.FromStream(ms)
        Else
            Result = My.Resources.photoNobody120
        End If
        Return Result
    End Function

    Private Function ImagenABytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            Dim Bin As New MemoryStream
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
#End Region
    Public Class Vista
        Public Property ID As New Integer
        Public Property Nombre As String = String.Empty
        Public Property ApellidoPaterno As String = String.Empty
        Public Property ApellidoMaterno As String = String.Empty
        Public Property FechaDeNacimiento As New Date
        Public Property Sexo As String = String.Empty
        Public Property FechaDeAlta As New Date
        Public Property EsActivo As Boolean = True
        <Browsable(False)>
        Public Property NombreCompleto As String = String.Empty
        <Browsable(False)>
        Public Property Usuario As Usuario = Nothing


        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal Empleado As Empleado)
            With Empleado
                ID = .ID
                Nombre = .Nombre
                ApellidoPaterno = .ApellidoPaterno
                ApellidoMaterno = .ApellidoMaterno
                FechaDeNacimiento = .FechaDeNacimiento.ToShortDateString()
                Sexo = .Sexo
                FechaDeAlta = .FechaDeAlta.ToShortDateString()
                EsActivo = .EsActivo
                NombreCompleto = .NombreCompleto
                Usuario = .Usuario
            End With
        End Sub

        Public Function GenerarVista(ByRef Listado As List(Of Empleado)) As List(Of Vista)
            Dim Resultado As New List(Of Vista)
            For Each Eval In Listado
                Resultado.Add(New Vista(Eval))
            Next
            Return Resultado
        End Function
    End Class
End Class

