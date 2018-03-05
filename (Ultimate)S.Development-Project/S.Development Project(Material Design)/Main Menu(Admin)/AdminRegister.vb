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

    Private StrengthWords() As String = {"Invalid", "Very Weak", "Weak", "Better", "Medium", "Strong", "Perfect"}

    Private Sub password_txt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_txt.KeyUp
        CalculateMeter()
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
        lblProgressBar.Width = 50 * score 'label width is not auto so seeting it to show color amount
        lblProgressBar.Text = StrengthWords(score) 'Getting strength word from string array declarred above
        lblProgressBar.TextAlign = ContentAlignment.MiddleCenter 'alignning to center can be done one time in design
        lblProgressBar.BackColor = GetColor(score) 'Getting color and setting
        lblProgressBar.ForeColor = GetColor(score) 'does not work unless you disable Visual Styles from application properties
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