Public Interface ICLUsuariosLG
    Function Insert(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function Validar(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function Update(ByVal Var As Entidades.E_Usuarios) As Boolean
    Function FindAll(ByVal Var As Entidades.E_Usuarios) As Entidades.E_Usuarios
    Function Delete(ByVal Var As Entidades.E_Usuarios) As Boolean
End Interface
