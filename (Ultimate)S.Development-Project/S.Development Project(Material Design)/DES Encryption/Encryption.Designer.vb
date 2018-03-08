<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encryption
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
        Me.Encrypt_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SelectLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.filepathname_txt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.filepathname_lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Decrypt_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.Depth = 0
        Me.back_btn.Location = New System.Drawing.Point(56, 578)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Primary = True
        Me.back_btn.Size = New System.Drawing.Size(192, 46)
        Me.back_btn.TabIndex = 32
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Browse_btn
        '
        Me.Browse_btn.Depth = 0
        Me.Browse_btn.Location = New System.Drawing.Point(799, 452)
        Me.Browse_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Browse_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Browse_btn.Name = "Browse_btn"
        Me.Browse_btn.Primary = True
        Me.Browse_btn.Size = New System.Drawing.Size(192, 46)
        Me.Browse_btn.TabIndex = 33
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.UseVisualStyleBackColor = True
        '
        'Encrypt_btn
        '
        Me.Encrypt_btn.Depth = 0
        Me.Encrypt_btn.Location = New System.Drawing.Point(56, 524)
        Me.Encrypt_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Encrypt_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Encrypt_btn.Name = "Encrypt_btn"
        Me.Encrypt_btn.Primary = True
        Me.Encrypt_btn.Size = New System.Drawing.Size(192, 46)
        Me.Encrypt_btn.TabIndex = 34
        Me.Encrypt_btn.Text = "Encrypt"
        Me.Encrypt_btn.UseVisualStyleBackColor = True
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Depth = 0
        Me.SelectLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SelectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectLabel.Location = New System.Drawing.Point(50, 306)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(745, 34)
        Me.SelectLabel.TabIndex = 31
        Me.SelectLabel.Text = "Please select the file(s) which you wish to encrypt/decrypt."
        '
        'filepathname_txt
        '
        Me.filepathname_txt.Depth = 0
        Me.filepathname_txt.Hint = ""
        Me.filepathname_txt.Location = New System.Drawing.Point(385, 388)
        Me.filepathname_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.filepathname_txt.MouseState = MaterialSkin.MouseState.HOVER
        Me.filepathname_txt.Name = "filepathname_txt"
        Me.filepathname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.filepathname_txt.SelectedText = ""
        Me.filepathname_txt.SelectionLength = 0
        Me.filepathname_txt.SelectionStart = 0
        Me.filepathname_txt.Size = New System.Drawing.Size(963, 39)
        Me.filepathname_txt.TabIndex = 30
        Me.filepathname_txt.UseSystemPasswordChar = False
        '
        'filepathname_lbl
        '
        Me.filepathname_lbl.AutoSize = True
        Me.filepathname_lbl.Depth = 0
        Me.filepathname_lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.filepathname_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.filepathname_lbl.Location = New System.Drawing.Point(50, 388)
        Me.filepathname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filepathname_lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.filepathname_lbl.Name = "filepathname_lbl"
        Me.filepathname_lbl.Size = New System.Drawing.Size(265, 34)
        Me.filepathname_lbl.TabIndex = 28
        Me.filepathname_lbl.Text = "File Path and Name:"
        '
        'Decrypt_btn
        '
        Me.Decrypt_btn.Depth = 0
        Me.Decrypt_btn.Location = New System.Drawing.Point(256, 524)
        Me.Decrypt_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Decrypt_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Decrypt_btn.Name = "Decrypt_btn"
        Me.Decrypt_btn.Primary = True
        Me.Decrypt_btn.Size = New System.Drawing.Size(192, 46)
        Me.Decrypt_btn.TabIndex = 35
        Me.Decrypt_btn.Text = "Decrypt"
        Me.Decrypt_btn.UseVisualStyleBackColor = True
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'Encryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 740)
        Me.Controls.Add(Me.Decrypt_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Browse_btn)
        Me.Controls.Add(Me.Encrypt_btn)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.filepathname_txt)
        Me.Controls.Add(Me.filepathname_lbl)
        Me.Name = "Encryption"
        Me.Text = "Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Browse_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Encrypt_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents SelectLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents filepathname_txt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents filepathname_lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Decrypt_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents OFD1 As OpenFileDialog
End Class
