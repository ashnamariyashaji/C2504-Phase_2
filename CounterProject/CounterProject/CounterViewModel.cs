using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CounterProject
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private Counter _newCounter = null;
        public Counter NewCounter
        {
            get => _newCounter;
            set { _newCounter = value; OnPropertyChanged(nameof(NewCounter)); }
        }

        public ICommand PlusCommand { get; }
        public ICommand MinusCommand { get; }

        public CounterViewModel()
        {
            this.NewCounter = new Counter { Number = 0 };

            PlusCommand = new RelayCommand(Increament);
            MinusCommand = new RelayCommand(Decreament);
        }

        public void Increament()
        {

            NewCounter.Number++;
            OnPropertyChanged(nameof(NewCounter));

        }
        public void Decreament()
        {

            NewCounter.Number--;
            OnPropertyChanged(nameof(NewCounter));
        }
    }
}
