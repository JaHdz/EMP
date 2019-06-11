Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class EstudioSocioeconomico
    Implements IDisposable

#Region "Propiedades"
    <Browsable(False)>
    Public Property ID As New Integer
    <Browsable(False)>
    Public Property Empleado As New Integer
    Public Property TipoDeVivienda As String = String.Empty
    Public Property CondicionesDeVivienda As String = String.Empty
    Public Property ServicioLuz As Boolean = False
    Public Property ServicioTelefono As Boolean = False
    Public Property ServicioAgua As Boolean = False
    Public Property ServicioDrenaje As Boolean = False
    Public Property ServicioGas As Boolean = False
    Public Property ServicioRecoleccionDeBasura As Boolean = False
    Public Property ServicioTVCable As Boolean = False
    Public Property ServicioDeInternet As Boolean = False
    Public Property ServicioSistemaDeSeguridad As Boolean = False
    Public Property TransporteMetro As Boolean = False
    Public Property TransportePublico As Boolean = False
    Public Property TransporteTaxi As Boolean = False
    Public Property TransporteVehiculoPropio As Boolean = False
    Public Property ActividadEventosSociales As String = String.Empty
    Public Property ActividadEventosCominitarios As String = String.Empty
    Public Property ActividadMuseos As String = String.Empty
    Public Property ActividadTeatros As String = String.Empty
    Public Property ActividadCines As String = String.Empty
    Public Property ActividadFestivalesCulturales As String = String.Empty
    Public Property ActividadZonasArqueologicas As String = String.Empty
    Public Property ActividadVaciones As String = String.Empty
    Public Property ActividadPlazasPublicas As String = String.Empty
    Public Property ActividadParquesNaturales As String = String.Empty
    Public Property ActividadParquesDeDiversiones As String = String.Empty
    Public Property GastosFijosRenta As New Decimal
    Public Property GastosFijosColegio As New Decimal
    Public Property GastosFijosDespensa As New Decimal
    Public Property GastosFijosServicios As New Decimal
    Public Property Pasatiempos As String = String.Empty
    Public Property Religion As String = String.Empty
    Public Property Verificador As String = String.Empty
    Public Property Observaciones As String = String.Empty
    Public Property FotoVivienda As Image = Nothing
    'Public Property OtrosIngresos As New List(Of OtroIngreso)
    'Public Property Referencias As New List(Of Referencia)
#End Region

