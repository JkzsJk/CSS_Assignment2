<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPayment
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
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.deposit_txt = New System.Windows.Forms.TextBox()
        Me.deposit_lbl = New System.Windows.Forms.Label()
        Me.RR_lbl = New System.Windows.Forms.Label()
        Me.P_lbl = New System.Windows.Forms.Label()
        Me.ICNumber_txt = New System.Windows.Forms.TextBox()
        Me.customerName_txt = New System.Windows.Forms.TextBox()
        Me.cPhoneNumber_txt = New System.Windows.Forms.TextBox()
        Me.ICNumber_lbl = New System.Windows.Forms.Label()
        Me.cPhoneNumber_lbl = New System.Windows.Forms.Label()
        Me.customerName_lbl = New System.Windows.Forms.Label()
        Me.totalPrice_txt = New System.Windows.Forms.TextBox()
        Me.paymentID_txt = New System.Windows.Forms.TextBox()
        Me.superiorRoom_txt = New System.Windows.Forms.TextBox()
        Me.deluxeRoom_txt = New System.Windows.Forms.TextBox()
        Me.standardRoom_txt = New System.Windows.Forms.TextBox()
        Me.rdt_txt = New System.Windows.Forms.TextBox()
        Me.addGroup_btn = New System.Windows.Forms.Button()
        Me.totalPrice_lbl = New System.Windows.Forms.Label()
        Me.superiorRoom_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_lbl = New System.Windows.Forms.Label()
        Me.standardRoom_lbl = New System.Windows.Forms.Label()
        Me.rdt_lbl = New System.Windows.Forms.Label()
        Me.roomReservation_lbl = New System.Windows.Forms.Label()
        Me.paymentID_lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalamountP_txt = New System.Windows.Forms.TextBox()
        Me.additionalpayment_lbl = New System.Windows.Forms.Label()
        Me.repaymentP_lbl = New System.Windows.Forms.Label()
        Me.additionalpaymentP_txt = New System.Windows.Forms.TextBox()
        Me.repaymentP_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckinidP_CB = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.reservationidP_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckOut_RB = New System.Windows.Forms.RadioButton()
        Me.checkin_RB = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(610, 327)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.close_btn.MinimumSize = New System.Drawing.Size(55, 16)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = False
        Me.close_btn.Size = New System.Drawing.Size(55, 36)
        Me.close_btn.TabIndex = 41
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'deposit_txt
        '
        Me.deposit_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deposit_txt.Enabled = False
        Me.deposit_txt.Location = New System.Drawing.Point(486, 196)
        Me.deposit_txt.Name = "deposit_txt"
        Me.deposit_txt.Size = New System.Drawing.Size(158, 20)
        Me.deposit_txt.TabIndex = 100
        '
        'deposit_lbl
        '
        Me.deposit_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deposit_lbl.AutoSize = True
        Me.deposit_lbl.Location = New System.Drawing.Point(359, 199)
        Me.deposit_lbl.Name = "deposit_lbl"
        Me.deposit_lbl.Size = New System.Drawing.Size(46, 13)
        Me.deposit_lbl.TabIndex = 99
        Me.deposit_lbl.Text = "Deposit:"
        '
        'RR_lbl
        '
        Me.RR_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RR_lbl.AutoSize = True
        Me.RR_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RR_lbl.Location = New System.Drawing.Point(173, 174)
        Me.RR_lbl.Name = "RR_lbl"
        Me.RR_lbl.Size = New System.Drawing.Size(25, 13)
        Me.RR_lbl.TabIndex = 98
        Me.RR_lbl.Text = "RR"
        '
        'P_lbl
        '
        Me.P_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_lbl.AutoSize = True
        Me.P_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_lbl.Location = New System.Drawing.Point(173, 123)
        Me.P_lbl.Name = "P_lbl"
        Me.P_lbl.Size = New System.Drawing.Size(15, 13)
        Me.P_lbl.TabIndex = 97
        Me.P_lbl.Text = "P"
        '
        'ICNumber_txt
        '
        Me.ICNumber_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ICNumber_txt.Enabled = False
        Me.ICNumber_txt.Location = New System.Drawing.Point(486, 170)
        Me.ICNumber_txt.Name = "ICNumber_txt"
        Me.ICNumber_txt.Size = New System.Drawing.Size(158, 20)
        Me.ICNumber_txt.TabIndex = 95
        '
        'customerName_txt
        '
        Me.customerName_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.customerName_txt.Enabled = False
        Me.customerName_txt.Location = New System.Drawing.Point(486, 121)
        Me.customerName_txt.Name = "customerName_txt"
        Me.customerName_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerName_txt.TabIndex = 94
        '
        'cPhoneNumber_txt
        '
        Me.cPhoneNumber_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cPhoneNumber_txt.Enabled = False
        Me.cPhoneNumber_txt.Location = New System.Drawing.Point(486, 146)
        Me.cPhoneNumber_txt.Name = "cPhoneNumber_txt"
        Me.cPhoneNumber_txt.Size = New System.Drawing.Size(158, 20)
        Me.cPhoneNumber_txt.TabIndex = 93
        '
        'ICNumber_lbl
        '
        Me.ICNumber_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ICNumber_lbl.AutoSize = True
        Me.ICNumber_lbl.Location = New System.Drawing.Point(359, 172)
        Me.ICNumber_lbl.Name = "ICNumber_lbl"
        Me.ICNumber_lbl.Size = New System.Drawing.Size(65, 13)
        Me.ICNumber_lbl.TabIndex = 92
        Me.ICNumber_lbl.Text = "I/C Number:"
        '
        'cPhoneNumber_lbl
        '
        Me.cPhoneNumber_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cPhoneNumber_lbl.AutoSize = True
        Me.cPhoneNumber_lbl.Location = New System.Drawing.Point(358, 149)
        Me.cPhoneNumber_lbl.Name = "cPhoneNumber_lbl"
        Me.cPhoneNumber_lbl.Size = New System.Drawing.Size(128, 13)
        Me.cPhoneNumber_lbl.TabIndex = 91
        Me.cPhoneNumber_lbl.Text = "Customer Phone Number:"
        '
        'customerName_lbl
        '
        Me.customerName_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.customerName_lbl.AutoSize = True
        Me.customerName_lbl.Location = New System.Drawing.Point(358, 124)
        Me.customerName_lbl.Name = "customerName_lbl"
        Me.customerName_lbl.Size = New System.Drawing.Size(85, 13)
        Me.customerName_lbl.TabIndex = 90
        Me.customerName_lbl.Text = "Customer Name:"
        '
        'totalPrice_txt
        '
        Me.totalPrice_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totalPrice_txt.Enabled = False
        Me.totalPrice_txt.Location = New System.Drawing.Point(173, 295)
        Me.totalPrice_txt.Name = "totalPrice_txt"
        Me.totalPrice_txt.Size = New System.Drawing.Size(151, 20)
        Me.totalPrice_txt.TabIndex = 89
        '
        'paymentID_txt
        '
        Me.paymentID_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paymentID_txt.Enabled = False
        Me.paymentID_txt.Location = New System.Drawing.Point(206, 119)
        Me.paymentID_txt.Name = "paymentID_txt"
        Me.paymentID_txt.Size = New System.Drawing.Size(118, 20)
        Me.paymentID_txt.TabIndex = 86
        '
        'superiorRoom_txt
        '
        Me.superiorRoom_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.superiorRoom_txt.Enabled = False
        Me.superiorRoom_txt.Location = New System.Drawing.Point(173, 270)
        Me.superiorRoom_txt.Name = "superiorRoom_txt"
        Me.superiorRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.superiorRoom_txt.TabIndex = 85
        '
        'deluxeRoom_txt
        '
        Me.deluxeRoom_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deluxeRoom_txt.Enabled = False
        Me.deluxeRoom_txt.Location = New System.Drawing.Point(173, 245)
        Me.deluxeRoom_txt.Name = "deluxeRoom_txt"
        Me.deluxeRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.deluxeRoom_txt.TabIndex = 83
        '
        'standardRoom_txt
        '
        Me.standardRoom_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.standardRoom_txt.Enabled = False
        Me.standardRoom_txt.Location = New System.Drawing.Point(173, 221)
        Me.standardRoom_txt.Name = "standardRoom_txt"
        Me.standardRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.standardRoom_txt.TabIndex = 81
        '
        'rdt_txt
        '
        Me.rdt_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdt_txt.Enabled = False
        Me.rdt_txt.Location = New System.Drawing.Point(173, 196)
        Me.rdt_txt.Name = "rdt_txt"
        Me.rdt_txt.Size = New System.Drawing.Size(151, 20)
        Me.rdt_txt.TabIndex = 79
        '
        'addGroup_btn
        '
        Me.addGroup_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addGroup_btn.Location = New System.Drawing.Point(486, 327)
        Me.addGroup_btn.Name = "addGroup_btn"
        Me.addGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.addGroup_btn.TabIndex = 88
        Me.addGroup_btn.Text = "Add"
        Me.addGroup_btn.UseVisualStyleBackColor = True
        '
        'totalPrice_lbl
        '
        Me.totalPrice_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totalPrice_lbl.AutoSize = True
        Me.totalPrice_lbl.Location = New System.Drawing.Point(27, 298)
        Me.totalPrice_lbl.Name = "totalPrice_lbl"
        Me.totalPrice_lbl.Size = New System.Drawing.Size(61, 13)
        Me.totalPrice_lbl.TabIndex = 87
        Me.totalPrice_lbl.Text = "Total Price:"
        '
        'superiorRoom_lbl
        '
        Me.superiorRoom_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.superiorRoom_lbl.AutoSize = True
        Me.superiorRoom_lbl.Location = New System.Drawing.Point(27, 273)
        Me.superiorRoom_lbl.Name = "superiorRoom_lbl"
        Me.superiorRoom_lbl.Size = New System.Drawing.Size(80, 13)
        Me.superiorRoom_lbl.TabIndex = 84
        Me.superiorRoom_lbl.Text = "Superior Room:"
        '
        'deluxeRoom_lbl
        '
        Me.deluxeRoom_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deluxeRoom_lbl.AutoSize = True
        Me.deluxeRoom_lbl.Location = New System.Drawing.Point(27, 248)
        Me.deluxeRoom_lbl.Name = "deluxeRoom_lbl"
        Me.deluxeRoom_lbl.Size = New System.Drawing.Size(74, 13)
        Me.deluxeRoom_lbl.TabIndex = 82
        Me.deluxeRoom_lbl.Text = "Deluxe Room:"
        '
        'standardRoom_lbl
        '
        Me.standardRoom_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.standardRoom_lbl.AutoSize = True
        Me.standardRoom_lbl.Location = New System.Drawing.Point(27, 224)
        Me.standardRoom_lbl.Name = "standardRoom_lbl"
        Me.standardRoom_lbl.Size = New System.Drawing.Size(84, 13)
        Me.standardRoom_lbl.TabIndex = 80
        Me.standardRoom_lbl.Text = "Standard Room:"
        '
        'rdt_lbl
        '
        Me.rdt_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdt_lbl.AutoSize = True
        Me.rdt_lbl.Location = New System.Drawing.Point(27, 200)
        Me.rdt_lbl.Name = "rdt_lbl"
        Me.rdt_lbl.Size = New System.Drawing.Size(79, 13)
        Me.rdt_lbl.TabIndex = 78
        Me.rdt_lbl.Text = "Check-In Date:"
        '
        'roomReservation_lbl
        '
        Me.roomReservation_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roomReservation_lbl.AutoSize = True
        Me.roomReservation_lbl.Location = New System.Drawing.Point(27, 174)
        Me.roomReservation_lbl.Name = "roomReservation_lbl"
        Me.roomReservation_lbl.Size = New System.Drawing.Size(112, 13)
        Me.roomReservation_lbl.TabIndex = 77
        Me.roomReservation_lbl.Text = "Room Reservation ID:"
        '
        'paymentID_lbl
        '
        Me.paymentID_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paymentID_lbl.AutoSize = True
        Me.paymentID_lbl.Location = New System.Drawing.Point(27, 123)
        Me.paymentID_lbl.Name = "paymentID_lbl"
        Me.paymentID_lbl.Size = New System.Drawing.Size(65, 13)
        Me.paymentID_lbl.TabIndex = 76
        Me.paymentID_lbl.Text = "Payment ID:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 15)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Total Amount Paid:"
        '
        'totalamountP_txt
        '
        Me.totalamountP_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totalamountP_txt.Enabled = False
        Me.totalamountP_txt.Location = New System.Drawing.Point(486, 299)
        Me.totalamountP_txt.Name = "totalamountP_txt"
        Me.totalamountP_txt.Size = New System.Drawing.Size(158, 20)
        Me.totalamountP_txt.TabIndex = 102
        '
        'additionalpayment_lbl
        '
        Me.additionalpayment_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.additionalpayment_lbl.AutoSize = True
        Me.additionalpayment_lbl.Location = New System.Drawing.Point(359, 223)
        Me.additionalpayment_lbl.Name = "additionalpayment_lbl"
        Me.additionalpayment_lbl.Size = New System.Drawing.Size(100, 13)
        Me.additionalpayment_lbl.TabIndex = 103
        Me.additionalpayment_lbl.Text = "Additional Payment:"
        '
        'repaymentP_lbl
        '
        Me.repaymentP_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.repaymentP_lbl.AutoSize = True
        Me.repaymentP_lbl.Location = New System.Drawing.Point(359, 248)
        Me.repaymentP_lbl.Name = "repaymentP_lbl"
        Me.repaymentP_lbl.Size = New System.Drawing.Size(64, 13)
        Me.repaymentP_lbl.TabIndex = 104
        Me.repaymentP_lbl.Text = "Repayment:"
        '
        'additionalpaymentP_txt
        '
        Me.additionalpaymentP_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.additionalpaymentP_txt.Enabled = False
        Me.additionalpaymentP_txt.Location = New System.Drawing.Point(486, 220)
        Me.additionalpaymentP_txt.Name = "additionalpaymentP_txt"
        Me.additionalpaymentP_txt.Size = New System.Drawing.Size(158, 20)
        Me.additionalpaymentP_txt.TabIndex = 105
        '
        'repaymentP_txt
        '
        Me.repaymentP_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.repaymentP_txt.Enabled = False
        Me.repaymentP_txt.Location = New System.Drawing.Point(486, 248)
        Me.repaymentP_txt.Name = "repaymentP_txt"
        Me.repaymentP_txt.Size = New System.Drawing.Size(158, 20)
        Me.repaymentP_txt.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Check-In ID:"
        '
        'CheckinidP_CB
        '
        Me.CheckinidP_CB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckinidP_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CheckinidP_CB.FormattingEnabled = True
        Me.CheckinidP_CB.Location = New System.Drawing.Point(206, 143)
        Me.CheckinidP_CB.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckinidP_CB.Name = "CheckinidP_CB"
        Me.CheckinidP_CB.Size = New System.Drawing.Size(118, 21)
        Me.CheckinidP_CB.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "CI"
        '
        'reservationidP_txt
        '
        Me.reservationidP_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.reservationidP_txt.Enabled = False
        Me.reservationidP_txt.Location = New System.Drawing.Point(206, 171)
        Me.reservationidP_txt.Name = "reservationidP_txt"
        Me.reservationidP_txt.Size = New System.Drawing.Size(118, 20)
        Me.reservationidP_txt.TabIndex = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.CheckOut_RB)
        Me.GroupBox1.Controls.Add(Me.checkin_RB)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 40)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Type"
        '
        'CheckOut_RB
        '
        Me.CheckOut_RB.AutoSize = True
        Me.CheckOut_RB.Location = New System.Drawing.Point(113, 19)
        Me.CheckOut_RB.Name = "CheckOut_RB"
        Me.CheckOut_RB.Size = New System.Drawing.Size(76, 17)
        Me.CheckOut_RB.TabIndex = 114
        Me.CheckOut_RB.TabStop = True
        Me.CheckOut_RB.Text = "Check-Out"
        Me.CheckOut_RB.UseVisualStyleBackColor = True
        '
        'checkin_RB
        '
        Me.checkin_RB.AutoSize = True
        Me.checkin_RB.Location = New System.Drawing.Point(11, 19)
        Me.checkin_RB.Name = "checkin_RB"
        Me.checkin_RB.Size = New System.Drawing.Size(68, 17)
        Me.checkin_RB.TabIndex = 113
        Me.checkin_RB.TabStop = True
        Me.checkin_RB.Text = "Check-In"
        Me.checkin_RB.UseVisualStyleBackColor = True
        '
        'AddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.reservationidP_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckinidP_CB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.repaymentP_txt)
        Me.Controls.Add(Me.additionalpaymentP_txt)
        Me.Controls.Add(Me.repaymentP_lbl)
        Me.Controls.Add(Me.additionalpayment_lbl)
        Me.Controls.Add(Me.totalamountP_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deposit_txt)
        Me.Controls.Add(Me.deposit_lbl)
        Me.Controls.Add(Me.RR_lbl)
        Me.Controls.Add(Me.P_lbl)
        Me.Controls.Add(Me.ICNumber_txt)
        Me.Controls.Add(Me.customerName_txt)
        Me.Controls.Add(Me.cPhoneNumber_txt)
        Me.Controls.Add(Me.ICNumber_lbl)
        Me.Controls.Add(Me.cPhoneNumber_lbl)
        Me.Controls.Add(Me.customerName_lbl)
        Me.Controls.Add(Me.totalPrice_txt)
        Me.Controls.Add(Me.paymentID_txt)
        Me.Controls.Add(Me.superiorRoom_txt)
        Me.Controls.Add(Me.deluxeRoom_txt)
        Me.Controls.Add(Me.standardRoom_txt)
        Me.Controls.Add(Me.rdt_txt)
        Me.Controls.Add(Me.addGroup_btn)
        Me.Controls.Add(Me.totalPrice_lbl)
        Me.Controls.Add(Me.superiorRoom_lbl)
        Me.Controls.Add(Me.deluxeRoom_lbl)
        Me.Controls.Add(Me.standardRoom_lbl)
        Me.Controls.Add(Me.rdt_lbl)
        Me.Controls.Add(Me.roomReservation_lbl)
        Me.Controls.Add(Me.paymentID_lbl)
        Me.Controls.Add(Me.close_btn)
        Me.MaximizeBox = False
        Me.Name = "AddPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPayment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents deposit_txt As System.Windows.Forms.TextBox
    Friend WithEvents deposit_lbl As System.Windows.Forms.Label
    Friend WithEvents RR_lbl As System.Windows.Forms.Label
    Friend WithEvents P_lbl As System.Windows.Forms.Label
    Friend WithEvents ICNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_txt As System.Windows.Forms.TextBox
    Friend WithEvents cPhoneNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents ICNumber_lbl As System.Windows.Forms.Label
    Friend WithEvents cPhoneNumber_lbl As System.Windows.Forms.Label
    Friend WithEvents customerName_lbl As System.Windows.Forms.Label
    Friend WithEvents totalPrice_txt As System.Windows.Forms.TextBox
    Friend WithEvents paymentID_txt As System.Windows.Forms.TextBox
    Friend WithEvents superiorRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents deluxeRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents standardRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents rdt_txt As System.Windows.Forms.TextBox
    Friend WithEvents addGroup_btn As System.Windows.Forms.Button
    Friend WithEvents totalPrice_lbl As System.Windows.Forms.Label
    Friend WithEvents superiorRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents deluxeRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents standardRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents rdt_lbl As System.Windows.Forms.Label
    Friend WithEvents roomReservation_lbl As System.Windows.Forms.Label
    Friend WithEvents paymentID_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalamountP_txt As System.Windows.Forms.TextBox
    Friend WithEvents additionalpayment_lbl As System.Windows.Forms.Label
    Friend WithEvents repaymentP_lbl As System.Windows.Forms.Label
    Friend WithEvents additionalpaymentP_txt As System.Windows.Forms.TextBox
    Friend WithEvents repaymentP_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckinidP_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents reservationidP_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckOut_RB As System.Windows.Forms.RadioButton
    Friend WithEvents checkin_RB As System.Windows.Forms.RadioButton
End Class
