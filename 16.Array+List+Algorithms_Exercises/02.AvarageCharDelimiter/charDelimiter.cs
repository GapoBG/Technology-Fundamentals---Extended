using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AvarageCharDelimiter
{
    class charDelimiter
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(' ');
            string delimiter = "";
            int sumChar = 0;
            int count = 0;

            for (int i = 0; i < arrayStr.Length; i++)
            {
                char[] currentStr = arrayStr[i].ToCharArray();
                count += currentStr.Length;

                for (int j = 0; j < currentStr.Length; j++)
                {
                    sumChar += currentStr[j];
                }
            }

            char lowerDelimiter = (char)(sumChar / count);
            delimiter = lowerDelimiter.ToString().ToUpper();

            Console.WriteLine(string.Join($"{delimiter}", arrayStr));
        }
    }
}
