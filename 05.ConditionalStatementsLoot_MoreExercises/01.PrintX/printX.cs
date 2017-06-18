using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintX
{
    class printX
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var space = 0;
            var middleSpace = input - 2;
            var spaceDown = (input - 3) / 2;
            var middleSpaceDown = 1;

            
            if (input %2 != 0)
            {
                for (int i = 1; i <= (input-1)/2; i++)
                {
                    Console.WriteLine(new string(' ',space) + "x" + new string(' ',middleSpace) + "x");
                    space++;
                    middleSpace -= 2;
                }
                Console.WriteLine(new string(' ', (input-1)/2) + "x");
                for (int i = 1; i <= (input - 1) / 2; i++)
                {
                    Console.WriteLine(new string(' ', spaceDown) + "x" + new string(' ', middleSpaceDown) + "x");
                    spaceDown--;
                    middleSpaceDown += 2;
                }
            }

        }
    }
}
