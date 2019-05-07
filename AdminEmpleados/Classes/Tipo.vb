Public Class Tipo
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Codigo As String
    Public Property Descripcion As String
    Public Property Estatus As boolean?
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID_TE As integer, ByVal lsCodigo As string, ByVal lsDescripcion As string, ByVal lbEstatus As boolean?)
        ID = liID_TE
        Codigo = lsCodigo
        Descripcion = lsDescripcion
        Estatus = lbEstatus 
End Sub
#End Region
End Class

