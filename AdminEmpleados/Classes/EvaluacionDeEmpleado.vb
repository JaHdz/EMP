Public Class EvaluacionDeEmpleado
#Region "Propiedades"
		Public Property ID_EvEmp As integer 
		Public Property ID_Codigo As string 
		Public Property ID_Emp As integer? 
		Public Property Fecha As DateTime? 
		Public Property Estatus As string 
		Public Property ID_User As integer? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_EvEmp As integer, ByVal lsID_Codigo As string, ByVal liID_Emp As integer?, ByVal lDFecha As DateTime?, ByVal lsEstatus As string, ByVal liID_User As integer?)
    ID_EvEmp = liID_EvEmp 
    ID_Codigo = lsID_Codigo 
    ID_Emp = liID_Emp 
    Fecha = lDFecha 
    Estatus = lsEstatus 
    ID_User = liID_User 
End Sub
#End Region
End Class

