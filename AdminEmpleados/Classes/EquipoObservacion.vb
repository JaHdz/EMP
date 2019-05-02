Public Class EquipoObservacion
#Region "Propiedades"
		Public Property ID_Comment As integer 
		Public Property ID_Emp As integer? 
		Public Property Observaciones As string 
		Public Property Fecha As DateTime? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Comment As integer, ByVal liID_Emp As integer?, ByVal lsObservaciones As string, ByVal lDFecha As DateTime?)
    ID_Comment = liID_Comment 
    ID_Emp = liID_Emp 
    Observaciones = lsObservaciones 
    Fecha = lDFecha 
End Sub
#End Region
End Class

