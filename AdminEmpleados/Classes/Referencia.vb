Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Referencia
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property EstudioSocioeconomico As New Integer
    Public Property Nombre As String = String.Empty
    Public Property Ocupacion As String = String.Empty
    Public Property TipoDeRelacion As String = String.Empty
    Public Property TiempoDeConocerse As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEstudioSocioeconomico As Integer, ByVal lsNombre As String, ByVal lsOcupacion As String,
                   ByVal lsTipoDeRelacion As String, ByVal lsTiempoDeConocerse As String)
        ID = liID
        EstudioSocioeconomico = liEstudioSocioeconomico
        Nombre = lsNombre
        Ocupacion = lsOcupacion
        TipoDeRelacion = lsTipoDeRelacion
        TiempoDeConocerse = lsTiempoDeConocerse
    End Sub

    Public Function CargarListado(EstudioSocioeconomico As Integer) As List(Of Referencia)
        Dim Result As New List(Of Referencia)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_REFERENCES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@OCUPATION", Ocupacion))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", TipoDeRelacion))
            cmd.Parameters.Add(New SqlParameter("@TIME", TiempoDeConocerse))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loReferencia As New Referencia(Reader("ID"), Reader("ES"), Reader("NAME"), Reader("OCU"), Reader("TDR"), Reader("TDC"))
                    Result.Add(loReferencia)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function Registrar() As Boolean
        Dim Result = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_REFERENCES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@OCUPATION", Ocupacion))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", TipoDeRelacion))
            cmd.Parameters.Add(New SqlParameter("@TIME", TiempoDeConocerse))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function

    Public Function Eliminar() As Boolean
        Dim Result = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_REFERENCES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@OCUPATION", Ocupacion))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", TipoDeRelacion))
            cmd.Parameters.Add(New SqlParameter("@TIME", TiempoDeConocerse))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function

    Public Function RegistrarLocal(ByRef Listado As List(Of Referencia)) As Boolean
        Dim Resultado As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not CamposEnBlanco() Then
            If Not VerificarExistencia(Listado) Then
                Listado.Add(Me)
                Resultado = True
            Else
                Mensaje = "Este registro ya se encuentra en la lista."
                Encabezado = "Error de registro de Referencia"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de Referencia"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Resultado
    End Function
    Public Function EliminarLocal(ByRef Listado As List(Of Referencia)) As Boolean
        Dim Resultado As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminarlo?", "Eliminar Referencia",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Listado.Remove(Me)
            Resultado = True
        End If
        Return Resultado
    End Function

    Private Function CamposEnBlanco() As Boolean
        If String.IsNullOrWhiteSpace(Nombre) OrElse String.IsNullOrWhiteSpace(Ocupacion) OrElse String.IsNullOrWhiteSpace(TipoDeRelacion) OrElse
           String.IsNullOrWhiteSpace(TiempoDeConocerse) Then
            Return True
        End If
        Return False
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Referencia)) As Boolean
        If Listado Is Nothing Then
            Listado = New List(Of Referencia)
            Return False
        End If
        Dim Result As Boolean = Listado.Any(Function(X) X.Nombre = Nombre)
        Return Result
    End Function
#End Region
End Class

