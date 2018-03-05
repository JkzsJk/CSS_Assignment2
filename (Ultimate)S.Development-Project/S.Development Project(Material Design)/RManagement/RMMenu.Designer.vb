<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RMMenu
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
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.room_Tab = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.roomIndiviTab = New System.Windows.Forms.TabPage()
        Me.totalPrice_lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalPrice_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.depositIndivi_txt = New System.Windows.Forms.TextBox()
        Me.depositIndivi_lbl = New System.Windows.Forms.Label()
        Me.RMI_lbl = New System.Windows.Forms.Label()
        Me.bookingDateIndivi_txt = New System.Windows.Forms.TextBox()
        Me.RR_lbl = New System.Windows.Forms.Label()
        Me.reservDateIndivi_dtp = New System.Windows.Forms.DateTimePicker()
        Me.reservationIDIndivi_txt = New System.Windows.Forms.TextBox()
        Me.reservationIDIndivi_lbl = New System.Windows.Forms.Label()
        Me.reservDateInvidi_lbl = New System.Windows.Forms.Label()
        Me.priceIndivi_txt = New System.Windows.Forms.TextBox()
        Me.bookingDateIndivi_lbl = New System.Windows.Forms.Label()
        Me.clearIndivi_btn = New System.Windows.Forms.Button()
        Me.addIndivi_btn = New System.Windows.Forms.Button()
        Me.durationIndivi_txt = New System.Windows.Forms.TextBox()
        Me.durationIndivi_lbl = New System.Windows.Forms.Label()
        Me.phoneNOIndivi_txt = New System.Windows.Forms.TextBox()
        Me.phoneNOIndivi_lbl = New System.Windows.Forms.Label()
        Me.customerICIndivi_txt = New System.Windows.Forms.TextBox()
        Me.customerICIndivi_lbl = New System.Windows.Forms.Label()
        Me.customerNameIndivi_txt = New System.Windows.Forms.TextBox()
        Me.customerNameIndivi_lbl = New System.Windows.Forms.Label()
        Me.bookingPriceInvidi_lbl = New System.Windows.Forms.Label()
        Me.roomtype_CB = New System.Windows.Forms.ComboBox()
        Me.roomType_lbl = New System.Windows.Forms.Label()
        Me.roomGroupTab = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.depositGroup_txt = New System.Windows.Forms.TextBox()
        Me.depositGroup_lbl = New System.Windows.Forms.Label()
        Me.RMG_lbl = New System.Windows.Forms.Label()
        Me.durationGroup_txt = New System.Windows.Forms.TextBox()
        Me.durationGroup_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reservationIDGroup_txt = New System.Windows.Forms.TextBox()
        Me.reservationIDGroup_lbl = New System.Windows.Forms.Label()
        Me.reservDateGroup_dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phoneNOGroup_txt = New System.Windows.Forms.TextBox()
        Me.bookingDateGroup_lbl = New System.Windows.Forms.Label()
        Me.clearGroup_btn = New System.Windows.Forms.Button()
        Me.addGroup_btn = New System.Windows.Forms.Button()
        Me.bookingDateGroup_txt = New System.Windows.Forms.TextBox()
        Me.phoneGroup_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_txt = New System.Windows.Forms.TextBox()
        Me.standardRoom_txt = New System.Windows.Forms.TextBox()
        Me.customerICGroup_txt = New System.Windows.Forms.TextBox()
        Me.customerICGroup_lbl = New System.Windows.Forms.Label()
        Me.customerNameGroup_txt = New System.Windows.Forms.TextBox()
        Me.customerNameGroup_lbl = New System.Windows.Forms.Label()
        Me.bookingPriceGroup_txt = New System.Windows.Forms.TextBox()
        Me.bookingPriceGroup_lbl = New System.Windows.Forms.Label()
        Me.superiorRoom_txt = New System.Windows.Forms.TextBox()
        Me.superiorRoom_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_lbl = New System.Windows.Forms.Label()
        Me.standardRoom_lbl = New System.Windows.Forms.Label()
        Me.FnS_Tab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bookingDate_lbl = New System.Windows.Forms.Label()
        Me.bookingDate_txt = New System.Windows.Forms.TextBox()
        Me.customerName_txt = New System.Windows.Forms.TextBox()
        Me.customerName_lbl = New System.Windows.Forms.Label()
        Me.FS_lbl = New System.Windows.Forms.Label()
        Me.typeFnS_CB = New System.Windows.Forms.ComboBox()
        Me.FR_lbl = New System.Windows.Forms.Label()
        Me.reservID_txt = New System.Windows.Forms.TextBox()
        Me.nameFnS_CB = New System.Windows.Forms.ComboBox()
        Me.chargesFeesFnS_txt = New System.Windows.Forms.TextBox()
        Me.FnSID_txt = New System.Windows.Forms.TextBox()
        Me.reservID_lbl = New System.Windows.Forms.Label()
        Me.FnSID_lbl = New System.Windows.Forms.Label()
        Me.clearFnS_btn = New System.Windows.Forms.Button()
        Me.addFnS_btn = New System.Windows.Forms.Button()
        Me.typeFnS_lbl = New System.Windows.Forms.Label()
        Me.roomNOFnS_lbl = New System.Windows.Forms.Label()
        Me.roomNOFnS_CB = New System.Windows.Forms.ComboBox()
        Me.nameFnS_lbl = New System.Windows.Forms.Label()
        Me.chargesFeesFnS_lbl = New System.Windows.Forms.Label()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl.SuspendLayout()
        Me.room_Tab.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.roomIndiviTab.SuspendLayout()
        Me.roomGroupTab.SuspendLayout()
        Me.FnS_Tab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.room_Tab)
        Me.RFTabControl.Controls.Add(Me.FnS_Tab)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(0, 93)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(682, 270)
        Me.RFTabControl.TabIndex = 6
        '
        'room_Tab
        '
        Me.room_Tab.Controls.Add(Me.TabControl1)
        Me.room_Tab.Location = New System.Drawing.Point(4, 22)
        Me.room_Tab.Margin = New System.Windows.Forms.Padding(2)
        Me.room_Tab.Name = "room_Tab"
        Me.room_Tab.Padding = New System.Windows.Forms.Padding(2)
        Me.room_Tab.Size = New System.Drawing.Size(674, 244)
        Me.room_Tab.TabIndex = 0
        Me.room_Tab.Text = "Room"
        Me.room_Tab.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.roomIndiviTab)
        Me.TabControl1.Controls.Add(Me.roomGroupTab)
        Me.TabControl1.Location = New System.Drawing.Point(5, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(673, 248)
        Me.TabControl1.TabIndex = 0
        '
        'roomIndiviTab
        '
        Me.roomIndiviTab.Controls.Add(Me.totalPrice_lbl)
        Me.roomIndiviTab.Controls.Add(Me.Label5)
        Me.roomIndiviTab.Controls.Add(Me.totalPrice_txt)
        Me.roomIndiviTab.Controls.Add(Me.Label3)
        Me.roomIndiviTab.Controls.Add(Me.depositIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.depositIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.RMI_lbl)
        Me.roomIndiviTab.Controls.Add(Me.bookingDateIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.RR_lbl)
        Me.roomIndiviTab.Controls.Add(Me.reservDateIndivi_dtp)
        Me.roomIndiviTab.Controls.Add(Me.reservationIDIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.reservationIDIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.reservDateInvidi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.priceIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.bookingDateIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.clearIndivi_btn)
        Me.roomIndiviTab.Controls.Add(Me.addIndivi_btn)
        Me.roomIndiviTab.Controls.Add(Me.durationIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.durationIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.phoneNOIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.phoneNOIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.customerICIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.customerICIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.customerNameIndivi_txt)
        Me.roomIndiviTab.Controls.Add(Me.customerNameIndivi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.bookingPriceInvidi_lbl)
        Me.roomIndiviTab.Controls.Add(Me.roomtype_CB)
        Me.roomIndiviTab.Controls.Add(Me.roomType_lbl)
        Me.roomIndiviTab.Location = New System.Drawing.Point(4, 22)
        Me.roomIndiviTab.Name = "roomIndiviTab"
        Me.roomIndiviTab.Padding = New System.Windows.Forms.Padding(3)
        Me.roomIndiviTab.Size = New System.Drawing.Size(665, 222)
        Me.roomIndiviTab.TabIndex = 0
        Me.roomIndiviTab.Text = "Individual"
        Me.roomIndiviTab.UseVisualStyleBackColor = True
        '
        'totalPrice_lbl
        '
        Me.totalPrice_lbl.AutoSize = True
        Me.totalPrice_lbl.Location = New System.Drawing.Point(331, 115)
        Me.totalPrice_lbl.Name = "totalPrice_lbl"
        Me.totalPrice_lbl.Size = New System.Drawing.Size(61, 13)
        Me.totalPrice_lbl.TabIndex = 46
        Me.totalPrice_lbl.Text = "Total Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "RM"
        '
        'totalPrice_txt
        '
        Me.totalPrice_txt.Enabled = False
        Me.totalPrice_txt.Location = New System.Drawing.Point(456, 112)
        Me.totalPrice_txt.Name = "totalPrice_txt"
        Me.totalPrice_txt.Size = New System.Drawing.Size(132, 20)
        Me.totalPrice_txt.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "RM"
        '
        'depositIndivi_txt
        '
        Me.depositIndivi_txt.Location = New System.Drawing.Point(456, 61)
        Me.depositIndivi_txt.Name = "depositIndivi_txt"
        Me.depositIndivi_txt.Size = New System.Drawing.Size(132, 20)
        Me.depositIndivi_txt.TabIndex = 42
        '
        'depositIndivi_lbl
        '
        Me.depositIndivi_lbl.AutoSize = True
        Me.depositIndivi_lbl.Location = New System.Drawing.Point(331, 64)
        Me.depositIndivi_lbl.Name = "depositIndivi_lbl"
        Me.depositIndivi_lbl.Size = New System.Drawing.Size(46, 13)
        Me.depositIndivi_lbl.TabIndex = 41
        Me.depositIndivi_lbl.Text = "Deposit:"
        '
        'RMI_lbl
        '
        Me.RMI_lbl.AutoSize = True
        Me.RMI_lbl.Location = New System.Drawing.Point(102, 64)
        Me.RMI_lbl.Name = "RMI_lbl"
        Me.RMI_lbl.Size = New System.Drawing.Size(24, 13)
        Me.RMI_lbl.TabIndex = 40
        Me.RMI_lbl.Text = "RM"
        '
        'bookingDateIndivi_txt
        '
        Me.bookingDateIndivi_txt.Enabled = False
        Me.bookingDateIndivi_txt.Location = New System.Drawing.Point(431, 35)
        Me.bookingDateIndivi_txt.Name = "bookingDateIndivi_txt"
        Me.bookingDateIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.bookingDateIndivi_txt.TabIndex = 31
        '
        'RR_lbl
        '
        Me.RR_lbl.AutoSize = True
        Me.RR_lbl.Location = New System.Drawing.Point(102, 12)
        Me.RR_lbl.Name = "RR_lbl"
        Me.RR_lbl.Size = New System.Drawing.Size(23, 13)
        Me.RR_lbl.TabIndex = 30
        Me.RR_lbl.Text = "RR"
        '
        'reservDateIndivi_dtp
        '
        Me.reservDateIndivi_dtp.Checked = False
        Me.reservDateIndivi_dtp.Location = New System.Drawing.Point(431, 86)
        Me.reservDateIndivi_dtp.Name = "reservDateIndivi_dtp"
        Me.reservDateIndivi_dtp.Size = New System.Drawing.Size(200, 20)
        Me.reservDateIndivi_dtp.TabIndex = 29
        '
        'reservationIDIndivi_txt
        '
        Me.reservationIDIndivi_txt.Enabled = False
        Me.reservationIDIndivi_txt.Location = New System.Drawing.Point(131, 9)
        Me.reservationIDIndivi_txt.Name = "reservationIDIndivi_txt"
        Me.reservationIDIndivi_txt.Size = New System.Drawing.Size(132, 20)
        Me.reservationIDIndivi_txt.TabIndex = 27
        '
        'reservationIDIndivi_lbl
        '
        Me.reservationIDIndivi_lbl.AutoSize = True
        Me.reservationIDIndivi_lbl.Location = New System.Drawing.Point(6, 12)
        Me.reservationIDIndivi_lbl.Name = "reservationIDIndivi_lbl"
        Me.reservationIDIndivi_lbl.Size = New System.Drawing.Size(81, 13)
        Me.reservationIDIndivi_lbl.TabIndex = 26
        Me.reservationIDIndivi_lbl.Text = "Reservation ID:"
        '
        'reservDateInvidi_lbl
        '
        Me.reservDateInvidi_lbl.AutoSize = True
        Me.reservDateInvidi_lbl.Location = New System.Drawing.Point(331, 89)
        Me.reservDateInvidi_lbl.Name = "reservDateInvidi_lbl"
        Me.reservDateInvidi_lbl.Size = New System.Drawing.Size(93, 13)
        Me.reservDateInvidi_lbl.TabIndex = 24
        Me.reservDateInvidi_lbl.Text = "Reservation Date:"
        '
        'priceIndivi_txt
        '
        Me.priceIndivi_txt.Enabled = False
        Me.priceIndivi_txt.Location = New System.Drawing.Point(131, 61)
        Me.priceIndivi_txt.Name = "priceIndivi_txt"
        Me.priceIndivi_txt.Size = New System.Drawing.Size(132, 20)
        Me.priceIndivi_txt.TabIndex = 23
        '
        'bookingDateIndivi_lbl
        '
        Me.bookingDateIndivi_lbl.AutoSize = True
        Me.bookingDateIndivi_lbl.Location = New System.Drawing.Point(331, 38)
        Me.bookingDateIndivi_lbl.Name = "bookingDateIndivi_lbl"
        Me.bookingDateIndivi_lbl.Size = New System.Drawing.Size(75, 13)
        Me.bookingDateIndivi_lbl.TabIndex = 21
        Me.bookingDateIndivi_lbl.Text = "Booking Date:"
        '
        'clearIndivi_btn
        '
        Me.clearIndivi_btn.Location = New System.Drawing.Point(556, 180)
        Me.clearIndivi_btn.Name = "clearIndivi_btn"
        Me.clearIndivi_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearIndivi_btn.TabIndex = 13
        Me.clearIndivi_btn.Text = "Clear"
        Me.clearIndivi_btn.UseVisualStyleBackColor = True
        '
        'addIndivi_btn
        '
        Me.addIndivi_btn.Location = New System.Drawing.Point(461, 180)
        Me.addIndivi_btn.Name = "addIndivi_btn"
        Me.addIndivi_btn.Size = New System.Drawing.Size(75, 23)
        Me.addIndivi_btn.TabIndex = 12
        Me.addIndivi_btn.Text = "Add"
        Me.addIndivi_btn.UseVisualStyleBackColor = True
        '
        'durationIndivi_txt
        '
        Me.durationIndivi_txt.Location = New System.Drawing.Point(105, 164)
        Me.durationIndivi_txt.Name = "durationIndivi_txt"
        Me.durationIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.durationIndivi_txt.TabIndex = 11
        Me.durationIndivi_txt.Text = "0"
        '
        'durationIndivi_lbl
        '
        Me.durationIndivi_lbl.AutoSize = True
        Me.durationIndivi_lbl.Location = New System.Drawing.Point(6, 167)
        Me.durationIndivi_lbl.Name = "durationIndivi_lbl"
        Me.durationIndivi_lbl.Size = New System.Drawing.Size(50, 13)
        Me.durationIndivi_lbl.TabIndex = 10
        Me.durationIndivi_lbl.Text = "Duration:"
        '
        'phoneNOIndivi_txt
        '
        Me.phoneNOIndivi_txt.Location = New System.Drawing.Point(105, 138)
        Me.phoneNOIndivi_txt.Name = "phoneNOIndivi_txt"
        Me.phoneNOIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.phoneNOIndivi_txt.TabIndex = 9
        '
        'phoneNOIndivi_lbl
        '
        Me.phoneNOIndivi_lbl.AutoSize = True
        Me.phoneNOIndivi_lbl.Location = New System.Drawing.Point(6, 141)
        Me.phoneNOIndivi_lbl.Name = "phoneNOIndivi_lbl"
        Me.phoneNOIndivi_lbl.Size = New System.Drawing.Size(81, 13)
        Me.phoneNOIndivi_lbl.TabIndex = 8
        Me.phoneNOIndivi_lbl.Text = "Phone Number:"
        '
        'customerICIndivi_txt
        '
        Me.customerICIndivi_txt.Location = New System.Drawing.Point(105, 112)
        Me.customerICIndivi_txt.Name = "customerICIndivi_txt"
        Me.customerICIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerICIndivi_txt.TabIndex = 7
        '
        'customerICIndivi_lbl
        '
        Me.customerICIndivi_lbl.AutoSize = True
        Me.customerICIndivi_lbl.Location = New System.Drawing.Point(6, 115)
        Me.customerICIndivi_lbl.Name = "customerICIndivi_lbl"
        Me.customerICIndivi_lbl.Size = New System.Drawing.Size(79, 13)
        Me.customerICIndivi_lbl.TabIndex = 6
        Me.customerICIndivi_lbl.Text = "Customer's I/C:"
        '
        'customerNameIndivi_txt
        '
        Me.customerNameIndivi_txt.Location = New System.Drawing.Point(105, 86)
        Me.customerNameIndivi_txt.Name = "customerNameIndivi_txt"
        Me.customerNameIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerNameIndivi_txt.TabIndex = 5
        '
        'customerNameIndivi_lbl
        '
        Me.customerNameIndivi_lbl.AutoSize = True
        Me.customerNameIndivi_lbl.Location = New System.Drawing.Point(6, 89)
        Me.customerNameIndivi_lbl.Name = "customerNameIndivi_lbl"
        Me.customerNameIndivi_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerNameIndivi_lbl.TabIndex = 4
        Me.customerNameIndivi_lbl.Text = "Customer's Name:"
        '
        'bookingPriceInvidi_lbl
        '
        Me.bookingPriceInvidi_lbl.AutoSize = True
        Me.bookingPriceInvidi_lbl.Location = New System.Drawing.Point(6, 64)
        Me.bookingPriceInvidi_lbl.Name = "bookingPriceInvidi_lbl"
        Me.bookingPriceInvidi_lbl.Size = New System.Drawing.Size(76, 13)
        Me.bookingPriceInvidi_lbl.TabIndex = 2
        Me.bookingPriceInvidi_lbl.Text = "Booking Price:"
        '
        'roomtype_CB
        '
        Me.roomtype_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomtype_CB.FormattingEnabled = True
        Me.roomtype_CB.Location = New System.Drawing.Point(105, 35)
        Me.roomtype_CB.Name = "roomtype_CB"
        Me.roomtype_CB.Size = New System.Drawing.Size(110, 21)
        Me.roomtype_CB.TabIndex = 1
        '
        'roomType_lbl
        '
        Me.roomType_lbl.AutoSize = True
        Me.roomType_lbl.Location = New System.Drawing.Point(6, 38)
        Me.roomType_lbl.Name = "roomType_lbl"
        Me.roomType_lbl.Size = New System.Drawing.Size(65, 13)
        Me.roomType_lbl.TabIndex = 0
        Me.roomType_lbl.Text = "Room Type:"
        '
        'roomGroupTab
        '
        Me.roomGroupTab.Controls.Add(Me.Label4)
        Me.roomGroupTab.Controls.Add(Me.depositGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.depositGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.RMG_lbl)
        Me.roomGroupTab.Controls.Add(Me.durationGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.durationGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.Label2)
        Me.roomGroupTab.Controls.Add(Me.reservationIDGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.reservationIDGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.reservDateGroup_dtp)
        Me.roomGroupTab.Controls.Add(Me.Label1)
        Me.roomGroupTab.Controls.Add(Me.phoneNOGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.bookingDateGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.clearGroup_btn)
        Me.roomGroupTab.Controls.Add(Me.addGroup_btn)
        Me.roomGroupTab.Controls.Add(Me.bookingDateGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.phoneGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.deluxeRoom_txt)
        Me.roomGroupTab.Controls.Add(Me.standardRoom_txt)
        Me.roomGroupTab.Controls.Add(Me.customerICGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.customerICGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.customerNameGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.customerNameGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.bookingPriceGroup_txt)
        Me.roomGroupTab.Controls.Add(Me.bookingPriceGroup_lbl)
        Me.roomGroupTab.Controls.Add(Me.superiorRoom_txt)
        Me.roomGroupTab.Controls.Add(Me.superiorRoom_lbl)
        Me.roomGroupTab.Controls.Add(Me.deluxeRoom_lbl)
        Me.roomGroupTab.Controls.Add(Me.standardRoom_lbl)
        Me.roomGroupTab.Location = New System.Drawing.Point(4, 22)
        Me.roomGroupTab.Name = "roomGroupTab"
        Me.roomGroupTab.Padding = New System.Windows.Forms.Padding(3)
        Me.roomGroupTab.Size = New System.Drawing.Size(665, 222)
        Me.roomGroupTab.TabIndex = 1
        Me.roomGroupTab.Text = "Group"
        Me.roomGroupTab.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "RM"
        '
        'depositGroup_txt
        '
        Me.depositGroup_txt.Location = New System.Drawing.Point(456, 61)
        Me.depositGroup_txt.Name = "depositGroup_txt"
        Me.depositGroup_txt.Size = New System.Drawing.Size(132, 20)
        Me.depositGroup_txt.TabIndex = 45
        '
        'depositGroup_lbl
        '
        Me.depositGroup_lbl.AutoSize = True
        Me.depositGroup_lbl.Location = New System.Drawing.Point(331, 64)
        Me.depositGroup_lbl.Name = "depositGroup_lbl"
        Me.depositGroup_lbl.Size = New System.Drawing.Size(46, 13)
        Me.depositGroup_lbl.TabIndex = 44
        Me.depositGroup_lbl.Text = "Deposit:"
        '
        'RMG_lbl
        '
        Me.RMG_lbl.AutoSize = True
        Me.RMG_lbl.Location = New System.Drawing.Point(102, 115)
        Me.RMG_lbl.Name = "RMG_lbl"
        Me.RMG_lbl.Size = New System.Drawing.Size(24, 13)
        Me.RMG_lbl.TabIndex = 39
        Me.RMG_lbl.Text = "RM"
        '
        'durationGroup_txt
        '
        Me.durationGroup_txt.Location = New System.Drawing.Point(431, 5)
        Me.durationGroup_txt.Name = "durationGroup_txt"
        Me.durationGroup_txt.Size = New System.Drawing.Size(158, 20)
        Me.durationGroup_txt.TabIndex = 38
        Me.durationGroup_txt.Text = "0"
        '
        'durationGroup_lbl
        '
        Me.durationGroup_lbl.AutoSize = True
        Me.durationGroup_lbl.Location = New System.Drawing.Point(332, 8)
        Me.durationGroup_lbl.Name = "durationGroup_lbl"
        Me.durationGroup_lbl.Size = New System.Drawing.Size(50, 13)
        Me.durationGroup_lbl.TabIndex = 37
        Me.durationGroup_lbl.Text = "Duration:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "RR"
        '
        'reservationIDGroup_txt
        '
        Me.reservationIDGroup_txt.Enabled = False
        Me.reservationIDGroup_txt.Location = New System.Drawing.Point(131, 5)
        Me.reservationIDGroup_txt.Name = "reservationIDGroup_txt"
        Me.reservationIDGroup_txt.Size = New System.Drawing.Size(132, 20)
        Me.reservationIDGroup_txt.TabIndex = 35
        '
        'reservationIDGroup_lbl
        '
        Me.reservationIDGroup_lbl.AutoSize = True
        Me.reservationIDGroup_lbl.Location = New System.Drawing.Point(6, 8)
        Me.reservationIDGroup_lbl.Name = "reservationIDGroup_lbl"
        Me.reservationIDGroup_lbl.Size = New System.Drawing.Size(81, 13)
        Me.reservationIDGroup_lbl.TabIndex = 34
        Me.reservationIDGroup_lbl.Text = "Reservation ID:"
        '
        'reservDateGroup_dtp
        '
        Me.reservDateGroup_dtp.Checked = False
        Me.reservDateGroup_dtp.Location = New System.Drawing.Point(431, 86)
        Me.reservDateGroup_dtp.Name = "reservDateGroup_dtp"
        Me.reservDateGroup_dtp.Size = New System.Drawing.Size(200, 20)
        Me.reservDateGroup_dtp.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Reservation Date:"
        '
        'phoneNOGroup_txt
        '
        Me.phoneNOGroup_txt.Location = New System.Drawing.Point(98, 198)
        Me.phoneNOGroup_txt.Name = "phoneNOGroup_txt"
        Me.phoneNOGroup_txt.Size = New System.Drawing.Size(158, 20)
        Me.phoneNOGroup_txt.TabIndex = 31
        '
        'bookingDateGroup_lbl
        '
        Me.bookingDateGroup_lbl.AutoSize = True
        Me.bookingDateGroup_lbl.Location = New System.Drawing.Point(331, 38)
        Me.bookingDateGroup_lbl.Name = "bookingDateGroup_lbl"
        Me.bookingDateGroup_lbl.Size = New System.Drawing.Size(75, 13)
        Me.bookingDateGroup_lbl.TabIndex = 30
        Me.bookingDateGroup_lbl.Text = "Booking Date:"
        '
        'clearGroup_btn
        '
        Me.clearGroup_btn.Location = New System.Drawing.Point(556, 180)
        Me.clearGroup_btn.Name = "clearGroup_btn"
        Me.clearGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearGroup_btn.TabIndex = 29
        Me.clearGroup_btn.Text = "Clear"
        Me.clearGroup_btn.UseVisualStyleBackColor = True
        '
        'addGroup_btn
        '
        Me.addGroup_btn.Location = New System.Drawing.Point(461, 180)
        Me.addGroup_btn.Name = "addGroup_btn"
        Me.addGroup_btn.Size = New System.Drawing.Size(75, 23)
        Me.addGroup_btn.TabIndex = 28
        Me.addGroup_btn.Text = "Add"
        Me.addGroup_btn.UseVisualStyleBackColor = True
        '
        'bookingDateGroup_txt
        '
        Me.bookingDateGroup_txt.Enabled = False
        Me.bookingDateGroup_txt.Location = New System.Drawing.Point(431, 35)
        Me.bookingDateGroup_txt.Name = "bookingDateGroup_txt"
        Me.bookingDateGroup_txt.Size = New System.Drawing.Size(158, 20)
        Me.bookingDateGroup_txt.TabIndex = 27
        '
        'phoneGroup_lbl
        '
        Me.phoneGroup_lbl.AutoSize = True
        Me.phoneGroup_lbl.Location = New System.Drawing.Point(6, 201)
        Me.phoneGroup_lbl.Name = "phoneGroup_lbl"
        Me.phoneGroup_lbl.Size = New System.Drawing.Size(81, 13)
        Me.phoneGroup_lbl.TabIndex = 26
        Me.phoneGroup_lbl.Text = "Phone Number:"
        '
        'deluxeRoom_txt
        '
        Me.deluxeRoom_txt.Location = New System.Drawing.Point(98, 57)
        Me.deluxeRoom_txt.Name = "deluxeRoom_txt"
        Me.deluxeRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.deluxeRoom_txt.TabIndex = 25
        Me.deluxeRoom_txt.Text = "0"
        '
        'standardRoom_txt
        '
        Me.standardRoom_txt.Location = New System.Drawing.Point(98, 31)
        Me.standardRoom_txt.Name = "standardRoom_txt"
        Me.standardRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.standardRoom_txt.TabIndex = 24
        Me.standardRoom_txt.Text = "0"
        '
        'customerICGroup_txt
        '
        Me.customerICGroup_txt.Location = New System.Drawing.Point(98, 170)
        Me.customerICGroup_txt.Name = "customerICGroup_txt"
        Me.customerICGroup_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerICGroup_txt.TabIndex = 23
        '
        'customerICGroup_lbl
        '
        Me.customerICGroup_lbl.AutoSize = True
        Me.customerICGroup_lbl.Location = New System.Drawing.Point(6, 173)
        Me.customerICGroup_lbl.Name = "customerICGroup_lbl"
        Me.customerICGroup_lbl.Size = New System.Drawing.Size(79, 13)
        Me.customerICGroup_lbl.TabIndex = 22
        Me.customerICGroup_lbl.Text = "Customer's I/C:"
        '
        'customerNameGroup_txt
        '
        Me.customerNameGroup_txt.Location = New System.Drawing.Point(98, 141)
        Me.customerNameGroup_txt.Name = "customerNameGroup_txt"
        Me.customerNameGroup_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerNameGroup_txt.TabIndex = 21
        '
        'customerNameGroup_lbl
        '
        Me.customerNameGroup_lbl.AutoSize = True
        Me.customerNameGroup_lbl.Location = New System.Drawing.Point(6, 144)
        Me.customerNameGroup_lbl.Name = "customerNameGroup_lbl"
        Me.customerNameGroup_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerNameGroup_lbl.TabIndex = 20
        Me.customerNameGroup_lbl.Text = "Customer's Name:"
        '
        'bookingPriceGroup_txt
        '
        Me.bookingPriceGroup_txt.Enabled = False
        Me.bookingPriceGroup_txt.Location = New System.Drawing.Point(131, 112)
        Me.bookingPriceGroup_txt.Name = "bookingPriceGroup_txt"
        Me.bookingPriceGroup_txt.Size = New System.Drawing.Size(125, 20)
        Me.bookingPriceGroup_txt.TabIndex = 19
        '
        'bookingPriceGroup_lbl
        '
        Me.bookingPriceGroup_lbl.AutoSize = True
        Me.bookingPriceGroup_lbl.Location = New System.Drawing.Point(6, 115)
        Me.bookingPriceGroup_lbl.Name = "bookingPriceGroup_lbl"
        Me.bookingPriceGroup_lbl.Size = New System.Drawing.Size(76, 13)
        Me.bookingPriceGroup_lbl.TabIndex = 18
        Me.bookingPriceGroup_lbl.Text = "Booking Price:"
        '
        'superiorRoom_txt
        '
        Me.superiorRoom_txt.Location = New System.Drawing.Point(98, 83)
        Me.superiorRoom_txt.Name = "superiorRoom_txt"
        Me.superiorRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.superiorRoom_txt.TabIndex = 17
        Me.superiorRoom_txt.Text = "0"
        '
        'superiorRoom_lbl
        '
        Me.superiorRoom_lbl.AutoSize = True
        Me.superiorRoom_lbl.Location = New System.Drawing.Point(6, 85)
        Me.superiorRoom_lbl.Name = "superiorRoom_lbl"
        Me.superiorRoom_lbl.Size = New System.Drawing.Size(80, 13)
        Me.superiorRoom_lbl.TabIndex = 16
        Me.superiorRoom_lbl.Text = "Superior Room:"
        '
        'deluxeRoom_lbl
        '
        Me.deluxeRoom_lbl.AutoSize = True
        Me.deluxeRoom_lbl.Location = New System.Drawing.Point(6, 60)
        Me.deluxeRoom_lbl.Name = "deluxeRoom_lbl"
        Me.deluxeRoom_lbl.Size = New System.Drawing.Size(74, 13)
        Me.deluxeRoom_lbl.TabIndex = 14
        Me.deluxeRoom_lbl.Text = "Deluxe Room:"
        '
        'standardRoom_lbl
        '
        Me.standardRoom_lbl.AutoSize = True
        Me.standardRoom_lbl.Location = New System.Drawing.Point(6, 34)
        Me.standardRoom_lbl.Name = "standardRoom_lbl"
        Me.standardRoom_lbl.Size = New System.Drawing.Size(84, 13)
        Me.standardRoom_lbl.TabIndex = 12
        Me.standardRoom_lbl.Text = "Standard Room:"
        '
        'FnS_Tab
        '
        Me.FnS_Tab.Controls.Add(Me.GroupBox1)
        Me.FnS_Tab.Location = New System.Drawing.Point(4, 22)
        Me.FnS_Tab.Margin = New System.Windows.Forms.Padding(2)
        Me.FnS_Tab.Name = "FnS_Tab"
        Me.FnS_Tab.Padding = New System.Windows.Forms.Padding(2)
        Me.FnS_Tab.Size = New System.Drawing.Size(674, 244)
        Me.FnS_Tab.TabIndex = 1
        Me.FnS_Tab.Text = "Facilities & Services"
        Me.FnS_Tab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bookingDate_lbl)
        Me.GroupBox1.Controls.Add(Me.bookingDate_txt)
        Me.GroupBox1.Controls.Add(Me.customerName_txt)
        Me.GroupBox1.Controls.Add(Me.customerName_lbl)
        Me.GroupBox1.Controls.Add(Me.FS_lbl)
        Me.GroupBox1.Controls.Add(Me.typeFnS_CB)
        Me.GroupBox1.Controls.Add(Me.FR_lbl)
        Me.GroupBox1.Controls.Add(Me.reservID_txt)
        Me.GroupBox1.Controls.Add(Me.nameFnS_CB)
        Me.GroupBox1.Controls.Add(Me.chargesFeesFnS_txt)
        Me.GroupBox1.Controls.Add(Me.FnSID_txt)
        Me.GroupBox1.Controls.Add(Me.reservID_lbl)
        Me.GroupBox1.Controls.Add(Me.FnSID_lbl)
        Me.GroupBox1.Controls.Add(Me.clearFnS_btn)
        Me.GroupBox1.Controls.Add(Me.addFnS_btn)
        Me.GroupBox1.Controls.Add(Me.typeFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.roomNOFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.roomNOFnS_CB)
        Me.GroupBox1.Controls.Add(Me.nameFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.chargesFeesFnS_lbl)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 236)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facilities or Services"
        '
        'bookingDate_lbl
        '
        Me.bookingDate_lbl.AutoSize = True
        Me.bookingDate_lbl.Location = New System.Drawing.Point(362, 55)
        Me.bookingDate_lbl.Name = "bookingDate_lbl"
        Me.bookingDate_lbl.Size = New System.Drawing.Size(75, 13)
        Me.bookingDate_lbl.TabIndex = 48
        Me.bookingDate_lbl.Text = "Booking Date:"
        '
        'bookingDate_txt
        '
        Me.bookingDate_txt.Enabled = False
        Me.bookingDate_txt.Location = New System.Drawing.Point(462, 52)
        Me.bookingDate_txt.Name = "bookingDate_txt"
        Me.bookingDate_txt.Size = New System.Drawing.Size(158, 20)
        Me.bookingDate_txt.TabIndex = 47
        '
        'customerName_txt
        '
        Me.customerName_txt.Location = New System.Drawing.Point(148, 175)
        Me.customerName_txt.Name = "customerName_txt"
        Me.customerName_txt.Size = New System.Drawing.Size(110, 20)
        Me.customerName_txt.TabIndex = 46
        '
        'customerName_lbl
        '
        Me.customerName_lbl.AutoSize = True
        Me.customerName_lbl.Location = New System.Drawing.Point(13, 178)
        Me.customerName_lbl.Name = "customerName_lbl"
        Me.customerName_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerName_lbl.TabIndex = 45
        Me.customerName_lbl.Text = "Customer's Name:"
        '
        'FS_lbl
        '
        Me.FS_lbl.AutoSize = True
        Me.FS_lbl.Location = New System.Drawing.Point(148, 116)
        Me.FS_lbl.Name = "FS_lbl"
        Me.FS_lbl.Size = New System.Drawing.Size(20, 13)
        Me.FS_lbl.TabIndex = 44
        Me.FS_lbl.Text = "FS"
        '
        'typeFnS_CB
        '
        Me.typeFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeFnS_CB.FormattingEnabled = True
        Me.typeFnS_CB.Location = New System.Drawing.Point(148, 52)
        Me.typeFnS_CB.Name = "typeFnS_CB"
        Me.typeFnS_CB.Size = New System.Drawing.Size(110, 21)
        Me.typeFnS_CB.TabIndex = 43
        '
        'FR_lbl
        '
        Me.FR_lbl.AutoSize = True
        Me.FR_lbl.Location = New System.Drawing.Point(145, 28)
        Me.FR_lbl.Name = "FR_lbl"
        Me.FR_lbl.Size = New System.Drawing.Size(21, 13)
        Me.FR_lbl.TabIndex = 42
        Me.FR_lbl.Text = "FR"
        '
        'reservID_txt
        '
        Me.reservID_txt.Enabled = False
        Me.reservID_txt.Location = New System.Drawing.Point(174, 25)
        Me.reservID_txt.Name = "reservID_txt"
        Me.reservID_txt.Size = New System.Drawing.Size(84, 20)
        Me.reservID_txt.TabIndex = 41
        '
        'nameFnS_CB
        '
        Me.nameFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameFnS_CB.FormattingEnabled = True
        Me.nameFnS_CB.Location = New System.Drawing.Point(148, 82)
        Me.nameFnS_CB.Name = "nameFnS_CB"
        Me.nameFnS_CB.Size = New System.Drawing.Size(110, 21)
        Me.nameFnS_CB.TabIndex = 40
        '
        'chargesFeesFnS_txt
        '
        Me.chargesFeesFnS_txt.Enabled = False
        Me.chargesFeesFnS_txt.Location = New System.Drawing.Point(148, 206)
        Me.chargesFeesFnS_txt.Name = "chargesFeesFnS_txt"
        Me.chargesFeesFnS_txt.Size = New System.Drawing.Size(110, 20)
        Me.chargesFeesFnS_txt.TabIndex = 39
        '
        'FnSID_txt
        '
        Me.FnSID_txt.Enabled = False
        Me.FnSID_txt.Location = New System.Drawing.Point(174, 113)
        Me.FnSID_txt.Name = "FnSID_txt"
        Me.FnSID_txt.Size = New System.Drawing.Size(84, 20)
        Me.FnSID_txt.TabIndex = 36
        '
        'reservID_lbl
        '
        Me.reservID_lbl.AutoSize = True
        Me.reservID_lbl.Location = New System.Drawing.Point(13, 28)
        Me.reservID_lbl.Name = "reservID_lbl"
        Me.reservID_lbl.Size = New System.Drawing.Size(81, 13)
        Me.reservID_lbl.TabIndex = 32
        Me.reservID_lbl.Text = "Reservation ID:"
        '
        'FnSID_lbl
        '
        Me.FnSID_lbl.AutoSize = True
        Me.FnSID_lbl.Location = New System.Drawing.Point(13, 116)
        Me.FnSID_lbl.Name = "FnSID_lbl"
        Me.FnSID_lbl.Size = New System.Drawing.Size(129, 13)
        Me.FnSID_lbl.TabIndex = 34
        Me.FnSID_lbl.Text = "Facilities and Services ID:"
        '
        'clearFnS_btn
        '
        Me.clearFnS_btn.Location = New System.Drawing.Point(558, 197)
        Me.clearFnS_btn.Name = "clearFnS_btn"
        Me.clearFnS_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearFnS_btn.TabIndex = 31
        Me.clearFnS_btn.Text = "Clear"
        Me.clearFnS_btn.UseVisualStyleBackColor = True
        '
        'addFnS_btn
        '
        Me.addFnS_btn.Location = New System.Drawing.Point(463, 197)
        Me.addFnS_btn.Name = "addFnS_btn"
        Me.addFnS_btn.Size = New System.Drawing.Size(75, 23)
        Me.addFnS_btn.TabIndex = 30
        Me.addFnS_btn.Text = "Add"
        Me.addFnS_btn.UseVisualStyleBackColor = True
        '
        'typeFnS_lbl
        '
        Me.typeFnS_lbl.AutoSize = True
        Me.typeFnS_lbl.Location = New System.Drawing.Point(13, 55)
        Me.typeFnS_lbl.Name = "typeFnS_lbl"
        Me.typeFnS_lbl.Size = New System.Drawing.Size(34, 13)
        Me.typeFnS_lbl.TabIndex = 12
        Me.typeFnS_lbl.Text = "Type:"
        '
        'roomNOFnS_lbl
        '
        Me.roomNOFnS_lbl.AutoSize = True
        Me.roomNOFnS_lbl.Location = New System.Drawing.Point(13, 146)
        Me.roomNOFnS_lbl.Name = "roomNOFnS_lbl"
        Me.roomNOFnS_lbl.Size = New System.Drawing.Size(78, 13)
        Me.roomNOFnS_lbl.TabIndex = 14
        Me.roomNOFnS_lbl.Text = "Room Number:"
        '
        'roomNOFnS_CB
        '
        Me.roomNOFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomNOFnS_CB.FormattingEnabled = True
        Me.roomNOFnS_CB.Location = New System.Drawing.Point(148, 143)
        Me.roomNOFnS_CB.Name = "roomNOFnS_CB"
        Me.roomNOFnS_CB.Size = New System.Drawing.Size(110, 21)
        Me.roomNOFnS_CB.TabIndex = 24
        '
        'nameFnS_lbl
        '
        Me.nameFnS_lbl.AutoSize = True
        Me.nameFnS_lbl.Location = New System.Drawing.Point(13, 85)
        Me.nameFnS_lbl.Name = "nameFnS_lbl"
        Me.nameFnS_lbl.Size = New System.Drawing.Size(38, 13)
        Me.nameFnS_lbl.TabIndex = 16
        Me.nameFnS_lbl.Text = "Name:"
        '
        'chargesFeesFnS_lbl
        '
        Me.chargesFeesFnS_lbl.AutoSize = True
        Me.chargesFeesFnS_lbl.Location = New System.Drawing.Point(13, 209)
        Me.chargesFeesFnS_lbl.Name = "chargesFeesFnS_lbl"
        Me.chargesFeesFnS_lbl.Size = New System.Drawing.Size(75, 13)
        Me.chargesFeesFnS_lbl.TabIndex = 18
        Me.chargesFeesFnS_lbl.Text = "Charges Fees:"
        '
        'close_btn
        '
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(626, 361)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.close_btn.MinimumSize = New System.Drawing.Size(55, 16)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = False
        Me.close_btn.Size = New System.Drawing.Size(55, 36)
        Me.close_btn.TabIndex = 38
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentTime_lbl.ForeColor = System.Drawing.Color.White
        Me.currentTime_lbl.Location = New System.Drawing.Point(601, 37)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentTime_lbl.TabIndex = 32
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentDate_lbl.ForeColor = System.Drawing.Color.White
        Me.currentDate_lbl.Location = New System.Drawing.Point(537, 37)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentDate_lbl.TabIndex = 31
        Me.currentDate_lbl.Text = "Date"
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
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
        Me.MaterialTabSelector1.TabIndex = 7
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RMMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 399)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "RMMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Management Data Entry"
        Me.RFTabControl.ResumeLayout(False)
        Me.room_Tab.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.roomIndiviTab.ResumeLayout(False)
        Me.roomIndiviTab.PerformLayout()
        Me.roomGroupTab.ResumeLayout(False)
        Me.roomGroupTab.PerformLayout()
        Me.FnS_Tab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents room_Tab As System.Windows.Forms.TabPage
    Friend WithEvents FnS_Tab As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents roomIndiviTab As System.Windows.Forms.TabPage
    Friend WithEvents roomGroupTab As System.Windows.Forms.TabPage
    Friend WithEvents customerICGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerICGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents customerNameGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerNameGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingPriceGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents bookingPriceGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents superiorRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents superiorRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents deluxeRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents standardRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents standardRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents deluxeRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents phoneGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingDateGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents durationIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents durationIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents roomType_lbl As System.Windows.Forms.Label
    Friend WithEvents phoneNOIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents roomtype_CB As System.Windows.Forms.ComboBox
    Friend WithEvents phoneNOIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingPriceInvidi_lbl As System.Windows.Forms.Label
    Friend WithEvents customerICIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerICIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents customerNameIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents customerNameIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents addIndivi_btn As System.Windows.Forms.Button
    Friend WithEvents clearIndivi_btn As System.Windows.Forms.Button
    Friend WithEvents clearGroup_btn As System.Windows.Forms.Button
    Friend WithEvents addGroup_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents roomNOFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents chargesFeesFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents nameFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents roomNOFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents typeFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clearFnS_btn As System.Windows.Forms.Button
    Friend WithEvents addFnS_btn As System.Windows.Forms.Button
    Friend WithEvents phoneNOGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents bookingDateGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingDateIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents priceIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents reservDateInvidi_lbl As System.Windows.Forms.Label
    Friend WithEvents reservationIDIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents reservDateIndivi_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents RR_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingDateIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents reservDateGroup_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reservationIDGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents durationGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents durationGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents reservID_lbl As System.Windows.Forms.Label
    Friend WithEvents FnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents chargesFeesFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents FnSID_txt As System.Windows.Forms.TextBox
    Friend WithEvents nameFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents reservID_txt As System.Windows.Forms.TextBox
    Friend WithEvents FR_lbl As System.Windows.Forms.Label
    Friend WithEvents typeFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents reservationIDGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents FS_lbl As System.Windows.Forms.Label
    Friend WithEvents reservationIDIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_lbl As System.Windows.Forms.Label
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents bookingDate_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingDate_txt As System.Windows.Forms.TextBox
    Friend WithEvents RMG_lbl As System.Windows.Forms.Label
    Friend WithEvents RMI_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents depositIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents depositIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents depositGroup_txt As System.Windows.Forms.TextBox
    Friend WithEvents depositGroup_lbl As System.Windows.Forms.Label
    Friend WithEvents totalPrice_lbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalPrice_txt As System.Windows.Forms.TextBox
End Class
