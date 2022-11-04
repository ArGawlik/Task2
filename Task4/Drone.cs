using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Drone : IFlyable
    {
        /*  
         * The drone can fly with constant speed defined in constructor (default 20km/h). Maximum distance it can fly on single charge is 1000km.
         * Lets assume that the battery is automatically recharged immediately after drone reach the destination. 
         * Then it can immediately fly to another point.
         */
        Coordinate currentPosition = new Coordinate(0, 0, 0);
        int speed = 20;
        readonly int maxDistance = 1000;

        public Drone(Coordinate currentPosition, int speed = 20)
        {
            this.currentPosition = currentPosition;
            this.speed = speed;
        }

        public void FlyTo(Coordinate point)
        {
            if (currentPosition.getDistance(point) > maxDistance)
            {
                Console.WriteLine("Destination is too far for the drone");
            }
            else
            {
                double timeHours = Math.Round(GetFlyTime(point), 2);
                double timeMinutes = Math.Round(GetFlyTime(point) * 60, 2);

                Console.WriteLine($"The drone flew to new position in {timeHours}h ({timeMinutes}min)");
                currentPosition = point;
            }
        }

        public double GetFlyTime(Coordinate point)
        {
            // the drone hovers for 1 minute every 10 minutes of fligth

            double time = currentPosition.getDistance(point) / speed;
            double timeBreaks = Math.Floor(time * 60 / 10) / 60;

            return time + timeBreaks;
        }
    }
}
