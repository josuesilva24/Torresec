'Imports MapSource

Public Class Menu

    'Property _session As Session




    Private Sub AlternativatoolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternativatoolStripMenuItem.Click
        Dim alt As New Alternativa()
        alt.Show()
        'Me.Hide()
    End Sub

    Private Sub AnilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnilloToolStripMenuItem.Click
        Dim ani As New Anilloo()
        ani.Show()
        'Me.Hide()
    End Sub

    Private Sub colloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colloToolStripMenuItem.Click
        Dim coll As New Collo()
        coll.Show()
        'Me.Hide()
    End Sub

    Private Sub energiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles energiaToolStripMenuItem.Click
        Dim energ As New Energia()
        energ.Show()
        'Me.Hide()
    End Sub

    Private Sub permisosDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles permisosDeDocumentosToolStripMenuItem.Click
        Dim perm As New Permisos()
        perm.Show()
        'Me.Hide()
    End Sub

    Private Sub sitiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sitiosToolStripMenuItem.Click
        Dim sit As New Sitio()
        sit.Show()
        'Me.Hide()
    End Sub

    Private Sub cambioDeClaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cambioDeClaveToolStripMenuItem1.Click
        Dim cambs As New Cambio()
        cambs.Show()
        'Me.Hide()
    End Sub

    Private Sub CrearToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearToolStripMenuItem3.Click
        Dim crea As New Usuario()
        crea.Show()
        'Me.Hide()
    End Sub

    Private Sub acercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acercaDeToolStripMenuItem.Click
        Dim ACRK As New AcercaD()
        ACRK.Show()
        'Me.Hide()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub salirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirToolStripMenuItem.Click
        'For Each o In _session.Usuario.Vistas
        '    MenuToolStripMenuItem.DropDownItems.Item(o.Vista).Visible = True
        'Next
        ''Me.Close()
        ''End
    End Sub

End Class