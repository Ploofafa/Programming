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
        private string _name;
        private string _address;
        private string _city;

        public Contact()
        {
        }
        public Contact MakeContact(string name,
                            string address,
                            string city,
                            string number)
        {
            Contact contact = new Contact();
            _name = name;
            _address = address;
            _city = city;
            _number = number;
            return contact;
        }

        public string Number
        {
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
            get
            {
                return _number;
            }
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }


}
