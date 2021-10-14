﻿using DevExpress.XtraSplashScreen;
using System;

namespace MyClassLibrary.Forms
{
	public partial class SplashScreen1 : SplashScreen
	{
		public SplashScreen1()
		{
			InitializeComponent();
			this.labelCopyright.Text = $"Copyright © 1998-{DateTime.Now.Year}";
		}

		#region Overrides

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion Overrides

		public enum SplashScreenCommand
		{
		}
	}
}