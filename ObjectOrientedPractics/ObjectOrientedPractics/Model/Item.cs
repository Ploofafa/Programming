using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator = ObjectOrientedPractics.Services.Validator;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        /// <summary>
		/// Хранит Id товара в программе.
		/// </summary>
		private static int _id;

        /// <summary>
        /// Хранит название товара. Должно содержать не больше 200 символов.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит описание товара. Должно содержать не больше 1000 символов.
        /// </summary>
        private string _info;

        /// <summary>
        /// Хранит стоимость товара. Лежит в пределах от 0 до 100 000.
        /// </summary>
        private double _coast;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id++;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Должно содержать не больше 200 символов.</param>
        /// <param name="info">Описание товара. Должно содержать не больше 1000 символов.</param>
        /// <param name="coast">Стоимость товара. Лежит в пределах от 0 до 100 000.</param>
        public Item(string name, string info, double coast)
        {
            Name = name;
            Info = info;
            Coast = coast;
            _id++;
        }

        /// <summary>
        /// Задаёт и возвращает название товара. Должно содержать не больше 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringOnMaxLength(value, 201);
                _name = value;
            }

        }

        /// <summary>
        /// Задаёт и возвращает описание товара. Должно содержать не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }

            set
            {
                Validator.AssertStringOnMaxLength(value, 1001);
                _info = value;

            }
        }

        /// <summary>
        /// Задаёт и возвращает стоимость товара. Лежит в пределах от 0 до 100 000.
        /// </summary>
        public double Coast
        {
            get
            {
                return _coast;
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 100000);
                _coast = value;
            }

        }

        /// <summary>
        /// Возвращает значение Id товара в программе.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
