Public Class PvP_Menu
    ' Updates:
    ' 09/25 : 9:20 : Finished the Player Vs Player System

    ' Switching Player Turn
    Dim PlayerTurn As Integer = 1
    ' Stick Identifier
    Public Class Stick_Count
        ' Determiner of number of sticks in a row
        Public Shared R1 As Integer = 1
        Public Shared R2 As Integer = 3
        Public Shared R3 As Integer = 5
        Public Shared R4 As Integer = 7
    End Class
    ' Boolean Identifier
    Public Class Bools
        ' Determiner what row has been choosen
        Public Shared R1 As Boolean = False
        Public Shared R2 As Boolean = False
        Public Shared R3 As Boolean = False
        Public Shared R4 As Boolean = False
        Public Shared Police As Boolean = False ' Determine when an error encounter
    End Class
    'Back Button
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles PvP_Back.Click
        ' Go back to Main Menu and refresh the values of sticks.
        User_Int.Show()
        Stick_Count.R1 = 1
        Stick_Count.R2 = 3
        Stick_Count.R3 = 5
        Stick_Count.R4 = 7
        Bools.Police = False
        Bools.R1 = False
        Bools.R2 = False
        Bools.R3 = False
        Bools.R4 = False

        Me.Close()
    End Sub
    'Enter_button
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles PvP_Enter.Click
        If Bools.R1 = False And Bools.R2 = False And Bools.R3 = False And Bools.R4 = False Then
            MsgBox("Error" & vbNewLine & "Select a Row",, "GON")
        ElseIf Number_Stick.Value = 0 Then
            MsgBox("Error" & vbNewLine & "Invalid Value",, "GON")
        Else
            Sector_I()
            SureWin()
            Sector_II()
            ' Preventing to switch the Player if an error encounter
            If Bools.Police = True Then
                If PlayerTurn = 1 Then
                    PlayerTurn = 2
                ElseIf PlayerTurn = 2 Then
                    PlayerTurn = 1
                End If
                Bools.Police = False
            End If
            Label2.Text = CInt(PlayerTurn)
            Number_Stick.Value = 0
        End If

    End Sub
    'Refresh Entire Game
    Private Sub ReMatch_Click(sender As Object, e As EventArgs) Handles ReMatch.Click
        ' Values
        Bools.R1 = False
        Bools.R2 = False
        Bools.R3 = False
        Bools.R4 = False
        Stick_Count.R1 = 1
        Stick_Count.R2 = 3
        Stick_Count.R3 = 5
        Stick_Count.R4 = 7
        Number_Stick.Value = 0
        ' RadioButton and Others
        R1.Enabled = True
        R2.Enabled = True
        R3.Enabled = True
        R4.Enabled = True
        Number_Stick.Enabled = True
        PvP_Enter.Enabled = True
        Label2.Text = "1"
        Row1_stick.Text = "|"
        Row2_stick.Text = "|    |    |"
        Row3_stick.Text = "|    |    |    |    |"
        Row4_stick.Text = "|    |    |    |    |    |    |"
        ReMatch.Enabled = False
        ReMatch.Visible = False
    End Sub
    ' Row 1
    Private Sub R1_CheckedChanged(sender As Object, e As EventArgs) Handles R1.CheckedChanged
        Bools.R1 = True
        Bools.R2 = False
        Bools.R3 = False
        Bools.R4 = False
    End Sub
    ' Row 2
    Private Sub R2_CheckedChanged(sender As Object, e As EventArgs) Handles R2.CheckedChanged
        Bools.R1 = False
        Bools.R2 = True
        Bools.R3 = False
        Bools.R4 = False

    End Sub
    ' Row 3
    Private Sub R3_CheckedChanged(sender As Object, e As EventArgs) Handles R3.CheckedChanged
        Bools.R1 = False
        Bools.R2 = False
        Bools.R3 = True
        Bools.R4 = False

    End Sub
    ' Row 4
    Private Sub R4_CheckedChanged(sender As Object, e As EventArgs) Handles R4.CheckedChanged
        Bools.R1 = False
        Bools.R2 = False
        Bools.R3 = False
        Bools.R4 = True

    End Sub
    ' Game
    ' Sector I: Removing Sticks
    Function Sector_I() As String
        ' Row 1
        If Bools.R1 = True And Number_Stick.Value = 1 And Stick_Count.R1 <> 0 Then
            If Row1_stick.Text <> vbNullString Then
                Row1_stick.Text = ""
                Stick_Count.R1 = Stick_Count.R1 - Number_Stick.Value
            Else
                MsgBox("Row 1 has 0 number of stick",, "GON")
                Bools.Police = True
            End If
        ElseIf Bools.R1 = True And Number_Stick.Value <> Stick_Count.R1 Then
            MsgBox("Error" & vbNewLine & "Row 1 has only 1 stick",, "GON")
            Bools.Police = True
        ElseIf Bools.R1 = True And Number_Stick.Value = 1 And Stick_Count.R1 < 0 Then
            MsgBox("Error" & vbNewLine & " Row 1 has 0 number of stick ",, "GON")
            Bools.Police = True
        End If

        ' Row 2
        If Bools.R2 = True And Number_Stick.Value <= Stick_Count.R2 And Stick_Count.R2 <> 0 Then
            ' Empty the text in the label
            Row2_stick.Text = ""
            ' Reproduce the number of sticks. 
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Count.R2
                Row2_stick.Text &= "|    "
            Next
            If Stick_Count.R2 > 0 Then
                Stick_Count.R2 = Stick_Count.R2 - CInt(Number_Stick.Value)
            ElseIf Stick_Count.R2 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 2 has only" & CStr(Stick_Count.R2) & " stick/s",, "GON")
                Bools.Police = True
            End If
        ElseIf Bools.R2 = True And Number_Stick.Value > Stick_Count.R2 Then
            If Stick_Count.R2 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 2 has only " & CStr(Stick_Count.R2) & " stick/s",, "GON")
                Bools.Police = True
            Else
                MsgBox("Error" & vbNewLine & "Row 2 has only " & CStr(Stick_Count.R2) & " stick/s",, "GON")
                Bools.Police = True
            End If
        End If

        ' Row 3
        If Bools.R3 = True And Number_Stick.Value <= Stick_Count.R3 And Stick_Count.R3 <> 0 Then
            Row3_stick.Text = ""
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Count.R3
                Row3_stick.Text &= "|    "
            Next
            If Stick_Count.R3 > 0 Then
                Stick_Count.R3 = Stick_Count.R3 - CInt(Number_Stick.Value)
            ElseIf Stick_Count.R3 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 3 has only" & CStr(Stick_Count.R3) & " stick/s ",, "GON")
                Bools.Police = True
            End If
        ElseIf Bools.R3 = True And Number_Stick.Value > Stick_Count.R3 Then
            If Stick_Count.R3 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 3 has only " & CStr(Stick_Count.R3) & " stick/s",, "GON")
                Bools.Police = True
            Else
                MsgBox("Error" & vbNewLine & "Row 3 has only " & CStr(Stick_Count.R3) & " stick/s",, "GON")
                Bools.Police = True
            End If
        End If

        'Row 4
        If Bools.R4 = True And Number_Stick.Value <= Stick_Count.R4 And Stick_Count.R4 <> 0 Then
            Row4_stick.Text = ""
            For Stick As Integer = CInt(Number_Stick.Value) + 1 To Stick_Count.R4
                Row4_stick.Text &= "|    "
            Next
            If Stick_Count.R4 > 0 Then
                Stick_Count.R4 = Stick_Count.R4 - CInt(Number_Stick.Value)
            ElseIf Stick_Count.R4 < 0 Then
                MsgBox("Error" & vbNewLine & "Row 4 has only" & CStr(Stick_Count.R4) & " stick/s",, "GON")
                Bools.Police = True
            End If
        ElseIf Bools.R4 = True And Number_Stick.Value > Stick_Count.R4 Then
            If Stick_Count.R4 <= 0 Then
                MsgBox("Error" & vbNewLine & "Row 4 has only " & CStr(Stick_Count.R4) & " stick/s",, "GON")
                Bools.Police = True
            Else
                MsgBox("Error" & vbNewLine & "Row 4 has only " & CStr(Stick_Count.R4) & " stick/s",, "GON")
                Bools.Police = True
            End If
        End If
        Return vbNull
    End Function
    ' Sector II: Player switching
    Function Sector_II()
        PlayerTurn += 1
        If PlayerTurn = 3 Then
            PlayerTurn = PlayerTurn - 2
        End If
        Return vbNull
    End Function
    ' Sector III: Winner
    Function SureWin()
        Dim Total_Stick As Integer = 0
        Total_Stick = Stick_Count.R1 + Stick_Count.R2 + Stick_Count.R3 + Stick_Count.R4
        If Total_Stick = 1 Then
            If Stick_Count.R1 = 1 Then
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Count.R2 = 1 Then
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Count.R3 = 1 Then
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            ElseIf Stick_Count.R4 = 1 Then
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            End If
        ElseIf Total_Stick = 0 Then
            If PlayerTurn = 1 Then
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn + 1),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            Else
                MsgBox("CONGRATULATION PLAYER " & CStr(PlayerTurn - 1),, "GON")
                R1.Enabled = False
                R2.Enabled = False
                R3.Enabled = False
                R4.Enabled = False
                Number_Stick.Enabled = False
                PvP_Enter.Enabled = False
                ReMatch.Enabled = True
                ReMatch.Visible = True
            End If

        Else
            Return vbNull
        End If
        Return vbNull
    End Function
End Class