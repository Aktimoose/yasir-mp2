Public Class endConfirmation
    Private Sub endConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coffeeShop.Close()
    End Sub
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        orderCount += 1
        coffeeShop.Show()
    End Sub
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub
End Class