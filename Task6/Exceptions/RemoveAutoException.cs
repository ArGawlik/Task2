using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    internal class RemoveAutoException : Exception
    {
        public RemoveAutoException() : base() { }
        public RemoveAutoException(string message) : base(message) { }
    }
}
