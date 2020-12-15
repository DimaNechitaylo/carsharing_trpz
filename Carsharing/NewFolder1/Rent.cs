using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.NewFolder1
{
    class Rent
    {
        private Guid Rent_id { get; }
        private Car Car { get; }
        private User User { get; }
        private Parking EndParking { get; }
        private DateTime StartDataTime { get; }
        private DateTime FinishDataTime { get; }
        public Rent(Guid Rent_id, Car Car, User User)
        {
            this.Rent_id = Rent_id;
            this.Car = new Car(Car.Car_id, Car.Capacity, Car.CarsClass, Car.Condition);
            this.User = new User(User.user_id, User.name, User.expirationDateOfRights);
            this.StartDataTime = DateTime.UtcNow;
        }
    }
}
