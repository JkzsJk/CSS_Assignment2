<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRegister
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
        Me.SuspendLayout()
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(6, 71)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(462, 19)
        Me.SelectLabel.TabIndex = 1
        Me.SelectLabel.Text = "Please select the position you wish the account to be registered as."
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Depth = 0
        Me.username_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.username_lbl.Location = New System.Drawing.Point(6, 143)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.username_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(81, 19)
        Me.username_lbl.TabIndex = 1
        Me.username_lbl.Text = "Username:"
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Depth = 0
        Me.password_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.password_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password_lbl.Location = New System.Drawing.Point(6, 183)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.password_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(79, 19)
        Me.password_lbl.TabIndex = 1
        Me.password_lbl.Text = "Password:"
        '
        'username_txt
        '
        Me.username_txt.Depth = 0
        Me.username_txt.Hint = ""
        Me.username_txt.Location = New System.Drawing.Point(109, 143)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.username_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_txt.Name = "username_txt"
        Me.username_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_txt.SelectedText = ""
        Me.username_txt.SelectionLength = 0
        Me.username_txt.SelectionStart = 0
        Me.username_txt.Size = New System.Drawing.Size(497, 23)
        Me.username_txt.TabIndex = 2
        Me.username_txt.UseSystemPasswordChar = False
        '
        'password_txt
        '
        Me.password_txt.Depth = 0
        Me.password_txt.Hint = ""
        Me.password_txt.Location = New System.Drawing.Point(109, 183)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.password_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.SelectedText = ""
        Me.password_txt.SelectionLength = 0
        Me.password_txt.SelectionStart = 0
        Me.password_txt.Size = New System.Drawing.Size(497, 23)
        Me.password_txt.TabIndex = 2
        Me.password_txt.UseSystemPasswordChar = False
        '
        'AddARButton
        '
        Me.AddARButton.Depth = 0
        Me.AddARButton.Location = New System.Drawing.Point(10, 229)
        Me.AddARButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddARButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddARButton.Name = "AddARButton"
        Me.AddARButton.Primary = True
        Me.AddARButton.Size = New System.Drawing.Size(96, 24)
        Me.AddARButton.TabIndex = 5
        Me.AddARButton.Text = "Add"
        Me.AddARButton.UseVisualStyleBackColor = True
        '
        'CloseRegisterARButton
        '
        Me.CloseRegisterARButton.Depth = 0
        Me.CloseRegisterARButton.Location = New System.Drawing.Point(110, 229)
        Me.CloseRegisterARButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseRegisterARButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CloseRegisterARButton.Name = "CloseRegisterARButton"
        Me.CloseRegisterARButton.Primary = True
        Me.CloseRegisterARButton.Size = New System.Drawing.Size(96, 24)
        Me.CloseRegisterARButton.TabIndex = 5
        Me.CloseRegisterARButton.Text = "Close"
        Me.CloseRegisterARButton.UseVisualStyleBackColor = True
        '
        'position_CB
        '
        Me.position_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.position_CB.FormattingEnabled = True
        Me.position_CB.Items.AddRange(New Object() {"Admin", "Reservation Management", "Front Desk Management", "Room & Facilities Management"})
        Me.position_CB.Location = New System.Drawing.Point(109, 106)
        Me.position_CB.Name = "position_CB"
        Me.position_CB.Size = New System.Drawing.Size(174, 21)
        Me.position_CB.TabIndex = 6
        '
        'position_lbl
        '
        Me.position_lbl.AutoSize = True
        Me.position_lbl.Depth = 0
        Me.position_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.position_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.position_lbl.Location = New System.Drawing.Point(6, 105)
        Me.position_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.position_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.position_lbl.Name = "position_lbl"
        Me.position_lbl.Size = New System.Drawing.Size(69, 19)
        Me.position_lbl.TabIndex = 7
        Me.position_lbl.Text = "Position:"
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentTime_lbl.ForeColor = System.Drawing.Color.White
        Me.currentTime_lbl.Location = New System.Drawing.Point(601, 37)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentTime_lbl.TabIndex = 32
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentDate_lbl.ForeColor = System.Drawing.Color.White
        Me.currentDate_lbl.Location = New System.Drawing.Point(537, 37)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentDate_lbl.TabIndex = 31
        Me.currentDate_lbl.Text = "Date"
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
        '
        'AdminRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 279)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.position_lbl)
        Me.Controls.Add(Me.position_CB)
        Me.Controls.Add(Me.CloseRegisterARButton)
        Me.Controls.Add(Me.AddARButton)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.SelectLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AdminRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Registration"
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
End Class
