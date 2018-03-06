<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.login_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.exit_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.IDLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.PasswordLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.password_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LogoPic = New System.Windows.Forms.PictureBox()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.username_CB = New System.Windows.Forms.ComboBox()
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_btn.Depth = 0
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Location = New System.Drawing.Point(504, 644)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.login_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Primary = True
        Me.login_btn.Size = New System.Drawing.Size(200, 54)
        Me.login_btn.TabIndex = 1
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exit_btn.Depth = 0
        Me.exit_btn.Location = New System.Drawing.Point(706, 644)
        Me.exit_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exit_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Primary = True
        Me.exit_btn.Size = New System.Drawing.Size(200, 54)
        Me.exit_btn.TabIndex = 1
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'IDLabel
        '
        Me.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Depth = 0
        Me.IDLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.IDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IDLabel.Location = New System.Drawing.Point(360, 444)
        Me.IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(148, 34)
        Me.IDLabel.TabIndex = 2
        Me.IDLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Depth = 0
        Me.PasswordLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PasswordLabel.Location = New System.Drawing.Point(360, 554)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(145, 34)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Password:"
        '
        'password_txt
        '
        Me.password_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_txt.Depth = 0
        Me.password_txt.Hint = ""
        Me.password_txt.Location = New System.Drawing.Point(532, 554)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.password_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.SelectedText = ""
        Me.password_txt.SelectionLength = 0
        Me.password_txt.SelectionStart = 0
        Me.password_txt.Size = New System.Drawing.Size(358, 39)
        Me.password_txt.TabIndex = 3
        Me.password_txt.UseSystemPasswordChar = False
        '
        'LogoPic
        '
        Me.LogoPic.BackColor = System.Drawing.Color.Transparent
        Me.LogoPic.Image = CType(resources.GetObject("LogoPic.Image"), System.Drawing.Image)
        Me.LogoPic.Location = New System.Drawing.Point(532, 144)
        Me.LogoPic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogoPic.Name = "LogoPic"
        Me.LogoPic.Size = New System.Drawing.Size(286, 292)
        Me.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPic.TabIndex = 4
        Me.LogoPic.TabStop = False
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
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
        Me.currentTime_lbl.TabIndex = 30
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
        Me.currentDate_lbl.TabIndex = 29
        Me.currentDate_lbl.Text = "Date"
        '
        'username_CB
        '
        Me.username_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.username_CB.FormattingEnabled = True
        Me.username_CB.Location = New System.Drawing.Point(532, 444)
        Me.username_CB.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.username_CB.Name = "username_CB"
        Me.username_CB.Size = New System.Drawing.Size(354, 33)
        Me.username_CB.TabIndex = 31
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 767)
        Me.Controls.Add(Me.username_CB)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.LogoPic)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel System Management"
        CType(Me.LogoPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents exit_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents IDLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PasswordLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents password_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents LogoPic As System.Windows.Forms.PictureBox
    Friend WithEvents username_CB As System.Windows.Forms.ComboBox

End Class
