Public Class Game2
    Dim identifier As Integer = 0 ' Step Identifier 
    Dim AI_Score As Integer = 0 ' Scores
    Dim PL_Score As Integer = 0 ' Scores
    Dim NumRounds As Integer = 1 ' Rounds
    Dim x As Integer  ' Randum boxes 

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles Update.Tick

        PScore.Text = PL_Score
        AiScore.Text = AI_Score
        RndNo.Text = NumRounds
        ' AI
        If (Box4.Text = "O" And Box5.Text = "O" And Box6.Text = "O") Or (Box2.Text = "O" And Box5.Text = "O" And Box8.Text = "O") Or (Box1.Text = "O" And Box2.Text = "O" And Box3.Text = "O") Or (Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "O") Or (Box1.Text = "O" And Box4.Text = "O" And Box7.Text = "O") Or (Box7.Text = "O" And Box8.Text = "O" And Box9.Text = "O") Or (Box7.Text = "O" And Box5.Text = "O" And Box3.Text = "O") Or (Box3.Text = "O" And Box6.Text = "O" And Box9.Text = "O") Then
            identifier = 0
            AI_Score += 1
            NumRounds += 1
            Update.Enabled = False
            MsgBox("YOU LOSE!")
            Box1.Enabled = True
            Box2.Enabled = True
            Box3.Enabled = True
            Box4.Enabled = True
            Box5.Enabled = True
            Box6.Enabled = True
            Box7.Enabled = True
            Box8.Enabled = True
            Box9.Enabled = True

            Box1.Text = ""
            Box2.Text = ""
            Box3.Text = ""
            Box4.Text = ""
            Box5.Text = ""
            Box6.Text = ""
            Box7.Text = ""
            Box8.Text = ""
            Box9.Text = ""
            x = CInt(Rnd() * 5 + 1)
Line2:
            If x = 1 Then
                Box1.Text = "O"
                Box1.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 2 Then
                Box3.Text = "O"
                Box3.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 3 Then
                Box5.Text = "O"
                Box5.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 4 Then
                Box7.Text = "O"
                Box7.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 5 Then
                Box9.Text = "O"
                Box9.Enabled = False
                player_turn.Text = "X"
            ElseIf Box1.Enabled = True Or Box3.Enabled = True Or Box5.Enabled = True Or Box7.Enabled = True Or Box9.Enabled = True Then
                x = CInt(Rnd() * 5 + 1)
                GoTo Line2
            End If

            Update.Enabled = True
        End If
        ' PLAYER
        If (Box4.Text = "X" And Box5.Text = "X" And Box6.Text = "X") Or (Box2.Text = "X" And Box5.Text = "X" And Box8.Text = "X") Or (Box1.Text = "X" And Box2.Text = "X" And Box3.Text = "X") Or (Box1.Text = "X" And Box5.Text = "X" And Box9.Text = "X") Or (Box1.Text = "X" And Box4.Text = "X" And Box7.Text = "X") Or (Box7.Text = "X" And Box8.Text = "X" And Box9.Text = "X") Or (Box7.Text = "X" And Box5.Text = "X" And Box3.Text = "X") Or (Box3.Text = "X" And Box6.Text = "X" And Box9.Text = "X") Then
            identifier = 0
            PL_Score += 1
            NumRounds += 1
            Update.Enabled = False
            MsgBox("YOU WIN!")
            Box1.Enabled = True
            Box2.Enabled = True
            Box3.Enabled = True
            Box4.Enabled = True
            Box5.Enabled = True
            Box6.Enabled = True
            Box7.Enabled = True
            Box8.Enabled = True
            Box9.Enabled = True

            Box1.Text = ""
            Box2.Text = ""
            Box3.Text = ""
            Box4.Text = ""
            Box5.Text = ""
            Box6.Text = ""
            Box7.Text = ""
            Box8.Text = ""
            Box9.Text = ""
            x = CInt(Rnd() * 5 + 1)
