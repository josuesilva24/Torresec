Public Interface ICLUsuariosAD
    Function Insert(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function conversor(ByVal Var As Entidades.E_Usuarios) As DATOS.Usuario
    Function Update(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function FindAll(ByVal Var As Entidades.E_Usuarios) As Entidades.E_Usuarios
    Function conversorinv(ByVal Var As ICollection(Of Usuario)) As List(Of Entidades.E_Usuarios)
    Function Delete(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function Validar(ByVal Var As Entidades.E_Usuarios) As Boolean
End Interface
