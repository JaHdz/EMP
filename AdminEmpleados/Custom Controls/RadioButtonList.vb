Public Class RadioButtonList
    Private Ignore As Boolean
    Private _SelectedValue As String = String.Empty
    Public Property ListOfItems As String() = New String() {}

    Public Property SelectedValue As String
        Get
            Return _SelectedValue
        End Get
        Set(ByVal Value As String)
            If _SelectedValue <> Value Then
                Ignore = True
                _SelectedValue = Value
                CheckRadios()
                Ignore = False
            End If
        End Set
    End Property

    Public Overrides Sub ResetText()
        MyBase.ResetText()
        SelectedValue = String.Empty
    End Sub

    Private Sub CheckRadios()
        If ListOfItems.Count > 0 Then
            If _SelectedValue = "" Then
                Reset()
            Else
                Assign()
            End If
        End If
    End Sub

    Private Sub Assign()
        If ListOfItems.Count > 0 Then
            For Each Radio As RadioButton In Controls
                If Radio.Text = _SelectedValue Then
                    Radio.Checked = True
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Reset()
        If ListOfItems.Count > 0 Then
            For Each Radio As RadioButton In Controls
                Radio.Checked = False
            Next
        End If
    End Sub

    Private Sub GenerateDisplayOptions()
        Dim AxisX As Integer = 37
        Dim AxisY As Integer = 0
        For Each Value As String In ListOfItems
            Dim Radio As New RadioButton With {
                .Name = "rbli" + (Value.Substring(0, 1).ToUpper + Value.Substring(1).ToLower()).Replace(" ", ""),
                .Text = Value,
                .AutoSize = True,
                .Padding = New Padding(3, 0, 3, 0),
                .Location = New Point(AxisX, AxisY)
            }
            AddHandler Radio.CheckedChanged, AddressOf Rbtn_CheckedChanged
            Using Cg As Graphics = CreateGraphics()
                Dim size As SizeF = Cg.MeasureString(Radio.Text, Font)
                Dim spacing = size.Width + 25
                If AxisX + spacing >= Me.Width Then
                    AxisX = 37
                    AxisY = AxisY + size.Height + 3
                    Radio.Location = New Point(AxisX, AxisY)
                End If
                AxisX = AxisX + spacing
            End Using
            Me.Controls.Add(Radio)
        Next
    End Sub

    Private Sub Rbtn_CheckedChanged(sender As Object, e As EventArgs)
        If Ignore Then Exit Sub
        SelectedValue = CType(sender, RadioButton).Text
    End Sub

    Private Sub RadioButtonList_Load(sender As Object, e As EventArgs) Handles Me.Load
        GenerateDisplayOptions()
    End Sub
End Class
