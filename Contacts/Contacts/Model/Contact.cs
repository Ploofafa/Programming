using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле, хранящее имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле, хранящее номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Поле, хранящее почту контакта.
        /// </summary>
        private string _email;

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
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
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
                _name = value;
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
                _phoneNumber = value;
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
                _email = value;
            }
        }
    }
}
