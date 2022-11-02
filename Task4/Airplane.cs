using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Airplane : IFlyable
    {
        Coordinate currentPosition = new Coordinate(0,0,0);
        int initialSpeed = 200;
        int maxSpeed = 600;
        double currentFuel;
        double fuelConsumption;

        public Airplane(double currentFuel, double fuelConsumption)
        {
            this.currentFuel = currentFuel;
            this.fuelConsumption = fuelConsumption;
        }

        public void FlyTo(Coordinate point)
        {
            double distance = currentPosition.getDistance(point);
            if (distance / 100 * fuelConsumption > currentFuel)
            {
                Console.WriteLine("Not enough fuel to fly there");
            }
            else
            {
            double timeHours = Math.Round(GetFlyTime(point), 2);
            double timeMinutes = Math.Round(GetFlyTime(point) * 60, 2);
            currentFuel -= distance / 100 * fuelConsumption;

            Console.WriteLine($"The airplane flew to new position in {timeHours}h ({timeMinutes}min)");
            currentPosition = point;
            }
        }
        public double GetFlyTime(Coordinate point)
        {
            // The plane increase speed by 10km/h every 10km up to maxSpeed

            double distance = currentPosition.getDistance(point);
            double time = 0d;
            int currentSpeed = initialSpeed;

            while (distance > 0)
            {
                if (distance >= 10)
                {
                    distance -= 10;
                    time += 10d/currentSpeed;
                    if (currentSpeed < maxSpeed)
                    {
                        currentSpeed += 10;
                    }
                }
                else
                {
                    time += (double) distance / currentSpeed;
                    distance = 0;
                }
            }
            return time;
        }
    }
}
