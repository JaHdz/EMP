Imports System.Reflection

Module Security
    Public UsuarioLogeado As Usuario = Nothing
    Public Function Encrypt(ByVal Pass As String) As String
        Dim Clave As String = "%ü&/@#$A"
        Dim Pass2 = ""
        For i = 1 To Len(Pass)
            Dim CAR = Mid(Pass, i, 1)
            Dim Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
        Next i
        Return Pass2
    End Function

    Public Function Decrypt(ByVal Pass As String) As String
        Dim Clave As String = "%ü&/@#$A"
        Dim Pass2 = ""
        Dim j = 1
        For i = 1 To Len(Pass) Step 2
            Dim CAR = Mid(Pass, i, 2)
            Dim Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
            Pass2 = Pass2 & Chr(Asc(Codigo) Xor Val("&h" + CAR))
            j = j + 1
        Next i
        Return Pass2
    End Function

    Public Function ToDataTable(Of T As Class)(data As List(Of T)) As DataTable
        Dim result As New DataTable()
        Dim type As Type = GetType(T)
        Dim list = (From p As PropertyInfo In type.GetProperties() Where (p.CanRead AndAlso (p.GetIndexParameters().Length = 0)) Select New With {.[Property] = p, .Column = New DataColumn(p.Name, p.PropertyType)})
        result.Columns.AddRange((From obj In list Select obj.Column).ToArray())
        If (Not data Is Nothing) Then
            result.BeginLoadData()
            Array.ForEach(Of T)(data.ToArray(), Function(item As T) result.Rows.Add((From obj In list Select obj.[Property].GetValue(item, Nothing)).ToArray()))
            result.EndLoadData()
        End If
        result.AcceptChanges()
        list = Nothing
        type = Nothing
        Return result
    End Function
End Module
