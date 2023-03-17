    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Contacts.Model;
using Contacts.Model.Services;

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
        private Contact _contact = new Contact();

        /// <summary>
        /// Переменная, хранящая делегат для сохранения.
        /// </summary>
        private RelayCommand _saveCommand;
    
        /// <summary>
        /// Переменная, хранящая делегат для загрузки.
        /// </summary>
        private RelayCommand _loadCommand;

        /// <summary>
        /// Конструктор класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
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
                if(_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
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
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
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
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
                
            }
        }

        /// <summary>
        /// Возвращает команду для сохранения контакта.
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ?? 
                    (_saveCommand = new RelayCommand(obj =>
                    {
                        ContactSerializer.SaveContact(_contact);
                    },
                    obj =>
                    {
                        return true;
                    }));
            }
        }

        /// <summary>
        /// Возвращает метод для загрузки контакта.
        /// </summary>
        public RelayCommand LoadCommand
        {
            get
            {
                return _loadCommand ?? 
                    (_loadCommand = new RelayCommand(obj =>
                    {
                        var contact = ContactSerializer.LoadContact(_contact);
                        Name = contact.Name;
                        Email = contact.Email;
                        PhoneNumber = contact.PhoneNumber;
                    },
                    obj =>
                    {
                        return true;
                    }));
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
