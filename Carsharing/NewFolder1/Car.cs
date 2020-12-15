using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.NewFolder1
{
    partial class Car
    {

        public Guid Car_id { get; }
        public int Capacity { get; }
        private bool Status { get; set; }
        public CarsCalsses CarsClass { get; }
        public Conditions Condition { get; set; }
        public Car(Guid Car_id, int Capacity, CarsCalsses CarsClass, Conditions Condition)
        {
            this.Car_id = Car_id;
            this.Capacity = Capacity;
            this.Condition = Condition;
            this.CarsClass = CarsClass;
        }
        public enum CarsCalsses
        {
            Econom,
            Comfort,
            Business
        }
        public enum Conditions
        {
            Excellent,
            Well,
            Satisfactorily,
            Weak,
            Unsatisfactory
        }
    }
}

