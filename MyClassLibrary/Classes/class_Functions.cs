using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyClassLibrary.Classes
{
	public static class class_Functions
	{
		public enum PasswordScore
		{
			Blank,
			VeryWeak,
			Weak,
			Medium,
			Strong,
			VeryStrong
		}

		public static PasswordScore CheckPasswordStrength(string password)
		{
			int N = 0;
			int L = password.Length;
			if (L == 0)
				return PasswordScore.Blank;
			if (Regex.IsMatch(password, @"[\d]", RegexOptions.ECMAScript))
				N += 10;
			if (Regex.IsMatch(password, "[a-z]", RegexOptions.ECMAScript))
				N += 26;
			if (Regex.IsMatch(password, "[A-Z]", RegexOptions.ECMAScript))
				N += 26;
			if (Regex.IsMatch(password, @"[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript) && password.Length > 8)
				N += 33;
			int H;
			try
			{
				H = Convert.ToInt32(L * Math.Round(Math.Log(N) / Math.Log(2d)));
			}
			catch (Exception ex)
			{
				H = 0;
				class_Procedures.Show_Error(ex);
			}

			if (H <= 32)
				return PasswordScore.VeryWeak;
			if (H <= 48)
				return PasswordScore.Weak;
			if (H <= 64)
				return PasswordScore.Medium;
			if (H <= 80)
				return PasswordScore.Strong;
			return PasswordScore.VeryStrong;
		}

		public static string Product_Name_Version()
		{
			return $"{Application.ProductName} {Application.ProductVersion}™ {DateTime.Today.Year}";
		}

		public static string AutoID(string sPreCode)
		{
			return $"{sPreCode}{DateTime.Now:yyyyMMddHHmmssfff}";
		}

		public static DateTime FirstDayOfMonth(DateTime value)
		{
			return new DateTime(value.Year, value.Month, 1);
		}

		public static int DaysInMonth(this DateTime value)
		{
			return DateTime.DaysInMonth(value.Year, value.Month);
		}

		public static DateTime LastDayOfMonth(this DateTime value)
		{
			return new DateTime(value.Year, value.Month, value.DaysInMonth());
		}

		public static int GetMonthDifference(DateTime startDate, DateTime endDate)
		{
			return Math.Abs(12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month);
		}

		public static DateTime Next_Working_Date(DateTime dt, bool bShiftPressed = false)
		{
			int i;

			i = bShiftPressed ? -1 : 1;

			dt = dt.AddDays(i);
			if (dt.DayOfWeek.Equals(DayOfWeek.Sunday))
			{
				dt = dt.AddDays(i);
			}

			return dt;
		}

		public static int WorkingDays(DateTime dtDateFrom, DateTime dtDateTo)
		{
			int _elapsedDays = 0;
			var _weekendDays = new[] { DayOfWeek.Sunday };
			for (int i = 0, loopTo = (dtDateTo - dtDateFrom).Days; i <= loopTo; i++)
			{
				if (!_weekendDays.Contains(dtDateFrom.AddDays(i).DayOfWeek))
					_elapsedDays += 1;
			}

			return _elapsedDays;
		}

		public static DateTime WorkingDays(DateTime dtDateFrom, int iDAys)
		{
			var _elapsedDate = dtDateFrom;
			var _weekendDays = new[] { DayOfWeek.Saturday, DayOfWeek.Sunday };
			if (iDAys > 0)
			{
				for (int i = 0, loopTo = iDAys - 1; i <= loopTo; i++)
				{
					_elapsedDate = _elapsedDate.AddDays(1d);
					if (_weekendDays.Contains(_elapsedDate.DayOfWeek))
					{
						i -= 1;
					}
				}
			}

			return _elapsedDate;
		}

		public static string Generate_ID(string sCode, int iZeros)
		{
			return Convert.ToInt32(sCode.Remove(0, sCode.Length - iZeros)).ToString();
		}

		public static string Generate_ID(string sPreCode, int iZeros, int iCode)
		{
			string sTmpCode, sCode;
			int iLength = iCode.ToString().Length;
			if (iLength > iZeros)
				iZeros = iLength;
			string sZeros = new string('0', iZeros);
			sTmpCode = $"{sPreCode}{sZeros}";
			sCode = sTmpCode.Remove(sTmpCode.Length - iLength);
			return sCode.Insert(sTmpCode.Length - iLength, iCode.ToString());
		}

		public static string Code_Increment(string sCode, int iCount)
		{
			if (sCode.Equals(string.Empty))
				return string.Empty;
			int iValueNew = Convert.ToInt32(sCode.Remove(0, sCode.Length - iCount)) + 1;
			return $"{sCode.Remove(sCode.Length - iValueNew.ToString().Length)}{iValueNew}";
		}

		public static double calculate_VAT(double dAmount)
		{
			return Math.Round(dAmount / 1.12 * 0.12, 2);
		}

		public static double calculate_no_VAT(double dAmount)
		{
			return Math.Round(dAmount - dAmount / 1.12 * 0.12, 2);
		}

		public static decimal Percent(decimal dAmount, decimal dRate)
		{
			//return dAmount * dRate / 100 - dAmount;
			//return (dAmount * dRate) - dAmount;
			return (dAmount * dRate);
		}

		public static string maskString(string s, int iUnMaskLeft, int iUnMaskRight)
		{
			string sReturn = null;
			try
			{
				string firstPart = s.Substring(0, iUnMaskLeft);
				int len = s.Length;
				string lastPart = s.Substring(len - iUnMaskRight, iUnMaskRight);
				int middlePartLenght = len - (firstPart.Length + lastPart.Length);
				string middlePart = new string('•', middlePartLenght);
				sReturn = $"{firstPart}{middlePart}{lastPart}";
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
			}

			return sReturn;
		}

		public static string AmountToWords(Decimal dNumber, bool bCurrency = true)
		{
			if (dNumber <= 0) return null;

			string sNumberSet = Strings.Trim(dNumber.ToString());
			var sAmount = sNumberSet.Split(new char[] { '.' });
			string sPesos = sAmount[0];
			string sCents = null;
			try
			{
				sCents = Strings.Left(sAmount[1], 2);
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex, "Looks like your Amount has no point value.", string.Empty, "Amount in Words"); //Please make sure that the [Amount in Words] are specified
			}

			try
			{
				if (Convert.ToInt32(sCents) > 0)
				{
					if (bCurrency)
						return $"{NumberToText(Convert.ToInt32(sPesos)).Trim()} Pesos and {NumberToText(Convert.ToInt32(sCents))} Cents Only";
					else
						return $"{NumberToText(Convert.ToInt32(sPesos)).Trim()} point {NumberToText(Convert.ToInt32(sCents))}";
				}
				else
				{
					if (bCurrency)
						return $"{NumberToText(Convert.ToInt32(sPesos)).Trim()} Pesos Only";
					else
						return $"{NumberToText(Convert.ToInt32(sPesos)).Trim()}";
				}
			}
			catch (Exception ex)
			{
				class_Procedures.Show_Error(ex);
			}

			return null;
		}

		private static string NumberToText(int n)
		{
			switch (n)
			{
				case 0:
					{
						return string.Empty;
					}

				case var @case when 1 <= @case && @case <= 19:
					{
						var arr = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
						return $"{arr[n - 1]}";
					}

				case var case1 when 20 <= case1 && case1 <= 99:
					{
						var arr = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
						return $"{arr[n / 10 - 2]} {NumberToText(n % 10)}";
					}

				case var case2 when 100 <= case2 && case2 <= 199:
					{
						return $"One Hundred {NumberToText(n % 100)}";
					}

				case var case3 when 200 <= case3 && case3 <= 999:
					{
						return $"{NumberToText(n / 100)} Hundred {NumberToText(n % 100)}";
					}

				case var case4 when 1000 <= case4 && case4 <= 1999:
					{
						return $"One Thousand {NumberToText(n % 1000)}";
					}

				case var case5 when 2000 <= case5 && case5 <= 999999:
					{
						return $"{NumberToText(n / 1000)} Thousand {NumberToText(n % 1000)}";
					}

				case var case6 when 1000000 <= case6 && case6 <= 1999999:
					{
						return $"One Million {NumberToText(n % 1000000)}";
					}

				case var case7 when 1000000 <= case7 && case7 <= 999999999:
					{
						return $"{NumberToText(n / 1000000)} Million {NumberToText(n % 1000000)}";
					}

				case var case8 when 1000000000 <= case8 && case8 <= 1999999999:
					{
						return $"One Billion {NumberToText(n % 1000000000)}";
					}

				default:
					{
						return $"{NumberToText(n / 1000000000)} Billion {NumberToText(n % 1000000000)}";
					}
			}
		}

		public static string GetOrdinal(int num)
		{
			switch (num % 100)
			{
				case 11:
				case 12:
				case 13:
					{
						return "th";
					}
			}

			switch (num % 10)
			{
				case 1:
					{
						return "st";
					}

				case 2:
					{
						return "nd";
					}

				case 3:
					{
						return "rd";
					}

				default:
					{
						return "th";
					}
			}
		}

		public static bool IsUpperCase(string input)
		{
			for (int i = 0, loopTo = input.Length - 1; i <= loopTo; i++)
			{
				if (string.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), false) != 0)
					return false;
			}

			return true;
		}

		private static void Args_Showing(object sender, XtraMessageShowingArgs e)
		{
			// e.Form.Icon = XtraForm1.Icon
		}

		public static string Show_Input_Box(string sPrompt, string sCaption, string dDefaultResponse)
		{
			string sResult = string.Empty;
			var args = new XtraInputBoxArgs();
			args.Showing += Args_Showing;
			args.Caption = sCaption;
			args.Prompt = sPrompt;
			args.DefaultButtonIndex = 0;
			args.DefaultResponse = dDefaultResponse;
			try
			{
				sResult = XtraInputBox.Show(args).ToString();
			}
			catch (Exception)
			{
				return string.Empty;
			}

			class_Procedures.Copy_Clipboard(sResult);
			return sResult;
		}

		public static DateTime Show_Input_Box(string sPrompt, string sCaption, DateTime dDefaultResponse)
		{
			var args = new XtraInputBoxArgs();
			args.Showing += Args_Showing;
			args.Caption = sCaption;
			args.Prompt = sPrompt;
			args.DefaultButtonIndex = 0;
			var editor = new DateEdit();
			editor.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
			editor.Properties.Mask.EditMask = "MMMM dd, yyyy";
			args.Editor = editor;
			args.DefaultResponse = dDefaultResponse;
			return Convert.ToDateTime(XtraInputBox.Show(args));
		}

		public static int Show_Input_Box(string sPrompt, string sCaption, int dDefaultResponse)
		{
			var args = new XtraInputBoxArgs();
			args.Showing += Args_Showing;
			args.Caption = sCaption;
			args.Prompt = sPrompt;
			args.DefaultButtonIndex = 0;
			var editor = new CalcEdit();
			editor.Properties.Mask.EditMask = "N0";
			args.Editor = editor;
			args.DefaultResponse = dDefaultResponse;
			return Convert.ToInt32(XtraInputBox.Show(args));
		}

		public static decimal Show_Input_Box(string sPrompt, string sCaption, decimal dDefaultResponse)
		{
			var args = new XtraInputBoxArgs();
			args.Showing += Args_Showing;
			args.Caption = sCaption;
			args.Prompt = sPrompt;
			args.DefaultButtonIndex = 0;
			var editor = new CalcEdit();
			editor.Properties.Mask.EditMask = "N2";
			args.Editor = editor;
			args.DefaultResponse = dDefaultResponse;
			return Convert.ToDecimal(XtraInputBox.Show(args));
		}

		public static bool gridView_Loop(DevExpress.XtraGrid.Views.Grid.GridView gridView, int iRowHandleOld, int iRowHandle, string sTitle, string sAction, bool bLoopStop = false, bool bLoopLive = true, bool bSelectAll = false, string columnFieldName = "Notes")
		{
			if (bLoopStop || class_Database.DBError)
			{
				gridView.SetRowCellValue(iRowHandle, columnFieldName, class_Database.sError);
				string argsTitle = string.Empty;
				class_Procedures.Loop_Stop_Message(sTitle, sAction, sTitle: ref argsTitle);
				return false;
			}

			if (bLoopLive)
			{
				if (!bSelectAll)
					gridView.UnselectRow(iRowHandleOld);
				gridView.FocusedRowHandle = iRowHandle;
				gridView.MakeRowVisible(iRowHandle);
				if (!bSelectAll)
					gridView.SelectRow(iRowHandle);
				Application.DoEvents();
			}

			return true;
		}
	}
}