Public Class frmHome
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Simple if else loop for login'

        If txtUsername.Text = "username" And txtPassword.Text = "pass123" Then
            frmMain.Show()
            Me.Hide()

        Else
            MessageBox.Show("Ïncorrect password or username")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
