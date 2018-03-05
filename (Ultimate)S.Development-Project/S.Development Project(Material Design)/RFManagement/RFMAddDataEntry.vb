Imports System.Data.OleDb
Imports MaterialSkin

Public Class RFMAddDataEntry
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim ds, ds1, ds2 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2, Sql3 As String
    Dim totalRec, totalRec1 As Integer

    Private Sub RFMAddDataEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RFManagement.Enabled = True
    End Sub
    Private Sub RFMAddDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Call newFnS()

    End Sub
    Public Sub newFnS()
        con.Open()
        ds.Clear()
        Sql = "Select FnS_ID from FacilitiesAndServices"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "FnS_ID")
        totalRec = ds.Tables("FnS_ID").Rows.Count

        Dim newFnSID As Integer = 100
        Dim j As Integer

        For j = 0 To totalRec - 1
            If newFnSID = ds.Tables("FnS_ID").Rows(j).Item(0) Then
                newFnSID += 1
            Else
                Exit For
            End If
        Next
        FnSID_txt.Text = newFnSID
        con.Close()
    End Sub
    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub addR_btn_Click(sender As Object, e As EventArgs) Handles addR_btn.Click
        con.Open()
        Sql1 = "Select Room_ID from Room"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "SearchRoomID")
        totalRec = ds1.Tables("SearchRoomID").Rows.Count
    
        For i = 0 To totalRec - 1
            If roomID_txt.Text = ds1.Tables("SearchRoomID").Rows(i).Item(0) Then
                MsgBox("The room is exsiting, try another one.", MsgBoxStyle.Critical)
                roomID_txt.Clear()
                roomID_txt.Focus()
                Exit Sub
            End If
        Next

        If roomID_txt.Text = "" Or roomType_CB.Text = "" Or price_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Sql = "insert into Room values ('"
        Sql = Sql & roomID_txt.Text & "','"
        Sql = Sql & roomType_CB.Text & "','"
        Sql = Sql & price_txt.Text & "','"
        Sql = Sql & "Available')"
        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("New room is added!")

        roomID_txt.Clear()
        roomType_CB.Text = ""
        price_txt.Clear()
        con.Close()
    End Sub

    Private Sub addFnS_btn_Click(sender As Object, e As EventArgs) Handles addFnS_btn.Click
        con.Open()
        Sql3 = "Select FnS_ID from FacilitiesAndServices"
        da2 = New OleDbDataAdapter(Sql3, con)
        da2.Fill(ds2, "SearchFnSID")
        totalRec1 = ds2.Tables("SearchFnSID").Rows.Count

        For i = 0 To totalRec1 - 1
            If FnSID_txt.Text = ds2.Tables("SearchFnSID").Rows(i).Item(0) Then
                MsgBox("The facilities or services is exsiting, try another one.", MsgBoxStyle.Critical)
                FnSID_txt.Clear()
                FnSID_txt.Focus()
                Exit Sub
            End If
        Next

        If FnSID_txt.Text = "" Or FnSType_CB.Text = "" Or FnSName_txt.Text = "" Or chargesFees_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Sql2 = "insert into FacilitiesAndServices values ('"
        Sql2 = Sql2 & FnSID_txt.Text & "','"
        Sql2 = Sql2 & FnSType_CB.Text & "','"
        Sql2 = Sql2 & FnSName_txt.Text & "','"
        Sql2 = Sql2 & chargesFees_txt.Text & "')"
        cmd = New OleDbCommand(Sql2, con)
        cmd.ExecuteNonQuery()
        MsgBox("New facilities or Services is added!")

        FnSID_txt.Clear()
        FnSType_CB.Text = ""
        FnSName_txt.Clear()
        chargesFees_txt.Clear()
        con.Close()
    End Sub


    Private Sub clearFnS_btn_Click(sender As Object, e As EventArgs) Handles clearFnS_btn.Click
        FnSID_txt.Clear()
        FnSType_CB.Text = ""
        FnSName_txt.Clear()
        chargesFees_txt.Clear()
    End Sub

    Private Sub clearR_btn_Click(sender As Object, e As EventArgs) Handles clearR_btn.Click
        roomID_txt.Clear()
        roomType_CB.Text = ""
        price_txt.Clear()
    End Sub
End Class