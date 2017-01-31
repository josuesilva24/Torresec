Public Interface ICLAnilloAD
    Function Insert(ByVal Var As Entidades.E_Anillo) As Boolean
    Function conversor(ByVal Var As Entidades.E_Anillo) As DATOS.Anillo
    Function Update(ByVal Var As Entidades.E_Anillo) As Boolean
    Function FindAll(ByVal var As Entidades.E_Anillo) As Entidades.E_Anillo
    Function conversorinv(ByVal Var As ICollection(Of Anillo)) As List(Of Entidades.E_Anillo)
    Function Delete(ByVal Var As Entidades.E_Anillo) As Boolean
End Interface
