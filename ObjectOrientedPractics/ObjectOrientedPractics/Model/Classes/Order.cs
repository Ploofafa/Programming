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

        public Order(Address deliveryAddress, List<Item> items, double amount)
        {
            _id = IdGenerator.GetNextId();
            _orderCreationDate = DateTime.Now;
            _deliveryAddress = deliveryAddress;
            _items = items;
            _amount = amount;
        }

        /// <summary>
        /// Возвращает значение уникального идентификатора заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime OrderCreationDate { get; }

        /// <summary>
        /// Возвращает и задаёт значение адреса доставки.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение списка покупок.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт значение общей стоимости заказа.
        /// </summary>
        public double Amout { get; set; }
    }
}
