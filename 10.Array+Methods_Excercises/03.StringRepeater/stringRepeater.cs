using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class stringRepeater
    {
        static void Main(string[] args)
        {
            string writeString = Console.ReadLine();
            int numRepeater = int.Parse(Console.ReadLine());

            repeaterString(writeString, numRepeater);
            Console.WriteLine(writeString);
        }

        private static string repeaterString(string writeString, int numRepeater)
        {
            for (int i = 1; i < numRepeater; i++)
            {
                Console.Write(writeString);
            }
            return writeString;
        }
    }
}
