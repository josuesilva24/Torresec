Imports LOGICA
Public Class Cambio
    Dim conexion As New CLUsuariosLG
    Dim usuario As New Entidades.E_Usuarios
    Private usuarios As ICollection(Of Entidades.E_Usuarios)
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub limpiar()
        txtContra.Clear()
        txtUsu.Clear()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        usuario.Nombre_Usuario = txtUsu.Text
        usuario = conexion.FindAll(usuario)
        usuario.Contrasena = txtContra.Text()
        If conexion.Update(usuario) = True Then
            MsgBox("Se relizó el cambio, satisfactoriamente")

        End If
        limpiar()
    End Sub
End Class