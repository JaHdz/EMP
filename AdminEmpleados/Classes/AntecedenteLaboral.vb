Public Class AntecedenteLaboral
#Region "Propiedades"
		Public Property ID_Ant As integer 
		Public Property ID_Emp As integer? 
		Public Property Ant_FInicio As DateTime? 
		Public Property Ant_FFin As DateTime? 
		Public Property Ant_NEmpresa As string 
		Public Property Ant_Cargo As string 
		Public Property Ant_Salario As decimal? 
		Public Property Ant_Tel As string 
		Public Property Ant_Motivo As string 
		Public Property Ant_Contacto As string
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID_Ant As Integer, ByVal liID_Emp As Integer?, ByVal lDAnt_FInicio As DateTime?, ByVal lDAnt_FFin As DateTime?, ByVal lsAnt_NEmpresa As String, ByVal lsAnt_Cargo As String, ByVal ldAnt_Salario As Decimal?, ByVal lsAnt_Tel As String, ByVal lsAnt_Motivo As String, ByVal lsAnt_Contacto As String)
        ID_Ant = liID_Ant
        ID_Emp = liID_Emp
        Ant_FInicio = lDAnt_FInicio
        Ant_FFin = lDAnt_FFin
        Ant_NEmpresa = lsAnt_NEmpresa
        Ant_Cargo = lsAnt_Cargo
        Ant_Salario = ldAnt_Salario
        Ant_Tel = lsAnt_Tel
        Ant_Motivo = lsAnt_Motivo
        Ant_Contacto = lsAnt_Contacto
    End Sub
#End Region
End Class

