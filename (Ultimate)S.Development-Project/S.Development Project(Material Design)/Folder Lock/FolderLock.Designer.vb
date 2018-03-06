<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderLock
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
        Me.Browse_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FolderLockDescription = New MaterialSkin.Controls.MaterialLabel()
        Me.folderpathname_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.folderpathname_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Lock_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Unlock_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Depth = 0
        Me.back_btn.Location = New System.Drawing.Point(75, 520)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Primary = True
        Me.back_btn.Size = New System.Drawing.Size(192, 46)
        Me.back_btn.TabIndex = 30
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Browse_btn
        '
        Me.Browse_btn.Depth = 0
        Me.Browse_btn.Location = New System.Drawing.Point(995, 282)
        Me.Browse_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Browse_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Primary = True
        Me.Browse_btn.Size = New System.Drawing.Size(192, 46)
        Me.Browse_btn.TabIndex = 31
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'FolderLockDescription
        '
        Me.FolderLockDescription.AutoSize = True
        Me.FolderLockDescription.Depth = 0
        Me.FolderLockDescription.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.FolderLockDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FolderLockDescription.Location = New System.Drawing.Point(69, 171)
        Me.FolderLockDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FolderLockDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.FolderLockDescription.Name = "FolderLockDescription"
        Me.FolderLockDescription.Size = New System.Drawing.Size(694, 34)
        Me.FolderLockDescription.TabIndex = 29
        Me.FolderLockDescription.Text = "Please select the folder which you wish to lock/unlock."
        '
        'folderpathname_txt
        '
        Me.folderpathname_txt.Depth = 0
        Me.folderpathname_txt.Hint = ""
        Me.folderpathname_txt.Location = New System.Drawing.Point(404, 282)
        Me.folderpathname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.folderpathname_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.folderpathname_txt.Name = "folderpathname_txt"
        Me.folderpathname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.folderpathname_txt.SelectedText = ""
        Me.folderpathname_txt.SelectionLength = 0
        Me.folderpathname_txt.SelectionStart = 0
        Me.folderpathname_txt.Size = New System.Drawing.Size(522, 39)
        Me.folderpathname_txt.TabIndex = 28
        Me.folderpathname_txt.UseSystemPasswordChar = False
        '
        'folderpathname_lbl
        '
        Me.folderpathname_lbl.AutoSize = True
        Me.folderpathname_lbl.Depth = 0
        Me.folderpathname_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.folderpathname_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.folderpathname_lbl.Location = New System.Drawing.Point(69, 282)
        Me.folderpathname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.folderpathname_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.folderpathname_lbl.Name = "folderpathname_lbl"
        Me.folderpathname_lbl.Size = New System.Drawing.Size(299, 34)
        Me.folderpathname_lbl.TabIndex = 27
        Me.folderpathname_lbl.Text = "Folder Path and Name:"
        '
        'Lock_btn
        '
        Me.Lock_btn.Depth = 0
        Me.Lock_btn.Location = New System.Drawing.Point(75, 428)
        Me.Lock_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Lock_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lock_btn.Name = "Lock_btn"
        Me.Lock_btn.Primary = True
        Me.Lock_btn.Size = New System.Drawing.Size(192, 46)
        Me.Lock_btn.TabIndex = 32
        Me.Lock_btn.Text = "Lock"
        Me.Lock_btn.UseVisualStyleBackColor = True
        '
        'Unlock_btn
        '
        Me.Unlock_btn.Depth = 0
        Me.Unlock_btn.Location = New System.Drawing.Point(313, 428)
        Me.Unlock_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Unlock_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Unlock_btn.Name = "Unlock_btn"
        Me.Unlock_btn.Primary = True
        Me.Unlock_btn.Size = New System.Drawing.Size(192, 46)
        Me.Unlock_btn.TabIndex = 33
        Me.Unlock_btn.Text = "Unlock"
        Me.Unlock_btn.UseVisualStyleBackColor = True
        '
        'FolderLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 710)
        Me.Controls.Add(Me.Unlock_btn)
        Me.Controls.Add(Me.Lock_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Browse_btn)
        Me.Controls.Add(Me.FolderLockDescription)
        Me.Controls.Add(Me.folderpathname_txt)
        Me.Controls.Add(Me.folderpathname_lbl)
        Me.Name = "FolderLock"
        Me.Text = "FolderLock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Browse_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FolderLockDescription As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents folderpathname_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents folderpathname_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Lock_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Unlock_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents FBD1 As FolderBrowserDialog
End Class
