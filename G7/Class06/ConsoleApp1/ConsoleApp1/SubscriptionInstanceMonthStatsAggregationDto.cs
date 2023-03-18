using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubscriptionInstanceMonthStatsAggregationDto
    {
        public CalendarMonth CalendarMonth { get; set; }
        //NOTE: costs in user currency:
        public decimal? MonthCost { get; set; }
        public decimal? MonthAssignedCost { get; set; }
        public decimal? MonthUnassignedCostost { get; set; }

        //from metering data
        public int? MaxMonthAssignedUsers { get; set; } //NOTE: something weird would be going on if UserMonthStats.Count(u => u.WasActive) != MaxMonthActiveUsers
        public int? MaxMonthUserCap { get; set; }

        //user tracking: (note: should these only be active users? if so skip was active bool)
        public List<SubscriptionUserMonthStats> UserMonthStats { get; set; } = new List<SubscriptionUserMonthStats>()
        {
            new SubscriptionUserMonthStats
            {
                
            }
        };

        public decimal? MonthCostPerUser { get; set; }//=> (UserMonthStats?.Any() ?? false) ? MonthCost / UserMonthStats.Count : 0;

        public decimal? CostByUsersActiveLast7Days => (UserMonthStats?.Count(u => u.DaysSinceLastActivity <= 7) ?? 0) * MonthCostPerUser;
        public decimal? CostByUsersActiveMoreThan7DaysAgo => (UserMonthStats?.Count(u => u.DaysSinceLastActivity > 7 && u.DaysSinceLastActivity <= 30) ?? 0) * MonthCostPerUser;
        public decimal? CostByUsersWithActivity => (UserMonthStats?.Count(u => u.DaysSinceLastActivity <= 30) ?? 0) * MonthCostPerUser;
        public decimal? CostByUsersWithNoActivity => (UserMonthStats?.Count(u => u.DaysSinceLastActivity == null || u.DaysSinceLastActivity > 30) ?? 0) * MonthCostPerUser;
    }
}
