using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    public partial class frm_Asset : DevExpress.XtraEditors.XtraForm
    {
        public frm_Asset()
        {
            InitializeComponent();

            if (xuc_Asset is null)
            {
                xuc_Asset = new Controls.xuc_Asset();
            }

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, xuc_Asset.layoutControl, BtnCancel);
            class_Saga_Procedures.Initialize_BarManager(this, barManager);
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

        private void frm_Asset_Load(object sender, EventArgs e)
        {
            toggle_Clear.Checked = class_Tools.RegKeyGet(this.Name, toggle_Clear.Name, false);
        }

        private void frm_Asset_Shown(object sender, EventArgs e)
        {
            xuc_Asset.Control_Initialize();
        }

        private void frm_Assets_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_Initialize();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_New(toggle_Clear.Checked);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Asset.Control_Save())
                btn_Save.Enabled = false;
        }

        private void btn_Save_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Asset.Control_Save())
            {
                btn_Save.Enabled = false;
                xuc_Asset.Control_New(false);
            }
        }

        private void btn_Save_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Asset.Control_Save())
            {
                Form_Close();
            }
        }

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_Preview();
        }
    }
}