Imports MaterialSkin
Imports System.Data.OleDb

Public Class RFMUpdateDataEntry
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2, da3 As New OleDbDataAdapter
    Dim ds, ds1, ds2, ds3 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2, Sql3, Sql4, Sql5 As String  ''Added Sql2
    Dim totalRec, totalRec1 As String

    Private Sub RFMUpdateDataEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RFManagement.Enabled = True
    End Sub

    Public Sub room()
        'add room id into room id combo box
        con.Open()
        ds.Clear()
        Dim i As Integer
        Sql = "Select Room_ID from Room"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomType")
        totalRec = ds.Tables("RoomType").Rows.Count - 1
        RoomID_cbbox.Items.Clear()
        For i = 0 To totalRec

            RoomID_cbbox.Items.Add(ds.Tables("RoomType").Rows(i).Item(0))

        Next
        con.Close()
    End Sub

    Public Sub FnS()
        'add facility and services id into combo box
        con.Open()
        ds1.Clear()
        Dim u As Integer
        Sql1 = "Select FnS_ID from FacilitiesAndServices"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "FnSType")
        totalRec1 = ds1.Tables("FnSType").Rows.Count - 1
        FnSID_cbbox.Items.Clear()
        For u = 0 To totalRec1

            FnSID_cbbox.Items.Add(ds1.Tables("FnSType").Rows(u).Item(0))

        Next
        con.Close()
    End Sub
    Private Sub RFMUpdateDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)


        Call room()
        Call FnS()

    End Sub

    Private Sub updateR_btn_Click(sender As Object, e As EventArgs) Handles updateR_btn.Click

        'Sql query for updating record from database
        If IsNumeric(price_txt.Text) = False Then
            MsgBox("The price that you key in is invalid.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If RoomID_cbbox.Text = "" Or roomtype_CB.Text = "" Or price_txt.Text = "" Or status_CB.Text = "" Then
            MsgBox("Please select a Room's info to be updated..")
            Exit Sub
        End If

        con.Open()
        Sql2 = "UPDATE Room SET"
        Sql2 = Sql2 & "[Room_Type] = '" & roomtype_CB.Text & "',"
        Sql2 = Sql2 & "[Price] = '" & price_txt.Text & "',"
        Sql2 = Sql2 & "[Status] = '" & status_CB.Text & "' Where [Room_ID] = " & "'" & RoomID_cbbox.Text & "'"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql2, con)
            cmd.ExecuteNonQuery()
            MsgBox("Room has been updated!")
        End If
        roomtype_CB.Enabled = False
        price_txt.Enabled = False
        status_CB.Enabled = False
        RoomID_cbbox.Text = ""
        RoomID_cbbox.Items.Clear()
        roomtype_CB.Text = ""
        price_txt.Clear()
        status_CB.Text = ""
        con.Close()
        Call room()
    End Sub

    Private Sub updateFnS_btn_Click(sender As Object, e As EventArgs) Handles updateFnS_btn.Click
        'users are not allow to update the facility and services if there is any blank textbox
        If IsNumeric(FnSName_txt.Text) = True Then
            MsgBox("The name that you key in is invalid.", MsgBoxStyle.Critical)
            FnSName_txt.Clear()
            FnSName_txt.Focus()
            Exit Sub

        ElseIf IsNumeric(chargesFees_txt.Text) = False Then
            MsgBox("The fees that you key in is invalid.", MsgBoxStyle.Critical)
            chargesFees_txt.Clear()
            chargesFees_txt.Focus()
            Exit Sub
        End If

        If FnSID_cbbox.Text = "" Or FnSType_CB.Text = "" Or FnSName_txt.Text = "" Or chargesFees_txt.Text = "" Then
            MsgBox("Please select a Room's info to be updated..")
            Exit Sub
        End If
        con.Open()
        Sql3 = "UPDATE FacilitiesAndServices SET"
        Sql3 = Sql3 & "[FnS_Type] = '" & FnSType_CB.Text & "',"
        Sql3 = Sql3 & "[FnS_Name] = '" & FnSName_txt.Text & "',"
        Sql3 = Sql3 & "[Charged_per_person] = '" & chargesFees_txt.Text & "' Where [FnS_ID] = " & "'" & FnSID_cbbox.Text & "'"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql3, con)
            cmd.ExecuteNonQuery()
            MsgBox("Facilities or services has been updated.")
        End If

        FnSType_CB.Enabled = False
        FnSName_txt.Enabled = False
        chargesFees_txt.Enabled = False
        FnSID_cbbox.Text = ""
        FnSID_cbbox.Items.Clear()
        FnSType_CB.Text = ""
        FnSName_txt.Clear()
        chargesFees_txt.Clear()
        con.Close()
    End Sub

    Private Sub FnSID_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FnSID_cbbox.SelectedIndexChanged
        FnSType_CB.Enabled = True
        FnSName_txt.Enabled = True
        chargesFees_txt.Enabled = True

        'retrieve facility and services details from database based on the facility and services id
        con.Open()
        ds2.Clear()
        Sql4 = "Select FnS_Type, FnS_Name, Charged_per_person From FacilitiesAndServices where FnS_ID='" & FnSID_cbbox.Text & "'"
        da2 = New OleDbDataAdapter(Sql4, con)
        da2.Fill(ds2, "FnSID")
        FnSType_CB.Text = ds2.Tables("FnSID").Rows(0).Item(0)
        FnSName_txt.Text = ds2.Tables("FnSID").Rows(0).Item(1)
        chargesFees_txt.Text = ds2.Tables("FnSID").Rows(0).Item(2)
        con.Close()
    End Sub

    Private Sub RoomID_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomID_cbbox.SelectedIndexChanged
        roomtype_CB.Enabled = True
        price_txt.Enabled = True
        status_CB.Enabled = True
        'retrieve room details from database based on the room id
        con.Open()
        ds3.Clear()
        Sql5 = "Select Room_Type, Price, Status From Room where Room_ID='" & RoomID_cbbox.Text & "'"
        da3 = New OleDbDataAdapter(Sql5, con)
        da3.Fill(ds3, "RoomID")
        roomtype_CB.Text = ds3.Tables("RoomID").Rows(0).Item(0)
        price_txt.Text = ds3.Tables("RoomID").Rows(0).Item(1)
        status_CB.Text = ds3.Tables("RoomID").Rows(0).Item(2)
        con.Close()

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub clearFnS_btn_Click(sender As Object, e As EventArgs) Handles clearFnS_btn.Click
        FnSType_CB.Text = ""
        FnSName_txt.Clear()
        chargesFees_txt.Clear()
    End Sub

    Private Sub clearR_btn_Click(sender As Object, e As EventArgs) Handles clearR_btn.Click
        roomtype_CB.Text = ""
        price_txt.Clear()
        status_CB.Text = ""
    End Sub
End Class