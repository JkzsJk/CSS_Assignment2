Imports System.Data.OleDb
Imports MaterialSkin

Public Class FirstRegister
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1 As String

    Private Sub FirstRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

    End Sub

    Private Sub accept_btn_Click(sender As Object, e As EventArgs) Handles accept_btn.Click

        If Username_txt.Text = "" Or password_txt.Text = "" Then
            MsgBox("You must fill in all the column.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        con.Open()
        Sql = "insert into Credentials values ('"
        Sql = Sql & Username_txt.Text & "','"
        Sql = Sql & password_txt.Text & "','"
        Sql = Sql & "Admin')"

        Dim y As String
        y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd = New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("New account is registered!")
            Me.Hide()
            Login.Show()
        End If

        Username_txt.Clear()
        password_txt.Clear()

        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class