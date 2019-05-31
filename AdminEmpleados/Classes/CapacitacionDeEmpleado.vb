Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class CapacitacionDeEmpleado
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property Capacitacion As New Integer
    Public Property Empleado As New Integer
    Public Property Fecha As New Date
    Public Property Comentario As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liCapacitacion As String, ByVal liEmpleado As String, ByVal ldFecha As Date, ByVal lsComentario As String)
        ID = liID
        If String.IsNullOrWhiteSpace(liCapacitacion) Then
            liCapacitacion = 0
        End If
        Capacitacion = liCapacitacion
        If String.IsNullOrWhiteSpace(liEmpleado) Then
            liEmpleado = 0
        End If
        Empleado = liEmpleado
        Fecha = ldFecha
        Comentario = lsComentario
    End Sub

    Public Function CargarListado(Optional FiltrarEmpleado As Integer = 0) As List(Of Vista)
        Dim Result As New List(Of Vista)
        Dim listado As New List(Of CapacitacionDeEmpleado)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TRAINING", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@TRAINING", Capacitacion))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
            cmd.Parameters.Add(New SqlParameter("@COMENTARIO", Comentario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEvaluacionDeEmpleado As New CapacitacionDeEmpleado(Reader("ID"), Reader("CAPACITACION"), Reader("EMPLEADO"), Reader("FECHA"), Reader("COMENTARIO"))
                    listado.Add(loEvaluacionDeEmpleado)
                End While
            End Using
        End Using

        Result = New Vista().GenerarVista(listado.FindAll(Function(X) X.Empleado = FiltrarEmpleado))
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Capacitacion <> 0 AndAlso Empleado <> 0 Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TRAINING", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@TRAINING", Capacitacion))
                    cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
                    cmd.Parameters.Add(New SqlParameter("@COMENTARIO", Comentario))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(Empleado)
                End Using
            Else
                Mensaje = "Esta capacitacion ya ha sido aplicada para este empleado."
                Encabezado = "Error al registrar le capacitacion"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error al registrar le capacitacion"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_TRAINING", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@TRAINING", Capacitacion))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
            cmd.Parameters.Add(New SqlParameter("@COMENTARIO", Comentario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(Empleado)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Capacitacion = Capacitacion)
        Return Result
    End Function
#End Region
    Public Class Vista
#Region "Propiedades"
        <Browsable(False)>
        Public Property ID As Integer
        Public Property Capacitacion As String
        <Browsable(False)>
        Public Property Empleado As Integer
        Public Property Fecha As Date
        Public Property Comentario As String

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal CapEmp As CapacitacionDeEmpleado)
            ID = CapEmp.ID
            Dim loCapacitacion = New Capacitacion().Buscar(CapEmp.ID.ToString())
            Capacitacion = loCapacitacion.Codigo + " : " + loCapacitacion.Descripcion
            Empleado = CapEmp.Empleado
            Fecha = CapEmp.Fecha
            Comentario = CapEmp.Comentario
        End Sub

        Public Function GenerarVista(ByVal Listado As List(Of CapacitacionDeEmpleado)) As List(Of Vista)
            Dim Resultado As New List(Of Vista)
            For Each Eval In Listado
                Resultado.Add(New Vista(Eval))
            Next
            Return Resultado
        End Function
#End Region
    End Class
End Class

