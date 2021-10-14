using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace SagaHR.Forms
{
    public partial class frm_Adjustments
    {
        public frm_Adjustments()
        {
            if (xuc_Adjustment is null)
            {
                xuc_Adjustment = new Controls.xuc_Adjustment();
            }

            InitializeComponent();
            var BtnCancel = new SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, DockManager, gridView, BtnCancel, xuc_Adjustment.layoutControl, xuc_Settings);
            SagaClassLibrary.Classes.class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
        }

        private bool Form_Close()
        {
            return class_Procedures.Form_Close(this, barManager, DockManager, gridView, xuc_Adjustment.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private void frm_Adjustments_Load(object sender, EventArgs e)
        {
            class_Saga_Variables.Initialize_COA();
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA_Code, class_Saga_Variables.eCOA_Type.COA_All);
        }

        private void frm_Adjustments_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Adjustment.Control_Initialize();
            
            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load("LOAD");
        }

        private void frm_Adjustments_FormClosing(object sender, FormClosingEventArgs e)
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
            xuc_Adjustment.Control_Initialize();
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
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "hr_Adjustment_Procedures", "hr_Adjustments");
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
                xuc_Adjustment.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
                xuc_Adjustment.Adjust_Code.Text = gridView.GetFocusedRowCellDisplayText(colAdjust_Code);
                xuc_Adjustment.Adjust_Category.Text = gridView.GetFocusedRowCellDisplayText(colAdjust_Category);
                xuc_Adjustment.Adjust_Type.EditValue = gridView.GetFocusedRowCellDisplayText(colAdjust_Type);
                xuc_Adjustment.Is_15th.EditValue = gridView.GetFocusedRowCellValue(colIs_15th);
                xuc_Adjustment.Is_30th.EditValue = gridView.GetFocusedRowCellValue(colIs_30th);
                xuc_Adjustment.COA_Code.EditValue = gridView.GetFocusedRowCellValue(colCOA_Code);
                xuc_Adjustment.Adjust_Name.Text = gridView.GetFocusedRowCellDisplayText(colAdjust_Name);
                xuc_Adjustment.Amount.Value = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colAmount));
                xuc_Adjustment.Adjust_Description.Text = gridView.GetFocusedRowCellDisplayText(colAdjust_Description);
                xuc_Adjustment.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);
            }
        }

        private void Update_Data_Row()
        {
            gridView.SetFocusedRowCellValue(colAdjust_Category, xuc_Adjustment.Adjust_Category.Text);
            gridView.SetFocusedRowCellValue(colAdjust_Type, xuc_Adjustment.Adjust_Type.Text);
            gridView.SetFocusedRowCellValue(colIs_15th, xuc_Adjustment.Is_15th.EditValue);
            gridView.SetFocusedRowCellValue(colIs_30th, xuc_Adjustment.Is_30th.EditValue);
            gridView.SetFocusedRowCellValue(colCOA_Code, xuc_Adjustment.COA_Code.EditValue);
            gridView.SetFocusedRowCellValue(colAdjust_Name, xuc_Adjustment.Adjust_Name.Text);
            gridView.SetFocusedRowCellValue(colAmount, xuc_Adjustment.Amount.Value);
            gridView.SetFocusedRowCellValue(colAdjust_Description, xuc_Adjustment.Adjust_Description.Text);
            gridView.SetFocusedRowCellValue(colNotes, xuc_Adjustment.Notes.Text);
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
                            xuc_Adjustment.Select();
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
                            xuc_Adjustment.Select();
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
            xuc_Adjustment.Control_New(true, xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Adjustment.Control_Save())
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
            if (xuc_Adjustment.Control_Delete())
                gridView.DeleteRow(gridView.FocusedRowHandle);
        }
    }
}