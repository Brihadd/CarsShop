using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static  class CarEnumToList
    {
        public static List<Fuel> FuelList = Enum.GetValues(typeof(Fuel))
                           .Cast<Fuel>()
                           .ToList();
        public static List<Condition> ConditionList = Enum.GetValues(typeof(Condition))
                           .Cast<Condition> ()
                           .ToList();
        public static List<DealState> DealStateList = Enum.GetValues(typeof(DealState))
                           .Cast<DealState>()
                           .ToList();
    }
}