#Region "Funciones y Metodos"
    Public Sub New()
        MyBase.New
    End Sub
    Public Sub New(ByVal liID As Integer, ByVal liEmpleado As Integer, ByVal lsTipoDeVivienda As String, ByVal lsCondicionesDeVivienda As String,
                   ByVal lbServicioLuz As Boolean, ByVal lbServicioTelefono As Boolean, ByVal lbServicioAgua As Boolean,
                   ByVal lbServicioDrenaje As Boolean, ByVal lbServicioGas As Boolean, ByVal lbServicioRecoleccionDeBasura As Boolean,
                   ByVal lbServicioTVCable As Boolean, ByVal lbServicioDeInternet As Boolean, ByVal lbServicioSistemaDeSeguridad As Boolean,
                   ByVal lbTransporteMetro As Boolean, ByVal lbTransportePublico As Boolean, ByVal lbTransporteTaxi As Boolean,
                   ByVal lbTransporteVehiculoPropio As Boolean, ByVal lsActividadEventosSociales As String,
                   ByVal lsActividadEventosCominitarios As String, ByVal lsActividadMuseos As String, ByVal lsActividadTeatros As String,
                   ByVal lsActividadCines As String, ByVal lsActividadFestivalesCulturales As String, ByVal lsActividadZonasArqueologicas As String,
                   ByVal lsActividadVaciones As String, ByVal lsActividadPlazasPublicas As String, ByVal lsActividadParquesNaturales As String,
                   ByVal lsActividadParquesDeDiversiones As String, ByVal ldGastosFijosRenta As Decimal, ByVal ldGastosFijosColegio As Decimal,
                   ByVal ldGastosFijosDespensa As Decimal, ByVal ldGastosFijosServicios As Decimal, ByVal lsPasatiempos As String,
                   ByVal lsReligion As String, ByVal lsVerificador As String, ByVal lsObservaciones As String, ByVal liFotoVivienda As Image)
        ID = liID
        Empleado = liEmpleado
        TipoDeVivienda = lsTipoDeVivienda
        CondicionesDeVivienda = lsCondicionesDeVivienda
        ServicioLuz = lbServicioLuz
        ServicioTelefono = lbServicioTelefono
        ServicioAgua = lbServicioAgua
        ServicioDrenaje = lbServicioDrenaje
        ServicioGas = lbServicioGas
        ServicioRecoleccionDeBasura = lbServicioRecoleccionDeBasura
        ServicioTVCable = lbServicioTVCable
        ServicioDeInternet = lbServicioDeInternet
        ServicioSistemaDeSeguridad = lbServicioSistemaDeSeguridad
        TransporteMetro = lbTransporteMetro
        TransportePublico = lbTransportePublico
        TransporteTaxi = lbTransporteTaxi
        TransporteVehiculoPropio = lbTransporteVehiculoPropio
        ActividadEventosSociales = lsActividadEventosSociales
        ActividadEventosCominitarios = lsActividadEventosCominitarios
        ActividadMuseos = lsActividadMuseos
        ActividadTeatros = lsActividadTeatros
        ActividadCines = lsActividadCines
        ActividadFestivalesCulturales = lsActividadFestivalesCulturales
        ActividadZonasArqueologicas = lsActividadZonasArqueologicas
        ActividadVaciones = lsActividadVaciones
        ActividadPlazasPublicas = lsActividadPlazasPublicas
        ActividadParquesNaturales = lsActividadParquesNaturales
        ActividadParquesDeDiversiones = lsActividadParquesDeDiversiones
        GastosFijosRenta = ldGastosFijosRenta
        GastosFijosColegio = ldGastosFijosColegio
        GastosFijosDespensa = ldGastosFijosDespensa
        GastosFijosServicios = ldGastosFijosServicios
        Pasatiempos = lsPasatiempos
        Religion = lsReligion
        Verificador = lsVerificador
        Observaciones = lsObservaciones
        FotoVivienda = liFotoVivienda
    End Sub

    Public Function Buscar(ByVal Empleado As String) As EstudioSocioeconomico
        Dim Result As EstudioSocioeconomico = Nothing
        If Not String.IsNullOrWhiteSpace(Empleado) Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_SES", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                cmd.Parameters.Add("@EMP_ID", SqlDbType.Int).Value = Empleado
                cmd.Parameters.Add("@H_TYPE", SqlDbType.NVarChar, 20).Value = TipoDeVivienda
                cmd.Parameters.Add("@H_CONDITION", SqlDbType.NVarChar, 20).Value = CondicionesDeVivienda
                cmd.Parameters.Add("@H_ELEC", SqlDbType.Bit).Value = ServicioLuz
                cmd.Parameters.Add("@H_PHONE", SqlDbType.Bit).Value = ServicioTelefono
                cmd.Parameters.Add("@H_WATER", SqlDbType.Bit).Value = ServicioAgua
                cmd.Parameters.Add("@H_SEWER", SqlDbType.Bit).Value = ServicioDrenaje
                cmd.Parameters.Add("@H_GAS", SqlDbType.Bit).Value = ServicioGas
                cmd.Parameters.Add("@H_TRASHREC", SqlDbType.Bit).Value = ServicioRecoleccionDeBasura
                cmd.Parameters.Add("@H_CABLETV", SqlDbType.Bit).Value = ServicioTVCable
                cmd.Parameters.Add("@H_INTERNET", SqlDbType.Bit).Value = ServicioDeInternet
                cmd.Parameters.Add("@H_SECURITY", SqlDbType.Bit).Value = ServicioSistemaDeSeguridad
                cmd.Parameters.Add("@T_METRO", SqlDbType.Bit).Value = TransporteMetro
                cmd.Parameters.Add("@T_PUBLIC", SqlDbType.Bit).Value = TransportePublico
                cmd.Parameters.Add("@T_TAX", SqlDbType.Bit).Value = TransporteTaxi
                cmd.Parameters.Add("@T_CAR", SqlDbType.Bit).Value = TransporteVehiculoPropio
                cmd.Parameters.Add("@A_SOCIAL", SqlDbType.NVarChar, 20).Value = ActividadEventosSociales
                cmd.Parameters.Add("@A_COMUNITARY", SqlDbType.NVarChar, 20).Value = ActividadEventosCominitarios
                cmd.Parameters.Add("@A_MUSEUMS", SqlDbType.NVarChar, 20).Value = ActividadMuseos
                cmd.Parameters.Add("@A_THEATERS", SqlDbType.NVarChar, 20).Value = ActividadTeatros
                cmd.Parameters.Add("@A_MOVIES", SqlDbType.NVarChar, 20).Value = ActividadCines
                cmd.Parameters.Add("@A_FESTIVALS", SqlDbType.NVarChar, 20).Value = ActividadFestivalesCulturales
                cmd.Parameters.Add("@A_ARCHE", SqlDbType.NVarChar, 20).Value = ActividadZonasArqueologicas
                cmd.Parameters.Add("@A_VACATIONS", SqlDbType.NVarChar, 20).Value = ActividadVaciones
                cmd.Parameters.Add("@A_PLAZAS", SqlDbType.NVarChar, 20).Value = ActividadPlazasPublicas
                cmd.Parameters.Add("@A_NPARK", SqlDbType.NVarChar, 20).Value = ActividadParquesNaturales
                cmd.Parameters.Add("@A_APARK", SqlDbType.NVarChar, 20).Value = ActividadParquesDeDiversiones
                cmd.Parameters.Add("@FS_RENT", SqlDbType.Decimal).Value = GastosFijosRenta
                cmd.Parameters.Add("@FS_SCHOOL", SqlDbType.Decimal).Value = GastosFijosColegio
                cmd.Parameters.Add("@FS_GROCERIES", SqlDbType.Decimal).Value = GastosFijosDespensa
                cmd.Parameters.Add("@FS_SERVICES", SqlDbType.Decimal).Value = GastosFijosServicios
                cmd.Parameters.Add("@SES_HOBBIES", SqlDbType.NVarChar, 100).Value = Pasatiempos
                cmd.Parameters.Add("@SES_RELIGION", SqlDbType.NVarChar, 20).Value = Religion
                cmd.Parameters.Add("@SES_VERIFIER", SqlDbType.NVarChar, 50).Value = Verificador
                cmd.Parameters.Add("@SES_OBSERVATIONS", SqlDbType.NVarChar, 200).Value = Observaciones
                cmd.Parameters.Add("PHOTO", SqlDbType.Image).Value = If(FotoVivienda Is Nothing OrElse FotoVivienda Is My.Resources.AddImage_80px,
                    DBNull.Value, ImagenABytes(FotoVivienda))
                cmd.Parameters.Add("OPTION", SqlDbType.Int).Value = Operacion.Buscar
                Using Reader As SqlDataReader = cmd.ExecuteReader()
                    If Reader.Read() Then
                        Result = New EstudioSocioeconomico(Reader("ID"), Reader("EMP"), Reader("TIPO"), Reader("CON"), Reader("LUZ"),
                                 Reader("TEL"), Reader("AGU"), Reader("DRE"), Reader("GAS"), Reader("BAS"), Reader("TV"), Reader("INTE"),
                                 Reader("SEG"), Reader("MET"), Reader("PUB"), Reader("TAX"), Reader("VEH"), Reader("ESO"), Reader("ECO"),
                                 Reader("MUS"), Reader("TEA"), Reader("CIN"), Reader("FES"), Reader("ZAR"), Reader("VAC"), Reader("PPU"),
                                 Reader("PNA"), Reader("PDI"), Reader("REN"), Reader("COL"), Reader("DESP"), Reader("SER"), Reader("PAS"),
                                 Reader("REL"), Reader("VER"), Reader("OBS"), CargarImagen(Reader("IMG")))
                    End If
                End Using
            End Using
        End If
        Return Result
    End Function

    Public Function Registrar() As Boolean
        Dim Result As Boolean = False
        If Not CamposEnBlanco() Then
            If Buscar(Empleado) Is Nothing Then
                Using con As New SqlConnection(ConnectionString())
                    con.Open()
                    Dim cmd As New SqlCommand("UDSP_SES", con) With {.CommandType = CommandType.StoredProcedure}
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    cmd.Parameters.Add("@EMP_ID", SqlDbType.Int).Value = Empleado
                    cmd.Parameters.Add("@H_TYPE", SqlDbType.NVarChar, 20).Value = TipoDeVivienda
                    cmd.Parameters.Add("@H_CONDITION", SqlDbType.NVarChar, 20).Value = CondicionesDeVivienda
                    cmd.Parameters.Add("@H_ELEC", SqlDbType.Bit).Value = ServicioLuz
                    cmd.Parameters.Add("@H_PHONE", SqlDbType.Bit).Value = ServicioTelefono
                    cmd.Parameters.Add("@H_WATER", SqlDbType.Bit).Value = ServicioAgua
                    cmd.Parameters.Add("@H_SEWER", SqlDbType.Bit).Value = ServicioDrenaje
                    cmd.Parameters.Add("@H_GAS", SqlDbType.Bit).Value = ServicioGas
                    cmd.Parameters.Add("@H_TRASHREC", SqlDbType.Bit).Value = ServicioRecoleccionDeBasura
                    cmd.Parameters.Add("@H_CABLETV", SqlDbType.Bit).Value = ServicioTVCable
                    cmd.Parameters.Add("@H_INTERNET", SqlDbType.Bit).Value = ServicioDeInternet
                    cmd.Parameters.Add("@H_SECURITY", SqlDbType.Bit).Value = ServicioSistemaDeSeguridad
                    cmd.Parameters.Add("@T_METRO", SqlDbType.Bit).Value = TransporteMetro
                    cmd.Parameters.Add("@T_PUBLIC", SqlDbType.Bit).Value = TransportePublico
                    cmd.Parameters.Add("@T_TAX", SqlDbType.Bit).Value = TransporteTaxi
                    cmd.Parameters.Add("@T_CAR", SqlDbType.Bit).Value = TransporteVehiculoPropio
                    cmd.Parameters.Add("@A_SOCIAL", SqlDbType.NVarChar, 20).Value = ActividadEventosSociales
                    cmd.Parameters.Add("@A_COMUNITARY", SqlDbType.NVarChar, 20).Value = ActividadEventosCominitarios
                    cmd.Parameters.Add("@A_MUSEUMS", SqlDbType.NVarChar, 20).Value = ActividadMuseos
                    cmd.Parameters.Add("@A_THEATERS", SqlDbType.NVarChar, 20).Value = ActividadTeatros
                    cmd.Parameters.Add("@A_MOVIES", SqlDbType.NVarChar, 20).Value = ActividadCines
                    cmd.Parameters.Add("@A_FESTIVALS", SqlDbType.NVarChar, 20).Value = ActividadFestivalesCulturales
                    cmd.Parameters.Add("@A_ARCHE", SqlDbType.NVarChar, 20).Value = ActividadZonasArqueologicas
                    cmd.Parameters.Add("@A_VACATIONS", SqlDbType.NVarChar, 20).Value = ActividadVaciones
                    cmd.Parameters.Add("@A_PLAZAS", SqlDbType.NVarChar, 20).Value = ActividadPlazasPublicas
                    cmd.Parameters.Add("@A_NPARK", SqlDbType.NVarChar, 20).Value = ActividadParquesNaturales
                    cmd.Parameters.Add("@A_APARK", SqlDbType.NVarChar, 20).Value = ActividadParquesDeDiversiones
                    cmd.Parameters.Add("@FS_RENT", SqlDbType.Decimal).Value = GastosFijosRenta
                    cmd.Parameters.Add("@FS_SCHOOL", SqlDbType.Decimal).Value = GastosFijosColegio
                    cmd.Parameters.Add("@FS_GROCERIES", SqlDbType.Decimal).Value = GastosFijosDespensa
                    cmd.Parameters.Add("@FS_SERVICES", SqlDbType.Decimal).Value = GastosFijosServicios
                    cmd.Parameters.Add("@SES_HOBBIES", SqlDbType.NVarChar, 100).Value = Pasatiempos
                    cmd.Parameters.Add("@SES_RELIGION", SqlDbType.NVarChar, 20).Value = Religion
                    cmd.Parameters.Add("@SES_VERIFIER", SqlDbType.NVarChar, 50).Value = Verificador
                    cmd.Parameters.Add("@SES_OBSERVATIONS", SqlDbType.NVarChar, 200).Value = Observaciones
                    cmd.Parameters.Add("PHOTO", SqlDbType.Image).Value = If(FotoVivienda Is Nothing OrElse FotoVivienda Is My.Resources.AddImage_80px,
                        DBNull.Value, ImagenABytes(FotoVivienda))
                    cmd.Parameters.Add("OPTION", SqlDbType.Int).Value = Operacion.Registrar
                    Using Reader As SqlDataReader = cmd.ExecuteReader()
                        If Reader.Read() Then
                            ID = Reader("SESID")
                            Result = True
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Este empleado ya tiene un Estudio Socioeconomico registrado", "Error al registrar Estudio Socioeconomico",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            Dim list As String = vbNewLine + "-Tipo" + vbNewLine + "-Material" + vbNewLine + "-Observaciones"
            MessageBox.Show("Segurese de que las siguientes secciones tengan información:" + list, "Campos vacios", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Function Actualizar() As Boolean
        Dim Result As Boolean = False
        If Not CamposEnBlanco() Then
            Using con As New SqlConnection(ConnectionString())
                con.Open()
                Dim cmd As New SqlCommand("UDSP_SES", con) With {.CommandType = CommandType.StoredProcedure}
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                cmd.Parameters.Add("@EMP_ID", SqlDbType.Int).Value = Empleado
                cmd.Parameters.Add("@H_TYPE", SqlDbType.NVarChar, 20).Value = TipoDeVivienda
                cmd.Parameters.Add("@H_CONDITION", SqlDbType.NVarChar, 20).Value = CondicionesDeVivienda
                cmd.Parameters.Add("@H_ELEC", SqlDbType.Bit).Value = ServicioLuz
                cmd.Parameters.Add("@H_PHONE", SqlDbType.Bit).Value = ServicioTelefono
                cmd.Parameters.Add("@H_WATER", SqlDbType.Bit).Value = ServicioAgua
                cmd.Parameters.Add("@H_SEWER", SqlDbType.Bit).Value = ServicioDrenaje
                cmd.Parameters.Add("@H_GAS", SqlDbType.Bit).Value = ServicioGas
                cmd.Parameters.Add("@H_TRASHREC", SqlDbType.Bit).Value = ServicioRecoleccionDeBasura
                cmd.Parameters.Add("@H_CABLETV", SqlDbType.Bit).Value = ServicioTVCable
                cmd.Parameters.Add("@H_INTERNET", SqlDbType.Bit).Value = ServicioDeInternet
                cmd.Parameters.Add("@H_SECURITY", SqlDbType.Bit).Value = ServicioSistemaDeSeguridad
                cmd.Parameters.Add("@T_METRO", SqlDbType.Bit).Value = TransporteMetro
                cmd.Parameters.Add("@T_PUBLIC", SqlDbType.Bit).Value = TransportePublico
                cmd.Parameters.Add("@T_TAX", SqlDbType.Bit).Value = TransporteTaxi
                cmd.Parameters.Add("@T_CAR", SqlDbType.Bit).Value = TransporteVehiculoPropio
                cmd.Parameters.Add("@A_SOCIAL", SqlDbType.NVarChar, 20).Value = ActividadEventosSociales
                cmd.Parameters.Add("@A_COMUNITARY", SqlDbType.NVarChar, 20).Value = ActividadEventosCominitarios
                cmd.Parameters.Add("@A_MUSEUMS", SqlDbType.NVarChar, 20).Value = ActividadMuseos
                cmd.Parameters.Add("@A_THEATERS", SqlDbType.NVarChar, 20).Value = ActividadTeatros
                cmd.Parameters.Add("@A_MOVIES", SqlDbType.NVarChar, 20).Value = ActividadCines
                cmd.Parameters.Add("@A_FESTIVALS", SqlDbType.NVarChar, 20).Value = ActividadFestivalesCulturales
                cmd.Parameters.Add("@A_ARCHE", SqlDbType.NVarChar, 20).Value = ActividadZonasArqueologicas
                cmd.Parameters.Add("@A_VACATIONS", SqlDbType.NVarChar, 20).Value = ActividadVaciones
                cmd.Parameters.Add("@A_PLAZAS", SqlDbType.NVarChar, 20).Value = ActividadPlazasPublicas
                cmd.Parameters.Add("@A_NPARK", SqlDbType.NVarChar, 20).Value = ActividadParquesNaturales
                cmd.Parameters.Add("@A_APARK", SqlDbType.NVarChar, 20).Value = ActividadParquesDeDiversiones
                cmd.Parameters.Add("@FS_RENT", SqlDbType.Decimal).Value = GastosFijosRenta
                cmd.Parameters.Add("@FS_SCHOOL", SqlDbType.Decimal).Value = GastosFijosColegio
                cmd.Parameters.Add("@FS_GROCERIES", SqlDbType.Decimal).Value = GastosFijosDespensa
                cmd.Parameters.Add("@FS_SERVICES", SqlDbType.Decimal).Value = GastosFijosServicios
                cmd.Parameters.Add("@SES_HOBBIES", SqlDbType.NVarChar, 100).Value = Pasatiempos
                cmd.Parameters.Add("@SES_RELIGION", SqlDbType.NVarChar, 20).Value = Religion
                cmd.Parameters.Add("@SES_VERIFIER", SqlDbType.NVarChar, 50).Value = Verificador
                cmd.Parameters.Add("@SES_OBSERVATIONS", SqlDbType.NVarChar, 200).Value = Observaciones
                cmd.Parameters.Add("PHOTO", SqlDbType.Image).Value = If(FotoVivienda Is Nothing OrElse FotoVivienda Is My.Resources.AddImage_80px,
                    DBNull.Value, ImagenABytes(FotoVivienda))
                cmd.Parameters.Add("OPTION", SqlDbType.Int).Value = Operacion.Actualizar
                cmd.ExecuteNonQuery()
                Result = True
            End Using
        Else
            Dim list As String = vbNewLine + "-Tipo" + vbNewLine + "-Material" + vbNewLine + "-Observaciones"
            MessageBox.Show("Segurese de que las siguientes secciones tengan información:" + list, "Campos vacios", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If
        Return Result
    End Function

    Public Sub OperacionDeOtrosIngresos(Original As List(Of OtroIngreso), Modificada As List(Of OtroIngreso))
        If Original Is Nothing Then Original = New List(Of OtroIngreso)
        If Modificada Is Nothing Then Modificada = New List(Of OtroIngreso)
        Dim RegistrosEliminados = Original.Where(Function(a) Not Modificada.Any(Function(b) b.ID = a.ID)).ToList()
        If RegistrosEliminados.Count > 0 Then
            For Each Ingreso As OtroIngreso In RegistrosEliminados
                Ingreso.Eliminar()
            Next
        End If
        Dim RegistrosNuevos = Modificada.Where(Function(a) Not Original.Any(Function(b) b.ID = a.ID)).ToList()
        If RegistrosNuevos.Count > 0 Then
            For Each Ingreso As OtroIngreso In RegistrosNuevos
                Ingreso.EstudioSocioeconomico = ID
                Ingreso.Registrar()
            Next
            Modificada = New OtroIngreso().CargarListado(ID)
        End If
    End Sub

    Public Sub OperacionDeReferencias(Original As List(Of Referencia), Modificada As List(Of Referencia))
        If Original Is Nothing Then Original = New List(Of Referencia)
        If Modificada Is Nothing Then Modificada = New List(Of Referencia)
        Dim RegistrosEliminados = Original.Where(Function(a) Not Modificada.Any(Function(b) b.ID = a.ID)).ToList()
        If RegistrosEliminados.Count > 0 Then
            For Each ref As Referencia In RegistrosEliminados
                ref.Eliminar()
            Next
        End If
        Dim RegistrosNuevos = Modificada.Where(Function(a) Not Original.Any(Function(b) b.ID = a.ID)).ToList()
        If RegistrosNuevos.Count > 0 Then
            For Each ref As Referencia In RegistrosNuevos
                ref.EstudioSocioeconomico = ID
                ref.Registrar()
            Next
            Modificada = New Referencia().CargarListado(ID)
        End If
    End Sub

    Private Function CamposEnBlanco() As Boolean
        If String.IsNullOrWhiteSpace(TipoDeVivienda) OrElse String.IsNullOrWhiteSpace(CondicionesDeVivienda) OrElse
            String.IsNullOrWhiteSpace(Pasatiempos) OrElse String.IsNullOrWhiteSpace(Observaciones) Then
            Return True
        End If
        Return False
    End Function


    Private Function CargarImagen(ArregloDeBytes As Byte()) As Image
        Dim Result As Image
        If ArregloDeBytes.Length > 0 Then
            Dim ms As New MemoryStream(ArregloDeBytes)
            Result = Image.FromStream(ms)
        Else
            Result = My.Resources.AddImage_80px
        End If
        Return Result
    End Function

    Private Function ImagenABytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            Dim Bin As New MemoryStream
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region
End Class

