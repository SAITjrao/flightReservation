using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightReservation.Data
{
    public class Flight
    {
        private string flightCode;
        private string flightAirline;
        private string flightOrigin;
        private string flightDest;
        private string flightDay;
        private string flightTime;
        private double flightCost;

        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string FlightAirline { get => flightAirline; set => flightAirline = value; }
        public string FlightOrigin { get => flightOrigin; set => flightOrigin = value; }
        public string FlightDest { get => flightDest; set => flightDest = value; }
        public string FlightDay { get => flightDay; set => flightDay = value; }
        public string FlightTime { get => flightTime; set => flightTime = value; }
        public double FlightCost { get => flightCost; set => flightCost = value; }

        public Flight() {  }

        public Flight(string flightCode, string flightAirline, string flightOrigin, string flightDest, string flightDay, string flightTime, double flightCost)
        {
            this.FlightCode = flightCode;
            this.FlightAirline = flightAirline;
            this.FlightOrigin = flightOrigin;
            this.FlightDest = flightDest;
            this.FlightDay = flightDay;
            this.FlightTime = flightTime;
            this.FlightCost = flightCost;
        }

        public override string ToString()
        {
            return $"Flight Number: {FlightCode}, Airline Name: {FlightAirline}, Departure Airport: {FlightOrigin}, Arrival Airport: {FlightDest}, Day: {flightDay}, Flight Time: {FlightTime}, Flight Cost: {FlightCost}";
        }
    }
}