Line3:
            If x = 1 Then
                Box1.Text = "O"
                Box1.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 2 Then
                Box3.Text = "O"
                Box3.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 3 Then
                Box5.Text = "O"
                Box5.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 4 Then
                Box7.Text = "O"
                Box7.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 5 Then
                Box9.Text = "O"
                Box9.Enabled = False
                player_turn.Text = "X"
            ElseIf Box1.Enabled = True Or Box3.Enabled = True Or Box5.Enabled = True Or Box7.Enabled = True Or Box9.Enabled = True Then
                x = CInt(Rnd() * 5 + 1)
                GoTo Line3
            End If

            Update.Enabled = True
        End If
        ' DRAW
        If Box1.Enabled = False And Box2.Enabled = False And Box3.Enabled = False And Box4.Enabled = False And Box5.Enabled = False And Box6.Enabled = False And Box7.Enabled = False And Box8.Enabled = False And Box9.Enabled = False Then
            identifier = 0
            Update.Enabled = False
            NumRounds += 1
            MsgBox("DRAW",, "3T's")

            Box1.Enabled = True
            Box2.Enabled = True
            Box3.Enabled = True
            Box4.Enabled = True
            Box5.Enabled = True
            Box6.Enabled = True
            Box7.Enabled = True
            Box8.Enabled = True
            Box9.Enabled = True

            Box1.Text = ""
            Box2.Text = ""
            Box3.Text = ""
            Box4.Text = ""
            Box5.Text = ""
            Box6.Text = ""
            Box7.Text = ""
            Box8.Text = ""
            Box9.Text = ""
            x = CInt(Rnd() * 5 + 1)
Line1:
            If x = 1 Then
                Box1.Text = "O"
                Box1.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 2 Then
                Box3.Text = "O"
                Box3.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 3 Then
                Box5.Text = "O"
                Box5.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 4 Then
                Box7.Text = "O"
                Box7.Enabled = False
                player_turn.Text = "X"
            ElseIf x = 5 Then
                Box9.Text = "O"
                Box9.Enabled = False
                player_turn.Text = "X"
            ElseIf Box1.Enabled = True Or Box3.Enabled = True Or Box5.Enabled = True Or Box7.Enabled = True Or Box9.Enabled = True Then
                x = CInt(Rnd() * 5 + 1)
                GoTo Line1
            End If

            Update.Enabled = True
        End If
    End Sub

    Private Sub Game2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Box1.Enabled = False
        Box2.Enabled = False
        Box3.Enabled = False
        Box4.Enabled = False
        Box5.Enabled = False
        Box6.Enabled = False
        Box7.Enabled = False
        Box8.Enabled = False
        Box9.Enabled = False
        Update.Enabled = False
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click

        Box1.Enabled = True
        Box2.Enabled = True
        Box3.Enabled = True
        Box4.Enabled = True
        Box5.Enabled = True
        Box6.Enabled = True
        Box7.Enabled = True
        Box8.Enabled = True
        Box9.Enabled = True
        Start.Enabled = False
        Start.Visible = False
        RndBox.Enabled = False
        Update.Enabled = True

        x = CInt(Rnd() * 5 + 1)

        If x = 1 Then
            Box1.Text = player_turn.Text
            Box1.Enabled = False
            player_turn.Text = "X"
        ElseIf x = 2 Then
            Box3.Text = player_turn.Text
            Box3.Enabled = False
            player_turn.Text = "X"
        ElseIf x = 3 Then
            Box5.Text = player_turn.Text
            Box5.Enabled = False
            player_turn.Text = "X"
        ElseIf x = 4 Then
            Box7.Text = player_turn.Text
            Box7.Enabled = False
            player_turn.Text = "X"
        ElseIf x = 5 Then
            Box9.Text = player_turn.Text
            Box9.Enabled = False
            player_turn.Text = "X"
        End If

        player_turn.Text = "X"
        Update.Enabled = True
    End Sub

    Private Sub Bot_Tick(sender As Object, e As EventArgs) Handles Bot.Tick
        Select Case identifier
            Case 1
