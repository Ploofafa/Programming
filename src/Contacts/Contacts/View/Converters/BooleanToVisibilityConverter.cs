using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Contacts.View.Converters
{
    /// <summary>
    /// Класс реализующий преобразование типа <see cref="bool"/> к <see cref="Visibility"/>.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Свойство проверяющее нужно ли провести инвертированную конвертацию.
        /// </summary>
        public bool IsInverse { get; set; }

        /// <summary>
        /// Метод преобразующий bool к Visibility.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        /// Метод который конвертирует из <see cref="Visibility"/> в <see cref="bool"/>.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
            {
                return (Visibility)value == Visibility.Visible;
            }
            return false;
        }
    }
}
