Public Class CLDepartamentoAD
    Implements ICLDepartamentoAD
    Dim context As SilesEntities

    Sub New(ByRef pcontext As SilesEntities)
        context = pcontext
    End Sub

    Public Function Insert(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoAD.Insert
        Try
            context.Departamento.AddObject(conversor(Var))
            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function conversor(ByVal Var As Entidades.E_Departamento) As Departamento Implements ICLDepartamentoAD.conversor
        Dim v As New DATOS.Departamento
        v.Id_Departamento = Var.Id_Departamento
        v.Departamento1 = Var.Departamento

        Return v
    End Function

    Public Function Update(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoAD.Update
        Dim varQuery = (From v In context.Departamento Where v.Id_Departamento = Var.Id_Departamento Select v).Single
        varQuery.Id_Departamento = Var.Id_Departamento
        varQuery.Departamento1 = Var.Departamento

        Try
            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function FindAll() As ICollection(Of Entidades.E_Departamento) Implements ICLDepartamentoAD.FindAll
        Try
            Dim consulta As New List(Of DATOS.Departamento)
            consulta = (From a In context.Departamento Select a).ToList()
            Return conversorinv(consulta)
        Catch ex As Exception
            Return ex
        End Try
    End Function

    Public Function conversorinv(ByVal Var As ICollection(Of Departamento)) As List(Of Entidades.E_Departamento) Implements ICLDepartamentoAD.conversorinv
        Dim vList As New List(Of ENTIDADES.E_Departamento)
        For Each ta In Var
            Dim v As New ENTIDADES.E_Departamento
            v.Id_Departamento = ta.Id_Departamento
            v.Departamento = ta.Departamento1
            vList.Add(v)
        Next
        Return vList
    End Function

    Public Function Delete(ByVal Var As Entidades.E_Departamento) As Boolean Implements ICLDepartamentoAD.Delete
        Dim varQuery As DATOS.Departamento = (From v In context.Departamento Where v.Id_Departamento = Var.Id_Departamento Select v).Single
        Try
            context.Departamento.DeleteObject(varQuery)
            context.SaveChanges()
            Return True
        Catch e As Exception
            Return True
        End Try
    End Function

End Class
