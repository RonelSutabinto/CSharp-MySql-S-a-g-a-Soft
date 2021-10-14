namespace MyClassLibrary.Forms
{
	public partial class XtraForm1
	{
		public XtraForm1()
		{
			InitializeComponent();
		}

		private void AlertControl_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
		{
			Classes.class_Procedures.Copy_Clipboard(e.Info.Text);
		}
	}
}