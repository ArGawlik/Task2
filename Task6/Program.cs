using System.Xml.Linq;
using Task3.VehicleElements;
using Task3.Vehicles;
using Task5;
using Task6;
using Task6.Exceptions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates few cars
            PassengerCar car1 = new PassengerCar(250, 200, 2.5, EngineType.Gasoline, 6, TransmissionTypes.Manual, "asd1234");
            PassengerCar car2 = new PassengerCar(180, 100, 1.5, EngineType.Diesel, 5, TransmissionTypes.Manual, "adg5674");
            PassengerCar car3 = new PassengerCar(350, 100, 6, EngineType.Diesel, 10, TransmissionTypes.Auto, "kjla988");
            PassengerCar car4 = new PassengerCar(220, 120, null, EngineType.Electric, 8, TransmissionTypes.Auto, "jhd8293");
            Bus bus = new Bus(60, 250, 4.5, EngineType.Diesel, 8, TransmissionTypes.Auto, "uioj789");

            // initialization exception - passenger car speed must be between 90-350
            try
            {
                PassengerCar car5 = new PassengerCar(380);
            }
            catch (InitializationException e)
            {
                Console.WriteLine(e.Message);
            }

            // other initialization exception - electric engines don't have volume
            try
            {
                Scooter scooter = new Scooter(true, 80, 1.2, EngineType.Electric, 4, TransmissionTypes.Manual, "asd4562");
            }
            catch (InitializationException e)
            {

                Console.WriteLine(e.Message);
            }

            // creating new parking object with cars and with size = 5
            Parking parking = new(5);
            parking.Add(car1).Add(car2).Add(car3).Add(car4).Add(bus);

            // add exception - cannot add more cars
            try
            {
                parking.Add(new PassengerCar(200));
            }
            catch (AddException e)
            {
                Console.WriteLine(e.Message);
            }


            // get cars with specified parameter and value
            var a = parking.GetAutoByParameter("transmissionType", "Auto");
            Console.WriteLine(a.Count); //3


            // exception - ivalid parameter and value
            try
            {
                var s = parking.GetAutoByParameter("someInvalidParameter", "Manual");
            }
            catch (GetAutoByParameterException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var d = parking.GetAutoByParameter("transmissionType", "InvalidType");
            }
            catch (GetAutoByParameterException e)
            {
                Console.WriteLine(e.Message);
            }

            PassengerCar car6 = new PassengerCar(280, 300, 4.5, EngineType.Gasoline, 6, TransmissionTypes.Manual, "siud2893");
            
            // update exception - invalid id
            try
            {
                parking.UpdateAuto("someInvalidId", car6);
            }
            catch(UpdateAutoException e)
            {
                Console.WriteLine(e.Message);
            }

            // updating 1 car
            parking.UpdateAuto("asd1234", car6);
            Console.WriteLine(parking.Cars.Count); // 5


            //remove exception - invalid id
            try
            {
                parking.RemoveAuto("someInvalidId");
            }
            catch (RemoveAutoException e)
            {
                Console.WriteLine(e.Message);
            }

            //removing 1 car
            parking.RemoveAuto("siud2893");
            Console.WriteLine(parking.Cars.Count); // 4
        }
    }
}