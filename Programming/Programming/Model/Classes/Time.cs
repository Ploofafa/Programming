using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о времени в настоящий момент:
    /// часы, минуты, секунды.
    /// </summary>
    public class Time
    {

        /// <summary>
        /// Количество часов. Должно лежать в промежутке от 0 до 24
        /// </summary>
        private int _hour;

        /// <summary>
        /// Количество минут. Должно лежать в промежутке от 0 до 60.
        /// </summary>
        private int _minute;

        /// <summary>
        /// Количество секунд. Должно лежать в промежутке от 0 до 60.
        /// </summary>
        private int _second;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hour">Количество минут. Лежит в промежутке от 0 до 60.</param>
        /// <param name="minute">Количество минут. Лежит в промежутке от 0 до 60.</param>
        /// <param name="second">Количество секунд. Лежит в промежутке от 0 до 60.</param>
        public Time(int hour,
                    int minute,
                    int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        /// <summary>
        /// Возвращает и задаёт значение количества часов. Должно лежать 
        /// в промежутке от 0 до 24.
        /// </summary>
        public int Hour
        {
            get 
            { 
                return _hour;
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hour));
                _hour = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение количества минут. Должно лежать
        /// в промежутке от 0 до 60.
        /// </summary>
        public int Minute
        {
            get 
            { 
                return _minute;
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Minute));
                _minute = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение количества секунд. Должно лежать
        /// в промежутке от 0 до 60.
        /// </summary>
        public int Second
        {
            get
            {
                return _second;
            }

            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Second));
                _second = value;
            }
        }
    }
}