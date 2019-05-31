Imports System.ComponentModel

Public Class Entidad
#Region "Propiedades"
    <Browsable(False)>
    Public Property Codigo As Integer
    Public Property Nombre As String
    Public Property Abreviacion As String

#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New
    End Sub
    Public Sub New(ByVal lsCodigo As Integer, ByVal lsDescripcion As String, lsAbreviacion As String)
        Codigo = lsCodigo
        Nombre = lsDescripcion
        Abreviacion = lsAbreviacion
    End Sub

    Public Function CargarListado() As List(Of Entidad)
        Dim Resultado As New List(Of Entidad) From {
            New Entidad("01", "AGUASCALIENTES", "AS"),
            New Entidad("02", "BAJA CALIFORNIA", "BC"),
            New Entidad("03", "BAJA CALIFORNIA SUR", "BS"),
            New Entidad("04", "CAMPECHE", "CC"),
            New Entidad("05", "COAHUILA DE ZARAGOZA", "CL"),
            New Entidad("06", "COLIMA", "CM"),
            New Entidad("07", "CHIAPAS", "CS"),
            New Entidad("08", "CHIHUAHUA", "CH"),
            New Entidad("09", "CIUDAD DE MÉXICO", "DF"),
            New Entidad("10", "DURANGO", "DG"),
            New Entidad("11", "GUANAJUATO", "GT"),
            New Entidad("12", "GUERRERO", "GR"),
            New Entidad("13", "HIDALGO", "HG"),
            New Entidad("14", "JALISCO", "JC"),
            New Entidad("15", "MÉXICO", "MC"),
            New Entidad("16", "MICHOACÁN DE OCAMPO", "MN"),
            New Entidad("17", "MORELOS", "MS"),
            New Entidad("18", "NAYARIT", "NT"),
            New Entidad("19", "NUEVO LEÓN", "NL"),
            New Entidad("20", "OAXACA", "OC"),
            New Entidad("21", "PUEBLA", "PL"),
            New Entidad("22", "QUERÉTARO", "QT"),
            New Entidad("23", "QUINTANA ROO", "QR"),
            New Entidad("24", "SAN LUIS POTOSÍ", "SP"),
            New Entidad("25", "SINALOA", "SL"),
            New Entidad("26", "SONORA", "SR"),
            New Entidad("27", "TABASCO", "TC"),
            New Entidad("28", "TAMAULIPAS", "TS"),
            New Entidad("29", "TLAXCALA", "TL"),
            New Entidad("30", "VERACRUZ DE IGNACIO DE LA LLAVE", "VZ"),
            New Entidad("31", "YUCATÁN", "YN"),
            New Entidad("32", "ZACATECAS", "ZS"),
            New Entidad("99", "NACIDO EN EL EXTRANJERO", "NE")
        }
        Return Resultado
    End Function

    Public Function Buscar(loCodigo As Integer) As Entidad
        Dim Resultado As New Entidad
        Resultado = Entidades.Find(Function(x) x.Codigo = loCodigo)
        Return Resultado
    End Function
#End Region
End Class

