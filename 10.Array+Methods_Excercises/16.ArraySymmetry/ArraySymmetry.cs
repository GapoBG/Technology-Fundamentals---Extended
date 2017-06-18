using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main(string[] args)
        {
            string[] wordLetter = Console.ReadLine()
                .Split(' ')
                .ToArray();
            bool result = true;

            for (int i = 0; i < wordLetter.Length/2; i++)
            {
                string fistWord = wordLetter[i];
                string secondWord = wordLetter[wordLetter.Length - 1 - i];

                if (fistWord != secondWord)
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
