using System;
using Harmony;

namespace ST.clock
{
    class STclockPatch
    {
		[HarmonyPatch(typeof(MeterScreen), "RefreshRations")]
		private static class Refresh_Patch
		{
			[HarmonyPostfix]
			public static void RefreshPatch(MeterScreen __instance)
			{
				if (__instance.RationsText.text.Contains("|"))
				{
					string text = __instance.RationsText.text.Split(new char[] { '|' })[0];
					__instance.RationsText.text = text.Trim() + " | " + STclockMod.FormatAsClock(STclockMod.GetClock());
					return;
				}
				LocText rationsText = __instance.RationsText;
				rationsText.text = rationsText.text + " | " + STclockMod.FormatAsClock(STclockMod.GetClock());
				return;
			}
		}
	}
}
