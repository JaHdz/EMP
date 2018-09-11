Imports Microsoft.Reporting.WinForms

Public Class Reportes
    Public ReportOption As Integer
    Public Emp As Integer
    Public User As String
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RvReports.Reset()
        RvReports.ProcessingMode = ProcessingMode.Local

        Select Case ReportOption
            Case ReportOptions.SocialeconomicStudy
                RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EstudioSocioeconomico.rdlc"
                RvReports.LocalReport.DataSources.Clear()
                Dim INFO As DataTable = New Cls_ES().GetInfo(Emp)
                Dim SESID = INFO.Rows(0).Item(0).ToString()
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_INFO", INFO))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_REFERENCES", New Cls_ES().GetReferences(SESID)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_FAMILY", New Cls_ES().GetFamily(Emp)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_OTHERINCOMES", New Cls_ES().GetOtherIncomes(SESID)))
            Case ReportOptions.AssignedEquipment

                RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EquipoEntregado.rdlc"
                RvReports.LocalReport.DataSources.Clear()
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("ASSIGNED_EQUIPMENT", New Cls_Emp().GetAssignedEquipment(Emp)))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("RECEIVER", New Cls_Emp().GetEquipmentReceiver(0, User)))

        End Select
        RvReports.RefreshReport()
    End Sub
End Class
Public Enum ReportOptions
    None = 0
    SocialeconomicStudy = 1
    AssignedEquipment = 2
End Enum