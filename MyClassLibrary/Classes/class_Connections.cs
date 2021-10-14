using AutoUpdaterDotNET;
using DevExpress.Compression;
using DevExpress.XtraEditors;
using Ionic.Zip;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MyClassLibrary.Classes
{
	public static class class_Connections
	{
		public static bool bServerOnline;

		public static bool is_Network_Adapter_OK()
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				return true;
			}
			else if (class_Database.bIsLocal)
			{
				return true;
			}
			else
			{
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"You are not connected to the network or internet due to following reasons:{Environment.NewLine}Wireless/Local network adapter(s) is/are:{Environment.NewLine} - disabled,{Environment.NewLine} - not available,{Environment.NewLine} - not connected.{Environment.NewLine}Please fix the following:{Environment.NewLine} - enable/restart your wifi adapter,{Environment.NewLine} - reinsert/reconnect local Ethernet cable(s),{Environment.NewLine} - wireless/network Ethernet adapter driver(s),{Environment.NewLine} - check and verify database server parameters.");
				return false;
			}
		}

		public static string Get_IP_Internet()
		{
			if (is_Network_Adapter_OK())
			{
				var IP = new WebClient();
				try
				{
					return IP.DownloadString("http://bot.whatismyipaddress.com");
				}
				catch (Exception ex)
				{
					class_Procedures.Show_Error(ex);
				}
			}

			return null;
		}

		public static bool Initialize_IP(string sIP)
		{
			class_Procedures.splash_Show("Initializing IP addresses.");
			if (!is_Network_Adapter_OK())
				return false;
			if (check_Internet(sIP))
			{
				try
				{
					class_Variables.sLocal_IP = $"{new WebClient().DownloadString("https://api.ipify.org")}";
					return true;
				}
				catch (Exception ex)
				{
					class_Variables.sLocal_IP = Get_IP_Local();

					return class_Procedures.Show_Error(ex);
				}
				finally
				{
					class_Procedures.splash_Close();
				}
			}
			else
			{
				class_Variables.sLocal_IP = Get_IP_Local();
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"You are not connected to the internet. {Environment.NewLine}Please check your internet connection and verify database server parameters.");
				class_Procedures.splash_Close();
				return false;
			}
		}

		public static string Get_IP_Local()
		{
			if (!is_Network_Adapter_OK())
				return null;
			string sIP = string.Empty;
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var iP in host.AddressList)
			{
				if (iP.AddressFamily == AddressFamily.InterNetwork)
				{
					sIP = $"{sIP} {iP}";
				}
			}

			return sIP.Trim();
		}

		public static bool check_Internet(string sWebSite)
		{
			if (!is_Network_Adapter_OK())
				return false;
			Ping pinger = null;
			try
			{
				pinger = new Ping();
				//var reply = pinger.Send(sWebSite);
				//bool pingable = reply.Status == IPStatus.Success;
				return true;
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
				return false;
			}
			finally
			{
				if (pinger is object)
					pinger.Dispose();
			}
		}

		public static bool check_Host(string sHost)
		{
			if (!is_Network_Adapter_OK())
				return false;
			bool pingable = false;
			Ping pinger = null;

			try
			{
				class_Procedures.splash_Show($"Pinging {sHost}");
				pinger = new Ping();
				var reply = pinger.Send(sHost);
				pingable = reply.Status == IPStatus.Success;
				class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The host {sHost}{Environment.NewLine}is reachable or online");
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
				class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"The host is offline or you are not connected to internet. {Environment.NewLine}Please check the server host IP address or your internet connection.");
				pingable = false;
			}
			finally
			{
				if (pinger is object)
				{
					pinger.Dispose();
				}

				class_Procedures.splash_Close();
			}

			return pingable;
		}

		public static void ping_Host(string sHost, bool bContinous = false)
		{
			if (!is_Network_Adapter_OK())
				return;

			var proc = new ProcessStartInfo() { FileName = @"C:\windows\system32\cmd.exe" };

			proc.Arguments = bContinous ? $"/c ping -t {sHost}" : $"/c ping {sHost}";

			Process.Start(proc);
		}

		public static string get_IP_GEO(string IP)
		{
			if (!is_Network_Adapter_OK())
				return null;

			if (ReferenceEquals(IP, string.Empty))
				return null;

			try
			{
				class_Procedures.splash_Show(sDescription: "Getting IP Address Location", bForceShow: true);
				string url = $"http://api.ipstack.com/{IP}?access_key=8eb90a8f1db251c6642ab4cecabf8d13";
				var request = WebRequest.Create(url);
				using var wrs = request.GetResponse();
				var stream = wrs.GetResponseStream();
				using var reader = new StreamReader(stream);
				string json = reader.ReadToEnd();
				var obj = JObject.Parse(json);
				string sContinent = (string)obj["continent_name"];
				string sCountry = (string)obj["country_name"];
				string sRegion = (string)obj["region_name"];
				string sCity = (string)obj["city"];
				string sZIP = (string)obj["zip"];
				string sLatitude = (string)obj["latitude"];
				string sLongitude = (string)obj["longitude"];
				return $"Continent:{sContinent} Country:{sCountry} Region:{sRegion} City:{sCity} ZIP:{sZIP} Latitude:{sLatitude} Longitude:{sLongitude}";
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
				return null;
			}
			finally
			{ 
				class_Procedures.splash_Close();
			}
		}

		public static bool Upload_Update_File(string sAppName, string sAppExtension)
		{
			class_Procedures.splash_Show($"uploading {sAppName}.{sAppExtension} to FTP", "Uploading Update File", true);
			string miUri = $"ftp://{class_Database.SqlServer}/{sAppName}/{sAppName}.{sAppExtension}";
			FtpWebRequest miRequest = (FtpWebRequest)WebRequest.Create(miUri);
			miRequest.Credentials = new NetworkCredential(class_Database.SqlUser, class_Database.SqlUser);
			miRequest.Method = WebRequestMethods.Ftp.UploadFile;

			try
			{
				var bFile = File.ReadAllBytes($@"{Application.StartupPath}\{sAppName}.{sAppExtension}");
				var miStream = miRequest.GetRequestStream();
				miStream.Write(bFile, 0, bFile.Length);
				miStream.Close();
				miStream.Dispose();
				return true;
			}
			catch (Exception ex)
			{
				return class_Procedures.Show_Error(ex);
			}
			finally
			{
				class_Procedures.splash_Close(true);
			}
		}

		public static void Show_Update(bool bMandatory, bool bErrorReport = false, bool bBackup = false)
		{
			if (class_Database.bIsLocal)
				return;

			if (bBackup)
			{
				using (var zip = new ZipFile())
				{
					zip.AddFile($"{Application.ProductName}.exe");
					zip.Save($"{Application.ProductName}-{Application.ProductVersion}.zip");
				}
			}

			string sUpdatePath = $"{class_Database.sUpdateLink}{Application.ProductName}.xml";
			AutoUpdater.Start(sUpdatePath, System.Reflection.Assembly.GetEntryAssembly());
			AutoUpdater.AppTitle = Application.ProductName;
			AutoUpdater.Mandatory = bMandatory;
			AutoUpdater.ReportErrors = bErrorReport;
		}

		public static void Create_XML_Update(XtraForm xForm, bool bMandatory = false)
		{
			class_Procedures.splash_Show("Creating XML file for Update Package", "Creating XML", true);

			string sAppName = Application.ProductName;

			using (StreamWriter file = new StreamWriter($"{sAppName}.xml"))
			{
				file.WriteLine($"<?xml version='1.0' encoding='UTF-8'?>");
				file.WriteLine("<item>");
				file.WriteLine($"<version>{Application.ProductVersion}</version>");
				file.WriteLine($"<url>{class_Database.sUpdateLink}{sAppName}.zip</url>");
				file.WriteLine($"<changelog>{class_Database.sUpdateLink}Releases.txt</changelog>");
				file.WriteLine($"<mandatory>{bMandatory.ToString().ToLower()}</mandatory>");
				file.WriteLine("</item>");
				file.Close();
			}

			class_Procedures.splash_Close(true);
		}

		public static void Create_App_Backup(XtraForm frm, bool bDevExComponents, string[] sFiles)
		{
			string sAppName = Application.ProductName;

			class_Procedures.splash_Show("compressing files for update package", "Creating Update File", true);

			using (Stream myZippedStream = new FileStream($"{sAppName}.zip", FileMode.Create))
			{
				using (ZipArchive zipArchive = new ZipArchive())
				{
					zipArchive.AddFile($"{Application.ProductName}.exe");

					if (bDevExComponents)
					{
						System.IO.DirectoryInfo path = new System.IO.DirectoryInfo(Application.StartupPath);
						System.IO.FileInfo[] files = path.GetFiles("*.dll");

						foreach (System.IO.FileInfo file in files)
							zipArchive.AddFile(file.Name);
					}
					else
					{
						try
						{
							foreach (string file in sFiles)
								zipArchive.AddFile(file);
						}
						catch (Exception ex)
						{
							class_Procedures.Show_Error(ex);
						}
					}

					zipArchive.Save($"{sAppName}.zip");
					zipArchive.Save(myZippedStream);
				}
			}

			class_Procedures.splash_Close(true);

			if (class_Connections.Upload_Update_File(sAppName, "xml") && class_Connections.Upload_Update_File(sAppName, "zip"))
				class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The Update Package files has been successfully uploaded to the FTP Server.", "FTP Update Package", true);
			else
			{
				try
				{
					class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The files has been successfully compressed and saved to the Local Directory Folder.");
					Process.Start("explorer.exe", $"{Application.StartupPath}");
				}
				catch (Exception ex)
				{
					class_Procedures.Show_Error(ex);
				}
			}
		}
	}
}