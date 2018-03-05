<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddPaymentRM
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FnSID_CB = New System.Windows.Forms.ComboBox()
        Me.bookDatenTime_txt = New System.Windows.Forms.TextBox()
        Me.customerNameFnS_txt = New System.Windows.Forms.TextBox()
        Me.chargesFee_txt = New System.Windows.Forms.TextBox()
        Me.bookDatenTime_lbl = New System.Windows.Forms.Label()
        Me.chargesFee_lbl = New System.Windows.Forms.Label()
        Me.customerNameFnS_lbl = New System.Windows.Forms.Label()
        Me.paymentFnSID_txt = New System.Windows.Forms.TextBox()
        Me.roomIDFnS_txt = New System.Windows.Forms.TextBox()
        Me.nameFnS_txt = New System.Windows.Forms.TextBox()
        Me.type_txt = New System.Windows.Forms.TextBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.roomIDFnS_lbl = New System.Windows.Forms.Label()
        Me.nameFnS_lbl = New System.Windows.Forms.Label()
        Me.typeFnS_lbl = New System.Windows.Forms.Label()
        Me.FnSID_lbl = New System.Windows.Forms.Label()
        Me.paymentFnSID_lbl = New System.Windows.Forms.Label()
        Me.paymentID_lbl = New System.Windows.Forms.Label()
        Me.roomReservation_lbl = New System.Windows.Forms.Label()
        Me.rdt_lbl = New System.Windows.Forms.Label()
        Me.standardRoom_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_lbl = New System.Windows.Forms.Label()
        Me.superiorRoom_lbl = New System.Windows.Forms.Label()
        Me.totalPrice_lbl = New System.Windows.Forms.Label()
        Me.addGroup_btn = New System.Windows.Forms.Button()
        Me.rdt_txt = New System.Windows.Forms.TextBox()
        Me.standardRoom_txt = New System.Windows.Forms.TextBox()
        Me.deluxeRoom_txt = New System.Windows.Forms.TextBox()
        Me.superiorRoom_txt = New System.Windows.Forms.TextBox()
        Me.paymentID_txt = New System.Windows.Forms.TextBox()
        Me.totalPrice_txt = New System.Windows.Forms.TextBox()
        Me.customerName_lbl = New System.Windows.Forms.Label()
        Me.cPhoneNumber_lbl = New System.Windows.Forms.Label()
        Me.ICNumber_lbl = New System.Windows.Forms.Label()
        Me.cPhoneNumber_txt = New System.Windows.Forms.TextBox()
        Me.customerName_txt = New System.Windows.Forms.TextBox()
        Me.ICNumber_txt = New System.Windows.Forms.TextBox()
        Me.roomReservation_cbbox = New System.Windows.Forms.ComboBox()
        Me.P_lbl = New System.Windows.Forms.Label()
        Me.RR_lbl = New System.Windows.Forms.Label()
        Me.deposit_lbl = New System.Windows.Forms.Label()
        Me.deposit_txt = New System.Windows.Forms.TextBox()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(637, 364)
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
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.TabPage1)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(1, 91)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(682, 268)
        Me.RFTabControl.TabIndex = 43
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(674, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Room reservation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.FnSID_CB)
        Me.GroupBox1.Controls.Add(Me.bookDatenTime_txt)
        Me.GroupBox1.Controls.Add(Me.customerNameFnS_txt)
        Me.GroupBox1.Controls.Add(Me.chargesFee_txt)
        Me.GroupBox1.Controls.Add(Me.bookDatenTime_lbl)
        Me.GroupBox1.Controls.Add(Me.chargesFee_lbl)
        Me.GroupBox1.Controls.Add(Me.customerNameFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.paymentFnSID_txt)
        Me.GroupBox1.Controls.Add(Me.roomIDFnS_txt)
        Me.GroupBox1.Controls.Add(Me.nameFnS_txt)
        Me.GroupBox1.Controls.Add(Me.type_txt)
        Me.GroupBox1.Controls.Add(Me.add_btn)
        Me.GroupBox1.Controls.Add(Me.roomIDFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.nameFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.typeFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.FnSID_lbl)
        Me.GroupBox1.Controls.Add(Me.paymentFnSID_lbl)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(666, 234)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facilities and Services Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "RR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "P"
        '
        'FnSID_CB
        '
        Me.FnSID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FnSID_CB.FormattingEnabled = True
        Me.FnSID_CB.Location = New System.Drawing.Point(190, 60)
        Me.FnSID_CB.Margin = New System.Windows.Forms.Padding(2)
        Me.FnSID_CB.Name = "FnSID_CB"
        Me.FnSID_CB.Size = New System.Drawing.Size(118, 21)
        Me.FnSID_CB.TabIndex = 69
        '
        'bookDatenTime_txt
        '
        Me.bookDatenTime_txt.Enabled = False
        Me.bookDatenTime_txt.Location = New System.Drawing.Point(472, 84)
        Me.bookDatenTime_txt.Name = "bookDatenTime_txt"
        Me.bookDatenTime_txt.Size = New System.Drawing.Size(158, 20)
        Me.bookDatenTime_txt.TabIndex = 68
        '
        'customerNameFnS_txt
        '
        Me.customerNameFnS_txt.Enabled = False
        Me.customerNameFnS_txt.Location = New System.Drawing.Point(472, 36)
        Me.customerNameFnS_txt.Name = "customerNameFnS_txt"
        Me.customerNameFnS_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerNameFnS_txt.TabIndex = 67
        '
        'chargesFee_txt
        '
        Me.chargesFee_txt.Enabled = False
        Me.chargesFee_txt.Location = New System.Drawing.Point(472, 60)
        Me.chargesFee_txt.Name = "chargesFee_txt"
        Me.chargesFee_txt.Size = New System.Drawing.Size(158, 20)
        Me.chargesFee_txt.TabIndex = 66
        '
        'bookDatenTime_lbl
        '
        Me.bookDatenTime_lbl.AutoSize = True
        Me.bookDatenTime_lbl.Location = New System.Drawing.Point(345, 86)
        Me.bookDatenTime_lbl.Name = "bookDatenTime_lbl"
        Me.bookDatenTime_lbl.Size = New System.Drawing.Size(108, 13)
        Me.bookDatenTime_lbl.TabIndex = 63
        Me.bookDatenTime_lbl.Text = "Book Date and Time:"
        '
        'chargesFee_lbl
        '
        Me.chargesFee_lbl.AutoSize = True
        Me.chargesFee_lbl.Location = New System.Drawing.Point(344, 63)
        Me.chargesFee_lbl.Name = "chargesFee_lbl"
        Me.chargesFee_lbl.Size = New System.Drawing.Size(70, 13)
        Me.chargesFee_lbl.TabIndex = 62
        Me.chargesFee_lbl.Text = "Charges Fee:"
        '
        'customerNameFnS_lbl
        '
        Me.customerNameFnS_lbl.AutoSize = True
        Me.customerNameFnS_lbl.Location = New System.Drawing.Point(344, 38)
        Me.customerNameFnS_lbl.Name = "customerNameFnS_lbl"
        Me.customerNameFnS_lbl.Size = New System.Drawing.Size(85, 13)
        Me.customerNameFnS_lbl.TabIndex = 61
        Me.customerNameFnS_lbl.Text = "Customer Name:"
        '
        'paymentFnSID_txt
        '
        Me.paymentFnSID_txt.Enabled = False
        Me.paymentFnSID_txt.Location = New System.Drawing.Point(190, 35)
        Me.paymentFnSID_txt.Name = "paymentFnSID_txt"
        Me.paymentFnSID_txt.Size = New System.Drawing.Size(118, 20)
        Me.paymentFnSID_txt.TabIndex = 52
        '
        'roomIDFnS_txt
        '
        Me.roomIDFnS_txt.Enabled = False
        Me.roomIDFnS_txt.Location = New System.Drawing.Point(165, 136)
        Me.roomIDFnS_txt.Name = "roomIDFnS_txt"
        Me.roomIDFnS_txt.Size = New System.Drawing.Size(151, 20)
        Me.roomIDFnS_txt.TabIndex = 49
        '
        'nameFnS_txt
        '
        Me.nameFnS_txt.Enabled = False
        Me.nameFnS_txt.Location = New System.Drawing.Point(165, 110)
        Me.nameFnS_txt.Name = "nameFnS_txt"
        Me.nameFnS_txt.Size = New System.Drawing.Size(151, 20)
        Me.nameFnS_txt.TabIndex = 47
        '
        'type_txt
        '
        Me.type_txt.Enabled = False
        Me.type_txt.Location = New System.Drawing.Point(165, 85)
        Me.type_txt.Name = "type_txt"
        Me.type_txt.Size = New System.Drawing.Size(151, 20)
        Me.type_txt.TabIndex = 45
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(443, 182)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 55
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'roomIDFnS_lbl
        '
        Me.roomIDFnS_lbl.AutoSize = True
        Me.roomIDFnS_lbl.Location = New System.Drawing.Point(13, 139)
        Me.roomIDFnS_lbl.Name = "roomIDFnS_lbl"
        Me.roomIDFnS_lbl.Size = New System.Drawing.Size(52, 13)
        Me.roomIDFnS_lbl.TabIndex = 48
        Me.roomIDFnS_lbl.Text = "Room ID:"
        '
        'nameFnS_lbl
        '
        Me.nameFnS_lbl.AutoSize = True
        Me.nameFnS_lbl.Location = New System.Drawing.Point(13, 113)
        Me.nameFnS_lbl.Name = "nameFnS_lbl"
        Me.nameFnS_lbl.Size = New System.Drawing.Size(146, 13)
        Me.nameFnS_lbl.TabIndex = 46
        Me.nameFnS_lbl.Text = "Facilities and Services Name:"
        '
        'typeFnS_lbl
        '
        Me.typeFnS_lbl.AutoSize = True
        Me.typeFnS_lbl.Location = New System.Drawing.Point(13, 89)
        Me.typeFnS_lbl.Name = "typeFnS_lbl"
        Me.typeFnS_lbl.Size = New System.Drawing.Size(142, 13)
        Me.typeFnS_lbl.TabIndex = 44
        Me.typeFnS_lbl.Text = "Facilities and Services Type:"
        '
        'FnSID_lbl
        '
        Me.FnSID_lbl.AutoSize = True
        Me.FnSID_lbl.Location = New System.Drawing.Point(13, 65)
        Me.FnSID_lbl.Name = "FnSID_lbl"
        Me.FnSID_lbl.Size = New System.Drawing.Size(129, 13)
        Me.FnSID_lbl.TabIndex = 43
        Me.FnSID_lbl.Text = "Facilities and Services ID:"
        '
        'paymentFnSID_lbl
        '
        Me.paymentFnSID_lbl.AutoSize = True
        Me.paymentFnSID_lbl.Location = New System.Drawing.Point(13, 38)
        Me.paymentFnSID_lbl.Name = "paymentFnSID_lbl"
        Me.paymentFnSID_lbl.Size = New System.Drawing.Size(65, 13)
        Me.paymentFnSID_lbl.TabIndex = 42
        Me.paymentFnSID_lbl.Text = "Payment ID:"
        '
        'paymentID_lbl
        '
        Me.paymentID_lbl.AutoSize = True
        Me.paymentID_lbl.Location = New System.Drawing.Point(13, 38)
        Me.paymentID_lbl.Name = "paymentID_lbl"
        Me.paymentID_lbl.Size = New System.Drawing.Size(65, 13)
        Me.paymentID_lbl.TabIndex = 42
        '
        'roomReservation_lbl
        '
        Me.roomReservation_lbl.AutoSize = True
        Me.roomReservation_lbl.Location = New System.Drawing.Point(13, 65)
        Me.roomReservation_lbl.Name = "roomReservation_lbl"
        Me.roomReservation_lbl.Size = New System.Drawing.Size(112, 13)
        Me.roomReservation_lbl.TabIndex = 43
        '
        'rdt_lbl
        '
        Me.rdt_lbl.AutoSize = True
        Me.rdt_lbl.Location = New System.Drawing.Point(13, 89)
        Me.rdt_lbl.Name = "rdt_lbl"
        Me.rdt_lbl.Size = New System.Drawing.Size(140, 13)
        Me.rdt_lbl.TabIndex = 44
        '
        'standardRoom_lbl
        '
        Me.standardRoom_lbl.AutoSize = True
        Me.standardRoom_lbl.Location = New System.Drawing.Point(13, 113)
        Me.standardRoom_lbl.Name = "standardRoom_lbl"
        Me.standardRoom_lbl.Size = New System.Drawing.Size(84, 13)
        Me.standardRoom_lbl.TabIndex = 46
        '
        'deluxeRoom_lbl
        '
        Me.deluxeRoom_lbl.AutoSize = True
        Me.deluxeRoom_lbl.Location = New System.Drawing.Point(13, 137)
        Me.deluxeRoom_lbl.Name = "deluxeRoom_lbl"
        Me.deluxeRoom_lbl.Size = New System.Drawing.Size(74, 13)
        Me.deluxeRoom_lbl.TabIndex = 48
        '
        'superiorRoom_lbl
        '
        Me.superiorRoom_lbl.AutoSize = True
        Me.superiorRoom_lbl.Location = New System.Drawing.Point(13, 162)
        Me.superiorRoom_lbl.Name = "superiorRoom_lbl"
        Me.superiorRoom_lbl.Size = New System.Drawing.Size(80, 13)
        Me.superiorRoom_lbl.TabIndex = 50
        '
        'totalPrice_lbl
        '
        Me.totalPrice_lbl.AutoSize = True
        Me.totalPrice_lbl.Location = New System.Drawing.Point(13, 187)
        Me.totalPrice_lbl.Name = "totalPrice_lbl"
        Me.totalPrice_lbl.Size = New System.Drawing.Size(61, 13)
        Me.totalPrice_lbl.TabIndex = 53
        '
        'addGroup_btn
        '
        Me.addGroup_btn.Location = New System.Drawing.Point(443, 182)
        Me.addGroup_btn.Name = "addGroup_btn"
        Me.addGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.addGroup_btn.TabIndex = 55
        Me.addGroup_btn.Text = "Add"
        Me.addGroup_btn.UseVisualStyleBackColor = True
        '
        'rdt_txt
        '
        Me.rdt_txt.Enabled = False
        Me.rdt_txt.Location = New System.Drawing.Point(159, 85)
        Me.rdt_txt.Name = "rdt_txt"
        Me.rdt_txt.Size = New System.Drawing.Size(151, 20)
        Me.rdt_txt.TabIndex = 45
        '
        'standardRoom_txt
        '
        Me.standardRoom_txt.Enabled = False
        Me.standardRoom_txt.Location = New System.Drawing.Point(159, 110)
        Me.standardRoom_txt.Name = "standardRoom_txt"
        Me.standardRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.standardRoom_txt.TabIndex = 47
        '
        'deluxeRoom_txt
        '
        Me.deluxeRoom_txt.Enabled = False
        Me.deluxeRoom_txt.Location = New System.Drawing.Point(159, 134)
        Me.deluxeRoom_txt.Name = "deluxeRoom_txt"
        Me.deluxeRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.deluxeRoom_txt.TabIndex = 49
        '
        'superiorRoom_txt
        '
        Me.superiorRoom_txt.Enabled = False
        Me.superiorRoom_txt.Location = New System.Drawing.Point(159, 159)
        Me.superiorRoom_txt.Name = "superiorRoom_txt"
        Me.superiorRoom_txt.Size = New System.Drawing.Size(151, 20)
        Me.superiorRoom_txt.TabIndex = 51
        '
        'paymentID_txt
        '
        Me.paymentID_txt.Enabled = False
        Me.paymentID_txt.Location = New System.Drawing.Point(192, 34)
        Me.paymentID_txt.Name = "paymentID_txt"
        Me.paymentID_txt.Size = New System.Drawing.Size(118, 20)
        Me.paymentID_txt.TabIndex = 52
        '
        'totalPrice_txt
        '
        Me.totalPrice_txt.Enabled = False
        Me.totalPrice_txt.Location = New System.Drawing.Point(159, 184)
        Me.totalPrice_txt.Name = "totalPrice_txt"
        Me.totalPrice_txt.Size = New System.Drawing.Size(151, 20)
        Me.totalPrice_txt.TabIndex = 58
        '
        'customerName_lbl
        '
        Me.customerName_lbl.AutoSize = True
        Me.customerName_lbl.Location = New System.Drawing.Point(344, 38)
        Me.customerName_lbl.Name = "customerName_lbl"
        Me.customerName_lbl.Size = New System.Drawing.Size(85, 13)
        Me.customerName_lbl.TabIndex = 61
        '
        'cPhoneNumber_lbl
        '
        Me.cPhoneNumber_lbl.AutoSize = True
        Me.cPhoneNumber_lbl.Location = New System.Drawing.Point(344, 63)
        Me.cPhoneNumber_lbl.Name = "cPhoneNumber_lbl"
        Me.cPhoneNumber_lbl.Size = New System.Drawing.Size(128, 13)
        Me.cPhoneNumber_lbl.TabIndex = 62
        '
        'ICNumber_lbl
        '
        Me.ICNumber_lbl.AutoSize = True
        Me.ICNumber_lbl.Location = New System.Drawing.Point(345, 86)
        Me.ICNumber_lbl.Name = "ICNumber_lbl"
        Me.ICNumber_lbl.Size = New System.Drawing.Size(65, 13)
        Me.ICNumber_lbl.TabIndex = 63
        '
        'cPhoneNumber_txt
        '
        Me.cPhoneNumber_txt.Enabled = False
        Me.cPhoneNumber_txt.Location = New System.Drawing.Point(472, 60)
        Me.cPhoneNumber_txt.Name = "cPhoneNumber_txt"
        Me.cPhoneNumber_txt.Size = New System.Drawing.Size(158, 20)
        Me.cPhoneNumber_txt.TabIndex = 66
        '
        'customerName_txt
        '
        Me.customerName_txt.Enabled = False
        Me.customerName_txt.Location = New System.Drawing.Point(472, 36)
        Me.customerName_txt.Name = "customerName_txt"
        Me.customerName_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerName_txt.TabIndex = 67
        '
        'ICNumber_txt
        '
        Me.ICNumber_txt.Enabled = False
        Me.ICNumber_txt.Location = New System.Drawing.Point(472, 84)
        Me.ICNumber_txt.Name = "ICNumber_txt"
        Me.ICNumber_txt.Size = New System.Drawing.Size(158, 20)
        Me.ICNumber_txt.TabIndex = 68
        '
        'roomReservation_cbbox
        '
        Me.roomReservation_cbbox.FormattingEnabled = True
        Me.roomReservation_cbbox.Location = New System.Drawing.Point(192, 59)
        Me.roomReservation_cbbox.Margin = New System.Windows.Forms.Padding(2)
        Me.roomReservation_cbbox.Name = "roomReservation_cbbox"
        Me.roomReservation_cbbox.Size = New System.Drawing.Size(118, 21)
        Me.roomReservation_cbbox.TabIndex = 69
        '
        'P_lbl
        '
        Me.P_lbl.AutoSize = True
        Me.P_lbl.Location = New System.Drawing.Point(159, 38)
        Me.P_lbl.Name = "P_lbl"
        Me.P_lbl.Size = New System.Drawing.Size(14, 13)
        Me.P_lbl.TabIndex = 70
        '
        'RR_lbl
        '
        Me.RR_lbl.AutoSize = True
        Me.RR_lbl.Location = New System.Drawing.Point(159, 65)
        Me.RR_lbl.Name = "RR_lbl"
        Me.RR_lbl.Size = New System.Drawing.Size(23, 13)
        Me.RR_lbl.TabIndex = 71
        '
        'deposit_lbl
        '
        Me.deposit_lbl.AutoSize = True
        Me.deposit_lbl.Location = New System.Drawing.Point(345, 113)
        Me.deposit_lbl.Name = "deposit_lbl"
        Me.deposit_lbl.Size = New System.Drawing.Size(46, 13)
        Me.deposit_lbl.TabIndex = 74
        '
        'deposit_txt
        '
        Me.deposit_txt.Location = New System.Drawing.Point(472, 110)
        Me.deposit_txt.Name = "deposit_txt"
        Me.deposit_txt.Size = New System.Drawing.Size(158, 20)
        Me.deposit_txt.TabIndex = 75
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(683, 25)
        Me.MaterialTabSelector1.TabIndex = 44
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'AddPaymentRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(683, 399)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Controls.Add(Me.close_btn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(683, 546)
        Me.MinimumSize = New System.Drawing.Size(682, 378)
        Me.Name = "AddPaymentRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Management Payment"
        Me.RFTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FnSID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents bookDatenTime_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerNameFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents chargesFee_txt As System.Windows.Forms.TextBox
    Friend WithEvents bookDatenTime_lbl As System.Windows.Forms.Label
    Friend WithEvents chargesFee_lbl As System.Windows.Forms.Label
    Friend WithEvents customerNameFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents paymentFnSID_txt As System.Windows.Forms.TextBox
    Friend WithEvents roomIDFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents nameFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents type_txt As System.Windows.Forms.TextBox
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents roomIDFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents nameFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents typeFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents FnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents paymentFnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents paymentID_lbl As System.Windows.Forms.Label
    Friend WithEvents roomReservation_lbl As System.Windows.Forms.Label
    Friend WithEvents rdt_lbl As System.Windows.Forms.Label
    Friend WithEvents standardRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents deluxeRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents superiorRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents totalPrice_lbl As System.Windows.Forms.Label
    Friend WithEvents addGroup_btn As System.Windows.Forms.Button
    Friend WithEvents rdt_txt As System.Windows.Forms.TextBox
    Friend WithEvents standardRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents deluxeRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents superiorRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents paymentID_txt As System.Windows.Forms.TextBox
    Friend WithEvents totalPrice_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_lbl As System.Windows.Forms.Label
    Friend WithEvents cPhoneNumber_lbl As System.Windows.Forms.Label
    Friend WithEvents ICNumber_lbl As System.Windows.Forms.Label
    Friend WithEvents cPhoneNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_txt As System.Windows.Forms.TextBox
    Friend WithEvents ICNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents roomReservation_cbbox As System.Windows.Forms.ComboBox
    Friend WithEvents P_lbl As System.Windows.Forms.Label
    Friend WithEvents RR_lbl As System.Windows.Forms.Label
    Friend WithEvents deposit_lbl As System.Windows.Forms.Label
    Friend WithEvents deposit_txt As System.Windows.Forms.TextBox
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
End Class
