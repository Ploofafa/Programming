using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Хранит количество накопленных баллов для скидки.
        /// </summary>
        private double _points;

        /// <summary>
        /// Возвращает и задаёт количество бонусных баллов.
        /// </summary>
        public double Points
        {
            get
            {
                return _points;
            }

            private set
            {
                _points = value;
            }
        }

        public string Info
        {
            get
            {
                return $"info:Накопительная - {_points} баллов.";
            }
        }

        public PointsDiscount()
        {
            _points = 0;
        }

        /// <summary>
        /// Метод для вычисления размера скидки к конкретному заказу.
        /// </summary>
        /// <param name="items">Список товаров в заказе.</param>
        /// <returns>Возвращает количество скидочных баллов.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;

            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            if (_points <= Math.Floor(amount * 0.3))
            {
                return _points;
            }

            else
            {
                return amount * 0.3;
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
                amount += item.Cost;
            }

            if (_points <= Math.Floor(amount * 0.3))
            {
                amount -= _points;
                _points = 0;
                return amount;
            }

            else
            {
                _points -= Math.Ceiling(amount * 0.3);
                return amount - Math.Ceiling(amount * 0.3);
            }
        }

        /// <summary>
        /// Добавляет бонусы на основе добавленных товаров
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = 0;

            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            _points += Math.Ceiling(amount * 0.1);
        }
    }
}
