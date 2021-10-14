using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Leaves
    {
        public frm_Leaves()
        {
            if (xuc_Leave is null)
            {
                xuc_Leave = new Controls.xuc_Leave();
            }

            InitializeComponent();
            var BtnCancel = new SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Leave.layoutControl, xuc_Settings);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Leave.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Leaves_Load(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_Employee(repositoryItemLookUpEdit_Employee);
        }

        private void frm_Leaves_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Leave.Control_Initialize();
            
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load("LOAD");
        }

        private void frm_Leaves_FormClosing(object sender, FormClosingEventArgs e)
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
            xuc_Leave.Control_Initialize();
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
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "hr_Leave_Procedures", "hr_Leaves");
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
                xuc_Leave.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
                xuc_Leave.Leave_Code.Text = gridView.GetFocusedRowCellDisplayText(colLeave_Code);
                xuc_Leave.Employee_Code.EditValue = gridView.GetFocusedRowCellValue(colEmployee_Code);
                xuc_Leave.Leave_Category.Text = gridView.GetFocusedRowCellDisplayText(colLeave_Category);
                xuc_Leave.Leave_Type.EditValue = gridView.GetFocusedRowCellDisplayText(colLeave_Type);
                xuc_Leave.Date_Start.EditValue = gridView.GetFocusedRowCellValue(colDate_Start);
                xuc_Leave.Date_End.EditValue = gridView.GetFocusedRowCellValue(colDate_End);
                xuc_Leave.Leave_Days.Value = Convert.ToInt32(gridView.GetFocusedRowCellValue(colLeave_Days));
                xuc_Leave.Leave_Name.Text = gridView.GetFocusedRowCellDisplayText(colLeave_Name);
                xuc_Leave.Leave_Description.Text = gridView.GetFocusedRowCellDisplayText(colLeave_Description);
                xuc_Leave.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
            }
        }

        private void Update_Data_Row()
        {
            gridView.SetFocusedRowCellValue(colEmployee_Code, xuc_Leave.Employee_Code.EditValue);
            gridView.SetFocusedRowCellValue(colLeave_Category, xuc_Leave.Leave_Category.Text);
            gridView.SetFocusedRowCellValue(colLeave_Type, xuc_Leave.Leave_Type.Text);
            gridView.SetFocusedRowCellValue(colDate_Start, xuc_Leave.Date_Start.EditValue);
            gridView.SetFocusedRowCellValue(colDate_End, xuc_Leave.Date_End.EditValue);
            gridView.SetFocusedRowCellValue(colLeave_Days, xuc_Leave.Leave_Days.Value);
            gridView.SetFocusedRowCellValue(colLeave_Name, xuc_Leave.Leave_Name.Text);
            gridView.SetFocusedRowCellValue(colLeave_Description, xuc_Leave.Leave_Description.Text);
            gridView.SetFocusedRowCellValue(colNotes, xuc_Leave.Notes.Text);
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
                            xuc_Leave.Select();
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
                            xuc_Leave.Select();
                            break;
                        }

                    case "colEmployee_Code":
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
            xuc_Leave.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Leave.Control_Save())
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
            if (xuc_Leave.Control_Delete())
                gridView.DeleteRow(gridView.FocusedRowHandle);
        }
    }
}