using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIN30Minutes
{
    class Back30min
    {
        static void Main(string[] args)
        {
            int HH = int.Parse(Console.ReadLine());
            int MM = int.Parse(Console.ReadLine());

            int newMM = MM + 30;
            int newHH = HH + 1;

            if (newMM <= 59)
            {
                Console.WriteLine("{0}:{1:d2}", HH, newMM);
            }

            else
            {
                if (newHH == 24)
                {
                    newHH = 0;
                }
                newMM = newMM - 60;
                Console.WriteLine("{0}:{1:d2}", newHH, newMM);
            }
        }
    }
}
