using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.NewFolder1
{
    public class User
    {
        public Guid user_id { get; }
        public string name { get; }
        public bool status { get; set; }
        public DateTime expirationDateOfRights { get; }
        public int rating { get; set; }
        public User(Guid user_id, string name, DateTime expirationDateOfRights)
        {
            this.user_id = user_id;
            this.name = name;
            this.expirationDateOfRights = expirationDateOfRights;
            this.rating = 100;
            this.status = true;
        }
        public bool increaseRating()
        {
            if (rating != 100)
            {
                rating++;
                return true;
            }
            else return false;

        }
        public bool lowerRating()
        {
            if (rating != 0)
            {
                rating--;
                return true;
            }
            else return false;

        }
    }
}
