using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model.Services;
using System.Windows.Input;

namespace Contacts.Model
{
    class SaveCommand : ICommand
    {
        private Action<object> _execute;
        private Func<bool> _canExecute;

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
            this._execute(ContactSerializer.SaveContact);
        }
    }
}
