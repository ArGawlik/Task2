using System.Text;

namespace Task2
{
    internal class Program
    {
        static string digits = "0123456789ABCDEFGHIJK";
        static void Main(string[] args)
        {
            int original = int.Parse(args[0]);
            int conversionFormat = int.Parse(args[1]);
            if (conversionFormat < 2 || conversionFormat > 20)
            {
                Console.WriteLine("Not supported number system");
            }
            else
            {
                Console.WriteLine($"Original number: {original}\nConverted in {args[1]} system: {ConvertNumber(original, conversionFormat)}");
            }
        }

        static string ConvertNumber(int number, int format)
        {
            StringBuilder converted = new();
            for(int i = 0; number > 0; i++)
            {
                converted.Insert(0, digits.ElementAt(number % format));
                number /= format;
            }
            return converted.ToString();
        }
    }
}