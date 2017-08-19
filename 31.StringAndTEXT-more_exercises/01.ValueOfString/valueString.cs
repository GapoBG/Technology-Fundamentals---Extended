using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ValueOfString
{
    class valueString
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string letterCase = Console.ReadLine();
            int sumResult = 0;

            foreach (var item in inputText)
            {
                if (letterCase == "UPPERCASE")
                {
                    if (item > 64 && item < 92)
                    {
                        sumResult += item;
                    }
                }
                else if (letterCase == "LOWERCASE")
                {
                    if (item > 96 && item < 123)
                    {
                        sumResult += item;
                    }
                }
            }
            Console.WriteLine("The total sum is: {0}", sumResult);
        }
    }
}
