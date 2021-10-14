using System;
using System.Windows.Forms;
using MyClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Leave
    {
        public frm_Leave()
        {
            if (this.xuc_Leave is null)
            {
                this.xuc_Leave = new Controls.xuc_Leave();
            }

            this.InitializeComponent();
            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, xuc_Leave.layoutControl, BtnCancel);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, this.BarManager);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Leave_Load(object sender, EventArgs e)
        {
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, this.BarManager);
        }

        private void frm_Leave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xuc_Leave.Control_Save();
        }

        private void btn_Save_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xuc_Leave.Control_Save())
                Form_Close();
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }
    }
}