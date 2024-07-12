using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightReservation.Data
{
    public class AirportManager
    {
        //C:\Users\Jazz\source\repos\flightReservation\flightReservation
        string FILE_NAME = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\airports.csv");
        public static List<Airport> airports = new List<Airport>(); //initialize empty list of airport objects

        public AirportManager()
        {
            populateAirports();
        }

        private void populateAirports()
        {
            Airport airport;

            foreach (string line in File.ReadLines(FILE_NAME))
            {
                string[] parts = line.Split(",");
                string airportCode = parts[0];
                string airportName = parts[1];

                airport = new Airport(airportCode, airportName); //create new airport object
                airports.Add(airport); //add airports to airport list
            }
        }

        public static List<Airport> GetAirports()
        {
            return airports;
        }
    }
}
