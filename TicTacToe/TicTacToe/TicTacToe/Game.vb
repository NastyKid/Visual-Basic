Public Class Game
#Region "GameUpdates"
    ' ESTIMATED DATE TO FINISH : 10.27-28.17
    ' PROGRESS:
    ' 10.18.17 : ESTABLISHING THE PILLARS AND AI STEP 1 
    ' 10.20.17 : FORMULATING POSSIBLE COMBINATIONS       
    ' 10.21.17 : STEP 3                                 
    ' 10.22.17 : STEP 4 - BOX 1-3 CONFIGURE             
    ' 10.23.17 : STEP 4 - BOX 4 CONFIGURE               
    ' 10.24.17 : STEP 4 - BOX 5-9 CONFIGURE              
    '          : ADD SCORING SYSTEM       
    ' 10.25.17 : TEST THE AI
    ' 10.26.17 : GAME DONE!

    ' UPDATE: 
    ' 08.06.19 : DEBUGGING : LINE 2878 : FIXING CONDITION STATEMENT FROM BOX5 to BOX4 (FIXED)
    ' 09.11.19 : DEBUGGING : ADD [COMBI 2-6-4-8 = O & 1-7-5 = X][COMBI 2-6-4-3 = O & 1-7-5 = X]
#End Region

    Dim identifier As Integer = 0 ' Step Identifier 
    Dim AI_Score As Integer = 0 ' Scores
    Dim PL_Score As Integer = 0 ' Scores
    Dim NumRounds As Integer = 1 ' Rounds

    ' Back Button
    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Main_Menu.Show()
        Me.Close()
    End Sub

    ' Scoring
    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles Update.Tick
        ' Scoring
        c_score.Text = PL_Score
        b_score.Text = AI_Score
        RndNo.Text = NumRounds
        ' DRAW
        If Box1.Enabled = False And Box2.Enabled = False And Box3.Enabled = False And Box4.Enabled = False And Box5.Enabled = False And Box6.Enabled = False And Box7.Enabled = False And Box8.Enabled = False And Box9.Enabled = False Then
            identifier = 0
            NumRounds += 1
            Update.Enabled = False
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
            Update.Enabled = True
        End If
        ' PLAYER 
        If (Box4.Text = "O" And Box5.Text = "O" And Box6.Text = "O") Or (Box2.Text = "O" And Box5.Text = "O" And Box8.Text = "O") Or (Box1.Text = "O" And Box2.Text = "O" And Box3.Text = "O") Or (Box1.Text = "O" And Box5.Text = "O" And Box9.Text = "O") Or (Box1.Text = "O" And Box4.Text = "O" And Box7.Text = "O") Or (Box7.Text = "O" And Box8.Text = "O" And Box9.Text = "O") Or (Box7.Text = "O" And Box5.Text = "O" And Box3.Text = "O") Or (Box3.Text = "O" And Box6.Text = "O" And Box9.Text = "O") Then
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
            Update.Enabled = True
        End If
        ' AI
        If (Box4.Text = "X" And Box5.Text = "X" And Box6.Text = "X") Or (Box2.Text = "X" And Box5.Text = "X" And Box8.Text = "X") Or (Box1.Text = "X" And Box2.Text = "X" And Box3.Text = "X") Or (Box1.Text = "X" And Box5.Text = "X" And Box9.Text = "X") Or (Box1.Text = "X" And Box4.Text = "X" And Box7.Text = "X") Or (Box7.Text = "X" And Box8.Text = "X" And Box9.Text = "X") Or (Box7.Text = "X" And Box5.Text = "X" And Box3.Text = "X") Or (Box3.Text = "X" And Box6.Text = "X" And Box9.Text = "X") Then
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
            Update.Enabled = True
        End If
    End Sub

    ' Artificial Intelligence
    Private Sub Bot_Tick(sender As Object, e As EventArgs) Handles Bot.Tick
        Select Case identifier
            Case 1 ' Step 1 : DONE : 10:27 PM
#Region "[S1]"
                If Box1.Text = "O" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box2.Text = "O" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box3.Text = "O" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box4.Text = "O" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box5.Text = "O" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box6.Text = "O" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box7.Text = "O" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box8.Text = "O" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                ElseIf Box9.Text = "O" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region
            Case 2 ' Step 2 : DONE : 7:58 PM
#Region "[S1 - S2 ]"
                ' Possible Combinations
                ''''''''''''''''' [ 1 ] '''''''''''''''''
                ' Combi Box : 1-2 & 5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3 & 5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi Box : 1-4 & 5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6 & 5 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7 & 5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8 & 5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9 & 5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ] '''''''''''''''''
                ' Combi box : 2-3 & 1 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4 & 1 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5 & 1 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box1.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6 & 1 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-7 & 1 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select

                End If
                ' Combi box : 2-8 & 1 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-9 & 1 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "X"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ] '''''''''''''''''
                ' Combi Box : 3-2 & 5 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4 & 5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi Box : 3-6 & 5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7 & 5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8 & 5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9 & 5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ] '''''''''''''''''
                ' Combi box : 4-2 & 1 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3 & 1 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5 & 1 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box1.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6 & 1 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7 & 1 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8 & 1 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9 & 1 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ] '''''''''''''''''
                ' Combi box : 5-1 & 9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2 & 9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3 & 9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4 & 9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6 & 9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7 & 9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8 & 9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ] '''''''''''''''''
                ' Combi box : 6-1 & 3 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box3.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2 & 3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4 & 3 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box3.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5 & 3 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7 & 3 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8 & 3 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9 & 3 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ] '''''''''''''''''
                ' Combi box : 7-2 & 5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4 & 5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6 & 5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8 & 5 = X
                If Box8.Text = "O" And Box7.Text = "O" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9 & 5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ] '''''''''''''''''
                ' Combi box : 8-1 & 7 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box7.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2 & 7 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box7.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3 & 7 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4 & 7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box7.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5 & 7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box7.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-6 & 7 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-9 & 7 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ] '''''''''''''''''
                ' Combi box : 9-2 & 5 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-4 & 5 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6 & 5 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8 & 5 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region
            Case 3 ' Step 3 : S1 - S2 - S3 & bx-by = X : DONE : 4:30 PM
