Public Class EquipoAsignado
#Region "Propiedades"
		Public Property ID_Assig As integer 
		Public Property ID_Equipo As string 
		Public Property ID_Emp As integer? 
		Public Property Fecha As DateTime? 
		Public Property Regreso As boolean? 
		Public Property Fecha_R As DateTime? 
		Public Property Comentario As string 
		Public Property ID_User As integer? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Assig As integer, ByVal lsID_Equipo As string, ByVal liID_Emp As integer?, ByVal lDFecha As DateTime?, ByVal lbRegreso As boolean?, ByVal lDFecha_R As DateTime?, ByVal lsComentario As string, ByVal liID_User As integer?)
    ID_Assig = liID_Assig 
    ID_Equipo = lsID_Equipo 
    ID_Emp = liID_Emp 
    Fecha = lDFecha 
    Regreso = lbRegreso 
    Fecha_R = lDFecha_R 
    Comentario = lsComentario 
    ID_User = liID_User 
End Sub
#End Region
End Class

