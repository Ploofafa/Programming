using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Класс, реализующий связь между GUI и бизнес-логикой.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие для отслеживания изменений в GUI.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Переменная, хранящая экземпляр класса <see cref="Contact"/>
        /// для отслеживания состояния объекта в реальном времени.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Коструктор класса <see cref="MainVM"/> с созданием объекта <see cref="Contact"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Задаёт и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }

            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Задаёт и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }

            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Задаёт и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Метод для отслеживания изменений свойств.
        /// </summary>
        /// <param name="propertyName">Имя изменяемого свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
