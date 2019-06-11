Imports System.Data.SqlClient

Public Class Enfermedad
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Empleado As New Integer
    Public Property Nombre As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lsNombre As String)
        ID = liID
        Empleado = liEmpleado
        Nombre = lsNombre
    End Sub

    Public Function CargarListado(Empleado As Integer) As List(Of Enfermedad)
        Dim Result As New List(Of Enfermedad)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_MEDCONDITIONS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Nombre))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEnfermedad As New Enfermedad(Reader("ID"), Reader("EMPLEADO"), Reader("ENFERMEDAD"))
                    Result.Add(loEnfermedad)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function Registrar(Listado As List(Of Enfermedad)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        If Not CamposEnBlanco() Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_MEDCONDITIONS", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Nombre))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(Empleado)
                End Using
            Else
                Mensaje = "Esta enfermedad ya fue registrada para este empleado"
            End If
        Else
            Mensaje = "Debe llenar los campos antes de continuar"
        End If
        If Mensaje IsNot String.Empty Then
            MessageBox.Show(Mensaje, "Error al registrar Enfermedad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of Enfermedad)) As Boolean
        Dim Result As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminar este contacto?", "Eliminar Contacto",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_MEDCONDITIONS", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                cmd.Parameters.Add(New SqlParameter("@DESCRIPTION", Nombre))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(Empleado)
            End Using
        End If
        Return Result
    End Function

    Private Function CamposEnBlanco() As Boolean
        If Empleado = 0 OrElse String.IsNullOrWhiteSpace(Nombre) Then
            Return True
        End If
        Return False
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Enfermedad)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Nombre = Nombre)
        Return Result
    End Function
#End Region
End Class

