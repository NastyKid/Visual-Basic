Public Class Main_Menu
    ''' <summary>
    '''                                                                                                 '''
    ''' ***********                       ***********                      ***********                  '''
    ''' ***********                       ***********                      ***********                  '''
    ''' *********** *******    ******     ***********   ****     ******    ***********   ****    ****** '''
    '''    *****    *******   **    **       *****     **  **   **    **      *****     **  **   **     '''
    '''    *****      ***    ***             *****     ******  ***            *****    **    **  ****   '''
    '''    *****    *******   **    **       *****     **  **   **    **      *****     **  **   **     '''
    '''    *****    *******    ******        *****     **  **    ******       *****      ****    ****** '''
    '''*************************************************************************************************'''
    '''*************************************************************************************************'''
    '''                                 Developed by : Sherwin D. Sandoval                              '''
    '''                                     Tested by : Elton Tapinit                                   '''
    '''                                                                                                 '''
    '''                                                                                                 '''
    ''' UNBEATABLE TIC TAC TOE                                                                          '''
    '''  Date Started:  10.18.17                                                                        '''
    '''    PROGRESS:                                                                                    '''
    '''      > MAIN MENU : DONE : 9:00 PM : 10.18.17                                                    '''                                                      '''
    '''      > GAME :                                                                                   '''                                                '''
    '''                                                                                                 '''
    ''' </summary>

    Private Sub play_btn_Click(sender As Object, e As EventArgs) Handles play_btn.Click
        play_btn.Visible = False
        Exit_btn.Visible = False
        help_btn.Visible = False
        Back_btn.Visible = True
        Bot.Visible = True
        challenger.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub help_btn_Click(sender As Object, e As EventArgs) Handles help_btn.Click
        play_btn.Visible = False
        Exit_btn.Visible = False
        help_btn.Visible = False
        Back_btn.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = True
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        play_btn.Visible = True
        Exit_btn.Visible = True
        help_btn.Visible = True
        Back_btn.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = False
        challenger.Visible = False
        Bot.Visible = False

    End Sub

    Private Sub challenger_Click(sender As Object, e As EventArgs) Handles challenger.Click
        Game.Show()
        Me.Close()
    End Sub

    Private Sub Bot_Click(sender As Object, e As EventArgs) Handles Bot.Click
        Game2.Show()
        Me.Close()
    End Sub
End Class
