Public Class FrmAgregarPaciente
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim agregarUsuario As New FrmRegistrarUsuario
        agregarUsuario.ShowDialog()
    End Sub
End Class