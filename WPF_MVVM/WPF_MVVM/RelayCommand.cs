using System;
using System.Windows.Input;

namespace WPF_MVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _action;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> action) : this(action, null)
        {
            _action = action;
        }

        public RelayCommand(Action<object> action, Predicate<object> canExecute)
        {
            if (action == null) throw new ArgumentNullException("Action is null.");
            _action = action;
            _canExecute = canExecute;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
