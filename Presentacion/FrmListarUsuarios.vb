Imports Entidades

Public Class FrmListarUsuarios
    Private Sub FrmListarUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tabla As DataTable
        Dim user As New EnUsuario
        tabla = user.listarUsuarios()
        Me.DgTablaUsuarios.DataSource = tabla

        DgTablaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim agregar As New FrmRegistrarUsuario
        agregar.ShowDialog()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim modificar As New FrmModificarUsuario
        modificar.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As New FrmEliminarUsuario
        eliminar.ShowDialog()
    End Sub

End Class