using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Exceptions
{
    internal class UpdateAutoException : Exception
    {
        public UpdateAutoException() : base() { }
        public UpdateAutoException(string message) : base(message) { }
    }
}
