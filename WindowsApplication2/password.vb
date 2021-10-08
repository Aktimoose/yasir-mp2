Public Class password
    Const masterPassword As String = "one2three3two1three"
    Private Sub password_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Sets the colour that appears when you enter an invalid
        Randomize() 'Resets the random seed so that the next result is different every time
        colorChoice = (Mid$((Int((6 * Rnd()) + 1)), 1, 1)) 'Picks a number from 1-6
        If colorChoice = 6 Then
            colorChoice = (Mid$((Int((6 * Rnd()) + 1)), 1, 1))
            If colorChoice = 6 Then
                colorChoice = (Mid$((Int((6 * Rnd()) + 1)), 1, 1))
                If colorChoice = 6 Then
                    invalidColor = Color.Red 'Pure red gets chosen if the random number generator gets 3 6s in a row (1/216 chance)
                End If
            End If
        ElseIf Not (colorChoice = 5) Then
            invalidColor = Color.FromArgb(255, 255, 73, 73) 'A different shade of red gets chosen when the random number generator gets 5
        Else
            invalidColor = Color.FromArgb(255, 244, 63, 72)
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtPassword.Text = masterPassword Then 'Checks if the text the user typed equals the master password
            MsgBox("Ok you win")
            loginForm.Show() 'Shows the next login form
        Else
            txtPassword.BackColor = invalidColor 'Makes the colour of the text field the invalid colour
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Return Then 'If the user hits return, it will check in the same way it does when the user clicks the OK button
            If txtPassword.Text = masterPassword Then
                MsgBox("Ok you win")
                loginForm.Show()
            Else
                txtPassword.BackColor = invalidColor
            End If
        End If
    End Sub

    'Switches whether the text field uses the system password character or not when the user clicks the eye icon
    Private Sub imgEye_Click(sender As Object, e As EventArgs) Handles imgEye.Click
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        txtPassword.Text = masterPassword 'Inputs the master password for the user if they manage to click the "dev debug button"
    End Sub
End Class