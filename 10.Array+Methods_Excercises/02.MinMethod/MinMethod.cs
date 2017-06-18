using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            foundMin();
        }

        private static void foundMin()
        {
            int counter = 3;
            int minNum = int.MaxValue;
            for (int i = 1; i <= counter; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
