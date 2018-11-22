
Public Class User_Int
    ''' <SIGNATURE>                                                                                       '''
    '''                                                                                                   '''
    '''                              *****      ****                ********                              '''
    '''                              ******    *****               ****     *                             '''
    '''                              **** **  ** *** *******        ******                                '''
    '''                              ****  ****  *** ***  **      *    ****                               '''
    '''                              ****   **   *** ***      *    ********                               '''
    '''                                 Program by : Sherwin D. Sandoval                                  '''
    '''                                                                                                   '''
    '''                           """""""""""""""""""""""""""""""""""""""""""""                           '''
    '''                           """""""""""""""""""""""""""""""""""""""""""""                           '''
    '''                           ""     LIFE IS TO SHORT FOR ARGUEMENTS     ""                           '''
    '''                           """""""""""""""""""""""""""""""""""""""""""""                           '''
    '''                           """""""""""""""""""""""""""""""""""""""""""""                           '''
    '''                                                                                                   '''
    '''                                                                                                   '''
    ''' PROGRESS:                                                                                         '''
    '''    > MAIN MENU : DONE : 10/16/17 :                                                                '''
    '''    > PLAYER VS PLAYER : DONE : 09/25/17 :                                                         '''
    '''    > PLAYER VS COMPUTER : 50% : 10/16/17 : STOP :                                                 '''
    '''         -> Artificial Intellegent(WHITE FLAG)                                                     '''
    '''                                                                                                   '''
    ''' </SIGNATURE>                                                                                      '''
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        PvP_Menu.Show()
        Me.Close()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Back.Visible = False
        Play.Visible = True
        About.Visible = True
        Exit_Button.Visible = True
    End Sub
    'Close
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        Play.Visible = False
        About.Visible = False
        Exit_Button.Visible = False
        Label6.Visible = True
        Ab_back.Visible = True
    End Sub

    Private Sub Ab_back_Click(sender As Object, e As EventArgs) Handles Ab_back.Click
        Label6.Visible = False
        Play.Visible = True
        About.Visible = True
        Exit_Button.Visible = True
        Ab_back.Visible = False
    End Sub
End Class
