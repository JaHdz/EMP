Public Class Usuario
#Region "Propiedades"
    Public Property ID As Integer
    Public Property Empleado As Integer
    Public Property UserName As String
    Public Property Password As String
    Public Property Activo As Boolean?
    Public Property Acceso As Integer?
    Public Property ResetKey As String
#End Region

#Region "Funciones y Metodos"
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer, ByVal lsUserName As String, ByVal lsPassword As String, ByVal lbActivo As Boolean?,
                   ByVal liAcceso As Integer?, ByVal lsResetKey As String)
        ID = liID
        Empleado = liEmpleado
        UserName = lsUserName
        Password = lsPassword
        Activo = lbActivo
        Acceso = liAcceso
        ResetKey = lsResetKey
    End Sub
#End Region
End Class

