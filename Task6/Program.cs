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
            PassengerCar car1 = new PassengerCar(250, "asd1234", new Engine(200, 2.5, EngineType.Gasoline, "hfks1234"), new Transmission(TransmissionTypes.Manual, 6, "Skoda"), new Chassis(4, "fhfkai4123", 2000));
            PassengerCar car2 = new PassengerCar(180, "adg5674", new Engine(100, 1.5, EngineType.Diesel, "kfgni845"), new Transmission(TransmissionTypes.Manual, 5, "Skoda"), new Chassis(4, "thfghtai4123", 1800));
            PassengerCar car3 = new PassengerCar(350, "kjla988", new Engine(250, 6, EngineType.Gasoline, "dkpjsd234"), new Transmission(TransmissionTypes.Auto, 10, "BMW"), new Chassis(4, "86fkai4123", 2000));
            PassengerCar car4 = new PassengerCar(220, "jhd8293", new Engine(120, null, EngineType.Electric, "hfks1234"), new Transmission(TransmissionTypes.Auto, 8, "Tesla"), new Chassis(4, "55sai4123", 1700));
            Bus bus = new Bus(60, "uioj789", new Engine(250, 4.5, EngineType.Diesel, "fgij1283"), new Transmission(TransmissionTypes.Auto, 8, "Mercedes"), new Chassis(8, "uhnf934", 3800));

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
                PassengerCar car5 = new PassengerCar(220, "jhd8293", new Engine(120, 2, EngineType.Electric, "hfks1234"), new Transmission(TransmissionTypes.Auto, 8, "Tesla"), new Chassis(4, "55sai4123", 1700));
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

            PassengerCar car6 = new PassengerCar(280, "siud2893", new Engine(300, 4.5, EngineType.Gasoline, "dfiug234"), new Transmission(TransmissionTypes.Manual, 6, "Skoda"), new Chassis(4, "dfgSDASD", 2000));
            
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