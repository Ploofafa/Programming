using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace Contacts.View.Converters
{
    /// <summary>
    /// Класс выполняющий преобразование из строки в номер. Также не даёт
    /// записывать буквы в строку.
    /// </summary>
    public class NumberToPhoneConverter : IValueConverter
    {
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

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
