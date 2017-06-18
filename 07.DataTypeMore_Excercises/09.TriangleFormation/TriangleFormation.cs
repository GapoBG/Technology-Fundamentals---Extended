using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TriangleFormation
{
    class TriangleFormation
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            string isValidTriangle = sideA + sideB > sideC &&
                sideA + sideC > sideB &&
                sideB + sideC > sideA ? "Triangle is valid." : "Invalid Triangle.";
            string isRightTriangle = isValidTriangle == "Triangle is valid." && sideA * sideA + sideB * sideB == sideC * sideC ?
                "Triangle has a right angle between sides a and b" :
                isValidTriangle == "Triangle is valid." && sideA * sideA + sideC * sideC == sideB * sideB ?
                "Triangle has a right angle between sides a and c" :
                isValidTriangle == "Triangle is valid." && sideB * sideB + sideC * sideC == sideA * sideA ?
                "Triangle has a right angle between sides b and c" :
                isValidTriangle == "Triangle is valid." ? "Trianglr has no right angles" : "";

            Console.WriteLine($"{isValidTriangle}\n{isRightTriangle}");
        }
    }
}
