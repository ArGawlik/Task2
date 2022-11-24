using System.Text.RegularExpressions;
using Task7.Commands;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * In the program we have a car store, which is implemented as sigleton
             * It allows to add and store cars
             * CountTypes and CountPrice implement ICommand with Execute() method which prints defined information
             * Commands are stored in list and executed after receiving input 0 as a command
             */

            Store store = Store.GetStore();
            string key = "";
            Invoker invoker = new Invoker();

            // you can add your own cars...
            while (key != "D2")
            {
                Console.WriteLine("Select option:\n1 - add car\n2 - go to commands");
                key = Console.ReadKey().Key.ToString();
                if (key != "D1" && key !="D2")
                {
                    Console.WriteLine("Invalid key");
                }
                else if (key == "D1")
                {
                    store.AddCar();
                }
            }

            // ...or just uncomment and use below code to avoid writing cars to console

            //Car car1 = new Car("Audi", "A6", 5, 120000);
            //Car car2 = new Car("Audi", "A4", 2, 60000);
            //Car car3 = new Car("Skoda", "Superb", 12, 80000);
            //Car car4 = new Car("Skoda", "Octavia", 3, 60000);
            //Car car5 = new Car("Mazda", "CX5", 4, 100000);
            //store.cars = new List<Car>() { car1, car2, car3, car4, car5 };


            Console.WriteLine("Write commands, or 0 to execute commands and exit program");
            Console.WriteLine("Available commands:\ncount all - count all cars" +
                "\ncount types - count available car brands" +
                "\ncount *type* - count cars of given type (ex. count Audi)" +
                "\navergae price - average price of car" +
                "\naverage price *type* - average price of car brand");
            string command = " ";
            while(command != "0" || command.Length == 0)
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case var x when new Regex(@"count \w*").IsMatch(x):
                        invoker.CountCars(command.Split(" ").Last());
                        break;                    
                    case var x when new Regex(@"average price \w*").IsMatch(x):
                        invoker.CountPriceOfType(command.Split(" ").Last());
                        break;
                    case "average price":
                        invoker.CountAveragePrice();
                        break;
                    case "0":
                        invoker.ExecuteCommands();
                        break;
                    default:
                        Console.WriteLine("invalid command");
                        break;
                }
            }
        }
    }
}