<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDelete
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
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.usernameID_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.usernameID_CB = New System.Windows.Forms.ComboBox()
        Me.delete_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.close_btn = New MaterialSkin.Controls.MaterialRaisedButton()
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
        Me.SelectLabel.Size = New System.Drawing.Size(343, 19)
        Me.SelectLabel.TabIndex = 2
        Me.SelectLabel.Text = "Please select the account that you want to delete."
        '
        'usernameID_lbl
        '
        Me.usernameID_lbl.AutoSize = True
        Me.usernameID_lbl.Depth = 0
        Me.usernameID_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.usernameID_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.usernameID_lbl.Location = New System.Drawing.Point(24, 128)
        Me.usernameID_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.usernameID_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.usernameID_lbl.Name = "usernameID_lbl"
        Me.usernameID_lbl.Size = New System.Drawing.Size(81, 19)
        Me.usernameID_lbl.TabIndex = 8
        Me.usernameID_lbl.Text = "Username:"
        '
        'usernameID_CB
        '
        Me.usernameID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.usernameID_CB.FormattingEnabled = True
        Me.usernameID_CB.Location = New System.Drawing.Point(135, 129)
        Me.usernameID_CB.Name = "usernameID_CB"
        Me.usernameID_CB.Size = New System.Drawing.Size(174, 21)
        Me.usernameID_CB.TabIndex = 9
        '
        'delete_btn
        '
        Me.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.delete_btn.Depth = 0
        Me.delete_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(71, 211)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.delete_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Primary = True
        Me.delete_btn.Size = New System.Drawing.Size(100, 28)
        Me.delete_btn.TabIndex = 10
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.close_btn.Depth = 0
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.Location = New System.Drawing.Point(209, 211)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = True
        Me.close_btn.Size = New System.Drawing.Size(100, 28)
        Me.close_btn.TabIndex = 11
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'AdminDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 272)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.usernameID_CB)
        Me.Controls.Add(Me.usernameID_lbl)
        Me.Controls.Add(Me.SelectLabel)
        Me.MaximizeBox = False
        Me.Name = "AdminDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDelete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents usernameID_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents usernameID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents delete_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
