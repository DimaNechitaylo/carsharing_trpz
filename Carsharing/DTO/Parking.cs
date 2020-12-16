using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.DTO
{
    class Parking
    {
        private Guid Parking_id { get; }
        private int Capacity { get; }
        private List<Car> CarList { get; }
        private string Location { get; }

        public bool AddCar(Car car)
        {
            if (!CarList.Contains(car))
            {
                CarList.Add(car);
                return true;
            }
            else return false;

        }
        public bool RemoveCar(Car car)
        {
            if (CarList.Contains(car))
            {
                CarList.Remove(car);
                return true;
            }
            else return false;

        }
    }
}
