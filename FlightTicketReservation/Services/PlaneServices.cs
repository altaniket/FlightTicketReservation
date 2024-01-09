using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightTicketReservation.Entities.Concreates;

namespace FlightTicketReservation.Services
{
    public class PlaneServices
    {
        private static List<Plane> Planes = new List<Plane>()
        {
        new Plane()
           {
               Brand = "AirBus",
               Model ="A319",
               ModelYear=2020,
               PassangerCapacity = 156,
               CargoCapacity=0,
               TotalFlightWeightLimit=79015,
               AircraftWeight=415000,
               FuelCapacity=26000
           },
        new Plane()
        {
            Brand = "Airbus",
            Model = "A320",
            ModelYear = 2015,
            PassangerCapacity = 150,
            CargoCapacity = 5000,
            AircraftWeight = 75000,
            TotalFlightWeightLimit = 100000,
            FuelCapacity = 30000
        },
        new Plane()
        {
            Brand = "Boeing",
            Model = "747",
            ModelYear = 2010,
            PassangerCapacity = 400,
            CargoCapacity = 10000,
            AircraftWeight = 120000,
            TotalFlightWeightLimit = 150000,
            FuelCapacity = 50000
        },
        new Plane()
        {
            Brand = "Embraer",
            Model = "E190",
            ModelYear = 2018,
            PassangerCapacity = 100,
            CargoCapacity = 3000,
            AircraftWeight = 50000,
            TotalFlightWeightLimit = 75000,
            FuelCapacity = 20000
        }
        
        };
    public List<Plane>GetPlaneList()
        {
            return Planes;
        }
    // Get Plane information by name
    public Plane GetPlaneByName(string name)
        {
            return Planes.Where(x => x.Model == name).FirstOrDefault();
        }
    }
}
