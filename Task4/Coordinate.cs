using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Coordinate(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getDistance(Coordinate point)
        {
            return Math.Sqrt(Math.Pow(this.x - point.x, 2) + 
                Math.Pow(this.y - point.y, 2) +
                Math.Pow(this.z - point.z, 2));
        }
    }
}
