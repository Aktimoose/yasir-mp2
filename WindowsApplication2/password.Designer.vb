<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(password))
        Me.lblPasswordTitle = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.imgEye = New System.Windows.Forms.PictureBox()
        Me.btnEasy = New System.Windows.Forms.Button()
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPasswordTitle
        '
        Me.lblPasswordTitle.AutoSize = True
        Me.lblPasswordTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblPasswordTitle.Name = "lblPasswordTitle"
        Me.lblPasswordTitle.Size = New System.Drawing.Size(545, 76)
        Me.lblPasswordTitle.TabIndex = 0
        Me.lblPasswordTitle.Text = "enter password ::"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(12, 106)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(508, 38)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Plakette 4 SF", 75.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(74, 150)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(202, 136)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'imgEye
        '
        Me.imgEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgEye.Image = CType(resources.GetObject("imgEye.Image"), System.Drawing.Image)
        Me.imgEye.Location = New System.Drawing.Point(422, 106)
        Me.imgEye.Name = "imgEye"
        Me.imgEye.Size = New System.Drawing.Size(64, 49)
        Me.imgEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEye.TabIndex = 3
        Me.imgEye.TabStop = False
        '
        'btnEasy
        '
        Me.btnEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEasy.Location = New System.Drawing.Point(587, 23)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(45, 52)
        Me.btnEasy.TabIndex = 4
        Me.btnEasy.Text = "dev debug button"
        Me.btnEasy.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 341)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.imgEye)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPasswordTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "welcome to google chrome"
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPasswordTitle As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents imgEye As PictureBox
    Friend WithEvents btnEasy As Button
End Class
