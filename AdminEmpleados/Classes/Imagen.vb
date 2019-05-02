Public Class Imagen
#Region "Propiedades"
		Public Property ID_Images As integer 
		Public Property ID_Emp As integer? 
		Public Property Img_Emp As byte[] 
		Public Property Img_Dom As byte[] 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Images As integer, ByVal liID_Emp As integer?, ByVal lbImg_Emp As byte[], ByVal lbImg_Dom As byte[])
    ID_Images = liID_Images 
    ID_Emp = liID_Emp 
    Img_Emp = lbImg_Emp 
    Img_Dom = lbImg_Dom 
End Sub
#End Region
End Class

