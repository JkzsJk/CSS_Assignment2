Imports MaterialSkin
Public Class FileHashing
    Inherits MaterialSkin.Controls.MaterialForm
    Private Sub FileHashing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
    End Sub

    Public Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Try
            Dim sb As New System.Text.StringBuilder(arrInput.Length * 2)
            For i As Integer = 0 To arrInput.Length - 1
                sb.Append(arrInput(i).ToString("X2"))
            Next
            Return sb.ToString().ToLower
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles Browse_btn.Click
        OpenFileDialog1.ShowDialog()
        filepathname_txt.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Hash_btn_Click(sender As Object, e As EventArgs) Handles Hash_btn.Click
        Dim path As String = filepathname_txt.Text
        Try
            Using reader As New System.IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
                Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider
                    Dim hash() As Byte = md5.ComputeHash(reader)
                    md5_txt.Text = ByteArrayToString(hash)
                End Using
            End Using
        Catch ex As Exception
            md5_txt.Text = ""
        End Try
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        MenuForAdmin.Show()
        Me.Hide()
    End Sub
End Class