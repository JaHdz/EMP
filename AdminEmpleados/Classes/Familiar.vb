Public Class Familiar
#Region "Propiedades"
		Public Property ID_Persona As integer 
		Public Property ID_Emp As integer? 
		Public Property Fam_Tipo As string 
		Public Property Fam_Nombre As string 
		Public Property Fam_APat As string 
		Public Property Fam_AMat As string 
		Public Property Fam_Nacion As string 
		Public Property Fam_FNac As DateTime? 
		Public Property Fam_Genero As string 
	#End Region

	#Region "Funciones y Metodos"
	Public Sub New(ByVal liID_Persona As integer, ByVal liID_Emp As integer?, ByVal lsFam_Tipo As string, ByVal lsFam_Nombre As string, ByVal lsFam_APat As string, ByVal lsFam_AMat As string, ByVal lsFam_Nacion As string, ByVal lDFam_FNac As DateTime?, ByVal lsFam_Genero As string)
    ID_Persona = liID_Persona 
    ID_Emp = liID_Emp 
    Fam_Tipo = lsFam_Tipo 
    Fam_Nombre = lsFam_Nombre 
    Fam_APat = lsFam_APat 
    Fam_AMat = lsFam_AMat 
    Fam_Nacion = lsFam_Nacion 
    Fam_FNac = lDFam_FNac 
    Fam_Genero = lsFam_Genero 
End Sub
#End Region
End Class

