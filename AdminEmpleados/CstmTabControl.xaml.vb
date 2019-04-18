Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input

Public Class CstmTabControl
    Public Property ParentForm() As Principal
    Public Property RedirectToForm() As Form
    Public Property Dictionary As Dictionary(Of Integer, Form)
    Private CurrentOption As Tab
    Private Enum Tab
        None = 0
        Empleados = 1
        Equipos = 2
        Capacitaciones = 3
        Evaluaciones = 4
        ExamenesMedicos = 5
        Administracion = 6
        CerrarSesion = 7
    End Enum

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(ByVal frmList As Dictionary(Of Integer, Form))
        MyClass.New()
        Dictionary = frmList
        LoadTabs()
    End Sub

    Private Sub LoadTabs()
        If Dictionary IsNot Nothing Then
            For Each kvp As KeyValuePair(Of Integer, Form) In Dictionary
                Dim Name As Integer = kvp.Key
                Dim Frm As Form = kvp.Value
                Select Case Name
                    Case Tab.Empleados
                        wfhEmpleados.Child = Frm
                    Case Tab.Equipos
                        wfhEquipos.Child = Frm
                    Case Tab.Capacitaciones
                        wfhCapacitaciones.Child = Frm
                    Case Tab.Evaluaciones
                        wfhEvaluaciones.Child = Frm
                    Case Tab.ExamenesMedicos
                        wfhExamenes.Child = Frm
                    Case Tab.Administracion
                        wfhAdministracion.Child = Frm
                End Select
                Frm.Show()
            Next
        End If
    End Sub
    Private Sub UserControl_Initialized(sender As Object, e As EventArgs)
        TabMenu.SelectedIndex = Tab.Empleados
        CurrentOption = Tab.Empleados
    End Sub


    Private Sub TabMenu_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles TabMenu.SelectionChanged
        Dim selectedtab = TabMenu.SelectedIndex
        If selectedtab <> CurrentOption Then
            If selectedtab <> Tab.None Then
                If selectedtab <> Tab.CerrarSesion Then
                    CurrentOption = selectedtab
                Else
                    TabMenu.SelectedIndex = CurrentOption
                    CurrentOption = TabMenu.SelectedIndex
                End If
            End If
        End If
    End Sub

    Private Sub Logout_Click(sender As Object, e As MouseButtonEventArgs)
        If MessageBox.Show("¿Desea cerrar sesion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            If RedirectToForm IsNot Nothing AndAlso RedirectToForm IsNot Nothing Then
                RedirectToForm.Show()
                ParentForm.ObLogout = True
                ParentForm.Close()
            End If
        End If
    End Sub

End Class
