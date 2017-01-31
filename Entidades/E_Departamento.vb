Public Class E_Departamento
    Private _Id_Departamento As Integer
    Private Const _tm_Id_Departamento = 1
    Private _Departamento As String
    Private Const _tm_Departamento = 250

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

    Property Departamento() As String
        Get
            Return _Departamento
        End Get

        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property
    Public Function tm_Departamento() As String
        Return _tm_Departamento
    End Function

End Class
