using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Класс описывающий корзину покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Поле хранит список товаров в корзине покупателя.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Пустой конструктор класса <see cref="Cart"/>.
        /// </summary>
        public Cart() 
        {
            _items = new List<Item>();
        }

        /// <summary>
        /// Конструктор класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items"></param>
        public Cart(List<Item> items)
        {
            _items = items;
        }

        /// <summary>
        /// Задаёт и возвращает список товаров в корзине покупателя.
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
        /// Возвращает суммарную стоимость товаров в корзине покупателя.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items.Count != 0)
                {
                    double amount = 0;
                    for (int i = 0; i < _items.Count; i++)
                    {
                        amount += _items[i].Cost;
                    }
                    return amount;
                }

                else
                {
                    return 0;
                }
            }

        }
    }
}
