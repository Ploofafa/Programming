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
        /// Хранит показатель приоритета заказа.
        /// </summary>
        private bool _IsPriority;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>. Id
        /// генерируется и присваивается автоматически.
        /// </summary>
        public Customer()
        {
            _fullName = "Default name";
            _id = IdGenerator.GetNextId();
            _cart = new Cart();
            Address = new Address();
            _orders = new List<Order>();
            _IsPriority = false;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя. Не более 200 символов.</param>
        /// <param name="address">Полный адрес покупателя.</param>
        public Customer(string fullName, Address address,
                        Cart cart, List<Order> orders, bool isPriority)
        {
            FullName = fullName;
            Address = address;
            Cart = cart;
            _orders = orders;
            _id = IdGenerator.GetNextId();
            _IsPriority = isPriority;
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
        /// Возвращает и задаёт значение приоритет заказа.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение корзины.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }

            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }

            set
            {
                _orders = value;
            }
        }
    }
}