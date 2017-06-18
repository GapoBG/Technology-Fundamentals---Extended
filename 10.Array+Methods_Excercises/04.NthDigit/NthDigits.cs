using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class NthDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            foundNum(number, counter);
        }

        private static void foundNum(int number, int counter)
        {
            for (int i = 1; i < counter ; i++)
            {
                number = number / 10;               
            }
            number = number % 10;
            Console.WriteLine(number);
        }
    }
}
