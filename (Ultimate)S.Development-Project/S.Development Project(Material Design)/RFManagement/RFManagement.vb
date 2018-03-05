Imports System.Data.OleDb
Imports MaterialSkin

Public Class RFManagement
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2, Sql3 As String
    Dim ButtonCheck As Boolean
    Dim totalRec, totalRec1, totalRec2, totalRec3, curRec, curRec1, curRec2, curRec3 As Integer
    Dim a As Boolean = False

    Private Sub RFManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Role.Text <> "Admin" Then
            If ButtonCheck = False Then
                Login.Close()
            End If
        End If

        If Role.Text = "Admin" Then
            If ButtonCheck = False Then
                MenuForAdmin.Close()
            End If
        End If
    End Sub

    Public Sub Room()
        con.Open()
        ds.Clear()
        Sql = "SELECT * FROM Room"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomReservation")
        totalRec = ds.Tables("RoomReservation").Rows.Count - 1

        For Me.curRec = 0 To totalRec
            Dim lv_item As String() = New String(4) {}
            Dim item As ListViewItem
            lv_item(0) = ds.Tables("RoomReservation").Rows(curRec).Item(0)
            lv_item(1) = ds.Tables("RoomReservation").Rows(curRec).Item(1)
            lv_item(2) = ds.Tables("RoomReservation").Rows(curRec).Item(2)
            lv_item(3) = ds.Tables("RoomReservation").Rows(curRec).Item(3)
            item = New ListViewItem(lv_item)
            lv_Room.Items.Add(item)
        Next
        con.Close()
    End Sub
    Public Sub FnS()
        con.Open()
        ds1.Clear()
        Sql1 = "SELECT * FROM FacilitiesAndServices"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "FacilitiesAndServices")
        totalRec1 = ds1.Tables("FacilitiesAndServices").Rows.Count - 1


        For Me.curRec1 = 0 To totalRec1
            Dim lv_item As String() = New String(4) {}
            Dim item As ListViewItem
            lv_item(0) = ds1.Tables("FacilitiesAndServices").Rows(curRec1).Item(0)
            lv_item(1) = ds1.Tables("FacilitiesAndServices").Rows(curRec1).Item(1)
            lv_item(2) = ds1.Tables("FacilitiesAndServices").Rows(curRec1).Item(2)
            lv_item(3) = ds1.Tables("FacilitiesAndServices").Rows(curRec1).Item(3)
            item = New ListViewItem(lv_item)
            lv_FnS.Items.Add(item)
        Next
        con.Close()
    End Sub

    Private Sub RFManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        ButtonCheck = False
        If Role.Text = "Admin" Then
            adminMenu_btn.Visible = True
        End If

        If Role.Text = "Admin" Then
            LogoutRFMButton.Visible = False
        End If

        Call Room()
        Call FnS()


    End Sub
    Private Sub LogoutRFMButton_Click(sender As Object, e As EventArgs) Handles LogoutRFMButton.Click
        Dim y As String
        y = MsgBox("Logout confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            ButtonCheck = True
            Application.Restart()
        End If
    End Sub

    Private Sub adminMenu_btn_Click(sender As Object, e As EventArgs) Handles adminMenu_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub AddNRRFButton_Click(sender As Object, e As EventArgs) Handles AddNRRFButton.Click
        Me.Enabled = False
        RFMAddDataEntry.Show()
    End Sub

    Private Sub UpdateRRFButton_Click(sender As Object, e As EventArgs) Handles UpdateRRFButton.Click
        Me.Enabled = False
        RFMUpdateDataEntry.Show()
    End Sub

    Private Sub DeleteRRFButton_Click(sender As Object, e As EventArgs) Handles DeleteRRFButton.Click
        Me.Enabled = False
        RFMDeleteDataEntry.Show()
    End Sub
    Private Sub SearchRFEntry_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchRFEntry.KeyUp
        If a = False Then
            If SearchRFEntry.Text = "" Then
                ds2.Clear()
                lv_Room.Items.Clear()
                Call Room()
                Exit Sub
            End If

            con.Open()
            ds2.Clear()
            lv_Room.Items.Clear()
            Sql2 = "SELECT * FROM Room where Room_ID='" & SearchRFEntry.Text & "'"
            da2 = New OleDbDataAdapter(Sql2, con)
            da2.Fill(ds2, "SearchR")
            totalRec2 = ds2.Tables("SearchR").Rows.Count - 1

            For Me.curRec2 = 0 To totalRec2
                Dim lv_item2 As String() = New String(4) {}
                Dim item2 As ListViewItem
                lv_item2(0) = ds2.Tables("SearchR").Rows(curRec2).Item(0)
                lv_item2(1) = ds2.Tables("SearchR").Rows(curRec2).Item(1)
                lv_item2(2) = ds2.Tables("SearchR").Rows(curRec2).Item(2)
                lv_item2(3) = ds2.Tables("SearchR").Rows(curRec2).Item(3)
                item2 = New ListViewItem(lv_item2)
                lv_Room.Items.Add(item2)
            Next
        End If

        If a = True Then
            If SearchRFEntry.Text = "" Then
                ds3.Clear()
                lv_FnS.Items.Clear()
                Call FnS()
                Exit Sub
            End If

            ds3.Clear()
            lv_FnS.Items.Clear()
            Sql3 = "SELECT * FROM FacilitiesAndServices where FnS_ID='" & SearchRFEntry.Text & "'"
            da3 = New OleDbDataAdapter(Sql3, con)
            da3.Fill(ds3, "SearchFnS")
            totalRec3 = ds3.Tables("SearchFnS").Rows.Count - 1

            For Me.curRec3 = 0 To totalRec3
                Dim lv_item3 As String() = New String(4) {}
                Dim item3 As ListViewItem
                lv_item3(0) = ds3.Tables("SearchFnS").Rows(curRec3).Item(0)
                lv_item3(1) = ds3.Tables("SearchFnS").Rows(curRec3).Item(1)
                lv_item3(2) = ds3.Tables("SearchFnS").Rows(curRec3).Item(2)
                lv_item3(3) = ds3.Tables("SearchFnS").Rows(curRec3).Item(3)
                item3 = New ListViewItem(lv_item3)
                lv_FnS.Items.Add(item3)
            Next
        End If
        con.Close()
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click
        If room_tab.Focus = True Then
            a = True
            SearchRFEntry.Clear()
        ElseIf FnS_tab.Focus = True Then
            a = False
            SearchRFEntry.Clear()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        If room_tab.Focus = True Then
            a = True
            lv_Room.Items.Clear()
            Call Room()
        ElseIf FnS_tab.Focus = True Then
            a = False
            lv_FnS.Items.Clear()
            Call FnS()
        End If
    End Sub
End Class