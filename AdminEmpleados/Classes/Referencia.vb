Public Class Referencia
#Region "Propiedades"
    Public Property ID As Integer
    Public Property EstudioSocioeconomico As Integer
    Public Property Nombre As String
    Public Property Ocupacion As String
    Public Property TipoDeRelacion As String
    Public Property TiempoDeConocerse As String
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID As Integer, ByVal liEstudioSocioeconomico As Integer, ByVal lsNombre As String, ByVal lsOcupacion As String,
                   ByVal lsTipoDeRelacion As String, ByVal lsTiempoDeConocerse As String)
        ID = liID
        EstudioSocioeconomico = liEstudioSocioeconomico
        Nombre = lsNombre
        Ocupacion = lsOcupacion
        TipoDeRelacion = lsTipoDeRelacion
        TiempoDeConocerse = lsTiempoDeConocerse
    End Sub
#End Region
End Class

