Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Supervisor
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property Empleado As New Integer
    Public Property Nombre As String = ""
    Public Property EstaActivo As Boolean = True

#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lbActivo As Boolean, ByVal lsNombre As String)
        ID = liID
        Empleado = liEmpleado
        EstaActivo = lbActivo
        Nombre = lsNombre
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of Supervisor)
        Dim Result As New List(Of Supervisor)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_SUPER", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@ID_Emp", Empleado))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loSupervisor As New Supervisor(Reader("ID_SUPER"), Reader("ID_EMP"), Reader("ACTIVO"), Reader("NAME"))
                    Result.Add(loSupervisor)
                End While
            End Using
        End Using
        If FiltrarInactivos = True Then
            Result = Result.FindAll(Function(X) X.EstaActivo = True)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Supervisor)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(Nombre) Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_SUPER", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@ID_Emp", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                    cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(True)
                End Using
            Else
                Mensaje = "Este supervisor ya se encuentra registrado en el sistema."
                Encabezado = "Error de registro de supervisor"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de supervisor"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Supervisor)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_SUPER", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@ID_Emp", Empleado))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(True)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Supervisor)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Empleado = Empleado)
        Return Result
    End Function

    Public Function Buscar(ByVal ID As String) As Supervisor
        Dim Result As Supervisor = Nothing
        If Not String.IsNullOrWhiteSpace(ID) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_SUPER", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@ID_Emp", Empleado))
                cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                cmd.Parameters.Add(New SqlParameter("@ESTATUS", EstaActivo))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New Supervisor(Reader("ID_SUPER"), Reader("ID_EMP"), Reader("ACTIVO"), Reader("NAME"))
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function
#End Region
End Class

