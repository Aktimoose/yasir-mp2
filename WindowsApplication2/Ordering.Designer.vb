<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordering
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
        Dim imgLogoBG As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordering))
        Me.radSip = New System.Windows.Forms.RadioButton()
        Me.grpCup = New System.Windows.Forms.GroupBox()
        Me.radStraw = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radIcedNo = New System.Windows.Forms.RadioButton()
        Me.radIcedYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkWhippedCream = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblBepis = New System.Windows.Forms.Label()
        imgLogoBG = New System.Windows.Forms.PictureBox()
        Me.grpCup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExtras.SuspendLayout()
        CType(imgLogoBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radSip
        '
        Me.radSip.AutoSize = True
        Me.radSip.Location = New System.Drawing.Point(15, 28)
        Me.radSip.Name = "radSip"
        Me.radSip.Size = New System.Drawing.Size(137, 17)
        Me.radSip.TabIndex = 0
        Me.radSip.TabStop = True
        Me.radSip.Text = "the cup you sip from idk"
        Me.radSip.UseVisualStyleBackColor = True
        '
        'grpCup
        '
        Me.grpCup.BackColor = System.Drawing.Color.Transparent
        Me.grpCup.Controls.Add(Me.radStraw)
        Me.grpCup.Controls.Add(Me.radSip)
        Me.grpCup.Location = New System.Drawing.Point(276, 71)
        Me.grpCup.Name = "grpCup"
        Me.grpCup.Size = New System.Drawing.Size(160, 131)
        Me.grpCup.TabIndex = 2
        Me.grpCup.TabStop = False
        Me.grpCup.Text = "Type of Cup"
        '
        'radStraw
        '
        Me.radStraw.AutoSize = True
        Me.radStraw.Location = New System.Drawing.Point(15, 85)
        Me.radStraw.Name = "radStraw"
        Me.radStraw.Size = New System.Drawing.Size(131, 17)
        Me.radStraw.TabIndex = 1
        Me.radStraw.TabStop = True
        Me.radStraw.Text = "the cup with a straw in"
        Me.radStraw.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radIcedNo)
        Me.GroupBox1.Controls.Add(Me.radIcedYes)
        Me.GroupBox1.Location = New System.Drawing.Point(145, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 131)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iced"
        '
        'radIcedNo
        '
        Me.radIcedNo.AutoSize = True
        Me.radIcedNo.Checked = True
        Me.radIcedNo.Location = New System.Drawing.Point(15, 85)
        Me.radIcedNo.Name = "radIcedNo"
        Me.radIcedNo.Size = New System.Drawing.Size(39, 17)
        Me.radIcedNo.TabIndex = 1
        Me.radIcedNo.TabStop = True
        Me.radIcedNo.Text = "No"
        Me.radIcedNo.UseVisualStyleBackColor = True
        '
        'radIcedYes
        '
        Me.radIcedYes.AutoSize = True
        Me.radIcedYes.Location = New System.Drawing.Point(15, 28)
        Me.radIcedYes.Name = "radIcedYes"
        Me.radIcedYes.Size = New System.Drawing.Size(43, 17)
        Me.radIcedYes.TabIndex = 0
        Me.radIcedYes.TabStop = True
        Me.radIcedYes.Text = "Yes"
        Me.radIcedYes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.numAmount)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 131)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amount"
        '
        'numAmount
        '
        Me.numAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.numAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAmount.Location = New System.Drawing.Point(6, 49)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(113, 30)
        Me.numAmount.TabIndex = 0
        Me.numAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(12, 9)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(446, 46)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "item: big burger in a cup"
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkWhippedCream)
        Me.grpExtras.Location = New System.Drawing.Point(442, 71)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(111, 131)
        Me.grpExtras.TabIndex = 3
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'chkWhippedCream
        '
        Me.chkWhippedCream.AutoSize = True
        Me.chkWhippedCream.Location = New System.Drawing.Point(7, 59)
        Me.chkWhippedCream.Name = "chkWhippedCream"
        Me.chkWhippedCream.Size = New System.Drawing.Size(102, 17)
        Me.chkWhippedCream.TabIndex = 0
        Me.chkWhippedCream.Text = "Whipped Cream"
        Me.chkWhippedCream.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.White
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Orator Std", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(12, 208)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(539, 50)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "o           k"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblBepis
        '
        Me.lblBepis.AutoSize = True
        Me.lblBepis.BackColor = System.Drawing.Color.Transparent
        Me.lblBepis.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBepis.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblBepis.Location = New System.Drawing.Point(933, 99)
        Me.lblBepis.Name = "lblBepis"
        Me.lblBepis.Size = New System.Drawing.Size(317, 663)
        Me.lblBepis.TabIndex = 5
        Me.lblBepis.Text = "you know what i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HATE?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      bepis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE TASTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    the smell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    " &
    "    the texture" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hey...." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           drooling......"
        '
        'imgLogoBG
        '
        imgLogoBG.Cursor = System.Windows.Forms.Cursors.Arrow
        imgLogoBG.Image = CType(resources.GetObject("imgLogoBG.Image"), System.Drawing.Image)
        imgLogoBG.Location = New System.Drawing.Point(1077, 146)
        imgLogoBG.Name = "imgLogoBG"
        imgLogoBG.Size = New System.Drawing.Size(296, 144)
        imgLogoBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        imgLogoBG.TabIndex = 6
        imgLogoBG.TabStop = False
        '
        'Ordering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 273)
        Me.ControlBox = False
        Me.Controls.Add(imgLogoBG)
        Me.Controls.Add(Me.lblBepis)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpCup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ordering"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "beep boop order calculation"
        Me.TopMost = True
        Me.grpCup.ResumeLayout(False)
        Me.grpCup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        CType(imgLogoBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCup As GroupBox
    Friend WithEvents radStraw As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radIcedNo As RadioButton
    Friend WithEvents radIcedYes As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblItem As Label
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents chkWhippedCream As CheckBox
    Friend WithEvents numAmount As NumericUpDown
    Friend WithEvents btnOk As Button
    Friend WithEvents radSip As RadioButton
    Friend WithEvents lblBepis As Label
End Class
