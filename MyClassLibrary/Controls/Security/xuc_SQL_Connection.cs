using MyClassLibrary.Classes;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace MyClassLibrary.Controls.Security
{
	public partial class xuc_SQL_Connection : DevExpress.XtraEditors.XtraUserControl
	{
		public xuc_SQL_Connection()
		{
			InitializeComponent();
			btn_Download.Name = "btn_Download";
			Server_Name.Name = "Server_Name";
			Server_Type.Name = "Server_Type";
		}

		public bool connect_Server_Test()
		{
			class_Procedures.splash_Show("verifying connection parameters", "Establishing Connection", true);
			if (class_Database.OpenDB($"Data Source={Server_Name.Text.Trim()}; Initial Catalog={Database_Name.Text.Trim()}; Persist Security Info=True; Connect Timeout={Time_Out.Text.Trim()}; User ID={User_Name.Text.Trim()}; Password={Password.Text.Trim()}"))
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The connection to the server was successfully tested.");
				class_Procedures.splash_Close(true);
				return true;
			}
			else
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "The connection to the server was not successful. Please review and verify the connection parameters.", "Connection Error");
				class_Procedures.splash_Close(true);
				Server_Name.Select();
				return false;
			}
		}

		public bool connect_Server()
		{
			class_Procedures.splash_Show("saving connection parameters", "Establishing Connection", true);
			Registry_Save();
			class_Database.Initialize_Connection();
			if (class_Database.OpenDB(class_Database.ICSConnection))
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Info, class_Database.ICSConnectionTemp);
				class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The connection parameters were applied and successfully connected to the server.");
				class_Procedures.splash_Close(true);
				return true;
			}
			else
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"Server connection was not successful.{Environment.NewLine}Please review the connection parameters and test the connection again.");
				class_Procedures.splash_Close(true);
				return false;
			}
		}

		public void registry_Load()
		{
			class_Database.Initialize_Connection();
			try
			{
				Server_Type.Text = class_Tools.RegKeyGet("Server Connection", "Type", "LOCAL MACHINE");
				Remember_Password.IsOn = class_Tools.RegKeyGet("Server Connection", "Remember", false);
				Server_Name.Text = class_Database.SqlServer;
				Database_Name.Text = class_Database.SqlDatabase;
				User_Name.Text = class_Database.SqlUser;
				Password.Text = class_Database.SqlPassword;
				Time_Out.EditValue = class_Database.SqlTimeOut;
				Connection_String.Text = class_Database.ICSConnectionTemp;
				Update_Link.Text = class_Tools.RegKeyGet("Server Connection", "Update", class_Database.sUpdateLink);
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
			}
		}

		private void Registry_Save()
		{
			switch (Server_Type.Text ?? string.Empty)
			{
				case "LOCAL MACHINE":
					{
						class_Database.bIsLocal = true;
						class_Tools.RegKeySet("Server Connection", "isLocal", true);
						break;
					}

				case "BACKUP SERVER":
					{
						class_Database.bIsLocal = false;
						class_Tools.RegKeySet("Server Connection", "isLocal", false);
						class_Tools.RegKeySet("Server Connection", "Backup", class_Tools.Encrypt(Server_Name.Text));
						break;
					}

				case "LOCAL NETWORK":
					{
						class_Database.bIsLocal = false;
						class_Tools.RegKeySet("Server Connection", "isLocal", false);
						class_Tools.RegKeySet("Server Connection", "Local", class_Tools.Encrypt(Server_Name.Text));
						break;
					}

				case "REMOTE IP":
					{
						class_Database.bIsLocal = false;
						class_Tools.RegKeySet("Server Connection", "isLocal", false);
						class_Tools.RegKeySet("Server Connection", "Remote", class_Tools.Encrypt(Server_Name.Text));
						break;
					}
			}

			class_Tools.RegKeySet("Server Connection", "Type", Server_Type.Text);
			class_Tools.RegKeySet("Server Connection", "Server", class_Tools.Encrypt(Server_Name.Text.Trim()));
			class_Tools.RegKeySet("Server Connection", "Database", class_Tools.Encrypt(Database_Name.Text.Trim()));
			class_Tools.RegKeySet("Server Connection", "User Name", class_Tools.Encrypt(User_Name.Text.Trim()));
			class_Tools.RegKeySet("Server Connection", "Password", class_Tools.Encrypt(Password.Text.Trim()));
			class_Tools.RegKeySet("Server Connection", "Timeout", (int)Time_Out.Value);
			class_Tools.RegKeySet("Server Connection", "Remember", Remember_Password.IsOn);
			class_Tools.RegKeySet("Server Connection", "Update", Update_Link.Text.Trim());
		}

		private void Server_Name_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			switch (e.Button.Index)
			{
				case 0:
					{
						class_Connections.ping_Host(Server_Name.Text, false);
						break;
					}

				case 1:
					{
						class_Connections.ping_Host(Server_Name.Text, true);
						break;
					}
			}
		}

		private void Server_Type_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (Server_Type.Text ?? string.Empty)
			{
				case "LOCAL MACHINE":
					{
						class_Database.bIsLocal = true;
						Server_Name.Text = Environment.MachineName;
						break;
					}

				case "BACKUP SERVER":
					{
						class_Database.bIsLocal = false;
						Server_Name.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Backup", "127.0.0.1"), "127.0.0.1");
						break;
					}

				case "LOCAL NETWORK":
					{
						class_Database.bIsLocal = false;
						Server_Name.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Local", "localhost"), "localhost");
						break;
					}

				case "REMOTE IP":
					{
						class_Database.bIsLocal = false;
						Server_Name.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Remote", "127.0.0.1"), "127.0.0.1");
						break;
					}
			}

			Connection_String.Text = $"Data Source={class_Functions.maskString(Server_Name.Text.Trim(), 2, 2)};{Environment.NewLine} Initial Catalog={class_Functions.maskString(Database_Name.Text.Trim(), 0, 0)};{Environment.NewLine} Persist Security Info=True;{Environment.NewLine} Connect Timeout={Time_Out.Value};{Environment.NewLine} User ID={class_Functions.maskString(User_Name.Text.Trim(), 0, 0)};{Environment.NewLine} Password={class_Functions.maskString(Password.Text.Trim(), 0, 0)};";
		}

		private void download_Update(string sFileName)
		{
			Thread thread = new Thread(() =>
			{
				WebClient client = new WebClient();
				client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
				client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
				client.DownloadFileAsync(new Uri($"{sFileName}"), @$"{Application.StartupPath}\{Application.ProductName}.zip");
			});
			thread.Start();
		}

		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				double bytesIn = double.Parse(e.BytesReceived.ToString());
				double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
				double percentage = bytesIn / totalBytes * 100;

				label.Text = $"Downloaded {e.BytesReceived:N0} of {e.TotalBytesToReceive:N0} bytes";
				progressBarControl.Properties.ShowTitle = true;
				progressBarControl.EditValue = int.Parse(Math.Truncate(percentage).ToString());
			});
		}

		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				btn_Download.Enabled = true;
				Process.Start("explorer.exe", $"{Application.StartupPath}");
			});
		}

		private void Set_Update_Link()
		{
			if (toggle_Update_Type.IsOn)
			{
				Update_Link.Text = $"http://{class_Database.SqlServer}/AutoUpdate/{Application.ProductName}/{Application.ProductName}Full.zip";
			}
			else
			{
				Update_Link.Text = $"http://{class_Database.SqlServer}/AutoUpdate/{Application.ProductName}/{Application.ProductName}.zip";
			}
		}

		private void toggle_Update_Type_Toggled(object sender, EventArgs e)
		{
			Set_Update_Link();
		}

		private void btn_Default_Click(object sender, EventArgs e)
		{
			Set_Update_Link();
		}

		private void btn_Download_Click(object sender, EventArgs e)
		{
			btn_Download.Enabled = false;
			progressBarControl.Visible = true;
			download_Update($"{Update_Link.Text.Trim()}");
		}
	}
}