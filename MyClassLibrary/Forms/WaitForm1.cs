using System;

namespace MyClassLibrary.Forms
{
	public partial class WaitForm1
	{
		public WaitForm1()
		{
			InitializeComponent();
			progressPanel.AutoHeight = true;
		}

		public override void SetCaption(string caption)
		{
			base.SetCaption(caption);
			progressPanel.Caption = caption;
		}

		public override void SetDescription(string description)
		{
			base.SetDescription(description);
			progressPanel.Description = description;
		}

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}
	}
}