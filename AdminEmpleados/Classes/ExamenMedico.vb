Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ExamenMedico
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property Empleado As New Integer?
    Public Property Estudio As String = String.Empty
    Public Property Resultado As String = String.Empty
    Public Property Fecha As New Date?
    Public Property FechaProxima As New Date?
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lsEstudio As String, ByVal lsResultado As String, ByVal ldFecha As Date?, ByVal ldFechaProxima As DateTime?)
        ID = liID
        Empleado = liEmpleado
        Estudio = lsEstudio
        Resultado = lsResultado
        Fecha = ldFecha
        FechaProxima = ldFechaProxima
    End Sub

    Public Function CargarListado(Optional FiltrarEmpleado As Integer = 0) As List(Of ExamenMedico)
        Dim Result As New List(Of ExamenMedico)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EXAMENES_MED", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@ESTUDIO", Estudio))
            cmd.Parameters.Add(New SqlParameter("@RESULTADO", Resultado))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.Parameters.Add(New SqlParameter("@FECHAPROXIMO", FechaProxima))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loExamenMedico As New ExamenMedico(Reader("ID"), Reader("EMPLEADO"), Reader("ESTUDIO"), Reader("RESULTADO"), Reader("FECHA"), Reader("FECHAPROXIMO"))
                    Result.Add(loExamenMedico)
                End While
            End Using
        End Using
        If FiltrarEmpleado <> 0 Then
            Result = Result.FindAll(Function(X) X.Empleado = FiltrarEmpleado)
        End If
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of ExamenMedico)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not String.IsNullOrWhiteSpace(Empleado) AndAlso Not String.IsNullOrWhiteSpace(Estudio) AndAlso Not String.IsNullOrWhiteSpace(Resultado) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EXAMENES_MED", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                cmd.Parameters.Add(New SqlParameter("@ESTUDIO", Estudio))
                cmd.Parameters.Add(New SqlParameter("@RESULTADO", Resultado))
                cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
                cmd.Parameters.Add(New SqlParameter("@FECHAPROXIMO", FechaProxima))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(ID)
            End Using
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error al registrar el examen medico"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of ExamenMedico)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EXAMENES_MED", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@ESTUDIO", Estudio))
            cmd.Parameters.Add(New SqlParameter("@RESULTADO", Resultado))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.Parameters.Add(New SqlParameter("@FECHAPROXIMO", FechaProxima))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(ID)
        End Using
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of ExamenMedico)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EXAMENES_MED", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@ESTUDIO", Estudio))
            cmd.Parameters.Add(New SqlParameter("@RESULTADO", Resultado))
            cmd.Parameters.Add(New SqlParameter("@FECHA", Fecha))
            cmd.Parameters.Add(New SqlParameter("@FECHAPROXIMO", FechaProxima))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(ID)
        End Using
        Return Result
    End Function
#End Region
End Class

