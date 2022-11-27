using ObjectOrientedPractics.Model.Enums;
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
        /// Хранит адрес доставки.
        /// </summary>
        private Address _deliveryAddress;

        /// <summary>
        /// Хранит список товаров, которые нужно доставить.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит общую стоимость товаров.
        /// </summary>
        private double _amount;

        public Order()
        {
            _id = IdGenerator.GetNextId();
            _orderCreationDate= DateTime.Now;
        }

        public Order(Address deliveryAddress, List<Item> items, double amount,
                        OrderStatus status)
        {
            _id = IdGenerator.GetNextId();
            _orderCreationDate = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _items = items;
            _amount = amount;
            _status = status;
        }

        /// <summary>
        /// Возвращает значение уникального идентификатора заказа.
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
        public DateTime OrderCreationDate
        {
            get
            {
                return _orderCreationDate;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение адреса доставки.
        /// </summary>
        public Address DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }

            set
            {
                _deliveryAddress = value;
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
        /// Возвращает и задаёт значение общей стоимости заказа.
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

        public static implicit operator List<object>(Order v)
        {
            throw new NotImplementedException();
        }
    }
}