#Region "[S1 - S2 - S3]"
                ''''''''''''''''' [ 1 ][ 2 ] ''''''''''''''''' 
                ' Combi box : 1-2-4 & 3-5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-6 & 3-5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-7 & 3-5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-8 & 3-5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-9 & 3-5 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 3 ] '''''''''''''''''
                ' Combi box : 1-3-4 = O & 2-5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-6 = O & 2-5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-7 = O & 2-5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-8 = O & 2-5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-9 = O & 2-5 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 4 ] '''''''''''''''''
                ' Combi box : 1-4-2 = O & 7-5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-3 = O & 7-5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-6 = O & 7-5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-8 = O & 7-5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-9 = O & 7-5 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 6 ] '''''''''''''''''
                ' Combi box : 1-6-4 = O & 3-5 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6-7 = O & 3-5 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6-8 = O & 3-5 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6-9 = O & 3-5 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 7 ] '''''''''''''''''
                ' Combi box : 1-7-2 = O & 4-5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-3 = O & 4-5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-6 = O & 4-5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-8 = O & 4-5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-9 = O & 4-5 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 8 ] '''''''''''''''''
                ' Combi box : 1-8-2 = O & 7-5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-3 = O & 7-5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-4 = O & 7-5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-6 = O & 7-5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-9 = O & 7-5 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 9 ] '''''''''''''''''
                ' Combi box : 1-9-2 = O & 8-5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-3 = O & 8-5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-4 = O & 8-5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-6 = O & 8-5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-7 = O & 8-5 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 3 ] ''''''''''''''''' 
                ' Combi box : 2-3-5 = O & 1-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-6 = O & 1-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-7 = O & 1-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-8 = O & 1-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-9 = O & 1-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ] '''''''''''''''''
                ' Combi box : 2-4-3 = O & 1-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-5 = O & 1-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-6 = O & 1-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-7 = O & 1-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-9 = O & 1-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ] '''''''''''''''''
                ' Combi box : 2-5-3 = O & 1-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-4 = O & 1-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-6 = O & 1-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-7 = O & 1-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-9 = O & 1-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 6 ] '''''''''''''''''
                ' Combi box : 2-6-3 = O & 1-7 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6-4 = O & 1-7 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6-5 = O & 1-7 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6-8 = O & 1-7 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6-9 = O & 1-7 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 2-7-3 = O & 1-5 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-7-4 = O & 1-5 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-7-6 = O & 1-5 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-7-8 = O & 1-5 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-7-9 = O & 1-5 = X
                If Box2.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 8 ] '''''''''''''''''
                ' Combi box : 2-8-3 = O & 1-5 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-8-4 = O & 1-5 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-8-6 = O & 1-5 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-8-7 = O & 1-5 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-8-9 = O & 1-5 = X
                If Box2.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 9 ] '''''''''''''''''
                ' Combi box : 2-9-3 = O & 1-7 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-9-4 = O & 1-7 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-9-5 = O & 1-7 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-9-6 = O & 1-7 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-9-8 = O & 1-7 = X
                If Box2.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 1 ] '''''''''''''''''
                ' Combi box : 3-1-4 = O & 2-5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-6 = O & 2-5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-7 = O & 2-5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-8 = O & 2-5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-9 = O & 2-5 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 2 ] '''''''''''''''''
                ' Combi box : 3-2-4 = O & 1-5 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-6 = O & 1-5 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-7 = O & 1-5 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-8 = O & 1-5 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-9 = O & 1-5 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 4 ] '''''''''''''''''
                ' Combi box : 3-4-2 = O & 1-5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-6 = O & 1-5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-7 = O & 1-5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-8 = O & 1-5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-9 = O & 1-5 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 6 ] '''''''''''''''''
                ' Combi box : 3-6-1 = O & 9-5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-2 = O & 9-5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-4 = O & 9-5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-7 = O & 9-5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-8 = O & 9-5 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 7 ] '''''''''''''''''
                ' Combi box : 3-7-1 = O & 8-5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-2 = O & 8-5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-4 = O & 8-5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-6 = O & 8-5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-9 = O & 8-5 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 8 ] '''''''''''''''''
                ' Combi box : 3-8-1 = O & 9-5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-2 = O & 9-5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-4 = O & 9-5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-6 = O & 9-5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-7 = O & 9-5 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 9 ] '''''''''''''''''
                ' Combi box : 3-9-1 = O & 6-5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-2 = O & 6-5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-4 = O & 6-5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-7 = O & 6-5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-8 = O & 6-5 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ] '''''''''''''''''
                ' Combi box : 4-2-3 = O & 1-8 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-5 = O & 1-8 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-6 = O & 1-8 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-7 = O & 1-8 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-9 = O & 1-8 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 3 ] '''''''''''''''''
                ' Combi box : 4-3-2 = O & 1-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-6 = O & 1-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-7 = O & 1-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-8 = O & 1-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-9 = O & 1-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ] '''''''''''''''''
                ' Combi box : 4-5-2 = O & 1-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-3 = O & 1-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-8 = O & 1-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-7 = O & 1-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-9 = O & 1-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 6 ] '''''''''''''''''
                ' Combi box : 4-6-2 = O & 1-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-3 = O & 1-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-7 = O & 1-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-8 = O & 1-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-9 = O & 1-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 7 ] '''''''''''''''''
                ' Combi box : 4-7-3 = O & 1-2 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-5 = O & 1-2 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-6 = O & 1-2 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-8 = O & 1-2 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-9 = O & 1-2 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box2.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 8 ] '''''''''''''''''
                ' Combi box : 4-8-2 = O & 1-3 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-5 = O & 1-3 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-6 = O & 1-3 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-7 = O & 1-3 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-9 = O & 1-3 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 9 ] '''''''''''''''''
                ' Combi box : 4-9-2 = O & 1-3 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-5 = O & 1-3 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-6 = O & 1-3 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-7 = O & 1-3 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-8 = O & 1-3 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box3.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 1 ] '''''''''''''''''
                ' Combi box : 5-1-2 = O & 7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-3 = O & 7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-4 = O & 7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-6 = O & 7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-8 = O & 7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 2 ] '''''''''''''''''
                ' Combi box : 5-2-1 = O & 8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-3 = O & 8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-4 = O & 8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-6 = O & 8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-7 = O & 8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 3 ] '''''''''''''''''
                ' Combi box : 5-3-1 = O & 7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-2 = O & 7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-4 = O & 7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-6 = O & 7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-8 = O & 7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 4 ] '''''''''''''''''
                ' Combi box : 5-4-1 = O & 6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-2 = O & 6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-3 = O & 6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-7 = O & 6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-8 = O & 6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ] '''''''''''''''''
                ' Combi box : 5-6-1 = O & 4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-2 = O & 4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-3 = O & 4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-7 = O & 4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-8 = O & 4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 7 ] '''''''''''''''''
                ' Combi box : 5-7-1 = O & 3-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-2 = O & 3-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-4 = O & 3-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-6 = O & 3-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-8 = O & 3-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ] '''''''''''''''''
                ' Combi box : 5-8-1 = O & 2-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-3 = O & 2-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-4 = O & 2-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-6 = O & 2-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-7 = O & 2-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 1 ] '''''''''''''''''
                ' Combi box : 6-1-2 = O & 3-5 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-4 = O & 3-5 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-7 = O & 3-5 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-8 = O & 3-5 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-9 = O & 3-5 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ] '''''''''''''''''
                ' Combi box : 6-2-1 = O & 3-8 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-4 = O & 3-8 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-5 = O & 3-8 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-7 = O & 3-8 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-9 = O & 3-8 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 4 ] '''''''''''''''''
                ' Combi box : 6-4-1 = O & 3-5 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-2 = O & 3-5 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-7 = O & 3-5 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-8 = O & 3-5 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-9 = O & 3-5 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ] '''''''''''''''''
                ' Combi box : 6-5-1 = O & 3-4 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-2 = O & 3-4 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-7 = O & 3-4 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-8 = O & 3-4 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-9 = O & 3-4 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 7 ] '''''''''''''''''
                ' Combi box : 6-7-2 = O & 3-1 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-4 = O & 3-1 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-5 = O & 3-1 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-8 = O & 3-1 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-9 = O & 3-1 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 8 ] '''''''''''''''''
                ' Combi box : 6-8-2 = O & 3-1 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-4 = O & 3-1 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-5 = O & 3-1 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-7 = O & 3-1 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-9 = O & 3-1 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 9 ] '''''''''''''''''
                ' Combi box : 6-9-1 = O & 3-2 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-4 = O & 3-2 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-5 = O & 3-2 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-7 = O & 3-2 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-8 = O & 3-2 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 1 ] '''''''''''''''''
                ' Combi box : 7-1-2 = O & 4-5 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-3 = O & 4-5 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-6 = O & 4-5 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-8 = O & 4-5 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-9 = O & 4-5 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 2 ] '''''''''''''''''
                ' Combi box : 7-2-3 = O & 1-5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-4 = O & 1-5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-6 = O & 1-5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-8 = O & 1-5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-9 = O & 1-5 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 3 ] '''''''''''''''''
                ' Combi box : 7-3-1 = O & 8-5 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-2 = O & 8-5 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-4 = O & 8-5 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-6 = O & 8-5 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-9 = O & 8-5 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 4 ] '''''''''''''''''
                ' Combi box : 7-4-2 = O & 1-5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-3 = O & 1-5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-6 = O & 1-5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-8 = O & 1-5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-9 = O & 1-5 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 6 ] '''''''''''''''''
                ' Combi box : 7-6-2 = O & 1-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-3 = O & 1-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-4 = O & 1-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-8 = O & 1-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-9 = O & 1-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 8 ] '''''''''''''''''
                ' Combi box : 7-8-1 = O & 9-5 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-2 = O & 9-5 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-3 = O & 9-5 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-4 = O & 9-5 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-6 = O & 9-5 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box9.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 9 ] '''''''''''''''''
                ' Combi box : 7-9-1 = O & 8-5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-2 = O & 8-5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-3 = O & 8-5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-4 = O & 8-5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-6 = O & 8-5 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 1 ] '''''''''''''''''
                ' Combi box : 8-1-2 = O & 7-5 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-3 = O & 7-5 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-4 = O & 7-5 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-6 = O & 7-5 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-9 = O & 7-5 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 2 ] '''''''''''''''''
                ' Combi box : 8-2-1 = O & 7-5 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-3 = O & 7-5 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-4 = O & 7-5 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-6 = O & 7-5 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-9 = O & 7-5 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 3 ] '''''''''''''''''
                ' Combi box : 8-3-2 = O & 7-1 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-4 = O & 7-1 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-5 = O & 7-1 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-6 = O & 7-1 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-9 = O & 7-1 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ] '''''''''''''''''
                ' Combi box : 8-4-1 = O & 7-2 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-3 = O & 7-2 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-5 = O & 7-2 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-6 = O & 7-2 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-9 = O & 7-2 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ] '''''''''''''''''
                ' Combi box : 8-5-1 = O & 7-2 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-3 = O & 7-2 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-4 = O & 7-2 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-6 = O & 7-2 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-9 = O & 7-2 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 6 ] '''''''''''''''''
                ' Combi box : 8-6-2 = O & 7-1 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-6-3 = O & 7-1 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-6-4 = O & 7-1 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-6-5 = O & 7-1 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-6-9 = O & 7-1 = X
                If Box8.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box7.Text = "X" And Box1.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 9 ] '''''''''''''''''
                ' Combi box : 8-9-1 = O & 7-4 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "X" And Box4.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-9-2 = O & 7-4 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-9-3 = O & 7-4 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box7.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-9-5 = O & 7-4 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box5.Text = "O" And Box7.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-9-6 = O & 7-4 = X
                If Box8.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box7.Text = "X" And Box4.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 1 ] '''''''''''''''''
                ' Combi box : 9-1-2 = O & 5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-3 = O & 5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-4 = O & 5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-6 = O & 5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-7 = O & 5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 2 ] '''''''''''''''''
                ' Combi box : 9-2-1 = O & 5-3 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-4 = O & 5-3 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-6 = O & 5-3 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-7 = O & 5-3 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-8 = O & 5-3 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 3 ] '''''''''''''''''
                ' Combi box : 9-3-1 = O & 5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-2 = O & 5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-4 = O & 5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-7 = O & 5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-8 = O & 5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 4 ] '''''''''''''''''
                ' Combi box : 9-4-1 = O & 5-7 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-4-2 = O & 5-7 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-4-3 = O & 5-7 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-4-6 = O & 5-7 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-4-8 = O & 5-7 = X
                If Box9.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 6 ] '''''''''''''''''
                ' Combi box : 9-6-1 = O & 5-3 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-2 = O & 5-3 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-4 = O & 5-3 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-7 = O & 5-3 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-8 = O & 5-3 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 7 ] '''''''''''''''''
                ' Combi box : 9-7-1 = O & 5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-2 = O & 5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-3 = O & 5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-4 = O & 5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-6 = O & 5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 8 ] '''''''''''''''''
                ' Combi box : 9-8-1 = O & 5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-2 = O & 5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-3 = O & 5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-4 = O & 5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-6 = O & 5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region
            Case 4 ' Step 4: S1 - S2 - S3 - S4 = O & Bx-By-Bz = X :
#Region "[S1 - S2 - S3 - S4]"
                ''''''''''''''''' [ 1 ][ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 1-2-7-6 = O & 3-5-4 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-7-8 = O & 3-5-4 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-2-7-9 = O & 3-5-4 = X
                If Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 3 ][ 8 ] '''''''''''''''''
                ' Combi box : 1-3-8-4 = O & 2-5-7 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-8-6 = O & 2-5-7 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-3-8-9 = O & 2-5-7 = X
                If Box1.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 4 ][ 3 ] '''''''''''''''''
                ' Combi box : 1-4-3-6 = O & 2-5-7 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-3-8 = O & 2-5-7 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-4-3-9 = O & 2-5-7 = X
                If Box1.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 6 ][ 7 ] '''''''''''''''''
                ' Combi box : 1-6-7-2 = O & 3-5-4 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6-7-8 = O & 3-5-4 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-6-7-9 = O & 3-5-4 = X
                If Box1.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 7 ][ 6 ] '''''''''''''''''
                ' Combi box : 1-7-6-3 = O & 2-5-4 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-6-8 = O & 2-5-4 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-7-6-9 = O & 2-5-4 = X
                If Box1.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 8 ][ 3 ] '''''''''''''''''
                ' Combi box : 1-8-3-4 = O & 2-5-7 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-3-6 = O & 2-5-7 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-8-3-9 = O & 2-5-7 = X
                If Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 1 ][ 9 ][ 2 ] '''''''''''''''''
                ' Combi box : 1-9-2-4 = O & 3-5-8 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-2-6 = O & 3-5-8 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 1-9-2-7 = O & 3-5-8 = X
                If Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 3 ][ 7 ] '''''''''''''''''
                ' Combi box : 2-3-7-6 = O & 1-5-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-7-8 = O & 1-5-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-3-7-9 = O & 1-5-4 = X
                If Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ][ 3 ] '''''''''''''''''
                ' Combi box : 2-4-3-5 = O & 1-8-9 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-3-6 = O & 1-8-9 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-3-7 = O & 1-8-9 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ][ 5 ] '''''''''''''''''
                ' Combi box : 2-4-5-3 = O & 1-8-6 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-5-7 = O & 1-8-6 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-5-9 = O & 1-8-6 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ][ 6 ] '''''''''''''''''
                ' Combi box : 2-4-6-3 = O & 1-5-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-6-7 = O & 1-5-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-6-9 = O & 1-5-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ][ 7 ] '''''''''''''''''
                ' Combi box : 2-4-7-3 = O & 1-6-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-7-5 = O & 1-6-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-7-9 = O & 1-6-8 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 4 ][ 9 ] '''''''''''''''''
                ' Combi box : 2-4-9-3 = O & 1-5-7 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-9-6 = O & 1-5-7 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-4-9-8 = O & 1-5-7 = X
                If Box2.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ][ 3 ] '''''''''''''''''
                ' Combi box : 2-5-3-4 = O & 1-8-7 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-3-6 = O & 1-8-7 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-3-9 = O & 1-8-7 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ][ 4 ] '''''''''''''''''
                ' Combi box : 2-5-4-3 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-4-7 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-4-9 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ][ 6 ] '''''''''''''''''
                ' Combi box : 2-5-6-3 = O & 1-4-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-6-7 = O & 1-4-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box4.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-6-9 = O & 1-4-8 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box4.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ][ 7 ] '''''''''''''''''
                ' Combi box : 2-5-7-4 = O & 1-8-3 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-7-6 = O & 1-8-3 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-7-9 = O & 1-8-3 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 5 ][ 9 ] '''''''''''''''''
                ' Combi box : 2-5-9-3 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-9-4 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-5-9-7 = O & 1-8-6 = X
                If Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 2 ][ 6 ][ 4 ] '''''''''''''''''
                ' Combi box : 2-6-4-8 = O & 1-7-5 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 2-6-4-3 = O & 1-7-5 = X
                If Box2.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box7.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 1 ][ 8 ] '''''''''''''''''
                ' Combi box : 3-1-8-4 = O & 2-5-7 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-8-6 = O & 2-5-7 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-1-8-9 = O & 2-5-7 = X
                If Box3.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 2 ][ 9 ] '''''''''''''''''
                ' Combi box : 3-2-9-4 = O & 1-5-6 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-9-7 = O & 1-5-6 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-2-9-8 = O & 1-5-6 = X
                If Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 4 ][ 9 ] '''''''''''''''''
                ' Combi box : 3-4-9-2 = O & 1-5-6 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-9-8 = O & 1-5-6 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-4-9-7 = O & 1-5-6 = X
                If Box3.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 6 ][ 1 ] '''''''''''''''''
                ' Combi box : 3-6-1-4 = O & 2-5-9 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-1-7 = O & 2-5-9 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-6-1-8 = O & 2-5-9 = X
                If Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 7 ][ 2 ] '''''''''''''''''
                ' Combi box : 3-7-2-4 = O & 1-5-8 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-2-6 = O & 1-5-8 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-7-2-9 = O & 1-5-8 = X
                If Box3.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 8 ][ 1 ] '''''''''''''''''
                ' Combi box : 3-8-1-4 = O & 2-5-9 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-1-6 = O & 4-5-9 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-8-1-7 = O & 4-5-9 = X
                If Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 3 ][ 9 ][ 4 ] '''''''''''''''''
                ' Combi box : 3-9-4-2 = O & 1-5-6 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-4-7 = O & 1-5-6 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 3-9-4-8 = O & 1-5-6 = X
                If Box3.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ][ 3 ] '''''''''''''''''
                ' Combi box : 4-2-3-5 = O & 1-8-9 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-3-6 = O & 1-8-9 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-3-7 = O & 1-8-9 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ][ 5 ] '''''''''''''''''
                ' Combi box : 4-2-5-3 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-5-7 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-5-9 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ][ 6 ] '''''''''''''''''
                ' Combi box : 4-2-6-3 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-6-7 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-6-9 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 4-2-7-3 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-7-5 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box5.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-7-9 = O & 1-8-6 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box5.Text = "X"
                    Box5.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 2 ][ 9 ] '''''''''''''''''
                ' Combi box : 4-2-9-3 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-9-6 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-2-9-7 = O & 1-8-5 = X
                If Box4.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box5.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 3 ][ 9 ] '''''''''''''''''
                ' Combi box : 4-3-9-2 = O & 1-6-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-9-7 = O & 1-6-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-3-9-8 = O & 1-6-5 = X
                If Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ][ 2 ] '''''''''''''''''
                ' Combi box : 4-5-2-3 = O & 1-6-8 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-2-7 = O & 1-6-8 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-2-9 = O & 1-6-8 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ][ 3 ] '''''''''''''''''
                ' Combi box : 4-5-3-2 = O & 1-6-7 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-3-8 = O & 1-6-7 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-3-9 = O & 1-6-7 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ][ 7 ] '''''''''''''''''
                ' Combi box : 4-5-7-2 = O & 1-6-3 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-7-8 = O & 1-6-3 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-7-9 = O & 1-6-3 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box6.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ][ 8 ] '''''''''''''''''
                ' Combi box : 4-5-8-3 = O & 1-2-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-8-7 = O & 1-2-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-8-9 = O & 1-2-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 5 ][ 9 ] '''''''''''''''''
                ' Combi box : 4-5-9-2 = O & 1-8-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-9-3 = O & 1-8-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-5-9-7 = O & 1-8-6 = X
                If Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box8.Text = "X" And Box6.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 6 ][ 9 ] '''''''''''''''''
                ' Combi box : 4-6-9-2 = O & 1-3-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-9-7 = O & 1-3-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-6-9-8 = O & 1-3-5 = X
                If Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 7 ][ 3 ] '''''''''''''''''
                ' Combi box : 4-7-3-6 = O & 1-2-5 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-3-8 = O & 1-2-5 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-7-3-9 = O & 1-2-5 = X
                If Box4.Text = "O" And Box7.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 8 ][ 2 ] '''''''''''''''''
                ' Combi box : 4-8-2-6 = O & 1-3-5 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-2-7 = O & 1-3-5 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-8-2-9 = O & 1-3-5 = X
                If Box4.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 4 ][ 9 ][ 2 ] '''''''''''''''''
                ' Combi box : 4-9-2-6 = O & 1-3-5 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-2-7 = O & 1-3-5 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 4-9-2-8 = O & 1-3-5 = X
                If Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box3.Text = "X" And Box5.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 1 ][ 8 ] '''''''''''''''''
                ' Combi box : 5-1-8-3 = O & 2-7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-8-4 = O & 2-7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-1-8-6 = O & 2-7-9 = X
                If Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 5-2-7-1 = O & 3-8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-7-4 = O & 3-8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-2-7-6 = O & 3-8-9 = X
                If Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 3 ][ 8 ] '''''''''''''''''
                ' Combi box : 5-3-8-1 = O & 2-7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-8-4 = O & 2-7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-3-8-6 = O & 2-7-9 = X
                If Box5.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 4 ][ 3 ] '''''''''''''''''
                ' Combi box : 5-4-3-1 = O & 7-6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-3-2 = O & 7-6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-4-3-8 = O & 7-6-9 = X
                If Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box6.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ][ 1 ] '''''''''''''''''
                ' Combi box : 5-6-1-2 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-1-3 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-1-8 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ][ 2 ] '''''''''''''''''
                ' Combi box : 5-6-2-1 = O & 8-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-2-3 = O & 8-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-2-7 = O & 8-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box8.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ][ 3 ] '''''''''''''''''
                ' Combi box : 5-6-3-1 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-3-2 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-3-8 = O & 7-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ][ 7 ] '''''''''''''''''
                ' Combi box : 5-6-7-1 = O & 3-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-7-2 = O & 3-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-7-8 = O & 3-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 6 ][ 8 ] '''''''''''''''''
                ' Combi box : 5-6-8-1 = O & 2-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-8-3 = O & 2-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-6-8-7 = O & 2-4-9 = X
                If Box5.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box2.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 7 ][ 6 ] '''''''''''''''''
                ' Combi box : 5-7-6-1 = O & 3-4-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-6-2 = O & 3-4-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-7-6-8 = O & 3-4-9 = X
                If Box5.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ][ 1 ] '''''''''''''''''
                ' Combi box : 5-8-1-4 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-1-6 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-1-7 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ][ 3 ] '''''''''''''''''
                ' Combi box : 5-8-3-1 = O & 2-7-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-3-4 = O & 2-7-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-3-6 = O & 2-7-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box7.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ][ 4 ] '''''''''''''''''
                ' Combi box : 5-8-4-1 = O & 2-6-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-4-3 = O & 2-6-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-4-7 = O & 2-6-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ][ 6 ] '''''''''''''''''
                ' Combi box : 5-8-6-1 = O & 2-4-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-6-3 = O & 2-4-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-6-7 = O & 2-4-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box9.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 5 ][ 8 ][ 7 ] '''''''''''''''''
                ' Combi box : 5-8-7-1 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-7-4 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 5-8-7-6 = O & 2-3-9 = X
                If Box5.Text = "O" And Box8.Text = "O" And Box6.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 1 ][ 7 ] '''''''''''''''''
                ' Combi box : 6-1-7-2 = O & 4-5-3 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-7-8 = O & 4-5-3 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-1-7-9 = O & 4-5-3 = X
                If Box6.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ][ 1 ] '''''''''''''''''
                ' Combi box : 6-2-1-4 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-1-7 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-1-9 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ][ 4 ] '''''''''''''''''
                ' Combi box : 6-2-4-1 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-4-7 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-4-9 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ][ 5 ] '''''''''''''''''
                ' Combi box : 6-2-5-1 = O & 8-4-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-5-7 = O & 8-4-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-5-9 = O & 8-4-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box4.Text = "X" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 6-2-7-1 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-7-4 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-7-9 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 2 ][ 9 ] '''''''''''''''''
                ' Combi box : 6-2-9-1 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-9-4 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-2-9-7 = O & 8-5-3 = X
                If Box6.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box8.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 4 ][ 7 ] '''''''''''''''''
                ' Combi box : 6-4-7-2 = O & 1-5-3 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-7-8 = O & 1-5-3 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-4-7-9 = O & 1-5-3 = X
                If Box6.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ][ 1 ] '''''''''''''''''
                ' Combi box : 6-5-1-2 = O & 4-3-9 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-1-7 = O & 4-3-9 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-1-8 = O & 4-3-9 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ][ 2 ] '''''''''''''''''
                ' Combi box : 6-5-2-1 = O & 4-3-8 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-2-7 = O & 4-3-8 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-2-9 = O & 4-3-8 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box8.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ][ 7 ] '''''''''''''''''
                ' Combi box : 6-5-7-2 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-7-8 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-7-9 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box7.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ][ 8 ] '''''''''''''''''
                ' Combi box : 6-5-8-1 = O & 4-3-2 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-8-7 = O & 4-3-2 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-8-9 = O & 4-3-2 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box8.Text = "O" And Box9.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box2.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 5 ][ 9 ] '''''''''''''''''
                ' Combi box : 6-5-9-2 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-9-7 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box7.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-5-9-8 = O & 4-3-1 = X
                If Box6.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box4.Text = "X" And Box3.Text = "X" And Box1.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 7 ][ 2 ] '''''''''''''''''
                ' Combi box : 6-7-2-4 = O & 1-5-3 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-2-8 = O & 1-5-3 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-7-2-9 = O & 1-5-3 = X
                If Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 8 ][ 2 ] '''''''''''''''''
                ' Combi box : 6-8-2-4 = O & 1-5-3 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-2-7 = O & 1-5-3 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-8-2-9 = O & 1-5-3 = X
                If Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 6 ][ 9 ][ 1 ] '''''''''''''''''
                ' Combi box : 6-9-1-4 = O & 5-2-3 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-1-7 = O & 5-2-3 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box7.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And Box3.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 6-9-1-8 = O & 5-2-3 = X
                If Box6.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box8.Text = "O" And Box5.Text = "X" And Box2.Text = "X" And Box3.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 1 ][ 6 ] '''''''''''''''''
                ' Combi box : 7-1-6-3 = O & 2-5-4 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-6-8 = O & 2-5-4 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box8.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-1-6-9 = O & 2-5-4 = X
                If Box7.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box4.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 2 ][ 9 ] '''''''''''''''''
                ' Combi box : 7-2-9-3 = O & 1-5-8 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-9-4 = O & 1-5-8 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-2-9-6 = O & 1-5-8 = X
                If Box7.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 3 ][ 2 ] '''''''''''''''''
                ' Combi box : 7-3-2-4 = O & 1-5-8 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-2-6 = O & 1-5-8 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-3-2-9 = O & 1-5-8 = X
                If Box7.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 4 ][ 9 ] '''''''''''''''''
                ' Combi box : 7-4-9-2 = O & 1-5-8 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-9-3 = O & 1-5-8 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-4-9-6 = O & 1-5-8 = X
                If Box7.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 6 ][ 9 ] '''''''''''''''''
                ' Combi box : 7-6-9-3 = O & 1-2-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-9-4 = O & 1-2-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-6-9-8 = O & 1-2-5 = X
                If Box7.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box5.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 8 ][ 1 ] '''''''''''''''''
                ' Combi box : 7-8-1-2 = O & 4-5-9 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-1-3 = O & 4-5-9 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-8-1-6 = O & 4-5-9 = X
                If Box7.Text = "O" And Box8.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box9.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 7 ][ 9 ][ 2 ] '''''''''''''''''
                ' Combi box : 7-9-2-1 = O & 4-5-8 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-2-3 = O & 4-5-8 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 7-9-2-6 = O & 4-5-8 = X
                If Box7.Text = "O" And Box9.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 1 ][ 3 ] '''''''''''''''''
                ' Combi box : 8-1-3-4 = O & 2-5-7 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-3-6 = O & 2-5-7 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-1-3-9 = O & 2-5-7 = X
                If Box8.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 2 ][ 3 ] '''''''''''''''''
                ' Combi box : 8-2-3-4 = O & 1-5-7 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-3-6 = O & 1-5-7 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-2-3-9 = O & 1-5-7 = X
                If Box8.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 3 ][ 4 ] '''''''''''''''''
                ' Combi box : 8-3-4-2 = O & 1-5-7 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-4-6 = O & 1-5-7 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-3-4-9 = O & 1-5-7 = X
                If Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ][ 1 ] '''''''''''''''''
                ' Combi box : 8-4-1-3 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-1-6 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-1-9 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ][ 3 ] '''''''''''''''''
                ' Combi box : 8-4-3-1 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-3-6 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-3-9 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ][ 5 ] '''''''''''''''''
                ' Combi box : 8-4-5-1 = O & 2-6-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-5-3 = O & 2-6-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-5-9 = O & 2-6-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ][ 6 ] '''''''''''''''''
                ' Combi box : 8-4-6-1 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-6-3 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-6-9 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 4 ][ 9 ] '''''''''''''''''
                ' Combi box : 8-4-9-1 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-9-3 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-4-9-6 = O & 2-5-7 = X
                If Box8.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ][ 1 ] '''''''''''''''''
                ' Combi box : 8-5-1-3 = O & 2-9-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box9.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-1-6 = O & 2-9-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box6.Text = "O" And Box2.Text = "X" And Box9.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-1-4 = O & 2-9-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box1.Text = "O" And Box4.Text = "O" And Box2.Text = "X" And Box9.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ][ 3 ] '''''''''''''''''
                ' Combi box : 8-5-3-4 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-3-6 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-3-9 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box3.Text = "O" And Box9.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ][ 4 ] '''''''''''''''''
                ' Combi box : 8-5-4-1 = O & 2-6-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-4-3 = O & 2-6-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-4-9 = O & 2-6-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box4.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box6.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ][ 6 ] '''''''''''''''''
                ' Combi box : 8-5-6-1 = O & 2-4-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box1.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box7.Text = "X" Then
                    Box9.Text = "X"
                    Box9.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-6-3 = O & 2-4-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box3.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-6-9 = O & 2-4-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box6.Text = "O" And Box9.Text = "O" And Box2.Text = "X" And Box4.Text = "X" And Box7.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 8 ][ 5 ][ 9 ] '''''''''''''''''
                ' Combi box : 8-5-9-3 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box3.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-9-4 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box4.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 8-5-9-6 = O & 1-2-7 = X
                If Box8.Text = "O" And Box5.Text = "O" And Box9.Text = "O" And Box6.Text = "O" And Box1.Text = "X" And Box2.Text = "X" And Box7.Text = "X" Then
                    Box3.Text = "X"
                    Box3.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 1 ][ 2 ] '''''''''''''''''
                ' Combi box : 9-1-2-4 = O & 3-5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-2-6 = O & 3-5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-1-2-7 = O & 3-5-8 = X
                If Box9.Text = "O" And Box1.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 2 ][ 7 ] '''''''''''''''''
                ' Combi box : 9-2-7-1 = O & 3-5-8 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-7-4 = O & 3-5-8 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-2-7-6 = O & 3-5-8 = X
                If Box9.Text = "O" And Box2.Text = "O" And Box7.Text = "O" And Box6.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 3 ][ 4 ] '''''''''''''''''
                ' Combi box : 9-3-4-2 = O & 1-5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box2.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-4-8 = O & 1-5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box8.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box7.Text = "X"
                    Box7.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-3-4-7 = O & 1-5-6 = X
                If Box9.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box7.Text = "O" And Box1.Text = "X" And Box5.Text = "X" And Box6.Text = "X" Then
                    Box8.Text = "X"
                    Box8.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 6 ][ 7 ] '''''''''''''''''
                ' Combi box : 9-6-7-1 = O & 3-5-8 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box1.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-7-2 = O & 3-5-8 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-6-7-4 = O & 3-5-8 = X
                If Box9.Text = "O" And Box6.Text = "O" And Box7.Text = "O" And Box4.Text = "O" And Box3.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 7 ][ 2 ] '''''''''''''''''
                ' Combi box : 9-7-2-1 = O & 4-5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-2-3 = O & 4-5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box3.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box6.Text = "X"
                    Box6.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-7-2-6 = O & 4-5-8 = X
                If Box9.Text = "O" And Box7.Text = "O" And Box2.Text = "O" And Box1.Text = "O" And Box4.Text = "X" And Box5.Text = "X" And Box8.Text = "X" Then
                    Box1.Text = "X"
                    Box1.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ''''''''''''''''' [ 9 ][ 8 ][ 3 ] '''''''''''''''''
                ' Combi box : 9-8-3-1 = O & 6-5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box1.Text = "O" And Box6.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-3-2 = O & 6-5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box2.Text = "O" And Box6.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box4.Text = "X"
                    Box4.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
                ' Combi box : 9-8-3-4 = O & 6-5-7 = X
                If Box9.Text = "O" And Box8.Text = "O" And Box3.Text = "O" And Box4.Text = "O" And Box6.Text = "X" And Box5.Text = "X" And Box7.Text = "X" Then
                    Box2.Text = "X"
                    Box2.Enabled = False
                    player_turn.Text = "O"
                    Bot.Enabled = False
                    Exit Select
                End If
