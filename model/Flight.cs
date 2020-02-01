using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Flight
    {

        private string airLineID;
        private string origin;
        private string destination;
        private string departureTime;
        private string arriveTime;
        private string date;
        private string distance;
        private string flightTime;
        private Boolean isLate;

        public Flight(string airLineID, string origin, string destination, string departureTime, 
            string arriveTime, string date, string distance, string flightTime, bool isLate)
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

        public string AirLineID { get => airLineID; set => airLineID = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public string DepartureTime { get => departureTime; set => departureTime = value; }
        public string ArriveTime { get => arriveTime; set => arriveTime = value; }
        public string Date { get => date; set => date = value; }
        public string Distance { get => distance; set => distance = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
        public bool IsLate { get => isLate; set => isLate = value; }
    }
}
