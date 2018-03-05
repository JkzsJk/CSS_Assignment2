<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstRegister
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
        Me.close_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.accept_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.password_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Username_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.password_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.username_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.pbStrength = New System.Windows.Forms.ProgressBar()
        Me.PStrengthMaterialLbl = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(220, 524)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = True
        Me.close_btn.Size = New System.Drawing.Size(192, 46)
        Me.close_btn.TabIndex = 16
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'accept_btn
        '
        Me.accept_btn.Depth = 0
        Me.accept_btn.Location = New System.Drawing.Point(20, 524)
        Me.accept_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.accept_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.accept_btn.Name = "accept_btn"
        Me.accept_btn.Primary = True
        Me.accept_btn.Size = New System.Drawing.Size(192, 46)
        Me.accept_btn.TabIndex = 17
        Me.accept_btn.Text = "Accept"
        Me.accept_btn.UseVisualStyleBackColor = True
        '
        'password_txt
        '
        Me.password_txt.Depth = 0
        Me.password_txt.Hint = ""
        Me.password_txt.Location = New System.Drawing.Point(347, 340)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.password_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.SelectedText = ""
        Me.password_txt.SelectionLength = 0
        Me.password_txt.SelectionStart = 0
        Me.password_txt.Size = New System.Drawing.Size(522, 39)
        Me.password_txt.TabIndex = 9
        Me.password_txt.UseSystemPasswordChar = False
        '
        'Username_txt
        '
        Me.Username_txt.Depth = 0
        Me.Username_txt.Hint = ""
        Me.Username_txt.Location = New System.Drawing.Point(347, 263)
        Me.Username_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.Username_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.Username_txt.Name = "Username_txt"
        Me.Username_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username_txt.SelectedText = ""
        Me.Username_txt.SelectionLength = 0
        Me.Username_txt.SelectionStart = 0
        Me.Username_txt.Size = New System.Drawing.Size(522, 39)
        Me.Username_txt.TabIndex = 10
        Me.Username_txt.UseSystemPasswordChar = False
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Depth = 0
        Me.password_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.password_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password_lbl.Location = New System.Drawing.Point(12, 340)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(145, 34)
        Me.password_lbl.TabIndex = 6
        Me.password_lbl.Text = "Password:"
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Depth = 0
        Me.username_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.username_lbl.Location = New System.Drawing.Point(12, 263)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.username_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(148, 34)
        Me.username_lbl.TabIndex = 7
        Me.username_lbl.Text = "Username:"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(12, 146)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(1026, 34)
        Me.SelectLabel.TabIndex = 18
        Me.SelectLabel.Text = "Please do keep in mind that this would automatically be an Administrator account"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(12, 192)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(691, 34)
        Me.MaterialLabel4.TabIndex = 18
        Me.MaterialLabel4.Text = "as it is the first account to be registered in this system."
        '
        'pbStrength
        '
        Me.pbStrength.Location = New System.Drawing.Point(349, 406)
        Me.pbStrength.Margin = New System.Windows.Forms.Padding(6)
        Me.pbStrength.Name = "pbStrength"
        Me.pbStrength.Size = New System.Drawing.Size(520, 44)
        Me.pbStrength.TabIndex = 19
        '
        'PStrengthMaterialLbl
        '
        Me.PStrengthMaterialLbl.AutoSize = True
        Me.PStrengthMaterialLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.PStrengthMaterialLbl.Depth = 0
        Me.PStrengthMaterialLbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.PStrengthMaterialLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PStrengthMaterialLbl.Location = New System.Drawing.Point(15, 416)
        Me.PStrengthMaterialLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PStrengthMaterialLbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.PStrengthMaterialLbl.Name = "PStrengthMaterialLbl"
        Me.PStrengthMaterialLbl.Size = New System.Drawing.Size(257, 34)
        Me.PStrengthMaterialLbl.TabIndex = 20
        Me.PStrengthMaterialLbl.Text = "Password Strength:"
        '
        'FirstRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 642)
        Me.Controls.Add(Me.PStrengthMaterialLbl)
        Me.Controls.Add(Me.pbStrength)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.accept_btn)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.Username_txt)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FirstRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents accept_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents password_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Username_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents password_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents username_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pbStrength As ProgressBar
    Friend WithEvents PStrengthMaterialLbl As MaterialSkin.Controls.MaterialLabel
End Class
