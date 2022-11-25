using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Описывает класс покупателей.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Хранит ID покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит полное ФИО покупателя. Не более 200 символов.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Хранит список всех заказов покупателя.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Хранит экземпляр корзины покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>. Id
        /// генерируется и присваивается автоматически.
        /// </summary>
        public Customer()
        {
            FullName = "Default name";
            _id = IdGenerator.GetNextId();
            _cart = new Cart();
            Address = new Address();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя. Не более 200 символов.</param>
        /// <param name="address">Полный адрес покупателя.</param>
        public Customer(string fullName, Address address,
                        Cart cart)
        {
            FullName = fullName;
            Address = address;
            Cart = cart;
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
                ValueValidator.AssertStringOnMaxLength(value, 201);
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
        /// Возвращает и задаёт значение адреса.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение корзины.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public Order Orders { get; set; }
    }
}