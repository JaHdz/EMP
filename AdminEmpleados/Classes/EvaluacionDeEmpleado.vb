Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EvaluacionDeEmpleado
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property Evaluacion As New Integer
    Public Property Empleado As New Integer
    Public Property Fecha As New Date
    Public Property Comentario As String = String.Empty
    Public Property Usuario As New Integer
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID_EvEmp As String, ByVal liEvaluacion As String, ByVal liEmpleado As String, ByVal lDFecha As Date?, ByVal lsComentario As String, liUsuario As Integer)
        ID = liID_EvEmp
        If String.IsNullOrEmpty(liEvaluacion) Then
            liEvaluacion = 0
        End If
        Evaluacion = liEvaluacion
        If String.IsNullOrWhiteSpace(liEmpleado) Then
            liEmpleado = 0
        End If
        Empleado = liEmpleado
        Fecha = lDFecha
        Comentario = lsComentario
        Usuario = liEmpleado
    End Sub

    Public Function CargarListado(Optional FiltrarEmpleado As Integer = 0) As List(Of EvaluacionEmpleadoVista)
        Dim Result As New List(Of EvaluacionEmpleadoVista)
        Dim listado As New List(Of EvaluacionDeEmpleado)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_EVALUATION", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EVALUACION", Evaluacion))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEvaluacionDeEmpleado As New EvaluacionDeEmpleado(Reader("ID"), Reader("EVALUACION"), Reader("EMPLEADO"), Reader("FECHA"), Reader("COMENTARIOS"), Reader("USUARIO"))
                    listado.Add(loEvaluacionDeEmpleado)
                End While
            End Using
        End Using

        Result = New EvaluacionEmpleadoVista().GenerarVista(listado.FindAll(Function(X) X.Empleado = FiltrarEmpleado))
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of EvaluacionEmpleadoVista)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Evaluacion <> 0 AndAlso Empleado <> 0 Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_EVALUATION", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@EVALUACION", Evaluacion))
                    cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
                    cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
                    cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(Empleado)
                End Using
            Else
                Mensaje = "Esta evaluacion ya ha sido aplicada para este empleado."
                Encabezado = "Error al registrar le evaluacion"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error al registrar le evaluacion"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of EvaluacionEmpleadoVista)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_EVALUATION", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EVALUACION", Evaluacion))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(Empleado)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of EvaluacionEmpleadoVista)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Evaluacion = Evaluacion)
        Return Result
    End Function
#End Region
    Public Class EvaluacionEmpleadoVista
#Region "Propiedades"
        <Browsable(False)>
        Public Property ID As Integer
        Public Property Evaluacion As String
        <Browsable(False)>
        Public Property Empleado As Integer
        Public Property Fecha As Date
        Public Property Comentario As String

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal EvalEmp As EvaluacionDeEmpleado)
            ID = EvalEmp.ID
            Dim loEvaluacion = New Evaluacion().Buscar(EvalEmp.Evaluacion.ToString())
            Evaluacion = loEvaluacion.Codigo + " : " + loEvaluacion.Descripcion
            Empleado = EvalEmp.Empleado
            Fecha = EvalEmp.Fecha
            Comentario = EvalEmp.Comentario
        End Sub

        Public Function GenerarVista(ByVal Listado As List(Of EvaluacionDeEmpleado)) As List(Of EvaluacionEmpleadoVista)
            Dim Resultado As New List(Of EvaluacionEmpleadoVista)
            For Each Eval In Listado
                Resultado.Add(New EvaluacionEmpleadoVista(Eval))
            Next
            Return Resultado
        End Function
#End Region
    End Class
End Class

