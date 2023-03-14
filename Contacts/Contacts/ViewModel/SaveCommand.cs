using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model.Services;
using System.Windows.Input;

namespace Contacts.Model
{
    /// <summary>
    /// Класс, реализующий сохранение контакта.
    /// Реализует интерфейс <see cref="ICommand"/>.
    /// </summary>
    class SaveCommand : ICommand
    {
        /// <summary>
        /// Делегат хранящий ссылку на метод, который должен срабатывать при
        /// исполнении метода <see cref="Execute(object?)"/>.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат хранящий ссылку на метод, который будет выполняться при исполнении
        /// метода <see cref="CanExecute(object?)"/>.
        /// </summary>
        private Func<object, bool> _canExecute;

        /// <summary>
        /// Конструктор для класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат, вызываемый при выполнении.</param>
        /// <param name="canExecute">Делегат, проверяющий возможность выполнения.</param>
        public SaveCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Событие вызываемое при изменении условий, указывающее, может ли команда выполняться.
        /// </summary>
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

        /// <summary>
        /// Метод определяющий может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Метод, который будет передан в делегат.</param>
        /// <returns>Возвращает значение возможности выполнения метода.</returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecute(parameter);
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Выполняемая команда.</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}
