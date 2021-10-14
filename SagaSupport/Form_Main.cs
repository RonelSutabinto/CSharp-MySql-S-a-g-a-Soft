using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Windows.Forms;

namespace SagaSupport
{
    public partial class Form_Main
    {
        public Form_Main()
        {
            base.Load += Form_Main_Load;
            base.Shown += Form_Main_Shown;
            base.FormClosing += Form_Main_FormClosing;
            InitializeComponent();
            var BtnCancel = new SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, BtnCancel);
        }

        static Form_Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            main_Close();
        }

        private bool main_Close()
        {
            if (class_Procedures.Form_Close(this, true))
            {
                Application.Exit();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            class_Database.Initialize_Connection();
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            Text = class_Functions.Product_Name_Version();
            BarStaticItem_App_Version.Caption = Application.ProductVersion;
            BarStaticItem_Username.Caption = $"User: {class_Variables.sUserName}";
            BarStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}";
            BarStaticItem_Server_IP.Caption = $"Server IP: {class_Database.SqlServer}";
            BarStaticItem_Local_IP.Caption = $"Local IP: {class_Variables.sLocal_IP}";
            class_Saga_Variables.Initialize_Branch();
            class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch);
            class_Saga_Variables.Initialize_Users();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!main_Close())
                e.Cancel = true;
        }

        //private void Show_Form(XtraForm xFrm, string sTitle, bool bChild = true)
        //{
        //    class_Procedures.splash_Show(sTitle, bForceShow: true, xMode: class_Procedures.xFormMode.xForm);
        //    try
        //    {
        //        xFrm.Icon = Icon;
        //        xFrm.Text = sTitle;
        //        if (bChild)
        //            xFrm.MdiParent = this;
        //        xFrm.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        class_Procedures.Show_Error(ex);
        //    }

        //    class_Procedures.splash_Close(true);
        //}

        private void BarEditItem_Branch_EditValueChanged(object sender, EventArgs e)
        {
            class_Saga_Variables.sBranchCode = BarEditItem_Branch.EditValue.ToString();
        }

        private void btn_Change_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'");
            if (class_Saga_Procedures.Show_Login("Change User"))
            {
                Initialize_User_Privileges();
            }
        }

        internal void Initialize_User_Privileges()
        {
            BarStaticItem_Username.Caption = $"User: {class_Variables.sUserName}";
            BarStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}";
        }

        private void btn_Ticket_Groups_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var xfrm = new Forms.frm_Ticket_Groups();
            class_Procedures.Show_Form(this, xfrm, "Ticket Group Management");
        }

        private void btn_Tickets_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var xfrm = new Forms.frm_Tickets();
            class_Procedures.Show_Form(this, xfrm, "Tickets and Incident Requests");
        }

        private void btn_New_Ticket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var xfrm = new Forms.frm_Ticket();
            class_Procedures.Show_Form(this, xfrm, $"Ticket - New", false);
            xfrm.xuc_Ticket.Control_Initialize();
            xfrm.xuc_Ticket.Control_New(false);
        }

        private void btn_Requests_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var frm = new SagaAssets.Forms.frm_Requests();
            //class_Procedures.Show_Form(this, frm, "Request Management");
        }
    }
}