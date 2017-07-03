using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            List<double> capacity = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            List<double> expenceProHour = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            int testHours = int.Parse(Console.ReadLine());

            double endBalance = 0;
            double endPercent = 0;
            double deadHours = 0;
            string result = "";
            int count = 1;

            for (int i = 0; i < capacity.Count; i++)
            {
                endBalance = Math.Round(capacity[i] - expenceProHour[i] * testHours, 2);
                endPercent = Math.Round(endBalance / capacity[i] * 100, 2);
                deadHours = Math.Ceiling(capacity[i] / expenceProHour[i]);

                if (endBalance > 0)
                {
                    result = $"Battery {count}: {endBalance:0.00} mAh ({endPercent:0.00})%";
                }
                else
                {
                    result = $"Battery {count}: dead (lasted {deadHours} hours)";
                }
                Console.WriteLine(result);
                count++;
            }
        }
    }
}
