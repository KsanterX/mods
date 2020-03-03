using System;
using System.Reflection;
using Harmony;
using STRINGS;
using UnityEngine;

namespace ST.vitals
{
    public class STvitalsScreen : TableScreen
    {
        public LabelTableColumn AddLabelColumn()
        {
            
        }
    }

    public class STvitalsPatch
    {

        [HarmonyPatch(typeof(VitalsTableScreen))]
        [HarmonyPatch("OnActivate")]
        public static class getVitals
        {
            [HarmonyPostfix]
            public static void getVitalsTable(ref VitalsTableScreen __instance)
            {
                LabelTableColumn labelTableColumn = new LabelTableColumn()
            }
        }
    }
}


protected LabelTableColumn AddLabelColumn(string id, Action<IAssignableIdentity, GameObject> on_load_action, Func<IAssignableIdentity, GameObject, string> get_value_action, Comparison<IAssignableIdentity> sort_comparison, Action<IAssignableIdentity, GameObject, ToolTip> on_tooltip, Action<IAssignableIdentity, GameObject, ToolTip> on_sort_tooltip, int widget_width = 128, bool should_refresh_columns = false)
{
    LabelTableColumn labelTableColumn = new LabelTableColumn(on_load_action, get_value_action, sort_comparison, on_tooltip, on_sort_tooltip, widget_width, should_refresh_columns);
    if (this.RegisterColumn(id, labelTableColumn))
    {
        return labelTableColumn;
    }
    return null;
}