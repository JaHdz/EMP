Public Class Enfermedad
#Region "Propiedades"
		Public Property ID_Enf As integer 
		Public Property ID_Emp As integer? 
		Public Property Text As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Enf As integer, ByVal liID_Emp As integer?, ByVal lsText As string)
    ID_Enf = liID_Enf 
    ID_Emp = liID_Emp 
    Text = lsText 
End Sub
#End Region
End Class

