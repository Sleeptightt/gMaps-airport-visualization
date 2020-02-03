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
        private List<Flight> arrivingFlights;
        private List<Flight> departingFlights;

        public Airport(String iataID)
        {
            this.iataID = iataID;
            arrivingFlights = new List<Flight>();
            departingFlights = new List<Flight>();
        }
        public List<Flight> getDepartingFlights()
        {
            return departingFlights;
        }

        public List<Flight> getArrivingFlights()
        {
            return arrivingFlights;
        }

        public void addDepartingFlight(String airLineID, String origin, String destination, String departureTime,
            String arriveTime, String date, String distance, String flightTime, Boolean isLate)
        {
            Flight flight = new Flight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
            departingFlights.Add(flight);
        }

        public void addArrivingFlight(String airLineID, String origin, String destination, String departureTime,
            String arriveTime, String date, String distance, String flightTime, Boolean isLate)
        {
            Flight flight = new Flight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
            arrivingFlights.Add(flight);
        }
    }
}
