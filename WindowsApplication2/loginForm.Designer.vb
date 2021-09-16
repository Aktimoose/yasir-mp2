<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class loginForm
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
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.imgLogoBG = New System.Windows.Forms.PictureBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbHonorific = New System.Windows.Forms.ComboBox()
        Me.imgLogoText = New System.Windows.Forms.PictureBox()
        Me.cmbDayOfBirth = New System.Windows.Forms.ComboBox()
        Me.cmbMonthOfBirth = New System.Windows.Forms.ComboBox()
        CType(Me.imgLogoBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogoBG
        '
        Me.imgLogoBG.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.imgLogoBG.Image = CType(resources.GetObject("imgLogoBG.Image"), System.Drawing.Image)
        Me.imgLogoBG.Location = New System.Drawing.Point(0, -1)
        Me.imgLogoBG.Name = "imgLogoBG"
        Me.imgLogoBG.Size = New System.Drawing.Size(218, 372)
        Me.imgLogoBG.TabIndex = 0
        Me.imgLogoBG.TabStop = False
        '
        'lblForename
        '
        Me.lblForename.Location = New System.Drawing.Point(221, 67)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(220, 23)
        Me.lblForename.TabIndex = 0
        Me.lblForename.Text = "&Forename"
        Me.lblForename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSurname
        '
        Me.lblSurname.Location = New System.Drawing.Point(221, 124)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(220, 23)
        Me.lblSurname.TabIndex = 2
        Me.lblSurname.Text = "&Surname"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtForename
        '
        Me.txtForename.AcceptsTab = True
        Me.txtForename.Location = New System.Drawing.Point(223, 87)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(220, 20)
        Me.txtForename.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.AcceptsTab = True
        Me.txtSurname.Location = New System.Drawing.Point(223, 144)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(220, 20)
        Me.txtSurname.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(246, 318)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 6
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(349, 318)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "&Cancel"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(221, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Month of Birth"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(220, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Day of Birth"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(223, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Honorific"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbHonorific
        '
        Me.cmbHonorific.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHonorific.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbHonorific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHonorific.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbHonorific.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbHonorific.FormattingEnabled = True
        Me.cmbHonorific.Items.AddRange(New Object() {"Mr.", "Miss.", "Mrs.", "Mx.", "Dr."})
        Me.cmbHonorific.Location = New System.Drawing.Point(223, 35)
        Me.cmbHonorific.Name = "cmbHonorific"
        Me.cmbHonorific.Size = New System.Drawing.Size(220, 21)
        Me.cmbHonorific.TabIndex = 1
        '
        'imgLogoText
        '
        Me.imgLogoText.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.imgLogoText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imgLogoText.Image = CType(resources.GetObject("imgLogoText.Image"), System.Drawing.Image)
        Me.imgLogoText.Location = New System.Drawing.Point(0, 257)
        Me.imgLogoText.Name = "imgLogoText"
        Me.imgLogoText.Size = New System.Drawing.Size(217, 77)
        Me.imgLogoText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogoText.TabIndex = 11
        Me.imgLogoText.TabStop = False
        '
        'cmbDayOfBirth
        '
        Me.cmbDayOfBirth.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDayOfBirth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbDayOfBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDayOfBirth.Enabled = False
        Me.cmbDayOfBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDayOfBirth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDayOfBirth.FormattingEnabled = True
        Me.cmbDayOfBirth.IntegralHeight = False
        Me.cmbDayOfBirth.Items.AddRange(New Object() {"1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "3", "30", "31", "4", "5", "6", "7", "8", "9"})
        Me.cmbDayOfBirth.Location = New System.Drawing.Point(223, 274)
        Me.cmbDayOfBirth.Name = "cmbDayOfBirth"
        Me.cmbDayOfBirth.Size = New System.Drawing.Size(220, 21)
        Me.cmbDayOfBirth.TabIndex = 5
        '
        'cmbMonthOfBirth
        '
        Me.cmbMonthOfBirth.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMonthOfBirth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMonthOfBirth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonthOfBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonthOfBirth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMonthOfBirth.FormattingEnabled = True
        Me.cmbMonthOfBirth.IntegralHeight = False
        Me.cmbMonthOfBirth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonthOfBirth.Location = New System.Drawing.Point(223, 208)
        Me.cmbMonthOfBirth.Name = "cmbMonthOfBirth"
        Me.cmbMonthOfBirth.Size = New System.Drawing.Size(220, 21)
        Me.cmbMonthOfBirth.TabIndex = 4
        '
        'loginForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(449, 368)
        Me.Controls.Add(Me.cmbMonthOfBirth)
        Me.Controls.Add(Me.cmbDayOfBirth)
        Me.Controls.Add(Me.imgLogoText)
        Me.Controls.Add(Me.cmbHonorific)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.imgLogoBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login Form"
        CType(Me.imgLogoBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbHonorific As ComboBox
    Friend WithEvents imgLogoText As PictureBox
    Friend WithEvents imgLogoBG As PictureBox
    Friend WithEvents cmbDayOfBirth As ComboBox
    Friend WithEvents cmbMonthOfBirth As ComboBox
End Class
