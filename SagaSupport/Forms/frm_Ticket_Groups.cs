using DevExpress.XtraTreeList;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Windows.Forms;

namespace SagaSupport.Forms
{
    public partial class frm_Ticket_Groups
    {
        public frm_Ticket_Groups()
        {
            if (xuc_Ticket_Group is null)
            {
                xuc_Ticket_Group = new Controls.xuc_Ticket_Group();
            }

            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;

            class_Procedures.Initialize_Form(this, DockManager, TreeList, BtnCancel, xuc_Settings);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, BarManager, DockManager, TreeList, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Ticket_Groups_Load(object sender, EventArgs e)
        {
            class_Procedures.Initialize_TreeList(TreeList, "Ticket_Group", "Ticket_Group_Sub");
            class_Saga_Procedures.Initialize_BarManager(this, BarManager, xuc_Settings);
        }

        private void frm_Tickets_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Ticket_Group.Control_Initialize();
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket_Group.Control_Initialize();
        }

        private void Data_Load()
        {
            class_Database.Bind_Data(class_Database.ICSConnection, TreeList, "SELECT * FROM acc_Ticket_Groups", "acc_Ticket_Groups");
            TreeList.ExpandAll();
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Data_Load();
        }

        // Private Sub TreeList_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles TreeList.PrintInitialize
        // class_Procedures.Initialize_Printing(e)
        // End Sub

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeList.ShowRibbonPrintPreview();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket_Group.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket_Group.Control_Save() && xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket_Group.Control_Delete();
        }

        private void data_Show_TreeView()
        {
            if (TreeList.AllNodesCount > 0)
            {
                try
                {
                    {
                        xuc_Ticket_Group.ID.EditValue = TreeList.GetFocusedRowCellDisplayText(colID);
                        xuc_Ticket_Group.Ticket_Group_Code.Text = TreeList.GetFocusedRowCellDisplayText(colTicket_Group_Code);
                        xuc_Ticket_Group.Ticket_Group.Text = TreeList.GetFocusedRowCellDisplayText(colTicket_Group);
                        xuc_Ticket_Group.Ticket_Group_Sub.Text = TreeList.GetFocusedRowCellDisplayText(colTicket_Group_Sub);
                        xuc_Ticket_Group.Ticket_Description.Text = TreeList.GetFocusedRowCellDisplayText(colTicket_Description);
                        xuc_Ticket_Group.Personnel.Text = TreeList.GetFocusedRowCellDisplayText(colPersonnel);
                        xuc_Ticket_Group.Notes.Text = TreeList.GetFocusedRowCellDisplayText(colNotes);
                    }
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
            }
        }

        private void treeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (xuc_Settings.Toggle_Select.IsOn)
                data_Show_TreeView();
        }
    }
}