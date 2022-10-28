using Task3.VehicleElements;
using Task3.Vehicles;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Truck();
            Vehicle passengerCar = new PassengerCar();
            Vehicle bus = new Bus();
            Vehicle scooter = new Scooter();

            Vehicle[] vehicles = { truck, passengerCar, bus, scooter };
            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle + 
                    "\n____________________________________");
            }
        }
    }
}