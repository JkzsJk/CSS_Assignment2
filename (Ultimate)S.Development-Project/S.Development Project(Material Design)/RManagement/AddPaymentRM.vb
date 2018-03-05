Imports MaterialSkin
Imports System.Data.OleDb

Public Class AddPaymentRM
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3, da4, da5, da6, da7 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec, totalRec1, totalRec2, totalRec3, totalRec4 As Integer
    Dim Sql, Sql1, Sql2, Sql3, Sql4, Sql5, Sql6, Sql7 As String
    Dim a, b, c As Integer
    Dim p, p1, p2, t, t1, t2, f, f1, f2 As Integer

    Public Sub newPayment()
        con.Open()
        ds.Clear()
        Sql = "Select FnS_Payment_ID from FnSPayment"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "FnS_Payment_ID")
        totalRec = ds.Tables("FnS_Payment_ID").Rows.Count

        Dim newPaymemtID As Integer = 100
        Dim j As Integer

        For j = 0 To totalRec - 1
            If newPaymemtID = ds.Tables("FnS_Payment_ID").Rows(j).Item(0) Then
                newPaymemtID += 1
            Else
                Exit For
            End If
        Next
        paymentFnSID_txt.Text = newPaymemtID
        con.Close()
    End Sub

    Public Sub FnSR_ID()
        con.Open()
        Sql1 = "Select FnS_Reservation_ID from FnSReservation where Status='Unpay'"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "FnS_ID")
        totalRec1 = ds1.Tables("FnS_ID").Rows.Count - 1
        FnSID_CB.Items.Clear()
        For i = 0 To totalRec1
            FnSID_CB.Items.Add(ds1.Tables("FnS_ID").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub AddPaymentRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Reservations_Management.Enabled = True
    End Sub
    Private Sub AddPaymentRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)


        Call newPayment()
        Call FnSR_ID()

    End Sub

    Private Sub FnSID_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FnSID_CB.SelectedIndexChanged
        con.Open()
        ds2.Clear()
        Sql2 = "Select * from FnSReservation where FnS_Reservation_ID='" & FnSID_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "FnS")

        type_txt.Text = ds2.Tables("FnS").Rows(0).Item(1)
        nameFnS_txt.Text = ds2.Tables("FnS").Rows(0).Item(2)
        roomIDFnS_txt.Text = ds2.Tables("FnS").Rows(0).Item(4)
        customerNameFnS_txt.Text = ds2.Tables("FnS").Rows(0).Item(5)
        chargesFee_txt.Text = ds2.Tables("FnS").Rows(0).Item(6)
        bookDatenTime_txt.Text = ds2.Tables("FnS").Rows(0).Item(7)
        con.Close()
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        con.Open()
        Sql3 = "insert into FnSPayment values ('"
        Sql3 = Sql3 & paymentFnSID_txt.Text & "','"
        Sql3 = Sql3 & FnSID_CB.Text & "','"
        Sql3 = Sql3 & type_txt.Text & "','"
        Sql3 = Sql3 & nameFnS_txt.Text & "','"
        Sql3 = Sql3 & roomIDFnS_txt.Text & "','"
        Sql3 = Sql3 & customerNameFnS_txt.Text & "','"
        Sql3 = Sql3 & chargesFee_txt.Text & "','"
        Sql3 = Sql3 & bookDatenTime_txt.Text & "')"

        Dim y As String
        y = MsgBox("Payment Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql3, con)
            cmd.ExecuteNonQuery()
            MsgBox("Payment is added.")
            
            Sql4 = "UPDATE FnSReservation SET"
            Sql4 = Sql4 & "[Status] = 'Paid' Where [FnS_Reservation_ID] = '" & FnSID_CB.Text & "'"
            cmd = New OleDbCommand(Sql4, con)
            cmd.ExecuteNonQuery()
            paymentFnSID_txt.Clear()

            FnSID_CB.Text = ""
            FnSID_CB.Items.Clear()
            type_txt.Clear()
            nameFnS_txt.Clear()
            roomIDFnS_txt.Clear()
            customerNameFnS_txt.Clear()
            chargesFee_txt.Clear()
            bookDatenTime_txt.Clear()
            Call newPayment()
        End If
        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class