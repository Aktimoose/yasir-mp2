<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class theEnd
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
        Me.lblTheEnd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTheEnd
        '
        Me.lblTheEnd.AutoSize = True
        Me.lblTheEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTheEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheEnd.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTheEnd.Location = New System.Drawing.Point(586, 306)
        Me.lblTheEnd.Name = "lblTheEnd"
        Me.lblTheEnd.Size = New System.Drawing.Size(147, 76)
        Me.lblTheEnd.TabIndex = 0
        Me.lblTheEnd.Text = "end"
        '
        'theEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1308, 656)
        Me.Controls.Add(Me.lblTheEnd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "theEnd"
        Me.Opacity = 0.1R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTheEnd As Label
End Class
