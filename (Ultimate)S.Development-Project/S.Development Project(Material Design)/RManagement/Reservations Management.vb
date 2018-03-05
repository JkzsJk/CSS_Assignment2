Imports MaterialSkin
Imports System.Data.OleDb

Public Class Reservations_Management
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3, da4, da5, da6, da7 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec, totalRec1, totalRec2, totalRec3, totalRec4, curRec, curRec1, curRec2, curRec3 As Integer
    Dim Sql, Sql1, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7 As String
    Dim a As Boolean = False
    Dim ButtonCheck As Boolean = False
    Public Event Selected As TabControlEventHandler
    Public Sub RoomR()
        con.Open()
        ds.Clear()
        Sql = "SELECT * FROM RoomReservation"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomReservation")
        totalRec = ds.Tables("RoomReservation").Rows.Count - 1

        For Me.curRec = 0 To totalRec
            Dim lv_item As String() = New String(14) {}
            Dim item As ListViewItem
            lv_item(0) = ds.Tables("RoomReservation").Rows(curRec).Item(0)
            lv_item(1) = ds.Tables("RoomReservation").Rows(curRec).Item(1)
            lv_item(2) = ds.Tables("RoomReservation").Rows(curRec).Item(2)
            lv_item(3) = ds.Tables("RoomReservation").Rows(curRec).Item(3)
            lv_item(4) = ds.Tables("RoomReservation").Rows(curRec).Item(4)
            lv_item(5) = ds.Tables("RoomReservation").Rows(curRec).Item(5)
            lv_item(6) = ds.Tables("RoomReservation").Rows(curRec).Item(6)
            lv_item(7) = ds.Tables("RoomReservation").Rows(curRec).Item(7)
            lv_item(8) = ds.Tables("RoomReservation").Rows(curRec).Item(8)
            lv_item(9) = ds.Tables("RoomReservation").Rows(curRec).Item(9)
            lv_item(10) = ds.Tables("RoomReservation").Rows(curRec).Item(10)
            lv_item(11) = ds.Tables("RoomReservation").Rows(curRec).Item(11)
            lv_item(12) = ds.Tables("RoomReservation").Rows(curRec).Item(12)
            lv_item(13) = ds.Tables("RoomReservation").Rows(curRec).Item(13)
            item = New ListViewItem(lv_item)
            lv_Room.Items.Add(item)
        Next
        con.Close()
    End Sub

    Public Sub FnS()
        con.Open()
        ds1.Clear()
        Sql1 = "SELECT * FROM FnSReservation"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "FnSReservation")
        totalRec1 = ds1.Tables("FnSReservation").Rows.Count - 1

        For Me.curRec1 = 0 To totalRec1
            Dim lv_item1 As String() = New String(9) {}
            Dim item1 As ListViewItem
            lv_item1(0) = ds1.Tables("FnSReservation").Rows(curRec1).Item(0)
            lv_item1(1) = ds1.Tables("FnSReservation").Rows(curRec1).Item(1)
            lv_item1(2) = ds1.Tables("FnSReservation").Rows(curRec1).Item(2)
            lv_item1(3) = ds1.Tables("FnSReservation").Rows(curRec1).Item(3)
            lv_item1(4) = ds1.Tables("FnSReservation").Rows(curRec1).Item(4)
            lv_item1(5) = ds1.Tables("FnSReservation").Rows(curRec1).Item(5)
            lv_item1(6) = ds1.Tables("FnSReservation").Rows(curRec1).Item(6)
            lv_item1(7) = ds1.Tables("FnSReservation").Rows(curRec1).Item(7)
            lv_item1(8) = ds1.Tables("FnSReservation").Rows(curRec1).Item(8)
            item1 = New ListViewItem(lv_item1)
            lv_FnS.Items.Add(item1)
        Next
        con.Close()
    End Sub

    Private Sub Reservations_Management_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)


        If Role.Text = "Admin" Then
            adminMenu_btn.Visible = True
        End If

        If Role.Text = "Admin" Then
            LogoutRMButton.Visible = False
        End If

        Call RoomR()
        Call FnS()
    End Sub

    Private Sub adminMenu_btn_Click(sender As Object, e As EventArgs) Handles adminMenu_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutRMButton_Click(sender As Object, e As EventArgs) Handles LogoutRMButton.Click
        Dim y As String
        y = MsgBox("Logout confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            Application.Restart()
        End If
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub AddRRButton_Click(sender As Object, e As EventArgs) Handles AddRRButton.Click
        Me.Enabled = False
        RMMenu.Show()
    End Sub

    Private Sub UpdateRRButton_Click(sender As Object, e As EventArgs) Handles UpdateRRButton.Click
        Me.Enabled = False
        RMUpdateDataEntry.Show()
    End Sub

    Private Sub AddPaymentRButton_Click(sender As Object, e As EventArgs) Handles AddPaymentRButton.Click
        Me.Enabled = False
        AddPaymentRM.Show()
    End Sub

    Private Sub DeleteRRButton_Click(sender As Object, e As EventArgs) Handles DeleteRRButton.Click
        Me.Enabled = False
        DeleteReservation.Show()
    End Sub

    Private Sub SearchREntry_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchREntry.KeyUp
        If a = False Then
            If SearchREntry.Text = "" Then
                ds2.Clear()
                lv_Room.Items.Clear()
                Call RoomR()
                Exit Sub
            End If

            con.Open()
            ds2.Clear()
            lv_Room.Items.Clear()
            Sql2 = "SELECT * FROM RoomReservation where Room_Reservation_ID='" & SearchREntry.Text & "'"
            da2 = New OleDbDataAdapter(Sql2, con)
            da2.Fill(ds2, "SearchR")
            totalRec2 = ds2.Tables("SearchR").Rows.Count - 1

            For Me.curRec2 = 0 To totalRec2
                Dim lv_item2 As String() = New String(14) {}
                Dim item2 As ListViewItem
                lv_item2(0) = ds2.Tables("SearchR").Rows(curRec2).Item(0)
                lv_item2(1) = ds2.Tables("SearchR").Rows(curRec2).Item(1)
                lv_item2(2) = ds2.Tables("SearchR").Rows(curRec2).Item(2)
                lv_item2(3) = ds2.Tables("SearchR").Rows(curRec2).Item(3)
                lv_item2(4) = ds2.Tables("SearchR").Rows(curRec2).Item(4)
                lv_item2(5) = ds2.Tables("SearchR").Rows(curRec2).Item(5)
                lv_item2(6) = ds2.Tables("SearchR").Rows(curRec2).Item(6)
                lv_item2(7) = ds2.Tables("SearchR").Rows(curRec2).Item(7)
                lv_item2(8) = ds2.Tables("SearchR").Rows(curRec2).Item(8)
                lv_item2(9) = ds2.Tables("SearchR").Rows(curRec2).Item(9)
                lv_item2(10) = ds2.Tables("SearchR").Rows(curRec2).Item(10)
                lv_item2(11) = ds2.Tables("SearchR").Rows(curRec2).Item(11)
                lv_item2(12) = ds2.Tables("SearchR").Rows(curRec2).Item(12)
                lv_item2(13) = ds2.Tables("SearchR").Rows(curRec2).Item(13)
                item2 = New ListViewItem(lv_item2)
                lv_Room.Items.Add(item2)
            Next
            con.Close()
        End If

        If a = True Then
            If SearchREntry.Text = "" Then
                ds3.Clear()
                lv_FnS.Items.Clear()
                Call FnS()
                Exit Sub
            End If
            con.Open()
            ds3.Clear()
            lv_FnS.Items.Clear()
            Sql3 = "SELECT * FROM FnSReservation where FnS_Reservation_ID='" & SearchREntry.Text & "'"
            da3 = New OleDbDataAdapter(Sql3, con)
            da3.Fill(ds3, "SearchFnS")
            totalRec3 = ds3.Tables("SearchFnS").Rows.Count - 1

            For Me.curRec3 = 0 To totalRec3
                Dim lv_item3 As String() = New String(9) {}
                Dim item3 As ListViewItem
                lv_item3(0) = ds3.Tables("SearchFnS").Rows(curRec3).Item(0)
                lv_item3(1) = ds3.Tables("SearchFnS").Rows(curRec3).Item(1)
                lv_item3(2) = ds3.Tables("SearchFnS").Rows(curRec3).Item(2)
                lv_item3(3) = ds3.Tables("SearchFnS").Rows(curRec3).Item(3)
                lv_item3(4) = ds3.Tables("SearchFnS").Rows(curRec3).Item(4)
                lv_item3(5) = ds3.Tables("SearchFnS").Rows(curRec3).Item(5)
                lv_item3(6) = ds3.Tables("SearchFnS").Rows(curRec3).Item(6)
                lv_item3(7) = ds3.Tables("SearchFnS").Rows(curRec3).Item(7)
                lv_item3(8) = ds3.Tables("SearchFnS").Rows(curRec3).Item(8)
                item3 = New ListViewItem(lv_item3)
                lv_FnS.Items.Add(item3)
            Next
            con.Close()
        End If
    End Sub

    Private Sub ReservationReportButton_Click(sender As Object, e As EventArgs) Handles ReservationReportButton.Click
        Me.Enabled = False
        RMReport.Show()
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click
        If TabPage1.Focus = True Then
            a = True
            SearchREntry.Clear()
        ElseIf TabPage2.Focus = True Then
            a = False
            SearchREntry.Clear()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        If TabPage1.Focus = True Then
            a = True
            lv_Room.Items.Clear()
            Call RoomR()
        ElseIf TabPage2.Focus = True Then
            a = False
            lv_FnS.Items.Clear()
            Call FnS()
        End If
    End Sub
End Class