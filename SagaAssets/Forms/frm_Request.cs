using MyClassLibrary.Classes;
using SagaAssets.Controls;
using SagaClassLibrary.Classes;
using System;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    public partial class frm_Request : DevExpress.XtraEditors.XtraForm
    {
        public frm_Request()
        {
            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, xuc_Request.layoutControl, BtnCancel);

            if (xuc_Request is null)
            {
                xuc_Request = new xuc_Request();
            }
        }

        private bool Form_Close()
        {
            class_Tools.RegKeySet(this.Name, toggle_Clear.Name, toggle_Clear.Checked);

            return class_Procedures.Form_Close(this, barManager, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Request_Load(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_BarManager(this, barManager);

            toggle_Clear.Checked = class_Tools.RegKeyGet(this.Name, toggle_Clear.Name, false);
        }

        private void frm_Request_Shown(object sender, EventArgs e)
        {
            xuc_Request.Control_Initialize();
            xuc_Request.Control_New();
        }

        private void frm_Request_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Initialize();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Save.Enabled = xuc_Request.Control_New(toggle_Clear.Checked);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Request.Control_Save())
                btn_Save.Enabled = false;
        }

        private void btn_Save_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Request.Control_Save())
            {
                btn_Save.Enabled = xuc_Request.Control_New(toggle_Clear.Checked);
            }
        }

        private void btn_Save_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Request.Control_Save())
            {
                Form_Close();
            }
        }

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Preview_System_Request();
        }

        private void btn_Preview_System_Request_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Preview_System_Request();
        }

        private void btn_Preview_Technical_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Preview_Technical_Report();
        }
    }
}