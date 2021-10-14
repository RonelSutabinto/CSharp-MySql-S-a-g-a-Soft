using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Pay_Checks
    {
        public frm_Pay_Checks()
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

        private void frm_Pay_Checks_Load(object sender, EventArgs e)
        {
           
        }

        private void frm_Pay_Checks_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Payroll.Control_Initialize();
            
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load("LOAD");
        }

        private void frm_Pay_Checks_FormClosing(object sender, FormClosingEventArgs e)
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
                xuc_Payroll.Branch_Code.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Code);
                xuc_Payroll.Date_Start.EditValue = gridView.GetFocusedRowCellValue(colDate_Start);
                xuc_Payroll.Date_End.EditValue = gridView.GetFocusedRowCellValue(colDate_End);
                xuc_Payroll.Payroll_Name.Text = gridView.GetFocusedRowCellDisplayText(colPayroll_Name);
                xuc_Payroll.Payroll_Description.Text = gridView.GetFocusedRowCellDisplayText(colPayroll_Description);
                xuc_Payroll.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
            }
        }

        private void Update_Data_Row()
        {
            gridView.SetFocusedRowCellValue(colCorporation, xuc_Payroll.Corporation.EditValue);
            gridView.SetFocusedRowCellValue(colBranch_Code, xuc_Payroll.Branch_Code.EditValue);
            gridView.SetFocusedRowCellValue(colDate_Start, xuc_Payroll.Date_Start.EditValue);
            gridView.SetFocusedRowCellValue(colDate_End, xuc_Payroll.Date_End.EditValue);
            gridView.SetFocusedRowCellValue(colPayroll_Name, xuc_Payroll.Payroll_Name.Text);
            gridView.SetFocusedRowCellValue(colPayroll_Description, xuc_Payroll.Payroll_Description.Text);
            gridView.SetFocusedRowCellValue(colNotes, xuc_Payroll.Notes.Text);
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (xuc_Settings.Toggle_Select.IsOn)
                Data_Show();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridView.DataRowCount > 0 & gridView.SelectedRowsCount > 0)
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

    }
}