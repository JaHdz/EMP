Public Class Empleado
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property Domicilio As String
    Public Property Colonia As String
    Public Property CiudadEstado As String
    Public Property CodigoPostal As String
    Public Property Celular As String
    Public Property Telefono As String
    Public Property EstadoCivil As String
    Public Property Nacionalidad As String
    Public Property CiudadNatal As String
    Public Property EntidadNatal As String
    Public Property Salario As Decimal
    Public Property NivelEducativo As String
    Public Property Email As String
    Public Property FechaDeNacimiento As Date
    Public Property RFC As String
    Public Property NSS As Integer
    Public Property FechaDeAlta As Date
    Public Property Sexo As String
    Public Property CURP As String
    Public Property Tipo As Tipo
    Public Property Supervisor As Supervisor
    Public Property FechaEfectiva As Date
    Public Property Departamento As Departamento
    Public Property Puesto As Puesto
    Public Property Usuario As Usuario
    Public Property EsActivo As Boolean
    Public Property EsSupervisor As Boolean
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID As Integer, ByVal lsNombre As String, ByVal lsApellidoPaterno As String, ByVal lsApellidoMaterno As String, ByVal lsDomicilio As String,
                   ByVal lsColonia As String, ByVal lsCiudadEstado As String, ByVal lsCodigoPostal As String, ByVal lsCelular As String, ByVal lsTelefono As String,
                   ByVal lsEstadoCivil As String, ByVal lsNacionalidad As String, ByVal lsCiudadNatal As String, ByVal lsEntidadNatal As String,
                   ByVal ldESalario As Decimal, ByVal lsNivelEducativo As String, ByVal lsEmail As String, ByVal ldFechaDeNacimiento As Date,
                   ByVal lsRFC As String, ByVal liNSS As Integer, ByVal ldFechaDeAlta As Date, ByVal lsSexo As String, ByVal lsCURP As String,
                   ByVal loTipo As Tipo, ByVal loSupervisor As Supervisor, ByVal ldFechaEfectiva As Date, ByVal loDepartamento As Departamento, ByVal loPuesto As Puesto,
                   ByVal loUsuario As Usuario, ByVal lbEsActivo As Boolean, ByVal lbEsSupervisor As Boolean)
        ID = liID
        Nombre = lsNombre
        ApellidoPaterno = lsApellidoPaterno
        ApellidoMaterno = lsApellidoMaterno
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
    End Sub
#End Region
End Class

