Imports System.IO
Imports MaterialSkin

Public Class WebsiteBlocker
    Private Sub WebsiteBlocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
    End Sub

    Dim path As String
    Dim sw As StreamWriter

    Private Sub Block_btn_Click(sender As Object, e As EventArgs) Handles Block_btn.Click
        path = "c:\Windows\System32\drivers\etc\hosts"
        sw = New StreamWriter(path, True)
        Dim sitetoblock As String = (Environment.NewLine & "127.0.0.1 " & URL_txt.Text)
        sw.Write(sitetoblock)
        sw.Close()
        MessageBox.Show("Site Blocked!")
    End Sub

    Private Sub Unblock_btn_Click(sender As Object, e As EventArgs) Handles Unblock_btn.Click
        Dim lines() As String = File.ReadAllLines("c:\Windows\System32\drivers\etc\hosts")
        Dim TheFileLines As New List(Of String)
        TheFileLines.AddRange(System.IO.File.ReadAllLines("c:\Windows\System32\drivers\etc\hosts"))
        'for each line
        Dim int As Integer
        For i As Integer = 0 To lines.Length - 1
            'if the line contains the search term, after the first column
            If lines(i).Length > 20 AndAlso lines(i).IndexOf(URL_txt.Text, 3) > 0 Then
                int = i
            End If
        Next
        If int >= TheFileLines.Count Then Exit Sub
        TheFileLines.RemoveAt(int)
        System.IO.File.WriteAllLines("c:\Windows\System32\drivers\etc\hosts", TheFileLines.ToArray)
        MsgBox("Website Unblock")
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub
End Class