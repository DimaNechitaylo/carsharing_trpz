using Carsharing.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing.ViewModel
{
    class CarModelView : INotifyPropertyChanged
    {
        private Car car;
        public CarModelView(Car car)
        {
            this.car = car;
        }

        public string Name
        {
            get { return car.Name; }
            set
            {
                car.Name = value;
                OnPropertyChanged("Title");
            }
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
