using System.Collections.Generic;
using System.Reflection.Emit;
using Database;
using Harmony;

namespace ST.achievename
{
    /*
    public class myAchiev : Message
    {
        public abstract string GetTitle();

        public override string GetSound()
        {
            return "";
        }

        // Token: 0x06003E8C RID: 16012
        public override string GetMessageBody()
        {
            return "";
        }

        // Token: 0x06003E8D RID: 16013
        public abstract string GetTooltip();

        // Token: 0x06003E8E RID: 16014 RVA: 0x0000B05A File Offset: 0x0000925A
        public override bool ShowDialog()
        {
            return true;
        }

        // Token: 0x06003E8F RID: 16015 RVA: 0x0000500A File Offset: 0x0000320A
        public virtual void OnCleanUp()
        {
        }

        // Token: 0x06003E90 RID: 16016 RVA: 0x0000B05A File Offset: 0x0000925A
        public virtual bool IsValid()
        {
            return true;
        }

        // Token: 0x06003E91 RID: 16017 RVA: 0x0000B05A File Offset: 0x0000925A
        public virtual bool PlayNotificationSound()
        {
            return true;
        }

        // Token: 0x06003E92 RID: 16018 RVA: 0x0000500A File Offset: 0x0000320A
        public virtual void OnClick()
        {
        }
    }*/
    public class achName
    {
        public static string getName(ColonyAchievement colonyAchievement)
        {
            return colonyAchievement.Name;
        }


    }

    public class achievenamePatch
    {
        public static string AchievementName;

        [HarmonyPatch(typeof(AchievementEarnedMessage), "TriggerNewAchievementCompleted")]
        class Patch1
        {
            [HarmonyPrefix]
            public static void GetAchId(string achievement_id)
            {
                if (!SaveGame.Instance.sandboxEnabled) {
                    ColonyAchievement colonyAchievement = Db.Get().ColonyAchievements.Get(achievement_id);
                    AchievementName = achName.getName(colonyAchievement);
                }
            }
            /*
            [HarmonyTranspiler]
            static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {

                foreach (var instr in instructions)
                {
                    if (instr.opcode == OpCodes.Newobj)
                    {
                        yield return new CodeInstruction(OpCodes.Newobj, "instance void AchievementEarnedMessage::.ctor()");
                        yield return new CodeInstruction(OpCodes.Stloc_1);
                        yield return new CodeInstruction(OpCodes.Call, "class Db Db::Get()");
                        yield return new CodeInstruction(OpCodes.Ldfld, "class Database.ColonyAchievements Db::ColonyAchievements");
                        yield return new CodeInstruction(OpCodes.Ldloc_0);

                    }

                }
            }*/
        }

        [HarmonyPatch(typeof(AchievementEarnedMessage), "GetTitle")]
        class Patch2
        {
            static void Postfix(ref string __result)
            {
                if (AchievementName != "")
                {
                    __result = __result + "<br>" + AchievementName;
                }
            }
        }
    }
}
