Imports Microsoft.Reporting.WinForms

Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RvReports.Reset()
        RvReports.ProcessingMode = ProcessingMode.Local

        RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EstudioSocioeconomico.rdlc"
        RvReports.LocalReport.DataSources.Clear()
        Dim INFO As DataTable = New Cls_ES().GetInfo(1)
        Dim SESID = INFO.Rows(0).Item(0).ToString()

        RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_INFO", INFO))
        RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_REFERENCES", New Cls_ES().GetReferences(SESID)))
        RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_FAMILY", New Cls_ES().GetFamily(1)))
        RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_OTHERINCOMES", New Cls_ES().GetOtherIncomes(SESID)))
        RvReports.RefreshReport()

    End Sub
End Class