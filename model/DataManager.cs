using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace model
{
    public class DataManager
    {

        private Dictionary<String, Airport> airports;
        private const string PATH = "..\\..\\..\\data.csv";

        public DataManager()
        {
            airports = new Dictionary<string, Airport>();
            
        
        }

        public List<Flight> getFlights(String iata)
        {
            return airports[iata]
        }

        public void readInfo()
        {
            var url = "https://query.data.world/s/6ankomqkxpsxwh4nnxjnw4ffvc7knf";
            var client = new WebClient();
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))
            {
                string line;
                int count = 0;
                while ((count < 1000) && (line = reader.ReadLine()) != null)
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
                    count++;
                }

                reader.Close();
            }

            

            /*
            StreamReader sr = new StreamReader(PATH);
            string line;

            flights.Clear();
            while ((line = sr.ReadLine()) != null )
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

            sr.Close();*/
        }
    }
}
