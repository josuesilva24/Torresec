Imports LOGICA
Imports Entidades

Public Class Anilloo
    Dim conexion As New CLAnilloLG
    Dim anillo As New E_Anillo

    Private Sub cargaDatos()
        anillo.Codigo_Torresec = txtC1.Text
        anillo.Nombre_Torresec = txtn2.Text
        anillo.Operador_Ancla = txtO3.Text
        anillo.Codigo_Operador_Ancla = txtO4.Text
        anillo.Anillo_Latitud = txt11.Text
        anillo.Anillo_Longitud = txt13.Text
        anillo.Nombre_Ancla = txto5.Text
        anillo.Radio_Busqueda = txt14.Text
        anillo.Altura_Requerida_RF = txt15.Text
        anillo.Altura_TX_Requerida = txt16.Text
        anillo.id_Region = cmb6.SelectedValue
        anillo.Id_Provincia = cmb07.SelectedValue
        anillo.id_Municipio_Departamento = cmb09.SelectedValue
        anillo.Localidad = txt10.Text
        anillo.Id_Tipo_Anillo = cmb1.SelectedValue
        anillo.Nombre = txt111.Text
        anillo.Buscador = txt121.Text
        anillo.Fecha_Asignacion_Anillo_Por_Operador = dtp17.Value
        anillo.Fecha_Asignacion_Buscador = dtp18.Value
        anillo.Fecha_Presentacion_Informe_Anillo_Buscador = dtp19.Value
        anillo.Fecha_Presentacion_Informe_Anillo_Operador = dtp20.Value
        anillo.Fecha_Estado_Anillo = dtp25.Value
        anillo.Fecha_Asignacion = dtp21.Value
        anillo.Estado_Anillo = txt23.Text
        anillo.Hay_Normativas = cmb26.SelectedValue
        anillo.Tipo_Normativa = cmb27.SelectedValue
    End Sub

    Private Sub limpiar()
        txtC1.Clear()
        txtn2.Clear()
        txtO3.Clear()
        txtO4.Clear()
        txt11.Clear()
        txt13.Clear()
        txto5.Clear()
        txt14.Clear()
        txt15.Clear()
        txt16.Clear()
        cmb6.SelectedValue = Nothing
        cmb07.SelectedValue = Nothing
        cmb09.SelectedValue = Nothing
        txt10.Clear()
        cmb1.SelectedValue = Nothing
        txt111.Clear()
        txt121.Clear()

        txt23.Clear()
        cmb26.SelectedValue = Nothing
        cmb27.SelectedValue = Nothing
    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        cargaDatos()
        If conexion.Update(anillo) = True Then
            MsgBox("L")
        Else
            MsgBox("")
        End If
    End Sub
    Private Sub Anillo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    


    End Sub

    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarButton.Click
        cargaDatos()
        If conexion.Insert(anillo) = True Then
            MsgBox("El ingreso de datos, ha sido exitoso")
            limpiar()
        Else
            MsgBox("A ocurrido un error, con el ingreso de datos")
        End If
    End Sub

    Private Sub borrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrarButton.Click
        anillo.Codigo_Torresec = txtC1.Text
        If conexion.Delete(anillo) = True Then
            MsgBox("El registro, ha sdo eliminado satisfactoriamente")
        Else
            MsgBox("A ocurrido un error, con la eliminación de la información")
        End If

    End Sub

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        anillo.Codigo_Torresec = txtC1.Text
        anillo = conexion.FindAll(anillo)

        txtC1.Text = anillo.Codigo_Torresec
        txtn2.Text = anillo.Nombre_Torresec
        txtO3.Text = anillo.Operador_Ancla
        txtO4.Text = anillo.Codigo_Operador_Ancla
        txt11.Text = anillo.Anillo_Latitud
        txt13.Text = anillo.Anillo_Longitud
        txto5.Text = anillo.Nombre_Ancla
        txt14.Text = anillo.Radio_Busqueda
        txt15.Text = anillo.Altura_Requerida_RF
        txt16.Text = anillo.Altura_TX_Requerida
        cmb6.SelectedValue = anillo.id_Region
        cmb07.SelectedValue = anillo.Id_Provincia
        cmb09.SelectedValue = anillo.id_Municipio_Departamento
        txt10.Text = anillo.Localidad
        cmb1.SelectedValue = anillo.Id_Tipo_Anillo
        txt111.Text = anillo.Nombre
        txt121.Text = anillo.Buscador
        dtp17.Value = anillo.Fecha_Asignacion_Anillo_Por_Operador
        dtp18.Value = anillo.Fecha_Asignacion_Buscador
        dtp19.Value = anillo.Fecha_Presentacion_Informe_Anillo_Buscador
        dtp20.Value = anillo.Fecha_Presentacion_Informe_Anillo_Operador
        dtp25.Value = anillo.Fecha_Estado_Anillo
        dtp21.Value = anillo.Fecha_Asignacion
        txt23.Text = anillo.Estado_Anillo
        cmb26.SelectedValue = anillo.Hay_Normativas
        cmb27.SelectedValue = anillo.Tipo_Normativa
    End Sub
End Class