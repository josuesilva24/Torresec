Public Class Paises

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New MenuA()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Estamos en plena construcción de Perú", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Estamos en plena construcción de Ecuador", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("Estamos en plena construcción de Colombia", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("Estamos en plena construcción de Republica Dominicana", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MessageBox.Show("Estamos en plena construcción de Panamá", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MessageBox.Show("Estamos en plena construcción de Puerto Rico", "Información País", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class