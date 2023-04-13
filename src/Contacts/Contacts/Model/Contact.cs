using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Contacts.Model
{
    /// <summary>
    /// Класс описывающий контакт записной книги.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
    {

        private string _name;
        private string _email;
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
            get
            {
                return _name;
            }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
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
                return _phoneNumber;
            }

            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
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
                    OnPropertyChanged("Email");
                }
            }
        }

        public object Clone()
        {
            return new Contact(Name, PhoneNumber, Email);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
