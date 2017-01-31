Public Class Energia

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAcumAntTrrsc.Clear()
        txtAcumUltMdcnTrrsc.Clear()
        txtDirDlSumElc.Clear()
        txtFchaPdSumElcPrs.Clear()
        txtProvDgstnDsum.Clear()
        txtTarfa.Clear()
        txtTitDlSumElc.Clear()
    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAcumAntTrrsc.Clear()
        txtAcumUltMdcnTrrsc.Clear()
        txtDirDlSumElc.Clear()
        txtFchaPdSumElcPrs.Clear()
        txtProvDgstnDsum.Clear()
        txtTarfa.Clear()
        txtTitDlSumElc.Clear()
        Me.Close()
    End Sub
    Private Sub Energia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "ENERGIA" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly

        txtAcumAntTrrsc.ReadOnly =
        txtAcumUltMdcnTrrsc.ReadOnly =
        txtDirDlSumElc.ReadOnly =
        txtFchaPdSumElcPrs.ReadOnly =
        txtProvDgstnDsum.ReadOnly =
        txtTarfa.ReadOnly =
        txtTitDlSumElc.ReadOnly =
        isReadyOnly



    End Sub


End Class