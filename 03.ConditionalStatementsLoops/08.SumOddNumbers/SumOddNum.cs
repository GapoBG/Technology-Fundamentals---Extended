using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOddNumbers
{
    class SumOddNum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            

            for (int i = 1; i <= num*2 -1; i+=2)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
