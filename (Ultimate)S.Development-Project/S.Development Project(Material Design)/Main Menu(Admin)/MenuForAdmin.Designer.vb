<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForAdmin
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
        Me.RegisterAccMMButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RFMMMButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ReservationMMMButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FDMMMButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.logOut_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.DeleteAcc_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.editAcc_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FileHashingBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FolderLockBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.WebsiteBlocker_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Keylogger_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'RegisterAccMMButton
        '
        Me.RegisterAccMMButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegisterAccMMButton.Depth = 0
        Me.RegisterAccMMButton.Location = New System.Drawing.Point(112, 163)
        Me.RegisterAccMMButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RegisterAccMMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.RegisterAccMMButton.Name = "RegisterAccMMButton"
        Me.RegisterAccMMButton.Primary = True
        Me.RegisterAccMMButton.Size = New System.Drawing.Size(544, 56)
        Me.RegisterAccMMButton.TabIndex = 0
        Me.RegisterAccMMButton.Text = "Register An Account"
        Me.RegisterAccMMButton.UseVisualStyleBackColor = True
        '
        'RFMMMButton
        '
        Me.RFMMMButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RFMMMButton.Depth = 0
        Me.RFMMMButton.Location = New System.Drawing.Point(112, 394)
        Me.RFMMMButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RFMMMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFMMMButton.Name = "RFMMMButton"
        Me.RFMMMButton.Primary = True
        Me.RFMMMButton.Size = New System.Drawing.Size(544, 56)
        Me.RFMMMButton.TabIndex = 0
        Me.RFMMMButton.Text = "Rooms & Facilities Management"
        Me.RFMMMButton.UseVisualStyleBackColor = True
        '
        'ReservationMMMButton
        '
        Me.ReservationMMMButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReservationMMMButton.Depth = 0
        Me.ReservationMMMButton.Location = New System.Drawing.Point(112, 467)
        Me.ReservationMMMButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationMMMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReservationMMMButton.Name = "ReservationMMMButton"
        Me.ReservationMMMButton.Primary = True
        Me.ReservationMMMButton.Size = New System.Drawing.Size(544, 56)
        Me.ReservationMMMButton.TabIndex = 0
        Me.ReservationMMMButton.Text = "Reservation Management"
        Me.ReservationMMMButton.UseVisualStyleBackColor = True
        '
        'FDMMMButton
        '
        Me.FDMMMButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FDMMMButton.Depth = 0
        Me.FDMMMButton.Location = New System.Drawing.Point(112, 546)
        Me.FDMMMButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FDMMMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.FDMMMButton.Name = "FDMMMButton"
        Me.FDMMMButton.Primary = True
        Me.FDMMMButton.Size = New System.Drawing.Size(544, 56)
        Me.FDMMMButton.TabIndex = 0
        Me.FDMMMButton.Text = "Front Desk Management"
        Me.FDMMMButton.UseVisualStyleBackColor = True
        '
        'logOut_btn
        '
        Me.logOut_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logOut_btn.Depth = 0
        Me.logOut_btn.Location = New System.Drawing.Point(112, 623)
        Me.logOut_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.logOut_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.logOut_btn.Name = "logOut_btn"
        Me.logOut_btn.Primary = True
        Me.logOut_btn.Size = New System.Drawing.Size(544, 56)
        Me.logOut_btn.TabIndex = 1
        Me.logOut_btn.Text = "Log out"
        Me.logOut_btn.UseVisualStyleBackColor = True
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
        'DeleteAcc_btn
        '
        Me.DeleteAcc_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeleteAcc_btn.Depth = 0
        Me.DeleteAcc_btn.Location = New System.Drawing.Point(112, 317)
        Me.DeleteAcc_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteAcc_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DeleteAcc_btn.Name = "DeleteAcc_btn"
        Me.DeleteAcc_btn.Primary = True
        Me.DeleteAcc_btn.Size = New System.Drawing.Size(544, 56)
        Me.DeleteAcc_btn.TabIndex = 33
        Me.DeleteAcc_btn.Text = "Delete Account"
        Me.DeleteAcc_btn.UseVisualStyleBackColor = True
        '
        'editAcc_btn
        '
        Me.editAcc_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.editAcc_btn.Depth = 0
        Me.editAcc_btn.Location = New System.Drawing.Point(112, 240)
        Me.editAcc_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.editAcc_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.editAcc_btn.Name = "editAcc_btn"
        Me.editAcc_btn.Primary = True
        Me.editAcc_btn.Size = New System.Drawing.Size(544, 56)
        Me.editAcc_btn.TabIndex = 34
        Me.editAcc_btn.Text = "Edit Account"
        Me.editAcc_btn.UseVisualStyleBackColor = True
        '
        'FileHashingBtn
        '
        Me.FileHashingBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FileHashingBtn.Depth = 0
        Me.FileHashingBtn.Location = New System.Drawing.Point(715, 163)
        Me.FileHashingBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.FileHashingBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.FileHashingBtn.Name = "FileHashingBtn"
        Me.FileHashingBtn.Primary = True
        Me.FileHashingBtn.Size = New System.Drawing.Size(544, 56)
        Me.FileHashingBtn.TabIndex = 0
        Me.FileHashingBtn.Text = "File Hashing"
        Me.FileHashingBtn.UseVisualStyleBackColor = True
        '
        'FolderLockBtn
        '
        Me.FolderLockBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FolderLockBtn.Depth = 0
        Me.FolderLockBtn.Location = New System.Drawing.Point(715, 240)
        Me.FolderLockBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.FolderLockBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.FolderLockBtn.Name = "FolderLockBtn"
        Me.FolderLockBtn.Primary = True
        Me.FolderLockBtn.Size = New System.Drawing.Size(544, 56)
        Me.FolderLockBtn.TabIndex = 35
        Me.FolderLockBtn.Text = "Folder Lock"
        Me.FolderLockBtn.UseVisualStyleBackColor = True
        '
        'WebsiteBlocker_btn
        '
        Me.WebsiteBlocker_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WebsiteBlocker_btn.Depth = 0
        Me.WebsiteBlocker_btn.Location = New System.Drawing.Point(715, 317)
        Me.WebsiteBlocker_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.WebsiteBlocker_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.WebsiteBlocker_btn.Name = "WebsiteBlocker_btn"
        Me.WebsiteBlocker_btn.Primary = True
        Me.WebsiteBlocker_btn.Size = New System.Drawing.Size(544, 56)
        Me.WebsiteBlocker_btn.TabIndex = 35
        Me.WebsiteBlocker_btn.Text = "Website Blocker"
        Me.WebsiteBlocker_btn.UseVisualStyleBackColor = True
        '
        'Keylogger_btn
        '
        Me.Keylogger_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Keylogger_btn.Depth = 0
        Me.Keylogger_btn.Location = New System.Drawing.Point(715, 394)
        Me.Keylogger_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Keylogger_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Keylogger_btn.Name = "Keylogger_btn"
        Me.Keylogger_btn.Primary = True
        Me.Keylogger_btn.Size = New System.Drawing.Size(544, 56)
        Me.Keylogger_btn.TabIndex = 36
        Me.Keylogger_btn.Text = "Keylogger"
        Me.Keylogger_btn.UseVisualStyleBackColor = True
        '
        'MenuForAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 767)
        Me.Controls.Add(Me.Keylogger_btn)
        Me.Controls.Add(Me.WebsiteBlocker_btn)
        Me.Controls.Add(Me.FolderLockBtn)
        Me.Controls.Add(Me.editAcc_btn)
        Me.Controls.Add(Me.DeleteAcc_btn)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.logOut_btn)
        Me.Controls.Add(Me.FileHashingBtn)
        Me.Controls.Add(Me.FDMMMButton)
        Me.Controls.Add(Me.ReservationMMMButton)
        Me.Controls.Add(Me.RFMMMButton)
        Me.Controls.Add(Me.RegisterAccMMButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MenuForAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisterAccMMButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents RFMMMButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ReservationMMMButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FDMMMButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents logOut_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents DeleteAcc_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents editAcc_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FileHashingBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FolderLockBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents WebsiteBlocker_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Keylogger_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
