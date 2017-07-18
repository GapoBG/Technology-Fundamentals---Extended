using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWord
{
    class Randomize
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Random rand = new Random();
            for (int i = 0; i < word.Length; i++)
            {
                int firstWord = rand.Next(0, word.Length);
                int secondWord = rand.Next(0, word.Length);

                string changer = word[firstWord];
                word[firstWord] = word[secondWord];
                word[secondWord] = changer;
            }
            Console.WriteLine(string.Join("\n", word));
        }
    }
}
