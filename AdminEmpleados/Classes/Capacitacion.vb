Public Class Capacitacion
#Region "Propiedades"
		Public Property ID_Cap As integer 
		Public Property CA_Codigo As string 
		Public Property CA_Desc As string 
		Public Property CA_Status As boolean? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Cap As integer, ByVal lsCA_Codigo As string, ByVal lsCA_Desc As string, ByVal lbCA_Status As boolean?)
    ID_Cap = liID_Cap 
    CA_Codigo = lsCA_Codigo 
    CA_Desc = lsCA_Desc 
    CA_Status = lbCA_Status 
End Sub
#End Region
End Class

