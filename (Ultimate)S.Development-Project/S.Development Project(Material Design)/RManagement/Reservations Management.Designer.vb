<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations_Management
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
        Me.SearchREntry = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DeleteRRButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.UpdateRRButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ReservationReportButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.AddPaymentRButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.AddRRButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lv_Room = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lv_FnS = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogoutRMButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.adminMenu_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Role = New System.Windows.Forms.Label()
        Me.nameID = New System.Windows.Forms.Label()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.refresh_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.filehashing_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RFTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchREntry
        '
        Me.SearchREntry.Depth = 0
        Me.SearchREntry.Hint = ""
        Me.SearchREntry.Location = New System.Drawing.Point(156, 698)
        Me.SearchREntry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchREntry.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchREntry.Name = "SearchREntry"
        Me.SearchREntry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchREntry.SelectedText = ""
        Me.SearchREntry.SelectionLength = 0
        Me.SearchREntry.SelectionStart = 0
        Me.SearchREntry.Size = New System.Drawing.Size(784, 39)
        Me.SearchREntry.TabIndex = 13
        Me.SearchREntry.UseSystemPasswordChar = False
        '
        'DeleteRRButton
        '
        Me.DeleteRRButton.Depth = 0
        Me.DeleteRRButton.Location = New System.Drawing.Point(770, 571)
        Me.DeleteRRButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteRRButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.DeleteRRButton.Name = "DeleteRRButton"
        Me.DeleteRRButton.Primary = True
        Me.DeleteRRButton.Size = New System.Drawing.Size(372, 44)
        Me.DeleteRRButton.TabIndex = 6
        Me.DeleteRRButton.Text = "Delete Reservation"
        Me.DeleteRRButton.UseVisualStyleBackColor = True
        '
        'UpdateRRButton
        '
        Me.UpdateRRButton.Depth = 0
        Me.UpdateRRButton.Location = New System.Drawing.Point(392, 571)
        Me.UpdateRRButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdateRRButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.UpdateRRButton.Name = "UpdateRRButton"
        Me.UpdateRRButton.Primary = True
        Me.UpdateRRButton.Size = New System.Drawing.Size(372, 44)
        Me.UpdateRRButton.TabIndex = 7
        Me.UpdateRRButton.Text = "Update Reservation(s)"
        Me.UpdateRRButton.UseVisualStyleBackColor = True
        '
        'ReservationReportButton
        '
        Me.ReservationReportButton.Depth = 0
        Me.ReservationReportButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReservationReportButton.Location = New System.Drawing.Point(418, 621)
        Me.ReservationReportButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReservationReportButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReservationReportButton.Name = "ReservationReportButton"
        Me.ReservationReportButton.Primary = True
        Me.ReservationReportButton.Size = New System.Drawing.Size(396, 44)
        Me.ReservationReportButton.TabIndex = 8
        Me.ReservationReportButton.Text = "Reservation Report"
        Me.ReservationReportButton.UseVisualStyleBackColor = True
        '
        'AddPaymentRButton
        '
        Me.AddPaymentRButton.Depth = 0
        Me.AddPaymentRButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddPaymentRButton.Location = New System.Drawing.Point(14, 621)
        Me.AddPaymentRButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddPaymentRButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddPaymentRButton.Name = "AddPaymentRButton"
        Me.AddPaymentRButton.Primary = True
        Me.AddPaymentRButton.Size = New System.Drawing.Size(396, 44)
        Me.AddPaymentRButton.TabIndex = 10
        Me.AddPaymentRButton.Text = "Add new payment"
        Me.AddPaymentRButton.UseVisualStyleBackColor = True
        '
        'AddRRButton
        '
        Me.AddRRButton.Depth = 0
        Me.AddRRButton.Location = New System.Drawing.Point(14, 571)
        Me.AddRRButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddRRButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddRRButton.Name = "AddRRButton"
        Me.AddRRButton.Primary = True
        Me.AddRRButton.Size = New System.Drawing.Size(372, 44)
        Me.AddRRButton.TabIndex = 12
        Me.AddRRButton.Text = "Add new Reservation(s)"
        Me.AddRRButton.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 123)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1366, 48)
        Me.MaterialTabSelector1.TabIndex = 5
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.TabPage1)
        Me.RFTabControl.Controls.Add(Me.TabPage2)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(2, 179)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(1364, 371)
        Me.RFTabControl.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lv_Room)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1356, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Individual Reservation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lv_Room
        '
        Me.lv_Room.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader20, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader21, Me.ColumnHeader22})
        Me.lv_Room.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Room.GridLines = True
        Me.lv_Room.Location = New System.Drawing.Point(4, 4)
        Me.lv_Room.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lv_Room.Name = "lv_Room"
        Me.lv_Room.Size = New System.Drawing.Size(1348, 325)
        Me.lv_Room.TabIndex = 0
        Me.lv_Room.UseCompatibleStateImageBehavior = False
        Me.lv_Room.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Tag = ""
        Me.ColumnHeader1.Text = "Room Reservation ID"
        Me.ColumnHeader1.Width = 115
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Standard Room"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Deluxe Room"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Superior Room"
        Me.ColumnHeader4.Width = 88
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Booking Price"
        Me.ColumnHeader5.Width = 78
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Deposit"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Customer Name"
        Me.ColumnHeader6.Width = 92
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "I/C Number"
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Phone Number"
        Me.ColumnHeader8.Width = 91
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Duration"
        Me.ColumnHeader9.Width = 58
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Booking Date & Time"
        Me.ColumnHeader10.Width = 117
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Reservation Date & Time"
        Me.ColumnHeader11.Width = 131
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Reservation Type"
        Me.ColumnHeader21.Width = 100
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Status"
        Me.ColumnHeader22.Width = 51
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lv_FnS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1356, 333)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facilities & Services"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lv_FnS
        '
        Me.lv_FnS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader23})
        Me.lv_FnS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_FnS.GridLines = True
        Me.lv_FnS.Location = New System.Drawing.Point(4, 4)
        Me.lv_FnS.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lv_FnS.Name = "lv_FnS"
        Me.lv_FnS.Size = New System.Drawing.Size(1348, 325)
        Me.lv_FnS.TabIndex = 0
        Me.lv_FnS.UseCompatibleStateImageBehavior = False
        Me.lv_FnS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Facilities & Services Reservation ID"
        Me.ColumnHeader12.Width = 184
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Facilities & Services Type"
        Me.ColumnHeader13.Width = 137
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Facilities & Services Name"
        Me.ColumnHeader14.Width = 141
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Facilities & Services ID"
        Me.ColumnHeader15.Width = 123
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Room ID"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Customer Name"
        Me.ColumnHeader17.Width = 96
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Charges Fee"
        Me.ColumnHeader18.Width = 77
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Book Date & Time"
        Me.ColumnHeader19.Width = 105
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Status"
        '
        'LogoutRMButton
        '
        Me.LogoutRMButton.AutoSize = True
        Me.LogoutRMButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogoutRMButton.BackColor = System.Drawing.Color.Transparent
        Me.LogoutRMButton.Depth = 0
        Me.LogoutRMButton.Location = New System.Drawing.Point(1236, 698)
        Me.LogoutRMButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LogoutRMButton.MinimumSize = New System.Drawing.Size(110, 31)
        Me.LogoutRMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.LogoutRMButton.Name = "LogoutRMButton"
        Me.LogoutRMButton.Primary = False
        Me.LogoutRMButton.Size = New System.Drawing.Size(116, 36)
        Me.LogoutRMButton.TabIndex = 37
        Me.LogoutRMButton.Text = "Logout"
        Me.LogoutRMButton.UseVisualStyleBackColor = False
        '
        'adminMenu_btn
        '
        Me.adminMenu_btn.Depth = 0
        Me.adminMenu_btn.Location = New System.Drawing.Point(1150, 571)
        Me.adminMenu_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.adminMenu_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.adminMenu_btn.Name = "adminMenu_btn"
        Me.adminMenu_btn.Primary = True
        Me.adminMenu_btn.Size = New System.Drawing.Size(194, 44)
        Me.adminMenu_btn.TabIndex = 44
        Me.adminMenu_btn.Text = "Admin menu"
        Me.adminMenu_btn.UseVisualStyleBackColor = True
        Me.adminMenu_btn.Visible = False
        '
        'Role
        '
        Me.Role.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Role.AutoSize = True
        Me.Role.BackColor = System.Drawing.Color.Transparent
        Me.Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.ForeColor = System.Drawing.Color.White
        Me.Role.Location = New System.Drawing.Point(994, 71)
        Me.Role.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(48, 25)
        Me.Role.TabIndex = 47
        Me.Role.Text = "role"
        '
        'nameID
        '
        Me.nameID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nameID.AutoSize = True
        Me.nameID.BackColor = System.Drawing.Color.Transparent
        Me.nameID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameID.ForeColor = System.Drawing.Color.White
        Me.nameID.Location = New System.Drawing.Point(884, 71)
        Me.nameID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameID.Name = "nameID"
        Me.nameID.Size = New System.Drawing.Size(65, 25)
        Me.nameID.TabIndex = 46
        Me.nameID.Text = "name"
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentTime_lbl.ForeColor = System.Drawing.Color.White
        Me.currentTime_lbl.Location = New System.Drawing.Point(1202, 71)
        Me.currentTime_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(59, 25)
        Me.currentTime_lbl.TabIndex = 49
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.BackColor = System.Drawing.Color.Transparent
        Me.currentDate_lbl.ForeColor = System.Drawing.Color.White
        Me.currentDate_lbl.Location = New System.Drawing.Point(1074, 71)
        Me.currentDate_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(57, 25)
        Me.currentDate_lbl.TabIndex = 48
        Me.currentDate_lbl.Text = "Date"
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(32, 702)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 34)
        Me.MaterialLabel1.TabIndex = 50
        Me.MaterialLabel1.Text = "Search:"
        '
        'refresh_btn
        '
        Me.refresh_btn.Depth = 0
        Me.refresh_btn.Location = New System.Drawing.Point(1150, 623)
        Me.refresh_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.refresh_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Primary = True
        Me.refresh_btn.Size = New System.Drawing.Size(194, 44)
        Me.refresh_btn.TabIndex = 59
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'filehashing_btn
        '
        Me.filehashing_btn.Depth = 0
        Me.filehashing_btn.Location = New System.Drawing.Point(822, 621)
        Me.filehashing_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.filehashing_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.filehashing_btn.Name = "filehashing_btn"
        Me.filehashing_btn.Primary = True
        Me.filehashing_btn.Size = New System.Drawing.Size(236, 42)
        Me.filehashing_btn.TabIndex = 67
        Me.filehashing_btn.Text = "File Hashing"
        Me.filehashing_btn.UseVisualStyleBackColor = True
        '
        'Reservations_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 767)
        Me.Controls.Add(Me.filehashing_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.nameID)
        Me.Controls.Add(Me.adminMenu_btn)
        Me.Controls.Add(Me.LogoutRMButton)
        Me.Controls.Add(Me.SearchREntry)
        Me.Controls.Add(Me.DeleteRRButton)
        Me.Controls.Add(Me.UpdateRRButton)
        Me.Controls.Add(Me.ReservationReportButton)
        Me.Controls.Add(Me.AddPaymentRButton)
        Me.Controls.Add(Me.AddRRButton)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Reservations_Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations Management"
        Me.RFTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchREntry As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DeleteRRButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents UpdateRRButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ReservationReportButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents AddPaymentRButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents AddRRButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LogoutRMButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents adminMenu_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Role As System.Windows.Forms.Label
    Friend WithEvents nameID As System.Windows.Forms.Label
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents lv_Room As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv_FnS As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents refresh_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents filehashing_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
