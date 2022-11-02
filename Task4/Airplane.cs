using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Airplane : IFlyable
    {
        /*
         * The airplane has max fuel tank capacity 10000. The fuel consumption per 100km and actual amount of fuel is defined in constructor.
         * The plane can make several flights on single tank, but it needs to be refueled if the remaining fuel would be not enough for flight to destination.
         */
        Coordinate currentPosition = new Coordinate(0,0,0);
        int initialSpeed = 200;
        int maxSpeed = 600;
        double fuelTankCapacity = 10000;
        double currentFuel;
        double fuelConsumption;
        double maxDistance;

        public Airplane(double fuelConsumption, double currentFuel = 10000)
        {
            this.currentFuel = currentFuel > fuelTankCapacity ? fuelTankCapacity : currentFuel;
            this.fuelConsumption = fuelConsumption;
            maxDistance = fuelTankCapacity / fuelConsumption * 100;
        }

        public void FlyTo(Coordinate point)
        {
            double distance = currentPosition.getDistance(point);
            if (distance > maxDistance)
            {
                Console.WriteLine("The airplane is not able to fly that far");
            }
            else if (distance / 100 * fuelConsumption > currentFuel)
            {
                Console.WriteLine("Not enough fuel to fly there. You need to refuel the airplane.");
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

        public void Refuel()
        {
            currentFuel = fuelTankCapacity;
        }
    }
}
