using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightReservation.Data
{
    public class FlightReservation
    {
        private string flightCode;
        private string airlineName;
        private string airportOrigin;
        private string airportDest;
        private string flightDay;
        private string flightTime;
        private string flightCost;
        private string passengerName;
        private string passengerCitizenship;
        private string reservationID;
        
        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string AirlineName { get => airlineName; set => airlineName = value; }
        public string AirportOrigin { get => airportOrigin; set => airportOrigin = value; }
        public string AirportDest { get => airportDest; set => airportDest = value; }
        public string FlightDay { get => flightDay; set => flightDay = value; }
        public string FlightTime { get => flightTime ; set => flightTime = value; }
        public string FlightCost { get => flightCost; set => flightCost = value; }
        public string PassengerName { get => passengerName; set => passengerName = value; }
        public string PassengerCitizenship { get => passengerCitizenship; set => passengerCitizenship = value; }
        public string ReservationID { get => reservationID; set => reservationID = value; }
        
        public FlightReservation() { }

        public FlightReservation(string flightCode, string airlineName, string airportOrigin, string airportDest, string flightDay, string flightTime, string flightCost, string passengerName, string passengerCitizenship, string reservationID)
        {
            this.FlightCode = flightCode;
            this.AirlineName = airlineName;
            this.AirportOrigin = airportOrigin;
            this.AirportDest = airportDest;
            this.FlightDay = flightDay;
            this.FlightTime = flightTime;
            this.FlightCost = flightCost;
            this.PassengerName = passengerName;
            this.PassengerCitizenship = passengerCitizenship;
            this.ReservationID = reservationID;
        }

        public override string ToString()
        {
            return $"Reservation ID: {ReservationID}, Name: {PassengerName}, Citizenship: {PassengerCitizenship}, Flight Number: {FlightCode}, Airline Name: {AirlineName}, Departure Airport: {AirportOrigin}, Arrival Airport: {AirportDest}, Day: {FlightDay}, Flight Time: {FlightTime}, Flight Cost: {FlightCost}"; ;
        }


    }
}
