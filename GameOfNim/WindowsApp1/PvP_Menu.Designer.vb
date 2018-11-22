<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PvP_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PvP_Menu))
        Me.PvP_Enter = New System.Windows.Forms.Button()
        Me.Player_turn = New System.Windows.Forms.Label()
        Me.Player = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Row1_stick = New System.Windows.Forms.Label()
        Me.Row2_stick = New System.Windows.Forms.Label()
        Me.Row3_stick = New System.Windows.Forms.Label()
        Me.Row4_stick = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PvP_Back = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.Number_Stick = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReMatch = New System.Windows.Forms.Button()
        CType(Me.Number_Stick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PvP_Enter
        '
        Me.PvP_Enter.Location = New System.Drawing.Point(149, 137)
        Me.PvP_Enter.Name = "PvP_Enter"
        Me.PvP_Enter.Size = New System.Drawing.Size(75, 23)
        Me.PvP_Enter.TabIndex = 4
        Me.PvP_Enter.Text = "Enter"
        Me.PvP_Enter.UseVisualStyleBackColor = True
        '
        'Player_turn
        '
        Me.Player_turn.AutoSize = True
        Me.Player_turn.Location = New System.Drawing.Point(94, 9)
        Me.Player_turn.Name = "Player_turn"
        Me.Player_turn.Size = New System.Drawing.Size(0, 13)
        Me.Player_turn.TabIndex = 5
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(97, 8)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(56, 16)
        Me.Player.TabIndex = 6
        Me.Player.Text = "Player : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "# of Stick"
        '
        'Row1_stick
        '
        Me.Row1_stick.AutoSize = True
        Me.Row1_stick.Location = New System.Drawing.Point(97, 39)
        Me.Row1_stick.Name = "Row1_stick"
        Me.Row1_stick.Size = New System.Drawing.Size(9, 13)
        Me.Row1_stick.TabIndex = 13
        Me.Row1_stick.Text = "|"
        '
        'Row2_stick
        '
        Me.Row2_stick.AutoSize = True
        Me.Row2_stick.Location = New System.Drawing.Point(97, 62)
        Me.Row2_stick.Name = "Row2_stick"
        Me.Row2_stick.Size = New System.Drawing.Size(37, 13)
        Me.Row2_stick.TabIndex = 14
        Me.Row2_stick.Text = "|    |    |"
        '
        'Row3_stick
        '
        Me.Row3_stick.AutoSize = True
        Me.Row3_stick.Location = New System.Drawing.Point(97, 86)
        Me.Row3_stick.Name = "Row3_stick"
        Me.Row3_stick.Size = New System.Drawing.Size(65, 13)
        Me.Row3_stick.TabIndex = 15
        Me.Row3_stick.Text = "|    |    |    |    |"
        '
        'Row4_stick
        '
        Me.Row4_stick.AutoSize = True
        Me.Row4_stick.Location = New System.Drawing.Point(97, 108)
        Me.Row4_stick.Name = "Row4_stick"
        Me.Row4_stick.Size = New System.Drawing.Size(93, 13)
        Me.Row4_stick.TabIndex = 16
        Me.Row4_stick.Text = "|    |    |    |    |    |    |"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "1"
        '
        'PvP_Back
        '
        Me.PvP_Back.Location = New System.Drawing.Point(10, 4)
        Me.PvP_Back.Name = "PvP_Back"
        Me.PvP_Back.Size = New System.Drawing.Size(75, 23)
        Me.PvP_Back.TabIndex = 18
        Me.PvP_Back.Text = "Back"
        Me.PvP_Back.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Location = New System.Drawing.Point(12, 37)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(56, 17)
        Me.R1.TabIndex = 19
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
        Me.R2.TabIndex = 20
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
        Me.R3.TabIndex = 21
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
        Me.R4.TabIndex = 22
        Me.R4.TabStop = True
        Me.R4.Text = "Row 4"
        Me.R4.UseVisualStyleBackColor = True
        '
        'Number_Stick
        '
        Me.Number_Stick.Location = New System.Drawing.Point(70, 139)
        Me.Number_Stick.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Number_Stick.Name = "Number_Stick"
        Me.Number_Stick.Size = New System.Drawing.Size(61, 20)
        Me.Number_Stick.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Turn"
        '
        'ReMatch
        '
        Me.ReMatch.Enabled = False
        Me.ReMatch.Location = New System.Drawing.Point(149, 137)
        Me.ReMatch.Name = "ReMatch"
        Me.ReMatch.Size = New System.Drawing.Size(75, 23)
        Me.ReMatch.TabIndex = 25
        Me.ReMatch.Text = "Rematch"
        Me.ReMatch.UseVisualStyleBackColor = True
        Me.ReMatch.Visible = False
        '
        'PvP_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 172)
        Me.Controls.Add(Me.ReMatch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Number_Stick)
        Me.Controls.Add(Me.R4)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.PvP_Back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Row4_stick)
        Me.Controls.Add(Me.Row3_stick)
        Me.Controls.Add(Me.Row2_stick)
        Me.Controls.Add(Me.Row1_stick)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Player_turn)
        Me.Controls.Add(Me.PvP_Enter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PvP_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GON"
        CType(Me.Number_Stick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PvP_Enter As Button
    Friend WithEvents Player_turn As Label
    Friend WithEvents Player As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Row1_stick As Label
    Friend WithEvents Row2_stick As Label
    Friend WithEvents Row3_stick As Label
    Friend WithEvents Row4_stick As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PvP_Back As Button
    Friend WithEvents R1 As RadioButton
    Friend WithEvents R2 As RadioButton
    Friend WithEvents R3 As RadioButton
    Friend WithEvents R4 As RadioButton
    Friend WithEvents Number_Stick As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents ReMatch As Button
End Class
