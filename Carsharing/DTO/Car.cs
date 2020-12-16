using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.DTO
{
    partial class Car : INotifyPropertyChanged
    {

        public Guid Car_id { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Capacity { get; set; }
        private bool Status { get; set; }
        public CarsCalsses CarsClass { get; set; }
        public Conditions Condition { get; set; }
        public Car(Guid Car_id,string name, int Capacity, CarsCalsses CarsClass, Conditions Condition)
        {
            this.Car_id = Car_id;
            this.name = name;
            this.Capacity = Capacity;
            this.Condition = Condition;
            this.CarsClass = CarsClass;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}

