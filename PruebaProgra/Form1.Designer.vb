<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnMorado = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.BackColor = System.Drawing.Color.Transparent
        Me.btnRojo.Location = New System.Drawing.Point(67, 48)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(87, 32)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = False
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(67, 97)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(87, 32)
        Me.btnVerde.TabIndex = 1
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(67, 147)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(87, 32)
        Me.btnAzul.TabIndex = 2
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(67, 191)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(87, 32)
        Me.btnAmarillo.TabIndex = 3
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnMorado
        '
        Me.btnMorado.Location = New System.Drawing.Point(67, 243)
        Me.btnMorado.Name = "btnMorado"
        Me.btnMorado.Size = New System.Drawing.Size(87, 32)
        Me.btnMorado.TabIndex = 4
        Me.btnMorado.Text = "Morado"
        Me.btnMorado.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(202, 48)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(371, 227)
        Me.txtColores.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(628, 314)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnMorado)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnMorado As Button
    Friend WithEvents txtColores As TextBox
End Class
