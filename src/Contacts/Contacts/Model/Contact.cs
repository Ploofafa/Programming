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
    public partial class Contact : ObservableObject, ICloneable, IDataErrorInfo
    {
        private Dictionary<string, string> Errors = new Dictionary<string, string>();

        /// <summary>
        /// Хранит имя контакта.
        /// </summary>с
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Хранит email контакта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Хранит номер телефона контакта. 
        /// </summary>
        [ObservableProperty]
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
        /// Создаёт клон контакта.
        /// </summary>
        /// <returns>Клонированный контакт.</returns>
        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }

        private bool HasError => Errors.Any();

        public bool IsValid => !HasError;

        public string Error => String.Empty;

        public string this[string propertyName]
        {
            get
            {
                Errors.Clear();
                CollectErrors();
                return Errors.ContainsKey(propertyName) ? Errors[propertyName] : string.Empty;
            }
        }

        private void CollectErrors()
        {
            if (Name?.Length == 0)
            {
                Errors.Add(nameof(Name), "Name is required");
            }

            if (Name?.Length > 100)
            {
                Errors.Add(nameof(Name), "Name must be less than 100 characters.");
            }

            if (PhoneNumber?.Length > 100)
            {
                Errors.Add(nameof(PhoneNumber), "Name must be less than 100 characters.");
            }

            if (Email?.Length > 100)
            {
                Errors.Add(nameof(Email), "Name must be less than 100 characters.");
            }

            if (Email != null && !Email.Contains("@"))
            {
                Errors.Add(nameof(Email), "Name must contain symbol: @");
            }
        }
    }
}
