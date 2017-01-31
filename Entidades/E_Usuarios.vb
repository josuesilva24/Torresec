Public Class E_Usuarios
    Private _Id As Integer
    Private Const _tm_Id = 1
    Private _Nombre As String
    Private Const _tm_Nombre = 250
    Private _Nombre_Usuario As String
    Private Const _tm_Nombre_Usuario = 250
    Private _Apellidos As String
    Private Const _tm_Apellidos = 250
    Private _Contrasena As String
    Private Const _tm_Contrasena = 250
    Private _Id_Departamento As Integer
    Private Const _tm_Id_Departamento = 1

    Property Id() As Integer
        Get
            Return _Id
        End Get

        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Public Function tm_Id() As Integer
        Return _tm_Id
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

    Property Nombre_Usuario() As String
        Get
            Return _Nombre_Usuario
        End Get

        Set(ByVal value As String)
            _Nombre_Usuario = value
        End Set
    End Property
    Public Function tm_Nombre_Usuario() As String
        Return _tm_Nombre_Usuario
    End Function

    Property Apellidos() As String
        Get
            Return _Apellidos
        End Get

        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property
    Public Function tm_Apellidos() As String
        Return _tm_Apellidos
    End Function

    Property Contrasena() As String
        Get
            Return _Contrasena
        End Get

        Set(ByVal value As String)
            _Contrasena = value
        End Set
    End Property
    Public Function tm_Contrasena() As String
        Return _tm_Contrasena
    End Function

    Property Id_Departamento() As Integer
        Get
            Return _Id_Departamento
        End Get

        Set(ByVal value As Integer)
            _Id_Departamento = value
        End Set
    End Property
    Public Function tm_Id_Departamento() As Integer
        Return _tm_Id_Departamento
    End Function
End Class
