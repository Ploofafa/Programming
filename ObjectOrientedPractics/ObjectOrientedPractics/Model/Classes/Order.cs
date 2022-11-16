using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    public class Order
    {
        /// <summary>
        /// Хранит уникальный идентификатор для заказа. Не управляется классом.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит дату создания заказа. Не имеет возможности редактирования,
        /// задаётся автоматически. 
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Хранит адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Хранит список всех товаров добавленных в корзину.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит общую стоимость всех товаров.
        /// </summary>
        private double _amount;

        public Order()
        {
            _id = IdGenerator.GetNextId();
        }

        public Order(int id, DateTime date, Address address, List<Item> items, double amount)
        {
            _id = IdGenerator.GetNextId();
            _date = date;
            _address = address;
            _items = items;
            _amount = amount;
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
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт наполнение корзины покупателя.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт конечную стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }
    }
}
