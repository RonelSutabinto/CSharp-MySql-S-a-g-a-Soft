using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Payrolls
    {
        private enum selectedgridView
        { 
            viewParent,
            viewEmployees,
            viewAdjustments
        }

        private selectedgridView selectedView;

        public frm_Payrolls()
        {
            if (xuc_Payroll is null)
            {
                xuc_Payroll = new Controls.xuc_Payroll();
            }

            InitializeComponent();
            var BtnCancel = new SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Payroll.layoutControl, xuc_Settings);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Payroll.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Payrolls_Load(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_Corporation(repositoryItemLookUpEdit_Corporation);
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch);
            class_Saga_Procedures.Initialize_Employee(repositoryItemLookUpEdit_Employee);

            //class_Saga_Variables.Initialize_Adjustment();
            class_Saga_Procedures.Initialize_Adjustment(repositoryItemLookUpEdit_Adjustment);

            class_Procedures.Initialize_gridView(gridView_Employees);
            class_Procedures.Initialize_gridView(gridView_Adjustments, true, true);
        }

        private void frm_Payrolls_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Payroll.Control_Initialize();

            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load("LOAD");
        }

        private void frm_Payrolls_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Payroll.Control_Initialize();
        }

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Payroll.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Payroll.Control_Save())
            {
                if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                {
                    Data_Load("LOAD");
                }
                else
                {
                    Update_Data_Row();
                }
            }
        }

        private void gridView_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            class_Procedures.Initialize_Printing(e);
        }

        private void btn_Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView.ShowRibbonPrintPreview();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Payroll.Control_Delete())
                gridView.DeleteRow(gridView.FocusedRowHandle);
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Data_Load("LOAD");
        }

        private void Data_Load(string sActionType, string sSearch = "")
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Search", sSearch),
                new SqlParameter("@Action_Type", sActionType)
            };
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "hr_Payroll_Procedures", "hr_Salaries");
        }

        private void Load_Search(string sSearch)
        {
            if (sSearch.Length > 2)
            {
                Data_Load("SEARCH");
            }
        }

        private void RepositoryItemSearchControl_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is BaseEdit && e.KeyCode.Equals(Keys.Enter))
            {
                try
                {
                    Load_Search(((BaseEdit)sender).Text.Trim());
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
            }
        }

        private void Data_Show()
        {
            if (gridView.RowCount > 0)
            {
                xuc_Payroll.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
                xuc_Payroll.Payroll_Code.Text = gridView.GetFocusedRowCellDisplayText(colPayroll_Code);
                xuc_Payroll.Corporation.Text = gridView.GetFocusedRowCellDisplayText(colCorporation);
                xuc_Payroll.Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code);
                xuc_Payroll.Pay_Day.EditValue = gridView.GetFocusedRowCellValue(colPay_Day);
                xuc_Payroll.Date_Start.EditValue = gridView.GetFocusedRowCellValue(colDate_Start);
                xuc_Payroll.Date_End.EditValue = gridView.GetFocusedRowCellValue(colDate_End);
                xuc_Payroll.Pay_Date.EditValue = gridView.GetFocusedRowCellValue(colPay_Date);
                xuc_Payroll.Payroll_Name.Text = gridView.GetFocusedRowCellDisplayText(colPayroll_Name);
                xuc_Payroll.Payroll_Description.Text = gridView.GetFocusedRowCellDisplayText(colPayroll_Description);
                xuc_Payroll.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);

                SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Branch_Code", gridView.GetFocusedRowCellValue(colBranch_Code)),
                new SqlParameter("@Action_Type", "LOAD_BRANCH")
            };
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl_Employees, gridView_Employees, "hr_Salary_Procedures", "hr_Salaries");
            }
        }

        private void Update_Data_Row()
        {
            gridView.SetFocusedRowCellValue(colCorporation, xuc_Payroll.Corporation.EditValue);
            gridView.SetFocusedRowCellValue(colBranch_Code, xuc_Payroll.Branch_Code.EditValue);
            gridView.SetFocusedRowCellValue(colPay_Day, xuc_Payroll.Pay_Day.EditValue);
            gridView.SetFocusedRowCellValue(colDate_Start, xuc_Payroll.Date_Start.EditValue);
            gridView.SetFocusedRowCellValue(colDate_End, xuc_Payroll.Date_End.EditValue);
            gridView.SetFocusedRowCellValue(colPay_Date, xuc_Payroll.Pay_Date.EditValue);
            gridView.SetFocusedRowCellValue(colPayroll_Name, xuc_Payroll.Payroll_Name.Text);
            gridView.SetFocusedRowCellValue(colPayroll_Description, xuc_Payroll.Payroll_Description.Text);
            gridView.SetFocusedRowCellValue(colNotes, xuc_Payroll.Notes.Text);
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (xuc_Settings.Toggle_Select.IsOn)
                Data_Show();
        }

        private void gridView_Employees_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Load_Adjustments();
        }

        private void Load_Adjustments()
        {
            string sPayrollCode = (string)gridView.GetFocusedRowCellValue(colPayroll_Code);
            string sEmpCode = (string)gridView_Employees.GetFocusedRowCellValue(colEmployee_Code);
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Payroll_Code", sPayrollCode),
                new SqlParameter("@Employee_Code", sEmpCode),
                new SqlParameter("@Action_Type", "LOAD_PAY_ADJUSTMENTS")
            };
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl_Adjustments, gridView_Adjustments, "hr_Adjustment_Procedures", "hr_Pay_Checks");
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView.DataRowCount > 0 && gridView.SelectedRowsCount > 0)
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:
                        {
                            Data_Show();
                            break;
                        }

                    case Keys.F2:
                        {
                            xuc_Payroll.Select();
                            break;
                        }
                }
            }
        }

        private void gridView_Adjustments_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Delete:
                    {
                        Adjustment_Delete();
                        break;
                    }
            }
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            {
                selectedView = selectedgridView.viewParent;
                popupMenu.ShowPopup(MousePosition);
            }
        }

        private void gridView_Employees_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridView_Employees.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            {
                selectedView = selectedgridView.viewEmployees;
                popupMenu_Employee.ShowPopup(MousePosition);
            }
        }

        private void gridView_Adjustments_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridView_Adjustments.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            {
                selectedView = selectedgridView.viewAdjustments;
                popupMenu_Adjustment.ShowPopup(MousePosition);
            }
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView.RowCount > 0 && e.Clicks.Equals(2))
            {
                Data_Show();
                switch (e.Column.Name ?? "")
                {
                    case "colID":
                        {
                            xuc_Payroll.Select();
                            break;
                        }

                    case "colBranch_Code":
                        {
                            break;
                        }

                    default:
                        {
                            Data_Show();
                            if (e.CellValue is null)
                                return;
                            else
                                class_Procedures.Copy_Clipboard(e.CellValue.ToString());
                            break;
                        }
                }
            }
        }

        private void btn_Generate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlParameter[] sqlParameters;

            string sPayrollCode = (string)gridView.GetFocusedRowCellValue(colPayroll_Code);
            bool bIs30th = (bool)gridView.GetFocusedRowCellValue(colPay_Day);

            switch (selectedView)
			{
                case selectedgridView.viewParent:
                    class_Database.DBError = false;
                    int iRowHandleOld = 0;
                    for (int i = 0, loopTo = gridView_Employees.DataRowCount - 1; i <= loopTo; i++)
                    {
                        try
                        {
                            string sEmpCode = (string)gridView_Employees.GetRowCellValue(i, colEmployee_Code);

                            sqlParameters = new[] {
                                new SqlParameter("@Payroll_Code", sPayrollCode),
                                new SqlParameter("@Employee_Code", sEmpCode),
                                new SqlParameter("@Is_30th", bIs30th),
                                new SqlParameter("@Added_By", class_Variables.sUserName),
                                new SqlParameter("@Action_Type", "GENERATE_ADJUSTMENTS")
                            };
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Generate Adjustments");
                        }
                        catch (Exception ex)
                        {
                            class_Procedures.Show_Error(ex);
                        }

                        if (class_Functions.gridView_Loop(gridView_Employees, iRowHandleOld, i, "Payroll Adjustments", "saved/updated", false))
                        {
                            iRowHandleOld = i;
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;

                case selectedgridView.viewEmployees:
                    sqlParameters = new[] {
                        new SqlParameter("@Payroll_Code", sPayrollCode),
                        new SqlParameter("@Employee_Code", gridView_Employees.GetFocusedRowCellValue(colEmployee_Code)),
                        new SqlParameter("@Is_30th", bIs30th),
                        new SqlParameter("@Added_By", class_Variables.sUserName),
                        new SqlParameter("@Action_Type", "GENERATE_ADJUSTMENTS")
                    };
                    class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Generate Adjustments");
                    break;
			}

            Load_Adjustments();
        }

        private void repositoryItemLookUpEdit_Adjustment_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
            LookUpEdit editor = (LookUpEdit)sender;

            gridView_Adjustments.SetFocusedRowCellValue(colAdjust_Category, editor.GetColumnValue("Adjust_Category"));
            gridView_Adjustments.SetFocusedRowCellValue(colAdjust_Type, editor.GetColumnValue("Adjust_Type"));
        }

		private void btn_Save_Adjustments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
            if (gridView_Adjustments.SelectedRowsCount > 0)
            {
                int iRowHandle, iRowHandleOld = 0;
                var selectedRows = gridView_Adjustments.GetSelectedRows();

                if (xuc_Settings.Toggle_Clear_Selection.IsOn)
                    gridView_Adjustments.ClearSelection();

                for (int i = 0, loopTo = selectedRows.Length - 1; i <= loopTo; i++)
                {
                    iRowHandle = selectedRows[i];
                    int iID;
                    try
                    {
                        iID = (int)gridView_Adjustments.GetRowCellValue(iRowHandle, col_ID_Adjustment);
                    }
                    catch (Exception)
                    {
                        iID = 0;
                    }

                    try
                    {
                        string sPayrollCode = (string)gridView.GetFocusedRowCellValue(colPayroll_Code);
                        string sEmpCode = (string)gridView_Employees.GetFocusedRowCellValue(colEmployee_Code);

                        SqlParameter[] sqlParameters = new[] {
                            new SqlParameter("@ID", iID),
                            new SqlParameter("@Payroll_Code", sPayrollCode),
                            new SqlParameter("@Employee_Code", sEmpCode),
                            new SqlParameter("@Adjust_Code", gridView_Adjustments.GetRowCellValue(iRowHandle, colAdjust_Code)),
                            new SqlParameter("@Amount", gridView_Adjustments.GetRowCellValue(iRowHandle, colAmount)),
                            new SqlParameter("@Adjust_Description", gridView_Adjustments.GetRowCellDisplayText(iRowHandle, colAdjust_Description)),
                            new SqlParameter("@Notes", gridView_Adjustments.GetRowCellDisplayText(iRowHandle, colAdjust_Notes)),
                            new SqlParameter("@Added_By", class_Variables.sUserName),
                            new SqlParameter("@Modified_By", class_Variables.sUserName),
                            new SqlParameter("@Action_Type", "SAVE_ADJUSTMENTS")
                        };
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Salary Profile");
                    }
                    catch (Exception ex)
                    {
                        class_Procedures.Show_Error(ex);
                    }

                    if (class_Functions.gridView_Loop(this.gridView_Adjustments, iRowHandleOld, iRowHandle, "Payroll Adjustments", "saved/updated", false))
                        iRowHandleOld = iRowHandle;
                    else
                        return;
                }
            }
        }

        private void Adjustment_Delete()
        {
            if (gridView_Adjustments.RowCount > 0 && gridView_Adjustments.SelectedRowsCount > 0)
            {
                try
                {
                    SqlParameter[] sqlParameters = new[] {
                            new SqlParameter("@ID", (int)gridView_Adjustments.GetFocusedRowCellValue(col_ID_Adjustment)),
                            new SqlParameter("@Action_Type", "DELETE")
                        };
                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Delete/Remove Adjustment", true);
                }
                catch (Exception ex)
                {
                    class_Procedures.Show_Error(ex);
                }
                Load_Adjustments();
            }
        }

        private void btn_Delete_Adjustments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView_Adjustments.SelectedRowsCount > 0)
            {
                Adjustment_Delete();

                //int iRowHandle, iRowHandleOld = 0;
                //var selectedRows = gridView_Adjustments.GetSelectedRows();

                //if (xuc_Settings.Toggle_Clear_Selection.IsOn)
                //    gridView_Adjustments.ClearSelection();

                //for (int i = 0, loopTo = selectedRows.Length - 1; i <= loopTo; i++)
                //{
                //    iRowHandle = selectedRows[i];
                //    int iID;
                //    try
                //    {
                //        iID = (int)gridView_Adjustments.GetRowCellValue(iRowHandle, col_ID_Adjustment);
                //    }
                //    catch (Exception)
                //    {
                //        iID = 0;
                //    }

                //    try
                //    {
                //        SqlParameter[] sqlParameters = new[] {
                //            new SqlParameter("@ID", iID),
                //            new SqlParameter("@Action_Type", "DELETE")
                //        };
                //        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "hr_Adjustment_Procedures", "Salary Adjustment");
                //    }
                //    catch (Exception ex)
                //    {
                //        class_Procedures.Show_Error(ex);
                //    }

                //    if (class_Functions.gridView_Loop(this.gridView_Adjustments, iRowHandleOld, iRowHandle, "Payroll Adjustments", "saved/updated", false))
                //        iRowHandleOld = iRowHandle;
                //    else
                //        return;
                //}
            }
        }
    }
}