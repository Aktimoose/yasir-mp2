<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class coffeeShop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim lblProdIDHeader As System.Windows.Forms.Label
        Me.btnCoffeeOrder = New System.Windows.Forms.Button()
        Me.lblCoffeePrice = New System.Windows.Forms.Label()
        Me.lblLattePrice = New System.Windows.Forms.Label()
        Me.btnLatte = New System.Windows.Forms.Button()
        Me.lblHotChocolatePrice = New System.Windows.Forms.Label()
        Me.btnHotChocolate = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtCoffeeDesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.Label()
        Me.txtHotChocolateID = New System.Windows.Forms.Label()
        Me.txtLatteID = New System.Windows.Forms.Label()
        Me.txtCoffeeID = New System.Windows.Forms.Label()
        Me.txtNameHeader = New System.Windows.Forms.Label()
        Me.lblPriceHeader = New System.Windows.Forms.Label()
        Me.lblDescHeader = New System.Windows.Forms.Label()
        Me.lblInfoHeader = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWaterDesc = New System.Windows.Forms.Label()
        Me.lblWaterPrice = New System.Windows.Forms.Label()
        Me.lblWater = New System.Windows.Forms.Button()
        Me.boxWhippedCream = New System.Windows.Forms.CheckBox()
        lblProdIDHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProdIDHeader
        '
        lblProdIDHeader.AutoSize = True
        lblProdIDHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdIDHeader.Location = New System.Drawing.Point(563, 60)
        lblProdIDHeader.Name = "lblProdIDHeader"
        lblProdIDHeader.Size = New System.Drawing.Size(58, 13)
        lblProdIDHeader.TabIndex = 23
        lblProdIDHeader.Text = "Product ID"
        '
        'btnCoffeeOrder
        '
        Me.btnCoffeeOrder.Location = New System.Drawing.Point(12, 118)
        Me.btnCoffeeOrder.Name = "btnCoffeeOrder"
        Me.btnCoffeeOrder.Size = New System.Drawing.Size(93, 23)
        Me.btnCoffeeOrder.TabIndex = 1
        Me.btnCoffeeOrder.Text = "Coffee"
        Me.btnCoffeeOrder.UseVisualStyleBackColor = True
        '
        'lblCoffeePrice
        '
        Me.lblCoffeePrice.AutoSize = True
        Me.lblCoffeePrice.Location = New System.Drawing.Point(111, 123)
        Me.lblCoffeePrice.Name = "lblCoffeePrice"
        Me.lblCoffeePrice.Size = New System.Drawing.Size(34, 13)
        Me.lblCoffeePrice.TabIndex = 2233232
        Me.lblCoffeePrice.Text = "£1.52"
        '
        'lblLattePrice
        '
        Me.lblLattePrice.AutoSize = True
        Me.lblLattePrice.Location = New System.Drawing.Point(111, 186)
        Me.lblLattePrice.Name = "lblLattePrice"
        Me.lblLattePrice.Size = New System.Drawing.Size(34, 13)
        Me.lblLattePrice.TabIndex = 444
        Me.lblLattePrice.Text = "£2.07"
        '
        'btnLatte
        '
        Me.btnLatte.Location = New System.Drawing.Point(12, 181)
        Me.btnLatte.Name = "btnLatte"
        Me.btnLatte.Size = New System.Drawing.Size(93, 23)
        Me.btnLatte.TabIndex = 2
        Me.btnLatte.Text = "Latte"
        Me.btnLatte.UseVisualStyleBackColor = True
        '
        'lblHotChocolatePrice
        '
        Me.lblHotChocolatePrice.AutoSize = True
        Me.lblHotChocolatePrice.Location = New System.Drawing.Point(111, 253)
        Me.lblHotChocolatePrice.Name = "lblHotChocolatePrice"
        Me.lblHotChocolatePrice.Size = New System.Drawing.Size(34, 13)
        Me.lblHotChocolatePrice.TabIndex = 50
        Me.lblHotChocolatePrice.Text = "£1.74"
        '
        'btnHotChocolate
        '
        Me.btnHotChocolate.Location = New System.Drawing.Point(12, 248)
        Me.btnHotChocolate.Name = "btnHotChocolate"
        Me.btnHotChocolate.Size = New System.Drawing.Size(93, 23)
        Me.btnHotChocolate.TabIndex = 3
        Me.btnHotChocolate.Text = "Hot Chocolate"
        Me.btnHotChocolate.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(9, 373)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(722, 36)
        Me.btnPay.TabIndex = 5
        Me.btnPay.Text = "Pay £0.00"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'txtCoffeeDesc
        '
        Me.txtCoffeeDesc.AutoSize = True
        Me.txtCoffeeDesc.Location = New System.Drawing.Point(312, 102)
        Me.txtCoffeeDesc.Name = "txtCoffeeDesc"
        Me.txtCoffeeDesc.Size = New System.Drawing.Size(152, 39)
        Me.txtCoffeeDesc.TabIndex = 10
        Me.txtCoffeeDesc.Text = "A basic hot drink made from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the organic and freshly roasted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "coffee beans of a l" &
    "ocal shrub."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "A form of coffee made with espresso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as well as hot steamed milk."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "A mix of water and the finest chocolate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "powder. Whipped Cream optional."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(701, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "V"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(701, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "VE"
        '
        'txtKey
        '
        Me.txtKey.AutoSize = True
        Me.txtKey.Location = New System.Drawing.Point(701, 9)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(77, 26)
        Me.txtKey.TabIndex = 15
        Me.txtKey.Text = "VE = Vegan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "V = Vegetarian"
        '
        'txtHotChocolateID
        '
        Me.txtHotChocolateID.AutoSize = True
        Me.txtHotChocolateID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtHotChocolateID.Location = New System.Drawing.Point(563, 253)
        Me.txtHotChocolateID.Name = "txtHotChocolateID"
        Me.txtHotChocolateID.Size = New System.Drawing.Size(38, 13)
        Me.txtHotChocolateID.TabIndex = 19
        Me.txtHotChocolateID.Text = "hoCho"
        '
        'txtLatteID
        '
        Me.txtLatteID.AutoSize = True
        Me.txtLatteID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtLatteID.Location = New System.Drawing.Point(563, 178)
        Me.txtLatteID.Name = "txtLatteID"
        Me.txtLatteID.Size = New System.Drawing.Size(21, 13)
        Me.txtLatteID.TabIndex = 18
        Me.txtLatteID.Text = "latt"
        '
        'txtCoffeeID
        '
        Me.txtCoffeeID.AutoSize = True
        Me.txtCoffeeID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtCoffeeID.Location = New System.Drawing.Point(563, 102)
        Me.txtCoffeeID.Name = "txtCoffeeID"
        Me.txtCoffeeID.Size = New System.Drawing.Size(25, 13)
        Me.txtCoffeeID.TabIndex = 17
        Me.txtCoffeeID.Text = "coff"
        '
        'txtNameHeader
        '
        Me.txtNameHeader.AutoSize = True
        Me.txtNameHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameHeader.Location = New System.Drawing.Point(12, 60)
        Me.txtNameHeader.Name = "txtNameHeader"
        Me.txtNameHeader.Size = New System.Drawing.Size(58, 13)
        Me.txtNameHeader.TabIndex = 20
        Me.txtNameHeader.Text = "Item Name"
        '
        'lblPriceHeader
        '
        Me.lblPriceHeader.AutoSize = True
        Me.lblPriceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceHeader.Location = New System.Drawing.Point(111, 60)
        Me.lblPriceHeader.Name = "lblPriceHeader"
        Me.lblPriceHeader.Size = New System.Drawing.Size(31, 13)
        Me.lblPriceHeader.TabIndex = 21
        Me.lblPriceHeader.Text = "Price"
        '
        'lblDescHeader
        '
        Me.lblDescHeader.AutoSize = True
        Me.lblDescHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescHeader.Location = New System.Drawing.Point(312, 60)
        Me.lblDescHeader.Name = "lblDescHeader"
        Me.lblDescHeader.Size = New System.Drawing.Size(60, 13)
        Me.lblDescHeader.TabIndex = 22
        Me.lblDescHeader.Text = "Description"
        '
        'lblInfoHeader
        '
        Me.lblInfoHeader.AutoSize = True
        Me.lblInfoHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoHeader.Location = New System.Drawing.Point(701, 60)
        Me.lblInfoHeader.Name = "lblInfoHeader"
        Me.lblInfoHeader.Size = New System.Drawing.Size(74, 13)
        Me.lblInfoHeader.TabIndex = 24
        Me.lblInfoHeader.Text = "Additional Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(563, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "watt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(701, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "V"
        '
        'lblWaterDesc
        '
        Me.lblWaterDesc.AutoSize = True
        Me.lblWaterDesc.Location = New System.Drawing.Point(315, 313)
        Me.lblWaterDesc.Name = "lblWaterDesc"
        Me.lblWaterDesc.Size = New System.Drawing.Size(125, 26)
        Me.lblWaterDesc.TabIndex = 28
        Me.lblWaterDesc.Text = "Just water. It's just water." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nothing special." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblWaterPrice
        '
        Me.lblWaterPrice.AutoSize = True
        Me.lblWaterPrice.Location = New System.Drawing.Point(114, 321)
        Me.lblWaterPrice.Name = "lblWaterPrice"
        Me.lblWaterPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblWaterPrice.TabIndex = 26
        Me.lblWaterPrice.Text = "£0.08"
        '
        'lblWater
        '
        Me.lblWater.Location = New System.Drawing.Point(15, 316)
        Me.lblWater.Name = "lblWater"
        Me.lblWater.Size = New System.Drawing.Size(93, 23)
        Me.lblWater.TabIndex = 4
        Me.lblWater.Text = "Water"
        Me.lblWater.UseVisualStyleBackColor = True
        '
        'boxWhippedCream
        '
        Me.boxWhippedCream.AutoSize = True
        Me.boxWhippedCream.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.boxWhippedCream.Location = New System.Drawing.Point(151, 252)
        Me.boxWhippedCream.Name = "boxWhippedCream"
        Me.boxWhippedCream.Size = New System.Drawing.Size(132, 17)
        Me.boxWhippedCream.TabIndex = 2233233
        Me.boxWhippedCream.Text = "Whipped Cream + 20p"
        Me.boxWhippedCream.UseVisualStyleBackColor = True
        '
        'coffeeShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 436)
        Me.Controls.Add(Me.boxWhippedCream)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblWaterDesc)
        Me.Controls.Add(Me.lblWaterPrice)
        Me.Controls.Add(Me.lblWater)
        Me.Controls.Add(Me.lblInfoHeader)
        Me.Controls.Add(lblProdIDHeader)
        Me.Controls.Add(Me.lblDescHeader)
        Me.Controls.Add(Me.lblPriceHeader)
        Me.Controls.Add(Me.txtNameHeader)
        Me.Controls.Add(Me.txtHotChocolateID)
        Me.Controls.Add(Me.txtLatteID)
        Me.Controls.Add(Me.txtCoffeeID)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCoffeeDesc)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblHotChocolatePrice)
        Me.Controls.Add(Me.btnHotChocolate)
        Me.Controls.Add(Me.lblLattePrice)
        Me.Controls.Add(Me.btnLatte)
        Me.Controls.Add(Me.lblCoffeePrice)
        Me.Controls.Add(Me.btnCoffeeOrder)
        Me.Name = "coffeeShop"
        Me.Text = "offical yasir coffe time Woo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCoffeeOrder As Button
    Friend WithEvents lblCoffeePrice As Label
    Friend WithEvents lblLattePrice As Label
    Friend WithEvents btnLatte As Button
    Friend WithEvents lblHotChocolatePrice As Label
    Friend WithEvents btnHotChocolate As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents txtCoffeeDesc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKey As Label
    Friend WithEvents txtHotChocolateID As Label
    Friend WithEvents txtLatteID As Label
    Friend WithEvents txtCoffeeID As Label
    Friend WithEvents txtNameHeader As Label
    Friend WithEvents lblPriceHeader As Label
    Friend WithEvents lblDescHeader As Label
    Friend WithEvents lblInfoHeader As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblWaterDesc As Label
    Friend WithEvents lblWaterPrice As Label
    Friend WithEvents lblWater As Button
    Friend WithEvents boxWhippedCream As CheckBox
End Class
