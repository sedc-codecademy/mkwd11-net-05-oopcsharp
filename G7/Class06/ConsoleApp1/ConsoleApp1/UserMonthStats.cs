using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserDataAggregation
    {
        //These should be populated when fetching user list for account (note: current is the last month that has imported data if it's within this or previous month)
        //public AccountInstanceDataAggregation AccountInstance { get; set; }
        public string UserId { get; set; }
        public string LatestStatus { get; set; }
        public int? CurrentDaysSinceLastActivity { get; set; }

        /// <summary>
        /// Stats for this user per calendar month it has been imported (regardless of subscription)
        /// </summary>
        public List<UserMonthStats> MonthlyImportStats { get; set; } = new List<UserMonthStats>(); //These should be populated by a call per account instance

        public int UserRef { get; set; }
    }

    public class UserMonthStats
    {
        //These should be populated by a call per account instance
        public UserDataAggregation User { get; set; }
        public CalendarMonth Month { get; set; }
        public string Status { get; set; }
        public int? DaysSinceLastActivity { get; set; }

        //the assignments should be populated iterating over subscriptions later
        /// <summary>
        /// The subscriptions the user was assigned to in the calendar month (with stats)
        /// </summary>
        public List<SubscriptionUserMonthStats> Assignments { get; set; } = new List<SubscriptionUserMonthStats>();

        //is this relevant?
        // <summary>
        // The sum of the users' part of the total cost (compared to number of users) in all subscriptions it is assigned to
        // </summary>
        //public decimal? CostsBornByUser { get; set; }
    }
}
