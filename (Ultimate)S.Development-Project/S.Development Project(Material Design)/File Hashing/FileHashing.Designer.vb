<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileHashing
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
        Me.md5_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.filepathname_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.md5_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.filepathname_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.back_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Hash_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Browse_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(107, 219)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(607, 34)
        Me.SelectLabel.TabIndex = 24
        Me.SelectLabel.Text = "Please select the file(s) which you wish to hash."
        '
        'md5_txt
        '
        Me.md5_txt.Depth = 0
        Me.md5_txt.Hint = ""
        Me.md5_txt.Location = New System.Drawing.Point(442, 407)
        Me.md5_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.md5_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.md5_txt.Name = "md5_txt"
        Me.md5_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.md5_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.md5_txt.SelectedText = ""
        Me.md5_txt.SelectionLength = 0
        Me.md5_txt.SelectionStart = 0
        Me.md5_txt.Size = New System.Drawing.Size(522, 39)
        Me.md5_txt.TabIndex = 21
        Me.md5_txt.UseSystemPasswordChar = False
        '
        'filepathname_txt
        '
        Me.filepathname_txt.Depth = 0
        Me.filepathname_txt.Hint = ""
        Me.filepathname_txt.Location = New System.Drawing.Point(442, 330)
        Me.filepathname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.filepathname_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.filepathname_txt.Name = "filepathname_txt"
        Me.filepathname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.filepathname_txt.SelectedText = ""
        Me.filepathname_txt.SelectionLength = 0
        Me.filepathname_txt.SelectionStart = 0
        Me.filepathname_txt.Size = New System.Drawing.Size(522, 39)
        Me.filepathname_txt.TabIndex = 22
        Me.filepathname_txt.UseSystemPasswordChar = False
        '
        'md5_lbl
        '
        Me.md5_lbl.AutoSize = True
        Me.md5_lbl.Depth = 0
        Me.md5_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.md5_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.md5_lbl.Location = New System.Drawing.Point(107, 407)
        Me.md5_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.md5_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.md5_lbl.Name = "md5_lbl"
        Me.md5_lbl.Size = New System.Drawing.Size(228, 34)
        Me.md5_lbl.TabIndex = 19
        Me.md5_lbl.Text = "MD5 Hash Value:"
        '
        'filepathname_lbl
        '
        Me.filepathname_lbl.AutoSize = True
        Me.filepathname_lbl.Depth = 0
        Me.filepathname_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.filepathname_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.filepathname_lbl.Location = New System.Drawing.Point(107, 330)
        Me.filepathname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filepathname_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.filepathname_lbl.Name = "filepathname_lbl"
        Me.filepathname_lbl.Size = New System.Drawing.Size(265, 34)
        Me.filepathname_lbl.TabIndex = 20
        Me.filepathname_lbl.Text = "File Path and Name:"
        '
        'back_btn
        '
        Me.back_btn.Depth = 0
        Me.back_btn.Location = New System.Drawing.Point(113, 568)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Primary = True
        Me.back_btn.Size = New System.Drawing.Size(192, 46)
        Me.back_btn.TabIndex = 25
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Hash_btn
        '
        Me.Hash_btn.Depth = 0
        Me.Hash_btn.Location = New System.Drawing.Point(1033, 407)
        Me.Hash_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Hash_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Hash_btn.Name = "Hash_btn"
        Me.Hash_btn.Primary = True
        Me.Hash_btn.Size = New System.Drawing.Size(192, 46)
        Me.Hash_btn.TabIndex = 26
        Me.Hash_btn.Text = "Hash"
        Me.Hash_btn.UseVisualStyleBackColor = True
        '
        'Browse_btn
        '
        Me.Browse_btn.Depth = 0
        Me.Browse_btn.Location = New System.Drawing.Point(1033, 330)
        Me.Browse_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Browse_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Primary = True
        Me.Browse_btn.Size = New System.Drawing.Size(192, 46)
        Me.Browse_btn.TabIndex = 26
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FileHashing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 658)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Browse_btn)
        Me.Controls.Add(Me.Hash_btn)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.md5_txt)
        Me.Controls.Add(Me.filepathname_txt)
        Me.Controls.Add(Me.md5_lbl)
        Me.Controls.Add(Me.filepathname_lbl)
        Me.Name = "FileHashing"
        Me.Text = "FileHashing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents md5_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents filepathname_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents md5_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents filepathname_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents back_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Hash_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Browse_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
