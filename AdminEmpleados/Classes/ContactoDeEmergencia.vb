Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ContactoDeEmergencia
#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property Empleado As New Integer
    Public Property Nombre As String = String.Empty
    Public Property ApellidoPaterno As String = String.Empty
    Public Property ApellidoMaterno As String = String.Empty
    Public Property Parentesco As String = String.Empty
    Public Property Telefono As String = String.Empty
    Public Property Celular As String = String.Empty
    Private Property NombreCompleto As String = String.Empty
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liID_Emp As Integer?, ByVal lsNombre As String, ByVal lsApellidoPaterno As String, ByVal lsApellidoMaterno As String, ByVal lsParentesco As String, ByVal lsTelefono As String, ByVal lsCelular As String)
        ID = liID
        Empleado = liID_Emp
        Nombre = lsNombre
        ApellidoPaterno = lsApellidoPaterno
        ApellidoMaterno = lsApellidoMaterno
        Parentesco = lsParentesco
        Telefono = lsTelefono
        Celular = lsCelular
        NombreCompleto = String.Concat(Nombre, " ", ApellidoPaterno, " ", ApellidoMaterno)
    End Sub

    Public Function CargarListado(Empleado As Integer) As List(Of ContactoDeEmergencia)
        Dim Result As New List(Of ContactoDeEmergencia)
        Using con As New SqlConnection(ConnectionString())
            con.Open()
            Dim cmd As New SqlCommand("UDSP_EMPLOYEE_CONTACTS", con) With {.CommandType = CommandType.StoredProcedure}
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
            cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
            cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", ApellidoPaterno))
            cmd.Parameters.Add(New SqlParameter("@M_LASTNAME", ApellidoMaterno))
            cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", Parentesco))
            cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
            cmd.Parameters.Add(New SqlParameter("@CELLPHONE", Celular))
            cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.BuscarTodos))
            Using Reader As SqlDataReader = cmd.ExecuteReader()
                While Reader.Read()
                    Dim loContactoDeEmergencia As New ContactoDeEmergencia(Reader("ID"), Reader("EMPLEADO"), Reader("NOMBRE"), Reader("APAT"), Reader("AMAT"), Reader("PARENTESCO"),
                                                                           Reader("TELEFONO"), Reader("CELULAR"))
                    Result.Add(loContactoDeEmergencia)
                End While
            End Using
        End Using
        Return Result
    End Function

    Public Function Registrar(Listado As List(Of ContactoDeEmergencia)) As Boolean
        Dim Result As Boolean = False
        Dim Mensaje = String.Empty
        If Not CamposEnBlanco() Then
            If Not VerificarExistencia(Listado) Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_EMPLOYEE_CONTACTS", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add(New SqlParameter("@ID", ID))
                    cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                    cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                    cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", ApellidoPaterno))
                    cmd.Parameters.Add(New SqlParameter("@M_LASTNAME", ApellidoMaterno))
                    cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", Parentesco))
                    cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
                    cmd.Parameters.Add(New SqlParameter("@CELLPHONE", Celular))
                    cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Registrar))
                    cmd.ExecuteNonQuery()
                    Result = True
                    Listado = CargarListado(Empleado)
                End Using
            Else
                Mensaje = "Este contacto ya esta registrado en el sistema"
            End If
        Else
            Mensaje = "Debe llenar los campos antes de continuar"
        End If
        If Mensaje IsNot String.Empty Then
            MessageBox.Show(Mensaje, "Error al registrar Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Function Eliminar(ByRef Listado As List(Of ContactoDeEmergencia)) As Boolean
        Dim Result As Boolean = False
        If MessageBox.Show("Esta a punto de eliminar un registro, ¿Esta seguro que desea eliminar este contacto?", "Eliminar Contacto",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_EMPLOYEE_CONTACTS", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add(New SqlParameter("@ID", ID))
                cmd.Parameters.Add(New SqlParameter("@EMPLOYEE", Empleado))
                cmd.Parameters.Add(New SqlParameter("@NAME", Nombre))
                cmd.Parameters.Add(New SqlParameter("@P_LASTNAME", ApellidoPaterno))
                cmd.Parameters.Add(New SqlParameter("@M_LASTNAME", ApellidoMaterno))
                cmd.Parameters.Add(New SqlParameter("@RELATIONSHIP", Parentesco))
                cmd.Parameters.Add(New SqlParameter("@PHONE", Telefono))
                cmd.Parameters.Add(New SqlParameter("@CELLPHONE", Celular))
                cmd.Parameters.Add(New SqlParameter("@OPTION", Operacion.Eliminar))
                cmd.ExecuteNonQuery()
                Result = True
                Listado = CargarListado(Empleado)
            End Using
        End If
        Return Result
    End Function

    Private Function CamposEnBlanco() As Boolean
        If Empleado <> 0 AndAlso Not String.IsNullOrWhiteSpace(Nombre) AndAlso Not String.IsNullOrWhiteSpace(ApellidoPaterno) AndAlso
            Not String.IsNullOrWhiteSpace(ApellidoMaterno) AndAlso Not String.IsNullOrWhiteSpace(Parentesco) AndAlso
            (Not String.IsNullOrWhiteSpace(Telefono) And Not String.IsNullOrWhiteSpace(Celular)) Then
            Return False
        End If
        Return True
    End Function

    Private Function VerificarExistencia(ByRef Listado As List(Of ContactoDeEmergencia)) As Boolean
        Dim Result As Boolean = Listado.Any(Function(X) X.NombreCompleto = NombreCompleto)
        Return Result
    End Function
#End Region
End Class

