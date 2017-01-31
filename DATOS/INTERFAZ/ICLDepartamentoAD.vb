Public Interface ICLDepartamentoAD
    Function Insert(ByVal Var As Entidades.E_Departamento) As Boolean
    Function conversor(ByVal Var As Entidades.E_Departamento) As DATOS.Departamento
    Function Update(ByVal Var As Entidades.E_Departamento) As Boolean
    Function FindAll() As ICollection(Of Entidades.E_Departamento)
    Function conversorinv(ByVal Var As ICollection(Of Departamento)) As List(Of Entidades.E_Departamento)
    Function Delete(ByVal Var As Entidades.E_Departamento) As Boolean
End Interface
