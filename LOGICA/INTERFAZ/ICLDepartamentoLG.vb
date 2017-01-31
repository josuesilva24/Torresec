Public Interface ICLDepartamentoLG
    Function Insert(ByVal Var As Entidades.E_Departamento) As Boolean
    Function Update(ByVal Var As Entidades.E_Departamento) As Boolean
    Function FindAll() As ICollection(Of Entidades.E_Departamento)
    Function Delete(ByVal Var As Entidades.E_Departamento) As Boolean
End Interface
