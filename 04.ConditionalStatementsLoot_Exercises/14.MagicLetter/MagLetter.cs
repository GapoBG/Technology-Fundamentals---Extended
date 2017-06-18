using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagLetter
    {
        static void Main(string[] args)
        {
            string inputA = Console.ReadLine().ToLower();
            char start = inputA[0];
            var inputB = Console.ReadLine().ToLower();
            char end = inputB[0];
            var inputC = Console.ReadLine().ToLower();
            char ignoreLetter = inputC[0];

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i == ignoreLetter || j == ignoreLetter || k == ignoreLetter)
                            continue;
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
