Public Class Puesto
#Region "Propiedades"
		Public Property ID_Puesto As integer 
		Public Property Nombre As string 
		Public Property Descripcion As string 
		Public Property Riesgo As boolean? 
		Public Property Estatus As boolean? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Puesto As integer, ByVal lsNombre As string, ByVal lsDescripcion As string, ByVal lbRiesgo As boolean?, ByVal lbEstatus As boolean?)
    ID_Puesto = liID_Puesto 
    Nombre = lsNombre 
    Descripcion = lsDescripcion 
    Riesgo = lbRiesgo 
    Estatus = lbEstatus 
End Sub
#End Region
End Class

