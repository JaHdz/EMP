Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Familiar
#Region "Propiedades"
    Public Property ID As New Integer
    Public Property Empleado As New Integer
    Public Property Tipo As String = String.Empty
    Public Property Nombre As String = String.Empty
    Public Property ApellidoPaterno As String = String.Empty
    Public Property ApellidoMaterno As String = String.Empty
    Public Property Nacionalidad As String = String.Empty
    Public Property FechaDeNacimineto As Date = DateTimePicker.MinimumDateTime
    Public Property Sexo As String = String.Empty
    Private Property NombreCompleto As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer?, ByVal lsTipo As String, ByVal lsNombre As String, ByVal lsApellidoPaterno As String, ByVal lsApellidoMaterno As String, ByVal lsNacionalidad As String, ByVal ldFechaDeNacimineto As DateTime?, ByVal lsSexo As String)
        ID = liID
        Empleado = liEmpleado
        Tipo = lsTipo
        Nombre = lsNombre.Trim()
        ApellidoPaterno = lsApellidoPaterno.Trim()
        ApellidoMaterno = lsApellidoMaterno.Trim()
        Nacionalidad = lsNacionalidad
        FechaDeNacimineto = ldFechaDeNacimineto
        Sexo = lsSexo
        NombreCompleto = String.Concat(Nombre, " ", ApellidoPaterno, " ", ApellidoMaterno).Trim()
    End Sub

    Public Function CargarListado(Empleado As Integer) As List(Of Vista)
        Dim Result As New List(Of Vista)
        Dim listado As New List(Of Familiar)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_FAMILY", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Empleado
            cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 20).Value = Nombre
            cmd.Parameters.Add("@P_LASTNAME", SqlDbType.NVarChar, 20).Value = ApellidoPaterno
            cmd.Parameters.Add("@M_LASTMANEM", SqlDbType.NVarChar, 20).Value = ApellidoMaterno
            cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
            cmd.Parameters.Add("@BIRTHDATE", SqlDbType.DateTime).Value = FechaDeNacimineto
            cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar, 1).Value = Sexo
            cmd.Parameters.Add("@OPTION", SqlDbType.Int).Value = Operacion.BuscarTodos

            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loFamiliar = New Familiar(Reader("ID"), Reader("EMPLEADO"), Reader("TIPO"), Reader("NOMBRE"), Reader("APAT"), Reader("AMAT"), Reader("NACION"), Reader("FNAC"), Reader("GENERO"))
                    listado.Add(loFamiliar)
                End While
            End Using
        End Using
        Result = New Vista().GenerarVista(listado)
        Return Result
    End Function

    Public Function Registrar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje As String = String.Empty
        If Not CamposEnBlanco() Then
            If Not VerificarExistencia(Listado) Then
                If Not VerificarExistenciaDeConyugue(Listado) Then
                    Using con As New SqlConnection(ConnectionString())
                        con.Open()
                        Dim cmd As New SqlCommand("UDSP_EMPLOYEE_FAMILY", con) With {.CommandType = CommandType.StoredProcedure}
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                        cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Empleado
                        cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo
                        cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 20).Value = Nombre
                        cmd.Parameters.Add("@P_LASTNAME", SqlDbType.NVarChar, 20).Value = ApellidoPaterno
                        cmd.Parameters.Add("@M_LASTMANEM", SqlDbType.NVarChar, 20).Value = ApellidoMaterno
                        cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
                        cmd.Parameters.Add("@BIRTHDATE", SqlDbType.DateTime).Value = FechaDeNacimineto
                        cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar, 1).Value = Sexo
                        cmd.Parameters.Add("@OPTION", SqlDbType.Int).Value = Operacion.Registrar
                        cmd.ExecuteNonQuery()
                        Result = True
                        Listado = CargarListado(Empleado)
                    End Using
                Else
                    Mensaje = "Solo se puede tener registrada a una persona como 'Conyugue'"
                End If
            Else
                Mensaje = "Este familiar ya se encuentra registrado"
            End If
        Else
            Mensaje = "Favor de llenar todos los campos para poder continuar"
        End If
        If Not String.IsNullOrWhiteSpace(Mensaje) Then
            MessageBox.Show(Mensaje, "Error al registrar familiar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminar a este familiar?", "Eliminar familiar",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_FAMILY", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                cmd.Parameters.Add("@EMPLOYEE", SqlDbType.Int).Value = Empleado
                cmd.Parameters.Add("@TYPE", SqlDbType.NVarChar, 10).Value = Tipo
                cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 20).Value = Nombre
                cmd.Parameters.Add("@P_LASTNAME", SqlDbType.NVarChar, 20).Value = ApellidoPaterno
                cmd.Parameters.Add("@M_LASTMANEM", SqlDbType.NVarChar, 20).Value = ApellidoMaterno
                cmd.Parameters.Add("@NATIONALITY", SqlDbType.NVarChar, 20).Value = Nacionalidad
                cmd.Parameters.Add("@BIRTHDATE", SqlDbType.DateTime).Value = FechaDeNacimineto
                cmd.Parameters.Add("@GENDER", SqlDbType.NVarChar, 1).Value = Sexo
                cmd.Parameters.Add("@OPTION", SqlDbType.Int).Value = Operacion.Eliminar
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(Empleado)
            End Using
        End If
        Return Result
    End Function

    Private Function CamposEnBlanco() As Boolean
        If Empleado = 0 OrElse String.IsNullOrWhiteSpace(Tipo) OrElse String.IsNullOrWhiteSpace(Nombre) OrElse String.IsNullOrWhiteSpace(ApellidoPaterno) OrElse
           String.IsNullOrWhiteSpace(ApellidoMaterno) OrElse String.IsNullOrWhiteSpace(Nacionalidad) OrElse FechaDeNacimineto = DateTimePicker.MinimumDateTime OrElse
           String.IsNullOrWhiteSpace(Sexo) Then
            Return True
        End If
        Return False
    End Function

    Private Function VerificarExistenciaDeConyugue(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = False
        If Tipo = "CONYUGE" Then
            Result = Listado.Any(Function(X) X.Tipo = Tipo)
        End If
        Return Result
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of Vista)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.NombreCompleto = NombreCompleto And X.Tipo = Tipo)
        Return Result
    End Function
