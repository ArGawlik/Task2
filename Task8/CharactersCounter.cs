using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task8
{
    public class CharactersCounter
    {
        public int CountUnequalCharacters(string line)
        {
            line = line.Replace(" ", "");
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

        public int CountIdenticalLetters(string line)
        {
            line = line.Replace(" ", "");
            if (!Regex.IsMatch(line, ".*[A-Za-z].*"))   // check if line contains letters
            {
                return 0;
            }
            int counter = 1;
            int max = 1;
            for (int i = 1; i < line.Length; i++)
            {
                if (IsAlpha(line[i]) && line[i - 1] == line[i])
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

    public int CountIdenticalDigits(string line)
        {
            line = line.Replace(" ", "");
            if (!Regex.IsMatch(line, ".*\\d.*"))    // check if line contains digits
            {
                return 0;
            }
            int counter = 1;
            int max = 1;
            for (int i = 1; i < line.Length; i++)
            {
                if (IsDigit(line[i]) && line[i - 1] == line[i])
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

        private bool IsAlpha(char c)
        {
            return Regex.IsMatch(c.ToString(), "[A-Za-z]");
        }

        private bool IsDigit(char c)
        {
            return Regex.IsMatch(c.ToString(), "[\\d]");
        }
    }
}
