using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Bird : IFlyable
    {
        /*
         * The bird can fly with random speed between 0 and 20.
         * It can fly on maximum heigth 10km.
         */
        Coordinate currentPosition = new Coordinate(0, 0, 0);
        int speed = new Random().Next(0, 20);
        public void FlyTo(Coordinate point)
        {
            // The bird can fly only on maximum ceiling 10km (Z axis)

            if (point.z > 10)
            {
                Console.WriteLine("The bird cannot fly so high :(");
            }
            else
            {
            double timeHours = Math.Round(GetFlyTime(point), 2);
            double timeMinutes = Math.Round(GetFlyTime(point) * 60, 2);

            Console.WriteLine($"The bird flew to new position in {timeHours}h ({timeMinutes}min)");
            currentPosition = point;
            }
        }

        public double GetFlyTime(Coordinate point)
        {
            return currentPosition.getDistance(point)/speed;
        }
    }
}
