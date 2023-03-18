using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubscriptionInstanceDataAggregation
    {
        public string SubscriptionTypeId { get; set; } //TODO: consider if we should/need to introduce this as a parent between this and account instance
        public string SubscriptionInstanceId { get; set; }

        public string SubscriptionMeteringType { get; set; }

        public int SubscriptionTypeRef { get; set; }
        public int SubscriptionInstanceRef { get; set; }
    }
}
