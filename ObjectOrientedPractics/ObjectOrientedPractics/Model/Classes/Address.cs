using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class Address
    {
        /// <summary>
        /// Хранит почтовый индекс. Целое 6-ти значное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Хранит название страны/региона. Не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Хранит название города. Не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Хранит название улицы. Не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Хранит номер дома на улице. Не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Хранит номер квартиры или помещения. Не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Пустой конструктор, создаёт экземпляр класса Address с полями по умолчанию.
        /// </summary>
        public Address() 
        { 
            _index = 000000;
            _country = "Default country";
            _city = "Default city";
            _street = "Default street";
            _building = "0";
            _apartment = "0";
        }

        /// <summary>
        /// Создаёт экземпляр класса Address.
        /// </summary>
        /// <param name="index">Индекс дома, содержит 6 цифр.</param>
        /// <param name="country">Регион/страна, не больше 50 символов.</param>
        /// <param name="city">Город/населённый пункт, не больше 50 символов.</param>
        /// <param name="street">Название улицы, не более 100 символов.</param>
        /// <param name="building">Номер дома, не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения, не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Задаёт и возвращает значение индекса. Должно состоять ровно из 6 цифр.
        /// </summary>
        public int Index 
        {
            get
            {
                return _index;
            }

            set
            {
                Validator.AssertIntOnNeedLength(value, 6);
                _index = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает название страны/региона. Содержит не более 50 символов. 
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 50);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название города. Не более 50 символов.
        /// </summary>
        public string City 
        {
            get
            {
                return _city;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 50);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название улицы. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 100);
                _street = value;
            }
        } 

        /// <summary>
        /// Возвращает и задаёт номер здания. Не более 10 символов.
        /// </summary>
        public string Building 
        {
            get
            {
                return _building;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 10);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения. Не более 10 символов.
        /// </summary>
        public string Apartment 
        {
            get
            {
                return _apartment;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 10);
                _apartment = value;
            }
        }
    }
}
