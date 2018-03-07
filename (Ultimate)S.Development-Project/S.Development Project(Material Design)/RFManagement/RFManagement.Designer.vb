<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFManagement
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
        Me.SearchRFEntry = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.room_tab = New System.Windows.Forms.TabPage()
        Me.lv_Room = New System.Windows.Forms.ListView()
        Me.Room_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Room_Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FnS_tab = New System.Windows.Forms.TabPage()
        Me.lv_FnS = New System.Windows.Forms.ListView()
        Me.FnSID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FnSType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FnSName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChargePerPerson = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogoutRFMButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.adminMenu_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.TimeNdate = New System.Windows.Forms.Timer(Me.components)
        Me.Role = New System.Windows.Forms.Label()
        Me.nameID = New System.Windows.Forms.Label()
        Me.AddNRRFButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.UpdateRRFButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DeleteRRFButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.refresh_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.filehashing_btn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RFTabControl.SuspendLayout()
        Me.room_tab.SuspendLayout()
        Me.FnS_tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchRFEntry
        '
        Me.SearchRFEntry.Depth = 0
        Me.SearchRFEntry.Hint = ""
        Me.SearchRFEntry.Location = New System.Drawing.Point(152, 798)
        Me.SearchRFEntry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchRFEntry.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchRFEntry.Name = "SearchRFEntry"
        Me.SearchRFEntry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchRFEntry.SelectedText = ""
        Me.SearchRFEntry.SelectionLength = 0
        Me.SearchRFEntry.SelectionStart = 0
        Me.SearchRFEntry.Size = New System.Drawing.Size(784, 39)
        Me.SearchRFEntry.TabIndex = 23
        Me.SearchRFEntry.UseSystemPasswordChar = False
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.room_tab)
        Me.RFTabControl.Controls.Add(Me.FnS_tab)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(14, 179)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(1342, 371)
        Me.RFTabControl.TabIndex = 14
        '
        'room_tab
        '
        Me.room_tab.Controls.Add(Me.lv_Room)
        Me.room_tab.Location = New System.Drawing.Point(4, 34)
        Me.room_tab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.room_tab.Name = "room_tab"
        Me.room_tab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.room_tab.Size = New System.Drawing.Size(1334, 333)
        Me.room_tab.TabIndex = 0
        Me.room_tab.Text = "Room"
        Me.room_tab.UseVisualStyleBackColor = True
        '
        'lv_Room
        '
        Me.lv_Room.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Room_ID, Me.Room_Type, Me.Price, Me.Status})
        Me.lv_Room.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Room.GridLines = True
        Me.lv_Room.Location = New System.Drawing.Point(4, 4)
        Me.lv_Room.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lv_Room.Name = "lv_Room"
        Me.lv_Room.Size = New System.Drawing.Size(1326, 325)
        Me.lv_Room.TabIndex = 1
        Me.lv_Room.UseCompatibleStateImageBehavior = False
        Me.lv_Room.View = System.Windows.Forms.View.Details
        '
        'Room_ID
        '
        Me.Room_ID.Text = "Room ID"
        Me.Room_ID.Width = 97
        '
        'Room_Type
        '
        Me.Room_Type.Text = "Room Type"
        Me.Room_Type.Width = 130
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 104
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 172
        '
        'FnS_tab
        '
        Me.FnS_tab.Controls.Add(Me.lv_FnS)
        Me.FnS_tab.Location = New System.Drawing.Point(4, 34)
        Me.FnS_tab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FnS_tab.Name = "FnS_tab"
        Me.FnS_tab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FnS_tab.Size = New System.Drawing.Size(1334, 333)
        Me.FnS_tab.TabIndex = 1
        Me.FnS_tab.Text = "Facilities & Services"
        Me.FnS_tab.UseVisualStyleBackColor = True
        '
        'lv_FnS
        '
        Me.lv_FnS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FnSID, Me.FnSType, Me.FnSName, Me.ChargePerPerson})
        Me.lv_FnS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_FnS.GridLines = True
        Me.lv_FnS.Location = New System.Drawing.Point(4, 4)
        Me.lv_FnS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lv_FnS.Name = "lv_FnS"
        Me.lv_FnS.Size = New System.Drawing.Size(1326, 325)
        Me.lv_FnS.TabIndex = 1
        Me.lv_FnS.UseCompatibleStateImageBehavior = False
        Me.lv_FnS.View = System.Windows.Forms.View.Details
        '
        'FnSID
        '
        Me.FnSID.Text = "Facilities & Services ID"
        Me.FnSID.Width = 150
        '
        'FnSType
        '
        Me.FnSType.Text = "Facilities & Services Type"
        Me.FnSType.Width = 150
        '
        'FnSName
        '
        Me.FnSName.Text = "Facilities & Services Name"
        Me.FnSName.Width = 150
        '
        'ChargePerPerson
        '
        Me.ChargePerPerson.Text = "Charge per person"
        Me.ChargePerPerson.Width = 150
        '
        'LogoutRFMButton
        '
        Me.LogoutRFMButton.AutoSize = True
        Me.LogoutRFMButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogoutRFMButton.BackColor = System.Drawing.Color.Transparent
        Me.LogoutRFMButton.Depth = 0
        Me.LogoutRFMButton.Location = New System.Drawing.Point(1232, 798)
        Me.LogoutRFMButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LogoutRFMButton.MinimumSize = New System.Drawing.Size(110, 31)
        Me.LogoutRFMButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.LogoutRFMButton.Name = "LogoutRFMButton"
        Me.LogoutRFMButton.Primary = False
        Me.LogoutRFMButton.Size = New System.Drawing.Size(116, 36)
        Me.LogoutRFMButton.TabIndex = 40
        Me.LogoutRFMButton.Text = "Logout"
        Me.LogoutRFMButton.UseVisualStyleBackColor = False
        '
        'adminMenu_btn
        '
        Me.adminMenu_btn.Depth = 0
        Me.adminMenu_btn.Location = New System.Drawing.Point(1162, 571)
        Me.adminMenu_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.adminMenu_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.adminMenu_btn.Name = "adminMenu_btn"
        Me.adminMenu_btn.Primary = True
        Me.adminMenu_btn.Size = New System.Drawing.Size(194, 44)
        Me.adminMenu_btn.TabIndex = 43
        Me.adminMenu_btn.Text = "Admin menu"
        Me.adminMenu_btn.UseVisualStyleBackColor = True
        Me.adminMenu_btn.Visible = False
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
        Me.currentTime_lbl.TabIndex = 51
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
        Me.currentDate_lbl.TabIndex = 50
        Me.currentDate_lbl.Text = "Date"
        '
        'TimeNdate
        '
        Me.TimeNdate.Enabled = True
        '
        'Role
        '
        Me.Role.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Role.AutoSize = True
        Me.Role.BackColor = System.Drawing.Color.Transparent
        Me.Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.ForeColor = System.Drawing.Color.White
        Me.Role.Location = New System.Drawing.Point(994, 76)
        Me.Role.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(48, 25)
        Me.Role.TabIndex = 53
        Me.Role.Text = "role"
        '
        'nameID
        '
        Me.nameID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nameID.AutoSize = True
        Me.nameID.BackColor = System.Drawing.Color.Transparent
        Me.nameID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameID.ForeColor = System.Drawing.Color.White
        Me.nameID.Location = New System.Drawing.Point(884, 76)
        Me.nameID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameID.Name = "nameID"
        Me.nameID.Size = New System.Drawing.Size(65, 25)
        Me.nameID.TabIndex = 52
        Me.nameID.Text = "name"
        '
        'AddNRRFButton
        '
        Me.AddNRRFButton.Depth = 0
        Me.AddNRRFButton.Location = New System.Drawing.Point(22, 571)
        Me.AddNRRFButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddNRRFButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AddNRRFButton.Name = "AddNRRFButton"
        Me.AddNRRFButton.Primary = True
        Me.AddNRRFButton.Size = New System.Drawing.Size(372, 96)
        Me.AddNRRFButton.TabIndex = 54
        Me.AddNRRFButton.Text = "Add New Room/Facilities & Services"
        Me.AddNRRFButton.UseVisualStyleBackColor = True
        '
        'UpdateRRFButton
        '
        Me.UpdateRRFButton.Depth = 0
        Me.UpdateRRFButton.Location = New System.Drawing.Point(402, 571)
        Me.UpdateRRFButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdateRRFButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.UpdateRRFButton.Name = "UpdateRRFButton"
        Me.UpdateRRFButton.Primary = True
        Me.UpdateRRFButton.Size = New System.Drawing.Size(372, 96)
        Me.UpdateRRFButton.TabIndex = 55
        Me.UpdateRRFButton.Text = "Update Room/Facilities & Services Details"
        Me.UpdateRRFButton.UseVisualStyleBackColor = True
        '
        'DeleteRRFButton
        '
        Me.DeleteRRFButton.Depth = 0
        Me.DeleteRRFButton.Location = New System.Drawing.Point(782, 571)
        Me.DeleteRRFButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteRRFButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.DeleteRRFButton.Name = "DeleteRRFButton"
        Me.DeleteRRFButton.Primary = True
        Me.DeleteRRFButton.Size = New System.Drawing.Size(372, 96)
        Me.DeleteRRFButton.TabIndex = 56
        Me.DeleteRRFButton.Text = "Delete Room/Facilities & Services"
        Me.DeleteRRFButton.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(28, 802)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 34)
        Me.MaterialLabel1.TabIndex = 57
        Me.MaterialLabel1.Text = "Search:"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-4, 123)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1370, 48)
        Me.MaterialTabSelector1.TabIndex = 15
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'refresh_btn
        '
        Me.refresh_btn.Depth = 0
        Me.refresh_btn.Location = New System.Drawing.Point(1162, 623)
        Me.refresh_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.refresh_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Primary = True
        Me.refresh_btn.Size = New System.Drawing.Size(194, 44)
        Me.refresh_btn.TabIndex = 58
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'filehashing_btn
        '
        Me.filehashing_btn.Depth = 0
        Me.filehashing_btn.Location = New System.Drawing.Point(22, 699)
        Me.filehashing_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.filehashing_btn.MouseState = MaterialSkin.MouseState.HOVER
        Me.filehashing_btn.Name = "filehashing_btn"
        Me.filehashing_btn.Primary = True
        Me.filehashing_btn.Size = New System.Drawing.Size(267, 57)
        Me.filehashing_btn.TabIndex = 66
        Me.filehashing_btn.Text = "File Hashing"
        Me.filehashing_btn.UseVisualStyleBackColor = True
        '
        'RFManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 881)
        Me.Controls.Add(Me.filehashing_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.DeleteRRFButton)
        Me.Controls.Add(Me.UpdateRRFButton)
        Me.Controls.Add(Me.AddNRRFButton)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.nameID)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.adminMenu_btn)
        Me.Controls.Add(Me.LogoutRFMButton)
        Me.Controls.Add(Me.SearchRFEntry)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "RFManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms & Facilities Management"
        Me.RFTabControl.ResumeLayout(False)
        Me.room_tab.ResumeLayout(False)
        Me.FnS_tab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchRFEntry As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents room_tab As System.Windows.Forms.TabPage
    Friend WithEvents FnS_tab As System.Windows.Forms.TabPage
    Friend WithEvents LogoutRFMButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents adminMenu_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeNdate As System.Windows.Forms.Timer
    Friend WithEvents Role As System.Windows.Forms.Label
    Friend WithEvents nameID As System.Windows.Forms.Label
    Friend WithEvents lv_Room As System.Windows.Forms.ListView
    Friend WithEvents Room_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Room_Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddNRRFButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents UpdateRRFButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents DeleteRRFButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lv_FnS As System.Windows.Forms.ListView
    Friend WithEvents FnSID As System.Windows.Forms.ColumnHeader
    Friend WithEvents FnSType As System.Windows.Forms.ColumnHeader
    Friend WithEvents FnSName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChargePerPerson As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents refresh_btn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents filehashing_btn As MaterialSkin.Controls.MaterialRaisedButton
End Class
