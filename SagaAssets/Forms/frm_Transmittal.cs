using MyClassLibrary.Classes;
using SagaAssets.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    public partial class frm_Transmittal
    {
        public frm_Transmittal()
        {
            if (xuc_Transmittal is null)
            {
                xuc_Transmittal = new Controls.xuc_Transmittal();
            }

            InitializeComponent();

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;

            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Transmittal.layoutControl, xuc_Settings);
            class_Saga_Procedures.Initialize_BarManager(this, BarManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            if (xuc_Settings.Check_Save_Restore_Layout.Checked)
            {
                xuc_Transmittal.layoutControl.SaveLayoutToRegistry(xuc_Transmittal.Name);
            }

            return class_Procedures.Form_Close(this, BarManager, DockManager, gridView, xuc_Transmittal.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Transmittals_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Transmittals_Load(object sender, EventArgs e)
        {
            if (!class_Saga_Variables.sBranchCode.Equals("000"))
            {
                btn_Suspend.Enabled = false;
            }
        }

        private void frm_Transmittals_Shown(object sender, EventArgs e)
        {
            var repositoryBranch = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            class_Saga_Procedures.Initialize_Branch(repositoryBranch);
            colBranch_From.ColumnEdit = repositoryBranch;
            colBranch_To.ColumnEdit = repositoryBranch;

            var repositoryEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            class_Saga_Variables.Initialize_Employee();
            class_Saga_Procedures.Initialize_Employee(repositoryEmployee);
            colPrepared_By.ColumnEdit = repositoryEmployee;
            colReceiver.ColumnEdit = repositoryEmployee;

            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Transmittal.Control_Initialize();
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Transmittal.Control_Initialize();
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
                            new SqlParameter("@Branch_From", class_Saga_Variables.sBranchCode)
                        };
                    }
                }
                else
                {
                    if (class_Saga_Variables.sBranchCode.Equals("000"))
                    {
                        sqlParameters = new[] {
                            new SqlParameter("@Action_Type", "LOAD_BRANCH"),
                            new SqlParameter("@Branch_From", class_Saga_Variables.sBranchCode)
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

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Transmittal_Procedures", "System Transmittals");
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

        private void btn_Preview_System_Transmittal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Transmittal.Control_Preview_System_Transmittal();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Transmittal.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Transmittal.Control_Save() && xuc_Settings.Toggle_Auto_Reload.IsOn)
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
            xuc_Transmittal.Control_Delete();
        }

        private void Data_Show()
        {
            xuc_Transmittal.ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID);
            xuc_Transmittal.Transmittal_Code.Text = gridView.GetFocusedRowCellDisplayText(colTransmittal_Code);
            xuc_Transmittal.Branch_From.EditValue = gridView.GetFocusedRowCellValue(colBranch_From);
            xuc_Transmittal.Branch_To.EditValue = gridView.GetFocusedRowCellValue(colBranch_To);
            xuc_Transmittal.Transmittal_Type.Text = gridView.GetFocusedRowCellDisplayText(colTransmittal_Type);
            xuc_Transmittal.Transmittal_Name.Text = gridView.GetFocusedRowCellDisplayText(colTransmittal_Name);
            xuc_Transmittal.Transmittal_Description.Text = gridView.GetFocusedRowCellDisplayText(colTransmittal_Description);
            xuc_Transmittal.Courier.Text = gridView.GetFocusedRowCellDisplayText(colCourier);
            xuc_Transmittal.Prepared_By.Text = gridView.GetFocusedRowCellDisplayText(colPrepared_By);
            xuc_Transmittal.Receiver.Text = gridView.GetFocusedRowCellDisplayText(colReceiver);
            xuc_Transmittal.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
        }

        private void Update_Data_Row()
        {
            if (gridView.RowCount > 0)
            {
                {
                    gridView.SetFocusedRowCellValue(colBranch_From, xuc_Transmittal.Branch_From.EditValue);
                    gridView.SetFocusedRowCellValue(colBranch_To, xuc_Transmittal.Branch_To.EditValue);
                    gridView.SetFocusedRowCellValue(colTransmittal_Code, xuc_Transmittal.Transmittal_Code.Text);
                    gridView.SetFocusedRowCellValue(colTransmittal_Type, xuc_Transmittal.Transmittal_Type.Text);
                    gridView.SetFocusedRowCellValue(colTransmittal_Name, xuc_Transmittal.Transmittal_Name.Text);
                    gridView.SetFocusedRowCellValue(colTransmittal_Description, xuc_Transmittal.Transmittal_Description.Text);
                    gridView.SetFocusedRowCellValue(colPrepared_By, xuc_Transmittal.Prepared_By.Text);
                    gridView.SetFocusedRowCellValue(colCourier, xuc_Transmittal.Courier.Text);
                    gridView.SetFocusedRowCellValue(colReceiver, xuc_Transmittal.Receiver.Text);
                    gridView.SetFocusedRowCellValue(colNotes, xuc_Transmittal.Notes.Text);
                }
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
                            if (xuc_Transmittal.Control_Delete())
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
                //btn_Transmittal_Open.Enabled = !Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
                //btn_Transmittal_Close.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
                //btn_Transmittal_Approve.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsClosed));
                //btn_Progress_Add.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
                PopupMenu.ShowPopup(MousePosition);
            }
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2) && gridView.DataRowCount > 0)
            {
                switch (e.Column.FieldName ?? string.Empty)
                {
                    // Classes.class_Local_Procedures.Show_Transmittal(e.CellValue.ToString)
                    case "Transmittal_Code":
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

        private void btn_Transmittal_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Transmittal.Transmittal_Code.Text, "Transmittal", "Open", "Opening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Transmittal_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Transmittal.Transmittal_Code.Text, "Transmittal", "Close", "Closing") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Transmittal_Approve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Transmittal.Transmittal_Code.Text, "Transmittal", "Approve", "Approving") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Suspend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Transmittal.Transmittal_Code.Text, "Transmittal", "Suspend", "Suspension") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }

        private void btn_Re_Open_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (class_Asset_Procedures.Action_Command(xuc_Transmittal.Transmittal_Code.Text, "Transmittal", "Re-Open", "Reopening") && xuc_Settings.Toggle_Auto_Reload.IsOn)
            {
                Data_Load();
            }
        }
    }
}