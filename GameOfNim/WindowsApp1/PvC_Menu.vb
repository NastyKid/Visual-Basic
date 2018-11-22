Public Class PvC_Menu
    ''' <UPDATES_AND_BUGS>
    ''' UPDATES:
    ''' 09/25 : 9:20 : Built the entire AI system.
    ''' 
    ''' BUGS:
    ''' Determine who is the winner
    ''' Enhance AI
    ''' 
    ''' </UPDATES_AND_BUGS>
    Dim Player_Switch As Integer = 1
    Dim Phase As Integer = 1
    ' Number of Stick Identifier
    Public Class Stick_Num
        ' Determiner of number of sticks in a row
        Public Shared R1 As Integer = 1
        Public Shared R2 As Integer = 3
        Public Shared R3 As Integer = 5
        Public Shared R4 As Integer = 7
    End Class
    ' Active key Identifier
    Public Class Bool
        ' Determiner what row has been choosen
        Public Shared R1 As Boolean = False
        Public Shared R2 As Boolean = False
        Public Shared R3 As Boolean = False
        Public Shared R4 As Boolean = False
    End Class
    ' Enter Button
    Private Async Sub Enter_Click(sender As Object, e As EventArgs) Handles PvC_Enter.Click

        If Bool.R1 = False And Bool.R2 = False And Bool.R3 = False And Bool.R4 = False Then
            MsgBox("Error" & vbNewLine & "Select a Row",, "GON")
        ElseIf Number_Stick.Value = 0 Then
            MsgBox("Error" & vbNewLine & "Invalid Value",, "GON")
        Else
            SectorI()
            SectorII()
            Label2.Text = CStr(Player_Switch)
            SectorIV()
            Await Task.Delay(5000)
            AI() ' Sector III
            SectorII()
            Phase = Phase + 1
            Label2.Text = CStr(Player_Switch)
            Number_Stick.Value = 0
        End If
    End Sub
    ' Rematch
    Private Sub ReMatch_Click(sender As Object, e As EventArgs) Handles ReMatch.Click

    End Sub
    ' Back
    Private Sub PvC_Back_Click(sender As Object, e As EventArgs) Handles PvC_Back.Click
        User_Int.Show()
        Stick_Num.R1 = 1
        Stick_Num.R2 = 3
        Stick_Num.R3 = 5
        Stick_Num.R4 = 7
        Bool.R1 = False
        Bool.R2 = False
        Bool.R3 = False
        Bool.R4 = False
        Me.Close()
    End Sub
    ' Row 1
    Private Sub R1_CheckedChanged(sender As Object, e As EventArgs) Handles R1.CheckedChanged
        Bool.R1 = True
        Bool.R2 = False
        Bool.R3 = False
        Bool.R4 = False
    End Sub
    ' Row 2
    Private Sub R2_CheckedChanged(sender As Object, e As EventArgs) Handles R2.CheckedChanged
        Bool.R1 = False
        Bool.R2 = True
        Bool.R3 = False
        Bool.R4 = False
    End Sub
    ' Row 3
    Private Sub R3_CheckedChanged(sender As Object, e As EventArgs) Handles R3.CheckedChanged
        Bool.R1 = False
        Bool.R2 = False
        Bool.R3 = True
        Bool.R4 = False
    End Sub

    ' Row 4
    Private Sub R4_CheckedChanged(sender As Object, e As EventArgs) Handles R4.CheckedChanged
        Bool.R1 = False
        Bool.R2 = False
        Bool.R3 = False
        Bool.R4 = True
    End Sub

    ' Game
    ' Sector I : Removing Sticks
    Function SectorI()
        ' Row 1
        If Bool.R1 = True And Number_Stick.Value = 1 And Stick_Num.R1 <> 0 Then
            If Row1_stick.Text <> vbNullString Then
                Row1_stick.Text = ""
                Stick_Num.R1 = Stick_Num.R1 - Number_Stick.Value
            Else
                MsgBox("Row 1 has 0 stick",, "GON")
            End If
        ElseIf Bool.R1 = True And Number_Stick.Value <> Stick_Num.R1 Then
            MsgBox("Error" & vbNewLine & CStr(Number_Stick.Value) & " Is greater than the number of stick in Row 1 ",, "GON")
        ElseIf Bool.R1 = True And Number_Stick.Value = 1 And Stick_Num.R1 < 0 Then
            MsgBox("Error" & vbNewLine & " Row 1 has 0 stick",, "GON")
        End If

        ' Row 2
        If Bool.R2 = True And Number_Stick.Value <= Stick_Num.R2 And Stick_Num.R2 <> 0 Then
            ' Empty the text in the label
            Row2_stick.Text = ""
            ' Reproduce the number of sticks. 
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                Row2_stick.Text &= "|    "
            Next
            If Stick_Num.R2 > 0 Then
                ' Update the Value of Stick... 
                Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
            ElseIf Stick_Num.R2 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 2 has " & CStr(Stick_Num.R2) & " number of sticks ",, "GON")
            End If
        ElseIf Bool.R2 = True And Number_Stick.Value > Stick_Num.R2 Then
            If Stick_Num.R2 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 2 has only " & CStr(Stick_Num.R2) & "stick/s",, "GON")
            Else
                MsgBox("Error" & vbNewLine & "Row 2 has only " & CStr(Stick_Num.R2) & "stick/s ",, "GON")
            End If
        End If

        ' Row 3
        If Bool.R3 = True And Number_Stick.Value <= Stick_Num.R3 And Stick_Num.R3 <> 0 Then
            Row3_stick.Text = ""
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                Row3_stick.Text &= "|    "
            Next
            If Stick_Num.R3 > 0 Then
                Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
            ElseIf Stick_Num.R3 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 3 has " & CStr(Stick_Num.R3) & " number of sticks ",, "GON")
            End If
        ElseIf Bool.R3 = True And Number_Stick.Value > Stick_Num.R3 Then
            If Stick_Num.R3 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 3 has only " & CStr(Stick_Num.R3) & "stick/s",, "GON")
            Else
                MsgBox("Error" & vbNewLine & "Row 3 has only " & CStr(Stick_Num.R3) & "stick/s",, "GON")
            End If
        End If

        ' Row 4
        If Bool.R4 = True And Number_Stick.Value <= Stick_Num.R4 And Stick_Num.R4 <> 0 Then
            Row4_stick.Text = ""
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                Row4_stick.Text &= "|    "
            Next
            If Stick_Num.R4 > 0 Then
                Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
            ElseIf Stick_Num.R4 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 4 has " & CStr(Stick_Num.R4) & " number of sticks ",, "GON")
            End If
        ElseIf Bool.R4 = True And Number_Stick.Value > Stick_Num.R4 Then
            If Stick_Num.R4 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 4 has only " & CStr(Stick_Num.R4) & "stick/s",, "GON")
            Else
                MsgBox("Error" & vbNewLine & "Row 4 has only " & CStr(Stick_Num.R4) & "stick/s",, "GON")
            End If
        End If
        Return vbNull
    End Function
    ' Sector II: Player Switching
    Function SectorII()
        Dim Store As Integer
        Player_Switch += 1
        If Player_Switch = 3 Then
            Player_Switch = Player_Switch - 2
        End If
        Return Store = Player_Switch
    End Function
    ' Sector III: Artificial Intelligent
    '''<StickConfg>
    '''Row1 = 1	= 1 x (1)		 	
    '''Row2 = 3	= 1 x (2) + 1 x (1)	
    '''Row3 = 5	= 1 x (4) + 1 x (1)	
    '''Row4 = 7	= 1 x (4) + 1 x (2) + 1 x (1)
    '''</StickConfg>
    Function AI()
        Dim Get_Value As Integer = CInt(Number_Stick.Value)
        ' PHASE I 
        If Phase = 1 Then
            If Get_Value = 1 Then
                If Bool.R1 = True Then
                    Row2_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                        Row2_stick.Text &= "|    "
                    Next
                    Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
                ElseIf Bool.R2 = True Then
                    Row3_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                ElseIf Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                ElseIf Bool.R4 = True Then
                    Row1_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R1
                        Row1_stick.Text &= "|    "
                    Next
                    Stick_Num.R1 = Stick_Num.R1 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 2 Then
                If Bool.R2 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                ElseIf Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = 6 + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - 6
                ElseIf Bool.R4 = True Then
                    Row2_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                        Row2_stick.Text &= "|    "
                    Next
                    Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)

                End If
            ElseIf Get_Value = 3 Then
                If Bool.R2 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)

                ElseIf Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = 7 + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - 7
                ElseIf Bool.R4 = True Then
                    Row2_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                        Row2_stick.Text &= "|    "
                    Next
                    Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 4 Then
                If Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                ElseIf Bool.R4 = True Then
                    Row3_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 5 Then
                If Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)

                ElseIf Bool.R4 = True Then
                    Row3_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 6 Then
                If Bool.R4 = True Then

                    Row3_stick.Text = ""
                    For Stick As Integer = 2 + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - 2

                End If
            ElseIf Get_Value = 7 Then
                If Bool.R4 = True Then

                    Row3_stick.Text = ""
                    For Stick As Integer = 3 + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - 3

                End If
            End If
        ElseIf Phase = 2 Then
            If Get_Value = 1 Then
                If Bool.R1 = True Then
                    If Stick_Num.R2 <> 0 Or Stick_Num.R2 < 0 Then
                        Row2_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                            Row2_stick.Text &= "|    "
                        Next
                        Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
                    ElseIf Stick_Num.R3 <> 0 Or Stick_Num.R3 < 0 Then
                        Row3_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                            Row3_stick.Text &= "|    "
                        Next
                        Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                    ElseIf Stick_Num.R4 <> 0 Or Stick_Num.R4 < 0 Then
                        Row4_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                            Row4_stick.Text &= "|    "
                        Next
                        Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                    End If
                ElseIf Bool.R2 = True Then
                    If Stick_Num.R2 <> 0 Or Stick_Num.R2 < 0 Then
                        Row2_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                            Row2_stick.Text &= "|    "
                        Next
                        Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
                    ElseIf Stick_Num.R3 <> 0 Or Stick_Num.R3 < 0 Then
                        Row3_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                            Row3_stick.Text &= "|    "
                        Next
                        Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                    ElseIf Stick_Num.R4 <> 0 Or Stick_Num.R4 < 0 Then
                        Row4_stick.Text = ""
                        For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                            Row4_stick.Text &= "|    "
                        Next
                        Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                    End If

                End If

            ElseIf Bool.R2 = True Then
                Row3_stick.Text = ""
                For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                    Row3_stick.Text &= "|    "
                Next
                Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
            ElseIf Bool.R3 = True Then
                Row4_stick.Text = ""
                For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                    Row4_stick.Text &= "|    "
                Next
                Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
            ElseIf Bool.R4 = True Then
                Row1_stick.Text = ""
                For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R1
                    Row1_stick.Text &= "|    "
                Next
                Stick_Num.R1 = Stick_Num.R1 - CInt(Number_Stick.Value)
            End If

        ElseIf Get_Value = 2 Then
                If Bool.R2 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                ElseIf Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = 6 + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - 6
                ElseIf Bool.R4 = True Then
                    Row2_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                        Row2_stick.Text &= "|    "
                    Next
                    Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)

                End If
            ElseIf Get_Value = 3 Then
                If Bool.R2 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)

                ElseIf Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = 7 + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - 7
                ElseIf Bool.R4 = True Then
                    Row2_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R2
                        Row2_stick.Text &= "|    "
                    Next
                    Stick_Num.R2 = Stick_Num.R2 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 4 Then
                If Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)
                ElseIf Bool.R4 = True Then
                    Row3_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 5 Then
                If Bool.R3 = True Then
                    Row4_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R4
                        Row4_stick.Text &= "|    "
                    Next
                    Stick_Num.R4 = Stick_Num.R4 - CInt(Number_Stick.Value)

                ElseIf Bool.R4 = True Then
                    Row3_stick.Text = ""
                    For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - CInt(Number_Stick.Value)
                End If
            ElseIf Get_Value = 6 Then
                If Bool.R4 = True Then

                    Row3_stick.Text = ""
                    For Stick As Integer = 2 + 1 To Stick_Num.R3
                        Row3_stick.Text &= "|    "
                    Next
                    Stick_Num.R3 = Stick_Num.R3 - 2

                End If
            ElseIf Get_Value = 7 Then
            If Bool.R4 = True Then

                Row3_stick.Text = ""
                For Stick As Integer = 3 + 1 To Stick_Num.R3
                    Row3_stick.Text &= "|    "
                Next
                Stick_Num.R3 = Stick_Num.R3 - 3

            End If
        End If


        Return vbNull
    End Function
    ' Sector IV: Winner
    Function SectorIV()
        Dim Total_Stick As Integer = 0
        Total_Stick = Stick_Num.R1 + Stick_Num.R2 + Stick_Num.R3 + Stick_Num.R4
        If Total_Stick = 1 Then
            If Stick_Num.R1 = 1 Then
                If Player_Switch = 2 Then
                    MsgBox("CONGRATUALATION PLAYER ",, "GON")
                Else
                    MsgBox("You Lose",, "GON")
                End If

                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Num.R2 = 1 Then
                If Player_Switch = 2 Then
                    MsgBox("CONGRATUALATION PLAYER ",, "GON")
                Else
                    MsgBox("You Lose",, "GON")
                End If
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Num.R3 = 1 Then
                If Player_Switch = 2 Then
                    MsgBox("CONGRATUALATION PLAYER ",, "GON")
                Else
                    MsgBox("You Lose",, "GON")
                End If
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Num.R4 = 1 Then
                If Player_Switch = 2 Then
                    MsgBox("CONGRATUALATION PLAYER ",, "GON")
                Else
                    MsgBox("You Lose",, "GON")
                End If
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            End If
        ElseIf Total_Stick = 0 Then
            If Player_Switch = 1 Then
                MsgBox("CONGRATUALATION PLAYER ",, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            Else
                MsgBox("You Lose",, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvC_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            End If

        Else
            Return vbNull
        End If
        Return vbNull
    End Function

End Class