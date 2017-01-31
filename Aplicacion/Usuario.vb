Imports logica
Public Class Usuario
    Dim conexion As New CLUsuariosLG
    Dim conexion2 As New CLDepartamentoLG
    Dim usuario As New Entidades.E_Usuarios
    Private usuarios As ICollection(Of Entidades.E_Usuarios)
    Private Departamentos As ICollection(Of Entidades.E_Departamento)

    Private Sub Cargarcombo()
        Departamentos = conexion2.FindAll()
        cmdDpt.DataSource = Departamentos
        cmdDpt.DisplayMember = "Departamento"
        cmdDpt.ValueMember = "Id_Departamento"
    End Sub

    Private Sub limpiar()
        txtAp.Clear()
        txtCo.Clear()
        txtNm.Clear()
        txtU.Clear()
        cmdDpt.SelectedItem = Nothing
    End Sub



    Private Sub guardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarButton.Click
        usuario.Nombre = txtNm.Text
        usuario.Apellidos = txtAp.Text
        usuario.Nombre_Usuario = txtU.Text
        usuario.Contrasena = txtCo.Text
        usuario.Id_Departamento = cmdDpt.SelectedValue
        If conexion.Insert(usuario) = True Then
            MsgBox("Usuario ingresado correctamente")
        End If
        limpiar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        usuario.Nombre = txtNm.Text
        usuario.Apellidos = txtAp.Text
        usuario.Nombre_Usuario = txtU.Text
        usuario.Id_Departamento = cmdDpt.SelectedValue
        conexion.Update(usuario)
    End Sub

    Private Sub borrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conexion.Delete(usuario)
    End Sub

    Private Sub limpiarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarButton.Click
        limpiar()
    End Sub

    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click

    End Sub

    Private Sub Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargarcombo()
    End Sub
End Class