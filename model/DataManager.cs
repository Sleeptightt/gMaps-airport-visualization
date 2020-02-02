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
            airports["CLT"] = new Airport("CLT");
            airports["FLL"] = new Airport("FLL");
            airports["RSW"] = new Airport("RSW");
            airports["PHX"] = new Airport("PHX");
            airports["ATL"] = new Airport("ATL");
            airports["DTW"] = new Airport("DTW");
            airports["PBI"] = new Airport("PBI");
            airports["PIT"] = new Airport("PIT");
            airports["PHL"] = new Airport("PHL");
            airports["TPA"] = new Airport("TPA");
            airports["MIA"] = new Airport("MIA");
            airports["LAX"] = new Airport("LAX");
            airports["DAL"] = new Airport("DAL");
            airports["RNO"] = new Airport("RNO");
            airports["LAS"] = new Airport("LAS");
            airports["DEN"] = new Airport("DEN");
            airports["SLC"] = new Airport("SLC");
            airports["MSP"] = new Airport("MSP");
            airports["IAD"] = new Airport("IAD");
            airports["MCO"] = new Airport("MCO");
            airports["CLE"] = new Airport("CLE");
            airports["BOI"] = new Airport("BOI");
            airports["ORD"] = new Airport("ORD");
            airports["TUS"] = new Airport("TUS");
            airports["FAI"] = new Airport("FAI");
            airports["ICT"] = new Airport("ICT");
            airports["AVL"] = new Airport("AVL");
            airports["CVG"] = new Airport("CVG");
            airports["KTN"] = new Airport("KTN");
            airports["LAN"] = new Airport("LAN");
            airports["MEM"] = new Airport("MEM");
            airports["LBB"] = new Airport("LBB");
            airports["RDD"] = new Airport("RDD");
            airports["ROC"] = new Airport("ROC");
            airports["SIT"] = new Airport("SIT");
            airports["SAN"] = new Airport("SAN");
            airports["YUM"] = new Airport("YUM");
            airports["BNA"] = new Airport("BNA");
            airports["TWF"] = new Airport("TWF");
            airports["ABE"] = new Airport("ABE");
            airports["MSO"] = new Airport("MSO");
            airports["SAF"] = new Airport("SAF");
        }

        public List<Flight> getAirportFlights(String iata)
        {
            return airports[iata].getFlights();
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
                    string origin = args[14];
                    string destination = args[24];
                    string departureTime = args[30];
                    string arriveTime = args[41];
                    string date = args[5];
                    string distance = args[54];
                    string flightTime = args[52];
                    Boolean isLate = false;
                    if (airports.ContainsKey(origin) && airports.ContainsKey(destination))
                    {
                        airports[origin].addFlight(airLineID, origin, destination, departureTime, arriveTime, date, distance, flightTime, isLate);
                    }
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