#End Region
    Public Class Vista
        <Browsable(False)>
        Public Property ID As New Integer
        <Browsable(False)>
        Public Property Empleado As New Integer
        <Browsable(False)>
        Public Property Tipo As String = String.Empty
        <Browsable(False)>
        Public Property Nombre As String = String.Empty
        <Browsable(False)>
        Public Property ApellidoPaterno As String = String.Empty
        <Browsable(False)>
        Public Property ApellidoMaterno As String = String.Empty
        Public Property NombreCompleto As String = String.Empty
        Public Property Nacionalidad As String = String.Empty
        Public Property FechaDeNacimineto As Date = DateTimePicker.MinimumDateTime
        Public Property Sexo As String = String.Empty

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal Familiar As Familiar)
            With Familiar
                ID = .ID
                Empleado = .Empleado
                Tipo = .Tipo
                Nombre = .Nombre
                ApellidoPaterno = .ApellidoPaterno
                ApellidoMaterno = .ApellidoMaterno
                NombreCompleto = .NombreCompleto
                Nacionalidad = .Nacionalidad
                FechaDeNacimineto = .FechaDeNacimineto
                Sexo = New Sexo().CargarListado().Find(Function(x) x.ID = .Sexo).Nombre
            End With
        End Sub

        Public Function GenerarVista(ByRef Listado As List(Of Familiar)) As List(Of Vista)
            Dim Resultado As New List(Of Vista)
            For Each Eval In Listado
                Resultado.Add(New Vista(Eval))
            Next
            Return Resultado
        End Function
    End Class
End Class

