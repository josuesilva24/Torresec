Public Class CLAnilloAD
    Implements ICLAnilloAD
    Dim context As SilesEntities

    Sub New(ByRef pcontext As SilesEntities)
        context = pcontext
    End Sub

    Public Function Insert(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloAD.Insert
        Try
            context.Anillo.AddObject(conversor(Var))
            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function conversor(ByVal Var As Entidades.E_Anillo) As Anillo Implements ICLAnilloAD.conversor
        Dim v As New DATOS.Anillo
        v.Codigo_Torresec = Var.Codigo_Torresec
        v.Nombre_Torresec = Var.Nombre_Torresec
        v.Operador_Ancla = Var.Operador_Ancla
        v.Codigo_Operador_Ancla = Var.Codigo_Operador_Ancla
        v.Anillo_Latitud = Var.Anillo_Latitud
        v.Anillo_Longitud = Var.Anillo_Longitud
        v.Radio_Busqueda = Var.Radio_Busqueda
        v.Altura_Requerida_RF = Var.Altura_Requerida_RF
        v.Altura_TX_Requerida = Var.Altura_TX_Requerida
        v.id_Region = Var.id_Region
        v.Id_Provincia = Var.Id_Provincia
        v.id_Municipio_Departamento = Var.id_Municipio_Departamento
        v.Localidad = Var.Localidad
        v.Id_Tipo_Anillo = Var.Id_Tipo_Anillo
        v.Nombre = Var.Nombre
        v.Buscador = Var.Buscador
        v.Fecha_Asignacion_Anillo_Por_Operador = Var.Fecha_Asignacion_Anillo_Por_Operador
        v.Fecha_Asignacion_Buscador = Var.Fecha_Asignacion_Buscador
        v.Fecha_Presentacion_Informe_Anillo_Buscador = Var.Fecha_Presentacion_Informe_Anillo_Buscador
        v.Fecha_Presentacion_Informe_Anillo_Operador = Var.Fecha_Presentacion_Informe_Anillo_Operador
        v.Fecha_Presentacion = Var.Fecha_Presentacion
        v.Estado_Anillo = Var.Estado_Anillo
        v.Fecha_Estado_Anillo = Var.Fecha_Estado_Anillo
        v.Hay_Normativas = Var.Hay_Normativas
        v.Tipo_Normativa = Var.Tipo_Normativa
        v.Fecha_Asignacion = Var.Fecha_Asignacion

        Return v
    End Function

    Public Function Update(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloAD.Update
        Dim varQuery = (From v In context.Anillo Where v.Codigo_Torresec = Var.Codigo_Torresec Select v).Single
        varQuery.Codigo_Torresec = Var.Codigo_Torresec
        varQuery.Nombre_Torresec = Var.Nombre_Torresec
        varQuery.Operador_Ancla = Var.Operador_Ancla
        varQuery.Codigo_Operador_Ancla = Var.Codigo_Operador_Ancla
        varQuery.Anillo_Latitud = Var.Anillo_Latitud
        varQuery.Anillo_Longitud = Var.Anillo_Longitud
        varQuery.Radio_Busqueda = Var.Radio_Busqueda
        varQuery.Altura_Requerida_RF = Var.Altura_Requerida_RF
        varQuery.Altura_TX_Requerida = Var.Altura_TX_Requerida
        varQuery.id_Region = Var.id_Region
        varQuery.Id_Provincia = Var.Id_Provincia
        varQuery.id_Municipio_Departamento = Var.id_Municipio_Departamento
        varQuery.Localidad = Var.Localidad
        varQuery.Id_Tipo_Anillo = Var.Id_Tipo_Anillo
        varQuery.Nombre = Var.Nombre
        varQuery.Buscador = Var.Buscador
        varQuery.Fecha_Asignacion_Anillo_Por_Operador = Var.Fecha_Asignacion_Anillo_Por_Operador
        varQuery.Fecha_Asignacion_Buscador = Var.Fecha_Asignacion_Buscador
        varQuery.Fecha_Presentacion_Informe_Anillo_Buscador = Var.Fecha_Presentacion_Informe_Anillo_Buscador
        varQuery.Fecha_Presentacion_Informe_Anillo_Operador = Var.Fecha_Presentacion_Informe_Anillo_Operador
        varQuery.Fecha_Presentacion = Var.Fecha_Presentacion
        varQuery.Estado_Anillo = Var.Estado_Anillo
        varQuery.Fecha_Estado_Anillo = Var.Fecha_Estado_Anillo
        varQuery.Hay_Normativas = Var.Hay_Normativas
        varQuery.Tipo_Normativa = Var.Tipo_Normativa
        varQuery.Fecha_Asignacion = Var.Fecha_Asignacion

        Try
            context.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function FindAll(ByVal var As Entidades.E_Anillo) As Entidades.E_Anillo Implements ICLAnilloAD.FindAll
        Try
            If (From v In context.Anillo Where v.Codigo_Torresec = var.Codigo_Torresec Select v).Count = 0 Then
                MsgBox("No existe")
                Return var
            Else
                Dim varQuery = (From v In context.Anillo Where v.Codigo_Torresec = var.Codigo_Torresec Select v).Single
                Dim anillo As New Entidades.E_Anillo

                anillo.Codigo_Torresec = varQuery.Codigo_Torresec
                anillo.Nombre_Torresec = varQuery.Nombre_Torresec
                anillo.Operador_Ancla = varQuery.Operador_Ancla
                anillo.Codigo_Operador_Ancla = varQuery.Codigo_Operador_Ancla
                anillo.Anillo_Latitud = varQuery.Anillo_Latitud
                anillo.Anillo_Longitud = varQuery.Anillo_Longitud
                anillo.Radio_Busqueda = varQuery.Radio_Busqueda
                anillo.Altura_Requerida_RF = varQuery.Altura_Requerida_RF
                anillo.Altura_TX_Requerida = varQuery.Altura_TX_Requerida
                anillo.id_Region = varQuery.Id_region
                anillo.Id_Provincia = varQuery.Id_Provincia
                anillo.id_Municipio_Departamento = varQuery.id_Municipio_Departamento
                anillo.Localidad = varQuery.Localidad
                anillo.Id_Tipo_Anillo = varQuery.Id_Tipo_Anillo
                anillo.Nombre = varQuery.Nombre
                anillo.Buscador = varQuery.Buscador
                anillo.Fecha_Asignacion_Anillo_Por_Operador = varQuery.Fecha_Asignacion_Anillo_Por_Operador
                anillo.Fecha_Asignacion_Buscador = varQuery.Fecha_Asignacion_Buscador
                anillo.Fecha_Presentacion_Informe_Anillo_Buscador = varQuery.Fecha_Presentacion_Informe_Anillo_Buscador
                anillo.Fecha_Presentacion_Informe_Anillo_Operador = varQuery.Fecha_Presentacion_Informe_Anillo_Operador
                anillo.Fecha_Presentacion = varQuery.Fecha_Presentacion
                anillo.Estado_Anillo = varQuery.Estado_Anillo
                anillo.Fecha_Estado_Anillo = varQuery.Fecha_Estado_Anillo
                anillo.Hay_Normativas = varQuery.Hay_Normativas
                anillo.Tipo_Normativa = varQuery.Tipo_Normativa
                anillo.Fecha_Asignacion = varQuery.Fecha_Asignacion

                Return anillo
            End If

        Catch ex As Exception
            MsgBox(ex)
            Return var
        End Try
    End Function

    Public Function conversorinv(ByVal Var As ICollection(Of Anillo)) As List(Of Entidades.E_Anillo) Implements ICLAnilloAD.conversorinv
        Dim vList As New List(Of ENTIDADES.E_Anillo)
        For Each ta In Var
            Dim v As New ENTIDADES.E_Anillo
            v.Codigo_Torresec = ta.Codigo_Torresec
            v.Nombre_Torresec = ta.Nombre_Torresec
            v.Operador_Ancla = ta.Operador_Ancla
            v.Codigo_Operador_Ancla = ta.Codigo_Operador_Ancla
            v.Anillo_Latitud = ta.Anillo_Latitud
            v.Anillo_Longitud = ta.Anillo_Longitud
            v.Radio_Busqueda = ta.Radio_Busqueda
            v.Altura_Requerida_RF = ta.Altura_Requerida_RF
            v.Altura_TX_Requerida = ta.Altura_TX_Requerida
            v.id_Region = ta.id_Region
            v.Id_Provincia = ta.Id_Provincia
            v.id_Municipio_Departamento = ta.id_Municipio_Departamento
            v.Localidad = ta.Localidad
            v.Id_Tipo_Anillo = ta.Id_Tipo_Anillo
            v.Nombre = ta.Nombre
            v.Buscador = ta.Buscador
            v.Fecha_Asignacion_Anillo_Por_Operador = ta.Fecha_Asignacion_Anillo_Por_Operador
            v.Fecha_Asignacion_Buscador = ta.Fecha_Asignacion_Buscador
            v.Fecha_Presentacion_Informe_Anillo_Buscador = ta.Fecha_Presentacion_Informe_Anillo_Buscador
            v.Fecha_Presentacion_Informe_Anillo_Operador = ta.Fecha_Presentacion_Informe_Anillo_Operador
            v.Fecha_Presentacion = ta.Fecha_Presentacion
            v.Estado_Anillo = ta.Estado_Anillo
            v.Fecha_Estado_Anillo = ta.Fecha_Estado_Anillo
            v.Hay_Normativas = ta.Hay_Normativas
            v.Tipo_Normativa = ta.Tipo_Normativa
            v.Fecha_Asignacion = ta.Fecha_Asignacion
            vList.Add(v)
        Next
        Return vList
    End Function

    Public Function Delete(ByVal Var As Entidades.E_Anillo) As Boolean Implements ICLAnilloAD.Delete
        Dim varQuery As DATOS.Anillo = (From v In context.Anillo Where v.Codigo_Torresec = Var.Codigo_Torresec Select v).Single
        Try
            context.Anillo.DeleteObject(varQuery)
            context.SaveChanges()
            Return True
        Catch e As Exception
            Return True
        End Try
    End Function

End Class
