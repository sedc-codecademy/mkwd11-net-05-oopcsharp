namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new SubscriptionInstanceMonthStatsAggregationDto();
            //x.UserMonthStats = null;
            x.MonthCostPerUser = null;
            Console.WriteLine(x.CostByUsersActiveLast7Days);
        }
    }
}