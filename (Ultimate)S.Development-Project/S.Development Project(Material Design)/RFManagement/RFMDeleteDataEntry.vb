Imports MaterialSkin
Imports System.Data.OleDb

Public Class RFMDeleteDataEntry
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2 As String  ''Added Sql2
    Dim totalRec As String

    Private Sub RFMDeleteDataEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RFManagement.Enabled = True
    End Sub

    Private Sub RFMDeleteDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()

        Dim i As Integer
        Sql = "Select Room_ID from Room"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "RoomType")
        totalRec = ds.Tables("RoomType").Rows.Count - 1
        RoomID_cbbox.Items.Clear()
        For i = 0 To totalRec
            RoomID_cbbox.Items.Add(ds.Tables("RoomType").Rows(i).Item(0))
        Next

        ''Added u as integer
        Dim u As Integer
        Sql2 = "Select FnS_ID from FacilitiesAndServices"
        da = New OleDbDataAdapter(Sql2, con)
        da.Fill(ds, "FnSType")
        totalRec = ds.Tables("FnSType").Rows.Count - 1
        FnSID_cbbox.Items.Clear()
        For u = 0 To totalRec
            FnSID_cbbox.Items.Add(ds.Tables("FnSType").Rows(u).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub updateR_btn_Click(sender As Object, e As EventArgs) Handles updateR_btn.Click
        con.Open()
        Sql = "Delete * from Room where Room_ID='" & RoomID_cbbox.Text & "'"
        cmd = New OleDbCommand(Sql, con)
        ' Sql query for updating record from database
        Dim y As String
        y = MsgBox("Delete confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("The room has been deleted.")
        End If

        RoomID_cbbox.Items.Clear()
        roomtype_txt.Clear()
        price_txt.Clear()
        status_txt.Clear()
        con.Close()
    End Sub

    Private Sub updateFnS_btn_Click(sender As Object, e As EventArgs) Handles updateFnS_btn.Click
        con.Open()
        Sql = "Delete * from FacilitiesAndServices where FnS_ID='" & FnSID_cbbox.Text & "'"
        cmd = New OleDbCommand(Sql, con)
        ' Sql query for updating record from database
        Dim y As String
        y = MsgBox("Delete confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("The room has been deleted.")
        End If

        FnSID_cbbox.Items.Clear()
        FnSType_txt.Clear()
        FnSName_txt.Clear()
        chargesFees_txt.Clear()
        con.Close()
    End Sub

    Private Sub FnSID_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FnSID_cbbox.SelectedIndexChanged
        con.Open()
        Sql1 = "Select FnS_Type, FnS_Name, Charged_per_person From FacilitiesAndServices where FnS_ID='" & FnSID_cbbox.Text & "'"
        da = New OleDbDataAdapter(Sql1, con)
        da.Fill(ds, "FnSID")
        FnSType_txt.Text = ds.Tables("FnSID").Rows(0).Item(0)
        FnSName_txt.Text = ds.Tables("FnSID").Rows(0).Item(1)
        chargesFees_txt.Text = ds.Tables("FnSID").Rows(0).Item(2)
        ds.Clear()
        con.Close()
    End Sub

    Private Sub RoomID_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomID_cbbox.SelectedIndexChanged
        con.Open()
        Sql1 = "Select Room_Type, Price, Status From Room where Room_ID='" & RoomID_cbbox.Text & "'"
        da = New OleDbDataAdapter(Sql1, con)
        da.Fill(ds, "RoomID")
        roomtype_txt.Text = ds.Tables("RoomID").Rows(0).Item(0)
        price_txt.Text = ds.Tables("RoomID").Rows(0).Item(1)
        status_txt.Text = ds.Tables("RoomID").Rows(0).Item(2)
        ds.Clear()
        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class