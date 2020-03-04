using System;
using System.Collections.Generic;

namespace ST.clock
{
	public class STclockMod
	{
		static Dictionary<string, string> DayTimeColors = new Dictionary<string, string>{
			{ "Morning", "#eebb74" },
			{ "Day", "#ef810e" },
			{ "Evening", "#09679a" },
			{ "Night", "#003a55" }
		};
		public static string GetClock()
		{
			return System.DateTime.Now.ToShortTimeString();
		}

		public static string FormatAsClock(string text)
		{

			return "<b><color=" + DayTimeColors[CheckTimeOfDay()] + ">" + text + "</color></b>";
		}

		public static string CheckTimeOfDay()
		{
			var time = System.DateTime.Now.Hour;

			if (time >= 5 && time < 10)
			{
				return "Morning";
			}
			else if (time >= 10 && time < 17)
			{
				return "Day";
			}
			else if (time >= 17 && time < 21)
			{
				return "Evening";
			}
			else
			{
				return "Night";
			}
		}
	}
}

