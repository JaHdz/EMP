Public Class CapacitacionDeEmpleado
#Region "Propiedades"
		Public Property ID_Cap_Emp As integer 
		Public Property ID_Cap As integer? 
		Public Property ID_Emp As integer? 
		Public Property Fecha As DateTime? 
		Public Property Comentario As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Cap_Emp As integer, ByVal liID_Cap As integer?, ByVal liID_Emp As integer?, ByVal lDFecha As DateTime?, ByVal lsComentario As string)
    ID_Cap_Emp = liID_Cap_Emp 
    ID_Cap = liID_Cap 
    ID_Emp = liID_Emp 
    Fecha = lDFecha 
    Comentario = lsComentario 
End Sub
#End Region
End Class

