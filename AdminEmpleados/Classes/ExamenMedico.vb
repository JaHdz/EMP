Public Class ExamenMedico
#Region "Propiedades"
		Public Property ID_EM As integer 
		Public Property ID_Emp As integer? 
		Public Property EM_Estudio As string 
		Public Property EM_Resultado As string 
		Public Property EM_Fecha As DateTime? 
		Public Property EM_FechaProximo As DateTime? 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_EM As integer, ByVal liID_Emp As integer?, ByVal lsEM_Estudio As string, ByVal lsEM_Resultado As string, ByVal lDEM_Fecha As DateTime?, ByVal lDEM_FechaProximo As DateTime?)
    ID_EM = liID_EM 
    ID_Emp = liID_Emp 
    EM_Estudio = lsEM_Estudio 
    EM_Resultado = lsEM_Resultado 
    EM_Fecha = lDEM_Fecha 
    EM_FechaProximo = lDEM_FechaProximo 
End Sub
#End Region
End Class

