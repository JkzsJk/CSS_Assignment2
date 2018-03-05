Imports MaterialSkin
Imports System.Data.OleDb
Public Class CheckOut
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds9, ds10, ds11, ds12, ds13, ds14, ds15, ds16, ds17, ds18 As New DataSet
    Dim TotCO, CurCO, TotCI, standardr, deluxer, superiorr, TotCIR, roomprice As Integer
    Private Sub CheckOut_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrontDeskManagement.Enabled = True
    End Sub
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Timer1.Start()

        con.Open()

        checkoutindi_txt.Enabled = False
        checkoutidgrp_txt.Enabled = False
        'auto generate the checkout id
        Dim Sql1 As String = "select * from CheckOut"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds9, "checkout")
        TotCO = 0
        TotCO = ds9.Tables("checkout").Rows.Count - 1
        CurCO = 100
        For i = 0 To TotCO
            CurCO = ds9.Tables("checkout").Rows(i).Item(0)
            CurCO = CurCO + 1
        Next
        checkoutindi_txt.Text = CurCO
        checkoutidgrp_txt.Text = CurCO
        'add the checkin id into the check in id combo box for search purpose
        checkinidIndi_CB.Items.Clear()
        Dim Sql As String = "select * from CheckIn where CheckIn_Type ='Individual' and Status = 'Checked-In'"
        Dim da As New OleDbDataAdapter(Sql, con)
        da.Fill(ds10, "checkoutindi")
        TotCI = ds10.Tables("checkoutindi").Rows.Count - 1
        For i = 0 To TotCI
            checkinidIndi_CB.Items.Add(ds10.Tables("checkoutindi").Rows(i).Item(0))
        Next

        checkinidGroup_CB.Items.Clear()
        Dim Sql2 As String = "select * from CheckIn where CheckIn_Type ='Group'and Status = 'Checked-In'"
        Dim da2 As New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds11, "checkoutgroup")
        TotCI = 0
        TotCI = ds11.Tables("checkoutgroup").Rows.Count - 1
        For i = 0 To TotCI
            checkinidGroup_CB.Items.Add(ds11.Tables("checkoutgroup").Rows(i).Item(0))
        Next
    End Sub
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        'retrieve checkin details from database to display in form based on checkin id
        Dim sql As String = "select * from CheckIn where CheckIn_ID = '" & checkinidIndi_CB.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds12, "checkin")

        If ds12.Tables("checkin").Rows(0).Item(2) = 1 Then
            roomtypeIndi_txt.Text = "Standard Room"
        End If

        If ds12.Tables("checkin").Rows(0).Item(3) = 1 Then
            roomtypeIndi_txt.Text = "Deluxe Room"
        End If

        If ds12.Tables("checkin").Rows(0).Item(4) = 1 Then
            roomtypeIndi_txt.Text = "Superior Room"
        End If

        depositpaidindi_txt.Text = ds12.Tables("checkin").Rows(0).Item(6)
        customerName_txt.Text = ds12.Tables("checkin").Rows(0).Item(7)
        customerIC_txt.Text = ds12.Tables("checkin").Rows(0).Item(8)
        phoneNO_txt.Text = ds12.Tables("checkin").Rows(0).Item(9)
        duration_txt.Text = ds12.Tables("checkin").Rows(0).Item(10)
        date_txt.Text = ds12.Tables("checkin").Rows(0).Item(12)

        Dim Sql1 As String = "select * from CheckInRoom"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds14, "checkin")
        TotCIR = ds14.Tables("checkin").Rows.Count - 1
        For i = 0 To TotCIR
            If ds14.Tables("checkin").Rows(i).Item(0) = checkinidIndi_CB.Text Then
                roomnoIndi_txt.Text = ds14.Tables("checkin").Rows(i).Item(2)
            End If
        Next

        If roomtypeIndi_txt.Text = "Standard Room" Then
            standardr = 1
            deluxer = 0
            superiorr = 0
        End If

        If roomtypeIndi_txt.Text = "Deluxe Room" Then
            standardr = 0
            deluxer = 1
            superiorr = 0
        End If

        If roomtypeIndi_txt.Text = "Superior Room" Then
            standardr = 0
            deluxer = 0
            superiorr = 1
        End If

        ds12.Clear()
        ds14.Clear()
    End Sub
    Private Sub checkOut_btn_Click(sender As Object, e As EventArgs) Handles checkOut_btn.Click
        'users are not allow to check out if there is any textbos is blank
        If extrachargesindi_txt.Text = "" Then
            MsgBox("Please fill in the extra charges.")
            Exit Sub
        End If

        If repaymentindi_txt.Text = "" Then
            MsgBox("Please fill in the repayment.")
            Exit Sub
        End If

        If customerName_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If customerIC_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If phoneNO_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If duration_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If

        If IsNumeric(customerIC_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(phoneNO_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        If IsNumeric(repaymentindi_txt.Text) = False Then
            MsgBox("Repayment can only be number.")
            Exit Sub
        End If

        If IsNumeric(extrachargesindi_txt.Text) = False Then
            MsgBox("Extra Charges can only be number.")
            Exit Sub
        End If


        Dim sql6 As String = "select * from Room where Room_ID = '" & roomnoIndi_txt.Text & "'"
        Dim da As New OleDbDataAdapter(sql6, con)
        da.Fill(ds15, "roomid")

        'add the checkout details into the CheckOut table
        Dim cmd2 As New OleDbCommand

        Dim sql As String = "insert into CheckOut values("
        sql = sql & "'" & checkoutindi_txt.Text & "',"
        sql = sql & "'" & checkinidIndi_CB.Text & "',"
        sql = sql & standardr & ","
        sql = sql & deluxer & ","
        sql = sql & superiorr & ","
        sql = sql & depositpaidindi_txt.Text & ","
        sql = sql & extrachargesindi_txt.Text & ","
        sql = sql & repaymentindi_txt.Text & ","
        sql = sql & "'" & customerName_txt.Text & "',"
        sql = sql & "'" & customerIC_txt.Text & "',"
        sql = sql & "'" & phoneNO_txt.Text & "',"
        sql = sql & "'" & todaydate_txt.Text & "')"

        cmd2 = New OleDbCommand(sql, con)
        cmd2.ExecuteNonQuery()
        'add the checkout room details into the CheckOutRoom table
        Dim cmd4 As New OleDbCommand
        Dim sql5 As String = "insert into CheckOutRoom values("
        sql5 = sql5 & "'" & checkoutindi_txt.Text & "',"
        sql5 = sql5 & "'" & roomnoIndi_txt.Text & "',"
        sql5 = sql5 & "'" & roomtypeIndi_txt.Text & "',"
        sql5 = sql5 & ds15.Tables("roomid").Rows(0).Item(2) & ")"

        cmd4 = New OleDbCommand(sql5, con)
        cmd4.ExecuteNonQuery()

        'update the status of the room that checked out to available
        Dim cmd1 As New OleDb.OleDbCommand
        Dim sql2 As String = "UPDATE Room set Status = 'Available' where Room_ID = '" & roomnoIndi_txt.Text & "'"
        cmd1 = New OleDbCommand(sql2, con)
        cmd1.ExecuteNonQuery()

        Dim sql3 As String = "select * from CheckIn where CheckIn_ID = '" & checkinidIndi_CB.Text & "'"
        Dim da1 As New OleDbDataAdapter(sql3, con)
        da1.Fill(ds13, "checkin")
        'update the room reservation status to checked-out 
        If (ds13.Tables("checkin").Rows(0).Item(1)).ToString <> "" Then
            Dim sql4 As String = "UPDATE RoomReservation set Status = 'Checked-Out' where Room_Reservation_ID = '" & ds13.Tables("checkin").Rows(0).Item(1) & "'"
            Dim cmd3 As New OleDbCommand
            cmd3 = New OleDbCommand(sql4, con)
            cmd3.ExecuteNonQuery()

        End If
        'update the check in status to checked-out 
        Dim cmd6 As New OleDb.OleDbCommand
        Dim sql9 As String = "UPDATE CheckIn set Status = 'Checked-Out' where CheckIn_ID = '" & checkinidIndi_CB.Text & "'"
        cmd6 = New OleDbCommand(sql9, con)
        cmd6.ExecuteNonQuery()

        MsgBox("Checked-Out successfully.")
        ds15.Clear()
        ds13.Clear()

        Me.Close()
    End Sub
    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        roomtypeIndi_txt.Clear()
        roomnoIndi_txt.Clear()
        customerName_txt.Clear()
        customerIC_txt.Clear()
        phoneNO_txt.Clear()
        duration_txt.Clear()
        date_txt.Clear()
        checkinidIndi_CB.Text = ""
        depositpaidindi_txt.Clear()
        extrachargesindi_txt.Clear()
        repaymentindi_txt.Clear()
    End Sub

    Private Sub searchGroupCO_btn_Click(sender As Object, e As EventArgs) Handles searchGroupCO_btn.Click
        'retrieve checkin details from database to display in the form based on the check in id
        Dim sql As String = "select * from CheckIn where CheckIn_ID = '" & checkinidGroup_CB.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds12, "checkin")

        depositpaidgrp_txt.Text = ds12.Tables("checkin").Rows(0).Item(6)
        cusNameCO_txt.Text = ds12.Tables("checkin").Rows(0).Item(7)
        cusICCO_txt.Text = ds12.Tables("checkin").Rows(0).Item(8)
        cusPNCO_txt.Text = ds12.Tables("checkin").Rows(0).Item(9)
        durationCO_txt.Text = ds12.Tables("checkin").Rows(0).Item(10)
        COdate_txt.Text = ds12.Tables("checkin").Rows(0).Item(12)

        Dim Sql1 As String = "select * from CheckInRoom"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds16, "checkin")
        TotCIR = ds16.Tables("checkin").Rows.Count - 1
        For i = 0 To TotCIR
            If ds16.Tables("checkin").Rows(i).Item(0) = checkinidGroup_CB.Text Then
                Room_Number_CO.Items.Add(ds16.Tables("checkin").Rows(i).Item(2) & " - " & ds16.Tables("checkin").Rows(i).Item(3))
            End If
        Next
        ds16.Clear()
        ds12.Clear()
    End Sub
    Private Sub clearGroup_btn_Click(sender As Object, e As EventArgs) Handles clearGroup_btn.Click
        Room_Number_CO.Items.Clear()
        cusNameCO_txt.Clear()
        cusICCO_txt.Clear()
        cusPNCO_txt.Clear()
        durationCO_txt.Clear()
        COdate_txt.Clear()
        depositpaidgrp_txt.Clear()
        checkinidGroup_CB.Text = ""
        extrachargesgrp_txt.Clear()
        repaymentgrp_txt.Clear()
    End Sub
    Private Sub checkoutGroup_btn_Click(sender As Object, e As EventArgs) Handles checkoutGroup_btn.Click

        If extrachargesgrp_txt.Text = "" Then
            MsgBox("Please fill in the extra charges.")
            Exit Sub
        End If

        If repaymentgrp_txt.Text = "" Then
            MsgBox("Please fill in the repayment.")
            Exit Sub
        End If

        If cusNameCO_txt.Text = "" Then
            MsgBox("Please fill in the name.")
            Exit Sub
        End If

        If cusICCO_txt.Text = "" Then
            MsgBox("Please fill in the I/C number.")
            Exit Sub
        End If

        If cusPNCO_txt.Text = "" Then
            MsgBox("Please fill in the phone number.")
            Exit Sub
        End If

        If durationCO_txt.Text = "" Then
            MsgBox("Please fill in the duration.")
            Exit Sub
        End If

        If IsNumeric(cusICCO_txt.Text) = False Then
            MsgBox("I/C number can only be number.")
            Exit Sub
        End If

        If IsNumeric(cusPNCO_txt.Text) = False Then
            MsgBox("Phone number can only be number.")
            Exit Sub
        End If

        If IsNumeric(repaymentgrp_txt.Text) = False Then
            MsgBox("Repayment can only be number.")
            Exit Sub
        End If

        If IsNumeric(extrachargesgrp_txt.Text) = False Then
            MsgBox("Extra Charges can only be number.")
            Exit Sub
        End If


        Dim sql As String = "select * from CheckIn where CheckIn_ID = '" & checkinidGroup_CB.Text & "'"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds12, "checkin")

        Dim cmd2 As New OleDbCommand

        Dim sql1 As String = "insert into CheckOut values("
        sql1 = sql1 & "'" & checkoutindi_txt.Text & "',"
        sql1 = sql1 & "'" & checkinidGroup_CB.Text & "',"
        sql1 = sql1 & ds12.Tables("checkin").Rows(0).Item(2) & ","
        sql1 = sql1 & ds12.Tables("checkin").Rows(0).Item(3) & ","
        sql1 = sql1 & ds12.Tables("checkin").Rows(0).Item(4) & ","
        sql1 = sql1 & depositpaidgrp_txt.Text & ","
        sql1 = sql1 & extrachargesgrp_txt.Text & ","
        sql1 = sql1 & repaymentgrp_txt.Text & ","
        sql1 = sql1 & "'" & cusNameCO_txt.Text & "',"
        sql1 = sql1 & "'" & cusICCO_txt.Text & "',"
        sql1 = sql1 & "'" & cusPNCO_txt.Text & "',"
        sql1 = sql1 & "'" & today_txt.Text & "')"

        cmd2 = New OleDbCommand(sql1, con)
        cmd2.ExecuteNonQuery()

        Dim sql7 As String = "select * from CheckInRoom"
        Dim da2 As New OleDbDataAdapter(sql7, con)
        da2.Fill(ds18, "checkout")
        TotCIR = ds18.Tables("checkout").Rows.Count - 1
        For i = 0 To TotCIR
            If ds18.Tables("checkout").Rows(i).Item(0) = checkinidGroup_CB.Text Then

                Dim cmd4 As New OleDbCommand
                Dim sql5 As String = "insert into CheckOutRoom values("
                sql5 = sql5 & "'" & checkoutindi_txt.Text & "',"
                sql5 = sql5 & "'" & ds18.Tables("checkout").Rows(i).Item(2) & "',"
                sql5 = sql5 & "'" & ds18.Tables("checkout").Rows(i).Item(3) & "',"
                sql5 = sql5 & ds18.Tables("checkout").Rows(0).Item(4) & ")"
                cmd4 = New OleDbCommand(sql5, con)
                cmd4.ExecuteNonQuery()

                Dim cmd1 As New OleDb.OleDbCommand
                Dim sql8 As String = "UPDATE Room set Status = 'Available' where Room_ID = '" & ds18.Tables("checkout").Rows(i).Item(2) & "'"
                cmd1 = New OleDbCommand(sql8, con)
                cmd1.ExecuteNonQuery()

            End If
        Next


        Dim sql3 As String = "select * from CheckIn where CheckIn_ID = '" & checkinidGroup_CB.Text & "'"
        Dim da1 As New OleDbDataAdapter(sql3, con)
        da1.Fill(ds13, "checkin")

        If (ds13.Tables("checkin").Rows(0).Item(1)).ToString <> "" Then
            Dim sql4 As String = "UPDATE RoomReservation set Status = 'Checked-Out' where Room_Reservation_ID = '" & ds13.Tables("checkin").Rows(0).Item(1) & "'"
            Dim cmd3 As New OleDbCommand
            cmd3 = New OleDbCommand(sql4, con)
            cmd3.ExecuteNonQuery()

        End If

        Dim cmd5 As New OleDb.OleDbCommand
        Dim sql0 As String = "UPDATE CheckIn set Status = 'Checked-Out' where CheckIn_ID = '" & checkinidGroup_CB.Text & "'"
        cmd5 = New OleDbCommand(sql0, con)
        cmd5.ExecuteNonQuery()

        MsgBox("Checked-Out successfully.")
        ds12.Clear()
        ds13.Clear()
        ds18.Clear()

        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        today_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
        todaydate_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
    End Sub
End Class