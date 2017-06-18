using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int digits = i;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }

                bool isSpecNum = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{i} -> {isSpecNum}");
            }

        }
    }
}
