using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetCalulate(number, power));
        }

        private static double GetCalulate(double number, int power)
        {
            var result = Math.Pow(number, power);
            return result;
        }
    }
}
