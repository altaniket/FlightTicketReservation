using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservation.Enums
{
    internal enum FlightStatus
    {
        LastCall,
        Departed,
        GateClosed,
        Boarding,
        CounterOpen,
        CounterClosed,
        Delayed
    }
}
