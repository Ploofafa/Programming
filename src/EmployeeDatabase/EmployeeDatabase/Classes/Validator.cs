using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabase.Classes
{
    public static class Validator
    {
        /// <summary>
        /// Метод для проверки вхождения значения
        /// в промежуток.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница интервала.</param>
        /// <param name="max">Верхняя граница интервала.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <returns>Возвращает входное значение, при успешной проверке.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int AssertValueInRange(int value, int min, int max)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"{nameof(value)} must be in range [{min}, {max}].");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        public static string AssertStringContainsOnlyLetters(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) & string.Compare(Convert.ToString(value[i]), " ") == 1)
                {
                    throw new ArgumentException($"{nameof(value)} must be alphabetic characters only.");
                }
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
        /// Проверяет, что дата не больше сегодняшнего дня.
        /// </summary>
        /// <param name="value">Проверяемая дата.</param>
        public static DateTime AssertOnCorrectDate(DateTime value)
        {
            if (value > DateTime.Today)
            {
                throw new ArgumentException($"{nameof(value)} date can't be more than today");
            }
            return value;
        }
    }
}
