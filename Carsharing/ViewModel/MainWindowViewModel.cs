using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsharing.DTO;

namespace Carsharing.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Car selectedCar;
        public ObservableCollection<Car> Cars { get; set; }
        public Car SelectedCar
        {
            get { return selectedCar; }
            set
            {
                selectedCar = value;
                OnPropertyChanged("SelectedCar");
            }
        }
        public MainWindowViewModel()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car (Guid.NewGuid(), "Tayota", 4, CarsCalsses.Econom, Conditions.Unsatisfactory),
                new Car (Guid.NewGuid(), "Voltswagen",2, CarsCalsses.Comfort, Conditions.Weak),
                new Car (Guid.NewGuid(), "Maibah",4, CarsCalsses.Business, Conditions.Excellent),
                new Car (Guid.NewGuid(), "Prius",5, CarsCalsses.Econom, Conditions.Well)
            };
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
