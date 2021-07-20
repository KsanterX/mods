using System;
using HarmonyLib;

namespace ST.achname
{
    public class resNamePatch
    {
        [HarmonyPatch(typeof(ResearchCompleteMessage), "GetTitle")]
        class Patch1
        {
            [HarmonyPostfix]
            public static void getResName(ref string __result, ref ResourceRef<Tech> ___tech)
            {
                __result = __result + "<br><b>" + ___tech.Get().Name + "<b>";

            }
        }

        [HarmonyPatch(typeof (MessageDialogFrame), "SetMessage")]
        class Patch2
        {
            [HarmonyPostfix]
            public static void delBr(ref LocText ___title)
            {
                if (___title.text.Contains("<BR>"))
                {
                    ___title.text = ___title.text.Substring(0, ___title.text.IndexOf("<BR>"));
                }
            }
        }
    }
}
