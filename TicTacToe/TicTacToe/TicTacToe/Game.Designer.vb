<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Me.Box1 = New System.Windows.Forms.Button()
        Me.Box2 = New System.Windows.Forms.Button()
        Me.Box3 = New System.Windows.Forms.Button()
        Me.Box4 = New System.Windows.Forms.Button()
        Me.Box5 = New System.Windows.Forms.Button()
        Me.Box6 = New System.Windows.Forms.Button()
        Me.Box7 = New System.Windows.Forms.Button()
        Me.Box8 = New System.Windows.Forms.Button()
        Me.Box9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.p_score = New System.Windows.Forms.Label()
        Me.c_score = New System.Windows.Forms.Label()
        Me.b_score = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.player_turn = New System.Windows.Forms.Label()
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Timer(Me.components)
        Me.Bot = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RndNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Box1
        '
        Me.Box1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box1.Location = New System.Drawing.Point(26, 51)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(51, 44)
        Me.Box1.TabIndex = 0
        Me.Box1.UseVisualStyleBackColor = True
        '
        'Box2
        '
        Me.Box2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box2.Location = New System.Drawing.Point(83, 51)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(51, 44)
        Me.Box2.TabIndex = 1
        Me.Box2.UseVisualStyleBackColor = True
        '
        'Box3
        '
        Me.Box3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box3.Location = New System.Drawing.Point(140, 51)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(51, 44)
        Me.Box3.TabIndex = 2
        Me.Box3.UseVisualStyleBackColor = True
        '
        'Box4
        '
        Me.Box4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box4.Location = New System.Drawing.Point(26, 101)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(51, 44)
        Me.Box4.TabIndex = 3
        Me.Box4.UseVisualStyleBackColor = True
        '
        'Box5
        '
        Me.Box5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box5.Location = New System.Drawing.Point(83, 101)
        Me.Box5.Name = "Box5"
        Me.Box5.Size = New System.Drawing.Size(51, 44)
        Me.Box5.TabIndex = 4
        Me.Box5.UseVisualStyleBackColor = True
        '
        'Box6
        '
        Me.Box6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box6.Location = New System.Drawing.Point(140, 101)
        Me.Box6.Name = "Box6"
        Me.Box6.Size = New System.Drawing.Size(51, 44)
        Me.Box6.TabIndex = 5
        Me.Box6.UseVisualStyleBackColor = True
        '
        'Box7
        '
        Me.Box7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box7.Location = New System.Drawing.Point(26, 151)
        Me.Box7.Name = "Box7"
        Me.Box7.Size = New System.Drawing.Size(51, 44)
        Me.Box7.TabIndex = 6
        Me.Box7.UseVisualStyleBackColor = True
        '
        'Box8
        '
        Me.Box8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box8.Location = New System.Drawing.Point(83, 151)
        Me.Box8.Name = "Box8"
        Me.Box8.Size = New System.Drawing.Size(51, 44)
        Me.Box8.TabIndex = 7
        Me.Box8.UseVisualStyleBackColor = True
        '
        'Box9
        '
        Me.Box9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box9.Location = New System.Drawing.Point(140, 151)
        Me.Box9.Name = "Box9"
        Me.Box9.Size = New System.Drawing.Size(51, 44)
        Me.Box9.TabIndex = 8
        Me.Box9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Challenger:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Computer:"
        '
        'p_score
        '
        Me.p_score.AutoSize = True
        Me.p_score.Location = New System.Drawing.Point(183, 13)
        Me.p_score.Name = "p_score"
        Me.p_score.Size = New System.Drawing.Size(0, 13)
        Me.p_score.TabIndex = 12
        '
        'c_score
        '
        Me.c_score.AutoSize = True
        Me.c_score.Location = New System.Drawing.Point(67, 208)
        Me.c_score.Name = "c_score"
        Me.c_score.Size = New System.Drawing.Size(13, 13)
        Me.c_score.TabIndex = 13
        Me.c_score.Text = "0"
        '
        'b_score
        '
        Me.b_score.AutoSize = True
        Me.b_score.Location = New System.Drawing.Point(152, 208)
        Me.b_score.Name = "b_score"
        Me.b_score.Size = New System.Drawing.Size(13, 13)
        Me.b_score.TabIndex = 14
        Me.b_score.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "TURN"
        '
        'player_turn
        '
        Me.player_turn.AutoSize = True
        Me.player_turn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player_turn.Location = New System.Drawing.Point(87, 13)
        Me.player_turn.Name = "player_turn"
        Me.player_turn.Size = New System.Drawing.Size(45, 39)
        Me.player_turn.TabIndex = 16
        Me.player_turn.Text = "O"
        '
        'Back_btn
        '
        Me.Back_btn.Location = New System.Drawing.Point(5, 3)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(39, 23)
        Me.Back_btn.TabIndex = 17
        Me.Back_btn.Text = "<----"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Enabled = True
        Me.Update.Interval = 1
        '
        'Bot
        '
        Me.Bot.Interval = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Round #"
        '
        'RndNo
        '
        Me.RndNo.AutoSize = True
        Me.RndNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RndNo.Location = New System.Drawing.Point(190, 0)
        Me.RndNo.Name = "RndNo"
        Me.RndNo.Size = New System.Drawing.Size(16, 16)
        Me.RndNo.TabIndex = 19
        Me.RndNo.Text = "1"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 224)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RndNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.player_turn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.b_score)
        Me.Controls.Add(Me.c_score)
        Me.Controls.Add(Me.p_score)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Box9)
        Me.Controls.Add(Me.Box8)
        Me.Controls.Add(Me.Box7)
        Me.Controls.Add(Me.Box6)
        Me.Controls.Add(Me.Box5)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " 3T's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Box1 As Button
    Friend WithEvents Box2 As Button
    Friend WithEvents Box3 As Button
    Friend WithEvents Box4 As Button
    Friend WithEvents Box5 As Button
    Friend WithEvents Box6 As Button
    Friend WithEvents Box7 As Button
    Friend WithEvents Box8 As Button
    Friend WithEvents Box9 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents p_score As Label
    Friend WithEvents c_score As Label
    Friend WithEvents b_score As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents player_turn As Label
    Friend WithEvents Back_btn As Button
    Friend WithEvents Update As Timer
    Friend WithEvents Bot As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents RndNo As Label
End Class
