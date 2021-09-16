Public Class loginForm
    Dim colorChoice As Integer
    Dim invalidColor As Color
    Dim honorificValidation As Boolean
    Dim forenameValidation As Boolean
    Dim surnameValidation As Boolean
    Dim dayOfBirthValidation As Boolean
    Dim monthOfBirthValidation As Boolean
    Dim validation As Boolean
    Dim months30 As String() = {"April", "June", "September", "November"} 'Creates an array of all the months that have 30 days
    Dim month30 As Boolean
    Dim month29 As Boolean
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Sets the colour that appears when you enter an invalid
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
            invalidColor = Color.FromArgb(255, 255, 73, 73)
        Else
            invalidColor = Color.FromArgb(255, 244, 63, 72)
        End If
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close() 'Closes the program if you click Cancel
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        validation = True
        If forenameValidation = False Then 'Checks the validation for every input
            txtForename.BackColor = invalidColor 'If it's found to be false, it sets the colour as red and marks it as invalid
            validation = False
        End If
        If surnameValidation = False Then
            txtSurname.BackColor = invalidColor
            validation = False
        End If
        If dayOfBirthValidation = False Then
            cmbDayOfBirth.BackColor = invalidColor
            validation = False
        End If
        If monthOfBirthValidation = False Then
            cmbMonthOfBirth.BackColor = invalidColor
            validation = False
        End If
        If honorificValidation = False Then
            cmbHonorific.BackColor = invalidColor
            validation = False
        End If

        If CInt(dayOfBirth) < 10 Then 'Checks to see if the day of birth is a single digit, in which case it will put a "0" infront of it to make it two digits.
            dayOfBirth = "0" & dayOfBirth
        End If
        If CInt(monthOfBirth) < 10 Then
            monthOfBirth = "0" & monthOfBirth
        End If

        If validation = True Then
            coffeeShop.Show()
        End If
    End Sub
    Private Sub cmbHonorific_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHonorific.SelectedIndexChanged
        honorificValidation = True
        cmbHonorific.BackColor = Color.White
        honorific = cmbHonorific.SelectedItem
    End Sub
    Private Sub txtForename_TextChanged(sender As Object, e As EventArgs) Handles txtForename.TextChanged
        If Len(txtForename.Text) < 1 Then 'Checks to see if a forename was typed in
            txtForename.BackColor = invalidColor
        ElseIf Len(txtForename.Text) > 20 Then 'Checks to see if the forename is too long
            txtForename.BackColor = invalidColor
        Else
            txtForename.BackColor = Color.White
            forenameValidation = True
            forename = txtForename.Text
        End If
    End Sub
    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        If Len(txtSurname.Text) < 1 Then
            txtSurname.BackColor = invalidColor
        ElseIf Len(txtSurname.Text) > 20 Then
            txtSurname.BackColor = invalidColor
        Else
            txtSurname.BackColor = Color.White
            surnameValidation = True
            surname = txtSurname.Text
        End If
    End Sub
    Private Sub cmbMonthOfBirth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonthOfBirth.SelectedIndexChanged
        monthOfBirthValidation = True
        cmbMonthOfBirth.BackColor = Color.White
        monthOfBirth = cmbMonthOfBirth.SelectedIndex + 1 'Makes the numerical month of birth used in the reference number match the selected month
        cmbDayOfBirth.Enabled = True 'Unlocks the day of birth combo box if it wasn't already
        cmbDayOfBirth.Items.Clear()
        month30 = False
        month29 = False
        For Each month As String In months30
            If cmbMonthOfBirth.SelectedItem = month Then 'Checks to see if the month chosen is within the array "months30"
                month30 = True
            ElseIf cmbMonthOfBirth.SelectedItem = "February" Then
                month29 = True
            End If
        Next
        If month30 = True Or month29 = True Then
            If month30 = True And month29 = False Then
                For day = 1 To 30 'Adds the numbers from 1-30 into the combo box
                    cmbDayOfBirth.Items.Add(day)
                Next
            Else
                For day = 1 To 29
                    cmbDayOfBirth.Items.Add(day)
                Next
            End If
        Else
            For day = 1 To 31
                cmbDayOfBirth.Items.Add(day)
            Next
        End If
    End Sub
    Private Sub cmbDayOfBirth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDayOfBirth.SelectedIndexChanged
        dayOfBirthValidation = True
        cmbDayOfBirth.BackColor = Color.White
        dayOfBirth = cmbDayOfBirth.SelectedItem
    End Sub
End Class