#End Region
        End Select
    End Sub

#Region "Boxes Sector"
    Private Sub Box1_Click(sender As Object, e As EventArgs) Handles Box1.Click
        Box1.Text = "O"       ' Get the text value into the the label(player_turn)
        Box1.Enabled = False  ' Disabling the box : So that it won't be never be clicked anymore
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box2_Click(sender As Object, e As EventArgs) Handles Box2.Click
        Box2.Text = "O"
        Box2.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box3_Click(sender As Object, e As EventArgs) Handles Box3.Click
        Box3.Text = "O"
        Box3.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box4_Click(sender As Object, e As EventArgs) Handles Box4.Click
        Box4.Text = "O"
        Box4.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box5_Click(sender As Object, e As EventArgs) Handles Box5.Click
        Box5.Text = "O"
        Box5.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box6_Click(sender As Object, e As EventArgs) Handles Box6.Click
        Box6.Text = "O"
        Box6.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box7_Click(sender As Object, e As EventArgs) Handles Box7.Click
        Box7.Text = "O"
        Box7.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box8_Click(sender As Object, e As EventArgs) Handles Box8.Click
        Box8.Text = "O"
        Box8.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub

    Private Sub Box9_Click(sender As Object, e As EventArgs) Handles Box9.Click
        Box9.Text = "O"
        Box9.Enabled = False
        player_turn.Text = "X"
        identifier += 1
        Bot.Enabled = True
    End Sub



#End Region
End Class
