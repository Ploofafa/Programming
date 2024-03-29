﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{

    /// <summary>
    /// Класс хранящий методы проверки значений полей.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Метод для проверки вхождения значения
        /// в промежуток.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница интервала.</param>
        /// <param name="max">Верхняя граница интервала.</param>
        /// <param name="name">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <returns>Возвращает входное значение, при успешной проверке.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double AssertValueInRange(double value, double min, double max)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"{nameof(value)} must be in range [{min}, {max}]");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что строка меньше максимальной длины.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина</param>
        public static string AssertStringOnMaxLength(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{nameof(value)} must contain less symbols.");
            }
            return value;
        }

        /// <summary>
        /// Проверяет целочисленное число на нужно количество цифр.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="length">Сколько цифр должно содержать.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Сообщение об ошибке.</exception>
        public static string AssertOnIndex(string value, int length)
        {
            if (value != null)
            {
                foreach (char symbol in value)
                {
                    if (symbol < '0' || symbol > '9')
                    {
                        throw new ArgumentException($"{nameof(value)} must contain only numbers.");
                    }
                }

                if (value.Length != length & value != "")
                {
                    throw new ArgumentException($"{nameof(value)} must contain only {length} symbols.");
                }
            }
            return value;
        }
    }
}
