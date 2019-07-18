Public Module Enumeraciones
    Public Enum Operacion
        Registrar = 0
        Actualizar = 1
        Eliminar = 2
        Buscar = 3
        BuscarTodos = 4
        IniciarSesion = 5
        Alta = 6
        Baja = 7
    End Enum

    Public Enum BuscarPor
        Empleado = 0
        Departamento = 1
        Evaluacion = 2
        Capacitacion = 3
        Equipo = 4
        Entidad = 5
        Ciudad = 6
        Puesto = 7
        Supervisor = 8
        TipoDeEmpleado = 9
        Nacionalidad = 10
    End Enum

    Public Enum ComentarioPara
        Ninguno = 0
        EquipoAsignado = 1
    End Enum

    Public Enum ReportOptions
        None = 0
        SocialeconomicStudy = 1
        AssignedEquipment = 2
    End Enum
End Module
