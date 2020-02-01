using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DataManager
    {

        private List<Flight> flights;
        private const string PATH = "..\\..\\..\\data.csv";

        public DataManager()
        {

            flights = new List<Flight>();
        
        }

        public List<Flight> Flights
        {

            get 
            {
                return flights;   
            }
        
        }

        public void readInfo()
        {
            StreamReader sr = new StreamReader(PATH);
            string line;

            flights.Clear();
            while ((line = sr.ReadLine()) != null)
            {
                string[] args = line.Split(',');

                string airLineID = args[7];
                string origin = args[15];
                string destination = args[24];
                string departureTime = args[30];
                string arriveTime = args[41];
                string date = args[5];
                string distance = args[54];
                string flightTime = args[52];
                Boolean isLate = false;
                Flight flight = new Flight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                flights.Add(flight);
            }

            sr.Close();
        }
    }
}
