﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFMAddDataEntry
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
        Me.room_Tab = New System.Windows.Forms.TabPage()
        Me.addRoom_G = New System.Windows.Forms.GroupBox()
        Me.roomType_CB = New System.Windows.Forms.ComboBox()
        Me.price_txt = New System.Windows.Forms.TextBox()
        Me.roomID_txt = New System.Windows.Forms.TextBox()
        Me.clearR_btn = New System.Windows.Forms.Button()
        Me.addR_btn = New System.Windows.Forms.Button()
        Me.roomID_lbl = New System.Windows.Forms.Label()
        Me.roomType_lbl = New System.Windows.Forms.Label()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.FnS_Tab = New System.Windows.Forms.TabPage()
        Me.addFnS_G = New System.Windows.Forms.GroupBox()
        Me.FnSType_CB = New System.Windows.Forms.ComboBox()
        Me.FnSName_txt = New System.Windows.Forms.TextBox()
        Me.FnSID_txt = New System.Windows.Forms.TextBox()
        Me.chargesFees_txt = New System.Windows.Forms.TextBox()
        Me.clearFnS_btn = New System.Windows.Forms.Button()
        Me.addFnS_btn = New System.Windows.Forms.Button()
        Me.FnSID_lbl = New System.Windows.Forms.Label()
        Me.FnSType_lbl = New System.Windows.Forms.Label()
        Me.FnSName_lbl = New System.Windows.Forms.Label()
        Me.chargesFees_lbl = New System.Windows.Forms.Label()
        Me.close_btn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.RFTabControl.SuspendLayout()
        Me.room_Tab.SuspendLayout()
        Me.addRoom_G.SuspendLayout()
        Me.FnS_Tab.SuspendLayout()
        Me.addFnS_G.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 50)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(683, 25)
        Me.MaterialTabSelector1.TabIndex = 9
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.room_Tab)
        Me.RFTabControl.Controls.Add(Me.FnS_Tab)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(0, 79)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(682, 270)
        Me.RFTabControl.TabIndex = 8
        '
        'room_Tab
        '
        Me.room_Tab.Controls.Add(Me.addRoom_G)
        Me.room_Tab.Location = New System.Drawing.Point(4, 22)
        Me.room_Tab.Margin = New System.Windows.Forms.Padding(2)
        Me.room_Tab.Name = "room_Tab"
        Me.room_Tab.Padding = New System.Windows.Forms.Padding(2)
        Me.room_Tab.Size = New System.Drawing.Size(674, 244)
        Me.room_Tab.TabIndex = 0
        Me.room_Tab.Text = "Room"
        Me.room_Tab.UseVisualStyleBackColor = True
        '
        'addRoom_G
        '
        Me.addRoom_G.Controls.Add(Me.roomType_CB)
        Me.addRoom_G.Controls.Add(Me.price_txt)
        Me.addRoom_G.Controls.Add(Me.roomID_txt)
        Me.addRoom_G.Controls.Add(Me.clearR_btn)
        Me.addRoom_G.Controls.Add(Me.addR_btn)
        Me.addRoom_G.Controls.Add(Me.roomID_lbl)
        Me.addRoom_G.Controls.Add(Me.roomType_lbl)
        Me.addRoom_G.Controls.Add(Me.price_lbl)
        Me.addRoom_G.Location = New System.Drawing.Point(7, 5)
        Me.addRoom_G.Name = "addRoom_G"
        Me.addRoom_G.Size = New System.Drawing.Size(669, 236)
        Me.addRoom_G.TabIndex = 28
        Me.addRoom_G.TabStop = False
        Me.addRoom_G.Text = "Add Room"
        '
        'roomType_CB
        '
        Me.roomType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roomType_CB.FormattingEnabled = True
        Me.roomType_CB.Items.AddRange(New Object() {"Standard Room", "Deluxe Room", "Superior Room"})
        Me.roomType_CB.Location = New System.Drawing.Point(114, 61)
        Me.roomType_CB.Name = "roomType_CB"
        Me.roomType_CB.Size = New System.Drawing.Size(110, 21)
        Me.roomType_CB.TabIndex = 36
        '
        'price_txt
        '
        Me.price_txt.Location = New System.Drawing.Point(114, 91)
        Me.price_txt.Name = "price_txt"
        Me.price_txt.Size = New System.Drawing.Size(110, 20)
        Me.price_txt.TabIndex = 33
        '
        'roomID_txt
        '
        Me.roomID_txt.Enabled = False
        Me.roomID_txt.Location = New System.Drawing.Point(114, 32)
        Me.roomID_txt.Name = "roomID_txt"
        Me.roomID_txt.Size = New System.Drawing.Size(110, 20)
        Me.roomID_txt.TabIndex = 32
        '
        'clearR_btn
        '
        Me.clearR_btn.Location = New System.Drawing.Point(558, 197)
        Me.clearR_btn.Name = "clearR_btn"
        Me.clearR_btn.Size = New System.Drawing.Size(75, 23)
        Me.clearR_btn.TabIndex = 31
        Me.clearR_btn.Text = "Clear"
        Me.clearR_btn.UseVisualStyleBackColor = True
        '
        'addR_btn
        '
        Me.addR_btn.Location = New System.Drawing.Point(463, 197)
        Me.addR_btn.Name = "addR_btn"
        Me.addR_btn.Size = New System.Drawing.Size(75, 23)
        Me.addR_btn.TabIndex = 30
        Me.addR_btn.Text = "Add"
        Me.addR_btn.UseVisualStyleBackColor = True
        '
        'roomID_lbl
        '
        Me.roomID_lbl.AutoSize = True
        Me.roomID_lbl.Location = New System.Drawing.Point(22, 35)
        Me.roomID_lbl.Name = "roomID_lbl"
        Me.roomID_lbl.Size = New System.Drawing.Size(55, 13)
        Me.roomID_lbl.TabIndex = 12
        Me.roomID_lbl.Text = "Room ID："
        '
        'roomType_lbl
        '
        Me.roomType_lbl.AutoSize = True
        Me.roomType_lbl.Location = New System.Drawing.Point(22, 64)
        Me.roomType_lbl.Name = "roomType_lbl"
        Me.roomType_lbl.Size = New System.Drawing.Size(65, 13)
        Me.roomType_lbl.TabIndex = 14
        Me.roomType_lbl.Text = "Room Type:"
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Location = New System.Drawing.Point(22, 94)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(34, 13)
        Me.price_lbl.TabIndex = 16
        Me.price_lbl.Text = "Price:"
        '
        'FnS_Tab
        '
        Me.FnS_Tab.Controls.Add(Me.addFnS_G)
        Me.FnS_Tab.Location = New System.Drawing.Point(4, 22)
        Me.FnS_Tab.Margin = New System.Windows.Forms.Padding(2)
        Me.FnS_Tab.Name = "FnS_Tab"
        Me.FnS_Tab.Padding = New System.Windows.Forms.Padding(2)
        Me.FnS_Tab.Size = New System.Drawing.Size(674, 244)
        Me.FnS_Tab.TabIndex = 1
        Me.FnS_Tab.Text = "Facilities & Services"
        Me.FnS_Tab.UseVisualStyleBackColor = True
        '
        'addFnS_G
        '
        Me.addFnS_G.Controls.Add(Me.FnSType_CB)
        Me.addFnS_G.Controls.Add(Me.FnSName_txt)
        Me.addFnS_G.Controls.Add(Me.FnSID_txt)
        Me.addFnS_G.Controls.Add(Me.chargesFees_txt)
        Me.addFnS_G.Controls.Add(Me.clearFnS_btn)
        Me.addFnS_G.Controls.Add(Me.addFnS_btn)
        Me.addFnS_G.Controls.Add(Me.FnSID_lbl)
        Me.addFnS_G.Controls.Add(Me.FnSType_lbl)
        Me.addFnS_G.Controls.Add(Me.FnSName_lbl)
        Me.addFnS_G.Controls.Add(Me.chargesFees_lbl)
        Me.addFnS_G.Location = New System.Drawing.Point(7, 5)
        Me.addFnS_G.Name = "addFnS_G"
        Me.addFnS_G.Size = New System.Drawing.Size(669, 236)
        Me.addFnS_G.TabIndex = 27
        Me.addFnS_G.TabStop = False
        Me.addFnS_G.Text = "Add Facilities or Services"
        '
        'FnSType_CB
        '
        Me.FnSType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FnSType_CB.FormattingEnabled = True
        Me.FnSType_CB.Items.AddRange(New Object() {"Facilities", "Services"})
        Me.FnSType_CB.Location = New System.Drawing.Point(174, 61)
        Me.FnSType_CB.Name = "FnSType_CB"
        Me.FnSType_CB.Size = New System.Drawing.Size(110, 21)
        Me.FnSType_CB.TabIndex = 35
        '
        'FnSName_txt
        '
        Me.FnSName_txt.Location = New System.Drawing.Point(174, 91)
        Me.FnSName_txt.Name = "FnSName_txt"
        Me.FnSName_txt.Size = New System.Drawing.Size(110, 20)
        Me.FnSName_txt.TabIndex = 34
        '
        'FnSID_txt
        '
        Me.FnSID_txt.Enabled = False
        Me.FnSID_txt.Location = New System.Drawing.Point(174, 32)
        Me.FnSID_txt.Name = "FnSID_txt"
        Me.FnSID_txt.Size = New System.Drawing.Size(110, 20)
        Me.FnSID_txt.TabIndex = 33
        '
        'chargesFees_txt
        '
        Me.chargesFees_txt.Location = New System.Drawing.Point(174, 121)
        Me.chargesFees_txt.Name = "chargesFees_txt"
        Me.chargesFees_txt.Size = New System.Drawing.Size(110, 20)
        Me.chargesFees_txt.TabIndex = 32
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
        'FnSID_lbl
        '
        Me.FnSID_lbl.AutoSize = True
        Me.FnSID_lbl.Location = New System.Drawing.Point(22, 35)
        Me.FnSID_lbl.Name = "FnSID_lbl"
        Me.FnSID_lbl.Size = New System.Drawing.Size(129, 13)
        Me.FnSID_lbl.TabIndex = 12
        Me.FnSID_lbl.Text = "Facilities and Services ID:"
        '
        'FnSType_lbl
        '
        Me.FnSType_lbl.AutoSize = True
        Me.FnSType_lbl.Location = New System.Drawing.Point(22, 64)
        Me.FnSType_lbl.Name = "FnSType_lbl"
        Me.FnSType_lbl.Size = New System.Drawing.Size(142, 13)
        Me.FnSType_lbl.TabIndex = 14
        Me.FnSType_lbl.Text = "Facilities and Services Type:"
        '
        'FnSName_lbl
        '
        Me.FnSName_lbl.AutoSize = True
        Me.FnSName_lbl.Location = New System.Drawing.Point(22, 94)
        Me.FnSName_lbl.Name = "FnSName_lbl"
        Me.FnSName_lbl.Size = New System.Drawing.Size(146, 13)
        Me.FnSName_lbl.TabIndex = 16
        Me.FnSName_lbl.Text = "Facilities and Services Name:"
        '
        'chargesFees_lbl
        '
        Me.chargesFees_lbl.AutoSize = True
        Me.chargesFees_lbl.Location = New System.Drawing.Point(22, 124)
        Me.chargesFees_lbl.Name = "chargesFees_lbl"
        Me.chargesFees_lbl.Size = New System.Drawing.Size(75, 13)
        Me.chargesFees_lbl.TabIndex = 18
        Me.chargesFees_lbl.Text = "Charges Fees:"
        '
        'close_btn
        '
        Me.close_btn.AutoSize = True
        Me.close_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.close_btn.BackColor = System.Drawing.Color.Transparent
        Me.close_btn.Depth = 0
        Me.close_btn.Location = New System.Drawing.Point(627, 362)
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
        'RFMAddDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 399)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "RFMAddDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms & Facilities Management Data Entry"
        Me.RFTabControl.ResumeLayout(False)
        Me.room_Tab.ResumeLayout(False)
        Me.addRoom_G.ResumeLayout(False)
        Me.addRoom_G.PerformLayout()
        Me.FnS_Tab.ResumeLayout(False)
        Me.addFnS_G.ResumeLayout(False)
        Me.addFnS_G.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents room_Tab As System.Windows.Forms.TabPage
    Friend WithEvents addRoom_G As System.Windows.Forms.GroupBox
    Friend WithEvents clearR_btn As System.Windows.Forms.Button
    Friend WithEvents addR_btn As System.Windows.Forms.Button
    Friend WithEvents roomID_lbl As System.Windows.Forms.Label
    Friend WithEvents roomType_lbl As System.Windows.Forms.Label
    Friend WithEvents price_lbl As System.Windows.Forms.Label
    Friend WithEvents FnS_Tab As System.Windows.Forms.TabPage
    Friend WithEvents addFnS_G As System.Windows.Forms.GroupBox
    Friend WithEvents clearFnS_btn As System.Windows.Forms.Button
    Friend WithEvents addFnS_btn As System.Windows.Forms.Button
    Friend WithEvents FnSID_lbl As System.Windows.Forms.Label
    Friend WithEvents FnSType_lbl As System.Windows.Forms.Label
    Friend WithEvents FnSName_lbl As System.Windows.Forms.Label
    Friend WithEvents chargesFees_lbl As System.Windows.Forms.Label
    Friend WithEvents price_txt As System.Windows.Forms.TextBox
    Friend WithEvents roomID_txt As System.Windows.Forms.TextBox
    Friend WithEvents FnSName_txt As System.Windows.Forms.TextBox
    Friend WithEvents FnSID_txt As System.Windows.Forms.TextBox
    Friend WithEvents chargesFees_txt As System.Windows.Forms.TextBox
    Friend WithEvents close_btn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FnSType_CB As System.Windows.Forms.ComboBox
    Friend WithEvents roomType_CB As System.Windows.Forms.ComboBox
End Class
