Public Class Ciudad
#Region "Propiedades"
		Public Property Codigo As string 
		Public Property Descripcion As string 
		Public Property ID_Estado As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal lsCodigo As string, ByVal lsDescripcion As string, ByVal lsID_Estado As string)
    Codigo = lsCodigo 
    Descripcion = lsDescripcion 
    ID_Estado = lsID_Estado 
End Sub
#End Region
End Class

