Imports MaterialSkin
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class RetriveAccountCredentials
    Inherits MaterialSkin.Controls.MaterialForm
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HotelManagementData.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1, Sql2 As String  ''Added Sql2
    Dim totalRec As String

    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub RetriveAccountCredentials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        con.Open()

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim MyEmail As String = txtEmail.Text
        If EmailCheck(MyEmail) = True Then
            lblVerified.Text = "Valid Email!"
            btnSendAC.Enabled = True
        Else
            lblVerified.Text = "Invalid Email!"
            btnSendAC.Enabled = False
        End If
    End Sub

    Private Sub btnSendAC_Click(sender As Object, e As EventArgs) Handles btnSendAC.Click
        Dim body As String = "Hello " + txtUsername.Text.Trim() + ","
        body += vbCrLf + vbCrLf + "Please use following credentials to log into your account."
        body += vbCrLf + "Username: " + txtUsername.Text
        body += vbCrLf + "Password:" + txtPassword.Text
        body += vbCrLf + vbCrLf + "Thanks"
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("jasontakumizs@gmail.com",
           "j1tUgq1R7Ny0")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("jasontakumizs@gmail.com")
            e_mail.To.Add(txtEmail.Text)
            e_mail.Subject = "Hotel System Management Credentials"
            e_mail.IsBodyHtml = False
            e_mail.Body = body
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent!")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

End Class