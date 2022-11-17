using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Commands
{
    internal class CountPrice : ICommand
    {
        List<Car> cars = Store.GetStore().cars;
        string type;

        public CountPrice(string type)
        {
            this.type = type;
        }
        public void Execute()
        {
            if (type != null)
            {
                if (cars.Where(x => x.brand == type).Count()==0)
                {
                    Console.WriteLine($"{type} is not available");
                }
                else
                {
                    Console.WriteLine($"Average {type} price is: " + cars.Where(x => x.brand == type).Select(x => x.unitPrice * x.quantity).Sum() / cars.Where(x => x.brand == type).Count());
                }
            }
            else
            {
                if (cars.Count == 0)
                {
                    Console.WriteLine("No cars available");
                } 
                else
                {
                    Console.WriteLine("Average car price is: " + cars.Select(x=>x.unitPrice * x.quantity).Sum()/cars.Count);
                }
            } 
        }
    }
}
