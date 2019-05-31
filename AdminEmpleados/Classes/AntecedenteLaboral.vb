Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AntecedenteLaboral
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property Empleado As New Integer
    Public Property FechaDeInicio As Date = DateTimePicker.MinimumDateTime
    Public Property FechaDeSalida As Date = DateTimePicker.MinimumDateTime
    Public Property Empresa As String = String.Empty
    Public Property Puesto As String = String.Empty
    Public Property Salario As New Decimal
    Public Property Telefono As String = String.Empty
    Public Property MotivoDeSalida As String = String.Empty
    Public Property Contacto As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal ldFechaDeInicio As Date, ByVal ldFechaDeSalida As Date,
                   ByVal lsEmpresa As String, ByVal lsPuesto As String, ByVal lsSalario As String, ByVal lsTelefono As String,
                   ByVal lsMotivoDeSalida As String, ByVal lsContacto As String)
        ID = liID
        Empleado = liEmpleado
        FechaDeInicio = ldFechaDeInicio
        FechaDeSalida = ldFechaDeSalida
        Empresa = lsEmpresa
        Puesto = lsPuesto
        If String.IsNullOrWhiteSpace(lsSalario) Then
            lsSalario = 0
        End If
        Salario = lsSalario
        Telefono = lsTelefono
        MotivoDeSalida = lsMotivoDeSalida
        Contacto = lsContacto
    End Sub

    Public Function CargarListado(Empleado As Integer) As List(Of AntecedenteLaboral)
        Dim Result As New List(Of AntecedenteLaboral)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_JOBHISTORY", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@START", FechaDeInicio))
            cmd.Parameters.Add(New SqlParameter("@END", FechaDeSalida))
            cmd.Parameters.Add(New SqlParameter("@COMPANY", Empresa))
            cmd.Parameters.Add(New SqlParameter("@POSITION", Puesto))
            cmd.Parameters.Add(New SqlParameter("@WAGE", Salario))
            cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
            cmd.Parameters.Add(New SqlParameter("@REASON", MotivoDeSalida))
            cmd.Parameters.Add(New SqlParameter("@CONTACT", Contacto))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loAntecedenteLaboral As New AntecedenteLaboral(Reader("ID"), Reader("EMPLEADO"), Reader("INICIO"), Reader("FINAL"), Reader("EMPRESA"), Reader("PUESTO"), Reader("SALARIO"),
                                                                       Reader("TEL"), Reader("MOTIVO"), Reader("CONTACTO"))
                    Result.Add(loAntecedenteLaboral)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of AntecedenteLaboral)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        Dim IconoDeMensaje As MessageBoxIcon
        Dim Encabezado = String.Empty
        If Not CamposEnBlanco() Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_JOBHISTORY", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@START", FechaDeInicio))
                    cmd.Parameters.Add(New SqlParameter("@END", FechaDeSalida))
                    cmd.Parameters.Add(New SqlParameter("@COMPANY", Empresa))
                    cmd.Parameters.Add(New SqlParameter("@POSITION", Puesto))
                    cmd.Parameters.Add(New SqlParameter("@WAGE", Salario))
                    cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
                    cmd.Parameters.Add(New SqlParameter("@REASON", MotivoDeSalida))
                    cmd.Parameters.Add(New SqlParameter("@CONTACT", Contacto))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Listado = CargarListado(Empleado)
                End Using
            Else
                Mensaje = "Este empleo ya fue registrado."
                Encabezado = "Error de registro de antecedentes"
                IconoDeMensaje = MessageBoxIcon.Hand
            End If
        Else
            Mensaje = "Debe llenar todos los campos."
            Encabezado = "Error de registro de antecedentes"
            IconoDeMensaje = MessageBoxIcon.Hand
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, Encabezado, MessageBoxButtons.OK, IconoDeMensaje)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of AntecedenteLaboral)) As Boolean
        Dim Result As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminarlo?", "Eliminar antecedente laboral",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_JOBHISTORY", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                cmd.Parameters.Add(New SqlParameter("@START", FechaDeInicio))
                cmd.Parameters.Add(New SqlParameter("@END", FechaDeSalida))
                cmd.Parameters.Add(New SqlParameter("@COMPANY", Empresa))
                cmd.Parameters.Add(New SqlParameter("@POSITION", Puesto))
                cmd.Parameters.Add(New SqlParameter("@WAGE", Salario))
                cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
                cmd.Parameters.Add(New SqlParameter("@REASON", MotivoDeSalida))
                cmd.Parameters.Add(New SqlParameter("@CONTACT", Contacto))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(Empleado)
            End Using
        End If

        Return Result
    End Function

    Private Function CamposEnBlanco() As Boolean
        Dim Result As Boolean = False
        If Empleado <> 0 AndAlso FechaDeInicio <> DateTimePicker.MinimumDateTime AndAlso FechaDeSalida <> DateTimePicker.MinimumDateTime AndAlso
            Not String.IsNullOrWhiteSpace(Empresa) AndAlso Not String.IsNullOrWhiteSpace(Puesto) AndAlso Salario <> 0 AndAlso
            Not String.IsNullOrWhiteSpace(MotivoDeSalida) AndAlso Not String.IsNullOrWhiteSpace(Contacto) Then
            Result = True
        End If
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of AntecedenteLaboral)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.Empresa = Empresa And X.FechaDeInicio = FechaDeInicio And X.FechaDeSalida = FechaDeSalida)
        Return Result
    End Function
#End Region
End Class

