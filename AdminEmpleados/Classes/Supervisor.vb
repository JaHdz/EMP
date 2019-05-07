Public Class Supervisor
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Empleado As Integer?
    Public Property Activo As Boolean
    Public Property Nombre As String
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lbActivo As Boolean, ByVal lsNombre As String)
        ID = liID
        Empleado = liEmpleado
        Activo = lbActivo
        Nombre = lsNombre
    End Sub
#End Region
End Class

