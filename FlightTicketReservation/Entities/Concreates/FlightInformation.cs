﻿using FlightTicketReservation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservation.Entities.Concreates
{
    public class FlightInformation
    {
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public Plane Aircraft { get; set; }
        public TimeOnly Time { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightDuration { get; set; }
        public string FlightNumber { get; set; }
        public string GateNumber { get; set; }
        public int EmptySeats { get; set;}
        public FlightStatus Status { get; set; }
        public int PromoSeatsCount { get; set; }
    }
}
