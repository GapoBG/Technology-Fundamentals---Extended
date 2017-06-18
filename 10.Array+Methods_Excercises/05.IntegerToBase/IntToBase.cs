using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IntegerToBase
{
    class IntToBase
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            BaseFromIneger(num, toBase);
          }

        private static void BaseFromIneger(int num, int toBase)
        {
            string result = "";
            while (num > 0)
            {
                int remainder = num % toBase;
                result = remainder + result;
                num /= toBase;

            }
            Console.WriteLine(result); ;

        }
    }
}
