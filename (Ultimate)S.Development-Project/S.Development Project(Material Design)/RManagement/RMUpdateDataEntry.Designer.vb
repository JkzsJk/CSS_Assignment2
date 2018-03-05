<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RMUpdateDataEntry
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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.roomTab = New System.Windows.Forms.TabPage()
        Me.room_G = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.depositIndivi_txt = New System.Windows.Forms.TextBox()
        Me.depositIndivi_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_txt = New System.Windows.Forms.TextBox()
        Me.standardRoom_txt = New System.Windows.Forms.TextBox()
        Me.superiorRoom_txt = New System.Windows.Forms.TextBox()
        Me.superiorRoom_lbl = New System.Windows.Forms.Label()
        Me.deluxeRoom_lbl = New System.Windows.Forms.Label()
        Me.standardRoom_lbl = New System.Windows.Forms.Label()
        Me.reservationIDIndivi_CB = New System.Windows.Forms.ComboBox()
        Me.bookingDateIndivi_txt = New System.Windows.Forms.TextBox()
        Me.RR_lbl = New System.Windows.Forms.Label()
        Me.reservDateIndivi_dtp = New System.Windows.Forms.DateTimePicker()
        Me.reservationIDIndivi_lbl = New System.Windows.Forms.Label()
        Me.reservDateInvidi_lbl = New System.Windows.Forms.Label()
        Me.priceIndivi_txt = New System.Windows.Forms.TextBox()
        Me.bookingDateIndivi_lbl = New System.Windows.Forms.Label()
        Me.durationIndivi_txt = New System.Windows.Forms.TextBox()
        Me.durationIndivi_lbl = New System.Windows.Forms.Label()
        Me.phoneNOIndivi_txt = New System.Windows.Forms.TextBox()
        Me.phoneNOIndivi_lbl = New System.Windows.Forms.Label()
        Me.customerICIndivi_txt = New System.Windows.Forms.TextBox()
        Me.customerICIndivi_lbl = New System.Windows.Forms.Label()
        Me.customerNameIndivi_txt = New System.Windows.Forms.TextBox()
        Me.customerNameIndivi_lbl = New System.Windows.Forms.Label()
        Me.bookingPriceInvidi_lbl = New System.Windows.Forms.Label()
        Me.clearIndivi_btn = New System.Windows.Forms.Button()
        Me.updateIndivi_btn = New System.Windows.Forms.Button()
        Me.FnSTab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bookingDateFnS_txt = New System.Windows.Forms.TextBox()
        Me.bookingDateFnS_lbl = New System.Windows.Forms.Label()
        Me.reservID_CB = New System.Windows.Forms.ComboBox()
        Me.customerName_txt = New System.Windows.Forms.TextBox()
        Me.customerName_lbl = New System.Windows.Forms.Label()
        Me.FS_lbl = New System.Windows.Forms.Label()
        Me.typeFnS_CB = New System.Windows.Forms.ComboBox()
        Me.FR_lbl = New System.Windows.Forms.Label()
        Me.nameFnS_CB = New System.Windows.Forms.ComboBox()
        Me.chargesFeesFnS_txt = New System.Windows.Forms.TextBox()
        Me.FnSID_txt = New System.Windows.Forms.TextBox()
        Me.reservID_lbl = New System.Windows.Forms.Label()
        Me.FnSID_lbl = New System.Windows.Forms.Label()
        Me.typeFnS_lbl = New System.Windows.Forms.Label()
        Me.roomNOFnS_lbl = New System.Windows.Forms.Label()
        Me.roomNOFnS_CB = New System.Windows.Forms.ComboBox()
        Me.nameFnS_lbl = New System.Windows.Forms.Label()
        Me.chargesFeesFnS_lbl = New System.Windows.Forms.Label()
        Me.clearFnS_btn = New System.Windows.Forms.Button()
        Me.updateFnS_btn = New System.Windows.Forms.Button()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.RFTabControl.SuspendLayout()
        Me.roomTab.SuspendLayout()
        Me.room_G.SuspendLayout()
        Me.FnSTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(683, 25)
        Me.MaterialTabSelector1.TabIndex = 65
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.roomTab)
        Me.RFTabControl.Controls.Add(Me.FnSTab)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(0, 93)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(682, 300)
        Me.RFTabControl.TabIndex = 64
        '
        'roomTab
        '
        Me.roomTab.Controls.Add(Me.room_G)
        Me.roomTab.Location = New System.Drawing.Point(4, 22)
        Me.roomTab.Margin = New System.Windows.Forms.Padding(2)
        Me.roomTab.Name = "roomTab"
        Me.roomTab.Padding = New System.Windows.Forms.Padding(2)
        Me.roomTab.Size = New System.Drawing.Size(674, 274)
        Me.roomTab.TabIndex = 0
        Me.roomTab.Text = "Room"
        Me.roomTab.UseVisualStyleBackColor = True
        '
        'room_G
        '
        Me.room_G.Controls.Add(Me.Label3)
        Me.room_G.Controls.Add(Me.depositIndivi_txt)
        Me.room_G.Controls.Add(Me.depositIndivi_lbl)
        Me.room_G.Controls.Add(Me.deluxeRoom_txt)
        Me.room_G.Controls.Add(Me.standardRoom_txt)
        Me.room_G.Controls.Add(Me.superiorRoom_txt)
        Me.room_G.Controls.Add(Me.superiorRoom_lbl)
        Me.room_G.Controls.Add(Me.deluxeRoom_lbl)
        Me.room_G.Controls.Add(Me.standardRoom_lbl)
        Me.room_G.Controls.Add(Me.reservationIDIndivi_CB)
        Me.room_G.Controls.Add(Me.bookingDateIndivi_txt)
        Me.room_G.Controls.Add(Me.RR_lbl)
        Me.room_G.Controls.Add(Me.reservDateIndivi_dtp)
        Me.room_G.Controls.Add(Me.reservationIDIndivi_lbl)
        Me.room_G.Controls.Add(Me.reservDateInvidi_lbl)
        Me.room_G.Controls.Add(Me.priceIndivi_txt)
        Me.room_G.Controls.Add(Me.bookingDateIndivi_lbl)
        Me.room_G.Controls.Add(Me.durationIndivi_txt)
        Me.room_G.Controls.Add(Me.durationIndivi_lbl)
        Me.room_G.Controls.Add(Me.phoneNOIndivi_txt)
        Me.room_G.Controls.Add(Me.phoneNOIndivi_lbl)
        Me.room_G.Controls.Add(Me.customerICIndivi_txt)
        Me.room_G.Controls.Add(Me.customerICIndivi_lbl)
        Me.room_G.Controls.Add(Me.customerNameIndivi_txt)
        Me.room_G.Controls.Add(Me.customerNameIndivi_lbl)
        Me.room_G.Controls.Add(Me.bookingPriceInvidi_lbl)
        Me.room_G.Controls.Add(Me.clearIndivi_btn)
        Me.room_G.Controls.Add(Me.updateIndivi_btn)
        Me.room_G.Location = New System.Drawing.Point(7, 5)
        Me.room_G.Name = "room_G"
        Me.room_G.Size = New System.Drawing.Size(667, 269)
        Me.room_G.TabIndex = 0
        Me.room_G.TabStop = False
        Me.room_G.Text = "Update Room Reservation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "RM"
        '
        'depositIndivi_txt
        '
        Me.depositIndivi_txt.Location = New System.Drawing.Point(458, 78)
        Me.depositIndivi_txt.Name = "depositIndivi_txt"
        Me.depositIndivi_txt.Size = New System.Drawing.Size(132, 20)
        Me.depositIndivi_txt.TabIndex = 80
        '
        'depositIndivi_lbl
        '
        Me.depositIndivi_lbl.AutoSize = True
        Me.depositIndivi_lbl.Location = New System.Drawing.Point(333, 81)
        Me.depositIndivi_lbl.Name = "depositIndivi_lbl"
        Me.depositIndivi_lbl.Size = New System.Drawing.Size(46, 13)
        Me.depositIndivi_lbl.TabIndex = 79
        Me.depositIndivi_lbl.Text = "Deposit:"
        '
        'deluxeRoom_txt
        '
        Me.deluxeRoom_txt.Enabled = False
        Me.deluxeRoom_txt.Location = New System.Drawing.Point(107, 78)
        Me.deluxeRoom_txt.Name = "deluxeRoom_txt"
        Me.deluxeRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.deluxeRoom_txt.TabIndex = 78
        Me.deluxeRoom_txt.Text = "0"
        '
        'standardRoom_txt
        '
        Me.standardRoom_txt.Enabled = False
        Me.standardRoom_txt.Location = New System.Drawing.Point(107, 52)
        Me.standardRoom_txt.Name = "standardRoom_txt"
        Me.standardRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.standardRoom_txt.TabIndex = 77
        Me.standardRoom_txt.Text = "0"
        '
        'superiorRoom_txt
        '
        Me.superiorRoom_txt.Enabled = False
        Me.superiorRoom_txt.Location = New System.Drawing.Point(107, 104)
        Me.superiorRoom_txt.Name = "superiorRoom_txt"
        Me.superiorRoom_txt.Size = New System.Drawing.Size(83, 20)
        Me.superiorRoom_txt.TabIndex = 76
        Me.superiorRoom_txt.Text = "0"
        '
        'superiorRoom_lbl
        '
        Me.superiorRoom_lbl.AutoSize = True
        Me.superiorRoom_lbl.Location = New System.Drawing.Point(8, 106)
        Me.superiorRoom_lbl.Name = "superiorRoom_lbl"
        Me.superiorRoom_lbl.Size = New System.Drawing.Size(80, 13)
        Me.superiorRoom_lbl.TabIndex = 75
        Me.superiorRoom_lbl.Text = "Superior Room:"
        '
        'deluxeRoom_lbl
        '
        Me.deluxeRoom_lbl.AutoSize = True
        Me.deluxeRoom_lbl.Location = New System.Drawing.Point(8, 81)
        Me.deluxeRoom_lbl.Name = "deluxeRoom_lbl"
        Me.deluxeRoom_lbl.Size = New System.Drawing.Size(74, 13)
        Me.deluxeRoom_lbl.TabIndex = 74
        Me.deluxeRoom_lbl.Text = "Deluxe Room:"
        '
        'standardRoom_lbl
        '
        Me.standardRoom_lbl.AutoSize = True
        Me.standardRoom_lbl.Location = New System.Drawing.Point(8, 55)
        Me.standardRoom_lbl.Name = "standardRoom_lbl"
        Me.standardRoom_lbl.Size = New System.Drawing.Size(84, 13)
        Me.standardRoom_lbl.TabIndex = 73
        Me.standardRoom_lbl.Text = "Standard Room:"
        '
        'reservationIDIndivi_CB
        '
        Me.reservationIDIndivi_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.reservationIDIndivi_CB.FormattingEnabled = True
        Me.reservationIDIndivi_CB.Location = New System.Drawing.Point(133, 25)
        Me.reservationIDIndivi_CB.Name = "reservationIDIndivi_CB"
        Me.reservationIDIndivi_CB.Size = New System.Drawing.Size(132, 21)
        Me.reservationIDIndivi_CB.TabIndex = 72
        '
        'bookingDateIndivi_txt
        '
        Me.bookingDateIndivi_txt.Enabled = False
        Me.bookingDateIndivi_txt.Location = New System.Drawing.Point(433, 52)
        Me.bookingDateIndivi_txt.Name = "bookingDateIndivi_txt"
        Me.bookingDateIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.bookingDateIndivi_txt.TabIndex = 71
        '
        'RR_lbl
        '
        Me.RR_lbl.AutoSize = True
        Me.RR_lbl.Location = New System.Drawing.Point(104, 29)
        Me.RR_lbl.Name = "RR_lbl"
        Me.RR_lbl.Size = New System.Drawing.Size(23, 13)
        Me.RR_lbl.TabIndex = 70
        Me.RR_lbl.Text = "RR"
        '
        'reservDateIndivi_dtp
        '
        Me.reservDateIndivi_dtp.Checked = False
        Me.reservDateIndivi_dtp.Enabled = False
        Me.reservDateIndivi_dtp.Location = New System.Drawing.Point(433, 103)
        Me.reservDateIndivi_dtp.Name = "reservDateIndivi_dtp"
        Me.reservDateIndivi_dtp.Size = New System.Drawing.Size(200, 20)
        Me.reservDateIndivi_dtp.TabIndex = 69
        '
        'reservationIDIndivi_lbl
        '
        Me.reservationIDIndivi_lbl.AutoSize = True
        Me.reservationIDIndivi_lbl.Location = New System.Drawing.Point(8, 29)
        Me.reservationIDIndivi_lbl.Name = "reservationIDIndivi_lbl"
        Me.reservationIDIndivi_lbl.Size = New System.Drawing.Size(81, 13)
        Me.reservationIDIndivi_lbl.TabIndex = 68
        Me.reservationIDIndivi_lbl.Text = "Reservation ID:"
        '
        'reservDateInvidi_lbl
        '
        Me.reservDateInvidi_lbl.AutoSize = True
        Me.reservDateInvidi_lbl.Location = New System.Drawing.Point(333, 106)
        Me.reservDateInvidi_lbl.Name = "reservDateInvidi_lbl"
        Me.reservDateInvidi_lbl.Size = New System.Drawing.Size(93, 13)
        Me.reservDateInvidi_lbl.TabIndex = 67
        Me.reservDateInvidi_lbl.Text = "Reservation Date:"
        '
        'priceIndivi_txt
        '
        Me.priceIndivi_txt.Enabled = False
        Me.priceIndivi_txt.Location = New System.Drawing.Point(107, 130)
        Me.priceIndivi_txt.Name = "priceIndivi_txt"
        Me.priceIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.priceIndivi_txt.TabIndex = 66
        '
        'bookingDateIndivi_lbl
        '
        Me.bookingDateIndivi_lbl.AutoSize = True
        Me.bookingDateIndivi_lbl.Location = New System.Drawing.Point(333, 55)
        Me.bookingDateIndivi_lbl.Name = "bookingDateIndivi_lbl"
        Me.bookingDateIndivi_lbl.Size = New System.Drawing.Size(75, 13)
        Me.bookingDateIndivi_lbl.TabIndex = 65
        Me.bookingDateIndivi_lbl.Text = "Booking Date:"
        '
        'durationIndivi_txt
        '
        Me.durationIndivi_txt.Enabled = False
        Me.durationIndivi_txt.Location = New System.Drawing.Point(107, 233)
        Me.durationIndivi_txt.Name = "durationIndivi_txt"
        Me.durationIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.durationIndivi_txt.TabIndex = 64
        '
        'durationIndivi_lbl
        '
        Me.durationIndivi_lbl.AutoSize = True
        Me.durationIndivi_lbl.Location = New System.Drawing.Point(8, 236)
        Me.durationIndivi_lbl.Name = "durationIndivi_lbl"
        Me.durationIndivi_lbl.Size = New System.Drawing.Size(50, 13)
        Me.durationIndivi_lbl.TabIndex = 63
        Me.durationIndivi_lbl.Text = "Duration:"
        '
        'phoneNOIndivi_txt
        '
        Me.phoneNOIndivi_txt.Enabled = False
        Me.phoneNOIndivi_txt.Location = New System.Drawing.Point(107, 207)
        Me.phoneNOIndivi_txt.Name = "phoneNOIndivi_txt"
        Me.phoneNOIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.phoneNOIndivi_txt.TabIndex = 62
        '
        'phoneNOIndivi_lbl
        '
        Me.phoneNOIndivi_lbl.AutoSize = True
        Me.phoneNOIndivi_lbl.Location = New System.Drawing.Point(8, 210)
        Me.phoneNOIndivi_lbl.Name = "phoneNOIndivi_lbl"
        Me.phoneNOIndivi_lbl.Size = New System.Drawing.Size(81, 13)
        Me.phoneNOIndivi_lbl.TabIndex = 61
        Me.phoneNOIndivi_lbl.Text = "Phone Number:"
        '
        'customerICIndivi_txt
        '
        Me.customerICIndivi_txt.Enabled = False
        Me.customerICIndivi_txt.Location = New System.Drawing.Point(107, 181)
        Me.customerICIndivi_txt.Name = "customerICIndivi_txt"
        Me.customerICIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerICIndivi_txt.TabIndex = 60
        '
        'customerICIndivi_lbl
        '
        Me.customerICIndivi_lbl.AutoSize = True
        Me.customerICIndivi_lbl.Location = New System.Drawing.Point(8, 184)
        Me.customerICIndivi_lbl.Name = "customerICIndivi_lbl"
        Me.customerICIndivi_lbl.Size = New System.Drawing.Size(79, 13)
        Me.customerICIndivi_lbl.TabIndex = 59
        Me.customerICIndivi_lbl.Text = "Customer's I/C:"
        '
        'customerNameIndivi_txt
        '
        Me.customerNameIndivi_txt.Enabled = False
        Me.customerNameIndivi_txt.Location = New System.Drawing.Point(107, 155)
        Me.customerNameIndivi_txt.Name = "customerNameIndivi_txt"
        Me.customerNameIndivi_txt.Size = New System.Drawing.Size(158, 20)
        Me.customerNameIndivi_txt.TabIndex = 58
        '
        'customerNameIndivi_lbl
        '
        Me.customerNameIndivi_lbl.AutoSize = True
        Me.customerNameIndivi_lbl.Location = New System.Drawing.Point(8, 158)
        Me.customerNameIndivi_lbl.Name = "customerNameIndivi_lbl"
        Me.customerNameIndivi_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerNameIndivi_lbl.TabIndex = 57
        Me.customerNameIndivi_lbl.Text = "Customer's Name:"
        '
        'bookingPriceInvidi_lbl
        '
        Me.bookingPriceInvidi_lbl.AutoSize = True
        Me.bookingPriceInvidi_lbl.Location = New System.Drawing.Point(8, 133)
        Me.bookingPriceInvidi_lbl.Name = "bookingPriceInvidi_lbl"
        Me.bookingPriceInvidi_lbl.Size = New System.Drawing.Size(76, 13)
        Me.bookingPriceInvidi_lbl.TabIndex = 56
        Me.bookingPriceInvidi_lbl.Text = "Booking Price:"
        '
        'clearIndivi_btn
        '
        Me.clearIndivi_btn.Enabled = False
        Me.clearIndivi_btn.Location = New System.Drawing.Point(558, 223)
        Me.clearIndivi_btn.Name = "clearIndivi_btn"
        Me.clearIndivi_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearIndivi_btn.TabIndex = 53
        Me.clearIndivi_btn.Text = "Clear"
        Me.clearIndivi_btn.UseVisualStyleBackColor = True
        '
        'updateIndivi_btn
        '
        Me.updateIndivi_btn.Location = New System.Drawing.Point(463, 223)
        Me.updateIndivi_btn.Name = "updateIndivi_btn"
        Me.updateIndivi_btn.Size = New System.Drawing.Size(75, 23)
        Me.updateIndivi_btn.TabIndex = 52
        Me.updateIndivi_btn.Text = "Update"
        Me.updateIndivi_btn.UseVisualStyleBackColor = True
        '
        'FnSTab
        '
        Me.FnSTab.Controls.Add(Me.GroupBox1)
        Me.FnSTab.Location = New System.Drawing.Point(4, 22)
        Me.FnSTab.Margin = New System.Windows.Forms.Padding(2)
        Me.FnSTab.Name = "FnSTab"
        Me.FnSTab.Padding = New System.Windows.Forms.Padding(2)
        Me.FnSTab.Size = New System.Drawing.Size(674, 274)
        Me.FnSTab.TabIndex = 1
        Me.FnSTab.Text = "Facilities & Services"
        Me.FnSTab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bookingDateFnS_txt)
        Me.GroupBox1.Controls.Add(Me.bookingDateFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.reservID_CB)
        Me.GroupBox1.Controls.Add(Me.customerName_txt)
        Me.GroupBox1.Controls.Add(Me.customerName_lbl)
        Me.GroupBox1.Controls.Add(Me.FS_lbl)
        Me.GroupBox1.Controls.Add(Me.typeFnS_CB)
        Me.GroupBox1.Controls.Add(Me.FR_lbl)
        Me.GroupBox1.Controls.Add(Me.nameFnS_CB)
        Me.GroupBox1.Controls.Add(Me.chargesFeesFnS_txt)
        Me.GroupBox1.Controls.Add(Me.FnSID_txt)
        Me.GroupBox1.Controls.Add(Me.reservID_lbl)
        Me.GroupBox1.Controls.Add(Me.FnSID_lbl)
        Me.GroupBox1.Controls.Add(Me.typeFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.roomNOFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.roomNOFnS_CB)
        Me.GroupBox1.Controls.Add(Me.nameFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.chargesFeesFnS_lbl)
        Me.GroupBox1.Controls.Add(Me.clearFnS_btn)
        Me.GroupBox1.Controls.Add(Me.updateFnS_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 269)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Facilities or Services"
        '
        'bookingDateFnS_txt
        '
        Me.bookingDateFnS_txt.Enabled = False
        Me.bookingDateFnS_txt.Location = New System.Drawing.Point(148, 237)
        Me.bookingDateFnS_txt.Name = "bookingDateFnS_txt"
        Me.bookingDateFnS_txt.Size = New System.Drawing.Size(133, 20)
        Me.bookingDateFnS_txt.TabIndex = 73
        '
        'bookingDateFnS_lbl
        '
        Me.bookingDateFnS_lbl.AutoSize = True
        Me.bookingDateFnS_lbl.Location = New System.Drawing.Point(13, 240)
        Me.bookingDateFnS_lbl.Name = "bookingDateFnS_lbl"
        Me.bookingDateFnS_lbl.Size = New System.Drawing.Size(75, 13)
        Me.bookingDateFnS_lbl.TabIndex = 72
        Me.bookingDateFnS_lbl.Text = "Booking Date:"
        '
        'reservID_CB
        '
        Me.reservID_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.reservID_CB.FormattingEnabled = True
        Me.reservID_CB.Location = New System.Drawing.Point(172, 25)
        Me.reservID_CB.Name = "reservID_CB"
        Me.reservID_CB.Size = New System.Drawing.Size(109, 21)
        Me.reservID_CB.TabIndex = 63
        '
        'customerName_txt
        '
        Me.customerName_txt.Enabled = False
        Me.customerName_txt.Location = New System.Drawing.Point(148, 175)
        Me.customerName_txt.Name = "customerName_txt"
        Me.customerName_txt.Size = New System.Drawing.Size(133, 20)
        Me.customerName_txt.TabIndex = 62
        '
        'customerName_lbl
        '
        Me.customerName_lbl.AutoSize = True
        Me.customerName_lbl.Location = New System.Drawing.Point(13, 178)
        Me.customerName_lbl.Name = "customerName_lbl"
        Me.customerName_lbl.Size = New System.Drawing.Size(92, 13)
        Me.customerName_lbl.TabIndex = 61
        Me.customerName_lbl.Text = "Customer's Name:"
        '
        'FS_lbl
        '
        Me.FS_lbl.AutoSize = True
        Me.FS_lbl.Location = New System.Drawing.Point(148, 116)
        Me.FS_lbl.Name = "FS_lbl"
        Me.FS_lbl.Size = New System.Drawing.Size(20, 13)
        Me.FS_lbl.TabIndex = 60
        Me.FS_lbl.Text = "FS"
        '
        'typeFnS_CB
        '
        Me.typeFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeFnS_CB.Enabled = False
        Me.typeFnS_CB.FormattingEnabled = True
        Me.typeFnS_CB.Location = New System.Drawing.Point(148, 52)
        Me.typeFnS_CB.Name = "typeFnS_CB"
        Me.typeFnS_CB.Size = New System.Drawing.Size(133, 21)
        Me.typeFnS_CB.TabIndex = 59
        '
        'FR_lbl
        '
        Me.FR_lbl.AutoSize = True
        Me.FR_lbl.Location = New System.Drawing.Point(145, 28)
        Me.FR_lbl.Name = "FR_lbl"
        Me.FR_lbl.Size = New System.Drawing.Size(21, 13)
        Me.FR_lbl.TabIndex = 58
        Me.FR_lbl.Text = "FR"
        '
        'nameFnS_CB
        '
        Me.nameFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameFnS_CB.Enabled = False
        Me.nameFnS_CB.FormattingEnabled = True
        Me.nameFnS_CB.Location = New System.Drawing.Point(148, 82)
        Me.nameFnS_CB.Name = "nameFnS_CB"
        Me.nameFnS_CB.Size = New System.Drawing.Size(133, 21)
        Me.nameFnS_CB.TabIndex = 56
        '
        'chargesFeesFnS_txt
        '
        Me.chargesFeesFnS_txt.Enabled = False
        Me.chargesFeesFnS_txt.Location = New System.Drawing.Point(148, 206)
        Me.chargesFeesFnS_txt.Name = "chargesFeesFnS_txt"
        Me.chargesFeesFnS_txt.Size = New System.Drawing.Size(133, 20)
        Me.chargesFeesFnS_txt.TabIndex = 55
        '
        'FnSID_txt
        '
        Me.FnSID_txt.Enabled = False
        Me.FnSID_txt.Location = New System.Drawing.Point(174, 113)
        Me.FnSID_txt.Name = "FnSID_txt"
        Me.FnSID_txt.Size = New System.Drawing.Size(107, 20)
        Me.FnSID_txt.TabIndex = 54
        '
        'reservID_lbl
        '
        Me.reservID_lbl.AutoSize = True
        Me.reservID_lbl.Location = New System.Drawing.Point(13, 28)
        Me.reservID_lbl.Name = "reservID_lbl"
        Me.reservID_lbl.Size = New System.Drawing.Size(81, 13)
        Me.reservID_lbl.TabIndex = 52
        Me.reservID_lbl.Text = "Reservation ID:"
        '
        'FnSID_lbl
        '
        Me.FnSID_lbl.AutoSize = True
        Me.FnSID_lbl.Location = New System.Drawing.Point(13, 116)
        Me.FnSID_lbl.Name = "FnSID_lbl"
        Me.FnSID_lbl.Size = New System.Drawing.Size(129, 13)
        Me.FnSID_lbl.TabIndex = 53
        Me.FnSID_lbl.Text = "Facilities and Services ID:"
        '
        'typeFnS_lbl
        '
        Me.typeFnS_lbl.AutoSize = True
        Me.typeFnS_lbl.Location = New System.Drawing.Point(13, 55)
        Me.typeFnS_lbl.Name = "typeFnS_lbl"
        Me.typeFnS_lbl.Size = New System.Drawing.Size(34, 13)
        Me.typeFnS_lbl.TabIndex = 47
        Me.typeFnS_lbl.Text = "Type:"
        '
        'roomNOFnS_lbl
        '
        Me.roomNOFnS_lbl.AutoSize = True
        Me.roomNOFnS_lbl.Location = New System.Drawing.Point(13, 146)
        Me.roomNOFnS_lbl.Name = "roomNOFnS_lbl"
        Me.roomNOFnS_lbl.Size = New System.Drawing.Size(78, 13)
        Me.roomNOFnS_lbl.TabIndex = 48
        Me.roomNOFnS_lbl.Text = "Room Number:"
        '
        'roomNOFnS_CB
        '
        Me.roomNOFnS_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomNOFnS_CB.Enabled = False
        Me.roomNOFnS_CB.FormattingEnabled = True
        Me.roomNOFnS_CB.Location = New System.Drawing.Point(148, 143)
        Me.roomNOFnS_CB.Name = "roomNOFnS_CB"
        Me.roomNOFnS_CB.Size = New System.Drawing.Size(133, 21)
        Me.roomNOFnS_CB.TabIndex = 51
        '
        'nameFnS_lbl
        '
        Me.nameFnS_lbl.AutoSize = True
        Me.nameFnS_lbl.Location = New System.Drawing.Point(13, 85)
        Me.nameFnS_lbl.Name = "nameFnS_lbl"
        Me.nameFnS_lbl.Size = New System.Drawing.Size(38, 13)
        Me.nameFnS_lbl.TabIndex = 49
        Me.nameFnS_lbl.Text = "Name:"
        '
        'chargesFeesFnS_lbl
        '
        Me.chargesFeesFnS_lbl.AutoSize = True
        Me.chargesFeesFnS_lbl.Location = New System.Drawing.Point(13, 209)
        Me.chargesFeesFnS_lbl.Name = "chargesFeesFnS_lbl"
        Me.chargesFeesFnS_lbl.Size = New System.Drawing.Size(75, 13)
        Me.chargesFeesFnS_lbl.TabIndex = 50
        Me.chargesFeesFnS_lbl.Text = "Charges Fees:"
        '
        'clearFnS_btn
        '
        Me.clearFnS_btn.Location = New System.Drawing.Point(558, 223)
        Me.clearFnS_btn.Name = "clearFnS_btn"
        Me.clearFnS_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearFnS_btn.TabIndex = 31
        Me.clearFnS_btn.Text = "Clear"
        Me.clearFnS_btn.UseVisualStyleBackColor = True
        '
        'updateFnS_btn
        '
        Me.updateFnS_btn.Location = New System.Drawing.Point(463, 223)
        Me.updateFnS_btn.Name = "updateFnS_btn"
        Me.updateFnS_btn.Size = New System.Drawing.Size(75, 23)
        Me.updateFnS_btn.TabIndex = 30
        Me.updateFnS_btn.Text = "Update"
        Me.updateFnS_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(627, 413)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.close_btn.MinimumSize = New System.Drawing.Size(55, 16)
        Me.close_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Primary = False
        Me.close_btn.Size = New System.Drawing.Size(55, 36)
        Me.close_btn.TabIndex = 66
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'RMUpdateDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(683, 448)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(682, 378)
        Me.Name = "RMUpdateDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation Management Data Entry"
        Me.RFTabControl.ResumeLayout(False)
        Me.roomTab.ResumeLayout(False)
        Me.room_G.ResumeLayout(False)
        Me.room_G.PerformLayout()
        Me.FnSTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents roomTab As System.Windows.Forms.TabPage
    Friend WithEvents FnSTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents clearFnS_btn As System.Windows.Forms.Button
    Friend WithEvents updateFnS_btn As System.Windows.Forms.Button
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents customerName_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerName_lbl As System.Windows.Forms.Label
    Friend WithEvents FS_lbl As System.Windows.Forms.Label
    Friend WithEvents typeFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents FR_lbl As System.Windows.Forms.Label
    Friend WithEvents nameFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents chargesFeesFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents FnSID_txt As System.Windows.Forms.TextBox
    Friend WithEvents reservID_lbl As System.Windows.Forms.Label
    Friend WithEvents FnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents typeFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents roomNOFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents roomNOFnS_CB As System.Windows.Forms.ComboBox
    Friend WithEvents nameFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents chargesFeesFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents room_G As System.Windows.Forms.GroupBox
    Friend WithEvents reservationIDIndivi_CB As System.Windows.Forms.ComboBox
    Friend WithEvents bookingDateIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents RR_lbl As System.Windows.Forms.Label
    Friend WithEvents reservDateIndivi_dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents reservationIDIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents reservDateInvidi_lbl As System.Windows.Forms.Label
    Friend WithEvents priceIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents bookingDateIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents durationIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents durationIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents phoneNOIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents phoneNOIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents customerICIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerICIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents customerNameIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents customerNameIndivi_lbl As System.Windows.Forms.Label
    Friend WithEvents bookingPriceInvidi_lbl As System.Windows.Forms.Label
    Friend WithEvents clearIndivi_btn As System.Windows.Forms.Button
    Friend WithEvents updateIndivi_btn As System.Windows.Forms.Button
    Friend WithEvents deluxeRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents standardRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents superiorRoom_txt As System.Windows.Forms.TextBox
    Friend WithEvents superiorRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents deluxeRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents standardRoom_lbl As System.Windows.Forms.Label
    Friend WithEvents reservID_CB As System.Windows.Forms.ComboBox
    Friend WithEvents bookingDateFnS_txt As System.Windows.Forms.TextBox
    Friend WithEvents bookingDateFnS_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents depositIndivi_txt As System.Windows.Forms.TextBox
    Friend WithEvents depositIndivi_lbl As System.Windows.Forms.Label
End Class
