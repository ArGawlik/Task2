using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Commands;

namespace Task7
{
    public class Invoker
    {
        List<ICommand> commands = new List<ICommand>();

        public void CountCars(string type)
        {
            commands.Add(new CountTypes(type));
        }

        public void CountPriceOfType(string type)
        {
            commands.Add(new CountPrice(type));
        }

        public void CountAveragePrice()
        {
            commands.Add(new CountPrice(null));
        }

        public void CountTypesWithPrice(string command)
        {
            var commandWords = command.Split(' ');
            commands.Add(new CountTypesWithPrice(int.Parse(commandWords.Last()), commandWords[1], commandWords[3]));
        }

        public void ExecuteCommands()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
            commands.Clear();
        }
    }
}
