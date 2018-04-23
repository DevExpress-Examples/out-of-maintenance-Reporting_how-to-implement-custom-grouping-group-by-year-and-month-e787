using System;
using DevExpress.XtraReports.UI;
using System.Globalization;
// ...

namespace CustomGrouping {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private int year = 0;
        private int month = 0;
        private DateTimeFormatInfo formatInfo = DateTimeFormatInfo.CurrentInfo;

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            e.Cancel = month == Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Month;
        }

        private void lbMonthName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            month = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Month;
            ((XRLabel)sender).Text = formatInfo.MonthNames[month - 1];
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            e.Cancel = year == Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Year;
        }

        private void lbYear_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            year = Convert.ToDateTime(GetCurrentColumnValue("OrderDate")).Year;
            ((XRLabel)sender).Text = year.ToString();
        }

    }
}
