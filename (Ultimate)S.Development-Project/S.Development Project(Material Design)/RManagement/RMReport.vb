Imports MaterialSkin

Public Class RMReport
    Inherits MaterialSkin.Controls.MaterialForm

    Private Sub RMReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Reservations_Management.Enabled = True
    End Sub

    Private Sub RMReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelManagementDataDataSet.FnSReservation' table. You can move, or remove it, as needed.
        Me.FnSReservationTableAdapter.Fill(Me.HotelManagementDataDataSet.FnSReservation)
        'TODO: This line of code loads data into the 'HotelManagementDataDataSet.RoomReservation' table. You can move, or remove it, as needed.
        Me.RoomReservationTableAdapter.Fill(Me.HotelManagementDataDataSet.RoomReservation)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue700, Primary.Blue900, Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE)

        Me.roomReservation_Report.RefreshReport()
        Me.FnS_Report.RefreshReport()
    End Sub

    Private Sub CLOSEReportFDButton_Click(sender As Object, e As EventArgs) Handles CLOSEReportFDButton.Click
        Me.Close()
    End Sub
End Class