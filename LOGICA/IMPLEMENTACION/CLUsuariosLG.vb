Imports DATOS
Public Class CLUsuariosLG
    Implements ICLUsuariosLG
    Private contexto As New SilesEntities
    Dim conec As New DATOS.CLUsuariosADvb(contexto)

    Public Function Validar(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosLG.Validar
        Return conec.Validar(Var)
    End Function

    Public Function Delete(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosLG.Delete
        Return conec.Delete(Var)
    End Function

    Public Function FindAll(ByVal Var As Entidades.E_Usuarios) As Entidades.E_Usuarios Implements ICLUsuariosLG.FindAll
        Return conec.FindAll(Var)
    End Function

    Public Function Insert(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosLG.Insert
        Return conec.Insert(Var)
    End Function

    Public Function Update(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosLG.Update
        Return conec.Update(Var)
    End Function
End Class
