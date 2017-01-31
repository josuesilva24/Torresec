Public Class AnillosAD
    Dim context As SilesEntities

    Sub New(ByRef pcontext As SilesEntities)
        context = pcontext
    End Sub

    Public Function Insert(ByVal Var As Entidades.E_Anillo) As Boolean
        Try
            'context.Anillo.AddObject()
            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
