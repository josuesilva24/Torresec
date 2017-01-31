Imports DATOS
Public Class CLAnilloLG
    Implements ICLAnilloLG
    Private contexto As New SilesEntities
    Dim conec As New DATOS.CLAnilloAD(contexto)

    Public Function Delete(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloLG.Delete
        Return conec.Delete(Var)
    End Function

    Public Function FindAll(ByVal var As Entidades.E_Anillo) As Entidades.E_Anillo Implements ICLAnilloLG.FindAll
        Return conec.FindAll(var)
    End Function

    Public Function Insert(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloLG.Insert
        Return conec.Insert(Var)
    End Function

    Public Function Update(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloLG.Update
        Return conec.Update(Var)
    End Function
End Class
