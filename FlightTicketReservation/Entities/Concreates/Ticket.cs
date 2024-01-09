using FlightTicketReservation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservation.Entities.Concreates
{
    public class Ticket
    {
        public FlightInformation FlightInformation { get; set; }
        public Passenger Passanger { get; set; }
        public string PNRNumber { get; set; }
        public int LuggageCapacity { get; set; }

    }
}
