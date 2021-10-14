using DevExpress.XtraEditors;
using MyClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SagaSupport.Classes;

namespace SagaSupport.Forms
{
	public partial class frm_Editor : DevExpress.XtraEditors.XtraForm
	{
		public frm_Editor()
		{
			InitializeComponent();

			var BtnCancel = new SimpleButton();
			BtnCancel.Click += BtnCancel_Click;

			var BtnOK = new SimpleButton();
			BtnCancel.Click += BtnOK_Click;

			this.AcceptButton = BtnOK;

			class_Procedures.Initialize_Form(this, BtnCancel);
		}

		private bool Form_Close()
		{
			if (class_Procedures.actionAsk("Editor Update", "update current edit", "You might lose your unsaved edit"))
			{
				class_Support_Variables.editorText = Solution.RtfText;
				//class_Support_Variables.richEditViewType = Solution.ActiveViewType;
			}

			ribbonControl.SaveLayoutToXml(this.Name);

			return class_Procedures.Form_Close(this, true);
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			Form_Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Form_Close();
		}

		private void frm_Help_Load(object sender, EventArgs e)
		{
			try
			{
				ribbonControl.RestoreLayoutFromXml(this.Name);
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
			}
		}

		private void frm_Help_Shown(object sender, EventArgs e)
		{
			
		}

		private void frm_Help_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Form_Close())
				e.Cancel = true;
		}
	}
}