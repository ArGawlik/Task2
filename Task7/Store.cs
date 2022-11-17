using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task7
{
    public class Store
    {
        private static Store singleton = null;
        List<ICommand> commands= new List<ICommand>();
        public List<Car> cars = new List<Car>();
        private Store() { }
        public static Store GetStore()
        {
            if (singleton == null)
            {
                singleton= new Store();
            }
            return singleton;
        }

        public void AddCar()
        {
            System.Console.WriteLine("Write car brand");
            string brand = System.Console.ReadLine();
            System.Console.WriteLine("Write car model");
            string model = System.Console.ReadLine();
            System.Console.WriteLine("Write car quantity");
            int quantity = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Write car unit price");
            int unitPrice = int.Parse(System.Console.ReadLine());

            cars.Add(new Car(brand, model, quantity, unitPrice));
        }
    }
}
