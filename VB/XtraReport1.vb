Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports System.Globalization
' ...

Namespace CustomGrouping
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private year As Integer = 0
		Private month As Integer = 0
		Private formatInfo As DateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo

		Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
			e.Cancel = month = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Month
		End Sub

		Private Sub lbMonthName_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbMonthName.BeforePrint
			month = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Month
			CType(sender, XRLabel).Text = formatInfo.MonthNames(month - 1)
		End Sub

		Private Sub GroupHeader2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader2.BeforePrint
			e.Cancel = year = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Year
		End Sub

		Private Sub lbYear_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbYear.BeforePrint
			year = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Year
			CType(sender, XRLabel).Text = year.ToString()
		End Sub

	End Class
End Namespace
