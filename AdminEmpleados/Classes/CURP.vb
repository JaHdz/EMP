Module CURP
    Public Const CurpLength As Integer = 18

    Private Const Alphabet As String = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"

    Function IsValid(ByVal curp As String) As Boolean
        If curp.Length <> CurpLength Then
            Return False
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(curp, "^[A-Z][AEIOUX][A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|[1-2][0-9]|30|31)(H|M)(AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|SM|NE)[BCDFGHJKLMNPQRSTVWXYZ]{3}[0-9A-Z][0-9]$") Then
            Return False
        End If

        Dim year As Integer = Convert.ToInt32(curp.Substring(4, 2)) + (If(curp(16) < "A"c, 1900, 2000))
        Dim month As Integer = Convert.ToInt32(curp.Substring(6, 2))
        Dim day As Integer = Convert.ToInt32(curp.Substring(8, 2))
        If day > DateTime.DaysInMonth(year, month) Then
            Return False
        End If

        Dim sum As Integer = 0
        For i As Integer = 0 To CurpLength - 1 - 1
            Dim index As Integer = Alphabet.IndexOf(curp(i))
            If index < 0 Then
                Return False
            End If

            sum += index * (CurpLength - i)
        Next

        Return curp(17) = Alphabet((10 - (sum Mod 10)) Mod 10)
    End Function

End Module
