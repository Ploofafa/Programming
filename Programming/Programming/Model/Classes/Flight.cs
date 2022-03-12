using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string DeparturePoint;
        private string ArrivalPoint;
        private int FlightDuration;

        public Flight MakeFlight(string departurePoint,
                                string arrivalPoint,
                                int flightDuration)
        {
            Flight flight = new Flight();
            SetDeparturePoint(flight, departurePoint);
            SetArrivalPoint(flight, arrivalPoint);
            SetFlightDuration(flight, flightDuration);
            return flight;
        }
        public void SetDeparturePoint(Flight flight, string departurePoint)
        {
            flight.DeparturePoint = departurePoint;
        }
        public void SetArrivalPoint(Flight flight, string arrivalPoint)
        {
            flight.ArrivalPoint = arrivalPoint;
        }
        public void SetFlightDuration(Flight flight, int flightDuration)
        {
            flight.FlightDuration = flightDuration;
        }
        public string GetDeparturePoint(Flight flight)
        {
            return flight.DeparturePoint;
        }
        public string GetArrivalPoint(Flight flight)
        {
            return flight.ArrivalPoint;
        }
        public int GetFlightDuration(Flight flight)
        {
            return flight.FlightDuration;
        }
    }
}
