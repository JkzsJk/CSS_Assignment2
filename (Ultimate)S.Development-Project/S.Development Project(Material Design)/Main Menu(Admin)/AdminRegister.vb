Imports System.Data.OleDb
Imports MaterialSkin

    Public Class AdminRegister
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1 As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1 As String
    Dim totalRec As Integer

    Private Sub AdminRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
    End Sub

    Private Sub AdminRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MenuForAdmin.Enabled = True
    End Sub

    Private Sub AddARButton_Click(sender As Object, e As EventArgs) Handles AddARButton.Click
        con.Open()
        Sql1 = "Select Username from Credentials"
        da1 = New OleDbDataAdapter(Sql1, con)
        da1.Fill(ds1, "username")
        totalRec = ds1.Tables("username").Rows.Count

        For i = 0 To totalRec - 1
            If username_txt.Text = ds1.Tables("username").Rows(i).Item(0) Then
                MsgBox("The username is exsiting, try another one.", MsgBoxStyle.Critical)
                username_txt.Clear()
                username_txt.Focus()
                password_txt.Clear()
                Exit Sub
            End If
        Next

        If username_txt.Text = "" Or password_txt.Text = "" Or position_CB.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Sql = "insert into Credentials values ('"
        Sql = Sql & username_txt.Text & "','"
        Sql = Sql & password_txt.Text & "','"
        Sql = Sql & position_CB.Text & "')"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("New account is registered!")
        End If
        position_CB.Text = ""
        username_txt.Clear()
        password_txt.Clear()
        con.Close()

    End Sub

    Private Sub CloseRegisterARButton_Click(sender As Object, e As EventArgs) Handles CloseRegisterARButton.Click
        Me.Close()
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
End Class