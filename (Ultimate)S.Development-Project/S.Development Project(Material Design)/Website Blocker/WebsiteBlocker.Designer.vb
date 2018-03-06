<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebsiteBlocker
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
        Me.Unblock_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Block_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.back_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FolderLockDescription = New MaterialSkin.Controls.MaterialLabel()
        Me.URL_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.folderpathname_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Unblock_btn
        '
        Me.Unblock_btn.Depth = 0
        Me.Unblock_btn.Location = New System.Drawing.Point(333, 440)
        Me.Unblock_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Unblock_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Unblock_btn.Name = "Unblock_btn"
        Me.Unblock_btn.Primary = True
        Me.Unblock_btn.Size = New System.Drawing.Size(192, 46)
        Me.Unblock_btn.TabIndex = 40
        Me.Unblock_btn.Text = "Unblock"
        Me.Unblock_btn.UseVisualStyleBackColor = True
        '
        'Block_btn
        '
        Me.Block_btn.Depth = 0
        Me.Block_btn.Location = New System.Drawing.Point(95, 440)
        Me.Block_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Block_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Block_btn.Name = "Block_btn"
        Me.Block_btn.Primary = True
        Me.Block_btn.Size = New System.Drawing.Size(192, 46)
        Me.Block_btn.TabIndex = 39
        Me.Block_btn.Text = "Block"
        Me.Block_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Depth = 0
        Me.back_btn.Location = New System.Drawing.Point(95, 532)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Primary = True
        Me.back_btn.Size = New System.Drawing.Size(192, 46)
        Me.back_btn.TabIndex = 37
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'FolderLockDescription
        '
        Me.FolderLockDescription.AutoSize = True
        Me.FolderLockDescription.Depth = 0
        Me.FolderLockDescription.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.FolderLockDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FolderLockDescription.Location = New System.Drawing.Point(89, 183)
        Me.FolderLockDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FolderLockDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.FolderLockDescription.Name = "FolderLockDescription"
        Me.FolderLockDescription.Size = New System.Drawing.Size(738, 34)
        Me.FolderLockDescription.TabIndex = 36
        Me.FolderLockDescription.Text = "Please enter the website which you wish to block/unblock."
        '
        'URL_txt
        '
        Me.URL_txt.Depth = 0
        Me.URL_txt.Hint = ""
        Me.URL_txt.Location = New System.Drawing.Point(319, 289)
        Me.URL_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.URL_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.URL_txt.Name = "URL_txt"
        Me.URL_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.URL_txt.SelectedText = ""
        Me.URL_txt.SelectionLength = 0
        Me.URL_txt.SelectionStart = 0
        Me.URL_txt.Size = New System.Drawing.Size(1077, 39)
        Me.URL_txt.TabIndex = 35
        Me.URL_txt.UseSystemPasswordChar = False
        '
        'folderpathname_lbl
        '
        Me.folderpathname_lbl.AutoSize = True
        Me.folderpathname_lbl.Depth = 0
        Me.folderpathname_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.folderpathname_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.folderpathname_lbl.Location = New System.Drawing.Point(89, 294)
        Me.folderpathname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.folderpathname_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.folderpathname_lbl.Name = "folderpathname_lbl"
        Me.folderpathname_lbl.Size = New System.Drawing.Size(185, 34)
        Me.folderpathname_lbl.TabIndex = 34
        Me.folderpathname_lbl.Text = "Website/URL:"
        '
        'WebsiteBlocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 671)
        Me.Controls.Add(Me.Unblock_btn)
        Me.Controls.Add(Me.Block_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.FolderLockDescription)
        Me.Controls.Add(Me.URL_txt)
        Me.Controls.Add(Me.folderpathname_lbl)
        Me.Name = "WebsiteBlocker"
        Me.Text = "WebsiteBlocker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Unblock_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Block_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents back_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FolderLockDescription As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents URL_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents folderpathname_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents FBD1 As FolderBrowserDialog
End Class
