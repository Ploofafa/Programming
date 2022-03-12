using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string Name;
        private string Adress;
        private string City;
        private string Number;

        public Contact MakeClearContact()
        {
            return new Contact();
        }
        public Contact MakeContact(string name,
                            string adress,
                            string city,
                            string number)
        {
            Contact contact = new Contact();
            SetName(contact, name);
            SetAdress(contact, adress);
            SetCity(contact, city);
            SetNumber(contact, number);
            return contact;
        }

        public void SetNumber(Contact contact, string number)
        {
            if (number.Length != 11)
            {
                throw new ArgumentException(
                "Number must contain exactly 11 digits");
            }
            else if (int.TryParse(number, out int num) == false)
            {
                throw new ArgumentException(
                    "Number can only be digits");
            }
            contact.Number = number;
        }
        public void SetName(Contact contact, string name)
        {
            contact.Name = name;
        }
        public void SetAdress(Contact contact, string adress)
        {
            contact.Adress = adress;
        }
        public void SetCity(Contact contact, string city)
        {
            contact.City = city;
        }
        public string GetNumber(Contact contact)
        {
            return contact.Number;
        }
        public string GetName(Contact contact)
        {
            return contact.Name;
        }
        public string GetAdress(Contact contact)
        {
            return contact.Adress;
        }
        public string GetCity(Contact contact)
        {
            return contact.City;
        }
    }
   
}
