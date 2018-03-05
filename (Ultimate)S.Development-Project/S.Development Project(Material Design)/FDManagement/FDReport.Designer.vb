<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CLOSEReportFDButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.RFTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.checkIn_report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HotelManagementDataDataSet = New S.Development_Project_Material_Design_.HotelManagementDataDataSet()
        Me.CheckInBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckInTableAdapter = New S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.CheckInTableAdapter()
        Me.checkOut_report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.payment_report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CheckOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckOutTableAdapter = New S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.CheckOutTableAdapter()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.PaymentTableAdapter()
        Me.RFTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.HotelManagementDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckInBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.CLOSEReportFDButton.TabIndex = 53
        Me.CLOSEReportFDButton.Text = "CLOSE"
        Me.CLOSEReportFDButton.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.RFTabControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-10, 64)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(831, 25)
        Me.MaterialTabSelector1.TabIndex = 52
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'RFTabControl
        '
        Me.RFTabControl.Controls.Add(Me.TabPage1)
        Me.RFTabControl.Controls.Add(Me.TabPage2)
        Me.RFTabControl.Controls.Add(Me.TabPage3)
        Me.RFTabControl.Depth = 0
        Me.RFTabControl.Location = New System.Drawing.Point(5, 92)
        Me.RFTabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.RFTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.RFTabControl.Name = "RFTabControl"
        Me.RFTabControl.SelectedIndex = 0
        Me.RFTabControl.Size = New System.Drawing.Size(813, 331)
        Me.RFTabControl.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.checkIn_report)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(805, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check-In"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.checkOut_report)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(805, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check-Out"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.payment_report)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(805, 305)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Payment"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'checkIn_report
        '
        Me.checkIn_report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CheckIn"
        ReportDataSource1.Value = Me.CheckInBindingSource
        Me.checkIn_report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.checkIn_report.LocalReport.ReportEmbeddedResource = "S.Development_Project_Material_Design_.CheckInReport.rdlc"
        Me.checkIn_report.Location = New System.Drawing.Point(2, 2)
        Me.checkIn_report.Name = "checkIn_report"
        Me.checkIn_report.Size = New System.Drawing.Size(801, 301)
        Me.checkIn_report.TabIndex = 0
        '
        'HotelManagementDataDataSet
        '
        Me.HotelManagementDataDataSet.DataSetName = "HotelManagementDataDataSet"
        Me.HotelManagementDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckInBindingSource
        '
        Me.CheckInBindingSource.DataMember = "CheckIn"
        Me.CheckInBindingSource.DataSource = Me.HotelManagementDataDataSet
        '
        'CheckInTableAdapter
        '
        Me.CheckInTableAdapter.ClearBeforeFill = True
        '
        'checkOut_report
        '
        Me.checkOut_report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.CheckOutBindingSource
        Me.checkOut_report.LocalReport.DataSources.Add(ReportDataSource2)
        Me.checkOut_report.LocalReport.ReportEmbeddedResource = "S.Development_Project_Material_Design_.CheckOutReport.rdlc"
        Me.checkOut_report.Location = New System.Drawing.Point(2, 2)
        Me.checkOut_report.Name = "checkOut_report"
        Me.checkOut_report.Size = New System.Drawing.Size(801, 301)
        Me.checkOut_report.TabIndex = 0
        '
        'payment_report
        '
        Me.payment_report.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.PaymentBindingSource
        Me.payment_report.LocalReport.DataSources.Add(ReportDataSource3)
        Me.payment_report.LocalReport.ReportEmbeddedResource = "S.Development_Project_Material_Design_.PaymentReport.rdlc"
        Me.payment_report.Location = New System.Drawing.Point(0, 0)
        Me.payment_report.Name = "payment_report"
        Me.payment_report.Size = New System.Drawing.Size(805, 305)
        Me.payment_report.TabIndex = 0
        '
        'CheckOutBindingSource
        '
        Me.CheckOutBindingSource.DataMember = "CheckOut"
        Me.CheckOutBindingSource.DataSource = Me.HotelManagementDataDataSet
        '
        'CheckOutTableAdapter
        '
        Me.CheckOutTableAdapter.ClearBeforeFill = True
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.HotelManagementDataDataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'FDReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 473)
        Me.Controls.Add(Me.CLOSEReportFDButton)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.RFTabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FDReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Front Desk Management Report"
        Me.RFTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.HotelManagementDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckInBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CLOSEReportFDButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents RFTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents checkIn_report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CheckInBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HotelManagementDataDataSet As S.Development_Project_Material_Design_.HotelManagementDataDataSet
    Friend WithEvents CheckInTableAdapter As S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.CheckInTableAdapter
    Friend WithEvents checkOut_report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents payment_report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CheckOutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckOutTableAdapter As S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.CheckOutTableAdapter
    Friend WithEvents PaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentTableAdapter As S.Development_Project_Material_Design_.HotelManagementDataDataSetTableAdapters.PaymentTableAdapter
End Class
