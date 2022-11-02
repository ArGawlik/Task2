using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IFlyable
    {
        public void FlyTo(Coordinate point);
        public double GetFlyTime(Coordinate point);
    }
}
