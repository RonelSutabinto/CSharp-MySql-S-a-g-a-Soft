using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using SagaSupport.Classes;
using System;
using System.Windows.Forms;

namespace SagaSupport.Forms
{
    public partial class frm_Ticket
    {
        public frm_Ticket()
        {
            if (xuc_Ticket is null)
            {
                xuc_Ticket = new Controls.xuc_Ticket();
            }

            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;

            class_Procedures.Initialize_Form(this, xuc_Ticket.layoutControl, BtnCancel);
            class_Saga_Procedures.Initialize_BarManager(this, BarManager);
        }

        private bool Form_Close()
        {
            class_Tools.RegKeySet(Name, toggle_Clear.Name, toggle_Clear.Checked);
            class_Tools.RegKeySet(xuc_Ticket.Report_Type.Name, xuc_Ticket.Report_Type.Name, xuc_Ticket.Report_Type.Text);
            return class_Procedures.Form_Close(this, BarManager, btn_Save.Enabled);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Ticket_Load(object sender, EventArgs e)
        {
            btn_Save_Open_Close.Enabled = class_Saga_Variables.isAccounting;
            
            toggle_Clear.Checked = class_Tools.RegKeyGet(Name, toggle_Clear.Name, false);
            xuc_Ticket.Report_Type.Text = class_Tools.RegKeyGet(xuc_Ticket.Report_Type.Name, xuc_Ticket.Report_Type.Name, "TICKET");
        }

        private void frm_Ticket_Shown(object sender, EventArgs e)
        {
            xuc_Ticket.Control_Initialize(true);
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Control_Initialize();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Save.Enabled = xuc_Ticket.Control_New(toggle_Clear.Checked);
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Edit_Ticket();
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket.Control_Save())
                btn_Save.Enabled = false;
        }

        private void btn_Save_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket.Control_Save())
            {
                btn_Save.Enabled = xuc_Ticket.Control_New(toggle_Clear.Checked);
            }
        }

        private void btn_Save_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket.Control_Save())
            {
                btn_Save.Enabled = false;
                Form_Close();
            }
        }

        private void btn_Save_Open_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket.Control_Save() && class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Open", "Opening"))
            {
                Form_Close();
            }
        }

		
	}
}