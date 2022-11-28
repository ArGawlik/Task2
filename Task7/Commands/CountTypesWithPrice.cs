using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Commands
{
    public class CountTypesWithPrice : ICommand
    {
        List<Car> cars = Store.GetStore().cars;
        string type;
        string logic;
        int price;
        public CountTypesWithPrice(int price, string type, string logic) 
        { 
            this.price = price;
            this.type = type;
            this.logic = logic;
        }
        public void Execute()
        {
            int result = 0;
            if (logic == "above")
            {
                result = cars.Where(x => x.unitPrice > price && x.brand == type).Select(x => x.quantity).Sum();
            }
            else
            {
                result = cars.Where(x => x.unitPrice < price && x.brand == type).Select(x => x.quantity).Sum();
            }
            if (result == 0)
            {
                Console.WriteLine($"No cars of {type} with price {logic} {price}");
            }
            else
            {
                Console.WriteLine($"There are {result} {type} cars with price {logic} {price}");
            }
        }
    }
}
