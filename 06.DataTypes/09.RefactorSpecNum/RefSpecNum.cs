using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecNum
{
    class RefSpecNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int tempNum = i;
                int sum = 0;
                while (tempNum > 0)
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                }

                bool special = false;
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {special}");
                sum = 0;
            }
        }
    }
}
