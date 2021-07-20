using System.Collections.Concurrent;
using Database;
using HarmonyLib;

namespace ST.achname
{
    public class achNamePatch
    {
        public static string Ach;

        [HarmonyPatch(typeof(ColonyAchievementTracker), "TriggerNewAchievementCompleted")]
        class TriggerNewAchievementCompleted_Patch
        {
            [HarmonyPrefix]
            public static void getAchId(string achievement)
            {
                ColonyAchievement colonyAchievement = Db.Get().ColonyAchievements.Get(achievement);
                
                Ach = achName.getName(colonyAchievement);
            }
        }

        [HarmonyPatch(typeof(AchievementEarnedMessage), "GetTitle")]
        class GetTitlePatch
        {
            static void Postfix(ref string __result)
            {
                    __result = __result + "<br><b>" + Ach + "</b>";
            }
        }
        
    }
}
