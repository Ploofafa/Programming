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
        public string Name { get; set; }

        /// <summary>
        /// Задаёт и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Задаёт и возвращает почту контакта.
        /// </summary>
        public string Email { get; set; }
    }
}
