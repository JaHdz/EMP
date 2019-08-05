Imports System.Text.RegularExpressions

Public Class NumericTextbox
    Inherits TextBox
    Private _AcceptsDecimals As Boolean = False

    Public Property AcceptsDecimals() As Boolean
        Get
            Return _AcceptsDecimals
        End Get
        Set
            _AcceptsDecimals = Value
        End Set
    End Property

    Private Sub Control_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        e.Handled = If(AcceptsDecimals,
            If(Not Text.Contains("."),
                Not (IsNumeric(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar),
                Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)),
            Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar))
    End Sub
End Class
