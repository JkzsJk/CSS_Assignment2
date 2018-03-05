<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RMReport
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RoomReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelManagementDataDataSet = New S.Development_Project_Material_Design_.HotelManagementDataDataSet()
        Me.FnSReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.roomReservation_Report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FnS_Report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RoomReservationTableAdapter = New S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.RoomReservationTableAdapter()
        Me.FnSReservationTableAdapter = New S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.FnSReservationTableAdapter()
        Me.CLOSEReportFDButton = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.RoomReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelManagementDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FnSReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RFTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoomReservationBindingSource
        '
        Me.RoomReservationBindingSource.DataMember = "RoomReservation"
        Me.RoomReservationBindingSource.DataSource = Me.HotelManagementDataDataSet
        '
        'HotelManagementDataDataSet
        '
        Me.HotelManagementDataDataSet.DataSetName = "HotelManagementDataDataSet"
        Me.HotelManagementDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FnSReservationBindingSource
        '
        Me.FnSReservationBindingSource.DataMember = "FnSReservation"
        Me.FnSReservationBindingSource.DataSource = Me.HotelManagementDataDataSet
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-6, 57)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(831, 25)
        Me.MaterialTabSelector1.TabIndex = 54
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.TabPage1)
        Me.RFTabControl.Controls.Add(Me.TabPage2)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(9, 85)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(803, 331)
        Me.RFTabControl.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.roomReservation_Report)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(795, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Room Reservation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'roomReservation_Report
        '
        Me.roomReservation_Report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "RoomReservation"
        ReportDataSource5.Value = Me.RoomReservationBindingSource
        Me.roomReservation_Report.LocalReport.DataSources.Add(ReportDataSource5)
        Me.roomReservation_Report.LocalReport.ReportEmbeddedResource = "S.Development_Project_Material_Design_.RoomReservationReport.rdlc"
        Me.roomReservation_Report.Location = New System.Drawing.Point(2, 2)
        Me.roomReservation_Report.Name = "roomReservation_Report"
        Me.roomReservation_Report.Size = New System.Drawing.Size(791, 301)
        Me.roomReservation_Report.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FnS_Report)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(795, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facilities & Services Reservation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FnS_Report
        '
        Me.FnS_Report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.FnSReservationBindingSource
        Me.FnS_Report.LocalReport.DataSources.Add(ReportDataSource6)
        Me.FnS_Report.LocalReport.ReportEmbeddedResource = "S.Development_Project_Material_Design_.FnSReservationReport.rdlc"
        Me.FnS_Report.Location = New System.Drawing.Point(2, 2)
        Me.FnS_Report.Name = "FnS_Report"
        Me.FnS_Report.Size = New System.Drawing.Size(791, 301)
        Me.FnS_Report.TabIndex = 0
        '
        'RoomReservationTableAdapter
        '
        Me.RoomReservationTableAdapter.ClearBeforeFill = True
        '
        'FnSReservationTableAdapter
        '
        Me.FnSReservationTableAdapter.ClearBeforeFill = True
        '
        'CLOSEReportFDButton
        '
        Me.CLOSEReportFDButton.Depth = 0
        Me.CLOSEReportFDButton.Location = New System.Drawing.Point(748, 439)
        Me.CLOSEReportFDButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CLOSEReportFDButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.CLOSEReportFDButton.Name = "CLOSEReportFDButton"
        Me.CLOSEReportFDButton.Primary = True
        Me.CLOSEReportFDButton.Size = New System.Drawing.Size(64, 23)
        Me.CLOSEReportFDButton.TabIndex = 55
        Me.CLOSEReportFDButton.Text = "CLOSE"
        Me.CLOSEReportFDButton.UseVisualStyleBackColor = True
        '
        'RMReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 473)
        Me.Controls.Add(Me.CLOSEReportFDButton)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Name = "RMReport"
        Me.Text = "RMReport"
        CType(Me.RoomReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelManagementDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FnSReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RFTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents roomReservation_Report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RoomReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HotelManagementDataDataSet As S.Development_Project_Material_Design_.HotelManagementDataDataSet
    Friend WithEvents RoomReservationTableAdapter As S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.RoomReservationTableAdapter
    Friend WithEvents FnS_Report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FnSReservationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FnSReservationTableAdapter As S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.FnSReservationTableAdapter
    Friend WithEvents CLOSEReportFDButton As MaterialSkin.Controls.MaterialRaisedButton
End Class
