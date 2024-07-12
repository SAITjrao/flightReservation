using System.ComponentModel.DataAnnotations;



namespace flightReservation.Data
{
    //display error messages if no name or citizenship are entered
    public class ReservationManager
    {
        private string flightCode;
        private string passengerName;
        private string passengerCitizenship;
        private string reservationCode;

        [Required(ErrorMessage = "Please select a flight.")]
        public string FlightCode { get => flightCode; set => flightCode = value; }

        [Required(ErrorMessage = "Name is required.")]
        public string PassengerName { get => passengerName; set => passengerName = value; }

        [Required(ErrorMessage = "Citizenship is required.")]
        public string PassengerCitizenship { get => passengerCitizenship; set => passengerCitizenship = value; }

        public string ReservationCode { get => reservationCode; set => reservationCode = value; }


        //generate a random reservation code 1character + 3numbers
        public static string generateReservationCode()
        {
            Random random = new Random();

            // Generate a random letter
            char letter = (char)random.Next('A', 'Z' + 1);

            // Generate a random three-digit number
            int number = random.Next(100, 1000);

            // Combine letter and number to form code
            string reservationCode = $"{letter}{number}";

            return reservationCode;
        }
    }

}
