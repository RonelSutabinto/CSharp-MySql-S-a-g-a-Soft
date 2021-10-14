using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Saga_Technician
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Top = class_Tools.RegKeyGet(this.Name, $"{this.Name}_Top", 50);
            Left = class_Tools.RegKeyGet(this.Name, $"{this.Name}_Left", 50);
            Width = class_Tools.RegKeyGet(this.Name, $"{this.Name}_Width", 800);
            Height = class_Tools.RegKeyGet(this.Name, $"{this.Name}_Height", 600);

            this.Text = class_Functions.Product_Name_Version();

            class_Saga_Variables.sBranchCode = class_Tools.RegKeyGet(this.Name, barEditItem_Branch.Name, "000");
            barEditItem_Date_Start.EditValue = class_Tools.RegKeyGet(this.Name, barEditItem_Date_Start.Name, DateTime.Today.ToString("MMMM dd, yyyy"));
            barEditItem_Date_End.EditValue = class_Tools.RegKeyGet(this.Name, barEditItem_Date_End.Name, DateTime.Today.ToString("MMMM dd, yyyy"));

            class_Procedures.Initialize_Controls(this);
        }

        private void MainView_Shown(object sender, EventArgs e)
        {
            Refresh_Connection();

            class_Procedures.Initialize_Controls(xuc_Printing_Detail);

            if (class_Database.OpenDB(class_Database.ICSConnection))
            {
                class_Saga_Variables.Initialize_Corporation();
                class_Saga_Variables.Initialize_Corporation_All();

                class_Saga_Variables.Initialize_Branch();
                class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch);

                class_Saga_Variables.Initialize_Users();
                class_Saga_Variables.Initialize_Asset_Items();
            }
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            class_Procedures.Set_Skin();

            if (WindowState.Equals(FormWindowState.Normal))
            {
                class_Tools.RegKeySet(this.Name, $"{this.Name}_Top", Top);
                class_Tools.RegKeySet(this.Name, $"{this.Name}_Left", Left);
                class_Tools.RegKeySet(this.Name, $"{this.Name}_Width", Width);
                class_Tools.RegKeySet(this.Name, $"{this.Name}_Height", Height);
            }

            class_Tools.RegKeySet(this.Name, barEditItem_Branch.Name, class_Saga_Variables.sBranchCode);
            class_Tools.RegKeySet(this.Name, barEditItem_Date_Start.Name, barEditItem_Date_Start.EditValue.ToString());
            class_Tools.RegKeySet(this.Name, barEditItem_Date_End.Name, barEditItem_Date_End.EditValue.ToString());
        }

        private void Refresh_Connection()
        {
            barStaticItem_User_Name.Caption = $"User: {class_Variables.sUserName}";
            barStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}";
            barStaticItem_IP_Server.Caption = $"Server IP: {class_Functions.maskString(class_Database.SqlServer, 3, 2)}";
            barStaticItem_IP_Local.Caption = $"Local IP: {class_Functions.maskString(class_Variables.sLocal_IP, 3, 2)}";
        }

        private void barEditItem_Branch_EditValueChanged(object sender, EventArgs e)
        {
            class_Saga_Variables.sBranchCode = barEditItem_Branch.EditValue.ToString();
            class_Tools.RegKeySet(this.Name, barEditItem_Branch.Name, class_Saga_Variables.sBranchCode);
        }

        private void Btn_Day_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue;
        }

        private void Btn_Day_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItem_Date_Start.EditValue = class_Functions.Next_Working_Date(Convert.ToDateTime(barEditItem_Date_Start.EditValue), Control.ModifierKeys.Equals(Keys.Shift));
            barEditItem_Date_End.EditValue = barEditItem_Date_Start.EditValue;
        }

        private void Btn_Today_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barEditItem_Date_Start.EditValue = DateTime.Today;
            barEditItem_Date_End.EditValue = DateTime.Today;
        }

        private void set_Month()
        {
            barEditItem_Date_Start.EditValue = class_Functions.FirstDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue));
            barEditItem_Date_End.EditValue = class_Functions.LastDayOfMonth(Convert.ToDateTime(barEditItem_Date_Start.EditValue));
        }

        private void Btn_Month_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            set_Month();
        }

        private void Btn_Month_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int iMonths = 1;

            if (Control.ModifierKeys.Equals(Keys.Shift))
                iMonths = -1;

            barEditItem_Date_Start.EditValue = Convert.ToDateTime(barEditItem_Date_Start.EditValue).AddMonths(iMonths);
            set_Month();
        }

        private void Btn_New_Ticket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //class_Procedures.Show_Form(this, );
        }

        private void Btn_New_Asset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_Asset = new SagaAssets.Forms.frm_Asset();
            class_Procedures.Show_Form(this, frm_Asset, "New Asset Item");
        }
    }
}
