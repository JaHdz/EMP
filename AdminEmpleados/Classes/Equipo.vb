Public Class Equipo
#Region "Propiedades"
		Public Property ID_Equipo As integer 
		Public Property Nombre As string 
		Public Property Descripcion As string 
		Public Property Costo As decimal? 
		Public Property Estatus As boolean? 
		Public Property ID_Depto As integer? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Equipo As integer, ByVal lsNombre As string, ByVal lsDescripcion As string, ByVal ldCosto As decimal?, ByVal lbEstatus As boolean?, ByVal liID_Depto As integer?)
    ID_Equipo = liID_Equipo 
    Nombre = lsNombre 
    Descripcion = lsDescripcion 
    Costo = ldCosto 
    Estatus = lbEstatus 
    ID_Depto = liID_Depto 
End Sub
#End Region
End Class

