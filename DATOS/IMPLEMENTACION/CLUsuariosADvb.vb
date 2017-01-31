Public Class CLUsuariosADvb
        Implements ICLUsuariosAD
    Dim context As SilesEntities

    Sub New(ByRef pcontext As SilesEntities)
        context = pcontext
    End Sub

        Public Function Insert(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosAD.Insert
            Try
            context.Usuario.AddObject(conversor(Var))
                context.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

    Public Function Validar(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosAD.Validar
        Try
            Dim varQuery As New DATOS.Usuario

            If (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Count = 0 Then
                MsgBox("El usuario no existe")
                Return False
            Else
                varQuery = (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Single
                If (varQuery.Contrasena = Var.Contrasena) Then
                    Return True
                Else
                    MsgBox("Contraseña incorrecta!")
                    Return False
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function conversor(ByVal Var As Entidades.E_Usuarios) As Usuario Implements ICLUsuariosAD.conversor
        Dim v As New DATOS.Usuario
        v.Id = Var.Id
        v.Nombre = Var.Nombre
        v.Nombre_Usuario = Var.Nombre_Usuario
        v.Apellidos = Var.Apellidos
        v.Contrasena = Var.Contrasena
        v.Id_Departamento = Var.Id_Departamento

        Return v
    End Function

        Public Function Update(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosAD.Update
        Try
            Dim varQuery = (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Single
            varQuery.Nombre = Var.Nombre
            varQuery.Nombre_Usuario = Var.Nombre_Usuario
            varQuery.Apellidos = Var.Apellidos
            varQuery.Contrasena = Var.Contrasena
            varQuery.Id_Departamento = Var.Id_Departamento

            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
        End Function

    Public Function FindAll(ByVal Var As Entidades.E_Usuarios) As Entidades.E_Usuarios Implements ICLUsuariosAD.FindAll
        Try
            If (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Count = 0 Then
                MsgBox("El usuario no existe")
                Return Var
            Else
                Dim usuario As New Entidades.E_Usuarios
                Dim varQuery = (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Single
                usuario.Nombre = varQuery.Nombre
                usuario.Nombre_Usuario = varQuery.Nombre_Usuario
                usuario.Apellidos = varQuery.Apellidos
                usuario.Contrasena = varQuery.Contrasena
                usuario.Id_Departamento = varQuery.Id_Departamento
                Return usuario
            End If
        Catch ex As Exception
            Return Var
        End Try
    End Function

    Public Function conversorinv(ByVal Var As ICollection(Of Usuario)) As List(Of Entidades.E_Usuarios) Implements ICLUsuariosAD.conversorinv
        Dim vList As New List(Of Entidades.E_Usuarios)
        For Each ta In Var
            Dim v As New Entidades.E_Usuarios
            v.Id = ta.Id
            v.Nombre = ta.Nombre
            v.Nombre_Usuario = ta.Nombre_Usuario
            v.Apellidos = ta.Apellidos
            v.Contrasena = ta.Contrasena
            v.Id_Departamento = ta.Id_Departamento
            vList.Add(v)
        Next
        Return vList
    End Function

        Public Function Delete(ByVal Var As Entidades.E_Usuarios) As Boolean Implements ICLUsuariosAD.Delete
        Dim varQuery As DATOS.Usuario = (From v In context.Usuario Where v.Nombre_Usuario = Var.Nombre_Usuario Select v).Single
            Try
            context.Usuario.DeleteObject(varQuery)
                context.SaveChanges()
                Return True
            Catch e As Exception
                Return True
            End Try
        End Function

      
    End Class
