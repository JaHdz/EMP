Imports Microsoft.Reporting.WinForms

Public Class frmReportes
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Public ReportOption As Integer
    Public Emp As Integer
    Public User As String
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RvReports.Reset()
        RvReports.ProcessingMode = ProcessingMode.Local

        Select Case ReportOption
            Case ReportOptions.SocialeconomicStudy
                Lbl_Title.Text = "Reporte de Estudio Socioeconomico"
                RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EstudioSocioeconomico.rdlc"
                RvReports.LocalReport.DataSources.Clear()
                Dim INFO As DataTable = New Cls_ES().GetInfo(Emp)
                Dim SESID = INFO.Rows(0).Item(0).ToString()
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_INFO", INFO))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_REFERENCES", New Cls_ES().GetReferences(SESID)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_FAMILY", New Cls_ES().GetFamily(Emp)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_OTHERINCOMES", New Cls_ES().GetOtherIncomes(SESID)))
            Case ReportOptions.AssignedEquipment
                Lbl_Title.Text = "Reporte de Equipo Entregado"
                RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EquipoEntregado.rdlc"
                RvReports.LocalReport.DataSources.Clear()
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("ASSIGNED_EQUIPMENT", New Cls_Emp().GetAssignedEquipment(Emp)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("RECEIVER", New Cls_Emp().GetEquipmentReceiver(0, User)))

        End Select
        RvReports.RefreshReport()
    End Sub
    Private Sub Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PnlHeader.MouseMove
        If bit Then
            Me.WindowState = FormWindowState.Normal
            If Me.Left + e.X - X >= 0 AndAlso Me.Top + e.Y - Y > 10 Then
                Me.Location = New Point(Me.Left + e.X - X, Me.Top + e.Y - Y)
            Else
                Me.Location = New Point(Me.Left + e.X - X, 10)
            End If
        End If
    End Sub

    Private Sub header_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PnlHeader.MouseDown
        bit = True
        X = e.X
        Y = e.Y
    End Sub

    Private Sub header_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PnlHeader.MouseUp
        bit = False
    End Sub
End Class
Public Enum ReportOptions
    None = 0
    SocialeconomicStudy = 1
    AssignedEquipment = 2
End Enum