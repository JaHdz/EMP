﻿
Public Class Sexo

    Public Property ID As String
    Public Property Nombre As String
    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(loID As String, loNombre As String)
        ID = loID
        Nombre = loNombre
    End Sub

    Public Function CargarListado() As List(Of Sexo)
        Dim resultado = New List(Of Sexo)
        resultado.Add(New Sexo("", ""))
        resultado.Add(New Sexo("M", "MASCULINO"))
        resultado.Add(New Sexo("F", "FEMENINO"))
        Return resultado
    End Function
End Class
