using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightReservation.Data
{
    public class FlightManager
    {
        //C:\Users\Jazz\source\repos\flightReservation\flightReservation
        string FILE_NAME = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\flights.csv");
        public static List<Flight> flights = new List<Flight>(); //initialize empty list of flight objects

        public FlightManager()
        {
            populateFlights();
        }

        private void populateFlights()
        {
            Flight flight ;

            foreach (string line in File.ReadLines(FILE_NAME))
            {
                string[] parts = line.Split(",");
                string flightCode = parts[0];
                string flightAirline = parts[1];
                string flightOrigin = parts[2];
                string flightDest = parts[3];
                string flightDay = parts[4];
                string flightTime = parts[5];
                double flightCost = Convert.ToDouble(parts[7]);

                flight = new Flight(flightCode, flightAirline, flightOrigin, flightDest, flightDay, flightTime, flightCost) ; //create new flight object
                flights.Add(flight); //add flights to flight list
            }
        }

        public static List<Flight> GetFlights()
        {
            return flights;
        }

    }
}
