Public Class E_Anillo
    Private _Codigo_Torresec As Integer
    Private Const _tm_Codigo_Torresec = 250
    Private _Nombre_Torresec As String
    Private Const _tm_Nombre_Torresec = 250
    Private _Operador_Ancla As String
    Private Const _tm_Operador_Ancla = 14
    Private _Codigo_Operador_Ancla As String
    Private _Nombre_Ancla As String
    Private Const _tm_Codigo_Operador_Ancla = 1
    Private _Anillo_Latitud As Integer
    Private Const _tm_Anillo_Latitud = 1
    Private _Anillo_Longitud As Integer
    Private Const _tm_Anillo_Longitud = 1
    Private _Radio_Busqueda As Integer
    Private Const _tm_Radio_Busqueda = 1
    Private _Altura_Requerida_RF As Double
    Private Const _tm_Altura_Requerida_RF = 1
    Private _Altura_TX_Requerida As Double
    Private Const _tm_Altura_TX_Requerida = 1
    Private _id_Region As Integer
    Private Const _tm_id_Region = 1
    Private _Id_Provincia As Integer
    Private Const _tm_Id_Provincia = 1
    Private _id_Municipio_Departamento As Integer
    Private Const _tm_id_Municipio_Departamento = 1
    Private _Localidad As String
    Private Const _tm_Localidad = 1
    Private _Id_Tipo_Anillo As Integer
    Private Const _tm_Id_Tipo_Anillo = 1
    Private _Nombre As String
    Private Const _tm_Nombre = 1
    Private _Buscador As String
    Private Const _tm_Buscador = 1
    Private _Fecha_Asignacion_Anillo_Por_Operador As DateTime
    Private Const _tm_Fecha_Asignacion_Anillo_Por_Operador = 1
    Private _Fecha_Asignacion_Buscador As DateTime
    Private Const _tm_Fecha_Asignacion_Buscador = 1
    Private _Fecha_Presentacion_Informe_Anillo_Buscador As DateTime
    Private Const _tm_Fecha_Presentacion_Informe_Anillo_Buscador = 1
    Private _Fecha_Presentacion_Informe_Anillo_Operador As DateTime
    Private Const _tm_Fecha_Presentacion_Informe_Anillo_Operador = 1
    Private _Estado_Anillo As String
    Private Const _tm_Estado_Anillo = 1
    Private _Fecha_Estado_Anillo As DateTime
    Private Const _tm_Fecha_Estado_Anillo = 1
    Private _Hay_Normativas As Boolean
    Private Const _tm_Hay_Normativas = 1
    Private _Tipo_Normativa As Integer
    Private Const _tm_Tipo_Normativa = 1
    Private _Fecha_Asignacion As DateTime
    Private _Fecha_Presentacion As DateTime

    Property Codigo_Torresec() As Integer
        Get
            Return _Codigo_Torresec
        End Get

        Set(ByVal value As Integer)
            _Codigo_Torresec = value
        End Set
    End Property
    Public Function tm_Codigo_Torresec() As Integer
        Return _tm_Codigo_Torresec
    End Function

    Property Nombre_Torresec() As String
        Get
            Return _Nombre_Torresec
        End Get

        Set(ByVal value As String)
            _Nombre_Torresec = value
        End Set
    End Property
    Public Function tm_Nombre_Torresec() As String
        Return _tm_Nombre_Torresec
    End Function

    Property Operador_Ancla() As String
        Get
            Return _Operador_Ancla
        End Get

        Set(ByVal value As String)
            _Operador_Ancla = value
        End Set
    End Property
    Public Function tm_Operador_Ancla() As String
        Return _tm_Operador_Ancla
    End Function

    Property Codigo_Operador_Ancla() As String
        Get
            Return _Codigo_Operador_Ancla
        End Get

        Set(ByVal value As String)
            _Codigo_Operador_Ancla = value
        End Set
    End Property
    Public Function tm_Codigo_Operador_Ancla() As String
        Return _tm_Codigo_Operador_Ancla
    End Function

    Property Anillo_Latitud() As Integer
        Get
            Return _Anillo_Latitud
        End Get

        Set(ByVal value As Integer)
            _Anillo_Latitud = value
        End Set
    End Property
    Public Function tm_Anillo_Latitud() As Integer
        Return _tm_Anillo_Latitud
    End Function

    Property Anillo_Longitud() As Integer
        Get
            Return _Anillo_Longitud
        End Get

        Set(ByVal value As Integer)
            _Anillo_Longitud = value
        End Set
    End Property
    Public Function tm_Anillo_Longitud() As Integer
        Return _tm_Anillo_Longitud
    End Function

    Property Radio_Busqueda() As Integer
        Get
            Return _Radio_Busqueda
        End Get

        Set(ByVal value As Integer)
            _Radio_Busqueda = value
        End Set
    End Property
    Public Function tm_Radio_Busqueda() As Integer
        Return _tm_Radio_Busqueda
    End Function

    Property Altura_Requerida_RF() As Double
        Get
            Return _Altura_Requerida_RF
        End Get

        Set(ByVal value As Double)
            _Altura_Requerida_RF = value
        End Set
    End Property
    Public Function tm_Altura_Requerida_RF() As Double
        Return _tm_Altura_Requerida_RF
    End Function

    Property Altura_TX_Requerida() As Double
        Get
            Return _Altura_TX_Requerida
        End Get

        Set(ByVal value As Double)
            _Altura_TX_Requerida = value
        End Set
    End Property
    Public Function tm_Altura_TX_Requerida() As Double
        Return _tm_Altura_TX_Requerida
    End Function

    Property id_Region() As Integer
        Get
            Return _id_Region
        End Get

        Set(ByVal value As Integer)
            _id_Region = value
        End Set
    End Property
    Public Function tm_id_Region() As Integer
        Return _tm_id_Region
    End Function

    Property Id_Provincia() As Integer
        Get
            Return _Id_Provincia
        End Get

        Set(ByVal value As Integer)
            _Id_Provincia = value
        End Set
    End Property
    Public Function tm_Id_Provincia() As Integer
        Return _tm_Id_Provincia
    End Function

    Property id_Municipio_Departamento() As Integer
        Get
            Return _id_Municipio_Departamento
        End Get

        Set(ByVal value As Integer)
            _id_Municipio_Departamento = value
        End Set
    End Property
    Public Function tm_id_Municipio_Departamento() As Integer
        Return _tm_id_Municipio_Departamento
    End Function

    Property Localidad() As String
        Get
            Return _Localidad
        End Get

        Set(ByVal value As String)
            _Localidad = value
        End Set
    End Property
    Public Function tm_Localidad() As String
        Return _tm_Localidad
    End Function

    Property Nombre_Ancla() As String
        Get
            Return _Nombre_Ancla
        End Get

        Set(ByVal value As String)
            _Nombre_Ancla = value
        End Set
    End Property

    Property Id_Tipo_Anillo() As Integer
        Get
            Return _Id_Tipo_Anillo
        End Get

        Set(ByVal value As Integer)
            _Id_Tipo_Anillo = value
        End Set
    End Property
    Public Function tm_Id_Tipo_Anillo() As Integer
        Return _tm_Id_Tipo_Anillo
    End Function

    Property Nombre() As String
        Get
            Return _Nombre
        End Get

        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Function tm_Nombre() As String
        Return _tm_Nombre
    End Function

    Property Buscador() As String
        Get
            Return _Buscador
        End Get

        Set(ByVal value As String)
            _Buscador = value
        End Set
    End Property
    Public Function tm_Buscador() As String
        Return _tm_Buscador
    End Function

    Property Fecha_Asignacion_Anillo_Por_Operador() As DateTime
        Get
            Return _Fecha_Asignacion_Anillo_Por_Operador
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Asignacion_Anillo_Por_Operador = value
        End Set
    End Property

    Property Fecha_Asignacion_Buscador() As DateTime
        Get
            Return _Fecha_Asignacion_Buscador
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Asignacion_Buscador = value
        End Set
    End Property

    Property Fecha_Presentacion_Informe_Anillo_Buscador() As DateTime
        Get
            Return _Fecha_Presentacion_Informe_Anillo_Buscador
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Presentacion_Informe_Anillo_Buscador = value
        End Set
    End Property

    Property Fecha_Presentacion_Informe_Anillo_Operador() As DateTime
        Get
            Return _Fecha_Presentacion_Informe_Anillo_Operador
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Presentacion_Informe_Anillo_Operador = value
        End Set
    End Property


    Property Estado_Anillo() As String
        Get
            Return _Estado_Anillo
        End Get

        Set(ByVal value As String)
            _Estado_Anillo = value
        End Set
    End Property
    Public Function tm_Estado_Anillo() As String
        Return _tm_Estado_Anillo
    End Function

    Property Fecha_Estado_Anillo() As DateTime
        Get
            Return _Fecha_Estado_Anillo
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Estado_Anillo = value
        End Set
    End Property

    Property Hay_Normativas() As Boolean
        Get
            Return _Hay_Normativas
        End Get

        Set(ByVal value As Boolean)
            _Hay_Normativas = value
        End Set
    End Property
    Public Function tm_Hay_Normativas() As Boolean
        Return _tm_Hay_Normativas
    End Function

    Property Tipo_Normativa() As Integer
        Get
            Return _Tipo_Normativa
        End Get

        Set(ByVal value As Integer)
            _Tipo_Normativa = value
        End Set
    End Property
    Public Function tm_Tipo_Normativa() As Integer
        Return _tm_Tipo_Normativa
    End Function

    Property Fecha_Asignacion() As DateTime
        Get
            Return _Fecha_Asignacion
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Asignacion = value
        End Set
    End Property

    Property Fecha_Presentacion() As DateTime
        Get
            Return _Fecha_Presentacion
        End Get

        Set(ByVal value As DateTime)
            _Fecha_Presentacion = value
        End Set
    End Property

End Class

