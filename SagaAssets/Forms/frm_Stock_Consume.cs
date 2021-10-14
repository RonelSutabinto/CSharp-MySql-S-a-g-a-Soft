using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    internal struct properties
    {
        internal int ID { get; set; }
        internal string AssetCode { get; set; }
    }

    public partial class frm_Stack_Consume : DevExpress.XtraEditors.XtraForm
	{
        public frm_Stack_Consume()
        {
            InitializeComponent();

            if (xuc_Stack_Consume is null)
            {
                xuc_Stack_Consume = new Controls.xuc_Stack_Consume();
            }

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, xuc_Stack_Consume.layoutControl, BtnCancel);
            class_Saga_Procedures.Initialize_BarManager(this, barManager);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Stack_Consume_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void frm_Stack_Consume_Load(object sender, EventArgs e)
        {
            
        }

        private void frm_Stack_Consume_Shown(object sender, EventArgs e)
        {
            
        }

    }
}