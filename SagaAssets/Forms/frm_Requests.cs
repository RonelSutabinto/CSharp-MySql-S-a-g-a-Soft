using MyClassLibrary.Classes;
using SagaAssets.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    public partial class frm_Requests
    {
        public frm_Requests()
        {
            if (xuc_Request is null)
            {
                xuc_Request = new Controls.xuc_Request();
            }

            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;

            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Request.layoutControl, xuc_Settings);
            class_Saga_Procedures.Initialize_BarManager(this, BarManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            if (xuc_Settings.Check_Save_Restore_Layout.Checked)
            {
                xuc_Request.layoutControl.SaveLayoutToRegistry(xuc_Request.Name);
            }

            gridView_Progress.SaveLayoutToRegistry(gridView_Progress.Name);
            return class_Procedures.Form_Close(this, BarManager, DockManager, gridView, xuc_Request.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Requests_Load(object sender, EventArgs e)
        {
            gridView_Progress.RestoreLayoutFromRegistry(gridView_Progress.Name);
            if (!class_Saga_Variables.sBranchCode.Equals("000"))
            {
                btn_Suspend.Enabled = false;
            }
        }

        private void frm_Requests_Shown(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit);

            var repositoryEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            class_Saga_Procedures.Initialize_Employee(repositoryEmployee);
            colRequested_By.ColumnEdit = repositoryEmployee;

            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Request.Control_Initialize();
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Initialize();
        }

        private void Data_Load()
        {
            SqlParameter[] sqlParameters;
            try
            {
                if (xuc_Settings.Toggle_Load_All.IsOn)
                {
                    if (class_Saga_Variables.sBranchCode.Equals("000"))
                    {
                        sqlParameters = new[] {
                            new SqlParameter("@Action_Type", "LOAD_ALL")
                        };
                    }
                    else
                    {
                        sqlParameters = new[] {
                            new SqlParameter("@Action_Type", "LOAD_BRANCH"),
                            new SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode)
                        };
                    }
                }
                else
                {
                    if (class_Saga_Variables.sBranchCode.Equals("000"))
                    {
                        sqlParameters = new[] {
                            new SqlParameter("@Action_Type", "LOAD_BRANCH"),
                            new SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode)
                        };
                    }
                    else
                    {
                        sqlParameters = new[] {
                            new SqlParameter("@Action_Type", "LOAD_USER"),
                            new SqlParameter("@Added_By", class_Variables.sUserName)
                        };
                    }
                }

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Request_Procedures", "System Requests");
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

        private void gridView_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            class_Procedures.Initialize_Printing(e);
        }

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ShowRibbonPrintPreview();
        }

        private void btn_Preview_System_Request_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Preview_System_Request();
        }

        private void btn_Preview_Technical_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_Preview_Technical_Report();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Request.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Request.Control_Save() && xuc_Settings.Toggle_Auto_Reload.IsOn)
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
            xuc_Request.Control_Delete();
        }

        private void Data_Show()
        {
            xuc_Request.ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID);
            xuc_Request.Request_Code.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Code);
            xuc_Request.Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code);
            xuc_Request.Requested_By.EditValue = gridView.GetFocusedRowCellValue(colRequested_By);
            xuc_Request.Department.Text = gridView.GetFocusedRowCellDisplayText(colDepartment);
            xuc_Request.Category.Text = gridView.GetFocusedRowCellDisplayText(colCategory);
            xuc_Request.Request_Type.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Type);
            xuc_Request.Amount.Value = (decimal)gridView.GetFocusedRowCellValue(colAmount);
            xuc_Request.Quantity.Value = (int)gridView.GetFocusedRowCellValue(colQuantity);
            xuc_Request.Request_Name.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Name);
            xuc_Request.Request_Description.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Description);
            xuc_Request.Reason.Text = gridView.GetFocusedRowCellDisplayText(colReason);
            xuc_Request.Technical_Report.Text = gridView.GetFocusedRowCellDisplayText(colTechnical_Report);
            xuc_Request.Recommendation.Text = gridView.GetFocusedRowCellDisplayText(colRecommendation);
            xuc_Request.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
            xuc_Request.Urgency.Text = gridView.GetFocusedRowCellDisplayText(colUrgency);

            Progress_Load();
        }

        private void Progress_Load()
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Action_Type", "LOAD_PROGRESS"), 
                new SqlParameter("@Request_Code", xuc_Request.Request_Code.Text) 
            };
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl_Progress, gridView_Progress, "inv_Request_Procedures", "Request Progress");
            if (gridView_Progress.DataRowCount > 0)
            {
                class_Procedures.Initialize_gridView(gridView_Progress);
                DockPanel3.Show();
            }
            else
            {
                DockPanel3.Hide();
            }
        }

        private void Update_Data_Row()
        {
            if (gridView.RowCount > 0)
            {
                gridView.SetFocusedRowCellValue(colBranch_Code, xuc_Request.Branch_Code.EditValue);
                gridView.SetFocusedRowCellValue(colRequest_Code, xuc_Request.Request_Code.Text);
                gridView.SetFocusedRowCellValue(colCategory, xuc_Request.Category.Text);
                gridView.SetFocusedRowCellValue(colRequest_Type, xuc_Request.Request_Type.Text);
                gridView.SetFocusedRowCellValue(colRequest_Name, xuc_Request.Request_Name.Text);
                gridView.SetFocusedRowCellValue(colRequest_Description, xuc_Request.Request_Description.Text);
                gridView.SetFocusedRowCellValue(colReason, xuc_Request.Reason.Text);
                gridView.SetFocusedRowCellValue(colTechnical_Report, xuc_Request.Technical_Report.Text);
                gridView.SetFocusedRowCellValue(colRecommendation, xuc_Request.Recommendation.Text);
                gridView.SetFocusedRowCellValue(colNotes, xuc_Request.Notes.Text);
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
                switch (e.KeyValue)
                {
                    case (int)Keys.Delete:
                        {
                            if (xuc_Request.Control_Delete())
                            {
                                try
                                {
                                    gridView.DeleteSelectedRows();
                                }
                                catch (Exception ex)
                                {
                                    class_Procedures.Show_Error(ex);
                                }
                            }

                            break;
                        }
                }
            }
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            {
                PopupMenu.ShowPopup(MousePosition);
            }
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2) && gridView.DataRowCount > 0)
            {
                switch (e.Column.FieldName ?? string.Empty)
                {
                    // Classes.class_Local_Procedures.Show_Request(e.CellValue.ToString)
                    case "Request_Code":
                        {
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

        private void btn_Request_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Request.Request_Code.Text, "Request", "Open", "Opening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Request_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Request.Request_Code.Text, "Request", "Close", "Closing") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Request_Approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Request.Request_Code.Text, "Request", "Approve", "Approving") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Suspend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Request.Request_Code.Text, "Request", "Suspend", "Suspension") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Re_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Request.Request_Code.Text, "Request", "Re-Open", "Reopening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Progress_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Progress_Load();
        }

        private void btn_Progress_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sProgress = class_Functions.Show_Input_Box("Input Request Update/Progress", "Request Update/Progress", string.Empty);
            if (sProgress.Length > 0)
            {
                SqlParameter[] sqlParameters = new[] {new SqlParameter("@Request_Code", xuc_Request.Request_Code.Text), new SqlParameter("@Notes", sProgress), new SqlParameter("@Added_By", class_Variables.sUserName), new SqlParameter("@Action_Type", "ADD_PROGRESS") };
                class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Request_Procedures", "Add New Request Progress", "New Request Update/Progress");
                Progress_Load();
            }
        }


    }
}