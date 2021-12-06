Public Class frmProfile
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click 'When The Login Button Is Pressed Login To Your Account'
        MessageBox.Show("You Have Successfully Logged Into Your Account") 'Prompts The End User That They Have Logged Into There Account'
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'When The Exit Button Is Pressed It Exits The Program'
        MessageBox.Show("Are You Sure You Want To Exit") 'Prompts The End User With A Confirmation If They Want To Leave The Program Or Not'
        End
    End Sub
End Class
