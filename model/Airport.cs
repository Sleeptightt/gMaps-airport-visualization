using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    
    class Airport
    {
        private String iataID;
        private List<Flight> flights;

        public Airport(String iataID)
        {
            this.iataID = iataID;
            flights = new List<Flight>();
        }
        public List<Flight> getFlights()
        {
            return flights;
        }

        public void addFlight(string airLineID, string origin, string destination, string departureTime,
            string arriveTime, string date, string distance, string flightTime, bool isLate)
        {
            Flight flight = new Flight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
            flights.Add(flight);
        }
    }
}
