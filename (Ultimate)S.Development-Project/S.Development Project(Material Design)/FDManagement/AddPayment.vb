Imports MaterialSkin
Imports System.Data.OleDb

Public Class AddPayment
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2, ds3, ds4, ds5, ds6 As New DataSet
    Dim TotP, CurP, TotR As Integer
    Dim stdr, delr, supr As Integer
    Private Sub AddPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrontDeskManagement.Enabled = True
    End Sub
    Private Sub AddPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Timer1.Start()

        con.Open()

        'auto generate payment id
        Dim Sql1 As String = "select * from Payment"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "payment")
        TotP = 0
        TotP = ds1.Tables("payment").Rows.Count - 1
        CurP = 100
        For i = 0 To TotP
            CurP = ds1.Tables("payment").Rows(i).Item(0)
            CurP = CurP + 1
        Next
        paymentID_txt.Text = CurP
    End Sub
    Public Sub newPayment()
        ds1.Clear()

        Dim Sql1 As String = "select * from Payment"
        Dim da1 As New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "payment")
        TotP = 0
        TotP = ds1.Tables("payment").Rows.Count - 1
        CurP = 100
        For i = 0 To TotP
            CurP = ds1.Tables("payment").Rows(i).Item(0)
            CurP = CurP + 1
        Next
        paymentID_txt.Text = CurP
    End Sub
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub addGroup_btn_Click(sender As Object, e As EventArgs) Handles addGroup_btn.Click
        Dim cmd As New OleDbCommand
        Dim y As String
        y = MsgBox("Payment Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            If checkin_RB.Checked = True Then 'add payment details into Payment table
                Dim Sql3 As String = "insert into Payment values ('"
                Sql3 = Sql3 & paymentID_txt.Text & "','"
                Sql3 = Sql3 & reservationidP_txt.Text & "','"
                Sql3 = Sql3 & CheckinidP_CB.Text & "','"
                Sql3 = Sql3 & rdt_txt.Text & "','"
                Sql3 = Sql3 & standardRoom_txt.Text & "','"
                Sql3 = Sql3 & deluxeRoom_txt.Text & "','"
                Sql3 = Sql3 & superiorRoom_txt.Text & "','"
                Sql3 = Sql3 & totalPrice_txt.Text & "','"
                Sql3 = Sql3 & customerName_txt.Text & "','"
                Sql3 = Sql3 & cPhoneNumber_txt.Text & "','"
                Sql3 = Sql3 & ICNumber_txt.Text & "','"
                Sql3 = Sql3 & deposit_txt.Text & "','"
                Sql3 = Sql3 & additionalpaymentP_txt.Text & "','"
                Sql3 = Sql3 & repaymentP_txt.Text & "','"
                Sql3 = Sql3 & totalamountP_txt.Text & "','Checked-In')"
                cmd = New OleDbCommand(Sql3, con)
                cmd.ExecuteNonQuery()

                Dim sql4 As String = "UPDATE CheckIn set PaymentStatus = 'Paid' where CheckIn_ID = '" & CheckinidP_CB.Text & "'"
                Dim cmd1 As New OleDbCommand
                cmd1 = New OleDbCommand(sql4, con)
                cmd1.ExecuteNonQuery()

                MsgBox("Payment is added.")
            End If

            If CheckOut_RB.Checked = True Then
                Dim Sql3 As String = "insert into Payment values ('"
                Sql3 = Sql3 & paymentID_txt.Text & "','"
                Sql3 = Sql3 & reservationidP_txt.Text & "','"
                Sql3 = Sql3 & CheckinidP_CB.Text & "','"
                Sql3 = Sql3 & rdt_txt.Text & "','"
                Sql3 = Sql3 & standardRoom_txt.Text & "','"
                Sql3 = Sql3 & deluxeRoom_txt.Text & "','"
                Sql3 = Sql3 & superiorRoom_txt.Text & "','"
                Sql3 = Sql3 & totalPrice_txt.Text & "','"
                Sql3 = Sql3 & customerName_txt.Text & "','"
                Sql3 = Sql3 & cPhoneNumber_txt.Text & "','"
                Sql3 = Sql3 & ICNumber_txt.Text & "','"
                Sql3 = Sql3 & deposit_txt.Text & "','"
                Sql3 = Sql3 & additionalpaymentP_txt.Text & "','"
                Sql3 = Sql3 & repaymentP_txt.Text & "','"
                Sql3 = Sql3 & totalamountP_txt.Text & "','Checked-Out')"
                cmd = New OleDbCommand(Sql3, con)
                cmd.ExecuteNonQuery()

                Dim sql4 As String = "UPDATE CheckIn set PaymentStatus = 'Repaid' where CheckIn_ID = '" & CheckinidP_CB.Text & "'"
                Dim cmd1 As New OleDbCommand
                cmd1 = New OleDbCommand(sql4, con)
                cmd1.ExecuteNonQuery()

                MsgBox("Payment is added.")
            End If
        End If
        paymentID_txt.Clear()
        CheckinidP_CB.Text = ""
        CheckinidP_CB.Items.Clear()
        rdt_txt.Clear()
        standardRoom_txt.Clear()
        deluxeRoom_txt.Clear()
        superiorRoom_txt.Clear()
        totalPrice_txt.Clear()
        customerName_txt.Clear()
        cPhoneNumber_txt.Clear()
        ICNumber_txt.Clear()
        reservationidP_txt.Clear()
        additionalpaymentP_txt.Clear()
        repaymentP_txt.Clear()

        checkin_RB.Checked = False
        CheckOut_RB.Checked = False
        Call newPayment()
    End Sub
    Private Sub CheckinidP_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckinidP_CB.SelectedIndexChanged
        ds2.Clear()
        ds3.Clear()
        'auto display the information based on the checkin id thats elected by the user
        Dim Sql2 As String = "Select * from CheckIn where CheckIn_ID='" & CheckinidP_CB.Text & "'"
        Dim da2 As New OleDbDataAdapter
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "RoomReservation")

        reservationidP_txt.Text = (ds2.Tables("RoomReservation").Rows(0).Item(1)).ToString
        rdt_txt.Text = (ds2.Tables("RoomReservation").Rows(0).Item(13)).ToString
        standardRoom_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(2)
        deluxeRoom_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(3)
        superiorRoom_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(4)
        totalPrice_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(5)
        customerName_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(7)
        cPhoneNumber_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(9)
        ICNumber_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(8)
        deposit_txt.Text = ds2.Tables("RoomReservation").Rows(0).Item(6)

        

        If checkin_RB.Checked = True Then
            totalamountP_txt.Text = totalPrice_txt.Text
        End If

        If CheckOut_RB.Checked = True Then
            Dim Sql3 As String = "Select * from CheckOut"
            Dim da3 As New OleDbDataAdapter
            da3 = New OleDbDataAdapter(Sql3, con)
            da3.Fill(ds3, "RoomReservation")
            TotR = ds3.Tables("RoomReservation").Rows.Count - 1
            For i = 0 To TotR
                If ds3.Tables("RoomReservation").Rows(i).Item(1) = CheckinidP_CB.Text Then
                    additionalpaymentP_txt.Text = ds3.Tables("RoomReservation").Rows(i).Item(6)
                    repaymentP_txt.Text = ds3.Tables("RoomReservation").Rows(i).Item(7)
                End If
            Next
            
            totalamountP_txt.Text = Val(totalPrice_txt.Text) + Val(additionalpaymentP_txt.Text)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles checkin_RB.CheckedChanged
        ds2.Clear()
        CheckinidP_CB.Text = "" 'all the textboxs will clear automatically when the users check the radio button
        rdt_txt.Clear()
        standardRoom_txt.Clear()
        deluxeRoom_txt.Clear()
        superiorRoom_txt.Clear()
        totalPrice_txt.Clear()
        customerName_txt.Clear()
        cPhoneNumber_txt.Clear()
        ICNumber_txt.Clear()
        reservationidP_txt.Clear()
        additionalpaymentP_txt.Clear()
        repaymentP_txt.Clear()
        CheckinidP_CB.Items.Clear()
        additionalpayment_lbl.Visible = False
        additionalpaymentP_txt.Visible = False
        repaymentP_txt.Visible = False
        repaymentP_lbl.Visible = False

        Dim sql As String = "select * from CheckIn"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds2, "ciid")
        TotR = ds2.Tables("ciid").Rows.Count - 1
        For i = 0 To TotR
            If (ds2.Tables("ciid").Rows(i).Item(15)).ToString = "Checked-In" And (ds2.Tables("ciid").Rows(i).Item(16)).ToString = "Not Pay" Then
                CheckinidP_CB.Items.Add(ds2.Tables("ciid").Rows(i).Item(0))
            End If
        Next
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckOut_RB.CheckedChanged
        ds2.Clear() 'all the textboxs will clear automatically when the users check the radio button
        CheckinidP_CB.Items.Clear()
        CheckinidP_CB.Text = ""
        rdt_txt.Clear()
        standardRoom_txt.Clear()
        deluxeRoom_txt.Clear()
        superiorRoom_txt.Clear()
        totalPrice_txt.Clear()
        customerName_txt.Clear()
        cPhoneNumber_txt.Clear()
        ICNumber_txt.Clear()
        reservationidP_txt.Clear()
        additionalpaymentP_txt.Clear()
        repaymentP_txt.Clear()
        additionalpayment_lbl.Visible = True
        additionalpaymentP_txt.Visible = True
        repaymentP_txt.Visible = True
        repaymentP_lbl.Visible = True

        Dim sql As String = "select * from CheckIn"
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds2, "ciid")
        TotR = ds2.Tables("ciid").Rows.Count - 1
        For i = 0 To TotR
            If (ds2.Tables("ciid").Rows(i).Item(15)).ToString = "Checked-Out" Then
                CheckinidP_CB.Items.Add(ds2.Tables("ciid").Rows(i).Item(0))
            End If
        Next
    End Sub
End Class