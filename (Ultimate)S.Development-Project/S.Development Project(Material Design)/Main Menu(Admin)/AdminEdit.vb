Imports System.Data.OleDb
Imports MaterialSkin

Public Class AdminEdit
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1, da2 As New OleDbDataAdapter
    Dim ds, ds1, ds2 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2, Sql3 As String
    Dim totalRec As Integer

    Public Sub username()
        con.Open()
        ds.Clear()
        Sql = "Select Username from Credentials"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "usernameID")
        totalRec = ds.Tables("usernameID").Rows.Count
        username_CB.Items.Clear()
        For i = 0 To totalRec - 1
            username_CB.Items.Add(ds.Tables("usernameID").Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub AdminEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MenuForAdmin.Enabled = True
    End Sub

    Private Sub AdminEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Call username()

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        con.Open()
        Sql1 = "UPDATE Credentials SET"
        Sql1 = Sql1 & "[Password] = '" & password_txt.Text & "',"
        Sql1 = Sql1 & "[Role] = '" & position_CB.Text & "' Where [Username] = " & "'" & username_CB.Text & "'"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql1, con)
            cmd.ExecuteNonQuery()
            MsgBox("Account has been updated.")
            password_txt.Enabled = False
            position_CB.Enabled = False

            username_CB.Text = ""
            username_CB.Items.Clear()
            password_txt.Clear()
            position_CB.SelectedIndex = -1
            con.Close()
            Call username()
        End If
    End Sub

    Private Sub username_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles username_CB.SelectedIndexChanged
        con.Open()
        ds2.Clear()
        password_txt.Enabled = True
        position_CB.Enabled = True

        Sql2 = "Select * from Credentials where Username='" & username_CB.Text & "'"
        da2 = New OleDbDataAdapter(Sql2, con)
        da2.Fill(ds2, "Account")
        password_txt.Text = ds2.Tables("Account").Rows(0).Item(1)
        position_CB.Text = ds2.Tables("Account").Rows(0).Item(2)
        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class