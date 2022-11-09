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
        public bool removableBattery;
        public Scooter(bool removableBattery)
        {
            type = "Scooter";
            engine = new Engine(80, null, EngineType.Electric, "HJKFG3487");
            chassis = new Chassis(2, "YUIR5676", 160);
            transmission = new Transmission(TransmissionTypes.Auto, 4, "Honda");
            this.removableBattery = removableBattery;
            additionalInfo = "Has removable battery: " + removableBattery;
        }

        public Scooter(bool removableBattery, int enginePower, double? engineVolume, EngineType engineType, int transmissionGearsNumber, TransmissionTypes transmissionType, string carId) : base(enginePower, engineVolume, engineType, transmissionGearsNumber, transmissionType, carId)
        {
            type = "Scooter";
            engineType = EngineType.Electric;
            engine = new Engine(enginePower, engineVolume, engineType, "HJKFG3487");
            chassis = new Chassis(2, "YUIR5676", 160);
            transmission = new Transmission(transmissionType, transmissionGearsNumber, "Honda");
            this.removableBattery = removableBattery;
            additionalInfo = "Has removable battery: " + removableBattery;
        }
    }
}
