using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int DurationInMinutes { get; set; }
        public int DistanceInMiles { get; set; }
        public int AirportId { get; set; }
        public int ArrivalAirportId { get; set; }
    }
}
