<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.WelcomeLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.Welcome2Button = New MaterialSkin.Controls.MaterialLabel()
        Me.LogoPic = New System.Windows.Forms.PictureBox()
        Me.register_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Depth = 0
        Me.WelcomeLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WelcomeLabel.Location = New System.Drawing.Point(111, 259)
        Me.WelcomeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WelcomeLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(478, 19)
        Me.WelcomeLabel.TabIndex = 7
        Me.WelcomeLabel.Text = "Welcome, please proceed to login next if you already have an account."
        '
        'Welcome2Button
        '
        Me.Welcome2Button.AutoSize = True
        Me.Welcome2Button.Depth = 0
        Me.Welcome2Button.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Welcome2Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Welcome2Button.Location = New System.Drawing.Point(150, 283)
        Me.Welcome2Button.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Welcome2Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Welcome2Button.Name = "Welcome2Button"
        Me.Welcome2Button.Size = New System.Drawing.Size(389, 19)
        Me.Welcome2Button.TabIndex = 7
        Me.Welcome2Button.Text = "Please register for a new account if you do not have one."
        '
        'LogoPic
        '
        Me.LogoPic.Location = New System.Drawing.Point(222, 109)
        Me.LogoPic.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoPic.Name = "LogoPic"
        Me.LogoPic.Size = New System.Drawing.Size(201, 130)
        Me.LogoPic.TabIndex = 10
        Me.LogoPic.TabStop = False
        '
        'register_btn
        '
        Me.register_btn.Depth = 0
        Me.register_btn.Location = New System.Drawing.Point(272, 309)
        Me.register_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.register_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.register_btn.Name = "register_btn"
        Me.register_btn.Primary = True
        Me.register_btn.Size = New System.Drawing.Size(100, 28)
        Me.register_btn.TabIndex = 8
        Me.register_btn.Text = "Register"
        Me.register_btn.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 399)
        Me.Controls.Add(Me.LogoPic)
        Me.Controls.Add(Me.register_btn)
        Me.Controls.Add(Me.Welcome2Button)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Welcome2Button As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LogoPic As System.Windows.Forms.PictureBox
    Friend WithEvents register_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
