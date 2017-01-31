Public Class Permisos

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAltPer.Clear()
        txtAltPermANAC.Clear()
        txtAltPrmdaTt.Clear()
        txtDocDmils4.Clear()
        txtDocDmils5.Clear()
        txtEstDgesDper.Clear()
        txtPermAmb.Clear()
        txtEstDgesDper.Clear()
        txtFactInTram.Clear()
        txtFactOtor.Clear()
        txtHabInTram.Clear()
        txtHabiOtor.Clear()
        txtNumDordMun.Clear()
        txtPermANACinTra.Clear()
        txtPermANACotor.Clear()
        txtPermArql.Clear()
        txtPermDobInTram.Clear()
        txtPermPatri.Clear()
        txtPrmDobOtor.Clear()
        txtProvANNAC.Clear()
        txtProvGstMuni.Clear()
        txtTipDEstPerm.Clear()
    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAltPer.Clear()
        txtAltPermANAC.Clear()
        txtAltPrmdaTt.Clear()
        txtDocDmils4.Clear()
        txtDocDmils5.Clear()
        txtEstDgesDper.Clear()
        txtPermAmb.Clear()
        txtEstDgesDper.Clear()
        txtFactInTram.Clear()
        txtFactOtor.Clear()
        txtHabInTram.Clear()
        txtHabiOtor.Clear()
        txtNumDordMun.Clear()
        txtPermANACinTra.Clear()
        txtPermANACotor.Clear()
        txtPermArql.Clear()
        txtPermDobInTram.Clear()
        txtPermPatri.Clear()
        txtPrmDobOtor.Clear()
        txtProvANNAC.Clear()
        txtProvGstMuni.Clear()
        txtTipDEstPerm.Clear()

        Me.Close()
    End Sub

    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "PERMISOS" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly

        txtAltPer.ReadOnly =
        txtAltPermANAC.ReadOnly =
        txtAltPrmdaTt.ReadOnly =
        txtDocDmils4.ReadOnly =
        txtDocDmils5.ReadOnly =
        txtEstDgesDper.ReadOnly =
        txtPermAmb.ReadOnly =
        txtEstDgesDper.ReadOnly =
        txtFactInTram.ReadOnly =
        txtFactOtor.ReadOnly =
        txtHabInTram.ReadOnly =
        txtHabiOtor.ReadOnly =
        txtNumDordMun.ReadOnly =
        txtPermANACinTra.ReadOnly =
        txtPermANACotor.ReadOnly =
        txtPermArql.ReadOnly =
        txtPermDobInTram.ReadOnly =
        txtPermPatri.ReadOnly =
        txtPrmDobOtor.ReadOnly =
        txtProvANNAC.ReadOnly =
        txtProvGstMuni.ReadOnly =
        txtTipDEstPerm.ReadOnly =
        isReadyOnly

    End Sub


End Class