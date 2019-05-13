Public Class Imagen
#Region "Propiedades"
    Public Property ID_Images As Integer
    Public Property ID_Emp As integer?
    Public Property Img_Emp As Byte()
    Public Property Img_Dom As Byte()
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID_Images As Integer, ByVal liID_Emp As Integer?, ByVal lbImg_Emp As Byte(), ByVal lbImg_Dom As Byte())
        ID_Images = liID_Images
        ID_Emp = liID_Emp
        Img_Emp = lbImg_Emp
        Img_Dom = lbImg_Dom
    End Sub
#End Region
End Class

