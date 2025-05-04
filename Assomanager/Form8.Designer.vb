<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.TextBox82 = New System.Windows.Forms.TextBox()
        Me.enregistrer8 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(23, 31)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(46, 20)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "Nom:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(23, 81)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(57, 20)
        Me.Label82.TabIndex = 1
        Me.Label82.Text = "Valeur:"
        Me.Label82.Visible = False
        '
        'TextBox81
        '
        Me.TextBox81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox81.Location = New System.Drawing.Point(87, 28)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(259, 26)
        Me.TextBox81.TabIndex = 2
        '
        'TextBox82
        '
        Me.TextBox82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox82.Location = New System.Drawing.Point(87, 78)
        Me.TextBox82.Multiline = True
        Me.TextBox82.Name = "TextBox82"
        Me.TextBox82.Size = New System.Drawing.Size(259, 114)
        Me.TextBox82.TabIndex = 3
        Me.TextBox82.Visible = False
        '
        'enregistrer8
        '
        Me.enregistrer8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregistrer8.Location = New System.Drawing.Point(87, 80)
        Me.enregistrer8.Name = "enregistrer8"
        Me.enregistrer8.Size = New System.Drawing.Size(110, 43)
        Me.enregistrer8.TabIndex = 4
        Me.enregistrer8.Text = "Ajouter"
        Me.enregistrer8.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(236, 80)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 43)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Fermer"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 180)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.enregistrer8)
        Me.Controls.Add(Me.TextBox82)
        Me.Controls.Add(Me.TextBox81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label81)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catégorie de membre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox82 As System.Windows.Forms.TextBox
    Friend WithEvents enregistrer8 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
