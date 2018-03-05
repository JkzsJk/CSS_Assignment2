Imports MaterialSkin
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class RMUpdateDataEntry
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9, ds10, ds11 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec, totalRec1, totalRec2, totalRec3, totalRec4, totalRec5 As Integer
    Dim Sql, Sql1, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7, Sql8, Sql9, Sql10, Sql11, Sql12 As String
    Dim a, b, c As Integer
    Dim p, p1, p2, t, t1, t2, f, f1, f2, d As Integer
    Dim FC As Boolean = False

    Public Sub reserv()
        con.Open()
        ds.Clear()
        Sql = "Select Room_Reservation_ID from RoomReservation"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomReservationID")
        totalRec = ds.Tables("RoomReservationID").Rows.Count - 1

        For i = 0 To totalRec
            reservationIDIndivi_CB.Items.Add(ds.Tables("RoomReservationID").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Public Sub FnS()
        con.Open()
        ds3.Clear()
        Sql3 = "Select FnS_Reservation_ID from FnSReservation"
        da3 = New OleDbDataAdapter(Sql3, con)
        da3.Fill(ds3, "FnSReservationID")
        totalRec1 = ds3.Tables("FnSReservationID").Rows.Count - 1

        For j = 0 To totalRec1
            reservID_CB.Items.Add(ds3.Tables("FnSReservationID").Rows(j).Item(0))
        Next
        con.Close()
    End Sub

    Public Sub Room()
        con.Open()
        Sql11 = "Select Room_ID from Room where Status='Unavailable' order by Room_ID"
        da11 = New OleDbDataAdapter(Sql11, con)
        da11.Fill(ds11, "Room_ID")
        totalRec5 = ds11.Tables("Room_ID").Rows.Count - 1
        roomNOFnS_CB.Items.Clear()
        For n = 0 To totalRec5
            roomNOFnS_CB.Items.Add(ds11.Tables("Room_ID").Rows(n).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub RMUpdateDataEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Reservations_Management.Enabled = True
    End Sub
    Private Sub RMUpdateDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)


        Call reserv()
        Call FnS()
        Call Room()
        

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub reservationIDIndivi_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reservationIDIndivi_CB.SelectedIndexChanged
        standardRoom_txt.Enabled = True
        deluxeRoom_txt.Enabled = True
        superiorRoom_txt.Enabled = True
        customerNameIndivi_txt.Enabled = True
        customerICIndivi_txt.Enabled = True
        phoneNOIndivi_txt.Enabled = True
        durationIndivi_txt.Enabled = True
        reservDateIndivi_dtp.Enabled = True
        clearIndivi_btn.Enabled = True

        con.Open()
        ds1.Clear()
        Sql1 = "Select * from RoomReservation where Room_Reservation_ID='" & reservationIDIndivi_CB.Text & "'"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "RoomReservation")

        standardRoom_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(1)
        deluxeRoom_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(2)
        superiorRoom_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(3)
        priceIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(4)
        depositIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(5)
        customerNameIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(6)
        customerICIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(7)
        phoneNOIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(8)
        durationIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(9)
        bookingDateIndivi_txt.Text = ds1.Tables("RoomReservation").Rows(0).Item(10)
        reservDateIndivi_dtp.Value = ds1.Tables("RoomReservation").Rows(0).Item(11)
        con.Close()
    End Sub

    Private Sub updateIndivi_btn_Click(sender As Object, e As EventArgs) Handles updateIndivi_btn.Click
        'update the reservation record
        'blank textboxs are not allow
        ' users are only allow to enter number in deluxe room,standard room,superior room, ic number textbox,deposit textbox,phone number textbox and duration textbox
        If reservationIDIndivi_CB.Text <> "" And standardRoom_txt.Text <> "" And deluxeRoom_txt.Text <> "" And superiorRoom_txt.Text <> "" And priceIndivi_txt.Text <> "" And depositIndivi_txt.Text <> "" And customerNameIndivi_txt.Text <> "" And customerICIndivi_txt.Text <> "" And phoneNOIndivi_txt.Text <> "" And durationIndivi_txt.Text <> "" Then
            If IsNumeric(customerNameIndivi_txt.Text) = True Then
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
            ElseIf IsNumeric(customerICIndivi_txt.Text) = False Then
                MsgBox("The I/C that you have entered is invalid.", MsgBoxStyle.Critical)
                customerICIndivi_txt.Clear()
                customerICIndivi_txt.Focus()
                Exit Sub
            ElseIf IsNumeric(depositIndivi_txt.Text) = False Then
                MsgBox("The deposot that you have entered is invalid.", MsgBoxStyle.Critical)
                depositIndivi_txt.Clear()
                depositIndivi_txt.Focus()
                Exit Sub
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
            End If
        ElseIf reservationIDIndivi_CB.Text = "" Or standardRoom_txt.Text = "" Or deluxeRoom_txt.Text = "" Or superiorRoom_txt.Text = "" Or priceIndivi_txt.Text = "" Or depositIndivi_txt.Text = "" Or customerNameIndivi_txt.Text = "" Or customerICIndivi_txt.Text = "" Or phoneNOIndivi_txt.Text = "" Or durationIndivi_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        con.Open()
        Sql2 = "UPDATE RoomReservation SET"
        Sql2 = Sql2 & "[Standard_Room] = '" & standardRoom_txt.Text & "',"
        Sql2 = Sql2 & "[Deluxe_Room] = '" & deluxeRoom_txt.Text & "',"
        Sql2 = Sql2 & "[Superior_Room] = '" & superiorRoom_txt.Text & "',"
        Sql2 = Sql2 & "[Booking_Price] = '" & priceIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Deposit] = '" & depositIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Customer_Name] = '" & customerNameIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[IC_Number] = '" & customerICIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Customer_Phone_Number] = '" & phoneNOIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Duration] = '" & durationIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Book_DatenTime] = '" & bookingDateIndivi_txt.Text & "',"
        Sql2 = Sql2 & "[Reservation_DatenTime] = '" & reservDateIndivi_dtp.Text & "' Where [Room_Reservation_ID] = " & "'" & reservationIDIndivi_CB.Text & "'"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql2, con)
            cmd.ExecuteNonQuery()
        End If

        reservationIDIndivi_CB.Text = ""
        reservationIDIndivi_CB.Items.Clear()
        standardRoom_txt.Text = 0
        deluxeRoom_txt.Text = 0
        superiorRoom_txt.Text = 0
        priceIndivi_txt.Clear()
        customerNameIndivi_txt.Clear()
        customerICIndivi_txt.Clear()
        phoneNOIndivi_txt.Clear()
        durationIndivi_txt.Clear()
        bookingDateIndivi_txt.Clear()
        reservDateIndivi_dtp.ResetText()
        con.Close()
        Call reserv()

        standardRoom_txt.Enabled = False
        deluxeRoom_txt.Enabled = False
        superiorRoom_txt.Enabled = False
        customerNameIndivi_txt.Enabled = False
        customerICIndivi_txt.Enabled = False
        phoneNOIndivi_txt.Enabled = False
        durationIndivi_txt.Enabled = False
        reservDateIndivi_dtp.Enabled = False
        clearIndivi_btn.Enabled = False

    End Sub

    Private Sub reservID_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reservID_CB.SelectedIndexChanged
        con.Open()
        ds2.Clear()
        typeFnS_CB.Enabled = True
        nameFnS_CB.Enabled = True
        roomNOFnS_CB.Enabled = True
        customerName_txt.Enabled = True


        Sql2 = "Select * from FnSReservation where FnS_Reservation_ID='" & reservID_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "FnSReservation")

        typeFnS_CB.Items.Add(ds2.Tables("FnSReservation").Rows(0).Item(1))
        typeFnS_CB.SelectedIndex = 0
        nameFnS_CB.Items.Add(ds2.Tables("FnSReservation").Rows(0).Item(2))
        nameFnS_CB.SelectedIndex = 0
        FnSID_txt.Text = ds2.Tables("FnSReservation").Rows(0).Item(3)
        roomNOFnS_CB.Text = ds2.Tables("FnSReservation").Rows(0).Item(4)
        customerName_txt.Text = ds2.Tables("FnSReservation").Rows(0).Item(5)
        chargesFeesFnS_txt.Text = ds2.Tables("FnSReservation").Rows(0).Item(6)
        con.Close()
    End Sub

    Private Sub typeFnS_CB_MouseDown(sender As Object, e As MouseEventArgs) Handles typeFnS_CB.MouseDown
        con.Open()
        ds3.Clear()
        typeFnS_CB.Items.Clear()
        FC = True

        ds4.Clear()
        Sql4 = "Select distinct FnS_Type from FacilitiesAndServices"
        da4 = New OleDbDataAdapter(Sql4, con)
        da4.Fill(ds4, "FnS_Type")

        totalRec2 = ds4.Tables("FnS_Type").Rows.Count - 1

        For n = 0 To totalRec2
            typeFnS_CB.Items.Add(ds4.Tables("FnS_Type").Rows(n).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub typeFnS_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeFnS_CB.SelectedIndexChanged
        con.Open()
        ds5.Clear()
        ds9.Clear()
        nameFnS_CB.Text = ""
        nameFnS_CB.Items.Clear()
        FnSID_txt.Clear()
        chargesFeesFnS_txt.Clear()

        If FC = False Then
            Sql5 = "Select * from FnSReservation where FnS_Reservation_ID='" & reservID_CB.Text & "'"
            da5 = New OleDbDataAdapter(Sql5, con)
            da5.Fill(ds5, "FnSR")

            typeFnS_CB.Text = ds5.Tables("FnSR").Rows(0).Item(1)
            nameFnS_CB.Text = ds5.Tables("FnSR").Rows(0).Item(2)
            FnSID_txt.Text = ds5.Tables("FnSR").Rows(0).Item(3)
            roomNOFnS_CB.Text = ds5.Tables("FnSR").Rows(0).Item(4)
            customerName_txt.Text = ds5.Tables("FnSR").Rows(0).Item(5)
            chargesFeesFnS_txt.Text = ds5.Tables("FnSR").Rows(0).Item(6)
            bookingDateFnS_txt.Text = ds5.Tables("FnSR").Rows(0).Item(7)
        Else
            Sql9 = "Select FnS_Name from FacilitiesAndServices where FnS_Type='" & typeFnS_CB.Text & "'"
            da9 = New OleDbDataAdapter(Sql9, con)
            da9.Fill(ds9, "FnSName")
            totalRec4 = ds9.Tables("FnSName").Rows.Count - 1

            For l = 0 To totalRec4
                nameFnS_CB.Items.Add(ds9.Tables("FnSName").Rows(l).Item(0))
            Next
        End If
        con.Close()
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

    Public Sub StandardRoom()
        con.Open()
        Sql6 = "Select Price from Room where Room_Type='Standard Room'"
        da6 = New OleDbDataAdapter(Sql6, con)
        da6.Fill(ds6, "StandardRoom")
        t = ds6.Tables("StandardRoom").Rows(0).Item(0)
        con.Close()
    End Sub
    Public Sub DeluxeRoom()
        con.Open()
        Sql7 = "Select Price from Room where Room_Type='Deluxe Room'"
        da7 = New OleDbDataAdapter(Sql7, con)
        da7.Fill(ds7, "DeluxeRoom")
        t1 = ds7.Tables("DeluxeRoom").Rows(0).Item(0)
        con.Close()
    End Sub
    Public Sub SuperiorRoom()
        con.Open()
        Sql8 = "Select Price from Room where Room_Type='Superior Room'"
        da8 = New OleDbDataAdapter(Sql8, con)
        da8.Fill(ds8, "SuperiorRoom")
        t2 = ds8.Tables("SuperiorRoom").Rows(0).Item(0)
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
        f = p * t
        priceIndivi_txt.Text = f + f1 + f2
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
        f1 = p1 * t1
        priceIndivi_txt.Text = f + f1 + f2
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
        f2 = p2 * t2
        priceIndivi_txt.Text = f + f1 + f2
    End Sub

    Private Sub clearIndivi_btn_Click(sender As Object, e As EventArgs) Handles clearIndivi_btn.Click
        standardRoom_txt.Text = 0
        deluxeRoom_txt.Text = 0
        superiorRoom_txt.Text = 0
        priceIndivi_txt.Clear()
        customerNameIndivi_txt.Clear()
        customerICIndivi_txt.Clear()
        phoneNOIndivi_txt.Clear()
        durationIndivi_txt.Clear()
        reservDateIndivi_dtp.ResetText()
    End Sub

    Private Sub nameFnS_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nameFnS_CB.SelectedIndexChanged
        con.Open()
        ds10.Clear()
        FnSID_txt.Clear()
        chargesFeesFnS_txt.Clear()

        Sql10 = "Select FnS_ID, Charged_per_person from FacilitiesAndServices where FnS_Name='" & nameFnS_CB.Text & "'"
        da10 = New OleDbDataAdapter(Sql10, con)
        da10.Fill(ds10, "FnSIDP")

        FnSID_txt.Text = ds10.Tables("FnSIDP").Rows(0).Item(0)
        chargesFeesFnS_txt.Text = ds10.Tables("FnSIDP").Rows(0).Item(1)
        con.Close()
    End Sub

    Private Sub updateFnS_btn_Click(sender As Object, e As EventArgs) Handles updateFnS_btn.Click
        If reservID_CB.Text <> "" And typeFnS_CB.Text <> "" And nameFnS_CB.Text <> "" And FnSID_txt.Text <> "" And roomNOFnS_CB.Text <> "" And customerName_txt.Text <> "" And chargesFeesFnS_txt.Text <> "" Then
            If IsNumeric(customerName_txt.Text) = True Then
                MsgBox("The name that you have entered is invalid.", MsgBoxStyle.Critical)
                customerName_txt.Clear()
                customerName_txt.Focus()
                Exit Sub
            End If
        ElseIf reservID_CB.Text = "" And typeFnS_CB.Text = "" And nameFnS_CB.Text = "" And FnSID_txt.Text = "" And roomNOFnS_CB.Text = "" And customerName_txt.Text = "" And chargesFeesFnS_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        con.Open()
        Sql12 = "UPDATE FnSReservation SET"
        Sql12 = Sql12 & "[FnS_Type] = '" & typeFnS_CB.Text & "',"
        Sql12 = Sql12 & "[FnS_Name] = '" & nameFnS_CB.Text & "',"
        Sql12 = Sql12 & "[FnS_ID] = '" & FnSID_txt.Text & "',"
        Sql12 = Sql12 & "[Room_ID] = '" & roomNOFnS_CB.Text & "',"
        Sql12 = Sql12 & "[Customer_Name] = '" & customerName_txt.Text & "',"
        Sql12 = Sql12 & "[Charges_fee] = '" & chargesFeesFnS_txt.Text & "',"
        Sql12 = Sql12 & "[Book_DatenTime] = '" & bookingDateFnS_txt.Text & "' Where [FnS_Reservation_ID] = " & "'" & reservID_CB.Text & "'"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql12, con)
            cmd.ExecuteNonQuery()
            MsgBox("Facilities or Services Reservation has been updated.")
        End If

        reservID_CB.Text = ""
        reservID_CB.Items.Clear()
        typeFnS_CB.Text = ""
        typeFnS_CB.Items.Clear()
        nameFnS_CB.Text = ""
        nameFnS_CB.Items.Clear()
        customerName_txt.Clear()
        chargesFeesFnS_txt.Clear()
        bookingDateFnS_txt.Clear()
        con.Close()
        Call FnS()

        typeFnS_CB.Enabled = False
        nameFnS_CB.Enabled = False
        roomNOFnS_CB.Enabled = False
        customerName_txt.Enabled = False

    End Sub

    Private Sub clearFnS_btn_Click(sender As Object, e As EventArgs) Handles clearFnS_btn.Click
        reservID_CB.Text = ""
        reservID_CB.Items.Clear()
        typeFnS_CB.Text = ""
        typeFnS_CB.Items.Clear()
        nameFnS_CB.Text = ""
        nameFnS_CB.Items.Clear()
        FnSID_txt.Clear()
        roomNOFnS_CB.Text = ""
        roomNOFnS_CB.Items.Clear()
        customerName_txt.Clear()
        chargesFeesFnS_txt.Clear()
        bookingDateFnS_txt.Clear()

        Call FnS()
        Call Room()
    End Sub

    Private Sub durationIndivi_txt_KeyUp(sender As Object, e As KeyEventArgs) Handles durationIndivi_txt.KeyUp
        If durationIndivi_txt.Text = "" Then
            durationIndivi_txt.Text = 0
        End If

        If IsNumeric(durationIndivi_txt.Text) = False Then
            durationIndivi_txt.Clear()
            durationIndivi_txt.Focus()
            MsgBox("You can only key in numeric.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        d = durationIndivi_txt.Text
        f = p * t * d
        f1 = p1 * t1 * d
        f2 = p2 * t2 * d
        priceIndivi_txt.Text = f + f1 + f2
    End Sub
End Class