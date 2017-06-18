using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DifferentNum
{
    class DifferrentNum
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (Math.Abs(secondNum - firstNum) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int one = firstNum; one <= secondNum; one++)
                {
                    for (int two = one + 1; two <= secondNum; two++)
                    {
                        for (int three = two + 1; three <= secondNum; three++)
                        {
                            for (int four = three + 1; four <= secondNum; four++)
                            {
                                for (int five = four + 1; five <= secondNum; five++)
                                {
                                    if (one < two || two < three || three < four || four < five)
                                    {
                                        Console.WriteLine($"{one} {two} {three} {four} {five}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
