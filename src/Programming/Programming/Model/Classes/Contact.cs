using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о контакте: номер, фамилию, имя.
    /// </summary>
    public class Contact
    {

        /// <summary>
        /// Номер. Должен состоять строго из 11 цифр.
        /// </summary>
        private string _number;

        /// <summary>
        /// Фамилия. Должна состоять только из букв.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя. Должно состоять только из букв.
        /// </summary>
        private string _name;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="city">Город. Должен состоять только из букв.</param>
        /// <param name="number">Номер. Должен состоять строго из 11 цифр.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        public Contact(string name,
                       string address,
                       string city,
                       string number,
                       string surname)
        {
            Name = name;
            Address = address;
            City = city;
            Number = number;
            Surname = surname;
        }

        /// <summary>
        /// Возвращает и задаёт Номер человека. 
        /// Должен состоять только из 11 цифр.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                    "Number must contain exactly 11 digits");
                }
                if (int.TryParse(value, out int num) == false)
                {
                    throw new ArgumentException(
                        "Number can only be digits");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя человека.
        /// Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию человека.
        /// Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрсе.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт город.
        /// </summary>
        public string City { get; set; }
    }
}
