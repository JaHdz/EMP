Friend Module CatalogosEstaticos
    Public Entidades As New List(Of Entidad)
    Public Ciudades As New List(Of Ciudad)
    Public EstadosCiviles As New List(Of EstadoCivil)
    Public NivelesEducativos As New List(Of NivelEducativo)

    Public Sub CargarCatalogos()
        Entidades = New Entidad().CargarListado()
        Ciudades = New Ciudad().CargarListado()
        EstadosCiviles = New EstadoCivil().CargarListado()
        NivelesEducativos = New NivelEducativo().CargarListado()
    End Sub

End Module
