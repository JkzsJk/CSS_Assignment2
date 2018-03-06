<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminRegister
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.username_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.password_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.username_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.password_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.AddARButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.CloseRegisterARButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.position_CB = New System.Windows.Forms.ComboBox()
        Me.position_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.pbStrength = New System.Windows.Forms.ProgressBar()
        Me.pwStrengthlbl = New MaterialSkin.Controls.MaterialLabel()
        Me.CaptchaBox1 = New S.Development_Project_Material_Design_.CaptchaBox()
        Me.CaptchaLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.CaptchaTxt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RefreshCBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.CaptchaBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(12, 137)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(847, 34)
        Me.SelectLabel.TabIndex = 1
        Me.SelectLabel.Text = "Please select the position you wish the account to be registered as."
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Depth = 0
        Me.username_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.username_lbl.Location = New System.Drawing.Point(12, 275)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.username_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(148, 34)
        Me.username_lbl.TabIndex = 1
        Me.username_lbl.Text = "Username:"
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Depth = 0
        Me.password_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.password_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password_lbl.Location = New System.Drawing.Point(12, 352)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(145, 34)
        Me.password_lbl.TabIndex = 1
        Me.password_lbl.Text = "Password:"
        '
        'username_txt
        '
        Me.username_txt.Depth = 0
        Me.username_txt.Hint = ""
        Me.username_txt.Location = New System.Drawing.Point(218, 275)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.username_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_txt.Name = "username_txt"
        Me.username_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_txt.SelectedText = ""
        Me.username_txt.SelectionLength = 0
        Me.username_txt.SelectionStart = 0
        Me.username_txt.Size = New System.Drawing.Size(994, 39)
        Me.username_txt.TabIndex = 2
        Me.username_txt.UseSystemPasswordChar = False
        '
        'password_txt
        '
        Me.password_txt.Depth = 0
        Me.password_txt.Hint = ""
        Me.password_txt.Location = New System.Drawing.Point(218, 352)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.password_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.SelectedText = ""
        Me.password_txt.SelectionLength = 0
        Me.password_txt.SelectionStart = 0
        Me.password_txt.Size = New System.Drawing.Size(994, 39)
        Me.password_txt.TabIndex = 2
        Me.password_txt.UseSystemPasswordChar = False
        '
        'AddARButton
        '
        Me.AddARButton.Depth = 0
        Me.AddARButton.Location = New System.Drawing.Point(37, 793)
        Me.AddARButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddARButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddARButton.Name = "AddARButton"
        Me.AddARButton.Primary = True
        Me.AddARButton.Size = New System.Drawing.Size(192, 46)
        Me.AddARButton.TabIndex = 5
        Me.AddARButton.Text = "Add"
        Me.AddARButton.UseVisualStyleBackColor = True
        '
        'CloseRegisterARButton
        '
        Me.CloseRegisterARButton.Depth = 0
        Me.CloseRegisterARButton.Location = New System.Drawing.Point(237, 793)
        Me.CloseRegisterARButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseRegisterARButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CloseRegisterARButton.Name = "CloseRegisterARButton"
        Me.CloseRegisterARButton.Primary = True
        Me.CloseRegisterARButton.Size = New System.Drawing.Size(192, 46)
        Me.CloseRegisterARButton.TabIndex = 5
        Me.CloseRegisterARButton.Text = "Close"
        Me.CloseRegisterARButton.UseVisualStyleBackColor = True
        '
        'position_CB
        '
        Me.position_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.position_CB.FormattingEnabled = True
        Me.position_CB.Items.AddRange(New Object() {"Admin", "Reservation Management", "Front Desk Management", "Room & Facilities Management"})
        Me.position_CB.Location = New System.Drawing.Point(218, 204)
        Me.position_CB.Margin = New System.Windows.Forms.Padding(6)
        Me.position_CB.Name = "position_CB"
        Me.position_CB.Size = New System.Drawing.Size(344, 33)
        Me.position_CB.TabIndex = 6
        '
        'position_lbl
        '
        Me.position_lbl.AutoSize = True
        Me.position_lbl.Depth = 0
        Me.position_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.position_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.position_lbl.Location = New System.Drawing.Point(12, 202)
        Me.position_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.position_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.position_lbl.Name = "position_lbl"
        Me.position_lbl.Size = New System.Drawing.Size(124, 34)
        Me.position_lbl.TabIndex = 7
        Me.position_lbl.Text = "Position:"
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentTime_lbl.ForeColor = System.Drawing.Color.White
        Me.currentTime_lbl.Location = New System.Drawing.Point(1202, 71)
        Me.currentTime_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(59, 25)
        Me.currentTime_lbl.TabIndex = 32
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentDate_lbl.ForeColor = System.Drawing.Color.White
        Me.currentDate_lbl.Location = New System.Drawing.Point(1074, 71)
        Me.currentDate_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(57, 25)
        Me.currentDate_lbl.TabIndex = 31
        Me.currentDate_lbl.Text = "Date"
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 435)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(257, 34)
        Me.MaterialLabel1.TabIndex = 35
        Me.MaterialLabel1.Text = "Password Strength:"
        '
        'pbStrength
        '
        Me.pbStrength.Location = New System.Drawing.Point(1026, 435)
        Me.pbStrength.Margin = New System.Windows.Forms.Padding(6)
        Me.pbStrength.Name = "pbStrength"
        Me.pbStrength.Size = New System.Drawing.Size(268, 44)
        Me.pbStrength.TabIndex = 36
        Me.pbStrength.Visible = False
        '
        'pwStrengthlbl
        '
        Me.pwStrengthlbl.AutoSize = True
        Me.pwStrengthlbl.Depth = 0
        Me.pwStrengthlbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.pwStrengthlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pwStrengthlbl.Location = New System.Drawing.Point(316, 435)
        Me.pwStrengthlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pwStrengthlbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.pwStrengthlbl.Name = "pwStrengthlbl"
        Me.pwStrengthlbl.Size = New System.Drawing.Size(243, 34)
        Me.pwStrengthlbl.TabIndex = 35
        Me.pwStrengthlbl.Text = "PasswordStrength"
        '
        'CaptchaBox1
        '
        Me.CaptchaBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CaptchaBox1.CaptchaTextLength = 8
        Me.CaptchaBox1.Location = New System.Drawing.Point(229, 521)
        Me.CaptchaBox1.Name = "CaptchaBox1"
        Me.CaptchaBox1.NumberOfLines = 50
        Me.CaptchaBox1.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz!#$%^&*()1234567890"
        Me.CaptchaBox1.Size = New System.Drawing.Size(436, 120)
        Me.CaptchaBox1.TabIndex = 37
        Me.CaptchaBox1.TabStop = False
        Me.CaptchaBox1.TextColor = System.Drawing.Color.Black
        '
        'CaptchaLbl
        '
        Me.CaptchaLbl.AutoSize = True
        Me.CaptchaLbl.Depth = 0
        Me.CaptchaLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CaptchaLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CaptchaLbl.Location = New System.Drawing.Point(12, 661)
        Me.CaptchaLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CaptchaLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.CaptchaLbl.Name = "CaptchaLbl"
        Me.CaptchaLbl.Size = New System.Drawing.Size(125, 34)
        Me.CaptchaLbl.TabIndex = 1
        Me.CaptchaLbl.Text = "Captcha:"
        '
        'CaptchaTxt
        '
        Me.CaptchaTxt.Depth = 0
        Me.CaptchaTxt.Hint = ""
        Me.CaptchaTxt.Location = New System.Drawing.Point(218, 661)
        Me.CaptchaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CaptchaTxt.MouseState = MaterialSkin.MouseState.HOVER
        Me.CaptchaTxt.Name = "CaptchaTxt"
        Me.CaptchaTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CaptchaTxt.SelectedText = ""
        Me.CaptchaTxt.SelectionLength = 0
        Me.CaptchaTxt.SelectionStart = 0
        Me.CaptchaTxt.Size = New System.Drawing.Size(994, 39)
        Me.CaptchaTxt.TabIndex = 2
        Me.CaptchaTxt.UseSystemPasswordChar = False
        '
        'RefreshCBtn
        '
        Me.RefreshCBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.RefreshCBtn.Depth = 0
        Me.RefreshCBtn.Location = New System.Drawing.Point(38, 739)
        Me.RefreshCBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshCBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.RefreshCBtn.Name = "RefreshCBtn"
        Me.RefreshCBtn.Primary = True
        Me.RefreshCBtn.Size = New System.Drawing.Size(293, 46)
        Me.RefreshCBtn.TabIndex = 5
        Me.RefreshCBtn.Text = "Refresh Captcha"
        Me.RefreshCBtn.UseVisualStyleBackColor = True
        '
        'AdminRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 904)
        Me.Controls.Add(Me.CaptchaBox1)
        Me.Controls.Add(Me.pbStrength)
        Me.Controls.Add(Me.pwStrengthlbl)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.position_lbl)
        Me.Controls.Add(Me.position_CB)
        Me.Controls.Add(Me.CloseRegisterARButton)
        Me.Controls.Add(Me.RefreshCBtn)
        Me.Controls.Add(Me.AddARButton)
        Me.Controls.Add(Me.CaptchaTxt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.CaptchaLbl)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.SelectLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AdminRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Registration"
        CType(Me.CaptchaBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents username_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents password_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents username_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents password_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents AddARButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents CloseRegisterARButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents position_CB As System.Windows.Forms.ComboBox
    Friend WithEvents position_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents lblProgressBar As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pbStrength As ProgressBar
    Friend WithEvents pwStrengthlbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CaptchaBox1 As CaptchaBox
    Friend WithEvents CaptchaLbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CaptchaTxt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RefreshCBtn As MaterialSkin.Controls.MaterialRaisedButton
End Class
