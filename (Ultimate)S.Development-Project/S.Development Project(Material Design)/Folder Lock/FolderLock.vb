Imports MaterialSkin
Imports System.Security.AccessControl
Imports System.IO

Public Class FolderLock
    Private Sub FolderLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles Browse_btn.Click
        With FBD1
            If .ShowDialog() = DialogResult.OK Then
                folderpathname_txt.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub Lock_btn_Click(sender As Object, e As EventArgs) Handles Lock_btn.Click
        Dim fs As FileSystemSecurity = File.GetAccessControl(folderpathname_txt.Text)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName,
        FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(folderpathname_txt.Text, fs)
        MessageBox.Show("Folder is now successfully LOCKED!")
    End Sub

    Private Sub Unlock_btn_Click(sender As Object, e As EventArgs) Handles Unlock_btn.Click
        Dim fs As FileSystemSecurity = File.GetAccessControl(folderpathname_txt.Text)
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName,
        FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(folderpathname_txt.Text, fs)
        MessageBox.Show("Folder is now successfully UNLOCKED!")
    End Sub
End Class