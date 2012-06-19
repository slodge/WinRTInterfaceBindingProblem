using System;

namespace App1
{
    public class BaseSimpleRelayCommand : IIntermediateCommand
    {
        public Action Action { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute()
        {
            Execute(null);
        }

        public void Execute(object parameter)
        {
            if (Action != null)
                Action();
        }

        public event EventHandler CanExecuteChanged;
    }
}