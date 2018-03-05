Imports MaterialSkin
Imports System.Data.OleDb
Public Class DeleteRecord
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9 As New DataSet
    Dim TotCI As Integer
    Dim roomid, checkinid As String
    Private Sub DeleteRecord_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrontDeskManagement.Enabled = True
    End Sub
    Private Sub DeleteRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()
    End Sub
    Private Sub recordtype_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles recordtype_CB.SelectedIndexChanged
        RecordID_CB.Items.Clear()
        'id will display in the id combo box based on the type of record that chosen by user
        If recordtype_CB.Text = "Check-In" Then
            CI_lbl.Visible = True
            CO_lbl.Visible = False
            recordstatus_txt.Visible = True
            recordstatus_txt.Enabled = False
            roomTypeGroupW_lbl.Visible = True
            Dim sql As String = "select * from CheckIn"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds1, "checkin")
            TotCI = ds1.Tables("checkin").Rows.Count - 1
            For i = 0 To TotCI
                RecordID_CB.Items.Add(ds1.Tables("checkin").Rows(i).Item(0))
            Next
        End If

        If recordtype_CB.Text = "Check-Out" Then
            CI_lbl.Visible = False
            CO_lbl.Visible = True
            recordstatus_txt.Visible = False
            roomTypeGroupW_lbl.Visible = False

            Dim sql As String = "select * from CheckOut"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds2, "checkout")
            TotCI = ds2.Tables("checkout").Rows.Count - 1
            For i = 0 To TotCI
                RecordID_CB.Items.Add(ds2.Tables("checkout").Rows(i).Item(0))
            Next
        End If

        ds1.Clear()
        ds2.Clear()
    End Sub
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
    Private Sub RecordID_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RecordID_CB.SelectedIndexChanged

        If recordtype_CB.Text = "Check-In" Then

            Dim sql As String = "select * from CheckIn where CheckIn_ID = '" & RecordID_CB.Text & "'"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds3, "checkinid")
            recordstatus_txt.Text = ds3.Tables("checkinid").Rows(0).Item(15)
        End If
        ds3.Clear()
    End Sub
    Private Sub deleteRecord_btn_Click(sender As Object, e As EventArgs) Handles deleteRecord_btn.Click
        'delete checkin record
        If recordtype_CB.Text = "Check-In" Then
            Dim cmd1 As New OleDbCommand
            Dim cmd As New OleDbCommand
            Dim cmd2 As New OleDbCommand

            Dim sql As String
            Dim choice As String = MsgBox("confirm delete?", vbYesNo)
            If choice = vbYes Then

                Dim sql2 As String = "select * from CheckInRoom"
                Dim da As New OleDbDataAdapter(sql2, con)
                da.Fill(ds4, "checkinr")
                TotCI = ds4.Tables("checkinr").Rows.Count - 1
                For i = 0 To TotCI
                    If ds4.Tables("checkinr").Rows(i).Item(0) = RecordID_CB.Text Then

                        roomid = ds4.Tables("checkinr").Rows(i).Item(2)
                        Dim sql5 As String = "UPDATE Room set Status = 'Available' where Room_ID = '" & roomid & "'"
                        cmd2 = New OleDbCommand(sql5, con)
                        cmd2.ExecuteNonQuery()

                    End If
                    If ds4.Tables("checkinr").Rows(i).Item(0) = RecordID_CB.Text Then
                        Dim sql3 As String = "delete * from CheckInRoom where CheckIn_ID = '" & RecordID_CB.Text & "'"
                        cmd1 = New OleDbCommand(sql3, con)
                        cmd1.ExecuteNonQuery()
                    End If
                Next

                Dim sql6 As String = "select * from CheckIn"
                Dim da1 As New OleDbDataAdapter(sql6, con)
                da1.Fill(ds6, "checkinr")
                TotCI = ds6.Tables("checkinr").Rows.Count - 1
                For i = 0 To TotCI
                    If ds6.Tables("checkinr").Rows(i).Item(0) = RecordID_CB.Text And (ds6.Tables("checkinr").Rows(i).Item(1)).ToString <> "" Then
                        Dim sql7 As String = "UPDATE RoomReservation set Status = 'Reserved' where Room_Reservation_ID = '" & ds6.Tables("checkinr").Rows(i).Item(1) & "'"
                        Dim cmd3 As New OleDbCommand
                        cmd3 = New OleDbCommand(sql7, con)
                        cmd3.ExecuteNonQuery()
                    End If

                Next

                sql = "delete * from CheckIn where CheckIn_ID = '" & RecordID_CB.Text & "'"
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()

            End If



        End If
        'delete checkout record
        If recordtype_CB.Text = "Check-Out" Then
            Dim cmd1 As New OleDbCommand
            Dim cmd As New OleDbCommand
            Dim cmd4 As New OleDbCommand
            Dim sql As String
            Dim choice As String = MsgBox("confirm delete?", vbYesNo)
            If choice = vbYes Then

                Dim sql2 As String = "select * from CheckOutRoom"
                Dim da As New OleDbDataAdapter(sql2, con)
                da.Fill(ds5, "checkout")
                TotCI = ds5.Tables("checkout").Rows.Count - 1
                For i = 0 To TotCI

                    If ds5.Tables("checkout").Rows(i).Item(0) = RecordID_CB.Text Then


                        Dim sql5 As String = "UPDATE Room set Status = 'Unavailable' where Room_ID = '" & ds5.Tables("checkout").Rows(i).Item(1) & "'"
                        cmd4 = New OleDbCommand(sql5, con)
                        cmd4.ExecuteNonQuery()

                    End If


                    If ds5.Tables("checkout").Rows(i).Item(0) = RecordID_CB.Text Then

                        Dim sql3 As String = "delete * from CheckOutRoom where CheckOut_ID = '" & RecordID_CB.Text & "'"
                        cmd1 = New OleDbCommand(sql3, con)
                        cmd1.ExecuteNonQuery()
                    End If
                Next

                Dim sql8 As String = "select * from CheckOut"
                Dim da1 As New OleDbDataAdapter(sql8, con)
                da1.Fill(ds7, "checkinr")
                TotCI = ds7.Tables("checkinr").Rows.Count - 1
                For i = 0 To TotCI

                    If ds7.Tables("checkinr").Rows(i).Item(0) = RecordID_CB.Text Then
                        checkinid = (ds7.Tables("checkinr").Rows(i).Item(1)).ToString

                        Dim sql0 As String = "UPDATE CheckIn set Status = 'Checked-In' where CheckIn_ID = '" & ds7.Tables("checkinr").Rows(i).Item(1) & "'"
                        Dim cmd5 As New OleDbCommand
                        cmd5 = New OleDbCommand(sql0, con)
                        cmd5.ExecuteNonQuery()
                    End If

                    Dim sql6 As String = "select * from CheckIn"
                    Dim da4 As New OleDbDataAdapter(sql6, con)
                    da4.Fill(ds6, "checkinr")
                    TotCI = ds6.Tables("checkinr").Rows.Count - 1
                    For q = 0 To TotCI
                        If ds6.Tables("checkinr").Rows(q).Item(0) = checkinid And (ds6.Tables("checkinr").Rows(q).Item(1)).ToString <> "" Then
                            Dim sql9 As String = "UPDATE RoomReservation set Status = 'Checked-In' where Room_Reservation_ID = '" & ds6.Tables("checkinr").Rows(q).Item(1) & "'"
                            Dim cmd0 As New OleDbCommand
                            cmd0 = New OleDbCommand(sql9, con)
                            cmd0.ExecuteNonQuery()
                        End If
                    Next


                Next

                sql = "delete * from CheckOut where CheckOut_ID = '" & RecordID_CB.Text & "'"
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
            End If
        End If

        MsgBox("Record is deleted successfully.")

        ds4.Clear()
        ds5.Clear()
        ds7.Clear()
        ds6.Clear()

        Me.Hide()
        FrontDeskManagement.Show()
    End Sub
End Class