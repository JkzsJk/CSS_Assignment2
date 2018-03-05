Imports MaterialSkin
Imports System.Data.OleDb

Public Class CheckIn
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2, ds3, ds4, ds5, ds6 As New DataSet
    Dim TotRec, TotCI, CurCI, TotCIR, CurCIR, TotR, TotRoom As Integer
    Dim stdr, delr, supr As Integer
    Dim standardr, deluxer, superiorr, roomid, roomprice, roompriceGroupW, roompriceGroupR, roomprice1, count As Integer
    Dim deposit As String
    Private Sub CheckIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrontDeskManagement.Enabled = True
    End Sub
    Private Sub CheckInRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Timer1.Start()

        con.Open()

        Room_Number_R.Items.Clear()
        Room_Number_W.Items.Clear()
        'add all the room types into room types combo box
        roomTypeGroupW_CB.Items.Add("Standard Room")
        roomTypeGroupW_CB.Items.Add("Deluxe Room")
        roomTypeGroupW_CB.Items.Add("Superior Room")

        roomTypeGroupR_CB.Items.Add("Standard Room")
        roomTypeGroupR_CB.Items.Add("Deluxe Room")
        roomTypeGroupR_CB.Items.Add("Superior Room")
        'auto generate the checkin id
        Dim Sql1 As String = "select * from CheckIn"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds2, "checkin")
        TotCI = 0
        TotCI = ds2.Tables("checkin").Rows.Count - 1
        CurCI = 100
        For i = 0 To TotCI
            CurCI = ds2.Tables("checkin").Rows(i).Item(0)
            CurCI = CurCI + 1
        Next
        checkInIDGroupW_txt.Text = CurCI
        checkInIDIndiviW_txt.Text = CurCI
        checkInIDIndiviR_txt.Text = CurCI
        checkInIDGroupR_txt.Text = CurCI

        checkInIDGroupW_txt.Enabled = False
        checkInIDIndiviW_txt.Enabled = False
        checkInIDIndiviR_txt.Enabled = False
        checkInIDGroupR_txt.Enabled = False
        roomtypeindiR_txt.Enabled = False
        dateIndiviR_txt.Enabled = False
        todaydate_txt.Enabled = False

        standardRoomR_txt.Enabled = False
        deluxeRoom_txt.Enabled = False
        superiorRoomR_txt.Enabled = False

        roomprice_txt.Enabled = False
        roompriceindi_txt.Enabled = False
        'add the reservation id which the reservation type is individual into the reservation id combo box
        reserveNOIndiviR_CB.Items.Clear()
        Dim Sql As String = "select * from RoomReservation where Reservation_Type ='Individual' and Status = 'Reserved'"
        Dim da As New OleDbDataAdapter(Sql, con)
        da.Fill(ds1, "roomreservationindi")
        TotRec = 0
        TotRec = ds1.Tables("roomreservationindi").Rows.Count - 1
        For i = 0 To TotRec
            reserveNOIndiviR_CB.Items.Add(ds1.Tables("roomreservationindi").Rows(i).Item(0))
        Next
        'add the reservation id which the reservation type is group into the reservation id combo box
        reservationid_CB.Items.Clear()
        Dim Sql2 As String = "select * from RoomReservation where Reservation_Type ='Group' and Status = 'Reserved'"
        Dim da2 As New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds6, "roomreservationgroup")
        TotRec = 0
        TotRec = ds6.Tables("roomreservationgroup").Rows.Count - 1
        For i = 0 To TotRec
            reservationid_CB.Items.Add(ds6.Tables("roomreservationgroup").Rows(i).Item(0))
        Next
    End Sub
    Private Sub checkInIndiviW_btn_Click(sender As Object, e As EventArgs) Handles checkInIndiviW_btn.Click
        'users are not allow to checkin if there is any of the textbox is blank
        If depositindi_txt.Text = "" Then
            MsgBox("Please fill in the deposit.")
            Exit Sub
        End If

        If customerNameIndiviW_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If customerICIndiviW_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If phoneNOIndiviW_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If durationIndiviW_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If
        'users can only enter number in IC number textbox and phone number textbox
        If IsNumeric(customerICIndiviW_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(phoneNOIndiviW_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        Dim Sql As String
        Dim cmd As New OleDbCommand
        'sql that used to add the check in details into CheckIn table
        Sql = "insert into CheckIn values("
        Sql = Sql & "'" & checkInIDIndiviW_txt.Text & "',"
        Sql = Sql & "'" & "',"
        Sql = Sql & "'" & standardr & "',"
        Sql = Sql & "'" & deluxer & "',"
        Sql = Sql & "'" & superiorr & "',"
        Sql = Sql & roompriceindi_txt.Text & ","
        Sql = Sql & depositindi_txt.Text & ","
        Sql = Sql & "'" & customerNameIndiviW_txt.Text & "',"
        Sql = Sql & "'" & customerICIndiviW_txt.Text & "',"
        Sql = Sql & "'" & phoneNOIndiviW_txt.Text & "',"
        Sql = Sql & "'" & durationIndiviW_txt.Text & "',"
        Sql = Sql & "'" & dateIndiviW_txt.Text & "',"
        Sql = Sql & "'" & dateIndiviW_txt.Text & "',"
        Sql = Sql & "'" & checkoutIndiW_txt.Text & "',"
        Sql = Sql & "'Individual','Checked-In','Not Pay')"

        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()

        'sql that used to add the check in room details into CheckInRoom table
        Dim sql2 As String = "insert into CheckInRoom values("
        sql2 = sql2 & "'" & checkInIDIndiviW_txt.Text & "',"
        sql2 = sql2 & "'" & customerNameIndiviW_txt.Text & "',"
        sql2 = sql2 & "'" & roomNOInvidiW_CB.Text & "',"
        sql2 = sql2 & "'" & roomTypeindiW_CB.Text & "',"
        sql2 = sql2 & "'" & roompriceindi_txt.Text & "')"
        cmd = New OleDbCommand(sql2, con)
        cmd.ExecuteNonQuery()
        'sql that used to update the status of room that checked in to unavailable
        Dim cmd1 As New OleDb.OleDbCommand
        Dim sql4 As String = "UPDATE Room set Status = 'Unavailable' where Room_ID = '" & roomNOInvidiW_CB.Text & "'"
        cmd1 = New OleDbCommand(sql4, con)
        cmd1.ExecuteNonQuery()

        MsgBox("Check-In successfully.")
        ds2.Clear()
        ds3.Clear()
        con.Close()
        Me.Close()
    End Sub

    Private Sub searchIndiviR_btn_Click(sender As Object, e As EventArgs) Handles searchIndiviR_btn.Click
        'retrieve reservation details from database and display in form based on reservation id
        Dim sql As String = "select * from RoomReservation where Room_Reservation_ID = '" & reserveNOIndiviR_CB.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds5, "roomreserve")

        If ds5.Tables("roomreserve").Rows(0).Item(1) = 1 Then
            roomtypeindiR_txt.Text = "Standard Room"
        End If

        If ds5.Tables("roomreserve").Rows(0).Item(2) = 1 Then
            roomtypeindiR_txt.Text = "Deluxe Room"
        End If

        If ds5.Tables("roomreserve").Rows(0).Item(3) = 1 Then
            roomtypeindiR_txt.Text = "Superior Room"
        End If

        roompricereserin_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(4)
        deposit = ds5.Tables("roomreserve").Rows(0).Item(5)
        customerNameIndivi_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(6)
        customerICIndivi_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(7)
        phoneNOIndivi_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(8)
        durationIndivi_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(9)
        dateIndiviR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(11)

        'add the available room id for the particular type of room when the user has selected that room type 
        roomNOInvidiR_CB.Items.Clear()
        If roomtypeindiR_txt.Text = "Standard Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomtypeindiR_txt.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roomprice = ds4.Tables("roomid").Rows(0).Item(2)
            standardr = 1
            deluxer = 0
            superiorr = 0
        End If

        If roomtypeindiR_txt.Text = "Deluxe Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomtypeindiR_txt.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roomprice = ds4.Tables("roomid").Rows(0).Item(2)

            standardr = 0
            deluxer = 1
            superiorr = 0
        End If

        If roomtypeindiR_txt.Text = "Superior Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomtypeindiR_txt.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roomprice = ds4.Tables("roomid").Rows(0).Item(2)

            standardr = 0
            deluxer = 0
            superiorr = 1
        End If

        Dim date1 As Date
        Dim dur As Integer
        date1 = Date.Now
        dur = durationIndivi_txt.Text
        checkoutdateIndiR_txt.Text = DateAdd(DateInterval.Day, dur, date1).ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub

    Private Sub addW_btn_Click(sender As Object, e As EventArgs) Handles addW_btn.Click
        TotRoom = Val(standardRoomW_txt.Text) + Val(deluxeRoomW_txt.Text) + Val(superiorRoomW_txt.Text)
        'add room id and room type into room list view
        If roollistW_LV.Items.Count < TotRoom Then 'users are not allow to add another room again if the number of room that added is same as the number of room that enter 

            count = roollistW_LV.Items.Count
            For i = 0 To count - 1
                If roollistW_LV.Items(i).Text = roomNOGroupW_CB.Text Then
                    MsgBox("This room is already added in the room list.")
                    Exit Sub
                End If
            Next

            If stdr = 0 And roomTypeGroupW_CB.SelectedItem = "Standard Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If delr = 0 And roomTypeGroupW_CB.SelectedItem = "Deluxe Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If supr = 0 And roomTypeGroupW_CB.SelectedItem = "Superior Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If stdr > 0 And roomTypeGroupW_CB.SelectedItem = "Standard Room" Then
                stdr = stdr - 1

            End If

            If delr > 0 And roomTypeGroupW_CB.SelectedItem = "Deluxe Room" Then
                delr = delr - 1

            End If

            If supr > 0 And roomTypeGroupW_CB.SelectedItem = "Superior Room" Then
                supr = supr - 1

            End If

            Dim item As New ListViewItem(roomNOGroupW_CB.Text)
            item.SubItems.Add(roomTypeGroupW_CB.Text)
            roollistW_LV.Items.Add(item)

            If stdr = 0 And delr = 0 And supr = 0 Then
                MsgBox("You have issued all the room.")
            End If

        Else
            MsgBox("The room added could not more than the room number.")
        End If

    End Sub

    Private Sub roomTypeGroupW_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomTypeGroupW_CB.SelectedIndexChanged
        roomNOGroupW_CB.Items.Clear()
        If roomTypeGroupW_CB.Text = "Standard Room" Then
            ds4.Clear()
            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roompriceGroupW = 150
        End If

        If roomTypeGroupW_CB.Text = "Deluxe Room" Then
            ds4.Clear()
            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roompriceGroupW = 300

        End If

        If roomTypeGroupW_CB.Text = "Superior Room" Then

            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
            roompriceGroupW = 500
        End If
        ds4.Clear()
    End Sub

    Private Sub checkInIndiviR_btn_Click(sender As Object, e As EventArgs) Handles checkInIndiviR_btn.Click
        If roompricereserin_txt.Text = "" Then
            MsgBox("Please fill in the deposit.")
            Exit Sub
        End If

        If customerNameIndivi_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If customerICIndivi_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If phoneNOIndivi_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If durationIndivi_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If

        If IsNumeric(customerICIndivi_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(phoneNOIndivi_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        Dim Sql As String
        Dim cmd As New OleDbCommand

        Sql = "insert into CheckIn values("
        Sql = Sql & "'" & checkInIDIndiviR_txt.Text & "'"
        Sql = Sql & ",'" & reserveNOIndiviR_CB.Text & "'"
        Sql = Sql & ",'" & standardr & "'"
        Sql = Sql & ",'" & deluxer & "'"
        Sql = Sql & ",'" & superiorr & "',"
        Sql = Sql & roompricereserin_txt.Text & ","
        Sql = Sql & deposit
        Sql = Sql & ",'" & customerNameIndivi_txt.Text & "'"
        Sql = Sql & ",'" & customerICIndivi_txt.Text & "'"
        Sql = Sql & ",'" & phoneNOIndivi_txt.Text & "'"
        Sql = Sql & ",'" & durationIndivi_txt.Text & "'"
        Sql = Sql & ",'" & dateIndiviR_txt.Text & "'"
        Sql = Sql & ",'" & todaydate_txt.Text & "'"
        Sql = Sql & ",'" & checkoutdateIndiR_txt.Text & "',"
        Sql = Sql & "'Individual',"
        Sql = Sql & "'Checked-In','Not Pay')"

        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()

        Dim sql2 As String = "insert into CheckInRoom values("
        sql2 = sql2 & "'" & checkInIDIndiviR_txt.Text & "'"
        sql2 = sql2 & ",'" & customerNameIndivi_txt.Text & "'"
        sql2 = sql2 & ",'" & roomNOInvidiR_CB.Text & "'"
        sql2 = sql2 & ",'" & roomtypeindiR_txt.Text & "',"
        sql2 = sql2 & roomprice & ")"
        cmd = New OleDbCommand(sql2, con)
        cmd.ExecuteNonQuery()

        Dim cmd1 As New OleDb.OleDbCommand
        Dim sql5 As String = "UPDATE Room set Status = 'Unavailable' where Room_ID = '" & roomNOInvidiR_CB.Text & "'"
        cmd1 = New OleDbCommand(sql5, con)
        cmd1.ExecuteNonQuery()

        Dim sql1 As String = "UPDATE RoomReservation set Status = 'Checked-In' where Room_Reservation_ID = '" & checkInIDIndiviR_txt.Text & "'"
        Dim cmd2 As New OleDbCommand
        cmd2 = New OleDbCommand(sql1, con)
        cmd2.ExecuteNonQuery()

        MsgBox("Check-In successfully.")
        ds5.Clear()
        ds4.Clear()
        ds3.Clear()
        con.Close()
        Me.Close()
    End Sub
    Private Sub roomTypeindiW_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomTypeindiW_CB.SelectedIndexChanged
        roomNOInvidiW_CB.Items.Clear()

        If roomTypeindiW_CB.Text = "Standard Room" Then
            standardr = 1
            deluxer = 0
            superiorr = 0
            roompriceindi_txt.Text = 150

            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeindiW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If

        If roomTypeindiW_CB.Text = "Deluxe Room" Then
            standardr = 0
            deluxer = 1
            superiorr = 0
            roompriceindi_txt.Text = 300

            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeindiW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If

        If roomTypeindiW_CB.Text = "Superior Room" Then
            standardr = 0
            deluxer = 0
            superiorr = 1
            roompriceindi_txt.Text = 500

            Dim sql As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeindiW_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOInvidiW_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If
        ds4.Clear()
    End Sub

    Private Sub searchGroupR_btn_Click(sender As Object, e As EventArgs) Handles searchGroupR_btn.Click
        Dim sql As String = "select * from RoomReservation where Room_Reservation_ID = '" & reservationid_CB.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds5, "roomreserve")


        standardRoomR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(1)
        deluxeRoom_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(2)
        superiorRoomR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(3)
        roomPriceGroupR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(4)
        deposit = Val(ds5.Tables("roomreserve").Rows(0).Item(5))
        customerNameGroupR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(6)
        customerICGroupR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(7)
        phonenumberGroupR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(8)
        durationgrp_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(9)
        dateGroupR_txt.Text = ds5.Tables("roomreserve").Rows(0).Item(11)

        If standardRoomR_txt.Text = 0 Then
            roomTypeGroupR_CB.Items.Remove("Standard Room")
        End If

        If deluxeRoom_txt.Text = 0 Then
            roomTypeGroupR_CB.Items.Remove("Deluxe Room")
        End If

        If superiorRoomR_txt.Text = 0 Then
            roomTypeGroupR_CB.Items.Remove("Superior Room")
        End If

        stdr = Val(standardRoomR_txt.Text)
        delr = Val(deluxeRoom_txt.Text)
        supr = Val(superiorRoomR_txt.Text)

        Dim date1 As Date
        Dim dur As Integer
        date1 = Date.Now
        dur = durationgrp_txt.Text
        checkoutdateGroupR_txt.Text = DateAdd(DateInterval.Day, dur, date1).ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub

    Private Sub roomTypeGroupR_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomTypeGroupR_CB.SelectedIndexChanged
        roomNOGroupR_CB.Items.Clear()
        If roomTypeGroupR_CB.Text = "Standard Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupR_CB.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If

        If roomTypeGroupR_CB.Text = "Deluxe Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupR_CB.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If

        If roomTypeGroupR_CB.Text = "Superior Room" Then

            Dim sql2 As String = "select * from Room where Status = 'Available' and Room_Type ='" & roomTypeGroupR_CB.Text & "'"
            Dim da2 As New OleDbDataAdapter(sql2, con)
            da2.Fill(ds4, "roomid")
            roomid = ds4.Tables("roomid").Rows.Count
            If roomid = 0 Then
                MsgBox("This room type is unavailable.")
                Exit Sub
            End If
            For i = 0 To roomid - 1
                roomNOGroupR_CB.Items.Add(ds4.Tables("roomid").Rows(i).Item(0))
            Next
        End If
        ds4.Clear()
    End Sub
    Private Sub checkInGroupR_btn_Click(sender As Object, e As EventArgs) Handles checkInGroupR_btn.Click
        If roomlistGrouR_LV.Items.Count <> (Val(standardRoomR_txt.Text) + Val(deluxeRoom_txt.Text) + Val(superiorRoomR_txt.Text)) Then
            MsgBox("The number of room that had issued is different as the total number of room check in.")
            Exit Sub
        End If

        If roomPriceGroupR_txt.Text = "" Then
            MsgBox("Please fill in the deposit.")
            Exit Sub
        End If

        If customerNameGroupR_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If customerICGroupR_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If phonenumberGroupR_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If durationgrp_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If

        If IsNumeric(customerICGroupR_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(phonenumberGroupR_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        roompriceGroupR = (Val(standardRoomR_txt.Text) * 150) + (Val(deluxeRoom_txt.Text) * 300) + (Val(superiorRoomR_txt.Text) * 500)
        Dim Sql As String
        Dim cmd As New OleDbCommand

        Sql = "insert into CheckIn values("
        Sql = Sql & "'" & checkInIDGroupR_txt.Text & "',"
        Sql = Sql & "'" & reservationid_CB.Text & "',"
        Sql = Sql & "'" & standardRoomR_txt.Text & "',"
        Sql = Sql & "'" & deluxeRoom_txt.Text & "',"
        Sql = Sql & "'" & superiorRoomR_txt.Text & "',"
        Sql = Sql & roomPriceGroupR_txt.Text & ","
        Sql = Sql & deposit & ","
        Sql = Sql & "'" & customerNameGroupR_txt.Text & "',"
        Sql = Sql & "'" & customerICGroupR_txt.Text & "',"
        Sql = Sql & "'" & phonenumberGroupR_txt.Text & "',"
        Sql = Sql & "'" & durationgrp_txt.Text & "',"
        Sql = Sql & "'" & dateGroupR_txt.Text & "',"
        Sql = Sql & "'" & todaydate_txt.Text & "',"
        Sql = Sql & "'" & checkoutdateGroupR_txt.Text & "',"
        Sql = Sql & "'Group','Checked-In','Not Pay')"

        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()

        Dim sql1 As String = "UPDATE RoomReservation set Status = 'Checked-In' where Room_Reservation_ID = '" & reservationid_CB.Text & "'"
        Dim cmd1 As New OleDbCommand
        cmd1 = New OleDbCommand(sql1, con)
        cmd1.ExecuteNonQuery()

        count = roomlistGrouR_LV.Items.Count
        For i = 0 To count - 1

            Dim cmd3 As New OleDbCommand
            Dim sql2 As String = "insert into CheckInRoom values("
            sql2 = sql2 & "'" & checkInIDGroupR_txt.Text & "',"
            sql2 = sql2 & "'" & customerNameGroupR_txt.Text & "',"
            sql2 = sql2 & "'" & roomlistGrouR_LV.Items(i).Text & "',"
            sql2 = sql2 & "'" & roomlistGrouR_LV.Items(i).SubItems(1).Text & "',"
            sql2 = sql2 & roomprice1 & ")"
            cmd3 = New OleDbCommand(sql2, con)
            cmd3.ExecuteNonQuery()

            Dim cmd4 As New OleDb.OleDbCommand
            Dim sql3 As String = "UPDATE Room set Status = 'Unavailable' where Room_ID = '" & roomlistGrouR_LV.Items(i).Text & "'"
            cmd4 = New OleDbCommand(sql3, con)
            cmd4.ExecuteNonQuery()

        Next

        MsgBox("Check-In successfully.")
        ds2.Clear()
        con.Close()

        Me.Close()
    End Sub

    Private Sub checkInGroupW_btn_Click(sender As Object, e As EventArgs) Handles checkInGroupW_btn.Click

        If roollistW_LV.Items.Count <> (Val(standardRoomW_txt.Text) + Val(deluxeRoomW_txt.Text) + Val(superiorRoomW_txt.Text)) Then
            MsgBox("The number of room that had issued is different as the total number of room check in.")
            Exit Sub
        End If

        If priceGroupW_txt.Text = "" Then
            MsgBox("Please fill in the deposit.")
            Exit Sub
        End If

        If customerNameGroupW_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If customerICGroupW_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If phoneNOGroupW_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If durationgroup_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If

        If IsNumeric(customerICGroupW_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(phoneNOGroupW_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        roomprice = (Val(standardRoomW_txt.Text) * 150) + (Val(deluxeRoomW_txt.Text) * 300) + (Val(superiorRoomW_txt.Text) * 500)

        Dim cmd As New OleDbCommand
        Dim Sql As String

        Sql = "insert into CheckIn values("
        Sql = Sql & "'" & checkInIDGroupW_txt.Text & "',"
        Sql = Sql & "'" & "',"
        Sql = Sql & standardRoomW_txt.Text & ","
        Sql = Sql & deluxeRoomW_txt.Text & ","
        Sql = Sql & superiorRoomW_txt.Text & ","
        Sql = Sql & roomprice & ","
        Sql = Sql & priceGroupW_txt.Text & ","
        Sql = Sql & "'" & customerNameGroupW_txt.Text & "',"
        Sql = Sql & "'" & customerICGroupW_txt.Text & "',"
        Sql = Sql & "'" & phoneNOGroupW_txt.Text & "',"
        Sql = Sql & "'" & durationgroup_txt.Text & "',"
        Sql = Sql & "'" & todaydate_txt.Text & "',"
        Sql = Sql & "'" & todaydate_txt.Text & "',"
        Sql = Sql & "'" & dateGroupW_txt.Text & "',"
        Sql = Sql & "'Group','Checked-In','Not Pay')"


        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()

        count = roollistW_LV.Items.Count
        For i = 0 To count - 1

            Dim cmd1 As New OleDbCommand
            Dim sql2 As String = "insert into CheckInRoom values("
            sql2 = sql2 & "'" & checkInIDGroupW_txt.Text & "',"
            sql2 = sql2 & "'" & customerNameGroupW_txt.Text & "',"
            sql2 = sql2 & "'" & roollistW_LV.Items(i).Text & "',"
            sql2 = sql2 & "'" & roollistW_LV.Items(i).SubItems(1).Text & "',"
            sql2 = sql2 & roompriceGroupW & ")"
            cmd1 = New OleDbCommand(sql2, con)
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New OleDb.OleDbCommand
            Dim sql3 As String = "UPDATE Room set Status = 'Unavailable' where Room_ID = '" & roollistW_LV.Items(i).Text & "'"
            cmd2 = New OleDbCommand(sql3, con)
            cmd2.ExecuteNonQuery()
        Next
        
        ds3.Clear()

        MsgBox("Check-In successfully.")


        ds2.Clear()
        ds3.Clear()
        con.Close()
        Me.Close()
    End Sub
    Private Sub addR_btn_Click(sender As Object, e As EventArgs) Handles addR_btn.Click
        TotRoom = Val(standardRoomR_txt.Text) + Val(deluxeRoom_txt.Text) + Val(superiorRoomR_txt.Text)

        If roomlistGrouR_LV.Items.Count < TotRoom Then

            count = roomlistGrouR_LV.Items.Count
            For i = 0 To count - 1
                If roomlistGrouR_LV.Items(i).Text = roomNOGroupR_CB.Text Then
                    MsgBox("This room is already added in the room list.")
                    Exit Sub
                End If
            Next

            If stdr = 0 And roomTypeGroupR_CB.SelectedItem = "Standard Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If delr = 0 And roomTypeGroupR_CB.SelectedItem = "Deluxe Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If supr = 0 And roomTypeGroupR_CB.SelectedItem = "Superior Room" Then
                MsgBox("You are only allow to issue the same number of room as you write.")
                Exit Sub
            End If

            If stdr > 0 And roomTypeGroupR_CB.SelectedItem = "Standard Room" Then
                stdr = stdr - 1
               
            End If

            If delr > 0 And roomTypeGroupR_CB.SelectedItem = "Deluxe Room" Then
                delr = delr - 1
               
            End If

            If supr > 0 And roomTypeGroupR_CB.SelectedItem = "Superior Room" Then
                supr = supr - 1
               
            End If

            Dim item As New ListViewItem(roomNOGroupR_CB.Text)
            item.SubItems.Add(roomTypeGroupR_CB.Text)
            roomlistGrouR_LV.Items.Add(item)


            If stdr = 0 And delr = 0 And supr = 0 Then
                MsgBox("You have issued all the room.")
            End If

            If roomTypeGroupR_CB.Text = "Standard Room" Then
                roomprice1 = 150
            End If

            If roomTypeGroupR_CB.Text = "Deluxe Room" Then
                roomprice1 = 300
            End If

            If roomTypeGroupR_CB.Text = "Superior Room" Then
                roomprice1 = 500
            End If
        Else
            MsgBox("The room added could not more than the room number.")
        End If
    End Sub
    Private Sub priceGroupW_txt_click(sender As Object, e As EventArgs) Handles priceGroupW_txt.Click
        stdr = Val(standardRoomW_txt.Text)
        delr = Val(deluxeRoomW_txt.Text)
        supr = Val(superiorRoomW_txt.Text)

        roomprice = (Val(standardRoomW_txt.Text) * 150) + (Val(deluxeRoomW_txt.Text) * 300) + (Val(superiorRoomW_txt.Text) * 500)
        roomprice_txt.Text = roomprice

        If standardRoomW_txt.Text = 0 Then
            roomTypeGroupW_CB.Items.Remove("Standard Room")
        End If

        If deluxeRoomW_txt.Text = 0 Then
            roomTypeGroupW_CB.Items.Remove("Deluxe Room")
        End If

        If superiorRoomW_txt.Text = 0 Then
            roomTypeGroupW_CB.Items.Remove("Superior Room")
        End If
    End Sub
    Private Sub deleteGroupR_btn_Click(sender As Object, e As EventArgs) Handles deleteGroupR_btn.Click
        Dim choice As String = MsgBox("confirm delete?", vbYesNo)
        If choice = vbYes Then
            For i As Integer = roomlistGrouR_LV.SelectedIndices.Count - 1 To 0 Step -1
                roomlistGrouR_LV.Items.RemoveAt(roomlistGrouR_LV.SelectedIndices.Item(i))
            Next
        End If

        roomTypeGroupR_CB.Text = ""
        roomNOGroupR_CB.Text = ""
    End Sub

    Private Sub clearGroupW_btn_Click(sender As Object, e As EventArgs) Handles clearGroupW_btn.Click
        ' clear all the textboxs
        standardRoomW_txt.Clear()
        deluxeRoomW_txt.Clear()
        superiorRoomW_txt.Clear()
        roomprice_txt.Clear()
        priceGroupW_txt.Clear()
        customerNameGroupW_txt.Clear()
        customerICGroupW_txt.Clear()
        phoneNOGroupW_txt.Clear()
        durationgroup_txt.Clear()
        roomTypeGroupW_CB.Text = ""
        roomNOGroupW_CB.Text = ""
        roomTypeGroupW_CB.Items.Clear()
        roomNOGroupW_CB.Items.Clear()
        Room_Number_W.Items.Clear()
    End Sub
    Private Sub clearIndiviW_btn_Click(sender As Object, e As EventArgs) Handles clearIndiviW_btn.Click
        roomTypeindiW_CB.Text = ""
        roomNOInvidiW_CB.Items.Clear()
        roomNOInvidiW_CB.Text = ""
        roompriceindi_txt.Clear()
        depositindi_txt.Clear()
        customerNameIndiviW_txt.Clear()
        customerICIndiviW_txt.Clear()
        phoneNOIndiviW_txt.Clear()
        durationIndiviW_txt.Clear()
    End Sub

    Private Sub deleteroomGroupW_btn_Click(sender As Object, e As EventArgs) Handles deleteroomGroupW_btn.Click
        'delete confirmation will pop out to ensure the deletion
        Dim choice As String = MsgBox("confirm delete?", vbYesNo)
        If choice = vbYes Then
            For i As Integer = roollistW_LV.SelectedIndices.Count - 1 To 0 Step -1
                roollistW_LV.Items.RemoveAt(roollistW_LV.SelectedIndices.Item(i))
            Next
        End If

        roomTypeGroupW_CB.Text = ""
        roomNOGroupW_CB.Text = ""
    End Sub
    Private Sub clearGroupR_btn_Click(sender As Object, e As EventArgs) Handles clearGroupR_btn.Click
        roomPriceGroupR_txt.Clear()
        customerNameGroupR_txt.Clear()
        customerICGroupR_txt.Clear()
        phonenumberGroupR_txt.Clear()
    End Sub
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        todaydate_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
        dateIndiviW_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub
    Private Sub durationIndiviW_txt_TextChanged(sender As Object, e As EventArgs) Handles durationIndiviW_txt.TextChanged
        'auto generate checked out date based on the duration that enter
        Dim date1 As Date
        Dim dur As Integer
        date1 = Date.Now
        dur = Val(durationIndiviW_txt.Text)
        checkoutIndiW_txt.Text = DateAdd(DateInterval.Day, dur, date1).ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub
    Private Sub durationgroup_txt_TextChanged(sender As Object, e As EventArgs) Handles durationgroup_txt.TextChanged
        Dim date1 As Date
        Dim dur As Integer
        date1 = Date.Now
        dur = Val(durationgroup_txt.Text)
        dateGroupW_txt.Text = DateAdd(DateInterval.Day, dur, date1).ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub

    Private Sub roomIndiviTab_Click(sender As Object, e As EventArgs) Handles roomIndiviTab.Click

    End Sub
End Class