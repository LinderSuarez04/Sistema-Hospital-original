<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaEspe
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
        BtnAgregar = New Button()
        TxtBuscar = New TextBox()
        BtnBuscar = New Button()
        DGVEspecialidad = New DataGridView()
        HSBespecialidad = New HScrollBar()
        CType(DGVEspecialidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.PaleGoldenrod
        BtnAgregar.Location = New Point(31, 22)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(147, 30)
        BtnAgregar.TabIndex = 0
        BtnAgregar.Text = "Agregar Especialidad"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' TxtBuscar
        ' 
        TxtBuscar.Location = New Point(160, 91)
        TxtBuscar.Name = "TxtBuscar"
        TxtBuscar.PlaceholderText = "Ingrese Búsqueda"
        TxtBuscar.Size = New Size(253, 23)
        TxtBuscar.TabIndex = 1
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = SystemColors.ActiveCaption
        BtnBuscar.Location = New Point(419, 88)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(71, 30)
        BtnBuscar.TabIndex = 2
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' DGVEspecialidad
        ' 
        DGVEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVEspecialidad.Location = New Point(60, 145)
        DGVEspecialidad.Name = "DGVEspecialidad"
        DGVEspecialidad.Size = New Size(643, 173)
        DGVEspecialidad.TabIndex = 3
        ' 
        ' HSBespecialidad
        ' 
        HSBespecialidad.Location = New Point(625, 340)
        HSBespecialidad.Name = "HSBespecialidad"
        HSBespecialidad.Size = New Size(78, 17)
        HSBespecialidad.TabIndex = 4
        ' 
        ' FrmListaEspe
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(766, 411)
        Controls.Add(HSBespecialidad)
        Controls.Add(DGVEspecialidad)
        Controls.Add(BtnBuscar)
        Controls.Add(TxtBuscar)
        Controls.Add(BtnAgregar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmListaEspe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lista Especialidades"
        CType(DGVEspecialidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DGVEspecialidad As DataGridView
    Friend WithEvents HSBespecialidad As HScrollBar
End Class
