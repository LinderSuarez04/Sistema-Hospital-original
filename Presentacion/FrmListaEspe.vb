Imports Entidades

Public Class FrmListaEspe

    Private Sub FrmListarEspe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable
        Dim Aten As New EnEspecialidad
        tabla = Aten.listarEspecialidad()
        Me.DGVEspecialidad.DataSource = tabla

        DGVEspecialidad.Columns("idEspecialidad").HeaderText = "ID Especialidad"
        DGVEspecialidad.Columns("nombre_especialidad").HeaderText = "Especialidad"
        DGVEspecialidad.Columns("costo").HeaderText = "Costo"
        DGVEspecialidad.Columns("Nombres_Completos").HeaderText = "Nombres"
    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim especialidad As New FrmEspecialidades
        especialidad.Show()
    End Sub

    Private Sub DGVEspecialidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEspecialidad.CellContentClick

    End Sub

    Private Sub FrmListaEspe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class