using System;

namespace MyClassLibrary.Classes
{
	public class DateDifference
	{
		private readonly int[] monthDay = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		private readonly DateTime fromDate;
		private readonly DateTime toDate;

		public DateDifference(DateTime d1, DateTime d2)
		{
			int increment;
			if (d1 > d2)
			{
				fromDate = d2;
				toDate = d1;
			}
			else
			{
				fromDate = d1;
				toDate = d2;
			}

			increment = 0;
			if (fromDate.Day > toDate.Day)
			{
				increment = monthDay[fromDate.Month - 1];
			}

			if (increment == -1)
			{
				if (DateTime.IsLeapYear(fromDate.Year))
				{
					increment = 29;
				}
				else
				{
					increment = 28;
				}
			}

			if (increment != 0)
			{
				Days = toDate.Day + increment - fromDate.Day;
				increment = 1;
			}
			else
			{
				Days = toDate.Day - fromDate.Day;
			}

			if (fromDate.Month + increment > toDate.Month)
			{
				Months = toDate.Month + 12 - (fromDate.Month + increment);
				increment = 1;
			}
			else
			{
				Months = toDate.Month - (fromDate.Month + increment);
				increment = 0;
			}

			Years = toDate.Year - (fromDate.Year + increment);
		}

		public override string ToString()
		{
			return $"{Years} Year(s), {Months} month(s), {Days} day(s)";
		}

		public int Years { get; private set; }
		public int Months { get; private set; }
		public int Days { get; private set; }
	}
}