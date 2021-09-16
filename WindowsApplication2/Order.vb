Public Class coffeeShop
	Dim receipt As String
	Dim total As Single
	Dim VATtotal As Single
	Dim grandTotal As Single
	Const VAT As Single = 0.2
	Dim coffeeQuantity As Integer
	Dim latteQuantity As Integer
	Dim hotChocolateQuantity As Integer
	Dim whippedCream As Boolean
	Dim waterQuantity As Integer
	Dim validation As Boolean
	Private Sub coffeeShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Executes the below block of code when the program loads
		LoginForm.Close()
		Dim randomCharacterOk As Char
		Randomize()
		randomCharacterOk = CChar(Mid$((Int((6 * Rnd()) + 1)), 1, 1))
		receipt = ""
		whippedCream = False
		MsgBox("welcome to official yasir coffe shepe Ok   " & randomCharacterOk) 'Welcomes the user
	End Sub
	Private Sub btnCoffeeOrder_Click(sender As Object, e As EventArgs) Handles btnCoffeeOrder.Click 'Executes the below block of code when the coffee button is clicked.
		Dim productTotal As Single
		Try
			coffeeQuantity = InputBox("How many coffees do you want?") 'Asks the user how many lattes they want
		Catch FormatException As Exception ' Checks to see if an error was caused by the user inputting something that wasn't the correct format (not an integer) to prevent a crash 
			MsgBox("it seems you didn't type an integer... i'll just charge you for a couple anyway.")
			coffeeQuantity = 2
		End Try
		productTotal = coffeeQuantity * 1.52
		total += productTotal 'Multiplies the quantity of coffees with the price (£1.52)
		receipt = receipt & vbNewLine & coffeeQuantity & " Coffee(s): £" & productTotal
		grandTotal = Math.Round(total, 2) 'Makes the grand total the total rounded to 2 decimal places
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		btnPay.Text = "Pay £" & Math.Round((grandTotal + VATtotal), 2) 'Shows the price on the pay button
	End Sub
	Private Sub btnLatte_Click(sender As Object, e As EventArgs) Handles btnLatte.Click
		Dim productTotal As Single
		Try
			latteQuantity = InputBox("How many lattes do you want?") 'Asks the user how many lattes they want
		Catch FormatException As Exception
			MsgBox("it seems you didn't type an integer, i guess that's fine, i'll just charge you for 50 lattes anyway.")
			latteQuantity = 50
		End Try
		productTotal = latteQuantity * 2.07
		total += productTotal 'Multiplies the quantity of lattes with the price (£2.07)
		receipt = receipt & vbNewLine & latteQuantity & " Latte(s): £" & productTotal
		grandTotal = Math.Round(total, 2) 'Makes the grand total the total rounded to 2 decimal places
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		btnPay.Text = "Pay £" & Math.Round((grandTotal + VATtotal), 2) 'Shows the price on the pay button
	End Sub
	Private Sub boxWhippedCream_CheckedChanged(sender As Object, e As EventArgs) Handles boxWhippedCream.CheckedChanged
		Select Case boxWhippedCream.Checked
			Case True
				whippedCream = True
			Case False
				whippedCream = False
		End Select
	End Sub
	Private Sub btnHotChocolate_Click(sender As Object, e As EventArgs) Handles btnHotChocolate.Click
		Dim productTotal As Single
		Try
			hotChocolateQuantity = InputBox("How many hot chocolates do you want?") 'Asks the user how many servings of hot chocolate they want
			If hotChocolateQuantity > 15 Then 'Checks to see if the user chose more than 15
				MsgBox("We can't sell over 15 hot chocolates at one time, sorry.")
				hotChocolateQuantity = 15
			ElseIf hotChocolateQuantity < 0 Then 'Checks to see if the user input a negative value to reset it to 0
				MsgBox("Negative hot chocolates? You are weird i will just give you 0")
				hotChocolateQuantity = 0
			End If
		Catch FormatException As Exception
			MsgBox("it seems you didn't type an integer, i'll just charge you for 20 hot chocolates anyway.")
			hotChocolateQuantity = 20
		End Try
		validation = False
		If whippedCream = True Then 'Checks if the user has asked for whipped cream
			productTotal = (hotChocolateQuantity * 1.74) + (hotChocolateQuantity * 0.2)
			total += productTotal 'If the user has asked for whipped cream, the price of the hot chocolate is added to the total as well as the price of the whipped cream.
			receipt = receipt & vbNewLine & hotChocolateQuantity & " Hot Chocolate(s) (with whipped cream): £" & productTotal
		Else
			total += hotChocolateQuantity * 1.74 'Without whipped cream, the price of the "Pay £" & Math.Round((grandTotal + VATtotal), 2)hot chocolate stays the same
			receipt = receipt & vbNewLine & hotChocolateQuantity & " Hot Chocolate(s): £" & total
		End If
		grandTotal = Math.Round(total, 2) 'Makes the grand total the total rounded to 2 decimal places
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		btnPay.Text = "Pay £" & Math.Round((grandTotal + VATtotal), 2) 'Shows the price on the pay button
	End Sub
	Private Sub lblWater_Click(sender As Object, e As EventArgs) Handles lblWater.Click
		Dim productTotal As Single
		Try
			waterQuantity = InputBox("How many Waters do you want?") 'Asks the user how many waters they want
		Catch FormatException As Exception
			MsgBox("it seems you didn't type an integer... weird.. i'll just take that as 0.")
			waterQuantity = 0
		End Try
		productTotal = waterQuantity * 0.08
		total += productTotal 'Multiplies the quantity of waters with the price (£0.08)
		receipt = receipt & vbNewLine & waterQuantity & " Water(s): £" & productTotal
		grandTotal = Math.Round(total, 2) 'Makes the grand total the total rounded to 2 decimal places
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		btnPay.Text = "Pay £" & Math.Round((grandTotal + VATtotal), 2) 'Shows the price on the pay button
	End Sub
	Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click 'Executes the below block of code when the pay button is clicked
		Dim referenceNo As String
		Dim name As String
		Dim reciept As String
		Dim payment As Single
		Dim change As Single
		Dim debtQ As String
		VATtotal = Math.Round((grandTotal * VAT), 2) 'Makes the VAT total the grand total * VAT
		grandTotal += VATtotal
		If grandTotal >= 50000 Then 'Checks if the amount they need to pay is 50000 or above
			MsgBox("you are really good at managing your money and spending it wisely")
		End If
		Try
			payment = InputBox("how much would you like to pay")
		Catch FormatException As Exception
			MsgBox("i'll take that as nothing...")
			payment = 0
		End Try
		change = Math.Round((payment - grandTotal), 2)
		If change < 0 Then 'checks if the change calculated is negative, and tells the user how much they owe
			change *= -1 'Makes the debt a positive number.
			debtQ = "You owe us £" & change & " since you only paid £" & payment
		ElseIf change = 0 Then
			debtQ = ""
		Else
			debtQ = "Your change is £" & change
		End If
		name = UCase(honorific & " " & Mid$(forename, 1, 1) & surname) 'Gets the honorific, the first character of the forename, and the surname and combines them.
		referenceNo = UCase(Mid$(forename, 1, 1) & surname & dayOfBirth & monthOfBirth) 'Gets the first character of the forename, the surname and the birth date and combines them.
		reciept = "Name: " & name & vbNewLine & receipt & vbNewLine & "VAT: " & VATtotal & vbNewLine & "Your order now comes to: " & grandTotal & vbNewLine & debtQ & vbNewLine & vbNewLine & "Reference No: " & referenceNo & vbNewLine & "Reference No but if it was lowercase: " & LCase(referenceNo)
		MsgBox(reciept)
		Me.Close()
	End Sub
End Class
