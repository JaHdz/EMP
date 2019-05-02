Public Class Departamento
#Region "Propiedades"
		Public Property ID_Depto As integer 
		Public Property Codigo As string 
		Public Property Descripcion As string 
		Public Property Estatus As boolean? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Depto As integer, ByVal lsCodigo As string, ByVal lsDescripcion As string, ByVal lbEstatus As boolean?)
    ID_Depto = liID_Depto 
    Codigo = lsCodigo 
    Descripcion = lsDescripcion 
    Estatus = lbEstatus 
End Sub
#End Region
End Class

