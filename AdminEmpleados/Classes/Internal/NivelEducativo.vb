Public Class NivelEducativo
    Public Property ID As Integer
    Public Property Descripcion As String

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(liID As Integer, lsDescripcion As String)
        ID = liID
        Descripcion = lsDescripcion
    End Sub

    Public Function CargarListado() As List(Of NivelEducativo)
        Dim Resultado As New List(Of NivelEducativo) From {
            New NivelEducativo(0, ""),
            New NivelEducativo(1, "PRIMARIA"),
            New NivelEducativo(2, "SECUNDARIA"),
            New NivelEducativo(3, "PREPARATORIA"),
            New NivelEducativo(4, "LICENCIATURA")
        }

        Return Resultado
    End Function
End Class
