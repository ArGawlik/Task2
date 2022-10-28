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

            Vehicle[] vehicles = { truck, passengerCar, bus, scooter };
            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle + 
                    "\n____________________________________");
            }
        }
    }
}