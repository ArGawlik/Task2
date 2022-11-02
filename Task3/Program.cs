using Task3.VehicleElements;
using Task3.Vehicles;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Truck(3.8);
            Vehicle passengerCar = new PassengerCar(250);
            Vehicle bus = new Bus(50);
            Vehicle scooter = new Scooter(true);

            List<Vehicle> vehicles = new List<Vehicle>() { truck, passengerCar, bus, scooter };

            var first = from vehicle in vehicles
                        where vehicle.engine.volume > 1.5
                        select vehicle;

            var second = from vehicle in vehicles
                         where vehicle.GetType().Name.Equals("Bus") || vehicle.GetType().Name.Equals("Truck")
                         select vehicle;

            var third = from vehicle in vehicles
                        where vehicle.transmission.type == TransmissionTypes.Auto
                        select vehicle;

            Console.WriteLine("All information about all vehicles an engine capacity of which is more than 1.5 liters:");
            foreach(var vehicle in first)
            {
                Console.WriteLine(vehicle.getXmlInformation() + "\n");
            }

            Console.WriteLine("Engine type, serial number and power rating for all buses and trucks:");
            foreach(var vehicle in second)
            {
                Console.WriteLine(vehicle.GetType().Name + ":");
                Console.WriteLine(vehicle.engine.getXmlInformation() + "\n");
            }
        }
    }
}