#Region "Box1 Combo"
                If x = 1 Then
                    ' 1 = O and 2 = X 
                    If Box1.Text = "O" And Box2.Text = "X" Then
                        Box7.Text = "O"
                        Box7.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 3 = X 
                    If Box1.Text = "O" And Box3.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 4 = X 
                    If Box1.Text = "O" And Box4.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 5 = X 
                    If Box1.Text = "O" And Box5.Text = "X" Then
                        Box2.Text = "O"
                        Box2.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 6 = X 
                    If Box1.Text = "O" And Box6.Text = "X" Then
                        Box7.Text = "O"
                        Box7.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 7 = X 
                    If Box1.Text = "O" And Box7.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 8 = X 
                    If Box1.Text = "O" And Box8.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 1 = O and 9 = X 
                    If Box1.Text = "O" And Box9.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If

#End Region ' DONE
#Region "Box3 Combo"
                ElseIf x = 2 Then
                    ' 3 = O and 1 = X
                    If Box3.Text = "O" And Box1.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 2 = X
                    If Box3.Text = "O" And Box2.Text = "X" Then
                        Box9.Text = "O"
                        Box9.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 4 = X
                    If Box3.Text = "O" And Box4.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 5 = X
                    If Box3.Text = "O" And Box5.Text = "X" Then
                        Box2.Text = "O"
                        Box2.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 6 = X
                    If Box3.Text = "O" And Box6.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 7 = X
                    If Box3.Text = "O" And Box7.Text = "X" Then
                        Box9.Text = "O"
                        Box9.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 8 = X
                    If Box3.Text = "O" And Box8.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 3 = O and 9 = X
                    If Box3.Text = "O" And Box9.Text = "X" Then
                        Box7.Text = "O"
                        Box7.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
#End Region ' DONE
#Region "Box5 Combo"
                ElseIf x = 3 Then
                    ' 5 = O and 1 = X
                    If Box5.Text = "O" And Box1.Text = "X" Then
                        Box3.Text = "O"
                        Box3.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 2 = X
                    If Box5.Text = "O" And Box2.Text = "X" Then
                        Box4.Text = "O"
                        Box4.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 4 = X
                    If Box5.Text = "O" And Box4.Text = "X" Then
                        Box2.Text = "O"
                        Box2.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 3 = X
                    If Box5.Text = "O" And Box3.Text = "X" Then
                        Box4.Text = "O"
                        Box4.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 6 = X
                    If Box5.Text = "O" And Box6.Text = "X" Then
                        Box2.Text = "O"
                        Box2.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 7 = X
                    If Box5.Text = "O" And Box7.Text = "X" Then
                        Box8.Text = "O"
                        Box8.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 8 = X
                    If Box5.Text = "O" And Box8.Text = "X" Then
                        Box6.Text = "O"
                        Box6.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 5 = O and 9 = X
                    If Box5.Text = "O" And Box9.Text = "X" Then
                        Box7.Text = "O"
                        Box7.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
#End Region ' DONE
#Region "Box7 Combo"
                ElseIf x = 4 Then
                    ' 7 = O and 1 = X
                    If Box7.Text = "O" And Box1.Text = "X" Then
                        Box8.Text = "O"
                        Box8.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 2 = X
                    If Box7.Text = "O" And Box2.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 4 = X
                    If Box7.Text = "O" And Box4.Text = "X" Then
                        Box9.Text = "O"
                        Box9.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 3 = X
                    If Box7.Text = "O" And Box3.Text = "X" Then
                        Box1.Text = "O"
                        Box1.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 6 = X
                    If Box7.Text = "O" And Box6.Text = "X" Then
                        Box1.Text = "O"
                        Box1.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 5 = X
                    If Box7.Text = "O" And Box5.Text = "X" Then
                        Box3.Text = "O"
                        Box3.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 8 = X
                    If Box7.Text = "O" And Box8.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 7 = O and 9 = X
                    If Box7.Text = "O" And Box9.Text = "X" Then
                        Box3.Text = "O"
                        Box3.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
