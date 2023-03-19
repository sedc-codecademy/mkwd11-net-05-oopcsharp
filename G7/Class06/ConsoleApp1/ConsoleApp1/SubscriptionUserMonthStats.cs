using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubscriptionUserMonthStats
    {
        //do we need parent account, (subscription?) links?
        public SubscriptionInstanceDataAggregation SubscriptionInstance { get; set; }
        public SubscriptionInstanceMonthStatsAggregationDto SubscriptionMonthStats { get; set; }
        public string UserId { get; set; }
        public UserMonthStats AccountUserMonthStats { get; set; }
        public int? DaysSinceLastActivity => AccountUserMonthStats.DaysSinceLastActivity;
        //is status relevant?

        public CalendarMonth CalendarMonth => SubscriptionMonthStats.CalendarMonth;
    }
}
