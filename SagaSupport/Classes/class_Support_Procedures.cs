
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using MyClassLibrary.Classes;

namespace SagaSupport.Classes
{
	public static class class_Support_Procedures
	{
        public static void Initialize_Ticket_Groups(TreeListLookUpEdit ticketGroup, TreeList treeList)
        {
            ticketGroup.Properties.DisplayMember = "Ticket_Group_Sub";
            ticketGroup.Properties.TreeList = treeList;
            ticketGroup.Properties.ValueMember = "Ticket_Group_Sub";

            treeList.KeyFieldName = "Ticket_Group_Sub";
            treeList.ParentFieldName = "Ticket_Group";

            class_Database.Bind_Data(class_Database.ICSConnection, ticketGroup, "SELECT Ticket_Group, Ticket_Group_Sub, Ticket_Description, Notes FROM acc_Ticket_Groups", "acc_Ticket_Groups");
        }

        internal static void Initialize_Assets(LookUpEdit lue)
        {
            string sQuery = "SELECT ASS.ID AS ID, " +
                                "ASS.Asset_Code AS Asset_Code, " +
                                "BRN.Branch_Local AS Branch_Local, " +
                                "ASS.Department AS Department, " +
                                "ASS.Category AS Category, " +
                                "ASS.Sub_Category AS Sub_Category, " +
                                "ASS.Asset_Name AS Asset_Name, " +
                                "ASS.Asset_Description AS Asset_Description " +
                            "FROM inv_Asset_Items AS ASS " +
                                "LEFT JOIN BranchParameters AS BRN " +
                                    "ON ASS.Branch_Code = BRN.BranchCode";
            
            class_Database.Bind_Data(class_Database.ICSConnection, lue, sQuery, "inv_Asset_Items");

            lue.Properties.Columns.Clear();
            lue.Properties.Columns.AddRange(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { 
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"), 
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Code", "Code"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Branch_Local", "Branch"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sub_Category"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Name", "Asset Name"),
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asset_Description", "Description") });

            lue.Properties.DisplayMember = "Asset_Name";
            lue.Properties.ValueMember = "Asset_Code";
            lue.Properties.NullValuePrompt = "Select Asset Inventory...";
			lue.Properties.BestFit();
		}
    }
}