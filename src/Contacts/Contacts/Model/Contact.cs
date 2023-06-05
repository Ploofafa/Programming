using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private Dictionary<string, string> Errors { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Хранит имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит email контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит номер телефона контакта. 
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
        }

        public bool IsError => Errors.Any();

        public bool IsOk => !IsError;

        /// <summary>
        /// Конструктор для создания экземпляра класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Переменная, хранящая имя контакта.</param>
        /// <param name="phoneNumber">Переменная, хранящая номер контакта.</param>
        /// <param name="email">Переменная, хранящая почту контакта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        /// <summary>
        /// Задаёт и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name == value)
                {
                    return;
                }

                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Задаёт и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
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
                return _email;
            }

            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
 
        public bool HasError { get; set; }

        public string Error => String.Empty;

        public string this[string propertyName]
        {
            get
            {
                CollectErrors();
                return Errors.ContainsKey(propertyName) ? Errors[propertyName] : String.Empty; 
            }
        }

        private void CollectErrors()
        {
            Errors.Clear();
            if (string.IsNullOrEmpty(Name))
            {
                Errors.Add(nameof(Name), "Name must be defined!");
            }

            if (Name.Length > 100)
            {
                Errors.Add(nameof(Name), "Name must be less than 100 charactters!");
            }

            if (Email.Length > 100)
            {
                Errors.Add(nameof(Email), "Email must be less than 100 charactters!");
            }

            if (PhoneNumber.Length > 100)
            {
                Errors.Add(nameof(PhoneNumber), "PhoneNumber must be less than 100 charactters!");
            }

            if (!Email.Contains("@"))
            {
                Errors.Add(nameof(Email), "Email must contains symbol: @!");
            }
        }

        /// <summary>
        /// Создаёт клон контакта.
        /// </summary>
        /// <returns>Клонированный контакт.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }

        /// <summary>
        /// Событие на изменения свойства для связи View и Model.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Метод, вызывающийся при изменении свойства.
        /// </summary>
        /// <param name="property">Имя свойства, которое его вызвало</param>
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
