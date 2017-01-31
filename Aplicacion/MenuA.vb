Public Class MenuA

    Private Sub tsbAnillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnillo.Click
        Dim ani As New AnilloA()
        ani.Show()

    End Sub

    Private Sub tsbAlternativa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAlternativa.Click
        Dim alt As New Alternativaa()
        alt.Show()
    End Sub

    Private Sub EnergiaStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnergiaStripButton2.Click
        Dim ener As New EnergiaA()
        ener.Show()
    End Sub

    Private Sub ALERtoolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALERtoolStripMenuItem.Click
        Dim alt As New Alternativaa()
        alt.Show()
    End Sub

    Private Sub anToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anToolStripMenuItem.Click
        Dim ani As New AnilloA()
        ani.Show()
    End Sub

    Private Sub colloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colloToolStripMenuItem.Click
        Dim col As New ColloA()
        col.Show()

    End Sub

    Private Sub energiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles energiaToolStripMenuItem.Click
        Dim ener As New EnergiaA()
        ener.Show()
    End Sub

    Private Sub permisosDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles permisosDeDocumentosToolStripMenuItem.Click
        Dim perm As New PermisosA()
        perm.Show()
    End Sub

    Private Sub sitiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sitiosToolStripMenuItem.Click
        Dim sit As New SitioA()
        sit.Show()
    End Sub

    Private Sub cambioDeClaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cambioDeClaveToolStripMenuItem1.Click
        Dim cambcla As New CambioA()
        cambcla.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim usu As New UsuarioA()
        usu.Show()
    End Sub

    Private Sub salirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class