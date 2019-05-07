Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Empleado
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    <Browsable(False)>
    Public Property Domicilio As String
    <Browsable(False)>
    Public Property Colonia As String
    <Browsable(False)>
    Public Property CiudadEstado As String
    <Browsable(False)>
    Public Property CodigoPostal As String
    <Browsable(False)>
    Public Property Celular As String
    <Browsable(False)>
    Public Property Telefono As String
    <Browsable(False)>
    Public Property EstadoCivil As String
    <Browsable(False)>
    Public Property Nacionalidad As String
    <Browsable(False)>
    Public Property CiudadNatal As String
    <Browsable(False)>
    Public Property EntidadNatal As String
    <Browsable(False)>
    Public Property Salario As Decimal
    <Browsable(False)>
    Public Property NivelEducativo As String
    <Browsable(False)>
    Public Property Email As String
    Public Property FechaDeNacimiento As Date
    <Browsable(False)>
    Public Property RFC As String
    <Browsable(False)>
    Public Property NSS As String
    Public Property Sexo As String
    Public Property FechaDeAlta As Date
    <Browsable(False)>
    Public Property CURP As String
    <Browsable(False)>
    Public Property Tipo As Tipo
    <Browsable(False)>
    Public Property Supervisor As Supervisor
    <Browsable(False)>
    Public Property FechaEfectiva As Date
    <Browsable(False)>
    Public Property Departamento As Departamento
    <Browsable(False)>
    Public Property Puesto As Puesto
    <Browsable(False)>
    Public Property Usuario As Usuario
    Public Property EsActivo As Boolean
    <Browsable(False)>
    Public Property EsSupervisor As Boolean
    <Browsable(False)>
    Public Property Foto As Image
    <Browsable(False)>
    Public Property FechaDeBaja As Date?
    <Browsable(False)>
    Public Property MotivoDeBaja As String
    <Browsable(False)>
    Public Property Alerta As Boolean
    <Browsable(False)>
    Public Property NotificarProveedores As Boolean
    <Browsable(False)>
    Public Property NotificarClientes As Boolean
    <Browsable(False)>
    Public Property NombreCompleto As String



#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal lsNombre As String, ByVal lsApellidoPaterno As String, ByVal lsApellidoMaterno As String, ByVal lsDomicilio As String,
                   ByVal lsColonia As String, ByVal lsCiudadEstado As String, ByVal lsCodigoPostal As String, ByVal lsCelular As String, ByVal lsTelefono As String,
                   ByVal lsEstadoCivil As String, ByVal lsNacionalidad As String, ByVal lsCiudadNatal As String, ByVal lsEntidadNatal As String,
                   ByVal ldESalario As Decimal, ByVal lsNivelEducativo As String, ByVal lsEmail As String, ByVal ldFechaDeNacimiento As Date,
                   ByVal lsRFC As String, ByVal liNSS As String, ByVal ldFechaDeAlta As Date, ByVal lsSexo As String, ByVal lsCURP As String,
                   ByVal loTipo As Tipo, ByVal loSupervisor As Supervisor, ByVal ldFechaEfectiva As Date, ByVal loDepartamento As Departamento, ByVal loPuesto As Puesto,
                   ByVal loUsuario As Usuario, ByVal lbEsActivo As Boolean, ByVal lbEsSupervisor As Boolean, ByVal liFoto As Image, ByVal ldFechaDeBaja As Date, ByVal lsMotivoDeBaja As String,
                   ByVal lbAlerta As Boolean, ByVal lbNotificarProveedores As Boolean, ByVal lbNotificarClientes As Boolean)
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
        Salario = ldESalario
        NivelEducativo = lsNivelEducativo
        Email = lsEmail
        FechaDeNacimiento = ldFechaDeNacimiento
        RFC = lsRFC
        NSS = liNSS
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
        NombreCompleto = lsNombre + " " + lsApellidoPaterno + " " + lsApellidoMaterno
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Empleado)
        Dim Result As New List(Of Empleado)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("Consulta_Emp", con) With {
                .CommandType = CommandType.StoredProcedure
            }
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEmpleado As New Empleado(
                        Reader("ID_Emp"), Reader("Emp_Name"), Reader("Emp_APat"), Reader("Emp_AMat"), Reader("Emp_Domicilio"), Reader("Emp_Col"), Reader("Emp_CiudadEstado"), Reader("Emp_CP"),
                        Reader("Emp_Cel"), Reader("Emp_Tel"), Reader("Emp_EdoCivil"), Reader("Emp_Nacionalidad"), Reader("Emp_Ciudad"), Reader("Emp_EN"), Reader("Emp_Salario"), Reader("Emp_NEducativo"),
                        Reader("Emp_Email"), Reader("Emp_FNac"), Reader("Emp_RFC"), Reader("Emp_NSS"), Reader("Emp_FAlta"), Reader("Emp_Sexo"), Reader("Emp_Curp"), New Tipo(), New Supervisor(),
                        Reader("Emp_FEfectiva"), New Departamento(), New Puesto(), New Usuario().Buscar(Reader("ID_User").ToString()), Reader("Emp_Activo"), Reader("EsSupervisor"), CargarImagen(Reader("Img_Emp")), Reader("Fecha_Baja"),
                        Reader("Motivo"), Reader("Alerta"), Reader("NProv"), Reader("NClientes")
                        )
                    Result.Add(loEmpleado)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EsActivo = True)
        End If
        Return Result
    End Function

    Private Function CargarImagen(ArregloDeBytes As Byte()) As Image
        Dim Result As Image
        If ArregloDeBytes.Length > 0 Then
            Dim ms As New IO.MemoryStream(ArregloDeBytes)
            Result = Image.FromStream(ms)
        Else
            Result = My.Resources.photoNobody120
        End If
        Return Result
    End Function
#End Region
End Class

