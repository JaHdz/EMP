Public Class OtroIngreso
#Region "Propiedades"
		Public Property ID_OIng As integer 
		Public Property ID_EstSocio As integer? 
		Public Property OIng_Desc As string 
		Public Property OIng_Cantidad As decimal? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_OIng As integer, ByVal liID_EstSocio As integer?, ByVal lsOIng_Desc As string, ByVal ldOIng_Cantidad As decimal?)
    ID_OIng = liID_OIng 
    ID_EstSocio = liID_EstSocio 
    OIng_Desc = lsOIng_Desc 
    OIng_Cantidad = ldOIng_Cantidad 
End Sub
#End Region
End Class

