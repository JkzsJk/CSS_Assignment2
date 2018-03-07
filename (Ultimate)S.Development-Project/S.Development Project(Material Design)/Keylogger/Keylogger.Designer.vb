<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keylogger
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.Back_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'Back_btn
        '
        Me.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Back_btn.Depth = 0
        Me.Back_btn.Location = New System.Drawing.Point(22, 848)
        Me.Back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Primary = True
        Me.Back_btn.Size = New System.Drawing.Size(141, 56)
        Me.Back_btn.TabIndex = 37
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = True
        '
        'Keylogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 934)
        Me.Controls.Add(Me.Back_btn)
        Me.Name = "Keylogger"
        Me.Text = "Keylogger"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
