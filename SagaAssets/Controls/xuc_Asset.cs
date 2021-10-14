using DevExpress.XtraEditors.Repository;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaAssets.Controls
{
    public partial class xuc_Asset : DevExpress.XtraEditors.XtraUserControl
    {
        public xuc_Asset()
        {
            InitializeComponent();

            btn_Inventory_Stack.Enabled = false;
            btn_Inventory_Consume.Enabled = false;
        }

        public void Control_Initialize()
        {
            class_Saga_Procedures.Initialize_Branch(Branch_Code);
            
            class_Saga_Variables.Initialize_Asset_Items();
            class_Saga_Procedures.Initialize_Asset_Items(Group_Code);

            class_Saga_Variables.Initialize_Employee();
            class_Saga_Procedures.Initialize_Employee(Current_Custodian);

            var repositoryLookUpEdit_Employee = new RepositoryItemLookUpEdit();
            class_Saga_Procedures.Initialize_Employee(repositoryLookUpEdit_Employee);
            colEmployee_Code_Custodian.ColumnEdit = repositoryLookUpEdit_Employee;

            class_Saga_Variables.Initialize_System_Requests();
            class_Saga_Variables.Initialize_Payment_Requests();
            class_Saga_Variables.Initialize_System_Transmittals();

            class_Database.Fill_Edit(class_Database.ICSConnection, Department, "inv_Asset_Items", "Department");
            class_Database.Fill_Edit(class_Database.ICSConnection, Category, "inv_Asset_Items", "Category");
            class_Database.Fill_Edit(class_Database.ICSConnection, Sub_Category, "inv_Asset_Items", "Sub_Category");
            class_Database.Fill_Edit(class_Database.ICSConnection, Asset_Type, "inv_Asset_Items", "Asset_Type");
            class_Database.Fill_Edit(class_Database.ICSConnection, Storage_Location, "inv_Asset_Items", "Storage_Location");
            class_Database.Fill_Edit(class_Database.ICSConnection, Asset_Condition, "inv_Asset_Items", "Asset_Condition");
            class_Database.Fill_Edit(class_Database.ICSConnection, Asset_Name, "inv_Asset_Items", "Asset_Name");
            class_Database.Fill_Edit(class_Database.ICSConnection, Made_In, "inv_Asset_Items", "Made_In");
            class_Database.Fill_Edit(class_Database.ICSConnection, Manufacturer, "inv_Asset_Items", "Manufacturer");
            class_Database.Fill_Edit(class_Database.ICSConnection, Brand, "inv_Asset_Items", "Brand");
            class_Database.Fill_Edit(class_Database.ICSConnection, Model, "inv_Asset_Items", "Model");
            class_Database.Fill_Edit(class_Database.ICSConnection, Color, "inv_Asset_Items", "Color");
            class_Database.Fill_Edit(class_Database.ICSConnection, Vendor_Name, "inv_Asset_Items", "Vendor_Name");
            class_Database.Fill_Edit(class_Database.ICSConnection, Asset_Status, "inv_Asset_Items", "Asset_Status");
            Department.Select();
        }

        public void Control_New(bool bClear = false)
        {
            if (bClear && !class_Procedures.actionAsk("New Asset Profile", "Initialize new Asset Profile", "You might lose unsaved data"))
                return;
            class_Procedures.Initialize_Controls(this, bClear);
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Asset_Code, "inv_Asset_Items", "Asset_Code", "ASSET-");
            Department.Select();
        }

        public bool Control_Retrieve(string sCode)
        {
            SqlParameter[] sqlParameters = new[] { 
                new SqlParameter("@Asset_Code", sCode), 
                new SqlParameter("@Action_Type", "RETRIEVE") 
            };
            using (var myDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures"))
            {
                if (myDataReader != null && myDataReader.HasRows)
                {
                    try
                    {
                        Asset_Code.Text = sCode;
                        myDataReader.Read();
                        ID.EditValue = myDataReader["ID"].ToString();
                        Branch_Code.EditValue = myDataReader["Branch_Code"].ToString();
                        Department.Text = myDataReader["Department"].ToString();
                        Category.Text = myDataReader["Category"].ToString();
                        Sub_Category.Text = myDataReader["Sub_Category"].ToString();
                        Storage_Location.Text = myDataReader["Storage_Location"].ToString();
                        Asset_Condition.Text = myDataReader["Asset_Condition"].ToString();
                        Asset_Name.Text = myDataReader["Asset_Name"].ToString();
                        Asset_Description.Text = myDataReader["Asset_Description"].ToString();
                        Made_In.Text = myDataReader["Made_In"].ToString();
                        Manufacturer.Text = myDataReader["Manufacturer"].ToString();
                        Brand.Text = myDataReader["Brand"].ToString();
                        Model.Text = myDataReader["Model"].ToString();
                        Color.Text = myDataReader["Color"].ToString();
                        Asset_Details.Text = myDataReader["Asset_Details"].ToString();
                        Vendor_Name.Text = myDataReader["Vendor_Name"].ToString();
                        Vendor_Description.Text = myDataReader["Vendor_Description"].ToString();
                        Purchased_Date.EditValue = myDataReader["Purchased_Date"];
                        Price_Value.Value = (decimal)myDataReader["Price_Value"];
                        Warranty_Date.EditValue = myDataReader["Warranty_Date"];
                        Current_Value.Value = (decimal)myDataReader["Current_Value"];
                        Current_Custodian.EditValue = myDataReader["Current_Custodian"].ToString();
                        Group_Code.EditValue = myDataReader["Group_Code"].ToString();
                        Asset_Type.Text = myDataReader["Asset_Type"].ToString();
                        Asset_Status.Text = myDataReader["Asset_Status"].ToString();
                        Notes.Text = myDataReader["Notes"].ToString();

                        System_Request_Code.EditValue = myDataReader["System_Request_Code"].ToString();
                        Payment_Request_Code.EditValue = myDataReader["Payment_Request_Code"].ToString();
                        Canvas_Code.EditValue = myDataReader["Canvas_Code"].ToString();
                        Liquiation_Code.EditValue = myDataReader["Liquiation_Code"].ToString();
                        Transmittal_Code.EditValue = myDataReader["Transmittal_Code"].ToString();

                        Control_Load_Bar_Codes(Asset_Code.Text);
                        Control_Load_Custodians(Asset_Code.Text);
                        Control_Load_Services(Asset_Code.Text);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return class_Procedures.Show_Error(ex);
                    }
                }
            }

            return false;
        }

        internal void Control_Load_Bar_Codes(string sAssetCode)
        {
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl_BarCodes, gridView_BarCodes, $"SELECT * FROM inv_Asset_Barcodes WHERE Asset_Code LIKE '{sAssetCode}' ORDER BY ID", "inv_Asset_Barcodes");
            class_Procedures.Initialize_gridView(gridView_BarCodes, true, true);
        }

        internal void Control_Load_Custodians(string sAssetCode)
        {
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl_Custodians, gridView_Custodians, $"SELECT * FROM inv_Asset_Custodians WHERE Asset_Code LIKE '{sAssetCode}' ORDER BY ID", "inv_Asset_Custodians");
            class_Procedures.Initialize_gridView(gridView_Custodians, true, true);
            colAssignment_Date.ColumnEdit = repositoryItemDateEdit;
        }

        internal void Control_Load_Services(string sAssetCode)
        { 
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl_Services, gridView_Services, $"SELECT ID, Ticket_Code, Ticket_Name, Ticket_Description, Added_Date, Closed_Date FROM acc_Tickets WHERE Asset_Code LIKE '{sAssetCode}' ORDER BY ID DESC", "acc_Tickets");
            class_Procedures.Initialize_gridView(gridView_Services);

        }

        internal bool Control_Save()
        {
            if (class_Procedures.isEmpty(Asset_Code)) return false;
            if (class_Procedures.isEmpty(Branch_Code)) return false;
            if (class_Procedures.isEmpty(Department)) return false;
            if (class_Procedures.isEmpty(Category)) return false;
            if (class_Procedures.isEmpty(Sub_Category)) return false;
            if (class_Procedures.isEmpty(Asset_Type)) return false;
            if (class_Procedures.isEmpty(Storage_Location)) return false;
            if (class_Procedures.isEmpty(Asset_Condition)) return false;
            if (class_Procedures.isEmpty(Asset_Name)) return false;

            if (ID.EditValue.Equals("0"))
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Asset_Code, "inv_Asset_Items", "Asset_Code", "ASSET-");

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue),
                new SqlParameter("@Asset_Code", Asset_Code.Text),
                new SqlParameter("@Branch_Code", Branch_Code.EditValue),
                new SqlParameter("@Department", Department.Text.Trim().ToUpper()),
                new SqlParameter("@Category", Category.Text.Trim().ToUpper()),
                new SqlParameter("@Sub_Category", Sub_Category.Text.Trim().ToUpper()),
                new SqlParameter("@Storage_Location", Storage_Location.Text.Trim().ToUpper()),
                new SqlParameter("@Asset_Condition", Asset_Condition.Text.Trim().ToUpper()),
                new SqlParameter("@Asset_Name", Asset_Name.Text.Trim()),
                new SqlParameter("@Asset_Description", Asset_Description.Text.Trim()),
                new SqlParameter("@Made_In", Made_In.Text.Trim().ToUpper()),
                new SqlParameter("@Manufacturer", Manufacturer.Text.Trim().ToUpper()),
                new SqlParameter("@Brand", Brand.Text.Trim().ToUpper()),
                new SqlParameter("@Model", Model.Text.Trim()),
                new SqlParameter("@Color", Color.Text.Trim().ToUpper()),
                new SqlParameter("@Asset_Details", Asset_Details.Text.Trim()),
                new SqlParameter("@Vendor_Name", Vendor_Name.Text.Trim().ToUpper()),
                new SqlParameter("@Vendor_Description", Vendor_Description.Text.Trim()),
                new SqlParameter("@Purchased_Date", Purchased_Date.EditValue),
                new SqlParameter("@Price_Value", Price_Value.Value),
                new SqlParameter("@Warranty_Date", Warranty_Date.EditValue),
                new SqlParameter("@Current_Value", Current_Value.Value),
                new SqlParameter("@System_Request_Code", System_Request_Code.EditValue),
                new SqlParameter("@Payment_Request_Code", Payment_Request_Code.EditValue),
                new SqlParameter("@Canvas_Code", Canvas_Code.EditValue),
                new SqlParameter("@Liquiation_Code", Liquiation_Code.EditValue),
                new SqlParameter("@Transmittal_Code", Transmittal_Code.EditValue),
                new SqlParameter("@Current_Custodian", Current_Custodian.EditValue),
                new SqlParameter("@Group_Code", Group_Code.EditValue),
                new SqlParameter("@Asset_Type", Asset_Type.Text.Trim().ToUpper()),
                new SqlParameter("@Asset_Status", Asset_Status.Text.Trim().ToUpper()),
                new SqlParameter("@Notes", Notes.Text.Trim()),
                new SqlParameter("@Added_By", class_Variables.sUserName),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Action_Type", "SAVE_ASSET")
            };

			switch (tabbedControlGroup.SelectedTabPageName)
			{
				case "layoutControlGroup_Bar_Codes":
                    Save_Bar_Codes();
                    break;

                case "layoutControlGroup_Custodians":
                    Save_Custodians();
                    break;
			}

            return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures", "Asset Profile", Asset_Name.Text.Trim());
        }

        private void Save_Bar_Codes()
        {
            if (gridView_BarCodes.DataRowCount > 0)
            {
                for (int i = 0, loopTo = gridView_BarCodes.DataRowCount - 1; i <= loopTo; i++)
                {
                    int iID;
                    try
                    {
                        if (gridView_BarCodes.GetRowCellValue(i, colID_Bar_Code).Equals(null))
                            return;
                        try
                        {
                            iID = Convert.ToInt32(gridView_BarCodes.GetRowCellValue(i, colID_Bar_Code));
                        }
                        catch (Exception)
                        {
                            iID = 0;
                        }

                        SqlParameter[] sqlParameters = new[] {
                            new SqlParameter("@ID", iID),
                            new SqlParameter("@Asset_Code", this.Asset_Code.Text),
                            new SqlParameter("@Bar_Code", gridView_BarCodes.GetRowCellValue(i, colBar_Code)),
                            new SqlParameter("@Bar_Code_Name", gridView_BarCodes.GetRowCellValue(i, colBar_Code_Name)),
                            new SqlParameter("@Bar_Code_Description", gridView_BarCodes.GetRowCellDisplayText(i, colBar_Code_Description)),
                            new SqlParameter("@Added_By", class_Variables.sUserName),
                            new SqlParameter("@Modified_By", class_Variables.sUserName),
                            new SqlParameter("@Action_Type", "SAVE_BAR_CODE")
                        };
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures", "Bar Code");
                    }
                    catch (Exception ex)
                    {
                        class_Procedures.Show_Error(ex);
                    }
                }

                Control_Load_Bar_Codes(Asset_Code.EditValue.ToString());
            }
        }

        private void Save_Custodians()
        {
            if (gridView_Custodians.DataRowCount > 0)
            {
                for (int i = 0, loopTo = gridView_Custodians.DataRowCount - 1; i <= loopTo; i++)
                {
                    int iID;
                    try
                    {
                        if (gridView_Custodians.GetRowCellValue(i, colEmployee_Code_Custodian).Equals(null))
                            return;
                        try
                        {
                            iID = Convert.ToInt32(gridView_Custodians.GetRowCellValue(i, colID_Custodian));
                        }
                        catch (Exception)
                        {
                            iID = 0;
                        }

                        SqlParameter[] sqlParameters = new[] {
                            new SqlParameter("@ID", iID),
                            new SqlParameter("@Asset_Code", this.Asset_Code.Text),
                            new SqlParameter("@Employee_Code", gridView_Custodians.GetRowCellValue(i, colEmployee_Code_Custodian)),
                            new SqlParameter("@Assignment_Date", gridView_Custodians.GetRowCellValue(i, colAssignment_Date)),
                            new SqlParameter("@Assignment_Description", gridView_Custodians.GetRowCellDisplayText(i, colAssignment_Description)),
                            new SqlParameter("@Notes", gridView_Custodians.GetRowCellDisplayText(i, colNotes_Custodian)),
                            new SqlParameter("@Added_By", class_Variables.sUserName),
                            new SqlParameter("@Modified_By", class_Variables.sUserName),
                            new SqlParameter("@Action_Type", "SAVE_CUSTODIAN")
                        };
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures", "Custodian");
                    }
                    catch (Exception ex)
                    {
                        class_Procedures.Show_Error(ex);
                    }
                }
                
                Control_Load_Custodians(Asset_Code.EditValue.ToString());
            }
        }

        internal void Control_Preview()
        {
            var xrpt_Asset = new SagaAssets.Reports.xrpt_Asset_Item();
            class_Database.Bind_Report(class_Database.ICSConnection, xrpt_Asset, $"SELECT * FROM inv_Asset_Items WHERE Asset_Code LIKE '{Asset_Code.Text}'", "inv_Asset_Items");

            try
            {
                xrpt_Asset.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                xrpt_Asset.PageWidth = 850;
                xrpt_Asset.PageHeight = 1100;

                xrpt_Asset.Current_Custodian.Text = Current_Custodian.Text;

                xrpt_Asset.Product_Version.Text = $"{class_Functions.Product_Name_Version()} - IT Department";
            }
            catch (Exception ex)
            {
                class_Procedures.Show_Error(ex);
            }
        }

        internal bool Control_Delete()
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@ID", ID.EditValue), 
                new SqlParameter("@Action_Type", "DELETE") 
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures", "Delete Asset Profile", true));
        }

        private void gridView_BarCodes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks.Equals(2))
            {
                gridView_BarCodes.OptionsBehavior.Editable = true;
            }
        }

        private void Group_Code_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    Group_Code.EditValue = string.Empty;
                    break;
            }
        }

        private void Current_Custodian_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    Current_Custodian.EditValue = string.Empty;
                    break;

                case 2:
                    SqlParameter[] sqlParameters = new[] {
                        new SqlParameter("@Asset_Code", Asset_Code.EditValue),
                        new SqlParameter("@Employee_Code", Current_Custodian.EditValue),
                        new SqlParameter("@Added_By", class_Variables.sUserName),
                        new SqlParameter("@Action_Type", "INSERT_CUSTODIAN")
                    };
                    class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Asset_Procedures", "Insert Custodian", Current_Custodian.Text);
                    Control_Load_Custodians(Asset_Code.EditValue.ToString());
                    break;
            }
        }

        private void Is_Consumable_Toggled(object sender, EventArgs e)
        {
            btn_Inventory_Stack.Enabled = Is_Consumable.IsOn;
            btn_Inventory_Consume.Enabled = Is_Consumable.IsOn;
        }

        private void btn_Inventory_Stack_Click(object sender, EventArgs e)
		{
            var frm = new SagaAssets.Forms.frm_Stack_Consume();
            frm.xuc_Stack_Consume.Entry_Type.EditValue = "STACK";
            frm.Show();
		}

		private void btn_Inventory_Consume_Click(object sender, EventArgs e)
		{
            var frm = new SagaAssets.Forms.frm_Stack_Consume();
            frm.xuc_Stack_Consume.Entry_Type.EditValue = "CONSUME";
            frm.Show();
        }

		
	}
}
