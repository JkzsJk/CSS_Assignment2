<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.reservation_tab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.todaydate_txt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.roomnoIndi_txt = New System.Windows.Forms.TextBox()
        Me.roomtypeIndi_txt = New System.Windows.Forms.TextBox()
        Me.checkinidIndi_CB = New System.Windows.Forms.ComboBox()
        Me.repaymentindi_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.extrachargesindi_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.depositpaidindi_txt = New System.Windows.Forms.TextBox()
        Me.checkoutindi_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_txt = New System.Windows.Forms.TextBox()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.roomNO_lbl = New System.Windows.Forms.Label()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.checkinID_lbl = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.checkOut_btn = New System.Windows.Forms.Button()
        Me.duration_txt = New System.Windows.Forms.TextBox()
        Me.duration_lbl = New System.Windows.Forms.Label()
        Me.phoneNO_txt = New System.Windows.Forms.TextBox()
        Me.phoneNO_lbl = New System.Windows.Forms.Label()
        Me.customerIC_txt = New System.Windows.Forms.TextBox()
        Me.customerIC_lbl = New System.Windows.Forms.Label()
        Me.customerName_txt = New System.Windows.Forms.TextBox()
        Me.customerName_lbl = New System.Windows.Forms.Label()
        Me.bookingPrice_lbl = New System.Windows.Forms.Label()
        Me.roomType_lbl = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.today_txt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.checkinidGroup_CB = New System.Windows.Forms.ComboBox()
        Me.Room_Number_CO = New System.Windows.Forms.ListBox()
        Me.repaymentgrp_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.extrachargesgrp_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.depositpaidgrp_txt = New System.Windows.Forms.TextBox()
        Me.checkoutidgrp_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.COdate_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.searchGroupCO_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.clearGroup_btn = New System.Windows.Forms.Button()
        Me.checkoutGroup_btn = New System.Windows.Forms.Button()
        Me.durationCO_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cusPNCO_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cusICCO_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cusNameCO_txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RFTabControl.SuspendLayout()
        Me.reservation_tab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 54)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(683, 25)
        Me.MaterialTabSelector1.TabIndex = 11
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.reservation_tab)
        Me.RFTabControl.Controls.Add(Me.TabPage1)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(0, 83)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(682, 270)
        Me.RFTabControl.TabIndex = 10
        '
        'reservation_tab
        '
        Me.reservation_tab.Controls.Add(Me.GroupBox1)
        Me.reservation_tab.Location = New System.Drawing.Point(4, 22)
        Me.reservation_tab.Margin = New System.Windows.Forms.Padding(2)
        Me.reservation_tab.Name = "reservation_tab"
        Me.reservation_tab.Padding = New System.Windows.Forms.Padding(2)
        Me.reservation_tab.Size = New System.Drawing.Size(674, 244)
        Me.reservation_tab.TabIndex = 0
        Me.reservation_tab.Text = "Individual"
        Me.reservation_tab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.todaydate_txt)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.roomnoIndi_txt)
        Me.GroupBox1.Controls.Add(Me.roomtypeIndi_txt)
        Me.GroupBox1.Controls.Add(Me.checkinidIndi_CB)
        Me.GroupBox1.Controls.Add(Me.repaymentindi_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.extrachargesindi_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.depositpaidindi_txt)
        Me.GroupBox1.Controls.Add(Me.checkoutindi_txt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.date_txt)
        Me.GroupBox1.Controls.Add(Me.date_lbl)
        Me.GroupBox1.Controls.Add(Me.roomNO_lbl)
        Me.GroupBox1.Controls.Add(Me.search_btn)
        Me.GroupBox1.Controls.Add(Me.checkinID_lbl)
        Me.GroupBox1.Controls.Add(Me.clear_btn)
        Me.GroupBox1.Controls.Add(Me.checkOut_btn)
        Me.GroupBox1.Controls.Add(Me.duration_txt)
        Me.GroupBox1.Controls.Add(Me.duration_lbl)
        Me.GroupBox1.Controls.Add(Me.phoneNO_txt)
        Me.GroupBox1.Controls.Add(Me.phoneNO_lbl)
        Me.GroupBox1.Controls.Add(Me.customerIC_txt)
        Me.GroupBox1.Controls.Add(Me.customerIC_lbl)
        Me.GroupBox1.Controls.Add(Me.customerName_txt)
        Me.GroupBox1.Controls.Add(Me.customerName_lbl)
        Me.GroupBox1.Controls.Add(Me.bookingPrice_lbl)
        Me.GroupBox1.Controls.Add(Me.roomType_lbl)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room"
        '
        'todaydate_txt
        '
        Me.todaydate_txt.Enabled = False
        Me.todaydate_txt.Location = New System.Drawing.Point(416, 125)
        Me.todaydate_txt.Name = "todaydate_txt"
        Me.todaydate_txt.Size = New System.Drawing.Size(158, 20)
        Me.todaydate_txt.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(329, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(112, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(108, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "CO"
        '
        'roomnoIndi_txt
        '
        Me.roomnoIndi_txt.Enabled = False
        Me.roomnoIndi_txt.Location = New System.Drawing.Point(137, 71)
        Me.roomnoIndi_txt.Name = "roomnoIndi_txt"
        Me.roomnoIndi_txt.Size = New System.Drawing.Size(114, 20)
        Me.roomnoIndi_txt.TabIndex = 51
        '
        'roomtypeIndi_txt
        '
        Me.roomtypeIndi_txt.Enabled = False
        Me.roomtypeIndi_txt.Location = New System.Drawing.Point(109, 43)
        Me.roomtypeIndi_txt.Name = "roomtypeIndi_txt"
        Me.roomtypeIndi_txt.Size = New System.Drawing.Size(142, 20)
        Me.roomtypeIndi_txt.TabIndex = 50
        '
        'checkinidIndi_CB
        '
        Me.checkinidIndi_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.checkinidIndi_CB.FormattingEnabled = True
        Me.checkinidIndi_CB.Location = New System.Drawing.Point(416, 13)
        Me.checkinidIndi_CB.Name = "checkinidIndi_CB"
        Me.checkinidIndi_CB.Size = New System.Drawing.Size(121, 21)
        Me.checkinidIndi_CB.TabIndex = 49
        '
        'repaymentindi_txt
        '
        Me.repaymentindi_txt.Location = New System.Drawing.Point(416, 95)
        Me.repaymentindi_txt.Name = "repaymentindi_txt"
        Me.repaymentindi_txt.Size = New System.Drawing.Size(158, 20)
        Me.repaymentindi_txt.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Repayment:"
        '
        'extrachargesindi_txt
        '
        Me.extrachargesindi_txt.Location = New System.Drawing.Point(416, 69)
        Me.extrachargesindi_txt.Name = "extrachargesindi_txt"
        Me.extrachargesindi_txt.Size = New System.Drawing.Size(158, 20)
        Me.extrachargesindi_txt.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Extra Charges:"
        '
        'depositpaidindi_txt
        '
        Me.depositpaidindi_txt.Enabled = False
        Me.depositpaidindi_txt.Location = New System.Drawing.Point(416, 43)
        Me.depositpaidindi_txt.Name = "depositpaidindi_txt"
        Me.depositpaidindi_txt.Size = New System.Drawing.Size(158, 20)
        Me.depositpaidindi_txt.TabIndex = 44
        '
        'checkoutindi_txt
        '
        Me.checkoutindi_txt.Location = New System.Drawing.Point(137, 15)
        Me.checkoutindi_txt.Name = "checkoutindi_txt"
        Me.checkoutindi_txt.Size = New System.Drawing.Size(114, 20)
        Me.checkoutindi_txt.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Check-Out ID:"
        '
        'date_txt
        '
        Me.date_txt.Enabled = False
        Me.date_txt.Location = New System.Drawing.Point(109, 211)
        Me.date_txt.Name = "date_txt"
        Me.date_txt.Size = New System.Drawing.Size(158, 20)
        Me.date_txt.TabIndex = 41
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Location = New System.Drawing.Point(16, 214)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(91, 13)
        Me.date_lbl.TabIndex = 40
        Me.date_lbl.Text = "Checked-In Date:"
        '
        'roomNO_lbl
        '
        Me.roomNO_lbl.AutoSize = True
        Me.roomNO_lbl.Location = New System.Drawing.Point(16, 74)
        Me.roomNO_lbl.Name = "roomNO_lbl"
        Me.roomNO_lbl.Size = New System.Drawing.Size(78, 13)
        Me.roomNO_lbl.TabIndex = 38
        Me.roomNO_lbl.Text = "Room Number:"
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(564, 13)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(75, 23)
        Me.search_btn.TabIndex = 37
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'checkinID_lbl
        '
        Me.checkinID_lbl.AutoSize = True
        Me.checkinID_lbl.Location = New System.Drawing.Point(329, 18)
        Me.checkinID_lbl.Name = "checkinID_lbl"
        Me.checkinID_lbl.Size = New System.Drawing.Size(67, 13)
        Me.checkinID_lbl.TabIndex = 36
        Me.checkinID_lbl.Text = "Check-In ID:"
        '
        'clear_btn
        '
        Me.clear_btn.Location = New System.Drawing.Point(567, 202)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(75, 23)
        Me.clear_btn.TabIndex = 34
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'checkOut_btn
        '
        Me.checkOut_btn.Location = New System.Drawing.Point(472, 202)
        Me.checkOut_btn.Name = "checkOut_btn"
        Me.checkOut_btn.Size = New System.Drawing.Size(75, 23)
        Me.checkOut_btn.TabIndex = 33
        Me.checkOut_btn.Text = "Check-Out"
        Me.checkOut_btn.UseVisualStyleBackColor = True
        '
        'duration_txt
        '
        Me.duration_txt.Location = New System.Drawing.Point(109, 184)
        Me.duration_txt.Name = "duration_txt"
        Me.duration_txt.Size = New System.Drawing.Size(158, 20)
        Me.duration_txt.TabIndex = 32
        '
        'duration_lbl
        '
        Me.duration_lbl.AutoSize = True
        Me.duration_lbl.Location = New System.Drawing.Point(17, 187)
        Me.duration_lbl.Name = "duration_lbl"
        Me.duration_lbl.Size = New System.Drawing.Size(50, 13)
        Me.duration_lbl.TabIndex = 31
        Me.duration_lbl.Text = "Duration:"
        '
        'phoneNO_txt
        '
        Me.phoneNO_txt.Location = New System.Drawing.Point(109, 156)
        Me.phoneNO_txt.Name = "phoneNO_txt"
        Me.phoneNO_txt.Size = New System.Drawing.Size(158, 20)
        Me.phoneNO_txt.TabIndex = 30
        '
        'phoneNO_lbl
        '
        Me.phoneNO_lbl.AutoSize = True
        Me.phoneNO_lbl.Location = New System.Drawing.Point(16, 159)
        Me.phoneNO_lbl.Name = "phoneNO_lbl"
        Me.phoneNO_lbl.Size = New System.Drawing.Size(81, 13)
        Me.phoneNO_lbl.TabIndex = 29
        Me.phoneNO_lbl.Text = "Phone Number:"
        '
        'customerIC_txt
        '
        Me.customerIC_txt.Location = New System.Drawing.Point(109, 125)
        Me.customerIC_txt.Name = "customerIC_txt"
        Me.customerIC_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerIC_txt.TabIndex = 28
        '
        'customerIC_lbl
        '
        Me.customerIC_lbl.AutoSize = True
        Me.customerIC_lbl.Location = New System.Drawing.Point(17, 128)
        Me.customerIC_lbl.Name = "customerIC_lbl"
        Me.customerIC_lbl.Size = New System.Drawing.Size(79, 13)
        Me.customerIC_lbl.TabIndex = 27
        Me.customerIC_lbl.Text = "Customer's I/C:"
        '
        'customerName_txt
        '
        Me.customerName_txt.Location = New System.Drawing.Point(109, 95)
        Me.customerName_txt.Name = "customerName_txt"
        Me.customerName_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerName_txt.TabIndex = 26
        '
        'customerName_lbl
        '
        Me.customerName_lbl.AutoSize = True
        Me.customerName_lbl.Location = New System.Drawing.Point(16, 98)
        Me.customerName_lbl.Name = "customerName_lbl"
        Me.customerName_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerName_lbl.TabIndex = 25
        Me.customerName_lbl.Text = "Customer's Name:"
        '
        'bookingPrice_lbl
        '
        Me.bookingPrice_lbl.AutoSize = True
        Me.bookingPrice_lbl.Location = New System.Drawing.Point(329, 46)
        Me.bookingPrice_lbl.Name = "bookingPrice_lbl"
        Me.bookingPrice_lbl.Size = New System.Drawing.Size(70, 13)
        Me.bookingPrice_lbl.TabIndex = 23
        Me.bookingPrice_lbl.Text = "Deposit Paid:"
        '
        'roomType_lbl
        '
        Me.roomType_lbl.AutoSize = True
        Me.roomType_lbl.Location = New System.Drawing.Point(16, 45)
        Me.roomType_lbl.Name = "roomType_lbl"
        Me.roomType_lbl.Size = New System.Drawing.Size(65, 13)
        Me.roomType_lbl.TabIndex = 21
        Me.roomType_lbl.Text = "Room Type:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.today_txt)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.checkinidGroup_CB)
        Me.TabPage1.Controls.Add(Me.Room_Number_CO)
        Me.TabPage1.Controls.Add(Me.repaymentgrp_txt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.extrachargesgrp_txt)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.depositpaidgrp_txt)
        Me.TabPage1.Controls.Add(Me.checkoutidgrp_txt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.COdate_txt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.searchGroupCO_btn)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.clearGroup_btn)
        Me.TabPage1.Controls.Add(Me.checkoutGroup_btn)
        Me.TabPage1.Controls.Add(Me.durationCO_txt)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cusPNCO_txt)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cusICCO_txt)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cusNameCO_txt)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(674, 244)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Group"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'today_txt
        '
        Me.today_txt.Enabled = False
        Me.today_txt.Location = New System.Drawing.Point(424, 125)
        Me.today_txt.Name = "today_txt"
        Me.today_txt.Size = New System.Drawing.Size(158, 20)
        Me.today_txt.TabIndex = 80
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(337, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(116, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 13)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "CO"
        '
        'checkinidGroup_CB
        '
        Me.checkinidGroup_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.checkinidGroup_CB.FormattingEnabled = True
        Me.checkinidGroup_CB.Location = New System.Drawing.Point(424, 13)
        Me.checkinidGroup_CB.Name = "checkinidGroup_CB"
        Me.checkinidGroup_CB.Size = New System.Drawing.Size(121, 21)
        Me.checkinidGroup_CB.TabIndex = 77
        '
        'Room_Number_CO
        '
        Me.Room_Number_CO.Enabled = False
        Me.Room_Number_CO.FormattingEnabled = True
        Me.Room_Number_CO.Location = New System.Drawing.Point(117, 41)
        Me.Room_Number_CO.Name = "Room_Number_CO"
        Me.Room_Number_CO.Size = New System.Drawing.Size(154, 43)
        Me.Room_Number_CO.TabIndex = 76
        '
        'repaymentgrp_txt
        '
        Me.repaymentgrp_txt.Location = New System.Drawing.Point(424, 95)
        Me.repaymentgrp_txt.Name = "repaymentgrp_txt"
        Me.repaymentgrp_txt.Size = New System.Drawing.Size(158, 20)
        Me.repaymentgrp_txt.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Repayment:"
        '
        'extrachargesgrp_txt
        '
        Me.extrachargesgrp_txt.Location = New System.Drawing.Point(424, 69)
        Me.extrachargesgrp_txt.Name = "extrachargesgrp_txt"
        Me.extrachargesgrp_txt.Size = New System.Drawing.Size(158, 20)
        Me.extrachargesgrp_txt.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Extra Charges:"
        '
        'depositpaidgrp_txt
        '
        Me.depositpaidgrp_txt.Enabled = False
        Me.depositpaidgrp_txt.Location = New System.Drawing.Point(424, 43)
        Me.depositpaidgrp_txt.Name = "depositpaidgrp_txt"
        Me.depositpaidgrp_txt.Size = New System.Drawing.Size(158, 20)
        Me.depositpaidgrp_txt.TabIndex = 71
        '
        'checkoutidgrp_txt
        '
        Me.checkoutidgrp_txt.Location = New System.Drawing.Point(145, 15)
        Me.checkoutidgrp_txt.Name = "checkoutidgrp_txt"
        Me.checkoutidgrp_txt.Size = New System.Drawing.Size(114, 20)
        Me.checkoutidgrp_txt.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Check-Out ID:"
        '
        'COdate_txt
        '
        Me.COdate_txt.Enabled = False
        Me.COdate_txt.Location = New System.Drawing.Point(117, 211)
        Me.COdate_txt.Name = "COdate_txt"
        Me.COdate_txt.Size = New System.Drawing.Size(158, 20)
        Me.COdate_txt.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Checked-In Date:"
        '
        'searchGroupCO_btn
        '
        Me.searchGroupCO_btn.Location = New System.Drawing.Point(572, 13)
        Me.searchGroupCO_btn.Name = "searchGroupCO_btn"
        Me.searchGroupCO_btn.Size = New System.Drawing.Size(75, 23)
        Me.searchGroupCO_btn.TabIndex = 64
        Me.searchGroupCO_btn.Text = "Search"
        Me.searchGroupCO_btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(337, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Check-In ID:"
        '
        'clearGroup_btn
        '
        Me.clearGroup_btn.Location = New System.Drawing.Point(575, 202)
        Me.clearGroup_btn.Name = "clearGroup_btn"
        Me.clearGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearGroup_btn.TabIndex = 61
        Me.clearGroup_btn.Text = "Clear"
        Me.clearGroup_btn.UseVisualStyleBackColor = True
        '
        'checkoutGroup_btn
        '
        Me.checkoutGroup_btn.Location = New System.Drawing.Point(480, 202)
        Me.checkoutGroup_btn.Name = "checkoutGroup_btn"
        Me.checkoutGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.checkoutGroup_btn.TabIndex = 60
        Me.checkoutGroup_btn.Text = "Check-Out"
        Me.checkoutGroup_btn.UseVisualStyleBackColor = True
        '
        'durationCO_txt
        '
        Me.durationCO_txt.Location = New System.Drawing.Point(117, 184)
        Me.durationCO_txt.Name = "durationCO_txt"
        Me.durationCO_txt.Size = New System.Drawing.Size(158, 20)
        Me.durationCO_txt.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Duration:"
        '
        'cusPNCO_txt
        '
        Me.cusPNCO_txt.Location = New System.Drawing.Point(117, 156)
        Me.cusPNCO_txt.Name = "cusPNCO_txt"
        Me.cusPNCO_txt.Size = New System.Drawing.Size(158, 20)
        Me.cusPNCO_txt.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Phone Number:"
        '
        'cusICCO_txt
        '
        Me.cusICCO_txt.Location = New System.Drawing.Point(117, 125)
        Me.cusICCO_txt.Name = "cusICCO_txt"
        Me.cusICCO_txt.Size = New System.Drawing.Size(158, 20)
        Me.cusICCO_txt.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Customer's I/C:"
        '
        'cusNameCO_txt
        '
        Me.cusNameCO_txt.Location = New System.Drawing.Point(117, 95)
        Me.cusNameCO_txt.Name = "cusNameCO_txt"
        Me.cusNameCO_txt.Size = New System.Drawing.Size(158, 20)
        Me.cusNameCO_txt.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Customer's Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(337, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Deposit Paid:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Rooms list:"
        '
        'close_btn
        '
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(627, 368)
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
        'Timer1
        '
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 406)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.MaximizeBox = False
        Me.Name = "CheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Check-Out"
        Me.RFTabControl.ResumeLayout(False)
        Me.reservation_tab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents reservation_tab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents date_txt As System.Windows.Forms.TextBox
    Friend WithEvents date_lbl As System.Windows.Forms.Label
    Friend WithEvents roomNO_lbl As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents checkinID_lbl As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents checkOut_btn As System.Windows.Forms.Button
    Friend WithEvents duration_txt As System.Windows.Forms.TextBox
    Friend WithEvents duration_lbl As System.Windows.Forms.Label
    Friend WithEvents phoneNO_txt As System.Windows.Forms.TextBox
    Friend WithEvents phoneNO_lbl As System.Windows.Forms.Label
    Friend WithEvents customerIC_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerIC_lbl As System.Windows.Forms.Label
    Friend WithEvents customerName_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingPrice_lbl As System.Windows.Forms.Label
    Friend WithEvents roomType_lbl As System.Windows.Forms.Label
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents checkoutindi_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents depositpaidindi_txt As System.Windows.Forms.TextBox
    Friend WithEvents repaymentindi_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents extrachargesindi_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents repaymentgrp_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents extrachargesgrp_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents depositpaidgrp_txt As System.Windows.Forms.TextBox
    Friend WithEvents checkoutidgrp_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents COdate_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents searchGroupCO_btn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents clearGroup_btn As System.Windows.Forms.Button
    Friend WithEvents checkoutGroup_btn As System.Windows.Forms.Button
    Friend WithEvents durationCO_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cusPNCO_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cusICCO_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cusNameCO_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Room_Number_CO As System.Windows.Forms.ListBox
    Friend WithEvents checkinidIndi_CB As System.Windows.Forms.ComboBox
    Friend WithEvents checkinidGroup_CB As System.Windows.Forms.ComboBox
    Friend WithEvents roomnoIndi_txt As System.Windows.Forms.TextBox
    Friend WithEvents roomtypeIndi_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents todaydate_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents today_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
