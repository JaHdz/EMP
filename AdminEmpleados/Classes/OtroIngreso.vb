Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class OtroIngreso
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property EstudioSocioeconomico As New Integer
    Public Property Parentesco As String = String.Empty
    Public Property Monto As New Decimal
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEstudioSocioeconomico As Integer, ByVal lsParentesco As String, ByVal ldMonto As String)
        ID = liID
        EstudioSocioeconomico = liEstudioSocioeconomico
        Parentesco = lsParentesco
        If String.IsNullOrWhiteSpace(ldMonto) Then
            ldMonto = 0
        End If
        Monto = CType(ldMonto, Decimal)
    End Sub

    Public Function CargarListado(piEstudioSocioeconomico As Integer) As List(Of OtroIngreso)
        Dim Result As New List(Of OtroIngreso)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_OTHER_INCOMES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", piEstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@DESC", Parentesco))
            cmd.Parameters.Add(New SqlParameter("@AMOUNT", Monto))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loOtroIngreso As New OtroIngreso(Reader("ID"), Reader("ES"), Reader("DESCR"), Reader("CANT"))
                    Result.Add(loOtroIngreso)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function Registrar() As Boolean
        Dim Result = False
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_SES_OTHER_INCOMES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@DESC", Parentesco))
            cmd.Parameters.Add(New SqlParameter("@AMOUNT", Monto))
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
            Dim cmd As New SqlCommand("UDSP_SES_OTHER_INCOMES", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@SES_ID", EstudioSocioeconomico))
            cmd.Parameters.Add(New SqlParameter("@DESC", Parentesco))
            cmd.Parameters.Add(New SqlParameter("@AMOUNT", Monto))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
            cmd.ExecuteNonQuery()
            Result = True
        End Using
        Return Result
    End Function

    Public Function RegistrarLocal(ByRef Listado As List(Of OtroIngreso)) As Boolean
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
                Encabezado = "Error de registro de Otros Ingresos"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de Otros Ingresos"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Resultado
    End Function

    Public Function EliminarLocal(ByRef Listado As List(Of OtroIngreso)) As Boolean
        Dim Resultado As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminarlo?", "Eliminar Otro Ingreso",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Listado.Remove(Me)
            Resultado = True
        End If
        Return Resultado
    End Function

    Private Function CamposEnBlanco() As Boolean
        If String.IsNullOrWhiteSpace(Parentesco) OrElse Monto = 0 Then
            Return True
        End If
        Return False
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of OtroIngreso)) As Boolean
        If Listado Is Nothing Then
            Listado = New List(Of OtroIngreso)
            Return False
        End If
        Dim Result As Boolean = Listado.Any(Function(X) X.Parentesco = Parentesco)
        Return Result
    End Function
#End Region

End Class

