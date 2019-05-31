Public Class EstadoCivil
    Public Property ID As Integer
    Public Property Descripcion As String

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(liID As Integer, lsDescripcion As String)
        ID = liID
        Descripcion = lsDescripcion
    End Sub

    Public Function CargarListado() As List(Of EstadoCivil)
        Dim Result As New List(Of EstadoCivil) From {
            New EstadoCivil(0, ""),
            New EstadoCivil(1, "SOLTERO"),
            New EstadoCivil(2, "CASADO"),
            New EstadoCivil(3, "UNION LIBRE"),
            New EstadoCivil(4, "DIVORCIADO"),
            New EstadoCivil(5, "VIUDO")
        }
        Return Result
    End Function
End Class
