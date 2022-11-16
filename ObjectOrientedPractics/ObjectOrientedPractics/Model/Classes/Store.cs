using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    internal class Store
    {
        /// <summary>
        /// Содержит список всех товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Содержит список всех покупателей
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/> с проинициализированными полями.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

        /// <summary>
        /// Задаёт и возвращает значение списка товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Задаёт и возвращает значение списка покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }
    }
}
