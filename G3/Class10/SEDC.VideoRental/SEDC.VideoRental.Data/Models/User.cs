using SEDC.VideoRental.Data.BaseModels;
using System;
using System.Collections.Generic;

namespace SEDC.VideoRental.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // card number is used as a username
        public int CardNumber { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }

        public bool IsSubscribedForPromotions { get; set; }
        
        // TODO: PART 3
        public List<RentalInfo> RentedMovies { get; set; }
        public List<RentalInfo> RentedMoviesHistory { get; set; }

        // TODO : END PART 3
        public User()
        {
            IsSubscriptionExpired = false;
            RentedMovies = new List<RentalInfo>();
            RentedMoviesHistory = new List<RentalInfo>();
        }
    }
}
