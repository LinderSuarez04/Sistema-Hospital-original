<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarAtencion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarAtencion))
        LblBuscarDni = New Label()
        BtnBuscar = New Button()
        BtnActivar = New Button()
        BtnModificar = New Button()
        TxtDni = New TextBox()
        BtnSalir = New Button()
        DGVListaPaciente = New DataGridView()
        Label2 = New Label()
        CType(DGVListaPaciente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblBuscarDni
        ' 
        LblBuscarDni.AutoSize = True
        LblBuscarDni.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBuscarDni.Location = New Point(26, 58)
        LblBuscarDni.Name = "LblBuscarDni"
        LblBuscarDni.Size = New Size(94, 21)
        LblBuscarDni.TabIndex = 0
        LblBuscarDni.Text = "Buscar DNI: "
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), Image)
        BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch
        BtnBuscar.Cursor = Cursors.Hand
        BtnBuscar.Location = New Point(485, 54)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(33, 32)
        BtnBuscar.TabIndex = 1
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' BtnActivar
        ' 
        BtnActivar.BackColor = Color.LawnGreen
        BtnActivar.Location = New Point(571, 529)
        BtnActivar.Name = "BtnActivar"
        BtnActivar.Size = New Size(75, 23)
        BtnActivar.TabIndex = 2
        BtnActivar.Text = "Activar"
        BtnActivar.UseVisualStyleBackColor = False
        ' 
        ' BtnModificar
        ' 
        BtnModificar.BackColor = Color.Aquamarine
        BtnModificar.Location = New Point(662, 529)
        BtnModificar.Name = "BtnModificar"
        BtnModificar.Size = New Size(75, 23)
        BtnModificar.TabIndex = 3
        BtnModificar.Text = "Modificar"
        BtnModificar.UseVisualStyleBackColor = False
        ' 
        ' TxtDni
        ' 
        TxtDni.Location = New Point(125, 58)
        TxtDni.Multiline = True
        TxtDni.Name = "TxtDni"
        TxtDni.Size = New Size(354, 24)
        TxtDni.TabIndex = 4
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnSalir.ForeColor = SystemColors.ButtonHighlight
        BtnSalir.Location = New Point(755, 529)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(75, 23)
        BtnSalir.TabIndex = 5
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' DGVListaPaciente
        ' 
        DGVListaPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVListaPaciente.Location = New Point(26, 98)
        DGVListaPaciente.Name = "DGVListaPaciente"
        DGVListaPaciente.Size = New Size(804, 416)
        DGVListaPaciente.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(331, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 30)
        Label2.TabIndex = 7
        Label2.Text = "LISTAR PACIENTE"
        ' 
        ' FrmListarAtencion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(854, 571)
        Controls.Add(Label2)
        Controls.Add(DGVListaPaciente)
        Controls.Add(BtnSalir)
        Controls.Add(TxtDni)
        Controls.Add(BtnModificar)
        Controls.Add(BtnActivar)
        Controls.Add(BtnBuscar)
        Controls.Add(LblBuscarDni)
        Name = "FrmListarAtencion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmListarAtencionPaciente"
        CType(DGVListaPaciente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblBuscarDni As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DGVListaPaciente As DataGridView
    Friend WithEvents Label2 As Label
End Class
