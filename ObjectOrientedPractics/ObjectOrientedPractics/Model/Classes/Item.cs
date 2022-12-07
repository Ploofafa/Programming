﻿using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueValidator = ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Описывает класс товаров.
    /// </summary>
    public class Item
    {
        /// <summary>
		/// Хранит Id товара в программе.
		/// </summary>
		private readonly int _id;

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
        private double _cost;

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = "Default Name";
            Info = "Add description";
            Cost = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Должно содержать не больше 200 символов.</param>
        /// <param name="info">Описание товара. Должно содержать не больше 1000 символов.</param>
        /// <param name="cost">Стоимость товара. Лежит в пределах от 0 до 100 000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = category;
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
                ValueValidator.AssertStringOnMaxLength(value, 201);
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
                ValueValidator.AssertStringOnMaxLength(value, 1001);
                _info = value;

            }
        }

        /// <summary>
        /// Задаёт и возвращает стоимость товара. Лежит в пределах от 0 до 100 000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000);
                _cost = value;
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

        public Category Category { get; set; }
    }
}
