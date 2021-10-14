using MyClassLibrary.Classes;
using System;

namespace SagaAssets.Reports
{
    public partial class xrpt_Asset_Item : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_Asset_Item()
        {
            InitializeComponent();
        }

        private void xrpt_Asset_Item_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Prepared_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Personnel", String.Empty);
            Prepared_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Position", String.Empty);

            Noted_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Personnel", String.Empty);
            Noted_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Position", String.Empty);

            Approved_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Personnel", String.Empty);
            Approved_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Position", String.Empty);
        }
    }
}
