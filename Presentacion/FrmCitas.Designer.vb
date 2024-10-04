<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCitas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblPaciente = New Label()
        LblEspecialidad = New Label()
        LblMedico = New Label()
        CbEspecialidad = New ComboBox()
        CbMedico = New ComboBox()
        LblDias = New Label()
        ChBLunes = New CheckBox()
        ChBMartes = New CheckBox()
        ChBMiercoles = New CheckBox()
        ChBJueves = New CheckBox()
        ChBViernes = New CheckBox()
        GBHorario = New GroupBox()
        DataGridView1 = New DataGridView()
        Col1 = New DataGridViewTextBoxColumn()
        Col2 = New DataGridViewTextBoxColumn()
        MCalendario = New MonthCalendar()
        LblDate = New Label()
        BtnGuardar = New Button()
        BtnCancelar = New Button()
        LblSecretaria = New Label()
        TxtSecretaria = New TextBox()
        TxtPaciente = New TextBox()
        BtnSeleccionar = New Button()
        GBHorario.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblPaciente
        ' 
        LblPaciente.AutoSize = True
        LblPaciente.BackColor = SystemColors.ActiveCaption
        LblPaciente.Location = New Point(240, 64)
        LblPaciente.Name = "LblPaciente"
        LblPaciente.Size = New Size(55, 15)
        LblPaciente.TabIndex = 0
        LblPaciente.Text = "Paciente:"
        ' 
        ' LblEspecialidad
        ' 
        LblEspecialidad.AutoSize = True
        LblEspecialidad.Location = New Point(238, 115)
        LblEspecialidad.Name = "LblEspecialidad"
        LblEspecialidad.Size = New Size(75, 15)
        LblEspecialidad.TabIndex = 1
        LblEspecialidad.Text = "Especialidad:"
        ' 
        ' LblMedico
        ' 
        LblMedico.AutoSize = True
        LblMedico.Location = New Point(238, 151)
        LblMedico.Name = "LblMedico"
        LblMedico.Size = New Size(50, 15)
        LblMedico.TabIndex = 2
        LblMedico.Text = "Médico:"
        ' 
        ' CbEspecialidad
        ' 
        CbEspecialidad.FormattingEnabled = True
        CbEspecialidad.Location = New Point(376, 107)
        CbEspecialidad.Name = "CbEspecialidad"
        CbEspecialidad.Size = New Size(240, 23)
        CbEspecialidad.TabIndex = 4
        CbEspecialidad.Text = "<seleccione>"
        ' 
        ' CbMedico
        ' 
        CbMedico.FormattingEnabled = True
        CbMedico.Location = New Point(376, 151)
        CbMedico.Name = "CbMedico"
        CbMedico.Size = New Size(240, 23)
        CbMedico.TabIndex = 5
        CbMedico.Text = "<seleccione>"
        ' 
        ' LblDias
        ' 
        LblDias.AutoSize = True
        LblDias.Location = New Point(121, 233)
        LblDias.Name = "LblDias"
        LblDias.Size = New Size(96, 15)
        LblDias.TabIndex = 6
        LblDias.Text = "Días Disponibles:"
        ' 
        ' ChBLunes
        ' 
        ChBLunes.AutoSize = True
        ChBLunes.Location = New Point(270, 233)
        ChBLunes.Name = "ChBLunes"
        ChBLunes.Size = New Size(32, 19)
        ChBLunes.TabIndex = 7
        ChBLunes.Text = "L"
        ChBLunes.UseVisualStyleBackColor = True
        ' 
        ' ChBMartes
        ' 
        ChBMartes.AutoSize = True
        ChBMartes.Location = New Point(342, 233)
        ChBMartes.Name = "ChBMartes"
        ChBMartes.Size = New Size(37, 19)
        ChBMartes.TabIndex = 8
        ChBMartes.Text = "M"
        ChBMartes.UseVisualStyleBackColor = True
        ' 
        ' ChBMiercoles
        ' 
        ChBMiercoles.AutoSize = True
        ChBMiercoles.Location = New Point(413, 233)
        ChBMiercoles.Name = "ChBMiercoles"
        ChBMiercoles.Size = New Size(33, 19)
        ChBMiercoles.TabIndex = 9
        ChBMiercoles.Text = "X"
        ChBMiercoles.UseVisualStyleBackColor = True
        ' 
        ' ChBJueves
        ' 
        ChBJueves.AutoSize = True
        ChBJueves.Location = New Point(489, 233)
        ChBJueves.Name = "ChBJueves"
        ChBJueves.Size = New Size(30, 19)
        ChBJueves.TabIndex = 10
        ChBJueves.Text = "J"
        ChBJueves.UseVisualStyleBackColor = True
        ' 
        ' ChBViernes
        ' 
        ChBViernes.AutoSize = True
        ChBViernes.Location = New Point(562, 233)
        ChBViernes.Name = "ChBViernes"
        ChBViernes.Size = New Size(33, 19)
        ChBViernes.TabIndex = 11
        ChBViernes.Text = "V"
        ChBViernes.UseVisualStyleBackColor = True
        ' 
        ' GBHorario
        ' 
        GBHorario.BackColor = Color.White
        GBHorario.Controls.Add(DataGridView1)
        GBHorario.Controls.Add(MCalendario)
        GBHorario.Location = New Point(121, 319)
        GBHorario.Name = "GBHorario"
        GBHorario.Size = New Size(578, 220)
        GBHorario.TabIndex = 15
        GBHorario.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Col1, Col2})
        DataGridView1.Location = New Point(323, 35)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 162)
        DataGridView1.TabIndex = 16
        ' 
        ' Col1
        ' 
        Col1.HeaderText = "Hora"
        Col1.Name = "Col1"
        ' 
        ' Col2
        ' 
        Col2.HeaderText = "Estado"
        Col2.Name = "Col2"
        ' 
        ' MCalendario
        ' 
        MCalendario.Location = New Point(10, 35)
        MCalendario.Name = "MCalendario"
        MCalendario.TabIndex = 15
        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.BackColor = Color.White
        LblDate.Location = New Point(121, 290)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(258, 15)
        LblDate.TabIndex = 16
        LblDate.Text = "Seleccionar fecha y hora disponibles para la cita"
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(118, 582)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(75, 23)
        BtnGuardar.TabIndex = 17
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Location = New Point(621, 582)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(75, 23)
        BtnCancelar.TabIndex = 18
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' LblSecretaria
        ' 
        LblSecretaria.AutoSize = True
        LblSecretaria.BackColor = SystemColors.ActiveCaption
        LblSecretaria.Location = New Point(240, 25)
        LblSecretaria.Name = "LblSecretaria"
        LblSecretaria.Size = New Size(61, 15)
        LblSecretaria.TabIndex = 19
        LblSecretaria.Text = "Secretaria:"
        ' 
        ' TxtSecretaria
        ' 
        TxtSecretaria.BackColor = SystemColors.ActiveCaption
        TxtSecretaria.Location = New Point(378, 22)
        TxtSecretaria.Name = "TxtSecretaria"
        TxtSecretaria.Size = New Size(240, 23)
        TxtSecretaria.TabIndex = 20
        ' 
        ' TxtPaciente
        ' 
        TxtPaciente.BackColor = SystemColors.ActiveCaption
        TxtPaciente.Location = New Point(378, 61)
        TxtPaciente.Name = "TxtPaciente"
        TxtPaciente.Size = New Size(238, 23)
        TxtPaciente.TabIndex = 21
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.Location = New Point(643, 61)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(75, 23)
        BtnSeleccionar.TabIndex = 22
        BtnSeleccionar.Text = "Seleccionar"
        BtnSeleccionar.UseVisualStyleBackColor = True
        ' 
        ' FrmCitas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 632)
        Controls.Add(BtnSeleccionar)
        Controls.Add(TxtPaciente)
        Controls.Add(TxtSecretaria)
        Controls.Add(LblSecretaria)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnGuardar)
        Controls.Add(LblDate)
        Controls.Add(GBHorario)
        Controls.Add(ChBViernes)
        Controls.Add(ChBJueves)
        Controls.Add(ChBMiercoles)
        Controls.Add(ChBMartes)
        Controls.Add(ChBLunes)
        Controls.Add(LblDias)
        Controls.Add(CbMedico)
        Controls.Add(CbEspecialidad)
        Controls.Add(LblMedico)
        Controls.Add(LblEspecialidad)
        Controls.Add(LblPaciente)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCitas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Cita"
        GBHorario.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblPaciente As Label
    Friend WithEvents LblEspecialidad As Label
    Friend WithEvents LblMedico As Label
    Friend WithEvents CbEspecialidad As ComboBox
    Friend WithEvents CbMedico As ComboBox
    Friend WithEvents LblDias As Label
    Friend WithEvents ChBLunes As CheckBox
    Friend WithEvents ChBMartes As CheckBox
    Friend WithEvents ChBMiercoles As CheckBox
    Friend WithEvents ChBJueves As CheckBox
    Friend WithEvents ChBViernes As CheckBox
    Friend WithEvents GBHorario As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents MCalendario As MonthCalendar
    Friend WithEvents LblDate As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblSecretaria As Label
    Friend WithEvents TxtSecretaria As TextBox
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents BtnSeleccionar As Button

End Class
