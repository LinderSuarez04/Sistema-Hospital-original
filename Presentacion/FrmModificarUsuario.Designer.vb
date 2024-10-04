<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUsuario
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
        BtnRegistrar = New Button()
        Label9 = New Label()
        Panel2 = New Panel()
        CbRol = New ComboBox()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        LblConfirmarContraseña = New Label()
        LblContraseña = New Label()
        txtConfirmarContraseña = New TextBox()
        LblUsuario = New Label()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(271, 403)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(129, 42)
        BtnCancelar.TabIndex = 27
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.BackColor = Color.FromArgb(CByte(45), CByte(142), CByte(225))
        BtnRegistrar.FlatStyle = FlatStyle.Flat
        BtnRegistrar.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRegistrar.ForeColor = Color.White
        BtnRegistrar.Location = New Point(75, 403)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(137, 42)
        BtnRegistrar.TabIndex = 26
        BtnRegistrar.Text = "Guardar"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(43), CByte(155), CByte(227))
        Label9.Location = New Point(147, 116)
        Label9.Name = "Label9"
        Label9.Size = New Size(169, 23)
        Label9.TabIndex = 25
        Label9.Text = "Modificar usuario"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CbRol)
        Panel2.Controls.Add(txtUsuario)
        Panel2.Controls.Add(txtContraseña)
        Panel2.Controls.Add(LblConfirmarContraseña)
        Panel2.Controls.Add(LblContraseña)
        Panel2.Controls.Add(txtConfirmarContraseña)
        Panel2.Controls.Add(LblUsuario)
        Panel2.Location = New Point(75, 142)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(325, 234)
        Panel2.TabIndex = 24
        ' 
        ' CbRol
        ' 
        CbRol.FormattingEnabled = True
        CbRol.Location = New Point(30, 19)
        CbRol.Margin = New Padding(3, 2, 3, 2)
        CbRol.Name = "CbRol"
        CbRol.Size = New Size(133, 23)
        CbRol.TabIndex = 16
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(27, 68)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(265, 23)
        txtUsuario.TabIndex = 13
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(27, 117)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(265, 23)
        txtContraseña.TabIndex = 14
        ' 
        ' LblConfirmarContraseña
        ' 
        LblConfirmarContraseña.AutoSize = True
        LblConfirmarContraseña.Location = New Point(27, 156)
        LblConfirmarContraseña.Name = "LblConfirmarContraseña"
        LblConfirmarContraseña.Size = New Size(124, 15)
        LblConfirmarContraseña.TabIndex = 10
        LblConfirmarContraseña.Text = "Confirmar Contraseña"
        ' 
        ' LblContraseña
        ' 
        LblContraseña.AutoSize = True
        LblContraseña.Location = New Point(27, 99)
        LblContraseña.Name = "LblContraseña"
        LblContraseña.Size = New Size(67, 15)
        LblContraseña.TabIndex = 11
        LblContraseña.Text = "Contraseña"
        ' 
        ' txtConfirmarContraseña
        ' 
        txtConfirmarContraseña.Location = New Point(27, 174)
        txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        txtConfirmarContraseña.Size = New Size(265, 23)
        txtConfirmarContraseña.TabIndex = 15
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(27, 50)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(110, 15)
        LblUsuario.TabIndex = 9
        LblUsuario.Text = "Nombre de Usuario"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo1
        PictureBox1.Location = New Point(178, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(116, 103)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' FrmModificarUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(474, 465)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnRegistrar)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrmModificarUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmModificarUsuario"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CbRol As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents LblConfirmarContraseña As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents txtConfirmarContraseña As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
