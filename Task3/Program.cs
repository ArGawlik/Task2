using System.Xml.Linq;
using Task3.VehicleElements;
using Task3.Vehicles;
using Task5;

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

            // step 1

            var highEngineCap = from vehicle in vehicles
                        where vehicle.engine.volume > 1.5
                        select vehicle;

            Console.WriteLine("All information about all vehicles an engine capacity of which is more than 1.5 liters:");
            foreach(var vehicle in highEngineCap)
            {
                Console.WriteLine(UtilXmlWriter.WriteXml(vehicle.getXmlElement()) + "\n");
            }
            UtilXmlWriter.SaveToXmlFile("file1.xml", "EngineCapMoreThan1.5", highEngineCap.Select(x => x.getXmlElement()).ToArray());

            // step 2

            var bussesAndTrucks = from vehicle in vehicles
                         where vehicle.GetType().Name.Equals("Bus") || vehicle.GetType().Name.Equals("Truck")
                         select vehicle;

            Console.WriteLine("Engine type, serial number and power rating for all buses and trucks:");
            foreach(var vehicle in bussesAndTrucks)
            {
                var x = UtilXmlWriter.ConcatElements(vehicle.GetType().Name, vehicle.engine.getXmlElement());
                Console.WriteLine(UtilXmlWriter.WriteXml(x) + "\n");
            }
            UtilXmlWriter.SaveToXmlFile("file2.xml", "BussesAndTrucksEngines", bussesAndTrucks.Select(x => x.engine.getXmlElement()).ToArray());

            // step 3

            Console.WriteLine("All information about all vehicles, grouped by transmission type:");
            var grouped = vehicles.GroupBy(v => v.transmission.type);
            List<XElement> groupedElements = new();
            foreach(var g in grouped)
            {
                var a = UtilXmlWriter.ConcatElements(g.Key.ToString(), g.Select(v => v.getXmlElement()).ToArray());
                Console.WriteLine(UtilXmlWriter.WriteXml(a));
                groupedElements.Add(a);
            }
            UtilXmlWriter.SaveToXmlFile("file3.xml", "Transmission", groupedElements.ToArray());
        }
    }
}