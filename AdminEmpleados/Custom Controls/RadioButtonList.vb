Public Class RadioButtonList
    Private Ignore As Boolean
    Private _SelectedValue As String = String.Empty
    Private _ListOfItems As String() = New String() {}

    Public Property ListOfItems As String()
        Get
            Return _ListOfItems
        End Get
        Set
            _ListOfItems = Value
            GenerateDisplayOptions()
        End Set
    End Property

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

    Public Sub GenerateDisplayOptions()
        Dim AxisX As Integer = 25
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
                AxisX = AxisX + spacing
            End Using
            Controls.Add(Radio)
        Next
    End Sub

    Private Sub Rbtn_CheckedChanged(sender As Object, e As EventArgs)
        If Ignore Then Exit Sub
        SelectedValue = CType(sender, RadioButton).Text
    End Sub
End Class
