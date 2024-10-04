Imports System.ComponentModel

Public Class FrmPrincipal
    'Private Sub RegistrarCitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarCitaToolStripMenuItem.Click
    '    Dim RegistrarCita As New FrmCita
    '    Me.Hide()
    '    RegistrarCita.ShowDialog()
    '    Me.Close()
    'End Sub

    'Private Sub RegistrarEspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarEspecialidadToolStripMenuItem.Click
    '    Dim RegistrarEspecialidad As New FrmAgregarEsp
    '    Me.Hide()
    '    RegistrarEspecialidad.ShowDialog()
    '    Me.Close()
    'End Sub

    'Private Sub ListarEspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarEspecialidadesToolStripMenuItem.Click
    '    Dim ListarEspecialidades As New FrmEspecialidades
    '    Me.Hide()
    '    ListarEspecialidades.ShowDialog()
    '    Me.Close()
    'End Sub

    'Private Sub RegistrarAtencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAtencionToolStripMenuItem.Click
    '    Dim RegistrarAtencion As New FrmNuevaAtencion
    '    Me.Hide()
    '    RegistrarAtencion.ShowDialog()
    '    Me.Close()
    'End Sub

    'Private Sub ListarAtencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarAtencionToolStripMenuItem.Click
    '    Dim ListarAtencion As New FrmAtencion
    '    Me.Hide()
    '    ListarAtencion.ShowDialog()
    '    Me.Close()
    'End Sub

    Private Sub ListarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarUsuariosToolStripMenuItem.Click
        Dim ListarUsuarios As New FrmListarUsuarios
        ListarUsuarios.ShowDialog()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

        ' Aplica el renderizador personalizado al MenuStrip
        MenuStrip1.Renderer = New CustomRenderer()
    End Sub
    Public Class CustomRenderer
        Inherits ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            MyBase.OnRenderMenuItemBackground(e)

            If e.Item.Selected Then
                ' Cambia el color de fondo cuando el cursor está sobre el elemento del menú
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Item.Bounds)
            End If
        End Sub
    End Class

    Private Sub ListarPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarPacientesToolStripMenuItem.Click
        Dim ListarPacientes As New FrmListarPacientes
        ListarPacientes.ShowDialog()
    End Sub

    Private Sub AgregarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPacienteToolStripMenuItem.Click
        Dim AgregarPaciente As New FrmAgregarPaciente
        AgregarPaciente.ShowDialog()
    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim cerrarSesion As New FrmLogin
        Me.Hide()
        cerrarSesion.ShowDialog()

    End Sub

    Private Sub RegistrarAtencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAtencionToolStripMenuItem.Click
        Dim MostrarPrincipalAtencion As New FrmPrincipalAtencion
        MostrarPrincipalAtencion.ShowDialog()

    End Sub

    Private Sub ListarAtencionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarAtencionToolStripMenuItem.Click
        Dim ListarAtencion As New FrmListarAtencion
        ListarAtencion.ShowDialog()
    End Sub

    Private Sub ListarEspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarEspecialidadesToolStripMenuItem.Click
        Dim ListarEspecialidad As New FrmListaEspe
        ListarEspecialidad.ShowDialog()
    End Sub
End Class