using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Flight
    {

        private String airLineID;
        private String origin;
        private String destination;
        private String departureTime;
        private String arriveTime;
        private String date;
        private String distance;
        private String flightTime;
        private Boolean isLate;

        public Flight(String airLineID, String origin, String destination, String departureTime,
            String arriveTime, String date, String distance, String flightTime, Boolean isLate)
        {
            this.airLineID = airLineID;
            this.origin = origin;
            this.destination = destination;
            this.departureTime = departureTime;
            this.arriveTime = arriveTime;
            this.date = date;
            this.distance = distance;
            this.flightTime = flightTime;
            this.isLate = isLate;
        }

        public String AirLineID { get => airLineID; set => airLineID = value; }
        public String Origin { get => origin; set => origin = value; }
        public String Destination { get => destination; set => destination = value; }
        public String DepartureTime { get => departureTime; set => departureTime = value; }
        public String ArriveTime { get => arriveTime; set => arriveTime = value; }
        public String Date { get => date; set => date = value; }
        public String Distance { get => distance; set => distance = value; }
        public String FlightTime { get => flightTime; set => flightTime = value; }
        public Boolean IsLate { get => isLate; set => isLate = value; }
    }
}
