'Imports BussinesLogic
'Imports BussinesLogic.UsuarioBL
Imports LOGICA
Public Class Login
    Dim conexion As New CLUsuariosLG
    Dim usuario As New Entidades.E_Usuarios

    Private Function validarcampos() As Boolean
        If txtUsuario.Text = "" Then

            MsgBox("Debe ingresar Usuario")
            Return False

        ElseIf txtClave.Text = "" Then
            MsgBox("Debe ingresar clave")
            Return False
        End If
        Return True

    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If validarcampos() = True Then
            usuario.Nombre_Usuario = txtUsuario.Text
            usuario.Contrasena = txtClave.Text

            If conexion.Validar(usuario) = True Then
                Dim alt As New Menu()
                alt.Show()
                Me.Hide()
            End If
            txtClave.Clear()
            txtUsuario.Clear()
        End If
       
    End Sub

End Class
