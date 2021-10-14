using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary.Classes;

namespace SagaAssets.Controls
{
	public partial class xuc_Consumables : DevExpress.XtraEditors.XtraUserControl
	{
		public xuc_Consumables()
		{
			InitializeComponent();
		}

		private void gridView_MouseDown(object sender, MouseEventArgs e)
		{
			if (gridView.RowCount > 0 && e.Button.Equals(MouseButtons.Right))
			{
				popupMenu.ShowPopup(MousePosition);
			}
		}

		internal void control_Data_Load(string sAssetCode)
		{
			SqlParameter[] sqlParameter = new[] {
				new SqlParameter(@"Asset_Code", sAssetCode),
				new SqlParameter(@"Action_Type", "LOAD_STOCKS")
			};
			class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameter, gridControl, gridView, "inv_Asset_Procedures", "inv_Consumables");
		}

		private void btn_Add_Stocks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var frm = new Forms.frm_Stack_Consume();
			frm.ShowDialog();
		}

		private void btn_Consume_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var frm = new Forms.frm_Stack_Consume();
			frm.ShowDialog();
		}
	}
}
