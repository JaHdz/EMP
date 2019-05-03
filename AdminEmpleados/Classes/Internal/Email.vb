Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Email

    Public Shared Function GenerateCode() As String
        Dim random As New Random()
        GenerateCode = "TSW-" & random.Next(1, 9999).ToString("D4")
    End Function


    Public Shared Function Send(Emails As String, Title As String, Header1 As String, Message1 As String, Code As String, Optional Header2 As String = "", Optional Message2 As String = "") As String
        Dim Status As String = Nothing
        Try
            Using Email As New MailMessage
                Dim HTML = File.ReadAllText("Email_template.html")
                HTML = HTML.Replace("#HEADER1#", Header1)
                HTML = HTML.Replace("#HEADER2#", Header2)
                HTML = HTML.Replace("#MESSAGE1#", Message1)
                HTML = HTML.Replace("#MESSAGE2#", Message2)
                HTML = HTML.Replace("#COMPANY#", "Turing Software " + Now.Year.ToString())
                HTML = HTML.Replace("#CODE#", Code)

                Email.Subject = "EASY: " & Title
                Email.Body = HTML
                Email.IsBodyHtml = True
                Email.Priority = MailPriority.High
                Email.From = New MailAddress("noreply.turingsoftware@gmail.com")

                If Not String.IsNullOrWhiteSpace(Emails) Then
                    For Each recipient In Emails.Split(";"c)
                        If Not String.IsNullOrWhiteSpace(recipient) Then
                            Email.Bcc.Add(recipient)
                        End If
                    Next
                End If

                If Email.Bcc.Count <= 0 Then
                    Throw New Exception("El remitente del correo esta vacío")
                    Status = "Failed"
                End If
                Using smtp As New SmtpClient
                    smtp.Port = 587
                    smtp.EnableSsl = True
                    smtp.Host = "smtp.gmail.com"
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network
                    smtp.Credentials = New NetworkCredential("noreply.turingsoftware@gmail.com", "@P@$$w0rd")
                    smtp.Send(Email)
                    Status = "Success"
                End Using
            End Using
        Catch ex As Exception
            Status = "Failed"
        End Try
        Return Status
    End Function
End Class
