Public Class Application
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"" ****      ****                ********  ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"" *****    *****               ****     * ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"" *** **  ** *** *******        ******    ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"" ***  ****  *** ***  **      *    ****   ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"" ***   **   *** ***      *    ********   ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''""    Program by : Sherwin D. Sandoval     ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''""     LIFE IS TO SHORT FOR ARGUEMENTS     ""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''  
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''"""""""""""""""""""""""""""""""""""""""""""""'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Caluclator Date created 08.12.17
    ' Not yet applicable for series calculation
    ' One Operation at a time... 
    ' NOTE : NO EXPONENTIAL BUTTON
    '      : NO DECIMAL POINT
    ' PROGRESS:
    ' : DATE 08.13.17 : TIME 3:00 PM : Show Equation And displaying the current value if their is no operation key is selected.
    ' : DATE 08.13.17 : TIME 6:40 PM : Fix the Operation Keys bug.
    ' : DATE 08.14.17 : TIME 5:28 PM : Remodel the text appear in upper text box. The equation will appear when after you press an operator.
    ' : DATE 08.15.17 : TIME 9:11 PM : Adding a new Class and call it.
    '                 : TIME 9:40 PM : Add backspace button/'C' button.  
    ' : DATE 08.18.17 : TIME 9:46 PM : Applying Pesticide 
    '                                : I can not guarantee you that all the bugs has been died, but atleast their population become lesser.


    Public Class GlobalVariables
        ' For less memory Consumption

        Public Shared Value_One As Double
        Public Shared Value_Two As Double
        Public Shared Value_Three As Double
        Public Shared Value As Double

        Public Shared Get_Text As String
        Public Shared Remove_Char As String
        Public Shared Cookies As String

        Public Shared Add_click As Boolean = False
        Public Shared Sub_click As Boolean = False
        Public Shared Mul_click As Boolean = False
        Public Shared Div_click As Boolean = False
        Public Shared Mod_click As Boolean = False
        Public Shared Click As Boolean = True


    End Class
    ' Number keys

    Private Sub key_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_1.Click
        Monitor.AppendText("1")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_2.Click
        Monitor.AppendText("2")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_3.Click
        Monitor.AppendText("3")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_4.Click
        Monitor.AppendText("4")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_5.Click
        Monitor.AppendText("5")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_6.Click
        Monitor.AppendText("6")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_7.Click
        Monitor.AppendText("7")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_8.Click
        Monitor.AppendText("8")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_9.Click
        Monitor.AppendText("9")
        key_backspace.Enabled = True

    End Sub

    Private Sub key_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_0.Click
        Monitor.AppendText("0")
        key_backspace.Enabled = True

    End Sub

    ' Reset everything
    Private Sub key_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Clear.Click

        Dim key_clear As String
        key_clear = ""
        Monitor.Text = key_clear
        Disp_Eq.Text = key_clear

        GlobalVariables.Value_One = 0
        GlobalVariables.Value_Two = 0
        GlobalVariables.Value = 0
        GlobalVariables.Add_click = False
        GlobalVariables.Sub_click = False
        GlobalVariables.Mul_click = False
        GlobalVariables.Div_click = False
        GlobalVariables.Mod_click = False
        GlobalVariables.Click = True
        key_backspace.Enabled = False

    End Sub
    ' BackSpace 
    Private Sub key_backspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_backspace.Click

        Dim Gone As String
        Gone = Convert.ToString(Monitor.Text())

        If Gone.Length = 0 Then
            'If Gone.Length turns to 0. It will disable the button
            key_backspace.Enabled = False
        Else
            Gone = Gone.Remove(Gone.Length - 1)
            Monitor.Text = Gone
        End If

    End Sub
    ' Operations keys

    ' Addition
    Private Sub key_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Add.Click
        ' Tell the program that Add button has been clicked
        GlobalVariables.Add_click = True
        GlobalVariables.Sub_click = False
        GlobalVariables.Div_click = False
        GlobalVariables.Mul_click = False
        GlobalVariables.Mod_click = False

        Dim Turn As Integer

        If Monitor.Text = vbNullString Then
            If Not Disp_Eq.Text = vbNullString Then
                ' Removing the operand
                ' .IndexOf() : To find specific character in a string : Return Value As Integer
                ' .Replace(Old, New) 
                GlobalVariables.Cookies = Disp_Eq.Text
                If GlobalVariables.Cookies.IndexOf("+") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " + ")
                End If
                If GlobalVariables.Cookies.IndexOf("/") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " + ")
                End If
                If GlobalVariables.Cookies.IndexOf("-") >= 0 Then
                    If GlobalVariables.Cookies.LastIndexOf("/") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " + ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("+") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " + ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("*") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " + ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("Mod") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " + ")
                    Else ' BUG : Every Time it Satisfy, The Digits will slowly move away from the Operand
                        GlobalVariables.Cookies = StrReverse(GlobalVariables.Cookies)
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Remove(GlobalVariables.Cookies.Length - 2)
                        GlobalVariables.Cookies = " - " & StrReverse(GlobalVariables.Cookies)
                    End If
                End If
                If GlobalVariables.Cookies.IndexOf("Mod") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " + ")
                End If
                Disp_Eq.Text = GlobalVariables.Cookies
            End If
        Else
            ' Get the value get the value of the monitor
            GlobalVariables.Get_Text = Monitor.Text
            ' Convert the value in the Monitor. ( Monitor.Text is in a String datatype )
            GlobalVariables.Value = Convert.ToInt32(Monitor.Text)
            'Display
            If GlobalVariables.Value < 0 Then
                Turn = -1 * GlobalVariables.Value
                Monitor.Text = ""
                Disp_Eq.AppendText(" + " & Convert.ToString(Turn) & " - ")
            Else

                Monitor.Text = ""
                Disp_Eq.AppendText(" + " & GlobalVariables.Get_Text)
            End If
        End If

    End Sub
    ' Subtraction : Partly Fixed 
    Private Sub key_Sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Sub.Click
        GlobalVariables.Add_click = False
        GlobalVariables.Sub_click = True
        GlobalVariables.Div_click = False
        GlobalVariables.Mul_click = False
        GlobalVariables.Mod_click = False
        Dim Turn As Integer
        If Monitor.Text = vbNullString Then 'BUG
            If Monitor.Text = vbNullString And Disp_Eq.Text = vbNullString Then
                Monitor.AppendText("-")
            End If
            If Not Disp_Eq.Text = vbNullString Then
                ' Removing the operand
                ' .IndexOf() : To find specific character in a string : Return Value As Integer
                ' .Replace(Old, New) 
                GlobalVariables.Cookies = Disp_Eq.Text
                If GlobalVariables.Cookies.IndexOf("+") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " - ")
                End If
                If GlobalVariables.Cookies.IndexOf("/") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " - ")
                End If
                If GlobalVariables.Cookies.IndexOf("-") >= 0 Then
                    If GlobalVariables.Cookies.LastIndexOf("/") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " - ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("+") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " - ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("*") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " - ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("Mod") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " - ")
                    Else ' BUG : Every Time it Satisfy, The Digits will slowly move away from the Operand
                        GlobalVariables.Cookies = StrReverse(GlobalVariables.Cookies)
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Remove(GlobalVariables.Cookies.Length - 2)
                        GlobalVariables.Cookies = " - " & StrReverse(GlobalVariables.Cookies)
                    End If
                End If
                If GlobalVariables.Cookies.IndexOf("Mod") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " - ")
                End If
                Disp_Eq.Text = GlobalVariables.Cookies
            End If
        Else
            GlobalVariables.Get_Text = Monitor.Text
            GlobalVariables.Value = Convert.ToInt32(Monitor.Text)
            'Display
            If GlobalVariables.Value < 0 Then
                Turn = -1 * GlobalVariables.Value
                Monitor.Text = ""
                Disp_Eq.AppendText(" - " & Convert.ToString(Turn) & " - ")
            Else
                Monitor.Text = ""
                Disp_Eq.AppendText(" - " & GlobalVariables.Get_Text)
            End If
        End If

    End Sub
    ' Multiplication : Partly Fixed
    Private Sub key_Mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Mul.Click
        GlobalVariables.Add_click = False
        GlobalVariables.Sub_click = False
        GlobalVariables.Div_click = False
        GlobalVariables.Mul_click = True
        GlobalVariables.Mod_click = False


        If Monitor.Text = vbNullString Then
            If Not Disp_Eq.Text = vbNullString Then
                ' Removing the operand
                ' .IndexOf() : To find specific character in a string
                ' .Replace(Old, New) 
                GlobalVariables.Cookies = Disp_Eq.Text
                If GlobalVariables.Cookies.IndexOf("+") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " * ")
                End If
                If GlobalVariables.Cookies.IndexOf("/") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " * ")
                End If
                If GlobalVariables.Cookies.IndexOf("-") >= 0 Then
                    If GlobalVariables.Cookies.LastIndexOf("/") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " * ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("+") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " * ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("*") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " * ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("Mod") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " * ")
                    Else ' BUG : Every Time it Satisfy, The Digits will slowly move away from the Operand
                        GlobalVariables.Cookies = StrReverse(GlobalVariables.Cookies)
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Remove(GlobalVariables.Cookies.Length - 2)
                        GlobalVariables.Cookies = " * " & StrReverse(GlobalVariables.Cookies)
                    End If
                End If
                If GlobalVariables.Cookies.IndexOf("Mod") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " * ")
                End If
                Disp_Eq.Text = GlobalVariables.Cookies
            End If
        Else
            GlobalVariables.Get_Text = Monitor.Text
            GlobalVariables.Value = Convert.ToInt32(Monitor.Text)
            'Display
            Monitor.Text = ""
            If GlobalVariables.Value < 0 Then
                ' Removing the string " - "
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text)
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text.Remove(GlobalVariables.Get_Text.Length - 1))
                Disp_Eq.AppendText(" * " & GlobalVariables.Get_Text & "-")
            Else
                Disp_Eq.AppendText(" * " & GlobalVariables.Get_Text)
            End If
        End If
    End Sub
    ' Division : Partly Fixed
    Private Sub key_Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Div.Click
        GlobalVariables.Add_click = False
        GlobalVariables.Sub_click = False
        GlobalVariables.Div_click = True
        GlobalVariables.Mul_click = False
        GlobalVariables.Mod_click = False


        If Monitor.Text = vbNullString Then
            If Not Disp_Eq.Text = vbNullString Then
                ' Removing the operand
                ' .IndexOf() : To find specific character in a string : Return Value As Integer
                ' .Replace(Old, New) 
                GlobalVariables.Cookies = Disp_Eq.Text
                If GlobalVariables.Cookies.IndexOf("+") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " / ")
                End If
                If GlobalVariables.Cookies.IndexOf("*") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " / ")
                End If
                If GlobalVariables.Cookies.IndexOf("-") >= 0 Then
                    If GlobalVariables.Cookies.LastIndexOf("/") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " / ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("+") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " / ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("*") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " / ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("Mod") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " / ")
                    Else
                        GlobalVariables.Cookies = StrReverse(GlobalVariables.Cookies)
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Remove(GlobalVariables.Cookies.Length - 2)
                        GlobalVariables.Cookies = " / " & StrReverse(GlobalVariables.Cookies)
                    End If
                End If
                If GlobalVariables.Cookies.IndexOf("Mod") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " / ")
                End If
                Disp_Eq.Text = GlobalVariables.Cookies
            End If
        Else
            GlobalVariables.Get_Text = Monitor.Text
            GlobalVariables.Value = Convert.ToInt32(Monitor.Text)

            'Display
            Monitor.Text = ""
            If GlobalVariables.Value < 0 Then
                ' Removing the string " - "
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text)
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text.Remove(GlobalVariables.Get_Text.Length - 1))
                Disp_Eq.AppendText(" / " & GlobalVariables.Get_Text & "-")
            Else
                Disp_Eq.AppendText(" / " & GlobalVariables.Get_Text)
            End If
        End If

    End Sub
    ' Modulo : BUG : In Display
    Private Sub key_Mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Mod.Click

        GlobalVariables.Add_click = False
        GlobalVariables.Sub_click = False
        GlobalVariables.Div_click = False
        GlobalVariables.Mul_click = False
        GlobalVariables.Mod_click = True

        If Monitor.Text = vbNullString Then
            If Not Disp_Eq.Text = vbNullString Then
                ' Removing the operand
                ' .IndexOf() : To find specific character in a string : Return Value As Integer
                ' .Replace(Old, New) 
                GlobalVariables.Cookies = Disp_Eq.Text
                If GlobalVariables.Cookies.IndexOf("+") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " Mod ")
                End If
                If GlobalVariables.Cookies.IndexOf("/") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " Mod ")
                End If
                If GlobalVariables.Cookies.IndexOf("-") >= 0 Then
                    If GlobalVariables.Cookies.LastIndexOf("/") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" / ", " Mod ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("+") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" + ", " Mod ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("*") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " Mod ")
                    ElseIf GlobalVariables.Cookies.LastIndexOf("Mod") > 0 Then
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" Mod ", " Mod ")
                    Else ' BUG : Every Time it Satisfy, The Digits will slowly move away from the Operand
                        GlobalVariables.Cookies = StrReverse(GlobalVariables.Cookies)
                        GlobalVariables.Cookies = GlobalVariables.Cookies.Remove(GlobalVariables.Cookies.Length - 2)
                        GlobalVariables.Cookies = " Mod " & StrReverse(GlobalVariables.Cookies)
                    End If
                End If
                If GlobalVariables.Cookies.IndexOf("*") > 0 Then
                    GlobalVariables.Cookies = GlobalVariables.Cookies.Replace(" * ", " Mod ")
                End If
                Disp_Eq.Text = GlobalVariables.Cookies
            End If
        Else
            GlobalVariables.Get_Text = Monitor.Text
            GlobalVariables.Value = Convert.ToInt32(Monitor.Text)
            'Display
            Monitor.Text = ""
            If GlobalVariables.Value < 0 Then
                ' Removing the string " - "
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text)
                GlobalVariables.Get_Text = StrReverse(GlobalVariables.Get_Text.Remove(GlobalVariables.Get_Text.Length - 1))
                Disp_Eq.AppendText(" Mod " & GlobalVariables.Get_Text & "-")
            Else
                Disp_Eq.AppendText(" Mod " & GlobalVariables.Get_Text)
            End If
        End If
    End Sub
    ' Answer
    Private Sub key_Ans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_Ans.Click
        If (GlobalVariables.Add_click = False And GlobalVariables.Sub_click = False And GlobalVariables.Mul_click = False And GlobalVariables.Div_click = False And GlobalVariables.Mod_click = False) Then
            'If Their is no Operation Button click and the user chose to click the 'Ans' button. It will display the value of the 1st/Current Value in screen.
            GlobalVariables.Value_One = 0
            Monitor.Text = Convert.ToString(GlobalVariables.Value_One)
        Else
            If Monitor.Text = vbNullString Then
                'Initialize the GV.Value_Two into Zero
                GlobalVariables.Value_Two = 0
            Else
                'Get the Converted value and store in GV.Value_Two
                GlobalVariables.Value_Two = Convert.ToInt32(Monitor.Text)
                If GlobalVariables.Value_Two = 0 And GlobalVariables.Div_click Then
                    Disp_Eq.Text = "Connot divided by zero"
                    Monitor.Text = ""
                Else
                    Disp_Eq.Text = ""
                    Monitor.Text = Convert.ToString(Do_Calc())
                End If
            End If
        End If
        GlobalVariables.Click = False
    End Sub
    ' Functions Do_Calc : Where the values have been Add, Sub, Mul, Div, and Mod.
    Function Do_Calc() As Integer
        ' Add
        If GlobalVariables.Add_click Then
            GlobalVariables.Value_One = GlobalVariables.Value
            Return GlobalVariables.Value_One + GlobalVariables.Value_Two
        End If
        ' Sub
        If GlobalVariables.Sub_click Then
            GlobalVariables.Value_One = GlobalVariables.Value
            ' Playing Safe :D 
            If GlobalVariables.Value_Two < 0 And GlobalVariables.Value_One < 0 Then
                Return GlobalVariables.Value_One + GlobalVariables.Value_Two

            ElseIf GlobalVariables.Value_Two < 0 Then
                Return (-1 * GlobalVariables.Value_One) + GlobalVariables.Value_Two

            Else
                Return GlobalVariables.Value_One - GlobalVariables.Value_Two
            End If
        End If
        ' Mul
        If GlobalVariables.Mul_click Then
            GlobalVariables.Value_One = GlobalVariables.Value
            Return GlobalVariables.Value_One * GlobalVariables.Value_Two
        End If
        ' Div
        If GlobalVariables.Div_click Then
            GlobalVariables.Value_One = GlobalVariables.Value
            Return GlobalVariables.Value_One \ GlobalVariables.Value_Two
        End If
        ' Mod
        If GlobalVariables.Mod_click Then
            GlobalVariables.Value_One = GlobalVariables.Value
            Return GlobalVariables.Value_One Mod GlobalVariables.Value_Two
        End If
        Return vbNull

    End Function
    ' Other Operator : TO BE CONTINUE :
    Private Sub key_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles key_next.Click
        ' Setting You as the object of Other_Op
        ' Under Construction 
        Dim kettle_korn As New Other_Op()
        If Me.You Is Nothing Then
            Monitor.Text = "[E][R][R][O][R] "
            Disp_Eq.Text = ". . . To be continue "
        Else
            kettle_korn.Show()
        End If
    End Sub

    Private Sub Disp_Eq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disp_Eq.TextChanged
        ' Display Equition 
    End Sub

    Public Sub Monitor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monitor.TextChanged
    End Sub

    Function You() As Nullable
        Return Nothing
    End Function



End Class
