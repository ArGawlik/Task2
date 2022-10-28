using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.VehicleElements;

namespace Task3.Vehicles
{
    internal class Scooter : Vehicle
    {
        public Scooter()
        {
            type = "Scooter";
            engine = new Engine(80, null, EngineType.Electric, "HJKFG3487");
            chassis = new Chassis(2, "YUIR5676", 160);
            transmission = new Transmission(TransmissionTypes.Auto, 4, "Honda");
        }
    }
}
