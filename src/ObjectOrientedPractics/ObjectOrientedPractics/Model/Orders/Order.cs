using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order
    {
        /// <summary>
        /// Хранит уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Хранит дату создания заказа.
        /// </summary>
        private readonly DateTime _orderCreationDate;

        /// <summary>
        /// Хранит адрес доставки в экземпляре класса <see cref="Address"/>.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Хранит список товаров, которые нужно доставить.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит общую стоимость товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Хранит имя покупателя.
        /// </summary>
        private string _customerName;

        /// <summary>
        /// Хранит статус приоритета заказа.
        /// </summary>
        private bool _isPriority;

        /// <summary>
        /// Хранит сумму скидки заказа.
        /// </summary>
        private double _discountAmount;

        /// <summary>
        /// Хранит итоговую стоимость закаказа.
        /// </summary>
        private double _total;

        public Order()
        {
            _id = IdGenerator.GetNextId();
            _orderCreationDate = DateTime.Now;
            _items = new List<Item>();
        }

        public Order(Address address, List<Item> items, double amount,
                        OrderStatus status, string customerName)
        {
            _id = IdGenerator.GetNextId();
            _orderCreationDate = DateTime.Now;
            _address = address;
            _items = items;
            _amount = amount;
            _status = status;
            _customerName = customerName;
        }

        /// <summary>
        /// Возвращает значение уникального идентификатора заказа.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime OrderCreationDate
        {
            get
            {
                return _orderCreationDate;
            }
        }

        /// <summary>
        /// Возвращает значение адреса доставки.
        /// </summary>
        public string DeliveryAddress
        {
            get
            {
                return _address.City + ", " +
                        _address.Country + ", " +
                        Convert.ToString(_address.Index) + ", " +
                        _address.Street + ", " +
                        _address.Building + ", " +
                        _address.Apartment; ;
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус приоритета заказа.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задаёт сумму скидки.
        /// </summary>
        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }

            set
            {
                _discountAmount = value;
            }
        }

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
        /// Возвращает и задаёт значение списка покупок.
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
        /// Возвращает итоговую стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return _amount - _discountAmount;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение общей стоимости заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    _amount += Items[i].Cost;
                }

                return _amount;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя покупателя.
        /// </summary>
        public string CustomerName
        {
            get
            {
                return _customerName;
            }

            set
            {
                _customerName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
    }
}
