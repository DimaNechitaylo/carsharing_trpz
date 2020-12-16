using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.DTO
{
    public class User
    {
        public Guid user_id { get; }
        public string name { get; }
        public string pass { get; }
        public bool status { get; set; }
        public DateTime expirationDateOfRights { get; }
        public User(Guid user_id, string name, string pass, DateTime expirationDateOfRights, bool status)
        {
            this.user_id = user_id;
            this.name = name;
            this.name = pass;
            this.expirationDateOfRights = expirationDateOfRights;
            this.status = status;
        }
    }
}
