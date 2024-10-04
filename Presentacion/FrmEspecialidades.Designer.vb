<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspecialidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        GbEspecialidad = New GroupBox()
        BtnSeleccionar = New Button()
        TxtMedico = New TextBox()
        LblMedico = New Label()
        TxtCosto = New TextBox()
        TxtNomb = New TextBox()
        LblCosto = New Label()
        LblName = New Label()
        GbEspecialidad.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(53, 285)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(75, 23)
        BtnGuardar.TabIndex = 5
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Location = New Point(385, 285)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(75, 23)
        BtnCancelar.TabIndex = 6
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' GbEspecialidad
        ' 
        GbEspecialidad.Controls.Add(BtnSeleccionar)
        GbEspecialidad.Controls.Add(TxtMedico)
        GbEspecialidad.Controls.Add(LblMedico)
        GbEspecialidad.Controls.Add(TxtCosto)
        GbEspecialidad.Controls.Add(TxtNomb)
        GbEspecialidad.Controls.Add(LblCosto)
        GbEspecialidad.Controls.Add(LblName)
        GbEspecialidad.Location = New Point(35, 48)
        GbEspecialidad.Name = "GbEspecialidad"
        GbEspecialidad.Size = New Size(445, 214)
        GbEspecialidad.TabIndex = 7
        GbEspecialidad.TabStop = False
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.Location = New Point(315, 40)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(75, 23)
        BtnSeleccionar.TabIndex = 10
        BtnSeleccionar.Text = "Seleccionar"
        BtnSeleccionar.UseVisualStyleBackColor = True
        ' 
        ' TxtMedico
        ' 
        TxtMedico.BackColor = SystemColors.InactiveCaption
        TxtMedico.Location = New Point(120, 37)
        TxtMedico.Name = "TxtMedico"
        TxtMedico.Size = New Size(180, 23)
        TxtMedico.TabIndex = 9
        ' 
        ' LblMedico
        ' 
        LblMedico.AutoSize = True
        LblMedico.Location = New Point(41, 40)
        LblMedico.Name = "LblMedico"
        LblMedico.Size = New Size(50, 15)
        LblMedico.TabIndex = 8
        LblMedico.Text = "Médico:"
        ' 
        ' TxtCosto
        ' 
        TxtCosto.Location = New Point(120, 168)
        TxtCosto.Name = "TxtCosto"
        TxtCosto.Size = New Size(180, 23)
        TxtCosto.TabIndex = 7
        ' 
        ' TxtNomb
        ' 
        TxtNomb.Location = New Point(120, 105)
        TxtNomb.Name = "TxtNomb"
        TxtNomb.Size = New Size(180, 23)
        TxtNomb.TabIndex = 6
        ' 
        ' LblCosto
        ' 
        LblCosto.AutoSize = True
        LblCosto.Location = New Point(41, 168)
        LblCosto.Name = "LblCosto"
        LblCosto.Size = New Size(41, 15)
        LblCosto.TabIndex = 5
        LblCosto.Text = "Costo:"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Location = New Point(41, 105)
        LblName.Name = "LblName"
        LblName.Size = New Size(54, 15)
        LblName.TabIndex = 4
        LblName.Text = "Nombre:"
        ' 
        ' FrmEspecialidades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 365)
        Controls.Add(GbEspecialidad)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnGuardar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmEspecialidades"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Especialidad"
        GbEspecialidad.ResumeLayout(False)
        GbEspecialidad.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GbEspecialidad As GroupBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents TxtNomb As TextBox
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblMedico As Label
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents BtnSeleccionar As Button
End Class
