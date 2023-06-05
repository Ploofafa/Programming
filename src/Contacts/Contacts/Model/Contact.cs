using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public class Contact : ObservableObject, ICloneable, IDataErrorInfo
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
            get => _name;
            set => SetProperty(ref _name, value);
        }

        /// <summary>
        /// Задаёт и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetProperty(ref _phoneNumber, value);
        }

        /// <summary>
        /// Задаёт и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public bool IsOk => !HasError;

        public bool HasError => Errors.Any();

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

            if (Name?.Length > 100)
            {
                Errors.Add(nameof(Name), "Name must be less than 100 charactters!");
            }

            if (Email?.Length > 100)
            {
                Errors.Add(nameof(Email), "Email must be less than 100 charactters!");
            }

            if (PhoneNumber?.Length > 100)
            {
                Errors.Add(nameof(PhoneNumber), "PhoneNumber must be less than 100 charactters!");
            }

            if (Email != null && Email.Length > 0)
            {
                if (!Email.Contains("@"))
                {
                    Errors.Add(nameof(Email), "Email must contains symbol: @!");
                }
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
    }
}
