using System;
using System.Windows.Forms;
using MyClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Employee
    {
        public frm_Employee()
        {
            if (this.xuc_Employee is null)
            {
                this.xuc_Employee = new Controls.xuc_Employee();
            }

            this.InitializeComponent();
            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, xuc_Employee.layoutControl, BtnCancel);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, this.BarManager);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Employee_Load(object sender, EventArgs e)
        {
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, this.BarManager);
        }

        private void frm_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.xuc_Employee.Control_Save();
        }

        private void btn_Save_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xuc_Employee.Control_Save())
                Form_Close();
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }
    }
}