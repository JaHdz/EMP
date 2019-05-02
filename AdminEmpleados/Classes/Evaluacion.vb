Public Class Evaluacion
#Region "Propiedades"
		Public Property ID_Evalua As integer 
		Public Property EV_Codigo As string 
		Public Property EV_Descipcion As string 
		Public Property EV_Estatus As boolean? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Evalua As integer, ByVal lsEV_Codigo As string, ByVal lsEV_Descipcion As string, ByVal lbEV_Estatus As boolean?)
    ID_Evalua = liID_Evalua 
    EV_Codigo = lsEV_Codigo 
    EV_Descipcion = lsEV_Descipcion 
    EV_Estatus = lbEV_Estatus 
End Sub
#End Region
End Class

