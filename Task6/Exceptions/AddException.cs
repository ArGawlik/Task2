using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    public class AddException : Exception
    {
        public AddException(string message) : base(message) { }
    }
}
