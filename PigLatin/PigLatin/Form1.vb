Public Class PigLatin
    ' Program : PIG LATIN
    ' Programmers : Villavelez & Sandoval
    Public Class Find

        Public Shared Consonants As String = "bcdfghjklmnpqrstvwxyz"
        Public Shared Vowels As String = "aeiou"

    End Class

    Private Sub Convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Convert.Click
        Dim Analyze As String = TextBox.Text
        Dim Vow As String = "AEIOU"
        ' CAPITILIZE ALL THE CHARACTERS IN TEXT THEN SEARCH FOR VOWELS
        ' It will return 0 If Found a Vowel and 1 if not.
        Dim I As Integer = Analyze.ToUpper().IndexOfAny(Vow)

        If I = 0 Then
            MsgBox(PigLatin_Conv_V())
        Else
            MsgBox(PigLatin_Conv_C())
        End If

    End Sub

    Function PigLatin_Conv_C() As String ' Consonants

        Dim Get_Text As String = TextBox.Text
        Dim Get_First_Letter As Char
        Dim Vow As String = "AEIOU"

        Dim test As String = vbNullString
        Dim test2 As String = vbNullString
        Dim test3 As String = vbNullString

        Dim S, Z As Integer
        Dim U, N, I As Integer

        For I = 0 To Find.Consonants.Length Step 1

            If Get_Text.StartsWith(Find.Consonants.Substring(I, 1)) Then   ' LOWERCASE

                test = Find.Consonants.Substring(I, 1) ' Store 1st Char
                Get_Text = Get_Text.Remove(0, 1) ' Remove the leading Char

                S = Get_Text.ToUpper().IndexOfAny(Vow)

                If S = 0 Then ' Examine If the 2nd character is a vowel
                    GoTo Line1
                Else
                    GoTo Line2
                End If


Line2:
                For U = 0 To Find.Consonants.Length Step 1 ' 2nd Consonant Char in the Word

                    If Get_Text.StartsWith(Find.Consonants.Substring(U, 1)) Then ' Matching
                        test2 = Find.Consonants.Substring(U, 1) ' Store then 2nd Char
                        Get_Text = Get_Text.Remove(0, 1) ' Remove the 2nd Char

                        S = Get_Text.ToUpper().IndexOfAny(Vow)

                        If S = 0 Then ' Examine If the 3rd character is a vowel
                            GoTo Line1
                        End If

                        For N = 0 To Find.Consonants.Length Step 1 ' 3rd Consonant Char in the Word
                            If Get_Text.StartsWith(Find.Consonants.Substring(N, 1)) Then
                                test3 = Find.Consonants.Substring(N, 1)
                                Get_Text = Get_Text.Remove(0, 1)
                                Exit For
                            ElseIf Get_Text.StartsWith("y") Then
                                Exit For
                            End If
                        Next

                        Exit For
                    ElseIf Get_Text.StartsWith("y") Then
                        Exit For
                    End If

                Next
Line1:
                ' Display
                Get_Text = Get_Text & test & test2 & test3 & "ay"
                Exit For
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf Get_Text.StartsWith(Char.ToUpper(Find.Consonants.Substring(I, 1))) Then  ' UPPERCASE

                test = Find.Consonants.Substring(I, 1)
                Get_Text = Get_Text.Remove(0, 1) ' Remove the 1st char
                Get_First_Letter = Get_Text.Substring(0, 1)


                Z = Get_Text.ToUpper().IndexOfAny(Vow)

                If Z = 0 Then ' Examine If the 2nd character is a vowel
                    Get_Text = Get_Text.Remove(0, 1)
                    GoTo Line4
                Else
                    GoTo Line3
                End If

Line3:
                For T As Integer = 0 To Find.Consonants.Length Step 1

                    If Get_Text.StartsWith(Find.Consonants.Substring(T, 1)) Then ' Matching

                        Get_First_Letter = Get_Text.Substring(0, 1) ' Get the 2nd Char
                        test2 = Find.Consonants.Substring(T, 1) ' Store then 2nd Char
                        Get_Text = Get_Text.Remove(0, 1) ' Remove the 2nd Char

                        Z = Get_Text.ToUpper().IndexOfAny(Vow)

                        If Z = 0 Then ' Examine If the 3rd character is a vowel
                            Get_First_Letter = Get_Text.Substring(0, 1)
                            Get_Text = Get_Text.Remove(0, 1)
                            GoTo Line4
                        End If

                        For Y = 0 To Find.Consonants.Length Step 1 ' 3rd Consonant Char in the Word
                            If Get_Text.StartsWith(Find.Consonants.Substring(Y, 1)) Then
                                Get_Text = Get_Text.Remove(0, 1) ' Remove the 2nd Char
                                Get_First_Letter = Get_Text.Substring(0, 1) ' Get the 3rd Char
                                test3 = Find.Consonants.Substring(Y, 1) ' Get the 3rd Char
                                Get_Text = Get_Text.Remove(0, 1) ' Remove the 3rd Char
                                Exit For
                            ElseIf Get_Text.StartsWith("y") Then
                                Get_First_Letter = Get_Text.Substring(0, 1) ' Get the 3rd Char
                                Get_Text = Get_Text.Remove(0, 1) ' Remove the 3rd Char
                                Exit For
                            End If
                        Next

                        Exit For
                    ElseIf Get_Text.StartsWith("y") Then
                        Get_First_Letter = Get_Text.Substring(0, 1) ' Get the 2nd Char
                        Get_Text = Get_Text.Remove(0, 1) ' Remove the 2nd Char
                        Exit For
                    End If
                Next

Line4:

                Get_Text = Char.ToUpper(Get_First_Letter) & Get_Text & test & test2 & test3 & "ay"
                Exit For
            Else
                Continue For
            End If

        Next

        Return Get_Text

    End Function

    Function PigLatin_Conv_V() As String ' VOWELS

        Dim Get_Text As String = TextBox.Text

        Dim I As Integer

        For I = 0 To Find.Vowels.Length Step 1

            If Get_Text.StartsWith(Find.Vowels.Substring(I, 1)) Or Get_Text.StartsWith(Char.ToUpper(Find.Vowels.Substring(I, 1))) Then
                Get_Text = Get_Text & "way"
                Exit For

            End If

        Next

        Return Get_Text

    End Function


    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox.TextChanged

    End Sub

End Class
