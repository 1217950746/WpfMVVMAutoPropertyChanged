using System;
using System.Windows.Input;

namespace WpfMVVMAutoPropertyChanged
{
    public class Command : ICommand
    {
        readonly Action action;
        public event EventHandler CanExecuteChanged;

        public Command(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action?.Invoke();
        }
    }
}