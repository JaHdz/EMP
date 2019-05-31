Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class EquipoAsignado
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    Public Property Equipo As New Integer
    Public Property Empleado As New Integer
    Public Property Fecha As Date = Now()
    Public Property Regreso As Boolean = True
    Public Property FechaDeRetorno As Date = Now()
    Public Property Comentario As String = String.Empty
    <Browsable(False)>
    Public Property Usuario As New Integer
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal lsEquipo As String, ByVal lsEmpleado As String, ByVal ldFecha As Date, ByVal lbRegreso As Boolean,
                   ByVal ldFechaDeRetorno As Date, ByVal lsComentario As String, ByVal liUsuario As Integer?)
        ID = liID
        If String.IsNullOrWhiteSpace(lsEquipo) OrElse Not IsNumeric(lsEquipo) Then
            lsEquipo = 0
        End If
        Equipo = lsEquipo
        If String.IsNullOrWhiteSpace(lsEmpleado) OrElse Not IsNumeric(lsEmpleado) Then
            lsEmpleado = 0
        End If
        Empleado = lsEmpleado
        Fecha = ldFecha
        Regreso = lbRegreso
        FechaDeRetorno = ldFechaDeRetorno
        Comentario = lsComentario
        Usuario = liUsuario
    End Sub

    Public Function CargarListado(Optional FiltrarEmpleado As Integer = 0, Optional FiltrarActivo As Boolean = False) As List(Of Vista)
        Dim Result As New List(Of Vista)
        Dim listado As New List(Of EquipoAsignado)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EQUIPMENT_ASSIGNED", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ASSIGNED", ID))
            cmd.Parameters.Add(New SqlParameter("@EQUIPMENT", Equipo))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
            cmd.Parameters.Add(New SqlParameter("@ISRETURNED", Regreso))
            cmd.Parameters.Add(New SqlParameter("@DATE_R", FechaDeRetorno))
            cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loEvaluacionDeEmpleado As New EquipoAsignado(Reader("ID"), Reader("EQUIPO"), Reader("EMPLEADO"), Reader("FECHA"), Reader("REGRESO"), Reader("FECHA_R"),
                                                                     Reader("COMENTARIO"), Reader("USUARIO"))
                    listado.Add(loEvaluacionDeEmpleado)
                End While
            End Using
        End Using
        If FiltrarEmpleado <> 0 Then
            Result = New Vista().GenerarVista(listado.FindAll(Function(X) X.Empleado = FiltrarEmpleado))
        Else
            Result = New Vista().GenerarVista(listado)
        End If
        If FiltrarActivo = True Then
            Result = Result.FindAll(Function(X) X.Regreso = False)
        End If

        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Equipo <> 0 AndAlso Empleado <> 0 Then
            If Not VerificarExistencia(Listado) Then
                If Not String.IsNullOrWhiteSpace(Comentario) Then
                    Using con As New SqlConnection(ConnectionString())
                        con.Open()
                        Dim cmd As New SqlCommand("UDSP_EQUIPMENT_ASSIGNED", con) With {.CommandType = CommandType.StoredProcedure}
                        cmd.Parameters.Add(New SqlParameter("@ASSIGNED", ID))
                        cmd.Parameters.Add(New SqlParameter("@EQUIPMENT", Equipo))
                        cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                        cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
                        cmd.Parameters.Add(New SqlParameter("@ISRETURNED", Regreso))
                        cmd.Parameters.Add(New SqlParameter("@DATE_R", FechaDeRetorno))
                        cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
                        cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
                        cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                If reader("RESULT") = True Then
                                    Result = True
                                    Listado = CargarListado(Empleado, True)
                                Else
                                    Mensaje = "Esta equipo ya esta asignado a otro empleado."
                                    Encabezado = "Error al asignar equipo"
                                    IconoDeMensaje = MessageBoxIcon.Hand
                                End If
                            End If
                        End Using
                    End Using
                Else
                    Mensaje = "Debes escribir las condiciones en las que entregas el equipo."
                    Encabezado = "Error al asignar equipo"
                    IconoDeMensaje = MessageBoxIcon.Hand
                End If
            Else
                Mensaje = "Este equipo ya ha sido asignado a este empleado."
                Encabezado = "Error al asignar equipo"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error al asignar equipo"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If

        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Actualizar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EQUIPMENT_ASSIGNED", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ASSIGNED", ID))
            cmd.Parameters.Add(New SqlParameter("@EQUIPMENT", Equipo))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@DATE", Fecha))
            cmd.Parameters.Add(New SqlParameter("@ISRETURNED", Regreso))
            cmd.Parameters.Add(New SqlParameter("@DATE_R", FechaDeRetorno))
            cmd.Parameters.Add(New SqlParameter("@COMMENT", Comentario))
            cmd.Parameters.Add(New SqlParameter("@USER", Usuario))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Actualizar))
            cmd.ExecuteNonQuery()
            Result = True
            Listado = CargarListado(Empleado, True)
        End Using
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.EquipoID = Equipo And Regreso <> True)
        Return Result
    End Function
#End Region

    Public Class Vista
#Region "Propiedades"
        <Browsable(False)>
        Public Property ID As Integer
        <Browsable(False)>
        Public Property EquipoID As Integer
        Public Property Equipo As String
        Public Property Empleado As Integer
        Public Property Fecha As Date
        Public Property Regreso As Boolean
        Public Property FechaDeRetorno As String
        Public Property Comentario As String
        <Browsable(False)>
        Public Property Usuario As Integer

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal EquipoEmp As EquipoAsignado)
            With EquipoEmp
                ID = .ID
                Dim loEquipo = New Equipo().Buscar(.Equipo)
                Equipo = loEquipo.Nombre + " : " + loEquipo.Descripcion
                Empleado = .Empleado
                Fecha = .Fecha
                Regreso = .Regreso
                If EquipoEmp.FechaDeRetorno = "1753-01-01" Then
                    FechaDeRetorno = "N/A"
                Else
                    FechaDeRetorno = .FechaDeRetorno.ToShortDateString()
                End If
                Comentario = .Comentario
                Usuario = .Usuario
            End With
        End Sub

        Public Function GenerarVista(ByVal Listado As List(Of EquipoAsignado)) As List(Of Vista)
            Dim Resultado As New List(Of Vista)
            For Each Eval In Listado
                Resultado.Add(New Vista(Eval))
            Next
            Return Resultado
        End Function
#End Region
    End Class
End Class

