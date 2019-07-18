Imports System.Data.SqlClient
Imports System.Transactions

Public Class ValeDeEquipo
    Public Property Encabezado As New ValeDeEquipoEncabezado
    Public Property Detalle As New List(Of ValeDeEquipoDetalle)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(pEmpleado As Integer)
        If pEmpleado <> 0 Then
            Encabezado = New ValeDeEquipoEncabezado(0, pEmpleado, UsuarioLogeado.NumeroDeEmpleado, True)
        End If
    End Sub

    Public Function CargarListado(Optional FiltrarInactivos As Boolean = False) As List(Of ValeDeEquipo)
        Dim Resultado As New List(Of ValeDeEquipo)
        Dim loLista As New List(Of ValeDeEquipo)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EQUIPMENT_VOUCHER_HEADER", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@Encabezado", ToDataTable(New List(Of ValeDeEquipoEncabezado) From {Encabezado})) With {.SqlDbType = SqlDbType.Structured})
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read
                    loLista.Add(New ValeDeEquipo With {.Encabezado = New ValeDeEquipoEncabezado(Reader("ID"), Reader("EMPLEADO"), Reader("ASIGNADOPOR"), Reader("ACTIVO")),
                                .Detalle = New List(Of ValeDeEquipoDetalle)})
                End While
            End Using
        End Using
        If loLista.Count > 0 Then
            For Each Vale As ValeDeEquipo In loLista
                Dim loDetalle As List(Of ValeDeEquipoDetalle) = New List(Of ValeDeEquipoDetalle) From {New ValeDeEquipoDetalle(0, Vale.Encabezado.ID, 0, Today, Today)}
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd = New SqlCommand("UDSP_EQUIPMENT_VOUCHER_DETAIL", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@Detalle", ToDataTable(loDetalle)) With {.SqlDbType = SqlDbType.Structured})
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Buscar))
                    Using Reader As SqlDataReader = cmd.ExecuteReader()
                        loDetalle.Clear()
                        While Reader.Read
                            loDetalle.Add(New ValeDeEquipoDetalle(Reader("DETALLEID"), Reader("VALEID"), Reader("EQUIPO"), Reader("FECHAASIGNADO"),
                                                                  Reader("FECHARETORNO")))
                        End While
                        Vale.Detalle = loDetalle
                    End Using
                End Using
            Next
            Resultado = loLista
        End If
        Return Resultado
    End Function

    Public Function Registrar() As Boolean
        Dim Result As Boolean = False
        Using transaction As New TransactionScope
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EQUIPMENT_VOUCHER_HEADER", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@Encabezado", ToDataTable(New List(Of ValeDeEquipoEncabezado) From {Encabezado})) With {.SqlDbType = SqlDbType.Structured})
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read Then
                        Encabezado.ID = Reader("ID")
                    End If
                End Using
            End Using
            For Each item As ValeDeEquipoDetalle In Detalle
                item.NumeroDeVale = Encabezado.ID
            Next
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd = New SqlCommand("UDSP_EQUIPMENT_VOUCHER_DETAIL", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@Detalle", ToDataTable(Detalle)) With {.SqlDbType = SqlDbType.Structured})
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    Dim listado As New List(Of String)
                    While Reader.Read
                        listado.Add(Reader("DESCRIP"))
                    End While
                    If listado.Count = Detalle.Count Then
                        MessageBox.Show("El equipo que desea asignar ya fué asignado a alguien más", "Equipo ya asignado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        transaction.Dispose()
                        Return Result
                    Else
                        If listado.Count > 0 Then
                            Dim msg As String = String.Concat("El equipo listado no ha podido ser asignado debido a que ya feue asignado a otro empleado", vbCr)
                            For Each Item In listado
                                msg = String.Concat(msg, vbCr, "*** ", Item)
                            Next
                            msg = String.Concat(msg, vbCr, vbCr, "El resto del equipo fue asignado correctamente al empleado ", vbCr, Encabezado.Empleado)
                            MessageBox.Show(msg, "Equipo ya asignado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                        Result = True
                        transaction.Complete()
                    End If
                End Using
            End Using
        End Using
        Return Result
    End Function

    Public Sub Buscar()


        'Encabezado.ID = ID
        'Detalle.Add(New ValeDeEquipoDetalle(0, ID, 0, Today, FechaMinima))

        'Using con As New SqlConnection(ConnectionString())
        '    con.Open()
        '    Dim cmd As New SqlCommand("UDSP_EQUIPMENT_VOUCHER_HEADER", con) With {.CommandType = CommandType.StoredProcedure}
        '    cmd.Parameters.Add(New SqlParameter("@Encabezado", ToDataTable(New List(Of ValeDeEquipoEncabezado) From {Encabezado})) With {.SqlDbType = SqlDbType.Structured})
        '    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
        '    Using Reader As SqlDataReader = cmd.ExecuteReader()
        '        If Reader.Read() Then
        '            Encabezado = New ValeDeEquipoEncabezado(Reader(""), Reader(""), Reader(""), Reader(""))
        '        End If
        '    End Using
        'End Using
    End Sub



    Public Class ValeDeEquipoEncabezado
        Public Property ID As Integer
        Public Property EmpleadoID As Integer
        Public Property Empleado As String
        Public Property AsignadoPorID As Integer
        Public Property AsignadoPor As String
        Public Property Activo As Boolean

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(pID As Integer, pEmpleado As Integer, pAsignadoPor As Integer, pActivo As Boolean)
            ID = pID
            EmpleadoID = pEmpleado
            Empleado = New Empleado().Buscar(EmpleadoID).NombreCompleto
            AsignadoPorID = pAsignadoPor
            AsignadoPor = If(AsignadoPorID = 0, "EASY System Administrator", New Empleado().Buscar(AsignadoPorID).NombreCompleto)
            Activo = pActivo
        End Sub

        Public Function Buscar(pID As Integer) As ValeDeEquipoEncabezado
            Dim Resultado As New ValeDeEquipoEncabezado

            Return Resultado
        End Function
    End Class

    Public Class ValeDeEquipoDetalle
        Public Property ID As Integer
        Public Property NumeroDeVale As Integer
        Public Property EquipoID As Integer
        Public Property Equipo As String
        Public Property FechaAsignado As Date
        Public Property FechaRetorno As Date

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(pID As Integer, pNumeroDeVale As Integer, pEquipo As Integer, pFechaAsignado As Date, pFechaRetorno As Date)
            ID = pID
            NumeroDeVale = pNumeroDeVale
            EquipoID = pEquipo
            Dim loEquipo = New Equipo().Buscar(pEquipo)
            With loEquipo
                If loEquipo IsNot Nothing Then
                    Equipo = String.Concat("(", String.Format("{0:D4}", EquipoID), ") ", .Nombre, ": ", .Descripcion)
                End If
            End With
            FechaAsignado = pFechaAsignado
            FechaRetorno = pFechaRetorno

        End Sub

        Public Function Buscar(pID As Integer) As List(Of ValeDeEquipoDetalle)
            Dim Resultado As New List(Of ValeDeEquipoDetalle)

            Return Resultado
        End Function
        Public Sub Agregar(ByRef Listado As List(Of ValeDeEquipoDetalle))
            If Not VerificarExistencia(Listado) Then
                Dim llist As New List(Of ValeDeEquipoDetalle)
                For Each itm In Listado
                    llist.Add(itm)
                Next
                llist.Add(Me)
                Listado = llist
            End If
        End Sub

        Public Function Eliminar(ByRef Listado As List(Of ValeDeEquipoDetalle)) As Boolean
            Dim Resultado = False
            If MessageBox.Show("Esta a punto de remover este equipo de asignacion actual, si decide hacerlo este no sera asignado al empleado, ¿Esta seguro que desea removerlo?",
                               "Remover equipo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Dim llist As New List(Of ValeDeEquipoDetalle)
                llist = Listado.FindAll(Function(x) x.EquipoID <> EquipoID)
                Listado = llist
                Resultado = True
            End If
            Return Resultado
        End Function

        Private Function VerificarExistencia(ByRef Listado As List(Of ValeDeEquipoDetalle)) As Boolean
            If Listado Is Nothing Then
                Listado = New List(Of ValeDeEquipoDetalle)
                Return False
            End If
            Dim Result As Boolean = Listado.Any(Function(X) X.EquipoID = EquipoID)
            Return Result
        End Function

    End Class
End Class


