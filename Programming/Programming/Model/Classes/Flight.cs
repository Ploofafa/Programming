using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _duration;

        public Flight()
        {
        }
        
        public Flight(string departurePoint,
                      string arrivalPoint,
                      int flightDuration)
        {
            FlightDuration = flightDuration;
            DeparturePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
        }
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

        public string DeparturePoint { get; set; }

        public string ArrivalPoint { get; set; }
    }
}
