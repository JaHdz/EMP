Imports Microsoft.Reporting.WinForms

Public Class FrmReportes
    Private bit As Boolean
    Private X As Integer
    Private Y As Integer
    Private liOpcion As ReportOptions
    Private loParametros As Dictionary(Of String, Object)
    Public Sub New(ByVal Parametros As Dictionary(Of String, Object), ByVal Opcion As ReportOptions)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loParametros = Parametros
        liOpcion = Opcion
    End Sub
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RvReports.Reset()
        RvReports.ProcessingMode = ProcessingMode.Local

        Select Case liOpcion
            Case ReportOptions.SocialeconomicStudy
                'Lbl_Title.Text = "Reporte de Estudio Socioeconomico"
                'RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EstudioSocioeconomico.rdlc"
                'RvReports.LocalReport.DataSources.Clear()
                'Dim INFO As DataTable = New Cls_ES().GetInfo(Empleado.ID)
                'Dim SESID = INFO.Rows(0).Item(0).ToString()
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_INFO", INFO))
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_REFERENCES", New Cls_ES().GetReferences(SESID)))
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_FAMILY", New Cls_ES().GetFamily(Empleado.ID)))
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("SES_OTHERINCOMES", New Cls_ES().GetOtherIncomes(SESID)))
            Case ReportOptions.AssignedEquipment
                Lbl_Title.Text = "Reporte de Equipo Entregado"
                'RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EquipoEntregado.rdlc"
                'RvReports.LocalReport.DataSources.Clear()
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("ASSIGNED_EQUIPMENT", New Cls_Emp().GetAssignedEquipment(Empleado.ID)))
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("RECEIVER", New Cls_Emp().GetEquipmentReceiver(UsuarioLogeado.ID, UsuarioLogeado.Nombre)))
                Dim llEmpleado As New List(Of Empleado) From {CType(loParametros("Empleado"), Empleado)}

                RvReports.LocalReport.ReportEmbeddedResource = "AdminEmpleados.EquipoAsignado.rdlc"
                RvReports.LocalReport.DataSources.Clear()

                RvReports.LocalReport.DataSources.Add(New ReportDataSource("Empleado", llEmpleado))
                RvReports.LocalReport.DataSources.Add(New ReportDataSource("Equipo", loParametros("Equipo")))
                'RvReports.LocalReport.DataSources.Add(New ReportDataSource("USUARIO", UsuarioLogeado))
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
