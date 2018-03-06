Imports MaterialSkin
Imports System.Data.OleDb

Public Class Login
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da, da1 As OleDbDataAdapter
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim totalRec, totalRec1 As Integer
    Dim staffrole As String
    Dim loginstaff As String
    Dim Sql1 As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()

        Dim Sql As String = "select * from Credentials"
        Dim da As New OleDbDataAdapter(Sql, con)
        da.Fill(ds1, "staffLogin")
        totalRec = ds1.Tables("staffLogin").Rows.Count - 1
        username_CB.Items.Clear()
        For i = 0 To totalRec
            username_CB.Items.Add(ds1.Tables("stafflogin").Rows(i).Item(0))
        Next


    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim Sql As String = "select * from Credentials where Username='" & username_CB.Text & "'"
        Dim da As New OleDbDataAdapter(Sql, con)

        da.Fill(ds2, "UserPassword")
        da.Fill(ds3, "StaffName")

        If password_txt.Text = ds2.Tables("UserPassword").Rows(0).Item(1).ToString Then
            MsgBox("Welcome " & username_CB.Text & "!!")

            loginstaff = ds3.Tables("StaffName").Rows(0).Item(0).ToString
            staffrole = ds3.Tables("StaffName").Rows(0).Item(2).ToString

            username_CB.Text = ""
            password_txt.Text = ""

        Else
            MsgBox("Password incorrect.", MsgBoxStyle.Critical)
            password_txt.Text = ""
        End If

        If staffrole = "Admin" Then
            RFManagement.nameID.Text = loginstaff
            RFManagement.Role.Text = staffrole
            Reservations_Management.nameID.Text = loginstaff
            Reservations_Management.Role.Text = staffrole
            FrontDeskManagement.nameID.Text = loginstaff
            FrontDeskManagement.Role.Text = staffrole

            MenuForAdmin.Show()
            Me.Close()

        End If

        If staffrole = "RFM" Then
            RFManagement.nameID.Text = loginstaff
            RFManagement.Role.Text = staffrole

            RFManagement.Show()
            Me.Close()

        End If

        If staffrole = "RM" Then
            Reservations_Management.nameID.Text = loginstaff
            Reservations_Management.Role.Text = staffrole

            Reservations_Management.Show()
            Me.Close()

        End If

        If staffrole = "FDM" Then
            FrontDeskManagement.nameID.Text = loginstaff
            FrontDeskManagement.Role.Text = staffrole

            FrontDeskManagement.Show()
            Me.Close()

        End If

    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Dim y As String
        y = MsgBox("Quit comfirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub password_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_txt.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            login_btn.PerformClick()
        End If
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
End Class
