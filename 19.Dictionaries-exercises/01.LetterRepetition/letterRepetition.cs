using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class letterRepetition
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            Dictionary<char, int> exportedChars = new Dictionary<char, int>();

            foreach (var item in letter)
            {
                if (!exportedChars.ContainsKey(item))
                {
                    exportedChars[item] = 0;
                }
                exportedChars[item]++;
            }

            foreach (var item in exportedChars)
            {
                char fromChar = item.Key;
                int value = item.Value;
                Console.WriteLine($"{fromChar} -> {value}");
            }
        }
    }
}
