<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keylogger
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
        Me.Close_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Role = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.keylogger_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Close_btn
        '
        Me.Close_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Close_btn.Depth = 0
        Me.Close_btn.Location = New System.Drawing.Point(22, 848)
        Me.Close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Primary = True
        Me.Close_btn.Size = New System.Drawing.Size(141, 56)
        Me.Close_btn.TabIndex = 37
        Me.Close_btn.Text = "Close"
        Me.Close_btn.UseVisualStyleBackColor = True
        '
        'Role
        '
        Me.Role.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Role.AutoSize = True
        Me.Role.BackColor = System.Drawing.Color.Transparent
        Me.Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.ForeColor = System.Drawing.Color.White
        Me.Role.Location = New System.Drawing.Point(1103, 879)
        Me.Role.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(48, 25)
        Me.Role.TabIndex = 48
        Me.Role.Text = "role"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8
        '
        'keylogger_txt
        '
        Me.keylogger_txt.Location = New System.Drawing.Point(46, 216)
        Me.keylogger_txt.Multiline = True
        Me.keylogger_txt.Name = "keylogger_txt"
        Me.keylogger_txt.ReadOnly = True
        Me.keylogger_txt.Size = New System.Drawing.Size(1089, 615)
        Me.keylogger_txt.TabIndex = 49
        '
        'Keylogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 934)
        Me.Controls.Add(Me.keylogger_txt)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.Close_btn)
        Me.Name = "Keylogger"
        Me.Text = "Keylogger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Close_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Role As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents keylogger_txt As TextBox
End Class
