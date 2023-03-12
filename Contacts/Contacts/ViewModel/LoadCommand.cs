using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    class LoadCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public LoadCommand(Action<object> execute)
        {
            _execute = execute;
        }

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this._execute(parameter);
        }
    }
}
