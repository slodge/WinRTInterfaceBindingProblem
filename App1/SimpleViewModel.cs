using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1
{
    class SimpleViewModel : INotifyPropertyChanged
    {
        private int _numTimesPressed;
        public int NumTimesPressed
        {
            get { return _numTimesPressed; }
            set { _numTimesPressed = value; OnPropertyChanged("NumTimesPressed"); }
        }

        public IIntermediateCommand Command1
        {
            get { return new SimpleRelayCommand() {Action = () => NumTimesPressed++}; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
