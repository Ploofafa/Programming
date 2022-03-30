using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightDuration;
        private string _departurePoint;
        private string _arrivalPoint;

        public Flight()
        {
        }
        public Flight MakeFlight(string departurePoint,
                                string arrivalPoint,
                                int flightDuration)
        {
            Flight flight = new Flight();
            _flightDuration = flightDuration;
            _departurePoint = departurePoint;
            _arrivalPoint = arrivalPoint;
            return flight;
        }
        public int FlightDuration 
        {
            set
            {
                if (value < 3 | value > 1140)
                {
                    throw new ArgumentOutOfRangeException("Flight Duration may be only > 0 and < 1140");
                }
                
                _flightDuration = value;
            }
            get
            {
                return _flightDuration;
            }
        }
        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }
    }
}
