using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct CalendarMonth //UtcCalendarMonth ?
    {
        //TODO: consider adjusting for (including) datetime offset? (or not? Maybe define as "at UTC")
        public int Year { get; set; }
        public int Month { get; set; }
        public int YearMonth => Year * 100 + Month; //YYYYMM as int

        public bool InclusiveBetween(CalendarMonth low, CalendarMonth high)
        {
            return InclusiveBetween(YearMonth, low.YearMonth, high.YearMonth);
        }

        public CalendarMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        //public static bool operator ==(CalendarMonth obj1, CalendarMonth obj2)
        //{
        //    return obj1.YearMonth == obj2.YearMonth;
        //}

        //// this is second one '!='
        //public static bool operator !=(CalendarMonth obj1, CalendarMonth obj2)
        //{
        //    return obj1.YearMonth != obj2.YearMonth;
        //}

        // this is third one 'Equals'
        public bool Equals(CalendarMonth obj)
        {
            return YearMonth == obj.YearMonth;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, 1);
        }


        public bool InclusiveBetween(int num, int low, int high)
        {
            return low <= num && num <= high;
        }
    }
}
