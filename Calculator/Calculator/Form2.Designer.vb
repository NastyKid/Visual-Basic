<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Other_Op
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Back_Calc = New System.Windows.Forms.Button()
        Me.key_sqrt = New System.Windows.Forms.Button()
        Me.key_exp = New System.Windows.Forms.Button()
        Me.key_QE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Back_Calc
        '
        Me.Back_Calc.Location = New System.Drawing.Point(12, 118)
        Me.Back_Calc.Name = "Back_Calc"
        Me.Back_Calc.Size = New System.Drawing.Size(170, 23)
        Me.Back_Calc.TabIndex = 0
        Me.Back_Calc.Text = "Back"
        Me.Back_Calc.UseVisualStyleBackColor = True
        '
        'key_sqrt
        '
        Me.key_sqrt.Location = New System.Drawing.Point(12, 12)
        Me.key_sqrt.Name = "key_sqrt"
        Me.key_sqrt.Size = New System.Drawing.Size(170, 23)
        Me.key_sqrt.TabIndex = 1
        Me.key_sqrt.Text = "Square Root"
        Me.key_sqrt.UseVisualStyleBackColor = True
        '
        'key_exp
        '
        Me.key_exp.Location = New System.Drawing.Point(12, 41)
        Me.key_exp.Name = "key_exp"
        Me.key_exp.Size = New System.Drawing.Size(170, 23)
        Me.key_exp.TabIndex = 2
        Me.key_exp.Text = "Exponent"
        Me.key_exp.UseVisualStyleBackColor = True
        '
        'key_QE
        '
        Me.key_QE.Location = New System.Drawing.Point(12, 70)
        Me.key_QE.Name = "key_QE"
        Me.key_QE.Size = New System.Drawing.Size(170, 23)
        Me.key_QE.TabIndex = 3
        Me.key_QE.Text = "Quadratic Equation"
        Me.key_QE.UseVisualStyleBackColor = True
        '
        'Other_Op
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 153)
        Me.Controls.Add(Me.key_QE)
        Me.Controls.Add(Me.key_exp)
        Me.Controls.Add(Me.key_sqrt)
        Me.Controls.Add(Me.Back_Calc)
        Me.Name = "Other_Op"
        Me.Text = "Other"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Back_Calc As System.Windows.Forms.Button
    Friend WithEvents key_sqrt As System.Windows.Forms.Button
    Friend WithEvents key_exp As System.Windows.Forms.Button
    Friend WithEvents key_QE As System.Windows.Forms.Button
End Class
