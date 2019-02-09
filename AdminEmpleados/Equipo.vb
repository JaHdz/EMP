Public Class Equipo

    Dim objcon As New Consultas
    Dim V1 As String
    Dim V2 As String
    Dim NEmp As Integer
    Dim NName As String
    Sub New(ByVal emp As Integer, name As String)
        InitializeComponent()
        NEmp = emp
        NName = name
    End Sub
    Public Sub llenar_buscador(tipo As String)
        Dim popup As New frmPopUp(tipo)
        Dim dialogresult__1 As DialogResult = popup.ShowDialog()
        V1 = popup.Variable
        V2 = popup.Variable2
        popup.Close()
    End Sub
    Private Sub txt_numero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txt_numero_Leave(sender As Object, e As EventArgs) Handles txt_numero.Leave
        pnl_comen.Visible = False
        If (txt_numero.Text <> "") Then
            NEmp = objcon.Emp_Exist(txt_numero.Text)
            If (NEmp = 1) Then
                Dim ldParameters As New Dictionary(Of String, Object) From {{"EmployeeNumber", txt_numero.Text}}
                Dim Wait As New Wait With {
                .Parameters = ldParameters,
                .Operation = BackgroundOperations.GetEmployeeInfo
            }
                Wait.ShowDialog()
                Dim Result As Cls_Emp = Wait.Result
                Wait.Close()
                lbl_emp.Text = txt_numero.Text + " | " + Result.Emp_Name + " " + Result.Emp_APat + " " + Result.Emp_AMat
                dgv_equipo_emp.DataSource = objcon.Consulta_EAsignado(txt_numero.Text)
            Else
                MessageBox.Show("Numero de empleado no existe")
                txt_numero.Text = ""
                lbl_emp.Text = ""
            End If
        End If
    End Sub

    Private Sub buscar_EN_Click(sender As Object, e As EventArgs) Handles buscar_EN.Click
        llenar_buscador("EMP")
        If (V1 <> "" And V2 <> "") Then
            txt_numero.Focus()
        Else
            txt_numero.Focus()
        End If
        txt_numero.Text = V1
    End Sub

    Private Sub Eq_Leave(sender As Object, e As EventArgs) Handles Eq.Leave
        If (Eq.Text <> "") Then
            V2 = objcon.S_catalago(Eq.Text, "EQ")
            If (V2 = "" Or V2 Is Nothing) Then
                MessageBox.Show("No existe")
                Eq.Text = ""
                Eq.Focus()
            Else
                eq2.Text = V2
            End If
        End If
    End Sub

    Private Sub buscar_eq_Click(sender As Object, e As EventArgs) Handles buscar_eq.Click
        llenar_buscador("EQ")
        If (V1 <> "" And V2 <> "") Then
            Eq.Focus()
        Else
            Eq.Focus()
        End If
        Eq.Text = V1
        eq2.Text = V2
    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If (Eq.Text <> "" Or txt_numero.Text <> "") Then
            If objcon.Add_EQUIPMENT_ASSIGNED(0, Eq.Text, txt_numero.Text, TXT_FECHA.Text, 0, "01/01/1900", NEmp, TXT_commen.Text) = True Then
            Else
                MessageBox.Show("Este registro ya Existe.")
            End If
            dgv_equipo_emp.DataSource = objcon.Consulta_EAsignado(txt_numero.Text)
            txt_numero.Text = ""
            Eq.Text = ""
            eq2.Text = ""
            TXT_FECHA.Text = ""
            TXT_commen.Text = ""
            lbl_emp.Text = ""
            txt_numero.Focus()
            MessageBox.Show("Debe ingresar un numero de empleado valido y un equipo.")
            pnl_comen.Visible = False
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

    Private Sub Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_FECHA.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub dgv_equipo_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipo_emp.CellClick
        Dim Id As Integer
        Dim gr As New DataGridView
        gr = sender
        If e.RowIndex <> -1 Then
            Select Case e.ColumnIndex
                Case Is > -1
                    Select Case gr.Columns(e.ColumnIndex).Name
                        Case "UPDATE"
                            If MessageBox.Show("Seguro que desea regresar el equipo?", "Regresar Equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Id = dgv_equipo_emp.Rows(e.RowIndex).Cells(3).Value
                                If dgv_equipo_emp.Rows(e.RowIndex).Cells(5).Value.ToString = "False" Then
                                    If objcon.Add_EQUIPMENT_ASSIGNED(dgv_equipo_emp.Rows(e.RowIndex).Cells(1).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(2).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(3).Value, dgv_equipo_emp.Rows(e.RowIndex).Cells(4).Value, True, Date.Now, dgv_equipo_emp.Rows(e.RowIndex).Cells(8).Value, TXT_commen.Text) = True Then
                                    Else
                                        MessageBox.Show("Este registro ya Existe.")
                                    End If
                                End If
                            End If
                    End Select
            End Select
            Dim dt As New DataTable
            If txt_numero.Text <> "" Then
                dt = objcon.Consulta_EAsignado(txt_numero.Text)
            Else
                dt = objcon.Consulta_EAsignado(Id)
            End If
            dgv_equipo_emp.DataSource = dt
        End If
    End Sub

    Private Sub pb_Report_Click(sender As Object, e As EventArgs) Handles pb_Report.Click
        If txt_numero.Text <> "" Then
            If TXT_commen.Visible = True Then
                If TXT_commen.Text = "" Then
                Else
                    objcon.Add_commen(txt_numero.Text, TXT_commen.Text)
                End If
                Dim Wait As New Wait()
                Wait.Operation = BackgroundOperations.JustShowScreen
                Wait.ShowDialog()
                Dim Reportes As New Reportes With {
                    .ReportOption = ReportOptions.AssignedEquipment,
                    .Emp = Convert.ToInt64(txt_numero.Text),
                    .User = NName
                }
                Reportes.ShowDialog()
            Else
                TXT_commen.Visible = True
                MessageBox.Show("Ingrese un commentario.")
            End If
        End If
    End Sub
End Class