#End Region ' DONE
#Region "Box9 Combo"
                ElseIf x = 5 Then
                    ' 9 = O and 1 = X
                    If Box9.Text = "O" And Box1.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 2 = X
                    If Box9.Text = "O" And Box2.Text = "X" Then
                        Box7.Text = "O"
                        Box7.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 4 = X
                    If Box9.Text = "O" And Box4.Text = "X" Then
                        Box3.Text = "O"
                        Box3.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 3 = X
                    If Box9.Text = "O" And Box3.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 6 = X
                    If Box9.Text = "O" And Box6.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 5 = X
                    If Box9.Text = "O" And Box5.Text = "X" Then
                        Box1.Text = "O"
                        Box1.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 8 = X
                    If Box9.Text = "O" And Box8.Text = "X" Then
                        Box5.Text = "O"
                        Box5.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                    ' 9 = O and 7 = X
                    If Box9.Text = "O" And Box7.Text = "X" Then
                        Box1.Text = "O"
                        Box1.Enabled = False
                        player_turn.Text = "X"
                        Bot.Enabled = False
                        Exit Select
                    End If
                End If
#End Region ' DONE
            Case 2
#Region "B1"
                ' 1 , 7 = O and 2 = X : P = 4
                If Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And (Box3.Text = "X" Or Box5.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 = O and 3 = X : P = 9
                If Box1.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And (Box2.text = "X" Or Box4.Text = "X" Or Box6.text = "X" Or Box7.text = "X" Or Box8.text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 = O and 4 = X : P = 9
                If Box1.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And (Box2.Text = "X" Or Box3.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 2 = O and 5 = X : P = 3
                If Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And (Box4.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 7 = O and 6 = X : P = 4
                If Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "X" And (Box3.Text = "X" Or Box5.Text = "X" Or Box2.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 = O and 7 = X : P = 9
                If Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box3.Text = "X" Or Box8.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 = O and 8 = X : P = 9
                If Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box3.Text = "X" Or Box7.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 = O and 9 = X : P = 3
                If Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box2.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box3.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box4.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box7.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B3"
                ' 3 , 5 = O and 1 = X : P = 7
                If Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 9 = O and 2 = X : P = 6
                If Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And (Box1.Text = "X" Or Box4.Text = "X" Or Box5.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 = O and 4 = X : P = 7
                If Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And (Box1.Text = "X" And Box2.Text = "X" And Box6.Text = "X" And Box8.Text = "X" And Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 2 = O and 5 = X : P = 1
                If Box3.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box1.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And (Box4.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 = O and 6 = X : P = 7
                If Box3.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box1.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 9 = O and 7 = X : P = 6
                If Box3.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box6.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And (Box1.Text = "X" Or Box4.Text = "X" Or Box5.Text = "X" Or Box2.Text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 = O and 8 = X : P = 7
                If Box3.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box1.Text = "X" Or Box6.Text = "X" Or Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 7 = O and 9 = X : P = 5
                If Box3.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box1.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B5"
                ' 5 , 3 = O and 1 = X : P = 7
                If Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And (Box2.Text = "X" Or Box6.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 4 = O and 2 = X : P = 6
                If Box5.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And (Box1.Text = "X" Or Box7.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 2 = O and 4 = X : P = 8
                If Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And (Box1.Text = "X" Or Box3.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X" Or Box9.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 4 = O and 3 = X : P = 6
                If Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box6.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And (Box1.Text = "X" Or Box7.Text = "X" Or Box2.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 2 = O and 6 = X : P = 8
                If Box5.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And (Box1.Text = "X" Or Box3.Text = "X" Or Box4.Text = "X" Or Box7.Text = "X" Or Box9.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 8 = O and 7 = X : P = 2
                If Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And (Box1.Text = "X" Or Box3.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box9.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 6 = O and 8 = X : P = 4
                If Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box3.Text = "X" Or Box7.Text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 7 = O and 9 = X : P = 3
                If Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box3.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B7"
                ' 7 , 8 = O and 1 = X : P = 9
                If Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box9.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And (Box2.Text = "X" Or Box3.Text = "X" Or Box4.Text = "X" Or Box5.Text = "X" Or Box6.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 = O and 2 = X : P = 3
                If Box7.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And Box3.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And (Box1.Text = "X" Or Box8.Text = "X" Or Box4.Text = "X" Or Box9.Text = "X" Or Box6.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 9 = O and 4 = X : P = 8
                If Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box3.Text = "X" Or Box5.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 1 = O and 3 = X : P = 4
                If Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And (Box2.Text = "X" Or Box5.Text = "X" Or Box6.Text = "X" Or Box8.text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 1 = O and 6 = X : P = 4
                If Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And (Box2.Text = "X" Or Box5.Text = "X" Or Box3.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 = O and 5 = X : P = 1
                If Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box1.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box2.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 = O and 8 = X : P = 3
                If Box7.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box9.Text = "X" Or Box6.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 = O and 9 = X : P = 5
                If Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B9"
                ' 9 , 5 = O And 1 = X : P = 2
                If Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 7 = O and 2 = X : P = 8
                If Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And (Box1.Text = "X" Or Box3.text = "X" Or Box4.Text = "X" Or Box5.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 3 = O and 4 = X : P = 6
                If Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box6.Text = "X" Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box3.Text = "X" Or Box7.text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 = O and 3 = X : P = 1
                If Box9.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And (Box6.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X" Or Box7.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 = O and 6 = X : P = 1
                If Box9.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And Box1.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And (Box3.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X" Or Box7.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 = O and 5 = X : P = 2
                If Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box2.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 = O and 8 = X : P = 1
                If Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box1.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And (Box6.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box3.Text = "X" Or Box7.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 = O and 7 = X : P = 5
                If Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And (Box3.Text = "X" Or Box2.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
            Case 3
#Region "B1"
                ' 1 , 5 , 7 = O and 2 , 4 = X ' WIN
                If Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And (Box4.Text = "X" Or Box8.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 6 = O and 3 , 9 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box9.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Enabled = False
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box9.Text = "X" And (Box2.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Enabled = False
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 2 = O and 4 , 9 = X ' WIN
                If Box1.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box9.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Enabled = False
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box9.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Enabled = False
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box9.Text = "X" And (Box7.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Enabled = False
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 2 , 7 = O and 3 , 5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And (Box6.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 7 , 5 = O and 6 , 4 = X ' WIN
                If Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box6.Text = "X" And Box4.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 8 = O and 7 , 9 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box9.Text = "X" And Box2.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box9.Text = "X" And (Box4.Text = "X" Or Box3.Text = "X" Or Box6.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 7 , 5 = O and 8 , 9 = X ' WIN
                If Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box9.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box9.Text = "X" And Box4.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box9.Text = "X" And (Box2.Text = "X" Or Box6.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 4 = O and 9 , 2 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "X" And Box2.Text = "X" And (Box6.Text = "X" Or Box3.Text = "X" Or Box8.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 6 = O and 9 , 3 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box3.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X" Or Box7.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 2 = O and 9 , 4 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box9.Text = "X" And Box4.Text = "X" And (Box3.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box9.Text = "X" And Box4.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 3 = O and 9 , 6 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "X" And Box6.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 8 = O and 9 , 7 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box9.Text = "X" And Box7.Text = "X" And (Box6.Text = "X" Or Box3.Text = "X" Or Box4.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box9.Text = "X" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 1 , 5 , 7 = O and 9 , 8 = X 
                If Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box8.Text = "X" And (Box6.Text = "X" Or Box3.Text = "X" Or Box2.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box8.Text = "X" And Box4.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B3"
                ' 3 , 5 , 4 = O and 1 , 7 = X 
                If Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 9 , 5 = O and 2 , 6 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box1.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And (Box4.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 , 1 = O and 4 , 7 = X
                If Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And (Box6.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 2 , 9 = O and 5 , 1 = X 
                If Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box5.Text = "X" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box5.Text = "X" And Box1.Text = "X" And (Box4.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 , 1 = O and 6 , 7 = X
                If Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box7.Text = "X" And (Box4.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 1 , 9 = O and 7 , 6 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box1.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box6.Text = "X" And (Box4.Text = "X" Or Box2.Text = "X" Or Box8.Text = "X") Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 5 , 9 = O and 8 , 7 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "X" And Box7.Text = "X" And (Box4.Text = "X" Or Box2.Text = "X" Or Box6.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 3 , 1 , 7 = O and 9 , 5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box5.Text = "X" And Box2.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box5.Text = "X" And (Box4.Text = "X" Or Box8.Text = "X" Or Box6.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B5"
                ' 5 , 3 , 4 = O and 1 , 7 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X" Or Box9.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 4 , 1 = O and 2 , 6 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And (Box3.Text = "X" Or Box8.Text = "X" Or Box7.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 4 , 9 = O and 3 , 6 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box6.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box6.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X" Or Box7.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 2 , 3 = O and 4 , 8 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And (Box1.Text = "X" Or Box6.Text = "X" Or Box9.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 2 , 1 = O and 6 , 8 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box8.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box7.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 8 , 1 = O and 7 , 2 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box2.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 6 , 9 = O and 8 , 4 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box4.Text = "X" And Box1.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box4.Text = "X" And (Box3.Text = "X" Or Box2.Text = "X" Or Box7.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 5 , 7 , 6 = O and 9 , 3 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box3.Text = "X" And (Box1.Text = "X" Or Box2.Text = "X" Or Box8.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B7"
                ' 7 , 8 , 5 = O and 1 , 9 = X 
                If Box7.Text = "O" And Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box9.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box9.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 , 1 = O and 2 , 3 = X 
                If Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And (Box8.Text = "X" Or Box9.Text = "X" Or Box6.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 , 1 = O and 3 , 4 = X 
                If Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box4.Text = "X" And (Box2.Text = "X" Or Box8.Text = "X" Or Box6.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 9 , 5 = O and 4 , 8 = X 
                If Box7.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And Box1.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And (Box3.Text = "X" Or Box2.Text = "X" Or Box6.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 9 = O and 5 , 1 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "X" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "X" And Box1.Text = "X" And (Box8.Text = "X" Or Box4.Text = "X" Or Box2.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 8 = O and 5 , 2 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And (Box1.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 6 = O and 5 , 4 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box4.Text = "X" And (Box8.Text = "X" Or Box1.Text = "X" Or Box2.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 4 = O and 5 , 6 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box6.Text = "X" And Box1.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box6.Text = "X" And (Box8.Text = "X" Or Box9.Text = "X" Or Box2.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 2 = O and 5 , 8 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" And Box1.Text = "X" Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" And (Box6.Text = "X" Or Box4.Text = "X" Or Box9.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 3 , 1 = O and 5 , 9 = X 
                If Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box9.Text = "X" And Box4.Text = "X" Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box9.Text = "X" And (Box8.Text = "X" Or Box6.Text = "X" Or Box2.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 , 1 = O and 6 , 4 = X 
                If Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box4.Text = "X" And (Box2.Text = "X" Or Box3.Text = "X" Or Box8.Text = "X") Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 7 , 5 , 4 = O and 8 , 3 = X 
                If Box7.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box3.Text = "X" And (Box6.Text = "X" Or Box2.Text = "X" Or Box9.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
#Region "B9"
                ' 9 , 5 , 3 = O and 1 , 2 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And (Box4.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 2 = O and 1 , 3 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And (Box4.Text = "X" Or Box7.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 7 = O and 1 , 4 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box4.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box4.Text = "X" And (Box2.Text = "X" Or Box3.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 8 = O and 1 , 6 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box2.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And (Box3.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 4 = O and 1 , 7 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And (Box2.Text = "X" Or Box3.Text = "X" Or Box8.Text = "X") Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 6 = O and 1 , 8 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box7.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 7 , 5 = O and 2 , 8 = X 
                If Box9.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And Box8.Text = "X" And Box1.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box2.Text = "X" And Box8.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 3 , 5 = O and 4 , 6 = X 
                If Box9.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box6.Text = "X" And Box1.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box4.Text = "X" And Box6.Text = "X" And (Box2.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 2 = O and 3 , 1 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box1.Text = "X" And (Box4.Text = "X" Or Box7.Text = "X" Or Box6.Text = "X") Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 5 , 8 = O and 6 , 1 = X 
                If Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "X" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "X" And Box1.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box7.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 8 = O and 5 , 2 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And (Box3.Text = "X" Or Box4.Text = "X" Or Box6.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 7 = O and 5 , 3 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box3.Text = "X" And (Box2.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 6 = O and 5 , 4 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box4.Text = "X" And (Box2.Text = "X" Or Box7.Text = "X" Or Box8.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 4 = O and 5 , 6 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box6.Text = "X" And (Box2.Text = "X" Or Box4.Text = "X" Or Box8.Text = "X") Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 3 = O and 5 , 7 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box7.Text = "X" And (Box4.Text = "X" Or Box6.Text = "X" Or Box8.Text = "X") Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' 9 , 1 , 2 = O and 5 , 8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" And (Box4.Text = "X" Or Box6.Text = "X" Or Box7.Text = "X") Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If

#End Region ' DONE
            Case 4
#Region "DRAW"
                If Box1.Enabled = True Then
                    Box1.Text = "O"
                    Box1.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box2.Enabled = True Then
                    Box2.Text = "O"
                    Box2.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Enabled = True Then
                    Box3.Text = "O"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box4.Enabled = True Then
                    Box4.Text = "O"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Enabled = True Then
                    Box5.Text = "O"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box6.Enabled = True Then
                    Box6.Text = "O"
                    Box6.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Enabled = True Then
                    Box7.Text = "O"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box8.Enabled = True Then
                    Box8.Text = "O"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Enabled = True Then
                    Box9.Text = "O"
                    Box9.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region ' DONE
        End Select
    End Sub

#Region "Player"

    Private Sub Box1_Click(sender As Object, e As EventArgs) Handles Box1.Click
        Box1.Text = player_turn.Text
        Box1.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box2_Click(sender As Object, e As EventArgs) Handles Box2.Click
        Box2.Text = player_turn.Text
        Box2.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box3_Click(sender As Object, e As EventArgs) Handles Box3.Click
        Box3.Text = player_turn.Text
        Box3.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box4_Click(sender As Object, e As EventArgs) Handles Box4.Click
        Box4.Text = player_turn.Text
        Box4.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box5_Click(sender As Object, e As EventArgs) Handles Box5.Click
        Box5.Text = player_turn.Text
        Box5.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box6_Click(sender As Object, e As EventArgs) Handles Box6.Click
        Box6.Text = player_turn.Text
        Box6.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box7_Click(sender As Object, e As EventArgs) Handles Box7.Click
        Box7.Text = player_turn.Text
        Box7.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box8_Click(sender As Object, e As EventArgs) Handles Box8.Click
        Box8.Text = player_turn.Text
        Box8.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box9_Click(sender As Object, e As EventArgs) Handles Box9.Click
        Box9.Text = player_turn.Text
        Box9.Enabled = False
        player_turn.Text = "O"
        identifier += 1
        Bot.Enabled = True
    End Sub


#End Region
End Class