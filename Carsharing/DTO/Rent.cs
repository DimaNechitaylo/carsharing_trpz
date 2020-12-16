using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.DTO
{
    class Rent
    {
        private Guid Rent_id { get; }
        private Car Car { get; }
        private User User { get; }
        private DateTime rentTimestamp { get; }
        public Rent(Guid Rent_id, Car Car, User User)
        {
            this.Rent_id = Rent_id;
            this.Car = Car;
            this.User = User;
            this.rentTimestamp = rentTimestamp;
        }
    }
}
