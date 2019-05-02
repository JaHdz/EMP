Public Class Bajas
#Region "Propiedades"
		Public Property ID_Baja As integer 
		Public Property ID_Emp As integer? 
		Public Property Fecha_Baja As DateTime? 
		Public Property Motivo As string 
		Public Property Alerta As boolean? 
		Public Property ID_user As integer? 
		Public Property NProv As boolean? 
		Public Property NClientes As boolean? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Baja As integer, ByVal liID_Emp As integer?, ByVal lDFecha_Baja As DateTime?, ByVal lsMotivo As string, ByVal lbAlerta As boolean?, ByVal liID_user As integer?, ByVal lbNProv As boolean?, ByVal lbNClientes As boolean?)
    ID_Baja = liID_Baja 
    ID_Emp = liID_Emp 
    Fecha_Baja = lDFecha_Baja 
    Motivo = lsMotivo 
    Alerta = lbAlerta 
    ID_user = liID_user 
    NProv = lbNProv 
    NClientes = lbNClientes 
End Sub
#End Region
End Class

