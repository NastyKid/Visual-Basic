<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvC_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PvC_Menu))
        Me.PvC_Back = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Number_Stick = New System.Windows.Forms.NumericUpDown()
        Me.PvC_Enter = New System.Windows.Forms.Button()
        Me.ReMatch = New System.Windows.Forms.Button()
        Me.Row1_stick = New System.Windows.Forms.Label()
        Me.Row2_stick = New System.Windows.Forms.Label()
        Me.Row3_stick = New System.Windows.Forms.Label()
        Me.Row4_stick = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Number_Stick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PvC_Back
        '
        Me.PvC_Back.Location = New System.Drawing.Point(10, 4)
        Me.PvC_Back.Name = "PvC_Back"
        Me.PvC_Back.Size = New System.Drawing.Size(75, 23)
        Me.PvC_Back.TabIndex = 0
        Me.PvC_Back.Text = "Back"
        Me.PvC_Back.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Location = New System.Drawing.Point(12, 37)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(56, 17)
        Me.R1.TabIndex = 1
        Me.R1.TabStop = True
        Me.R1.Text = "Row 1"
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Location = New System.Drawing.Point(12, 60)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(56, 17)
        Me.R2.TabIndex = 2
        Me.R2.TabStop = True
        Me.R2.Text = "Row 2"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Location = New System.Drawing.Point(12, 84)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(56, 17)
        Me.R3.TabIndex = 3
        Me.R3.TabStop = True
        Me.R3.Text = "Row 3"
        Me.R3.UseVisualStyleBackColor = True
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.Location = New System.Drawing.Point(12, 106)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(56, 17)
        Me.R4.TabIndex = 4
        Me.R4.TabStop = True
        Me.R4.Text = "Row 4"
        Me.R4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "# of Stick"
        '
        'Number_Stick
        '
        Me.Number_Stick.Location = New System.Drawing.Point(70, 139)
        Me.Number_Stick.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Number_Stick.Name = "Number_Stick"
        Me.Number_Stick.Size = New System.Drawing.Size(61, 20)
        Me.Number_Stick.TabIndex = 6
        '
        'PvC_Enter
        '
        Me.PvC_Enter.Location = New System.Drawing.Point(149, 137)
        Me.PvC_Enter.Name = "PvC_Enter"
        Me.PvC_Enter.Size = New System.Drawing.Size(75, 23)
        Me.PvC_Enter.TabIndex = 7
        Me.PvC_Enter.Text = "Enter"
        Me.PvC_Enter.UseVisualStyleBackColor = True
        '
        'ReMatch
        '
        Me.ReMatch.Location = New System.Drawing.Point(149, 137)
        Me.ReMatch.Name = "ReMatch"
        Me.ReMatch.Size = New System.Drawing.Size(75, 23)
        Me.ReMatch.TabIndex = 8
        Me.ReMatch.Text = "Rematch"
        Me.ReMatch.UseVisualStyleBackColor = True
        Me.ReMatch.Visible = False
        '
        'Row1_stick
        '
        Me.Row1_stick.AutoSize = True
        Me.Row1_stick.Location = New System.Drawing.Point(97, 39)
        Me.Row1_stick.Name = "Row1_stick"
        Me.Row1_stick.Size = New System.Drawing.Size(9, 13)
        Me.Row1_stick.TabIndex = 9
        Me.Row1_stick.Text = "|"
        '
        'Row2_stick
        '
        Me.Row2_stick.AutoSize = True
        Me.Row2_stick.Location = New System.Drawing.Point(97, 62)
        Me.Row2_stick.Name = "Row2_stick"
        Me.Row2_stick.Size = New System.Drawing.Size(37, 13)
        Me.Row2_stick.TabIndex = 10
        Me.Row2_stick.Text = "|    |    |"
        '
        'Row3_stick
        '
        Me.Row3_stick.AutoSize = True
        Me.Row3_stick.Location = New System.Drawing.Point(97, 86)
        Me.Row3_stick.Name = "Row3_stick"
        Me.Row3_stick.Size = New System.Drawing.Size(65, 13)
        Me.Row3_stick.TabIndex = 11
        Me.Row3_stick.Text = "|    |    |    |    |"
        '
        'Row4_stick
        '
        Me.Row4_stick.AutoSize = True
        Me.Row4_stick.Location = New System.Drawing.Point(97, 108)
        Me.Row4_stick.Name = "Row4_stick"
        Me.Row4_stick.Size = New System.Drawing.Size(93, 13)
        Me.Row4_stick.TabIndex = 12
        Me.Row4_stick.Text = "|    |    |    |    |    |    |"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "1"
        '
        'PvC_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 172)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Row4_stick)
        Me.Controls.Add(Me.Row3_stick)
        Me.Controls.Add(Me.Row2_stick)
        Me.Controls.Add(Me.Row1_stick)
        Me.Controls.Add(Me.ReMatch)
        Me.Controls.Add(Me.PvC_Enter)
        Me.Controls.Add(Me.Number_Stick)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.R4)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.PvC_Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PvC_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GON"
        CType(Me.Number_Stick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PvC_Back As Button
    Friend WithEvents R1 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R3 As RadioButton
    Friend WithEvents R4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Number_Stick As NumericUpDown
    Friend WithEvents PvC_Enter As Button
    Friend WithEvents ReMatch As Button
    Friend WithEvents Row1_stick As Label
    Friend WithEvents Row2_stick As Label
    Friend WithEvents Row3_stick As Label
    Friend WithEvents Row4_stick As Label
    Friend WithEvents Label2 As Label
End Class
