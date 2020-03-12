using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;

namespace ST.achname
{
    public class achName
    {
        public static string getName(ColonyAchievement colonyAchievement)
        {
            return colonyAchievement.Name;
        }

        public static string getDescription(ColonyAchievement colonyAchievement)
        {
            return colonyAchievement.description;
        }
    }
}
