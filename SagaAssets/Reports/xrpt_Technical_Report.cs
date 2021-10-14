using MyClassLibrary.Classes;
using System;

namespace SagaAssets.Reports
{
    public partial class xrpt_Technical_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_Technical_Report()
        {
            InitializeComponent();
        }

        private void xrpt_System_Request_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Prepared_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Personnel", String.Empty);
            Prepared_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Position", String.Empty);

            Noted_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Personnel", String.Empty);
            Noted_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Position", String.Empty);

            Recommended_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Recommended_Personnel", String.Empty);
            Recommended_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Recommended_Position", String.Empty);

            Approved_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Personnel", String.Empty);
            Approved_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Position", String.Empty);
        }
    }
}
