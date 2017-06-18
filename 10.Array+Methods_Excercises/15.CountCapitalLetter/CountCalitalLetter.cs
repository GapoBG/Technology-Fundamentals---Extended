using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountCapitalLetter
{
    class CountCalitalLetter
    {
        static void Main(string[] args)
        {
            string[] wordArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = 0;

            for (int i = 0; i < wordArray.Length; i++)
            {
                var currentLetter = wordArray[i];
                if (currentLetter.Length == 1)
                {
                    char letter = currentLetter[0];
                    if (letter >= 'A' || letter <= 'Z')
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
