Public Class Alternativa


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


    End Sub

    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarButton.Click

    End Sub

    Private Sub txtDistAccPreHespLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistAccPreHespLoc.TextChanged

    End Sub

    Private Sub txtDistPuntConHespLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistPuntConHespLoc.TextChanged

    End Sub
End Class