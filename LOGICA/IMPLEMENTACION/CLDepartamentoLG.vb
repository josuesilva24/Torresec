Imports DATOS
Public Class CLDepartamentoLG
    Implements ICLDepartamentoLG
    Private contexto As New SilesEntities
    Dim conec As New DATOS.CLDepartamentoAD(contexto)

    Public Function Delete(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoLG.Delete
        Return conec.Delete(Var)
    End Function

    Public Function FindAll() As System.Collections.Generic.ICollection(Of Entidades.E_Departamento) Implements ICLDepartamentoLG.FindAll
        Return conec.FindAll()
    End Function

    Public Function Insert(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoLG.Insert
        Return conec.Insert(Var)
    End Function

    Public Function Update(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoLG.Update
        Return conec.Update(Var)
    End Function
End Class
