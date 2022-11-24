using Task8;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CharactersCounter counter = new CharactersCounter();
            foreach (string arg in args)
            {
                Console.WriteLine(arg + "\nmax unequal consecutive characters count: " + counter.CountUnequalCharacters(arg));
            }
        }
    }
}