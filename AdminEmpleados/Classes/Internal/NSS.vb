
Module NSS
    Public Const NssLength As Integer = 11

    Function IsValid(ByVal nss As String) As Boolean
        If nss.Length <> NssLength Then
            Return False
        End If

        Dim sum As Integer = 0
        For i As Integer = 0 To NssLength - 2
            Dim n = Asc(nss(i)) - Asc("0"c)
            If n < 0 OrElse n > 9 Then
                Return False
            End If

            If i Mod 2 = 1 Then
                n = n * 2
                If n >= 10 Then
                    n = n \ 10 + n Mod 10
                End If
            End If

            sum += n
        Next

        Dim calcDigit = Math.Ceiling(sum / 10D) * 10 - sum
        Dim lastDigit = Asc(nss(10)) - Asc("0"c)
        Return calcDigit = lastDigit
    End Function
End Module
