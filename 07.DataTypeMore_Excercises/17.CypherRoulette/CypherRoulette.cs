using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string output = "";
            string previousWord = "";
            bool toEnd = true;

            for (int i = 1; i <= num; i++)
            {
                string curentWord = Console.ReadLine();
                if (curentWord == "spin")
                {
                    toEnd = !toEnd;
                    i--;
                }
                switch (toEnd)
                {
                    case (true):
                        output += curentWord;
                        break;
                    case (false):
                        output = curentWord + output;
                        break;
                }
                if (curentWord == previousWord)
                {
                    output = "";
                    if (curentWord == "spin")
                    {
                        toEnd = !toEnd;
                    }
                    previousWord = curentWord;
                }
                previousWord = curentWord;
            }
            output = output.Replace("spin", "");
            Console.WriteLine(output);

        }
    }
}
