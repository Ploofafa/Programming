using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _number;

        private string _surname;

        private string _name;

        public Contact()
        {
        }

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

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        private string AssertStringContainsOnlyLetters(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{nameof(value)} must be alphabetic characters only");
                }
            }
            return value;
        }

        public string Address { get; set; }

        public string City { get; set; }
    }
}
