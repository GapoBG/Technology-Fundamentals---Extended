using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPionts
{
    class DistancePiont
    {
        static void Main(string[] args)
        {
            var point1 = pointReader();
            var point2 = pointReader();

            var result = Distance(point1, point2);
            Console.WriteLine("{0:f3}", result);
            
        }

        public static double Distance(Point point1, Point point2)
        {
            double squareX = Math.Pow(point1.X - point2.X, 2);
            double squareY = Math.Pow(point1.Y - point2.Y, 2);

            var result = Math.Sqrt(squareX + squareY);
            return result;
        }

        static Point pointReader()
        {
            int[] pointParts = Console.ReadLine()               
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
