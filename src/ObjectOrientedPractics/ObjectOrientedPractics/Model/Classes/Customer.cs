﻿using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Discounts;

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
        /// Хранит список доступных скидок у покупателя
        /// </summary>
        private List<IDiscount> _discounts;

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
            _discounts = new List<IDiscount> { new PointsDiscount() };
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя. Не более 200 символов.</param>
        /// <param name="address">Полный адрес покупателя.</param>
        public Customer(string fullName, Address address,
                        Cart cart, List<Order> orders, bool isPriority,
                        List<IDiscount> discounts)
        {
            FullName = fullName;
            Address = address;
            Cart = cart;
            _orders = orders;
            _id = IdGenerator.GetNextId();
            _IsPriority = isPriority;
            _discounts = new List<IDiscount> { new PointsDiscount() };

            foreach (var discount in discounts)
            {
                _discounts.Add(discount);
            }
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
        public bool IsPriority
        {
            get
            {
                return _IsPriority;
            }

            set
            {
                _IsPriority = value;
            }
        }

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

        /// <summary>
        /// Возвращает и задаёт список доступных покупателю скидок.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get
            {
                return _discounts;
            }

            set
            {
                _discounts = value;
            }
        }
    }
}