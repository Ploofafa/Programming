using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Хранит категорию товара, на которую предоставляется скидка.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Хранит сумму на которую куплены товары.
        /// </summary>
        private double _accumulated;

        /// <summary>
        /// Хранит процент скидки. Лежит в промежутке от 0,01 до 0,1.
        /// </summary>
        private double _discount;

        public double Accumulated
        {
            get
            {
                return _accumulated;
            }

            set
            {
                _accumulated = value;
            }
        }

        public Category Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public double Discount
        {
            get
            {
                return _discount;
            }

            set
            {
                _discount = value;
            }
        }

        public string Info
        {
            get
            {
                return $"info: Процентная «{_category}» - {_discount}";
            }
        }

        /// <summary>
        /// Конструктор создающий экземпляр процентной скидки.
        /// </summary>
        /// <param name="category">Категория товаров входящих в скидку.</param>
        public PercentDiscount(Category category)
        {
            _category = category;
            _accumulated = 0;
            _discount = 0.01;
        }

        /// <summary>
        /// Метод для вычисления размера скидки к конкретному заказу.
        /// </summary>
        /// <param name="items">Список товаров в заказе.</param>
        /// <returns>Возвращает количество скидочных баллов.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;

            if (_discount > 0)
            {


                foreach (Item item in items)
                {
                    if (_category == item.Category)
                    {
                        amount += item.Cost;
                    }
                }

                return amount * _discount;
            }

            else
            {
                return amount;
            }
        }

        /// <summary>
        /// Метод применяет скидку к товарам. Возвращает цену с учётом скидки.
        /// </summary>
        /// <param name="items">Список товаров в корзине.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double amount = 0;

            foreach (Item item in items)
            {
                if (_category == item.Category)
                {
                    amount += item.Cost;
                }
            }

            if (_discount > 0)
            {

                amount -= amount * _discount;
                return Math.Ceiling(amount);
            }

            else
            {
                return amount;
            }
        }

        /// <summary>
        /// Добавляет бонусы на основе добавленных товаров
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if (_discount < 1)
            {
                double amount = 0;

                foreach (Item item in items)
                {
                    if (_category == item.Category)
                    {
                        amount += item.Cost;
                    }
                }

                _accumulated += amount;
                if (_accumulated > 10000)
                {
                    _discount = 0.1;
                }

                else if (_accumulated > 1000)
                {
                    _discount = Math.Floor(_accumulated / 1000) * 0.01;
                }

                else
                {
                    _discount = 0;
                }
            }
        }
    }
}
