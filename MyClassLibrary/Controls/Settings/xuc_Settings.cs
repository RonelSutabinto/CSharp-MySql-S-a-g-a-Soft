using DevExpress.XtraEditors;

namespace MyClassLibrary.Controls.Settings
{
	public partial class xuc_Settings : XtraUserControl
	{
		public xuc_Settings()
		{
			InitializeComponent();
		}

		private void Toggle_Accept_Tab_Return_Toggled(object sender, System.EventArgs e)
		{
			MemoEdit_Notes.Properties.AcceptsTab = Toggle_Accept_Tab_Return.IsOn;
			MemoEdit_Notes.Properties.AcceptsReturn = Toggle_Accept_Tab_Return.IsOn;
		}
	}
}