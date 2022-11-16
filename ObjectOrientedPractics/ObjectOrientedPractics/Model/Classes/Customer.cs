using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class Customer
    {
        /// <summary>
        /// Хранит Id покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит полное ФИО покупателя. Не более 200 символов.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Хранит корзину товаров покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Хранит список всех заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>. Id
        /// генерируется и присваевается автоматически.
        /// </summary>
        public Customer()
        {
            FullName = "Default name";
            _id = IdGenerator.GetNextId();
            Address = new Address();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя. Не более 200 символов.</param>
        /// <param name="address">Полный адрес покупателя.</param>
        public Customer(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
            
            _id = IdGenerator.GetNextId();
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
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Задаёт и возвращает список всех заказов покупателя.
        /// </summary>
        private List<Order> Orders { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение адреса.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение данных корзины.
        /// </summary>
        public Cart Cart {get; set;}
    }
}