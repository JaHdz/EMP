Public Class ContactoDeEmergencia
#Region "Propiedades"
		Public Property ID_CEmergencia As integer 
		Public Property ID_Emp As integer? 
		Public Property CE_Nombre As string 
		Public Property CE_APat As string 
		Public Property CE_AMat As string 
		Public Property CE_Parentesco As string 
		Public Property CE_Telefono As string 
		Public Property CE_Celular As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_CEmergencia As integer, ByVal liID_Emp As integer?, ByVal lsCE_Nombre As string, ByVal lsCE_APat As string, ByVal lsCE_AMat As string, ByVal lsCE_Parentesco As string, ByVal lsCE_Telefono As string, ByVal lsCE_Celular As string)
    ID_CEmergencia = liID_CEmergencia 
    ID_Emp = liID_Emp 
    CE_Nombre = lsCE_Nombre 
    CE_APat = lsCE_APat 
    CE_AMat = lsCE_AMat 
    CE_Parentesco = lsCE_Parentesco 
    CE_Telefono = lsCE_Telefono 
    CE_Celular = lsCE_Celular 
End Sub
#End Region
End Class

