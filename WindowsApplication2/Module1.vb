Module Module1
    'Setting variables here lets me make them fully global across multiple forms
    Public colorChoice As Integer
    Public invalidColor As Color

    Public forename As String
    Public surname As String
    Public monthOfBirth As String
    Public dayOfBirth As String
    Public honorific As String

    'Sets the details of the products
    Public products As String() = {"Coffee", "Latte", "Hot Chocolate", "Water"}
    Public productPrices As Single() = {1.52, 2.07, 1.74, 0.08}
    Public productDescs As String() = {"A basic hot drink made from the organic and freshly roasted coffee beans of a local shrub.",
        "A form of coffee made with espresso as well as hot steamed milk.",
        "A mix of water and the finest chocolate powder. Whipped Cream optional.",
        "Just water. It's just water. Nothing special."}
    Public productIDs As String() = {"coff", "latt", "hoCho", "watt"}
    Public productsQuantity(0 To 3) As Integer
    Public productOrder As Integer

    Public total As Single
    Public receipt As String
    Public Const VAT As Single = 0.2
    Public VATtotal As Single
    Public grandTotal As Single

    Public debt As Single

    Public orderCount As Integer
    Public orderlines(0 To 4) As String
    Public orders As String
End Module










'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
'MAKE ALL ORDERS GO THROUGH Ordering.vb
