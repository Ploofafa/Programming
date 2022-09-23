﻿using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Хранит Id покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Хранит полное ФИО покупателя. Не более 200 символов.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Хранит полный адрес покупателя. Не более 500 символов.
        /// </summary>
        private string _address;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>. Id
        /// генерируется и присваевается автоматически.
        /// </summary>
        public Customer()
        {
            _id++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя. Не более 200 символов.</param>
        /// <param name="address">Полный адрес покупателя. Не более 500 символов.</param>
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _id++;
        }

        /// <summary>
        /// Задаёт и возвращает полное ФИО покупателя. Не более 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 201);
                _fullName = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает полный адрес покупателя. Не более 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 501);

            }
        }
    }
}