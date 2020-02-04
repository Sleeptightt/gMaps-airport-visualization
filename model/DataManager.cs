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

        public List<Flight> getDepartingAirportFlights(String iata)
        {
            return airports[iata].getDepartingFlights();
        }

        public List<Flight> getArrivingAirportFlights(String iata)
        {
            return airports[iata].getArrivingFlights();
        }

        public ISet<string> readInfo()
        {
            var url = "https://query.data.world/s/6ankomqkxpsxwh4nnxjnw4ffvc7knf";
            var client = new WebClient();
            ISet<string> set = new HashSet<string>();
            using (var stream = client.OpenRead(url))
            using (var reader = new StreamReader(stream))

            {
                String line = reader.ReadLine();
                int count = 0;
                while ((count < 1000) && (line = reader.ReadLine()) != null)
                {
                    String[] args = line.Split(',');

                    String airLineID = args[7].Replace("\"", "");
                    String origin = args[14].Replace("\"", "");
                    String destination = args[24].Replace("\"", "");
                    set.Add(args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA"); set.Add(args[25].Split(',')[0].Replace("\"", "") + ", " +args[29].Replace("\"", "") + ", USA");
                    String departureTime = args[31].Replace("\"", "");
                    departureTime = departureTime[0] + "" + departureTime[1] + ":" + departureTime[2] + "" + departureTime[3];
                    String arriveTime = args[42].Replace("\"", "");
                    arriveTime = arriveTime[0] +""+ arriveTime[1] + ":" + arriveTime[2] + "" + arriveTime[3];
                    String date = args[5].Replace("\"", "");
                    String distance = args[56].Replace("\"", "");
                    String flightTime = args[52].Replace("\"", "");
                    Boolean isLate = false;

                    if (airports.ContainsKey(args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA") && airports.ContainsKey(args[25].Split(',')[0].Replace("\"", "") + ", " + args[29].Replace("\"", "") + ", USA"))
                    {
                       airports[args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA"].addDepartingFlight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                       airports[args[25].Split(',')[0].Replace("\"", "") + ", " + args[29].Replace("\"", "") + ", USA"].addArrivingFlight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                    }
                    else
                    {
                        airports[args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA"] = new Airport(args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA");
                        airports[args[25].Split(',')[0].Replace("\"", "") + ", " + args[29].Replace("\"", "") + ", USA"] = new Airport(args[25].Split(',')[0].Replace("\"", "") + ", " + args[29].Replace("\"", "") + ", USA");
                        airports[args[15].Split(',')[0].Replace("\"", "") + ", " + args[19].Replace("\"", "") + ", USA"].addDepartingFlight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                        airports[args[25].Split(',')[0].Replace("\"", "") + ", " + args[29].Replace("\"", "") + ", USA"].addArrivingFlight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                    }
                    count++;
                }
                reader.Close();
                return set;
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
