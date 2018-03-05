Imports System.Data.OleDb
Imports MaterialSkin

Public Class DeleteReservation
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim ds, ds1, ds2 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec, totalRec1 As Integer
    Dim Sql, Sql1, Sql2 As String

    Public Sub roomReserv()
        con.Open()
        ds.Clear()
        Sql = "Select Room_Reservation_ID from RoomReservation"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomReservationID")
        totalRec = ds.Tables("RoomReservationID").Rows.Count - 1

        For i = 0 To totalRec
            roomReservID_CB.Items.Add(ds.Tables("RoomReservationID").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Public Sub FnSReserv()
        con.Open()
        ds1.Clear()
        Sql1 = "Select FnS_Reservation_ID from FnSReservation"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "FnSReservationID")
        totalRec1 = ds1.Tables("FnSReservationID").Rows.Count - 1

        For j = 0 To totalRec1
            FnSReservID_CB.Items.Add(ds1.Tables("FnSReservationID").Rows(j).Item(0))
        Next
        con.Close()
    End Sub
    Private Sub DeleteReservation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Reservations_Management.Enabled = True
    End Sub
    Private Sub DeleteReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

    End Sub

    Private Sub RR_R_CheckedChanged(sender As Object, e As EventArgs) Handles RR_R.CheckedChanged
        Call roomReserv()
        roomReservID_CB.Enabled = True
        FnSReservID_CB.Enabled = False
        FnSReservID_CB.Text = ""
        FnSReservID_CB.Items.Clear()
    End Sub

    Private Sub FnS_R_CheckedChanged(sender As Object, e As EventArgs) Handles FnS_R.CheckedChanged
        Call FnSReserv()
        roomReservID_CB.Enabled = False
        roomReservID_CB.Text = ""
        roomReservID_CB.Items.Clear()
        FnSReservID_CB.Enabled = True
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        'delete reservation record from database based on reservation id 
        con.Open()
        If RR_R.Checked = True Then
            Sql2 = "Delete * from RoomReservation where "
            Sql2 = Sql2 & "Room_Reservation_ID= '" & roomReservID_CB.Text & "'"
            cmd = New OleDbCommand(Sql2, con)
            Dim y As String
            y = MsgBox("Delete Confirmation", MsgBoxStyle.YesNo)
            If y = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Room reservation has been deleted.")
                roomReservID_CB.Text = ""
                roomReservID_CB.Items.Clear()
                Call roomReserv()
            End If
        End If

        If FnS_R.Checked = True Then
            Sql2 = "Delete * from FnSReservation where "
            Sql2 = Sql2 & "FnS_Reservation_ID= '" & FnSReservID_CB.Text & "'"
            cmd = New OleDbCommand(Sql2, con)
            Dim y As String
            y = MsgBox("Delete Confirmation", MsgBoxStyle.YesNo)
            If y = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Room reservation has been deleted.")
                FnSReservID_CB.Text = ""
                FnSReservID_CB.Items.Clear()
                Call FnSReserv()
            End If
        End If
        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class