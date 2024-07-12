using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightReservation.Data
{
    public class Airport
    {
        private string airportCode;
        private string airportName;

        public string AirportCode { get => airportCode; set => airportCode = value; }
        public string AirportName { get => airportName; set => airportName = value; }

        public Airport() { }

        public Airport(string airportCode, string airportName)
        {
            this.AirportCode = airportCode;
            this.AirportName = airportName;
        }
    }
}
