Imports System.Data.OleDb
Imports MaterialSkin
Imports System.Text.RegularExpressions

Public Class RMMenu
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3, da4, da5, da6, da7 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec, totalRec1, totalRec2, totalRec3, totalRec4 As Integer
    Dim Sql, Sql1, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7 As String
    Dim a, b, c As Integer
    Dim p, p1, p2, t, t1, t2, f, f1, f2, d As Integer
    Dim o, o1, o2, u As Integer

    Private Sub RMMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
        bookingDateIndivi_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay

        Call newReserv()
        Call newFnS()
        con.Open()
        Sql = "Select Room_Type from Room"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomType")
        totalRec = ds.Tables("RoomType").Rows.Count - 1
        roomtype_CB.Items.Clear()
        For i = 0 To totalRec
            roomtype_CB.Items.Add(ds.Tables("RoomType").Rows(i).Item(0))
        Next

        Sql2 = "Select distinct FnS_Type from FacilitiesAndServices"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "FnS_Type")
        totalRec2 = ds2.Tables("FnS_Type").Rows.Count - 1
        typeFnS_CB.Items.Clear()
        For k = 0 To totalRec2
            typeFnS_CB.Items.Add(ds2.Tables("FnS_Type").Rows(k).Item(0))
        Next

        Sql3 = "Select Room_ID from Room where Status='Unavailable' order by Room_ID"
        da3 = New OleDbDataAdapter(Sql3, con)
        da3.Fill(ds3, "Room_ID")
        totalRec3 = ds3.Tables("Room_ID").Rows.Count - 1
        roomNOFnS_CB.Items.Clear()
        For n = 0 To totalRec3
            roomNOFnS_CB.Items.Add(ds3.Tables("Room_ID").Rows(n).Item(0))
        Next
        con.Close()

    End Sub

    Public Sub newReserv()
        con.Open()
        ds1.Clear()
        Sql1 = "Select Room_Reservation_ID from RoomReservation"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "ReservationID")
        totalRec1 = ds1.Tables("ReservationID").Rows.Count

        Dim newReservID As Integer = 100
        Dim j As Integer

        For j = 0 To totalRec1 - 1
            If newReservID = ds1.Tables("ReservationID").Rows(j).Item(0) Then
                newReservID += 1
            Else
                Exit For
            End If
        Next
        reservationIDIndivi_txt.Text = newReservID
        reservationIDGroup_txt.Text = newReservID
        con.Close()
    End Sub

    Public Sub newFnS()
        con.Open()
        ds4.Clear()
        Sql4 = "Select FnS_Reservation_ID from FnSReservation"
        da4 = New OleDbDataAdapter(Sql4, con)
        da4.Fill(ds4, "FnSReservationID")
        totalRec4 = ds4.Tables("FnSReservationID").Rows.Count

        Dim newFnSReservID As Integer = 100
        Dim n As Integer

        For n = 0 To totalRec4 - 1
            If newFnSReservID = ds4.Tables("FnSReservationID").Rows(n).Item(0) Then
                newFnSReservID += 1
            Else
                Exit For
            End If
        Next
        reservID_txt.Text = newFnSReservID
        con.Close()
    End Sub

    Private Sub RMMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Reservations_Management.Enabled = True
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub roomtype_CB_MouseDown(sender As Object, e As MouseEventArgs) Handles roomtype_CB.MouseDown
    End Sub

    Private Sub roomtype_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roomtype_CB.SelectedIndexChanged
        con.Open()
        ds2.Clear()
        priceIndivi_txt.Clear()
        durationGroup_txt.Clear()
        totalPrice_txt.Clear()

        Sql2 = "Select Price from Room where Room_Type='" & roomtype_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "Price")
        priceIndivi_txt.Text = ds2.Tables("Price").Rows(0).Item(0)

        If roomtype_CB.Text = "Standard Room" Then
            a = 1
            b = 0
            c = 0
            o = a * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o
        ElseIf roomtype_CB.Text = "Deluxe Room" Then
            a = 0
            b = 1
            c = 0
            o1 = b * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o1
        ElseIf roomtype_CB.Text = "Superior Room" Then
            a = 0
            b = 0
            c = 1
            o2 = c * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o2
        End If
        con.Close()
    End Sub

    Private Sub addIndivi_btn_Click(sender As Object, e As EventArgs) Handles addIndivi_btn.Click
        If reservationIDIndivi_txt.Text <> "" And priceIndivi_txt.Text <> "" And depositIndivi_txt.Text <> "" And customerNameIndivi_txt.Text <> "" And customerICIndivi_txt.Text <> "" And phoneNOIndivi_txt.Text <> "" And durationIndivi_txt.Text <> "" Then
            If IsNumeric(customerNameIndivi_txt.Text) = True Then
                MsgBox("The name that you have entered is invalid.", MsgBoxStyle.Critical)
                customerNameIndivi_txt.Clear()
                customerNameIndivi_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(depositIndivi_txt.Text) = False Then
                MsgBox("The deposit that you have entered is invalid.", MsgBoxStyle.Critical)
                depositIndivi_txt.Clear()
                depositIndivi_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(customerICIndivi_txt.Text) = False Then
                MsgBox("The I/C number that you have entered is invalid.", MsgBoxStyle.Critical)
                customerICIndivi_txt.Clear()
                customerICIndivi_txt.Focus()
                Exit Sub
            End If
        ElseIf IsNumeric(phoneNOIndivi_txt.Text) = False Then
            MsgBox("The phone that you have entered is invalid.", MsgBoxStyle.Critical)
            phoneNOIndivi_txt.Clear()
            phoneNOIndivi_txt.Focus()
            Exit Sub
        ElseIf IsNumeric(durationIndivi_txt.Text) = False Then
            MsgBox("The duration that you have entered is invalid.", MsgBoxStyle.Critical)
            durationIndivi_txt.Clear()
            durationIndivi_txt.Focus()
            Exit Sub
        ElseIf reservationIDIndivi_txt.Text = "" Or priceIndivi_txt.Text = "" Or depositIndivi_txt.Text = "" Or customerNameIndivi_txt.Text <> "" Or customerICIndivi_txt.Text = "" Or phoneNOIndivi_txt.Text = "" Or durationIndivi_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        con.Open()
        Sql = "insert into RoomReservation values ('"
        Sql = Sql & reservationIDIndivi_txt.Text & "','"
        Sql = Sql & a & "','"
        Sql = Sql & b & "','"
        Sql = Sql & c & "','"
        Sql = Sql & totalPrice_txt.Text & "','"
        Sql = Sql & depositIndivi_txt.Text & "','"
        Sql = Sql & customerNameIndivi_txt.Text & "','"
        Sql = Sql & customerICIndivi_txt.Text & "','"
        Sql = Sql & phoneNOIndivi_txt.Text & "','"
        Sql = Sql & durationIndivi_txt.Text & "','"
        Sql = Sql & bookingDateIndivi_txt.Text & "','"
        Sql = Sql & reservDateIndivi_dtp.Value & "','"
        Sql = Sql & "Individual','Reserved')"

        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Individual Reservation is added.")

        reservationIDIndivi_txt.Clear()
        roomtype_CB.Text = ""
        priceIndivi_txt.Clear()
        customerNameIndivi_txt.Clear()
        customerICIndivi_txt.Clear()
        phoneNOIndivi_txt.Clear()
        durationIndivi_txt.Clear()
        bookingDateIndivi_txt.Clear()
        reservDateIndivi_dtp.ResetText()
        con.Close()
        Call newReserv()
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub addGroup_btn_Click(sender As Object, e As EventArgs) Handles addGroup_btn.Click
        If reservationIDGroup_txt.Text <> "" And standardRoom_txt.Text <> "" And deluxeRoom_txt.Text <> "" And superiorRoom_txt.Text <> "" And bookingPriceGroup_txt.Text <> "" And depositGroup_txt.Text = "" And customerNameGroup_txt.Text <> "" And customerICGroup_txt.Text <> "" And phoneNOGroup_txt.Text <> "" And durationGroup_txt.Text <> "" Then
            If IsNumeric(customerNameGroup_txt.Text) = True Then
                MsgBox("The name that you have entered is invalid.", MsgBoxStyle.Critical)
                customerNameIndivi_txt.Clear()
                customerNameIndivi_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(standardRoom_txt.Text) = False Then
                MsgBox("The duration that you have entered is invalid.", MsgBoxStyle.Critical)
                standardRoom_txt.Clear()
                standardRoom_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(deluxeRoom_txt.Text) = False Then
                MsgBox("The duration that you have entered is invalid.", MsgBoxStyle.Critical)
                deluxeRoom_txt.Clear()
                deluxeRoom_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(superiorRoom_txt.Text) = False Then
                MsgBox("The duration that you have entered is invalid.", MsgBoxStyle.Critical)
                superiorRoom_txt.Clear()
                superiorRoom_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(depositGroup_txt.Text) = False Then
                MsgBox("The deposit that you have entered is invalid.", MsgBoxStyle.Critical)
                depositGroup_txt.Clear()
                depositGroup_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(customerICGroup_txt.Text) = False Then
                MsgBox("The I/C number that you have entered is invalid.", MsgBoxStyle.Critical)
                customerICGroup_txt.Clear()
                customerICGroup_txt.Focus()
                Exit Sub
            End If
        ElseIf IsNumeric(phoneNOGroup_txt.Text) = False Then
            MsgBox("The phone that you have entered is invalid.", MsgBoxStyle.Critical)
            phoneNOIndivi_txt.Clear()
            phoneNOIndivi_txt.Focus()
            Exit Sub
        ElseIf IsNumeric(durationGroup_txt.Text) = False Then
            MsgBox("The duration that you have entered is invalid.", MsgBoxStyle.Critical)
            durationIndivi_txt.Clear()
            durationIndivi_txt.Focus()
            Exit Sub
        ElseIf reservationIDGroup_txt.Text = "" Or standardRoom_txt.Text = "" Or deluxeRoom_txt.Text = "" Or superiorRoom_txt.Text = "" Or bookingPriceGroup_txt.Text = "" Or depositGroup_txt.Text = "" Or customerNameIndivi_txt.Text <> "" Or customerICGroup_txt.Text = "" Or phoneNOGroup_txt.Text = "" Or durationGroup_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        con.Open()
        bookingDateGroup_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
        Sql = "insert into RoomReservation values ('"
        Sql = Sql & reservationIDGroup_txt.Text & "','"
        Sql = Sql & standardRoom_txt.Text & "','"
        Sql = Sql & deluxeRoom_txt.Text & "','"
        Sql = Sql & superiorRoom_txt.Text & "','"
        Sql = Sql & bookingPriceGroup_txt.Text & "','"
        Sql = Sql & depositGroup_txt.Text & "','"
        Sql = Sql & customerNameGroup_txt.Text & "','"
        Sql = Sql & customerICGroup_txt.Text & "','"
        Sql = Sql & phoneNOGroup_txt.Text & "','"
        Sql = Sql & durationGroup_txt.Text & "','"
        Sql = Sql & bookingDateGroup_txt.Text & "','"
        Sql = Sql & reservDateGroup_dtp.Value & "','"
        Sql = Sql & "Group','Reserved')"

        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Group Reservation is added.")
        reservationIDGroup_txt.Clear()
        standardRoom_txt.Text = 0
        deluxeRoom_txt.Text = 0
        superiorRoom_txt.Text = 0
        bookingPriceGroup_txt.Clear()
        customerNameGroup_txt.Clear()
        customerICGroup_txt.Clear()
        phoneNOGroup_txt.Clear()
        durationGroup_txt.Clear()
        bookingDateGroup_txt.Clear()
        reservDateGroup_dtp.ResetText()
        con.Close()
        Call newReserv()
    End Sub

    Public Sub StandardRoom()
        con.Open()
        ds5.Clear()
        Sql5 = "Select Price from Room where Room_Type='Standard Room'"
        da5 = New OleDbDataAdapter(Sql5, con)
        da5.Fill(ds5, "StandardRoom")
        t = ds5.Tables("StandardRoom").Rows(0).Item(0)
        con.Close()
    End Sub
    Public Sub DeluxeRoom()
        con.Open()
        ds6.Clear()
        Sql6 = "Select Price from Room where Room_Type='Deluxe Room'"
        da6 = New OleDbDataAdapter(Sql6, con)
        da6.Fill(ds6, "DeluxeRoom")
        t1 = ds6.Tables("DeluxeRoom").Rows(0).Item(0)
        con.Close()
    End Sub
    Public Sub SuperiorRoom()
        con.Open()
        ds7.Clear()
        Sql7 = "Select Price from Room where Room_Type='Superior Room'"
        da7 = New OleDbDataAdapter(Sql7, con)
        da7.Fill(ds7, "SuperiorRoom")
        t2 = ds7.Tables("SuperiorRoom").Rows(0).Item(0)
        con.Close()
    End Sub

    Private Sub standardRoom_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles standardRoom_txt.KeyUp
        If standardRoom_txt.Text = "" Then
            standardRoom_txt.Text = 0
            
        End If
        If IsNumeric(standardRoom_txt.Text) = False Then
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            standardRoom_txt.Clear()
            standardRoom_txt.Focus()
            Exit Sub
        End If

        p = standardRoom_txt.Text
        Call StandardRoom()
        f = p * t * d
        bookingPriceGroup_txt.Text = f + f1 + f2
    End Sub
    Private Sub deluxeRoom_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles deluxeRoom_txt.KeyUp
        If deluxeRoom_txt.Text = "" Then
            deluxeRoom_txt.Text = 0
        End If
        If IsNumeric(deluxeRoom_txt.Text) = False Then
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            deluxeRoom_txt.Clear()
            deluxeRoom_txt.Focus()
            Exit Sub
        End If

        p1 = deluxeRoom_txt.Text
        Call DeluxeRoom()
        f1 = p1 * t1 * d
        bookingPriceGroup_txt.Text = f + f1 + f2
    End Sub
    Private Sub superiorRoom_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles superiorRoom_txt.KeyUp
        If superiorRoom_txt.Text = "" Then
            superiorRoom_txt.Text = 0
        End If
        If IsNumeric(superiorRoom_txt.Text) = False Then
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            superiorRoom_txt.Clear()
            superiorRoom_txt.Focus()
            Exit Sub
        End If

        p2 = superiorRoom_txt.Text
        Call SuperiorRoom()
        f2 = p2 * t2 * d
        bookingPriceGroup_txt.Text = f + f1 + f2
    End Sub

    Private Sub standardRoom_txt_MouseDown(sender As Object, e As MouseEventArgs) Handles standardRoom_txt.MouseDown
        standardRoom_txt.Clear()
    End Sub
    Private Sub deluxeRoom_txt_MouseDown(sender As Object, e As MouseEventArgs) Handles deluxeRoom_txt.MouseDown
        deluxeRoom_txt.Clear()
    End Sub

    Private Sub superiorRoom_txt_MouseDown(sender As Object, e As MouseEventArgs) Handles superiorRoom_txt.MouseDown
        superiorRoom_txt.Clear()
    End Sub

    Private Sub typeFnS_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeFnS_CB.SelectedIndexChanged
        con.Open()
        ds2.Clear()
        nameFnS_CB.Text = ""
        nameFnS_CB.Items.Clear()
        FnSID_txt.Clear()
        chargesFeesFnS_txt.Clear()

        Sql2 = "Select FnS_Name from FacilitiesAndServices where FnS_Type='" & typeFnS_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "FnS_Name")
        totalRec3 = ds2.Tables("FnS_Name").Rows.Count - 1
        For i = 0 To totalRec3
            nameFnS_CB.Items.Add(ds2.Tables("FnS_Name").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub nameFnS_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nameFnS_CB.SelectedIndexChanged
        con.Open()
        ds3.Clear()
        FnSID_txt.Clear()

        Sql2 = "Select FnS_ID from FacilitiesAndServices where FnS_Name='" & nameFnS_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds3, "FnS_Name")
        FnSID_txt.Text = ds3.Tables("FnS_Name").Rows(0).Item(0)

        ds4.Clear()
        chargesFeesFnS_txt.Clear()

        Sql3 = "Select Charged_per_person from FacilitiesAndServices where FnS_Name='" & nameFnS_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql3, con)
        da2.Fill(ds4, "ChargesFess")
        chargesFeesFnS_txt.Text = ds4.Tables("ChargesFess").Rows(0).Item(0)
        con.Close()
    End Sub

    Private Sub addFnS_btn_Click(sender As Object, e As EventArgs) Handles addFnS_btn.Click
        If reservID_txt.Text <> "" And typeFnS_CB.Text <> "" And nameFnS_CB.Text <> "" And FnSID_txt.Text <> "" And roomNOFnS_CB.Text <> "" And customerName_txt.Text <> "" And chargesFeesFnS_txt.Text <> "" Then
            If IsNumeric(customerName_txt.Text) = True Then
                MsgBox("The name that you have entered is invalid.", MsgBoxStyle.Critical)
                customerName_txt.Clear()
                customerName_txt.Focus()
                Exit Sub
            End If
        ElseIf reservID_txt.Text = "" And typeFnS_CB.Text = "" And nameFnS_CB.Text = "" And FnSID_txt.Text = "" And roomNOFnS_CB.Text = "" And customerName_txt.Text = "" And chargesFeesFnS_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        con.Open()
        bookingDate_txt.Text = Date.Now.ToString("dd-MM-yyyy") & " " & TimeOfDay
        Sql = "insert into FnSReservation values ('"
        Sql = Sql & reservID_txt.Text & "','"
        Sql = Sql & typeFnS_CB.Text & "','"
        Sql = Sql & nameFnS_CB.Text & "','"
        Sql = Sql & FnSID_txt.Text & "','"
        Sql = Sql & roomNOFnS_CB.Text & "','"
        Sql = Sql & customerName_txt.Text & "','"
        Sql = Sql & chargesFeesFnS_txt.Text & "','"
        Sql = Sql & bookingDate_txt.Text & "','"
        Sql = Sql & "Unpay')"
        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("Facilities or Services is booked.")
        con.Close()
        Call newFnS()
        typeFnS_CB.Text = ""
        nameFnS_CB.Text = ""
        nameFnS_CB.Items.Clear()
        FnSID_txt.Clear()
        roomNOFnS_CB.Text = ""
        customerName_txt.Clear()
        chargesFeesFnS_txt.Clear()
        bookingDate_txt.Clear()

    End Sub

    Private Sub clearIndivi_btn_Click(sender As Object, e As EventArgs) Handles clearIndivi_btn.Click
        roomtype_CB.Text = ""
        priceIndivi_txt.Clear()
        customerNameIndivi_txt.Clear()
        customerICIndivi_txt.Clear()
        phoneNOIndivi_txt.Clear()
        durationIndivi_txt.Clear()
        bookingDateIndivi_txt.Clear()
        reservDateIndivi_dtp.ResetText()
    End Sub

    Private Sub clearGroup_btn_Click(sender As Object, e As EventArgs) Handles clearGroup_btn.Click
        standardRoom_txt.Text = 0
        deluxeRoom_txt.Text = 0
        superiorRoom_txt.Text = 0
        bookingPriceGroup_txt.Clear()
        customerNameGroup_txt.Clear()
        customerICGroup_txt.Clear()
        phoneNOGroup_txt.Clear()
        durationGroup_txt.Clear()
        bookingDateGroup_txt.Clear()
        reservDateGroup_dtp.ResetText()
    End Sub

    Private Sub durationGroup_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles durationGroup_txt.KeyUp
        If durationGroup_txt.Text = "" Then
            durationGroup_txt.Text = 0
        End If

        If IsNumeric(durationGroup_txt.Text) = False Then
            durationGroup_txt.Clear()
            durationGroup_txt.Focus()
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        d = durationGroup_txt.Text

    End Sub

    Private Sub durationIndivi_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles durationIndivi_txt.KeyUp

        If durationIndivi_txt.Text = "" Then
            durationIndivi_txt.Text = 0
        End If

        If IsNumeric(durationIndivi_txt.Text) = False Then
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            durationIndivi_txt.Clear()
            durationGroup_txt.Focus()
            Exit Sub
        End If

        If roomtype_CB.Text = "Standard Room" Then
            u = durationIndivi_txt.Text
            o = a * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o
        End If
        If roomtype_CB.Text = "Deluxue Room" Then
            u = durationIndivi_txt.Text
            o1 = b * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o1
        End If
        If roomtype_CB.Text = "Superior Room" Then
            u = durationIndivi_txt.Text
            o2 = c * u * priceIndivi_txt.Text
            totalPrice_txt.Text = o2
        End If
    End Sub

    Private Sub durationIndivi_txt_MouseDown(sender As Object, e As MouseEventArgs) Handles durationIndivi_txt.MouseDown
        durationIndivi_txt.Clear()
    End Sub

    Private Sub durationGroup_txt_MouseDown(sender As Object, e As MouseEventArgs) Handles durationGroup_txt.MouseDown
        durationGroup_txt.Clear()
    End Sub
End Class