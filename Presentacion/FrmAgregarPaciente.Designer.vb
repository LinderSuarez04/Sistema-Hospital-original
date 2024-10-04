<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarPaciente
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
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DtFechaRegistro = New DateTimePicker()
        DtFechaNac = New DateTimePicker()
        TxtNombres = New TextBox()
        TxtApellidoPaterno = New TextBox()
        TxtApellidoMaterno = New TextBox()
        TxtDni = New TextBox()
        BtnEliminar = New Button()
        BtnAgregar = New Button()
        BtnNuevo = New Button()
        LblTitulo = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(254, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 23)
        Label2.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(79, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 15
        Label1.Text = "Nombres:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(79, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 20)
        Label3.TabIndex = 16
        Label3.Text = "Apellido Paterno:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(76, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 20)
        Label4.TabIndex = 17
        Label4.Text = "Apellido Materno:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(79, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 20)
        Label5.TabIndex = 18
        Label5.Text = "Dni:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(76, 396)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 20)
        Label6.TabIndex = 19
        Label6.Text = "Fecha de Nacimiento:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(84, 130)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 20)
        Label7.TabIndex = 21
        Label7.Text = "Fecha de registro:"
        ' 
        ' DtFechaRegistro
        ' 
        DtFechaRegistro.Location = New Point(234, 125)
        DtFechaRegistro.Name = "DtFechaRegistro"
        DtFechaRegistro.Size = New Size(274, 27)
        DtFechaRegistro.TabIndex = 22
        ' 
        ' DtFechaNac
        ' 
        DtFechaNac.Location = New Point(234, 396)
        DtFechaNac.Name = "DtFechaNac"
        DtFechaNac.Size = New Size(274, 27)
        DtFechaNac.TabIndex = 23
        ' 
        ' TxtNombres
        ' 
        TxtNombres.Location = New Point(234, 186)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(274, 27)
        TxtNombres.TabIndex = 24
        ' 
        ' TxtApellidoPaterno
        ' 
        TxtApellidoPaterno.Location = New Point(234, 235)
        TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        TxtApellidoPaterno.Size = New Size(274, 27)
        TxtApellidoPaterno.TabIndex = 25
        ' 
        ' TxtApellidoMaterno
        ' 
        TxtApellidoMaterno.Location = New Point(234, 287)
        TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        TxtApellidoMaterno.Size = New Size(274, 27)
        TxtApellidoMaterno.TabIndex = 26
        ' 
        ' TxtDni
        ' 
        TxtDni.Location = New Point(234, 343)
        TxtDni.Name = "TxtDni"
        TxtDni.Size = New Size(274, 27)
        TxtDni.TabIndex = 27
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.Red
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEliminar.ForeColor = Color.White
        BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BtnEliminar.Location = New Point(372, 505)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(117, 44)
        BtnEliminar.TabIndex = 28
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnAgregar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnAgregar.Cursor = Cursors.Hand
        BtnAgregar.FlatStyle = FlatStyle.Flat
        BtnAgregar.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        BtnAgregar.ForeColor = Color.White
        BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft
        BtnAgregar.Location = New Point(249, 506)
        BtnAgregar.Margin = New Padding(3, 4, 3, 4)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(117, 43)
        BtnAgregar.TabIndex = 29
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnNuevo.BackColor = Color.DarkTurquoise
        BtnNuevo.BackgroundImageLayout = ImageLayout.Zoom
        BtnNuevo.Cursor = Cursors.Hand
        BtnNuevo.FlatStyle = FlatStyle.Flat
        BtnNuevo.Font = New Font("Century Gothic", 9F, FontStyle.Bold)
        BtnNuevo.ForeColor = Color.White
        BtnNuevo.ImageAlign = ContentAlignment.MiddleLeft
        BtnNuevo.Location = New Point(126, 506)
        BtnNuevo.Margin = New Padding(3, 4, 3, 4)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(117, 43)
        BtnNuevo.TabIndex = 30
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = False
        ' 
        ' LblTitulo
        ' 
        LblTitulo.AutoSize = True
        LblTitulo.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitulo.ForeColor = Color.Black
        LblTitulo.Location = New Point(179, 40)
        LblTitulo.Name = "LblTitulo"
        LblTitulo.Size = New Size(249, 28)
        LblTitulo.TabIndex = 33
        LblTitulo.Text = "REGISTRAR PACIENTE"
        ' 
        ' FrmAgregarPaciente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(606, 596)
        Controls.Add(LblTitulo)
        Controls.Add(BtnNuevo)
        Controls.Add(BtnAgregar)
        Controls.Add(BtnEliminar)
        Controls.Add(TxtDni)
        Controls.Add(TxtApellidoMaterno)
        Controls.Add(TxtApellidoPaterno)
        Controls.Add(TxtNombres)
        Controls.Add(DtFechaNac)
        Controls.Add(DtFechaRegistro)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "FrmAgregarPaciente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Paciente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtFechaRegistro As DateTimePicker
    Friend WithEvents DtFechaNac As DateTimePicker
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LblTitulo As Label
End Class
