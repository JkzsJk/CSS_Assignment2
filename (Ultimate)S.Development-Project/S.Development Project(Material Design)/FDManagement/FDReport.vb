Imports MaterialSkin

Public Class Report
    Inherits MaterialSkin.Controls.MaterialForm

    Private Sub FDReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrontDeskManagement.Enabled = True
    End Sub
    Private Sub FDReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelManagementDataDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.HotelManagementDataDataSet.Payment)
        'TODO: This line of code loads data into the 'HotelManagementDataDataSet.CheckOut' table. You can move, or remove it, as needed.
        Me.CheckOutTableAdapter.Fill(Me.HotelManagementDataDataSet.CheckOut)
        'TODO: This line of code loads data into the 'HotelManagementDataDataSet.CheckIn' table. You can move, or remove it, as needed.
        Me.CheckInTableAdapter.Fill(Me.HotelManagementDataDataSet.CheckIn)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)
        Me.checkIn_report.RefreshReport()
        Me.checkOut_report.RefreshReport()
        Me.payment_report.RefreshReport()
    End Sub

    Private Sub CLOSEReportFDButton_Click(sender As Object, e As EventArgs) Handles CLOSEReportFDButton.Click
        Me.Close()
    End Sub
End Class