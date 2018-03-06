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

    Private StrengthWords() As String = {"Invalid", "Very Weak", "Weak", "Better", "Medium", "Strong", "Perfect"}

    Private Sub FirstRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
        CaptchaBox1.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
        CaptchaBox1.CaptchaTextLength = 5
    End Sub

    Private Sub accept_btn_Click(sender As Object, e As EventArgs) Handles accept_btn.Click

        If CaptchaTxt.Text.ToUpper.Equals(CaptchaBox1.CaptchaText.ToUpper) Then
            MessageBox.Show("Captcha is Correct!")
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

        Else
            MessageBox.Show("Captcha is Incorrect!")
        End If

        Username_txt.Clear()
        password_txt.Clear()

        con.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub password_txt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_txt.KeyUp
        CalculateMeter()
    End Sub

    Private Sub RefreshCBtn_Click(sender As Object, e As EventArgs) Handles RefreshCBtn.Click
        CaptchaBox1.Refresh()
    End Sub

    Sub CalculateMeter()

        Dim score As Integer
        Dim password As String = password_txt.Text

        If (password.Length > 6) Then score += 1 'Length more than 6
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And
        System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
            score += 1 'upper and lower case
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then
            score += 1 'number
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[,!,@,#,$,%,^,&,*,?,_,~,-,/,"",]") Then
            score += 1 'special character
        End If
        If (password.Length >= 10) Then score += 1 'length more than 9
        If (password.Length > 15) Then score += 1 'length more than 15
        pbStrength.Value = score / 6 * 100 'finding percentage to increase
        pwStrengthlbl.Width = 50 * score 'label width is not auto so seeting it to show color amount
        pwStrengthlbl.Text = StrengthWords(score) 'Getting strength word from string array declarred above
        pwStrengthlbl.TextAlign = ContentAlignment.MiddleCenter 'alignning to center can be done one time in design
        pwStrengthlbl.BackColor = GetColor(score) 'Getting color and setting
        pbStrength.ForeColor = GetColor(score) 'does not work unless you disable Visual Styles from application properties
    End Sub

    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score
            Case 0
                Return Color.Red
            Case 1
                Return Color.OrangeRed
            Case 2
                Return Color.Orange
            Case 3
                Return Color.Yellow
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen
        End Select
    End Function

End Class