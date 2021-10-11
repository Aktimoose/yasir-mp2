Public Class Ordering
    Private Sub Ordering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coffeeShop.Enabled = False 'Makes the user unable to interact with the original coffee shop form before finishing this order
        lblItem.Text = "Item: " & products(0, productOrder)
        'If the product order is Hot Chocolate, it will make the group box that handles extras like Whipped Cream visible, and extend the width of the form
        If productOrder = 2 Then
            grpExtras.Visible = True
            Me.Width = 581
            btnOk.Width = 539
            'If the product order is not Hot Chocolate, it will make the group box that handles extras invisible, and decrease the width of the form
        Else
            chkWhippedCream.Checked = False
            grpExtras.Visible = False
            Me.Width = 467
            btnOk.Width = 424
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim productLine As String
        Dim productTotal As Single
        Dim extras As String = ""
        products(4, productOrder) = numAmount.Value

        Select Case radIcedYes.Checked
            Case True
                extras = extras + " (iced)" 'Adds "(iced)" to the extras section of the order line
        End Select

        Select Case radSip.Checked
            'Adds the variant of cup to the extras section of the order line
            Case True
                extras = extras + " (the cup you sip from idk)"
            Case False
                extras = extras + " (the cup with a straw in)"
        End Select

        Select Case chkWhippedCream.Checked
            Case True
                productTotal = (products(4, productOrder) * products(1, productOrder)) + (products(4, productOrder) * 0.2) 'If the user has asked for whipped cream, the price of the hot chocolate is added to the total as well as the price of the whipped cream.
                extras = extras + " (with whipped cream)" 'Adds the whipped cream to the extras section of the order line
            Case False
                productTotal = products(4, productOrder) * products(1, productOrder) 'Without whipped cream, the price of the hot chocolate stays the same
        End Select

        total += productTotal
        productLine = products(4, productOrder) & " " & products(0, productOrder) & "(s)" & extras & ": £" & productTotal 'Creates the line of the receipt that contains this item order
        receipt += vbNewLine & productLine
        coffeeShop.lstReceipt.Items.Add(productLine) 'Displays this order line on the main coffee shop form
        grandTotal = Math.Round(total, 2) 'Makes the grand total the total rounded to 2 decimal places
        VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
        coffeeShop.btnPay.Text = "Pay £" & Math.Round((grandTotal + VATtotal), 2) 'Shows the price on the pay button
        coffeeShop.Enabled = True 'Allows the user to interact with the coffee shop form again
        Me.Close()
    End Sub

    Private Sub lblBepis_Click(sender As Object, e As EventArgs) Handles lblBepis.Click
        MsgBox("You've unlocked: pipis")
        numAmount.Minimum = -6666
    End Sub
End Class