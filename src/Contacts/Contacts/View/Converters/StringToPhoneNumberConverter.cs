using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Contacts.View.Converters
{
    /// <summary>
    /// Класс конвертирующий входную строку в номер телефона.
    /// Позволяет вводить только цифры
    /// </summary>
    internal class StringToPhoneNumberConverter : IValueConverter
    {
        /// <summary>
        /// Метод преобразующий входную строку в номер телефона нужного вида.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Правильную строку</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            //retrieve only numbers in case we are dealing with already formatted phone no
            string phoneNumber = new string(value.ToString().Where(char.IsDigit).ToArray());

            try
            {
                return Regex.Replace(phoneNumber, @"(\d{1})(\d{3})(\d{3})(\d{2})(\d{2})", "+$1 ($2) $3-$4-$5");
            }
            catch
            {
                return phoneNumber;
            }

        }

        /// <summary>
        /// Метод для обратного конвертирования. Не используется.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
