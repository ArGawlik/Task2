using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Commands
{
    public class CountTypes : ICommand
    {
        string type;
        List<Car> cars = Store.GetStore().cars; 
        public CountTypes(string type)
        {
            this.type = type;
        }
        public void Execute()
        {
            if(type == "types")
            {
                Console.WriteLine("Cars types count: " + cars.Select(x=>x.brand).Distinct().Count());
            } 
            else if (type == "all")
            {
                Console.WriteLine("Avaliable cars count: " + cars.Select(x=>x.quantity).Sum());
            }
            else
            {
                Console.WriteLine($"{type} count: " + cars.Where(x => x.brand == type).Select(x => x.quantity).Sum());
            }
        }
    }
}
