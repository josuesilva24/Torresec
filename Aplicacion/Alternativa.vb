Imports BussinesLogic

Public Class Alternativa
    Dim _tipoInstalacionBl As Tipo_InstalacionBL
    Dim _alternativaBl As AlternativaBL

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAlt.Clear()
        txtAltDestru.Clear()
        txtAltLat.Clear()
        txtAltLon.Clear()
        txtCalle.Clear()
        txtCanonMens.Clear()
        txtDistAccPreHespLoc.Clear()
        txtDistPuntConHespLoc.Clear()
        txtDocFaltnt.Clear()
        txtDoComplta.Clear()
        txtDocuDMilst1.Clear()
        txtDocuDMilst2.Clear()
        txtDocuDMilst3.Clear()
        txtDRSMont.Clear()
        txtEC1.Clear()
        txtEC2.Clear()
        txtEstadoSLA.Clear()
        txtEstatsAdq.Clear()
        txtNivlDapoEst.Clear()
        txtNum.Clear()
        txtObsAdq.Clear()
        txtObsvLgals.Clear()
        txtOpComMont.Clear()
        txtPagsAdltds.Clear()
        txtSupAlocar.Clear()
        txtValidMuniTORSC.Clear()
        txtValiEconOperMO.Clear()

        Me.Close()
    End Sub

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAlt.Clear()
        txtAltDestru.Clear()
        txtAltLat.Clear()
        txtAltLon.Clear()
        txtCalle.Clear()
        txtCanonMens.Clear()
        txtDistAccPreHespLoc.Clear()
        txtDistPuntConHespLoc.Clear()
        txtDocFaltnt.Clear()
        txtDoComplta.Clear()
        txtDocuDMilst1.Clear()
        txtDocuDMilst2.Clear()
        txtDocuDMilst3.Clear()
        txtDRSMont.Clear()
        txtEC1.Clear()
        txtEC2.Clear()
        txtEstadoSLA.Clear()
        txtEstatsAdq.Clear()
        txtNivlDapoEst.Clear()
        txtNum.Clear()
        txtObsAdq.Clear()
        txtObsvLgals.Clear()
        txtOpComMont.Clear()
        txtPagsAdltds.Clear()
        txtSupAlocar.Clear()
        txtValidMuniTORSC.Clear()
        txtValiEconOperMO.Clear()

    End Sub

    Private Sub Alternativa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "ALTERNATIVA" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly
        txtAltDestru.ReadOnly =
        txtAltLat.ReadOnly =
        txtAltLon.ReadOnly =
        txtCalle.ReadOnly =
        txtCanonMens.ReadOnly =
        txtDistAccPreHespLoc.ReadOnly =
        txtDistPuntConHespLoc.ReadOnly =
        txtDocFaltnt.ReadOnly =
        txtDoComplta.ReadOnly =
        txtDocuDMilst1.ReadOnly =
        txtDocuDMilst2.ReadOnly =
        txtDocuDMilst3.ReadOnly =
        txtDRSMont.ReadOnly =
        txtEC1.ReadOnly =
        txtEC2.ReadOnly =
        txtEstadoSLA.ReadOnly =
        txtEstatsAdq.ReadOnly =
        txtNivlDapoEst.ReadOnly =
        txtNum.ReadOnly =
        txtObsAdq.ReadOnly =
        txtObsvLgals.ReadOnly =
        txtOpComMont.ReadOnly =
        txtPagsAdltds.ReadOnly =
        txtSupAlocar.ReadOnly =
        txtValidMuniTORSC.ReadOnly =
        txtValiEconOperMO.ReadOnly =
        txtAlt.ReadOnly =
        txtAltDestru.ReadOnly =
        txtAltLat.ReadOnly =
        txtAltLon.ReadOnly =
        txtCalle.ReadOnly =
        txtCanonMens.ReadOnly =
        txtDistAccPreHespLoc.ReadOnly =
        txtDistPuntConHespLoc.ReadOnly =
        txtDocFaltnt.ReadOnly =
        txtDoComplta.ReadOnly =
        txtDocuDMilst1.ReadOnly =
        txtDocuDMilst2.ReadOnly =
        txtDocuDMilst3.ReadOnly =
        txtDRSMont.ReadOnly =
        txtEC1.ReadOnly =
        txtEC2.ReadOnly =
        txtEstadoSLA.ReadOnly =
        txtEstatsAdq.ReadOnly =
        txtNivlDapoEst.ReadOnly =
        txtNum.ReadOnly =
        txtObsAdq.ReadOnly =
        txtObsvLgals.ReadOnly =
        txtOpComMont.ReadOnly =
        txtPagsAdltds.ReadOnly =
        txtSupAlocar.ReadOnly =
        txtValidMuniTORSC.ReadOnly =
        txtValiEconOperMO.ReadOnly =
        isReadyOnly

        _tipoInstalacionBl = New Tipo_InstalacionBL()

        cmbTipDInst.DataSource = _tipoInstalacionBl.GetAllTipo_Instalacion()
        cmbTipDInst.DisplayMember = "Tipo"
        cmbTipDInst.ValueMember = "Id"

    End Sub

    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarButton.Click
        Dim alter = New DATOS.Alternativa()
        _alternativaBl = New AlternativaBL()
        alter.Alternativa1 = txtAlt.Text
        alter.Calle = txtCalle.Text
        If String.IsNullOrEmpty(txtNum.Text) = False Then
            alter.Numero = Integer.Parse(txtNum.Text)
        End If
        alter.Entre_Calle_1 = txtEC1.Text
        alter.Entre_Calle_2 = txtEC2.Text

        If String.IsNullOrEmpty(txtAltLat.Text) = False Then
            alter.Alternativa_Latitud = Integer.Parse(txtAltLat.Text)
        End If

        If String.IsNullOrEmpty(txtAltLon.Text) = False Then
            alter.Alternativa_Longitud = Integer.Parse(txtAltLon.Text)
        End If

        If String.IsNullOrEmpty(cmbTipDInst.Text) = False Then
            alter.Id_Tipo_Instalacion = Integer.Parse(cmbTipDInst.SelectedIndex)
        End If

        alter.Id_Tipo_Estructura = cmbTipDEstru.SelectedIndex
        If String.IsNullOrEmpty(txtNivlDapoEst.Text) = False Then
            alter.Nivel_Apoyo_Estructura = Decimal.Parse(txtNivlDapoEst.Text)
        Else
            alter.Nivel_Apoyo_Estructura = 0
        End If

        If String.IsNullOrEmpty(txtAltDestru.Text) = False Then
            alter.Altura_Estructura = Decimal.Parse(txtAltDestru.Text)
        Else
            alter.Altura_Estructura = 0
        End If

        If String.IsNullOrEmpty(txtAltTotl.Text) = False Then
            alter.Altura_Total = Decimal.Parse(txtAltTotl.Text)
        Else
            alter.Altura_Total = 0
        End If

        If String.IsNullOrEmpty(txtSupAlocar.Text) = False Then
            alter.Superficie_A_Locar = Decimal.Parse(txtSupAlocar.Text)
        Else
            alter.Superficie_A_Locar = 0
        End If

        If String.IsNullOrEmpty(txtSupAlocar.Text) = False Then
            alter.Superficie_A_Locar = Decimal.Parse(txtSupAlocar.Text)
        Else
            alter.Superficie_A_Locar = 0
        End If

        alter.Acceso_Independiete = False

        If String.IsNullOrEmpty(txtDistPuntConHespLoc.Text) = False Then
            alter.Distancia_Desde_Punto_Conexion_Hasta_Espacio_A_Locar = Decimal.Parse(txtDistPuntConHespLoc.Text)
        Else
            alter.Distancia_Desde_Punto_Conexion_Hasta_Espacio_A_Locar = 0
        End If

        If String.IsNullOrEmpty(txtDistAccPreHespLoc.Text) = False Then
            alter.Distancia_Desde_El_Acceso_Al_Predio_Hasta_Espacio_A_Locar = Decimal.Parse(txtDistAccPreHespLoc.Text)
        Else
            alter.Distancia_Desde_El_Acceso_Al_Predio_Hasta_Espacio_A_Locar = 0
        End If

        alter.Suministro_Electrico = _cmbSumiElect.Text
        alter.Require_Mimetizado = False
        alter.Validacion_Economica_Operador = cmbValiEconOper.SelectedIndex

        If _alternativaBl.InsertAlternativa(alter) Then
            MsgBox("Datos Almacenados")
        Else
            MsgBox("Error Al Guardar Alternativa")

        End If
    End Sub

    Private Sub txtDistAccPreHespLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistAccPreHespLoc.TextChanged

    End Sub

    Private Sub txtDistPuntConHespLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistPuntConHespLoc.TextChanged

    End Sub
End Class