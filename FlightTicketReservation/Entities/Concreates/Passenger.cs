using FlightTicketReservation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservation.Entities.Concreates
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public string IdentificationNumber { get; set; }
        public string PassportNumber { get; set; }

    }
}
