Imports MaterialSkin
Imports System.Data.OleDb

Public Class Welcome

    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim totalRec As Integer
    Dim Sql As String

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()

        Sql = "Select * from Credentials"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Account")
        totalRec = ds.Tables("Account").Rows.Count
        con.Close()

        If totalRec >= 1 Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        FirstRegister.Show()
        Me.Close()
    End Sub
End Class