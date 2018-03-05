Imports System.Data.OleDb
Imports MaterialSkin

Public Class AdminDelete
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1 As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1 As String
    Dim totalRec, totalRec1 As Integer

    Public Sub ID()
        ds.Clear()
        Sql = "Select Username from Credentials"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "usernameID")
        totalRec = ds.Tables("usernameID").Rows.Count
        usernameID_CB.Items.Clear()
        For i = 0 To totalRec - 1
            usernameID_CB.Items.Add(ds.Tables("usernameID").Rows(i).Item(0))
        Next
    End Sub

    Private Sub AdminDelete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MenuForAdmin.Enabled = True
    End Sub


    Private Sub AdminDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
        con.Open()
        Call ID()
        con.Close()

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        con.Open()
        Sql1 = "Delete * from Credentials where "
        Sql1 = Sql1 & "Username= '" & usernameID_CB.Text & "'"
        cmd = New OleDbCommand(Sql1, con)
        Dim y As String
        y = MsgBox("Delete Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Room reservation has been deleted.")
            usernameID_CB.Text = ""
            usernameID_CB.Items.Clear()
            Call ID()
        End If

        ds1.Clear()
        Sql1 = "Select * from Credentials"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "Account")
        totalRec1 = ds1.Tables("Account").Rows.Count

        If totalRec1 = 0 Then
            MsgBox("You have deleted all the account, you may register a new admin account again to start this system.", MsgBoxStyle.Critical)
            Welcome.Show()
            MenuForAdmin.Close()
            Me.Close()
        End If
        con.Close()

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class