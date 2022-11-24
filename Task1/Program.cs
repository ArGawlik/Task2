namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                string ignoredSpaces = arg.Replace(" ", "");
                Console.WriteLine(arg + "\nmax unequal consecutive characters count: " + CountCharacters(ignoredSpaces));
            }
        }

        static int CountCharacters(string line)
        {
            if (line.Length == 0)
            {
                return 0;
            }
            int counter = 1;
            int max = 1;
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i - 1] != line[i])
                {
                    counter++;
                }
                else
                {
                    if (counter > max)
                    {
                        max = counter;
                    }
                    counter = 1;
                }
            }
            return max >= counter ? max : counter;
        }
    }
}