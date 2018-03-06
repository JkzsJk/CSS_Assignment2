Imports MaterialSkin

Public Class MenuForAdmin
    Inherits MaterialSkin.Controls.MaterialForm

    Private Sub MenuForAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

    End Sub

    Private Sub logOut_btn_Click(sender As Object, e As EventArgs) Handles logOut_btn.Click
        Dim y As String
        y = MsgBox("Logout confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub RegisterAccMMButton_Click(sender As Object, e As EventArgs) Handles RegisterAccMMButton.Click
        AdminRegister.Show()
        Me.Enabled = False
    End Sub

    Private Sub RFMMMButton_Click(sender As Object, e As EventArgs) Handles RFMMMButton.Click
        RFManagement.Show()
        Me.Hide()
    End Sub

    Private Sub ReservationMMMButton_Click(sender As Object, e As EventArgs) Handles ReservationMMMButton.Click
        Reservations_Management.Show()
        Me.Hide()
    End Sub

    Private Sub FDMMMButton_Click(sender As Object, e As EventArgs) Handles FDMMMButton.Click
        FrontDeskManagement.Show()
        Me.Hide()
    End Sub

    Private Sub TimeNdate_Tick(sender As Object, e As EventArgs) Handles TimeNdate.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub DeleteAcc_btn_Click(sender As Object, e As EventArgs) Handles DeleteAcc_btn.Click
        Me.Enabled = False
        AdminDelete.Show()
    End Sub

    Private Sub editAcc_btn_Click(sender As Object, e As EventArgs) Handles editAcc_btn.Click
        Me.Enabled = False
        AdminEdit.Show()
    End Sub

    Private Sub FileHashingBtn_Click(sender As Object, e As EventArgs) Handles FileHashingBtn.Click
        FileHashing.Show()
        Me.Hide()
    End Sub

    Private Sub FolderLockBtn_Click(sender As Object, e As EventArgs) Handles FolderLockBtn.Click
        FolderLock.Show()
        Me.Hide()
    End Sub

    Private Sub WebsiteBlocker_btn_Click(sender As Object, e As EventArgs) Handles WebsiteBlocker_btn.Click
        WebsiteBlocker.Show()
        Me.Hide()
    End Sub
End Class