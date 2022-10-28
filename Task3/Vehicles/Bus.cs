using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3.Vehicles
{
    internal class Bus : Vehicle
    {
        int seatsNumber;
        public Bus(int seatsNumber)
        {
            type = "Bus";
            engine = new Engine(250, 4.5, EngineType.Diesel, "KRV99999");
            chassis = new Chassis(6, "POIU57679", 5000);
            transmission = new Transmission(TransmissionTypes.Auto, 8, "Man");
            this.seatsNumber = seatsNumber;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nAdditional info:" +
                "\nSeats number: " + seatsNumber;
        }
    }
}
