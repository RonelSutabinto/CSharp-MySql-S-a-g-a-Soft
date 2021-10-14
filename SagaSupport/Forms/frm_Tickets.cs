using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using SagaSupport.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SagaSupport.Forms
{
    public partial class frm_Tickets
    {
        public frm_Tickets()
        {
            if (xuc_Ticket is null)
            {
                xuc_Ticket = new Controls.xuc_Ticket();
            }

            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;

            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Ticket.layoutControl, xuc_Settings);
            class_Saga_Procedures.Initialize_BarManager(this, BarManager, xuc_Settings);

        }

        private bool Form_Close()
        {
            if (xuc_Settings.Check_Save_Restore_Layout.Checked)
                gridView_Progress.SaveLayoutToRegistry(gridView_Progress.Name);
            
            return class_Procedures.Form_Close(this, BarManager, DockManager, gridView, xuc_Ticket.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
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

        private void frm_Tickets_Load(object sender, EventArgs e)
        {
            if (xuc_Settings.Check_Save_Restore_Layout.Checked)
                gridView_Progress.RestoreLayoutFromRegistry(gridView_Progress.Name);

            if (!class_Saga_Variables.sBranchCode.Equals("000"))
            {
                btn_Suspend.Enabled = false;
            }
        }

        private void frm_Tickets_Shown(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit);
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Ticket.Control_Initialize(true);
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Control_Initialize(true);
        }

        private void Data_Load(bool bAll = false)
        {
            SqlParameter[] sqlParameters;
            try
            {
                if (xuc_Settings.Toggle_Load_All.IsOn)
                {
                    if (class_Saga_Variables.sBranchCode.Equals("000"))
                    {
                        if (bAll)
                            sqlParameters = new[] { new SqlParameter("@Action_Type", "LOAD_ALL") };
                        else
                            sqlParameters = new[] { new SqlParameter("@Action_Type", "LOAD_UNCLOSED") };
                    }
                    else
                    {
                        sqlParameters = new[] { new SqlParameter("@Action_Type", "LOAD_BRANCH"), new SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode) };
                    }
                }
                else
                {
                    sqlParameters = new[] { new SqlParameter("@Action_Type", "LOAD_USER"), new SqlParameter("@Added_By", class_Variables.sUserName) };
                }

                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Ticket_Procedures", "acc_Tickets");
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
            finally
            {
                colID.SortIndex = 0;
                colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Data_Load();
        }

        private void btn_Load_All_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Data_Load(true);
        }

        private void gridView_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            class_Procedures.Initialize_Printing(e);
        }

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ShowRibbonPrintPreview();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Edit_Ticket();
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Ticket.Control_Save() && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
            else
            {
                Update_Data_Row();
            }
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Ticket.Control_Delete();
        }

        private void Data_Show()
        {
            xuc_Ticket.ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID);
            xuc_Ticket.Ticket_Code.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Code);
            xuc_Ticket.Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code);
            xuc_Ticket.Created_By.EditValue = gridView.GetFocusedRowCellDisplayText(colCreated_By).ToLower();
            xuc_Ticket.Assigned_To.EditValue = gridView.GetFocusedRowCellDisplayText(colAssigned_To);
            xuc_Ticket.Added_By.EditValue = gridView.GetFocusedRowCellDisplayText(colAdded_By);
            xuc_Ticket.Modified_By.EditValue = gridView.GetFocusedRowCellDisplayText(colModified_By);
            xuc_Ticket.Opened_By.EditValue = gridView.GetFocusedRowCellDisplayText(colOpened_By);
            xuc_Ticket.Closed_By.EditValue = gridView.GetFocusedRowCellDisplayText(colClosed_By);
            xuc_Ticket.Deleted_By.EditValue = gridView.GetFocusedRowCellDisplayText(colDeleted_By);
            xuc_Ticket.Ticket_Status.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Status);
            xuc_Ticket.Ticket_Group.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Group);
            xuc_Ticket.Report_Type.Text = gridView.GetFocusedRowCellDisplayText(colReport_Type);
            xuc_Ticket.Communication_Type.Text = gridView.GetFocusedRowCellDisplayText(colCommunication_Type);
            xuc_Ticket.Incident_Date.Text = gridView.GetFocusedRowCellDisplayText(colIncident_Date);
            xuc_Ticket.Ticket_Impact.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Impact);
            xuc_Ticket.Ticket_Urgency.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Urgency);
            xuc_Ticket.Defect_Type.Text = gridView.GetFocusedRowCellDisplayText(colDefect_Type);
            xuc_Ticket.Asset_Code.EditValue = gridView.GetFocusedRowCellDisplayText(colAsset_Code);
            xuc_Ticket.Ticket_Name.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Name);
            xuc_Ticket.Ticket_Description.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Description);
            xuc_Ticket.Ticket_Attachment.RtfText = gridView.GetFocusedRowCellDisplayText(colTicket_Attachment);
            xuc_Ticket.Ticket_Solution.Text = gridView.GetFocusedRowCellDisplayText(colTicket_Solution);
            xuc_Ticket.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);

            Progress_Load(gridView.GetFocusedRowCellDisplayText(colTicket_Code));
        }

        private void Progress_Load(string sTicketCode)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Action_Type", "LOAD_PROGRESS"), 
                new SqlParameter("@Ticket_Code", sTicketCode) 
            };
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl_Progress, gridView_Progress, "acc_Ticket_Procedures", "Ticket Progress");
            if (gridView_Progress.DataRowCount > 0)
            {
                DockPanel3.Show();
            }
            else
            {
                //DockPanel3.Hide();
            }
            class_Procedures.Initialize_gridView(gridView_Progress);
        }

        private void Update_Data_Row()
        {
            if (gridView.RowCount > 0)
            {
                gridView.SetFocusedRowCellValue(colTicket_Code, xuc_Ticket.Ticket_Code.Text);
                gridView.SetFocusedRowCellValue(colBranch_Code, xuc_Ticket.Branch_Code.EditValue);
                gridView.SetFocusedRowCellValue(colCreated_By, xuc_Ticket.Created_By.EditValue);
                gridView.SetFocusedRowCellValue(colAssigned_To, xuc_Ticket.Assigned_To.EditValue);
                gridView.SetFocusedRowCellValue(colTicket_Group, xuc_Ticket.Ticket_Group.Text);
                gridView.SetFocusedRowCellValue(colReport_Type, xuc_Ticket.Report_Type.Text);
                gridView.SetFocusedRowCellValue(colCommunication_Type, xuc_Ticket.Communication_Type.Text);
                gridView.SetFocusedRowCellValue(colTicket_Impact, xuc_Ticket.Ticket_Impact.Text);
                gridView.SetFocusedRowCellValue(colTicket_Urgency, xuc_Ticket.Ticket_Urgency.Text);
                gridView.SetFocusedRowCellValue(colTicket_Name, xuc_Ticket.Ticket_Name.Text);
                gridView.SetFocusedRowCellValue(colTicket_Description, xuc_Ticket.Ticket_Description.Text);
                gridView.SetFocusedRowCellValue(colTicket_Attachment, xuc_Ticket.Ticket_Attachment.RtfText);
                gridView.SetFocusedRowCellValue(colTicket_Solution, xuc_Ticket.Ticket_Solution.Text);
                gridView.SetFocusedRowCellValue(colDefect_Type, xuc_Ticket.Defect_Type.Text);
                gridView.SetFocusedRowCellValue(colNotes, xuc_Ticket.Notes.Text);
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (xuc_Settings.Toggle_Select.IsOn)
                Data_Show();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView.DataRowCount > 0)
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        {
                            //if (xuc_Ticket.Control_Delete())
                            //{
                            //    try
                            //    {
                            //        gridView.DeleteSelectedRows();
                            //    }
                            //    catch (Exception ex)
                            //    {
                            //        class_Procedures.Show_Error(ex);
                            //    }
                            //}

                            class_Saga_Database.Transaction_Delete(gridView, "Delete", "acc_Ticket_Procedures", "DELETE_TICKET", xuc_Settings.Toggle_Live_Looping.IsOn);

                            break;
                        }
                }
            }
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            {
                btn_Ticket_Open.Enabled = !Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
                btn_Ticket_Close.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened)) && !Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsClosed));
                btn_Ticket_Approve.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsClosed)) && !Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsApproved));
                btn_Re_Open.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsClosed));
                btn_Progress_Add.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
                PopupMenu.ShowPopup(MousePosition);
            }
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2) && gridView.DataRowCount > 0)
            {
                switch (e.Column.FieldName ?? string.Empty)
                {
                    // Classes.class_Local_Procedures.Show_Ticket(e.CellValue.ToString)
                    case "Ticket_Code":
                        {
                            break;
                        }

                    case "Asset_Code":
                        {
                            var frm = new SagaAssets.Forms.frm_Asset();
                            frm.Show();
                            //frm.xuc_Asset.Control_Retrieve(e.CellValue.ToString());

                            break;
                        }

                    default:
                        {
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString());
                            Data_Show();
                            break;
                        }
                }
            }
        }

        private void btn_Ticket_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Open", "Opening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                xuc_Ticket.Copy_To_Clipboard();
             
                Data_Load();
            }
        }

        private void btn_Ticket_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Close", "Closing") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                xuc_Ticket.Copy_To_Clipboard();
             
                Data_Load();
            }
        }

        private void btn_Ticket_Approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Approve", "Approving") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Suspend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Suspend", "Suspension") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Re_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Support_Database.Ticket_Action(xuc_Ticket.Ticket_Code.Text, "Re-Open", "Reopening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Progress_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Progress_Load(gridView.GetFocusedRowCellDisplayText(colTicket_Code));
        }

        private void btn_Progress_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sProgress = class_Functions.Show_Input_Box("Input Ticket Update/Progress", "Ticket Update/Progress", string.Empty);
            if (sProgress.Length > 0)
            {
                SqlParameter[] sqlParameters = new[] {
                    new SqlParameter("@Ticket_Code", gridView.GetFocusedRowCellDisplayText(colTicket_Code)), 
                    new SqlParameter("@Notes", sProgress), 
                    new SqlParameter("@Added_By", class_Variables.sUserName), 
                    new SqlParameter("@Action_Type", "ADD_PROGRESS") 
                };
                class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Procedures", "Add New Ticket Progress", "New Ticket Update/Progress");
                Progress_Load(gridView.GetFocusedRowCellDisplayText(colTicket_Code));
            }
        }

        private void gridView_Progress_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    class_Saga_Database.Transaction_Delete(gridView_Progress, "Progress", "acc_Ticket_Procedures", "DELETE_PROGRESS", xuc_Settings.Toggle_Live_Looping.IsOn);
                    break;
            }
        }

		private void btn_Copy_To_Clipboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
            xuc_Ticket.Copy_To_Clipboard();
		}

		
	}
}