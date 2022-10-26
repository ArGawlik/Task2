using System.Text;

namespace Task2
{
    internal class Program
    {
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
                converted.Insert(0, ByteConversion(number % format));
                number /= format;
            }
            return converted.ToString();
        }

        static string ByteConversion(int number)
        {
            if(number <= 9)
            {
                return number.ToString();
            }
            else
            {
                switch (number)
                {
                    case 10: return "A";
                        case 11: return "B";
                        case 12: return "C";
                        case 13: return "D";
                        case 14: return "E";
                        case 15: return "F";
                        case 16: return "G";
                        case 17: return "H";
                        case 18: return "I";
                        case 19: return "J";
                    default:
                        return "";
                }
            }
        }
    }
}