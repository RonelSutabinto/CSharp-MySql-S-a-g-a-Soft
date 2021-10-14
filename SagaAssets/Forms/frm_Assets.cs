using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SagaAssets.Forms
{
    public partial class frm_Assets
    {
        public frm_Assets()
        {
            InitializeComponent();

            if (xuc_Asset is null)
            {
                xuc_Asset = new Controls.xuc_Asset();
            }

            var BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            BtnCancel.Click += BtnCancel_Click;
            class_Procedures.Initialize_Form(this, dockManager, gridView, BtnCancel, xuc_Asset.layoutControl, xuc_Settings);
            class_Saga_Procedures.Initialize_BarManager(this, barManager, xuc_Settings);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form_Close();
        }

        private bool Form_Close()
        {
            xuc_Asset.gridView_BarCodes.SaveLayoutToRegistry(xuc_Asset.gridView_BarCodes.Name);
            xuc_Asset.gridView_Custodians.SaveLayoutToRegistry(xuc_Asset.gridView_Custodians.Name);
            xuc_Asset.gridView_Services.SaveLayoutToRegistry(xuc_Asset.gridView_Services.Name);

            return class_Procedures.Form_Close(this, barManager, dockManager, gridView, xuc_Asset.layoutControl, xuc_Settings, Control.ModifierKeys == Keys.Shift, true);
        }

        private void frm_Assets_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Form_Close())
                e.Cancel = true;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Close();
        }

        private void frm_Assets_Load(object sender, EventArgs e)
        {
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch);

            class_Saga_Procedures.Initialize_Asset_Items(repositoryItemLookUpEdit_Asset_Items);

            class_Saga_Variables.Initialize_Employee();
            class_Saga_Procedures.Initialize_Employee(repositoryItemLookUpEdit_Employees);

            xuc_Asset.gridView_BarCodes.RestoreLayoutFromRegistry(xuc_Asset.gridView_BarCodes.Name);
            xuc_Asset.gridView_Custodians.RestoreLayoutFromRegistry(xuc_Asset.gridView_Custodians.Name);
            xuc_Asset.gridView_Services.RestoreLayoutFromRegistry(xuc_Asset.gridView_Services.Name);
        }

        private void frm_Assets_Shown(object sender, EventArgs e)
        {
            if (xuc_Settings.Toggle_Auto_Initialize.IsOn)
                xuc_Asset.Control_Initialize();

            if (xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Initialize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_Initialize();
        }

        private void Data_Load()
        {
            try
            {
                SqlParameter[] sqlParameters = new[] { new SqlParameter("@Action_Type", "LOAD_ASSETS") };
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Asset_Procedures", "Asset Items");
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
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

        private void btn_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn);
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (xuc_Asset.Control_Save() && xuc_Settings.Toggle_Auto_Reload.IsOn)
                Data_Load();
        }

        private void btn_Preview_Asset_Item_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_Preview();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuc_Asset.Control_Delete();
        }

        private void Data_Show()
        {
            try
            {
                xuc_Asset.ID.EditValue = gridView.GetFocusedRowCellValue(colID);
                xuc_Asset.Asset_Code.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Code);
                xuc_Asset.Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code);
                xuc_Asset.Department.Text = gridView.GetFocusedRowCellDisplayText(colDepartment);
                xuc_Asset.Category.Text = gridView.GetFocusedRowCellDisplayText(colCategory);
                xuc_Asset.Sub_Category.Text = gridView.GetFocusedRowCellDisplayText(colSub_Category);
                xuc_Asset.Storage_Location.Text = gridView.GetFocusedRowCellDisplayText(colStorage_Location);
                xuc_Asset.Asset_Condition.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Condition);
                xuc_Asset.Asset_Name.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Name);
                xuc_Asset.Asset_Description.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Description);
                xuc_Asset.Made_In.Text = gridView.GetFocusedRowCellDisplayText(colMade_In);
                xuc_Asset.Manufacturer.Text = gridView.GetFocusedRowCellDisplayText(colManufacturer);
                xuc_Asset.Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand);
                xuc_Asset.Model.Text = gridView.GetFocusedRowCellDisplayText(colModel);
                xuc_Asset.Color.Text = gridView.GetFocusedRowCellDisplayText(colColor);
                xuc_Asset.Asset_Details.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Details);
                xuc_Asset.Vendor_Name.Text = gridView.GetFocusedRowCellDisplayText(colVendor_Name);
                xuc_Asset.Vendor_Description.Text = gridView.GetFocusedRowCellDisplayText(colVendor_Description);
                xuc_Asset.Purchased_Date.EditValue = gridView.GetFocusedRowCellValue(colPurchased_Date);
                xuc_Asset.Price_Value.Value = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colPrice_Value));
                xuc_Asset.Warranty_Date.EditValue = gridView.GetFocusedRowCellValue(colWarranty_Date);
                xuc_Asset.Current_Custodian.EditValue = gridView.GetFocusedRowCellValue(colCurrent_Custodian);
                xuc_Asset.Group_Code.EditValue = gridView.GetFocusedRowCellValue(colGroup_Code);
                xuc_Asset.Asset_Type.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Type);
                xuc_Asset.Asset_Status.Text = gridView.GetFocusedRowCellDisplayText(colAsset_Status);
                xuc_Asset.Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes);

                xuc_Asset.Current_Value.Value = (decimal)gridView.GetFocusedRowCellValue(colCurrent_Value);
            
                xuc_Asset.System_Request_Code.EditValue = gridView.GetFocusedRowCellValue(colSystem_Request_Code);
                xuc_Asset.Payment_Request_Code.EditValue = gridView.GetFocusedRowCellValue(colPayment_Request_Code);
                xuc_Asset.Canvas_Code.EditValue = gridView.GetFocusedRowCellValue(colCanvas_Code);
                xuc_Asset.Liquiation_Code.EditValue = gridView.GetFocusedRowCellValue(colLiquiation_Code);
                xuc_Asset.Transmittal_Code.EditValue = gridView.GetFocusedRowCellValue(colTransmittal_Code);
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
            finally
            {
                xuc_Asset.Control_Load_Bar_Codes(gridView.GetFocusedRowCellDisplayText(colAsset_Code));
                xuc_Asset.Control_Load_Custodians(gridView.GetFocusedRowCellDisplayText(colAsset_Code));
                xuc_Asset.Control_Load_Services(gridView.GetFocusedRowCellDisplayText(colAsset_Code));
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
                            if (xuc_Asset.Control_Delete())
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
            //if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
            //{
            //    btn_Ticket_Open.Enabled = !Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
            //    btn_Ticket_Close.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
            //    btn_Ticket_Approve.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsClosed));
            //    btn_Progress_Add.Enabled = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsOpened));
            //    PopupMenu.ShowPopup(MousePosition);
            //}
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2) && gridView.DataRowCount > 0)
            {
                switch (e.Column.FieldName)
                {
                    case "Ticket_Code":
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


    }
}