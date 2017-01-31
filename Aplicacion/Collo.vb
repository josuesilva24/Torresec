Public Class Collo

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        txtAproDingAop2.Clear()
        txtAproDingAop3.Clear()
        txtCantDdAntRFop2.Clear()
        txtCantDdAntRFop3.Clear()
        txtCantDidAntRFop2.Clear()
        txtCantDidAntRFop3.Clear()
        txtCntDimDantRFop2.Clear()
        txtCntDimDantRFop3.Clear()
        txtCodDSit.Clear()
        txtEnDingAop2.Clear()
        txtEnDingAop3.Clear()
        txtEstaDingAop2.Clear()
        txtEstaDingAop3.Clear()
        txtEstRcpObOp2.Clear()
        txtEstRcpObOp3.Clear()
        txtEstSLAop2.Clear()
        txtEstSLAop3.Clear()
        txtFirSLAop2.Clear()
        txtFirSLAop3.Clear()
        txtNomOpCoub.Clear()
        txtNvlRFop2.Clear()
        txtNvlRFop3.Clear()
        txtOprdra2.Clear()
        txtOprdra3.Clear()
        txtNvlTXop2.Clear()
        txtNvlTXop3.Clear()


    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        txtAproDingAop2.Clear()
        txtAproDingAop3.Clear()
        txtCantDdAntRFop2.Clear()
        txtCantDdAntRFop3.Clear()
        txtCantDidAntRFop2.Clear()
        txtCantDidAntRFop3.Clear()
        txtCntDimDantRFop2.Clear()
        txtCntDimDantRFop3.Clear()
        txtCodDSit.Clear()
        txtEnDingAop2.Clear()
        txtEnDingAop3.Clear()
        txtEstaDingAop2.Clear()
        txtEstaDingAop3.Clear()
        txtEstRcpObOp2.Clear()
        txtEstRcpObOp3.Clear()
        txtEstSLAop2.Clear()
        txtEstSLAop3.Clear()
        txtFirSLAop2.Clear()
        txtFirSLAop3.Clear()
        txtNomOpCoub.Clear()
        txtNvlRFop2.Clear()
        txtNvlRFop3.Clear()
        txtOprdra2.Clear()
        txtOprdra3.Clear()
        txtNvlTXop2.Clear()
        txtNvlTXop3.Clear()

        Me.Close()
    End Sub

    Private Sub Collo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vistaNombre = "COLLO" 'Nombre de la vista en mayuscula
        Dim isReadyOnly = False ' Siempre en false
        'Todos los inputs que se ocupan en readyOnly

        txtAproDingAop2.ReadOnly =
        txtAproDingAop3.ReadOnly =
        txtCantDdAntRFop2.ReadOnly =
        txtCantDdAntRFop3.ReadOnly =
        txtCantDidAntRFop2.ReadOnly =
        txtCantDidAntRFop3.ReadOnly =
        txtCntDimDantRFop2.ReadOnly =
        txtCntDimDantRFop3.ReadOnly =
        txtCodDSit.ReadOnly =
        txtEnDingAop2.ReadOnly =
        txtEnDingAop3.ReadOnly =
        txtEstaDingAop2.ReadOnly =
        txtEstaDingAop3.ReadOnly =
        txtEstRcpObOp2.ReadOnly =
        txtEstRcpObOp3.ReadOnly =
        txtEstSLAop2.ReadOnly =
        txtEstSLAop3.ReadOnly =
        txtFirSLAop2.ReadOnly =
        txtFirSLAop3.ReadOnly =
        txtNomOpCoub.ReadOnly =
        txtNvlRFop2.ReadOnly =
        txtNvlRFop3.ReadOnly =
        txtOprdra2.ReadOnly =
        txtOprdra3.ReadOnly =
        txtNvlTXop2.ReadOnly =
        txtNvlTXop3.ReadOnly =
        isReadyOnly

    End Sub


End Class