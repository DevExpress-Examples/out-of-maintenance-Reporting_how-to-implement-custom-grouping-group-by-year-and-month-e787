Imports Microsoft.VisualBasic
Imports System
Namespace CustomGrouping
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.nwindDataSet1 = New CustomGrouping.nwindDataSet()
			Me.ordersTableAdapter = New CustomGrouping.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.lbYear = New DevExpress.XtraReports.UI.XRLabel()
			Me.lbMonthName = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.Height = 33
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbMonthName})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.Height = 48
			Me.GroupHeader1.Name = "GroupHeader1"
'			Me.GroupHeader1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.GroupHeader1_BeforePrint);
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbYear})
			Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader2.Height = 48
			Me.GroupHeader2.Level = 1
			Me.GroupHeader2.Name = "GroupHeader2"
'			Me.GroupHeader2.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.GroupHeader2_BeforePrint);
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' lbYear
			' 
			Me.lbYear.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(255))))))
			Me.lbYear.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "")})
			Me.lbYear.Font = New System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold)
			Me.lbYear.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.lbYear.Location = New System.Drawing.Point(17, 8)
			Me.lbYear.Name = "lbYear"
			Me.lbYear.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbYear.Size = New System.Drawing.Size(600, 33)
			Me.lbYear.StylePriority.UseBackColor = False
			Me.lbYear.StylePriority.UseFont = False
			Me.lbYear.StylePriority.UseForeColor = False
			Me.lbYear.Text = "lbYear"
'			Me.lbYear.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.lbYear_BeforePrint);
			' 
			' lbMonthName
			' 
			Me.lbMonthName.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(240))))))
			Me.lbMonthName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate", "")})
			Me.lbMonthName.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbMonthName.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.lbMonthName.Location = New System.Drawing.Point(17, 8)
			Me.lbMonthName.Name = "lbMonthName"
			Me.lbMonthName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.lbMonthName.Size = New System.Drawing.Size(600, 33)
			Me.lbMonthName.StylePriority.UseBackColor = False
			Me.lbMonthName.StylePriority.UseFont = False
			Me.lbMonthName.StylePriority.UseForeColor = False
			Me.lbMonthName.Text = "lbMonthName"
'			Me.lbMonthName.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.lbMonthName_BeforePrint);
			' 
			' xrTable1
			' 
			Me.xrTable1.Location = New System.Drawing.Point(17, 8)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.Size = New System.Drawing.Size(600, 25)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Size = New System.Drawing.Size(600, 25)
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipName", "")})
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Size = New System.Drawing.Size(198, 25)
			Me.xrTableCell1.Text = "xrTableCell1"
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipCountry", "")})
			Me.xrTableCell2.Location = New System.Drawing.Point(198, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Size = New System.Drawing.Size(198, 25)
			Me.xrTableCell2.Text = "xrTableCell2"
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipAddress", "")})
			Me.xrTableCell3.Location = New System.Drawing.Point(396, 0)
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Size = New System.Drawing.Size(204, 25)
			Me.xrTableCell3.Text = "xrTableCell3"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupHeader2})
			Me.DataAdapter = Me.ordersTableAdapter
			Me.DataMember = "Orders"
			Me.DataSource = Me.nwindDataSet1
			Me.DrawGrid = False
			Me.Version = "8.3"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents lbMonthName As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents lbYear As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private ordersTableAdapter As CustomGrouping.nwindDataSetTableAdapters.OrdersTableAdapter
	End Class
End Namespace
