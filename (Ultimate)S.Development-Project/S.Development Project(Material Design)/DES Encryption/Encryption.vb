Imports MaterialSkin
Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class Encryption
    Inherits MaterialSkin.Controls.MaterialForm
    Private des As DESCryptoServiceProvider
    Private Sub Encryption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        OFD1.ShowDialog()
        filepathname_txt.Text = OFD1.FileName
    End Sub

    Private Sub Encrypt_btn_Click(sender As Object, e As EventArgs) Handles Encrypt_btn.Click
        Dim sr As StreamReader = New StreamReader(filepathname_txt.Text)
        Dim strInput As String = (sr).ReadToEnd()
        sr.Close()
        Dim byteArrayInput() As Byte = Encoding.Default.GetBytes(strInput)
        Dim encFile As String = filepathname_txt.Text + ".enc"
        Dim fs As FileStream = New FileStream(encFile, FileMode.Create, FileAccess.Write)
        des = New DESCryptoServiceProvider
        Dim DESencrypt As ICryptoTransform = des.CreateEncryptor()
        Dim DEScryptostream As CryptoStream = New CryptoStream(fs, DESencrypt, CryptoStreamMode.Write)
        DEScryptostream.Write(byteArrayInput, 0, byteArrayInput.Length)
        DEScryptostream.Close()
        fs.Close()
        MessageBox.Show("File is encrypted successfully")
    End Sub

    Private Sub Decrypt_btn_Click(sender As Object, e As EventArgs) Handles Decrypt_btn.Click
        Dim fsread As FileStream = New FileStream(filepathname_txt.Text, FileMode.Open, FileAccess.Read)
        Dim desdecrypt As ICryptoTransform = des.CreateDecryptor()
        Dim cryptostreamDecr As CryptoStream = New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        Dim decryptedFile As String = New StreamReader(cryptostreamDecr).ReadToEnd()
        Dim fi As FileInfo = New FileInfo(filepathname_txt.Text)
        Dim originalFile As String = filepathname_txt.Text.Substring(0, filepathname_txt.Text.Length - fi.Extension.Length)
        Dim fileWriter As StreamWriter = New StreamWriter(originalFile)
        fileWriter.Write(decryptedFile)
        fileWriter.Close()
        MessageBox.Show("File is decrypted successfully")
    End Sub

End Class