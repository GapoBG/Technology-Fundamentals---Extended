using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class drawSquare
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            prinHeader(num);
            printMiddle(num);
            prinHeader(num);
        }

        private static void printMiddle(int num)
        {           
            for (int i = 0; i < num-2; i++)
            {
                Console.Write("-");
                for (int j = 0; j <= num-2; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void prinHeader(int num)
        {
            Console.WriteLine(new string('-', num*2));
        }
    }
}
