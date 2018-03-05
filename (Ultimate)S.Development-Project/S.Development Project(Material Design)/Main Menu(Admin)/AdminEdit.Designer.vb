<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminEdit
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
        Me.password_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.password_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.username_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.username_CB = New System.Windows.Forms.ComboBox()
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.close_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.update_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.position_CB = New System.Windows.Forms.ComboBox()
        Me.position_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'password_txt
        '
        Me.password_txt.Depth = 0
        Me.password_txt.Enabled = False
        Me.password_txt.Hint = ""
        Me.password_txt.Location = New System.Drawing.Point(108, 146)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.password_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.SelectedText = ""
        Me.password_txt.SelectionLength = 0
        Me.password_txt.SelectionStart = 0
        Me.password_txt.Size = New System.Drawing.Size(174, 23)
        Me.password_txt.TabIndex = 5
        Me.password_txt.UseSystemPasswordChar = False
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Depth = 0
        Me.password_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.password_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.password_lbl.Location = New System.Drawing.Point(5, 146)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.password_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(79, 19)
        Me.password_lbl.TabIndex = 3
        Me.password_lbl.Text = "Password:"
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Depth = 0
        Me.username_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.username_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.username_lbl.Location = New System.Drawing.Point(5, 106)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.username_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(81, 19)
        Me.username_lbl.TabIndex = 4
        Me.username_lbl.Text = "Username:"
        '
        'username_CB
        '
        Me.username_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.username_CB.FormattingEnabled = True
        Me.username_CB.Location = New System.Drawing.Point(108, 107)
        Me.username_CB.Name = "username_CB"
        Me.username_CB.Size = New System.Drawing.Size(174, 21)
        Me.username_CB.TabIndex = 7
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
        Me.SelectLabel.Size = New System.Drawing.Size(327, 19)
        Me.SelectLabel.TabIndex = 8
        Me.SelectLabel.Text = "Please select the account that you want to edit."
        '
        'close_btn
        '
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(109, 230)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = True
        Me.close_btn.Size = New System.Drawing.Size(96, 24)
        Me.close_btn.TabIndex = 9
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Depth = 0
        Me.update_btn.Location = New System.Drawing.Point(9, 230)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.update_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Primary = True
        Me.update_btn.Size = New System.Drawing.Size(96, 24)
        Me.update_btn.TabIndex = 10
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'position_CB
        '
        Me.position_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.position_CB.Enabled = False
        Me.position_CB.FormattingEnabled = True
        Me.position_CB.Items.AddRange(New Object() {"Admin", "Reservation Management", "Front Desk Management", "Room & Facilities Management"})
        Me.position_CB.Location = New System.Drawing.Point(108, 186)
        Me.position_CB.Name = "position_CB"
        Me.position_CB.Size = New System.Drawing.Size(174, 21)
        Me.position_CB.TabIndex = 12
        '
        'position_lbl
        '
        Me.position_lbl.AutoSize = True
        Me.position_lbl.Depth = 0
        Me.position_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.position_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.position_lbl.Location = New System.Drawing.Point(5, 185)
        Me.position_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.position_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.position_lbl.Name = "position_lbl"
        Me.position_lbl.Size = New System.Drawing.Size(69, 19)
        Me.position_lbl.TabIndex = 11
        Me.position_lbl.Text = "Position:"
        '
        'AdminEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 279)
        Me.Controls.Add(Me.position_CB)
        Me.Controls.Add(Me.position_lbl)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.username_CB)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.MaximizeBox = False
        Me.Name = "AdminEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents password_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents username_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents username_CB As System.Windows.Forms.ComboBox
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents update_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents position_CB As System.Windows.Forms.ComboBox
    Friend WithEvents position_lbl As MaterialSkin.Controls.MaterialLabel
End Class
