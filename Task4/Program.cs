namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new();
            bird.FlyTo(new Coordinate(0, 0, 100));
            bird.FlyTo(new Coordinate(100, 0, 5));

            Airplane airplane = new Airplane(100, 10000);
            airplane.FlyTo(new Coordinate(9000, 0, 0));
            airplane.FlyTo(new Coordinate(0, 0, 0));
            airplane.Refuel();
            airplane.FlyTo(new Coordinate(0, 0, 0));

            Drone drone = new Drone();
            drone.FlyTo(new Coordinate(5, 0, 0));
            drone.FlyTo(new Coordinate(5, 2, 1000));
        }
    }
}