<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteReservation
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
        Me.delete_G = New System.Windows.Forms.GroupBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.FnSReservID_CB = New System.Windows.Forms.ComboBox()
        Me.roomReservID_CB = New System.Windows.Forms.ComboBox()
        Me.FnSID_lbl = New System.Windows.Forms.Label()
        Me.RRID_lbl = New System.Windows.Forms.Label()
        Me.FnS_R = New System.Windows.Forms.RadioButton()
        Me.RR_R = New System.Windows.Forms.RadioButton()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.delete_G.SuspendLayout()
        Me.SuspendLayout()
        '
        'delete_G
        '
        Me.delete_G.Controls.Add(Me.delete_btn)
        Me.delete_G.Controls.Add(Me.FnSReservID_CB)
        Me.delete_G.Controls.Add(Me.roomReservID_CB)
        Me.delete_G.Controls.Add(Me.FnSID_lbl)
        Me.delete_G.Controls.Add(Me.RRID_lbl)
        Me.delete_G.Controls.Add(Me.FnS_R)
        Me.delete_G.Controls.Add(Me.RR_R)
        Me.delete_G.Location = New System.Drawing.Point(12, 76)
        Me.delete_G.Name = "delete_G"
        Me.delete_G.Size = New System.Drawing.Size(659, 255)
        Me.delete_G.TabIndex = 0
        Me.delete_G.TabStop = False
        Me.delete_G.Text = "Room, Facilities or Services:"
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(482, 214)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 23)
        Me.delete_btn.TabIndex = 13
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'FnSReservID_CB
        '
        Me.FnSReservID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FnSReservID_CB.Enabled = False
        Me.FnSReservID_CB.FormattingEnabled = True
        Me.FnSReservID_CB.Location = New System.Drawing.Point(167, 186)
        Me.FnSReservID_CB.Name = "FnSReservID_CB"
        Me.FnSReservID_CB.Size = New System.Drawing.Size(138, 21)
        Me.FnSReservID_CB.TabIndex = 5
        '
        'roomReservID_CB
        '
        Me.roomReservID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomReservID_CB.Enabled = False
        Me.roomReservID_CB.FormattingEnabled = True
        Me.roomReservID_CB.Location = New System.Drawing.Point(167, 82)
        Me.roomReservID_CB.Name = "roomReservID_CB"
        Me.roomReservID_CB.Size = New System.Drawing.Size(138, 21)
        Me.roomReservID_CB.TabIndex = 4
        '
        'FnSID_lbl
        '
        Me.FnSID_lbl.AutoSize = True
        Me.FnSID_lbl.Location = New System.Drawing.Point(32, 189)
        Me.FnSID_lbl.Name = "FnSID_lbl"
        Me.FnSID_lbl.Size = New System.Drawing.Size(129, 13)
        Me.FnSID_lbl.TabIndex = 3
        Me.FnSID_lbl.Text = "Facilities and Services ID:"
        '
        'RRID_lbl
        '
        Me.RRID_lbl.AutoSize = True
        Me.RRID_lbl.Location = New System.Drawing.Point(32, 85)
        Me.RRID_lbl.Name = "RRID_lbl"
        Me.RRID_lbl.Size = New System.Drawing.Size(112, 13)
        Me.RRID_lbl.TabIndex = 2
        Me.RRID_lbl.Text = "Room Reservation ID:"
        '
        'FnS_R
        '
        Me.FnS_R.AutoSize = True
        Me.FnS_R.Location = New System.Drawing.Point(35, 131)
        Me.FnS_R.Name = "FnS_R"
        Me.FnS_R.Size = New System.Drawing.Size(130, 17)
        Me.FnS_R.TabIndex = 1
        Me.FnS_R.TabStop = True
        Me.FnS_R.Text = "Facilities and Services"
        Me.FnS_R.UseVisualStyleBackColor = True
        '
        'RR_R
        '
        Me.RR_R.AutoSize = True
        Me.RR_R.Location = New System.Drawing.Point(35, 43)
        Me.RR_R.Name = "RR_R"
        Me.RR_R.Size = New System.Drawing.Size(113, 17)
        Me.RR_R.TabIndex = 0
        Me.RR_R.TabStop = True
        Me.RR_R.Text = "Room Reservation"
        Me.RR_R.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(641, 348)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.close_btn.MinimumSize = New System.Drawing.Size(55, 16)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = False
        Me.close_btn.Size = New System.Drawing.Size(55, 36)
        Me.close_btn.TabIndex = 39
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'DeleteReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 384)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.delete_G)
        Me.MaximizeBox = False
        Me.Name = "DeleteReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Reservation"
        Me.delete_G.ResumeLayout(False)
        Me.delete_G.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents delete_G As System.Windows.Forms.GroupBox
    Friend WithEvents FnS_R As System.Windows.Forms.RadioButton
    Friend WithEvents RR_R As System.Windows.Forms.RadioButton
    Friend WithEvents FnSReservID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents roomReservID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents FnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents RRID_lbl As System.Windows.Forms.Label
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents delete_btn As System.Windows.Forms.Button
End Class
