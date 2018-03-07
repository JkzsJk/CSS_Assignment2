<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetriveAccountCredentials
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
        Me.back_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnSendAC = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.password_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Username_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.txtEmail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Email_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.lblVerified = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Depth = 0
        Me.back_btn.Location = New System.Drawing.Point(32, 624)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Primary = True
        Me.back_btn.Size = New System.Drawing.Size(192, 46)
        Me.back_btn.TabIndex = 40
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'btnSendAC
        '
        Me.btnSendAC.Depth = 0
        Me.btnSendAC.Location = New System.Drawing.Point(255, 624)
        Me.btnSendAC.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSendAC.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSendAC.Name = "btnSendAC"
        Me.btnSendAC.Primary = True
        Me.btnSendAC.Size = New System.Drawing.Size(192, 46)
        Me.btnSendAC.TabIndex = 42
        Me.btnSendAC.Text = "Send"
        Me.btnSendAC.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = ""
        Me.txtPassword.Location = New System.Drawing.Point(361, 387)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(1061, 39)
        Me.txtPassword.TabIndex = 37
        Me.txtPassword.UseSystemPasswordChar = False
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = ""
        Me.txtUsername.Location = New System.Drawing.Point(361, 310)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(1061, 39)
        Me.txtUsername.TabIndex = 38
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Depth = 0
        Me.password_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.password_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password_lbl.Location = New System.Drawing.Point(26, 387)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(145, 34)
        Me.password_lbl.TabIndex = 35
        Me.password_lbl.Text = "Password:"
        '
        'Username_lbl
        '
        Me.Username_lbl.AutoSize = True
        Me.Username_lbl.Depth = 0
        Me.Username_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Username_lbl.Location = New System.Drawing.Point(26, 310)
        Me.Username_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Username_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Username_lbl.Name = "Username_lbl"
        Me.Username_lbl.Size = New System.Drawing.Size(148, 34)
        Me.Username_lbl.TabIndex = 36
        Me.Username_lbl.Text = "Username:"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(26, 224)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(607, 34)
        Me.SelectLabel.TabIndex = 39
        Me.SelectLabel.Text = "Please select the file(s) which you wish to hash."
        '
        'txtEmail
        '
        Me.txtEmail.Depth = 0
        Me.txtEmail.Hint = ""
        Me.txtEmail.Location = New System.Drawing.Point(361, 467)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.Size = New System.Drawing.Size(1061, 39)
        Me.txtEmail.TabIndex = 44
        Me.txtEmail.UseSystemPasswordChar = False
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Depth = 0
        Me.Email_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Email_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Email_lbl.Location = New System.Drawing.Point(26, 467)
        Me.Email_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Email_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(209, 34)
        Me.Email_lbl.TabIndex = 43
        Me.Email_lbl.Text = "E-mail Address:"
        '
        'lblVerified
        '
        Me.lblVerified.AutoSize = True
        Me.lblVerified.Depth = 0
        Me.lblVerified.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblVerified.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVerified.Location = New System.Drawing.Point(617, 542)
        Me.lblVerified.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVerified.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblVerified.Name = "lblVerified"
        Me.lblVerified.Size = New System.Drawing.Size(192, 34)
        Me.lblVerified.TabIndex = 45
        Me.lblVerified.Text = "E-mail Validity"
        '
        'RetriveAccountCredentials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 704)
        Me.Controls.Add(Me.lblVerified)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Email_lbl)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.btnSendAC)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.Username_lbl)
        Me.Controls.Add(Me.SelectLabel)
        Me.Name = "RetriveAccountCredentials"
        Me.Text = "RetriveAccountCredentials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnSendAC As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents password_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Username_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtEmail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Email_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblVerified As MaterialSkin.Controls.MaterialLabel
End Class
