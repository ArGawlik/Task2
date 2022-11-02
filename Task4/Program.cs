namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bird bird = new();
            //bird.currentPosition = new Coordinate(0, 0, 0);
            //Console.WriteLine(bird.GetFlyTime(new Coordinate(0,0,100)));

            Airplane airplane = new Airplane(10000, 100);
            airplane.FlyTo(new Coordinate(9000, 0, 0));

            airplane.FlyTo(new Coordinate(0, 0, 0));

            Drone drone = new Drone();
            drone.currentPosition = new Coordinate(0, 0, 0);
            drone.FlyTo(new Coordinate(5, 0, 0));
        }
    }
}