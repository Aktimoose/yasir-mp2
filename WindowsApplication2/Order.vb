Public Class coffeeShop
	Private Sub coffeeShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Executes the below block of code when the program loads
		Dim payment As Single
		grandTotal = 0
		VATtotal = 0
		total = 0
		loginForm.Close()
		endConfirmation.Close()

		'Populates the form with the details captured in the arrays of items
		For Each product As Control In grpProducts.Controls
			product.Text = products(0, product.TabIndex)
		Next

		For Each price As Control In grpPrices.Controls
			price.Text = "£" & products(1, price.TabIndex)
		Next

		For Each desc As Control In grpDescs.Controls
			desc.Text = products(2, desc.TabIndex)
		Next

		For Each id As Control In grpIDs.Controls
			id.Text = products(3, id.TabIndex)
		Next

		receipt = ""
		'Checks any previous debt from previous orders
		If debt > 0 Then
			Try
				payment = InputBox("you still haven't paid back your debt. how much money do you want to give to clear it? (no i won't tell you how much your debt is)")
			Catch FormatException As Exception 'If the input the user put in was not a number, it will catch the error and just take it as 0
				MsgBox("i'll take that as nothing...")
				payment = 0
			End Try
			If payment < debt Then
				MsgBox("go away")
				Me.Close()
			Else
				debt = debt - payment 'Makes the debt negative
			End If
		End If
		If orderCount = 0 Then 'Checks if the order is the first one to determine whether to welcome the user for the first time or to welcome them back
			MsgBox("welcome to official yasir coffe shop real   !") 'Welcomes the user
		Else
			MsgBox("WELCOME BACK to the Zone")
		End If
	End Sub
	'All of the item buttons below opens up the ordering form and sets the item to the respective items
	Private Sub btnCoffeeOrder_Click(sender As Object, e As EventArgs) Handles btn0Order.Click
		productOrder = 0
		Ordering.Show()
	End Sub
	Private Sub btnLatte_Click(sender As Object, e As EventArgs) Handles btn1Order.Click
		productOrder = 1
		Ordering.Show()
	End Sub
	Private Sub btnHotChocolate_Click(sender As Object, e As EventArgs) Handles btn2Order.Click
		productOrder = 2
		Ordering.Show()
	End Sub
	Private Sub lblWater_Click(sender As Object, e As EventArgs) Handles btn3Order.Click
		productOrder = 3
		Ordering.Show()
	End Sub
	Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
		Dim referenceNo As String
		Dim name As String
		Dim payment As Single
		Dim change As Single
		Dim debtQ As String
		Dim strOrderLines As String
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		grandTotal += VATtotal
		If grandTotal >= 50000 Then 'Checks if the amount they need to pay is 50000 or above
			MsgBox("you are really good at managing your money and spending it wisely")
		End If
		Try
			payment = InputBox("how much would you like to pay")
		Catch FormatException As Exception 'If the input the user put in was not a number, it will catch the error and just take it as 0
			MsgBox("i'll take that as nothing...")
			payment = 0
		End Try
		payment -= debt
		change = Math.Round((payment - grandTotal), 2)
		If change < 0 Then 'checks if the change calculated is negative, and tells the user how much they owe
			debt = change * -1
			debtQ = "You owe us £" & debt & " since you only paid £" & payment
		ElseIf change = 0 Then
			debtQ = ""
		Else
			debtQ = "Your change is £" & change
			debt = debt - change
		End If
		name = UCase(honorific & " " & Mid$(forename, 1, 1) & surname) 'Gets the honorific, the first character of the forename, and the surname and combines them.
		referenceNo = UCase(Mid$(forename, 1, 1) & surname & dayOfBirth & monthOfBirth) 'Gets the first character of the forename, the surname and the birth date and combines them.

		orderlines(orderCount) = receipt & vbNewLine & "VAT: " & VATtotal

		receipt = "Name: " & name & vbNewLine & orderlines(orderCount) & vbNewLine & "Your order now comes to: " & grandTotal & vbNewLine & debtQ & vbNewLine & vbNewLine & "Reference No: " & referenceNo & vbNewLine & "Reference No but if it was lowercase: " & LCase(referenceNo)
		If orderCount < 4 Then
			MsgBox(receipt)
		End If

		'If the user has ordered before, it shows them all their previous orders
		If orderCount > 0 And orderCount < 4 Then
			strOrderLines = "Previous orders:" & vbNewLine
			For count = 0 To (orderCount - 1)
				strOrderLines += vbNewLine & Str(count + 1) & ")" & orderlines(count) & vbNewLine
			Next
			MsgBox(strOrderLines)
		End If

		'If this is the user's last order, it will show their last order along with all of their previous orders, instead of separately. It also opens a separate ending form.
		If orderCount = 4 Then
			strOrderLines = "Order lines:" & vbNewLine
			For count = 0 To (orderCount - 1)
				strOrderLines += vbNewLine & Str(count + 1) & ")" & orderlines(count) & vbNewLine
			Next
			MsgBox(strOrderLines)
			theEnd.Show()
		Else
			endConfirmation.Show()
		End If
		Me.Close()
	End Sub
End Class
