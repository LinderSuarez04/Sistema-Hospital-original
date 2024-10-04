Imports Entidades

Public Class FrmListarAtencion

    Private Sub FrmListarAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable
        Dim Aten As New EnAtencion
        tabla = Aten.ListarAtenciones()
        Me.DGVListaPaciente.DataSource = tabla

        DGVListaPaciente.Columns("idAtencion").HeaderText = "ID Atencion"
        DGVListaPaciente.Columns("NombreCompleto").HeaderText = "Paciente"
        DGVListaPaciente.Columns("dni").HeaderText = "DNI"
        DGVListaPaciente.Columns("DiagnosticoDescripcion").HeaderText = "Diagnostico"
        DGVListaPaciente.Columns("TipoOrdenMedica").HeaderText = "Tipo Orden Medica"
        DGVListaPaciente.Columns("CostoServicio").HeaderText = "Costo"
        DGVListaPaciente.Columns("estado").HeaderText = "Estado"
    End Sub



    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim tabla As DataTable

        Dim aten As New EnAtencion

        tabla = aten.BuscarAtencion(Me.TxtDni.Text)

        Me.DGVListaPaciente.DataSource = tabla
    End Sub

    Private Sub TxtDni_TextChanged(sender As Object, e As EventArgs) Handles TxtDni.TextChanged

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModificar As New FrmModificarAtencion
        FrmModificar.ShowDialog()
    End Sub
End Class