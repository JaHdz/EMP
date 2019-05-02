Public Class Entidad
#Region "Propiedades"
		Public Property Codigo As string 
		Public Property Descripcion As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal lsCodigo As string, ByVal lsDescripcion As string)
    Codigo = lsCodigo 
    Descripcion = lsDescripcion 
End Sub
#End Region
End Class

