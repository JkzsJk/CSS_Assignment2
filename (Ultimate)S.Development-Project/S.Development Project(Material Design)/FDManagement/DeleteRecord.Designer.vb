<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteRecord
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
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteRecord_btn = New System.Windows.Forms.Button()
        Me.roomNOGroupW_lbl = New System.Windows.Forms.Label()
        Me.RecordID_CB = New System.Windows.Forms.ComboBox()
        Me.roomTypeGroupW_lbl = New System.Windows.Forms.Label()
        Me.recordtype_CB = New System.Windows.Forms.ComboBox()
        Me.recordstatus_txt = New System.Windows.Forms.TextBox()
        Me.CI_lbl = New System.Windows.Forms.Label()
        Me.CO_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(268, 255)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.close_btn.MinimumSize = New System.Drawing.Size(55, 16)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = False
        Me.close_btn.Size = New System.Drawing.Size(55, 36)
        Me.close_btn.TabIndex = 40
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Record Type:"
        '
        'deleteRecord_btn
        '
        Me.deleteRecord_btn.Location = New System.Drawing.Point(176, 204)
        Me.deleteRecord_btn.Name = "deleteRecord_btn"
        Me.deleteRecord_btn.Size = New System.Drawing.Size(75, 23)
        Me.deleteRecord_btn.TabIndex = 52
        Me.deleteRecord_btn.Text = "Delete"
        Me.deleteRecord_btn.UseVisualStyleBackColor = True
        '
        'roomNOGroupW_lbl
        '
        Me.roomNOGroupW_lbl.AutoSize = True
        Me.roomNOGroupW_lbl.Location = New System.Drawing.Point(57, 149)
        Me.roomNOGroupW_lbl.Name = "roomNOGroupW_lbl"
        Me.roomNOGroupW_lbl.Size = New System.Drawing.Size(59, 13)
        Me.roomNOGroupW_lbl.TabIndex = 50
        Me.roomNOGroupW_lbl.Text = "Record ID:"
        '
        'RecordID_CB
        '
        Me.RecordID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RecordID_CB.FormattingEnabled = True
        Me.RecordID_CB.Location = New System.Drawing.Point(187, 146)
        Me.RecordID_CB.Name = "RecordID_CB"
        Me.RecordID_CB.Size = New System.Drawing.Size(64, 21)
        Me.RecordID_CB.TabIndex = 51
        '
        'roomTypeGroupW_lbl
        '
        Me.roomTypeGroupW_lbl.AutoSize = True
        Me.roomTypeGroupW_lbl.Location = New System.Drawing.Point(57, 177)
        Me.roomTypeGroupW_lbl.Name = "roomTypeGroupW_lbl"
        Me.roomTypeGroupW_lbl.Size = New System.Drawing.Size(78, 13)
        Me.roomTypeGroupW_lbl.TabIndex = 49
        Me.roomTypeGroupW_lbl.Text = "Record Status:"
        '
        'recordtype_CB
        '
        Me.recordtype_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.recordtype_CB.FormattingEnabled = True
        Me.recordtype_CB.Items.AddRange(New Object() {"Check-In", "Check-Out"})
        Me.recordtype_CB.Location = New System.Drawing.Point(163, 120)
        Me.recordtype_CB.Name = "recordtype_CB"
        Me.recordtype_CB.Size = New System.Drawing.Size(88, 21)
        Me.recordtype_CB.TabIndex = 54
        '
        'recordstatus_txt
        '
        Me.recordstatus_txt.Enabled = False
        Me.recordstatus_txt.Location = New System.Drawing.Point(163, 177)
        Me.recordstatus_txt.Name = "recordstatus_txt"
        Me.recordstatus_txt.Size = New System.Drawing.Size(88, 20)
        Me.recordstatus_txt.TabIndex = 55
        '
        'CI_lbl
        '
        Me.CI_lbl.AutoSize = True
        Me.CI_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CI_lbl.Location = New System.Drawing.Point(160, 149)
        Me.CI_lbl.Name = "CI_lbl"
        Me.CI_lbl.Size = New System.Drawing.Size(19, 13)
        Me.CI_lbl.TabIndex = 56
        Me.CI_lbl.Text = "CI"
        '
        'CO_lbl
        '
        Me.CO_lbl.AutoSize = True
        Me.CO_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CO_lbl.Location = New System.Drawing.Point(160, 149)
        Me.CO_lbl.Name = "CO_lbl"
        Me.CO_lbl.Size = New System.Drawing.Size(24, 13)
        Me.CO_lbl.TabIndex = 57
        Me.CO_lbl.Text = "CO"
        Me.CO_lbl.Visible = False
        '
        'DeleteRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 295)
        Me.Controls.Add(Me.CO_lbl)
        Me.Controls.Add(Me.CI_lbl)
        Me.Controls.Add(Me.recordstatus_txt)
        Me.Controls.Add(Me.recordtype_CB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deleteRecord_btn)
        Me.Controls.Add(Me.roomNOGroupW_lbl)
        Me.Controls.Add(Me.RecordID_CB)
        Me.Controls.Add(Me.roomTypeGroupW_lbl)
        Me.Controls.Add(Me.close_btn)
        Me.MaximizeBox = False
        Me.Name = "DeleteRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents deleteRecord_btn As System.Windows.Forms.Button
    Friend WithEvents roomNOGroupW_lbl As System.Windows.Forms.Label
    Friend WithEvents RecordID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents roomTypeGroupW_lbl As System.Windows.Forms.Label
    Friend WithEvents recordtype_CB As System.Windows.Forms.ComboBox
    Friend WithEvents recordstatus_txt As System.Windows.Forms.TextBox
    Friend WithEvents CI_lbl As System.Windows.Forms.Label
    Friend WithEvents CO_lbl As System.Windows.Forms.Label
End Class
