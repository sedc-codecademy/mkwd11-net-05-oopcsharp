using SEDC.VideoRental.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.VideoRental.Data.Database
{
    public class UserRepository : InMemoryDatabase
    {
        public User GetUserByIdCard(int idCard)
        {
            return Users.FirstOrDefault(_user => _user.CardNumber == idCard);
        }

        public bool CreateUser(User user)
        {
            var beforeLength = Users.Count;
            Users.Add(user);

            return beforeLength != Users.Count;
        }

        public List<int> GetAllCardNumbers()
        {
            return Users.Select(_user => _user.CardNumber).ToList();
        }
    }
}
