using Task3.VehicleElements;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine truckEngine = new Engine(500, 6.0, EngineType.Diesel, "ASD123");
            Chassis truckChasis = new Chassis(8, "FGH8824", 10000);
            Transmission truckTranssmition = new Transmission(TransmissionTypes.Manual, 6, "Volvo");
            Engine carEngine = new Engine(120, 1.8, EngineType.Gasoline, "TUY5775");
            Chassis carChasis = new Chassis(4, "FFLJ7824", 1500);
            Transmission carTransmission = new Transmission(TransmissionTypes.Manual, 6, "Skoda");
            Engine busEngine = new Engine(250, 4.5, EngineType.Diesel, "KRV99999");
            Chassis busChasis = new Chassis(6, "POIU57679", 5000);
            Transmission busTransmission = new Transmission(TransmissionTypes.Auto, 8, "AutoSan");
            Engine scooterEngine = new Engine(80, null, EngineType.Electric, "HJKFG3487");
            Chassis scooterChasis = new Chassis(2, "YUIR5676", 160);
            Transmission scooterTransmission = new Transmission(TransmissionTypes.Auto, 4, "Honda");

            Vehicle truck = new Vehicle("Truck", truckChasis, truckEngine, truckTranssmition);
            Vehicle passengerCar = new Vehicle("Passenger car", carChasis, carEngine, carTransmission);
            Vehicle bus = new Vehicle("Bus", busChasis, busEngine, busTransmission);
            Vehicle scooter = new Vehicle("Scooter", scooterChasis, scooterEngine, scooterTransmission);

            Console.WriteLine(truck);
            Console.WriteLine("\n");            
            Console.WriteLine(passengerCar);
            Console.WriteLine("\n");            
            Console.WriteLine(bus);
            Console.WriteLine("\n");            
            Console.WriteLine(scooter);
        }
    }
}