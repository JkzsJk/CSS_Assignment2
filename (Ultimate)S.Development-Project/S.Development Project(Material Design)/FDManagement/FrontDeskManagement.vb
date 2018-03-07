Imports MaterialSkin
Imports System.Data.OleDb
Public Class FrontDeskManagement
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ButtonCheck As Boolean
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9 As New DataSet
    Dim tot, current As Integer

    Public Sub callcheckIn()
        'display checkin table 
        ds1.Clear()
        Dim sql As String = "SELECT * FROM CheckIn where Status = 'Checked-In'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds1, "CheckinList")
        tot = ds1.Tables("CheckinList").Rows.Count - 1

        For Me.current = 0 To tot
            Dim lv_item As String() = New String(11) {}
            Dim item As ListViewItem
            lv_item(0) = ds1.Tables("CheckinList").Rows(current).Item(0) 'CheckIn ID
            lv_item(1) = (ds1.Tables("CheckinList").Rows(current).Item(1)).ToString 'Reservation ID
            lv_item(2) = ds1.Tables("CheckinList").Rows(current).Item(2) 'Number of standard room
            lv_item(3) = ds1.Tables("CheckinList").Rows(current).Item(3) 'Number of deluxe room
            lv_item(4) = ds1.Tables("CheckinList").Rows(current).Item(4) 'Number of superior room
            lv_item(5) = ds1.Tables("CheckinList").Rows(current).Item(5) 'total room price
            lv_item(6) = ds1.Tables("CheckinList").Rows(current).Item(6) 'deposit
            lv_item(7) = ds1.Tables("CheckinList").Rows(current).Item(7) 'customer's name
            lv_item(8) = ds1.Tables("CheckinList").Rows(current).Item(12) 'checkedin date
            lv_item(9) = ds1.Tables("CheckinList").Rows(current).Item(10) 'duration
            lv_item(10) = (ds1.Tables("CheckinList").Rows(current).Item(14)).ToString 'checkedin type

            item = New ListViewItem(lv_item)
            checkin_LV.Items.Add(item)
            'showCusRoom()
        Next

    End Sub

    Private Sub FrontDeskManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Role.Text <> "Admin" Then
            If ButtonCheck = False Then
                FileHashing.Close()
            End If
        End If

        If Role.Text = "Admin" Then
            If ButtonCheck = False Then
                MenuForAdmin.Close()
            End If
        End If
    End Sub

    Private Sub FrontDeskManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()
        ds1.Clear()
        checkin_LV.Items.Clear()
        Dim sql As String = "SELECT * FROM CheckIn where Status = 'Checked-In'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds1, "CheckinList")
        tot = ds1.Tables("CheckinList").Rows.Count - 1

        For Me.current = 0 To tot 'display check in table
            Dim lv_item As String() = New String(11) {}
            Dim item As ListViewItem
            lv_item(0) = ds1.Tables("CheckinList").Rows(current).Item(0) 'CheckIn ID
            lv_item(1) = (ds1.Tables("CheckinList").Rows(current).Item(1)).ToString 'Reservation ID
            lv_item(2) = ds1.Tables("CheckinList").Rows(current).Item(2) 'Number of standard room
            lv_item(3) = ds1.Tables("CheckinList").Rows(current).Item(3) 'Number of deluxe room
            lv_item(4) = ds1.Tables("CheckinList").Rows(current).Item(4) 'Number of superior room
            lv_item(5) = ds1.Tables("CheckinList").Rows(current).Item(5) 'total room price
            lv_item(6) = ds1.Tables("CheckinList").Rows(current).Item(6) 'deposit
            lv_item(7) = ds1.Tables("CheckinList").Rows(current).Item(7) 'customer's name
            lv_item(8) = ds1.Tables("CheckinList").Rows(current).Item(12) 'checkedin date
            lv_item(9) = ds1.Tables("CheckinList").Rows(current).Item(10) 'duration
            lv_item(10) = (ds1.Tables("CheckinList").Rows(current).Item(14)).ToString 'checkedin type

            item = New ListViewItem(lv_item)
            checkin_LV.Items.Add(item)
            'showCusRoom()
        Next
        con.Close()

        ds2.Clear()
        checkout_LV.Items.Clear()
        Dim sql1 As String = "SELECT * FROM CheckOut"
        Dim da1 As New OleDbDataAdapter(sql1, con)
        da1.Fill(ds2, "CheckinList")
        tot = ds2.Tables("CheckinList").Rows.Count - 1

        For Me.current = 0 To tot 'display checkout details
            Dim lv_item As String() = New String(9) {}
            Dim item As ListViewItem
            lv_item(0) = ds2.Tables("CheckinList").Rows(current).Item(0) 'CheckOut ID
            lv_item(1) = (ds2.Tables("CheckinList").Rows(current).Item(1)).ToString 'CheckIn ID
            lv_item(2) = ds2.Tables("CheckinList").Rows(current).Item(2) 'Number of standard room
            lv_item(3) = ds2.Tables("CheckinList").Rows(current).Item(3) 'Number of deluxe room
            lv_item(4) = ds2.Tables("CheckinList").Rows(current).Item(4) 'Number of superior room
            lv_item(5) = ds2.Tables("CheckinList").Rows(current).Item(5) 'deposit paid
            lv_item(6) = (ds2.Tables("CheckinList").Rows(current).Item(6)).ToString 'extra charges
            lv_item(7) = (ds2.Tables("CheckinList").Rows(current).Item(8)).ToString 'customer's name
            lv_item(8) = (ds2.Tables("CheckinList").Rows(current).Item(11)).ToString 'checkedout date

            item = New ListViewItem(lv_item)
            checkout_LV.Items.Add(item)
            'showCusRoom()
        Next
        con.Close()

        ds3.Clear()
        reservation_LV.Items.Clear()
        Dim sql2 As String = "SELECT * FROM RoomReservation where Status = 'Reserved'"
        Dim da2 As New OleDbDataAdapter(sql2, con)
        da2.Fill(ds3, "RList")
        tot = ds3.Tables("RList").Rows.Count - 1

        For Me.current = 0 To tot ' display reservation details
            Dim lv_item As String() = New String(10) {}
            Dim item As ListViewItem
            lv_item(0) = ds3.Tables("RList").Rows(current).Item(0) 'Reservation ID
            lv_item(1) = (ds3.Tables("RList").Rows(current).Item(1)).ToString 'Number of standard room
            lv_item(2) = ds3.Tables("RList").Rows(current).Item(2) 'Number of deluxe room
            lv_item(3) = ds3.Tables("RList").Rows(current).Item(3) 'Number of superior room
            lv_item(4) = ds3.Tables("RList").Rows(current).Item(4) 'total price
            lv_item(5) = ds3.Tables("RList").Rows(current).Item(5) 'deposit
            lv_item(6) = ds3.Tables("RList").Rows(current).Item(9) 'duration
            lv_item(7) = ds3.Tables("RList").Rows(current).Item(11) 'date
            lv_item(8) = (ds3.Tables("RList").Rows(current).Item(6)).ToString 'customer's name
            lv_item(9) = ds3.Tables("RList").Rows(current).Item(12) 'type

            item = New ListViewItem(lv_item)
            reservation_LV.Items.Add(item)
            'showCusRoom()
        Next
        con.Close()

        con.Open()
        ds8.Clear()
        payment_LV.Items.Clear()
        Dim sql11 As String = "SELECT * FROM Payment"
        Dim da11 As New OleDbDataAdapter(sql11, con)
        da11.Fill(ds8, "payment")
        tot = ds8.Tables("payment").Rows.Count - 1

        For Me.current = 0 To tot 'display payment details
            Dim lv_item As String() = New String(10) {}
            Dim item As ListViewItem
            lv_item(0) = ds8.Tables("payment").Rows(current).Item(0) 'payment ID
            lv_item(1) = (ds8.Tables("payment").Rows(current).Item(1)).ToString 'Reservation ID
            lv_item(2) = ds8.Tables("payment").Rows(current).Item(2) 'checkin ID
            lv_item(3) = ds8.Tables("payment").Rows(current).Item(7) 'total room price
            lv_item(4) = ds8.Tables("payment").Rows(current).Item(8) 'customer's name
            lv_item(5) = ds8.Tables("payment").Rows(current).Item(11) 'deposit
            lv_item(6) = ds8.Tables("payment").Rows(current).Item(12) 'extra charges
            lv_item(7) = ds8.Tables("payment").Rows(current).Item(13) 'repayment
            lv_item(8) = ds8.Tables("payment").Rows(current).Item(14) 'total paid
            lv_item(9) = ds8.Tables("payment").Rows(current).Item(15) 'type


            item = New ListViewItem(lv_item)
            payment_LV.Items.Add(item)
            'showCusRoom()
        Next
        con.Close()


        ButtonCheck = False
        If Role.Text = "Admin" Then
            adminMenu_btn.Visible = True
        End If

        If Role.Text = "Admin" Then
            LogoutFDMButton.Visible = False
        End If
    End Sub
    Private Sub adminMenu_btn_Click(sender As Object, e As EventArgs) Handles adminMenu_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub filehashing_btn_Click(sender As Object, e As EventArgs) Handles filehashing_btn.Click
        FileHashingFDM.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutFDMButton_Click(sender As Object, e As EventArgs) Handles LogoutFDMButton.Click
        Dim y As String
        y = MsgBox("Logout confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            ButtonCheck = True
            Application.Restart()
        End If
    End Sub
    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
    Private Sub CheckInFDMButton_Click(sender As Object, e As EventArgs) Handles CheckInFDMButton.Click
        Me.Enabled = False
        checkIn.Show()
    End Sub
    Private Sub CheckOutFDMButton_Click(sender As Object, e As EventArgs) Handles CheckOutFDMButton.Click
        Me.Enabled = False
        CheckOut.Show()
    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Me.Enabled = False
        DeleteRecord.Show()
    End Sub
    Private Sub SearchFDMButton_Click(sender As Object, e As EventArgs) Handles SearchFDMButton.Click

        ds4.Clear()
        ds5.Clear()
        ds7.Clear()
        ds6.Clear()


        'display the particular search record based on the type of id
        If search_CB.Text = "Check-In ID" Then
            CheckInS_LV.Items.Clear()
            CheckInS_LV.Visible = True
            paymentS_LV.Visible = False
            CheckOutS_LV.Visible = False
            ReservationS_LV.Visible = False

            Dim sql As String = "SELECT * FROM CheckIn where CheckIn_ID = '" & SearchFDMEntry.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "CheckinList")
            tot = ds4.Tables("CheckinList").Rows.Count - 1

            For Me.current = 0 To tot
                Dim lv_item As String() = New String(11) {}
                Dim item As ListViewItem
                lv_item(0) = ds4.Tables("CheckinList").Rows(current).Item(0) 'CheckIn ID
                lv_item(1) = (ds4.Tables("CheckinList").Rows(current).Item(1)).ToString 'Reservation ID
                lv_item(2) = ds4.Tables("CheckinList").Rows(current).Item(2) 'Number of standard room
                lv_item(3) = ds4.Tables("CheckinList").Rows(current).Item(3) 'Number of deluxe room
                lv_item(4) = ds4.Tables("CheckinList").Rows(current).Item(4) 'Number of superior room
                lv_item(5) = ds4.Tables("CheckinList").Rows(current).Item(5) 'total room price
                lv_item(6) = ds4.Tables("CheckinList").Rows(current).Item(6) 'deposit
                lv_item(7) = ds4.Tables("CheckinList").Rows(current).Item(7) 'customer's name
                lv_item(8) = ds4.Tables("CheckinList").Rows(current).Item(12) 'checkedin date
                lv_item(9) = ds4.Tables("CheckinList").Rows(current).Item(10) 'duration
                lv_item(10) = ds4.Tables("CheckinList").Rows(current).Item(14) 'checkedin type

                item = New ListViewItem(lv_item)
                CheckInS_LV.Items.Add(item)
                'showCusRoom()
            Next
            con.Close()
        End If

        If search_CB.Text = "Check-Out ID" Then
            CheckOutS_LV.Items.Clear()
            CheckOutS_LV.Visible = True
            paymentS_LV.Visible = False
            CheckInS_LV.Visible = False
            ReservationS_LV.Visible = False
            Dim sql1 As String = "SELECT * FROM CheckOut where CheckOut_ID ='" & SearchFDMEntry.Text & "'"
            Dim da1 As New OleDbDataAdapter(sql1, con)
            da1.Fill(ds5, "CheckinList")
            tot = ds5.Tables("CheckinList").Rows.Count - 1

            For Me.current = 0 To tot
                Dim lv_item As String() = New String(9) {}
                Dim item As ListViewItem
                lv_item(0) = ds5.Tables("CheckinList").Rows(current).Item(0) 'CheckOut ID
                lv_item(1) = (ds5.Tables("CheckinList").Rows(current).Item(1)).ToString 'CheckIn ID
                lv_item(2) = ds5.Tables("CheckinList").Rows(current).Item(2) 'Number of standard room
                lv_item(3) = ds5.Tables("CheckinList").Rows(current).Item(3) 'Number of deluxe room
                lv_item(4) = ds5.Tables("CheckinList").Rows(current).Item(4) 'Number of superior room
                lv_item(5) = ds5.Tables("CheckinList").Rows(current).Item(5) 'deposit paid
                lv_item(6) = ds5.Tables("CheckinList").Rows(current).Item(6) 'extra charges
                lv_item(7) = (ds5.Tables("CheckinList").Rows(current).Item(8)).ToString 'customer's name
                lv_item(8) = (ds5.Tables("CheckinList").Rows(current).Item(11)).ToString 'checkedout date

                item = New ListViewItem(lv_item)
                CheckOutS_LV.Items.Add(item)
                'showCusRoom()
            Next
            con.Close()
        End If

        If search_CB.Text = "Reservation ID" Then
            ReservationS_LV.Items.Clear()
            ReservationS_LV.Visible = True
            paymentS_LV.Visible = False
            CheckInS_LV.Visible = False
            CheckOutS_LV.Visible = False
            Dim sql2 As String = "SELECT * FROM RoomReservation where Room_Reservation_ID ='" & SearchFDMEntry.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds7, "RList")
            tot = ds7.Tables("RList").Rows.Count - 1

            For Me.current = 0 To tot
                Dim lv_item As String() = New String(10) {}
                Dim item As ListViewItem
                lv_item(0) = ds7.Tables("RList").Rows(current).Item(0) 'Reservation ID
                lv_item(1) = (ds7.Tables("RList").Rows(current).Item(1)).ToString 'Number of standard room
                lv_item(2) = ds7.Tables("RList").Rows(current).Item(2) 'Number of deluxe room
                lv_item(3) = ds7.Tables("RList").Rows(current).Item(3) 'Number of superior room
                lv_item(4) = ds7.Tables("RList").Rows(current).Item(4) 'total price
                lv_item(5) = ds7.Tables("RList").Rows(current).Item(5) 'deposit
                lv_item(6) = ds7.Tables("RList").Rows(current).Item(9) 'duration
                lv_item(7) = ds7.Tables("RList").Rows(current).Item(11) 'date
                lv_item(8) = ds7.Tables("RList").Rows(current).Item(6) 'customer's name
                lv_item(9) = ds7.Tables("RList").Rows(current).Item(12) 'type

                item = New ListViewItem(lv_item)
                ReservationS_LV.Items.Add(item)
                'showCusRoom()
            Next
            con.Close()
        End If

        If search_CB.Text = "Payment ID" Then
            paymentS_LV.Items.Clear()
            paymentS_LV.Visible = True
            ReservationS_LV.Visible = False
            CheckInS_LV.Visible = False
            CheckOutS_LV.Visible = False

            Dim sql11 As String = "SELECT * FROM Payment where Payment_ID ='" & SearchFDMEntry.Text & "'"
            Dim da11 As New OleDbDataAdapter(sql11, con)
            da11.Fill(ds6, "payment")
            tot = ds6.Tables("payment").Rows.Count - 1

            For Me.current = 0 To tot
                Dim lv_item As String() = New String(10) {}
                Dim item As ListViewItem
                lv_item(0) = ds6.Tables("payment").Rows(current).Item(0) 'payment ID
                lv_item(1) = (ds6.Tables("payment").Rows(current).Item(1)).ToString 'Reservation ID
                lv_item(2) = ds6.Tables("payment").Rows(current).Item(2) 'checkin ID
                lv_item(3) = ds6.Tables("payment").Rows(current).Item(7) 'total room price
                lv_item(4) = ds6.Tables("payment").Rows(current).Item(8) 'customer's name
                lv_item(5) = ds6.Tables("payment").Rows(current).Item(11) 'deposit
                lv_item(6) = ds6.Tables("payment").Rows(current).Item(12) 'extra charges
                lv_item(7) = ds6.Tables("payment").Rows(current).Item(13) 'repayment
                lv_item(8) = ds6.Tables("payment").Rows(current).Item(14) 'total paid
                lv_item(9) = ds6.Tables("payment").Rows(current).Item(15) 'type


                item = New ListViewItem(lv_item)
                paymentS_LV.Items.Add(item)
                'showCusRoom()
            Next
            con.Close()
        End If
    End Sub
    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Me.Enabled = False
        AddPayment.Show()
    End Sub

    Private Sub GenerateFSRFButton_Click(sender As Object, e As EventArgs) Handles GenerateFSRFButton.Click
        Me.Enabled = False
        Report.Show()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        checkin_LV.Items.Clear()
        Call callcheckIn()
    End Sub

 
End Class
