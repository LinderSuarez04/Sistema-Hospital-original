<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarAtencion
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
        BtnCancelar = New Button()
        BtnGuardar = New Button()
        LblPaciente = New Label()
        LblDni = New Label()
        LblDiagnostico = New Label()
        LblTipoOrdenMedica = New Label()
        LblCosto = New Label()
        LblEstado = New Label()
        TxtPaciente = New TextBox()
        TxtDni = New TextBox()
        CbDiagnostico = New ComboBox()
        CbTipoOrdenMedica = New ComboBox()
        TxtCosto = New TextBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(251, 435)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(129, 42)
        BtnCancelar.TabIndex = 28
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnGuardar.FlatStyle = FlatStyle.Flat
        BtnGuardar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnGuardar.ForeColor = Color.White
        BtnGuardar.Location = New Point(64, 435)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(137, 42)
        BtnGuardar.TabIndex = 29
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' LblPaciente
        ' 
        LblPaciente.AutoSize = True
        LblPaciente.Location = New Point(27, 70)
        LblPaciente.Name = "LblPaciente"
        LblPaciente.Size = New Size(65, 15)
        LblPaciente.TabIndex = 30
        LblPaciente.Text = "PACIENTE :"
        ' 
        ' LblDni
        ' 
        LblDni.AutoSize = True
        LblDni.Location = New Point(268, 101)
        LblDni.Name = "LblDni"
        LblDni.Size = New Size(33, 15)
        LblDni.TabIndex = 31
        LblDni.Text = "DNI :"
        ' 
        ' LblDiagnostico
        ' 
        LblDiagnostico.AutoSize = True
        LblDiagnostico.Location = New Point(27, 173)
        LblDiagnostico.Name = "LblDiagnostico"
        LblDiagnostico.Size = New Size(90, 15)
        LblDiagnostico.TabIndex = 32
        LblDiagnostico.Text = "DIAGNOSTICO :"
        ' 
        ' LblTipoOrdenMedica
        ' 
        LblTipoOrdenMedica.AutoSize = True
        LblTipoOrdenMedica.Location = New Point(27, 229)
        LblTipoOrdenMedica.Name = "LblTipoOrdenMedica"
        LblTipoOrdenMedica.Size = New Size(127, 15)
        LblTipoOrdenMedica.TabIndex = 33
        LblTipoOrdenMedica.Text = "TIPO ORDEN MEDICA :"
        ' 
        ' LblCosto
        ' 
        LblCosto.AutoSize = True
        LblCosto.Location = New Point(251, 264)
        LblCosto.Name = "LblCosto"
        LblCosto.Size = New Size(50, 15)
        LblCosto.TabIndex = 34
        LblCosto.Text = "COSTO :"
        ' 
        ' LblEstado
        ' 
        LblEstado.AutoSize = True
        LblEstado.Location = New Point(27, 321)
        LblEstado.Name = "LblEstado"
        LblEstado.Size = New Size(55, 15)
        LblEstado.TabIndex = 35
        LblEstado.Text = "ESTADO :"
        ' 
        ' TxtPaciente
        ' 
        TxtPaciente.Location = New Point(27, 98)
        TxtPaciente.Name = "TxtPaciente"
        TxtPaciente.Size = New Size(223, 23)
        TxtPaciente.TabIndex = 36
        ' 
        ' TxtDni
        ' 
        TxtDni.Location = New Point(323, 98)
        TxtDni.Name = "TxtDni"
        TxtDni.Size = New Size(118, 23)
        TxtDni.TabIndex = 37
        ' 
        ' CbDiagnostico
        ' 
        CbDiagnostico.FormattingEnabled = True
        CbDiagnostico.Location = New Point(135, 170)
        CbDiagnostico.Name = "CbDiagnostico"
        CbDiagnostico.Size = New Size(306, 23)
        CbDiagnostico.TabIndex = 38
        ' 
        ' CbTipoOrdenMedica
        ' 
        CbTipoOrdenMedica.FormattingEnabled = True
        CbTipoOrdenMedica.Location = New Point(27, 261)
        CbTipoOrdenMedica.Name = "CbTipoOrdenMedica"
        CbTipoOrdenMedica.Size = New Size(186, 23)
        CbTipoOrdenMedica.TabIndex = 39
        ' 
        ' TxtCosto
        ' 
        TxtCosto.Location = New Point(323, 261)
        TxtCosto.Name = "TxtCosto"
        TxtCosto.Size = New Size(118, 23)
        TxtCosto.TabIndex = 40
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(97, 318)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 23)
        ComboBox1.TabIndex = 41
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(117, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 25)
        Label1.TabIndex = 42
        Label1.Text = "MODIFICAR ATENCIÓN"
        ' 
        ' FrmModificarAtencion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(462, 524)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(TxtCosto)
        Controls.Add(CbTipoOrdenMedica)
        Controls.Add(CbDiagnostico)
        Controls.Add(TxtDni)
        Controls.Add(TxtPaciente)
        Controls.Add(LblEstado)
        Controls.Add(LblCosto)
        Controls.Add(LblTipoOrdenMedica)
        Controls.Add(LblDiagnostico)
        Controls.Add(LblDni)
        Controls.Add(LblPaciente)
        Controls.Add(BtnGuardar)
        Controls.Add(BtnCancelar)
        Name = "FrmModificarAtencion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmModificarAtencion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LblPaciente As Label
    Friend WithEvents LblDni As Label
    Friend WithEvents LblDiagnostico As Label
    Friend WithEvents LblTipoOrdenMedica As Label
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents CbDiagnostico As ComboBox
    Friend WithEvents CbTipoOrdenMedica As ComboBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
