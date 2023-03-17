using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{

    /// <summary>
    /// Содержит информацию о перелёте: длительность полёта,
    /// точка вылета, точка прибытия.
    /// </summary>
    public class Flight
    {

        /// <summary>
        /// Длительность полёта.
        /// Должна быть не меньше трёх минут и не больше 1140 минут.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Точка вылета.</param>
        /// <param name="arrivalPoint">Точка прибытия.</param>
        /// <param name="flightDuration">Длительность полёта.
        /// Должна быть не меньше трёх минут и не больше 1140 минут.</param>
        public Flight(string departurePoint,
                      string arrivalPoint,
                      int flightDuration)
        {
            FlightDuration = flightDuration;
            DeparturePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
        }

        /// <summary>
        /// Возвращает и задаёт длительность полёта.
        /// Должна быть не меньше трёх минут и не больше 1140 минут.
        /// </summary>
        public int FlightDuration 
        {
            get
            {
                return _duration;
            }

            set
            {
                Validator.AssertValueInRange(value, 3, 1140, nameof(FlightDuration));
                _duration = value;
            }   
        }

        /// <summary>
        /// Возвращает и задаёт точку отправки.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт точку прибытия.
        /// </summary>
        public string ArrivalPoint { get; set; }
    }
}
