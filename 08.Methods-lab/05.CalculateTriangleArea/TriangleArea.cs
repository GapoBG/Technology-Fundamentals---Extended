using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideHa = double.Parse(Console.ReadLine());
            Console.WriteLine(calculate(sideA,sideHa));
        }

        private static double calculate(double width, double height)
        {
            var result = (width * height) / 2;
            return result;
        }
    }
}
