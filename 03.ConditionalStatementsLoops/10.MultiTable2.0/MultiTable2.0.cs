using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());

            if (startNum > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num, startNum, num * startNum);
            }
            else
            {
                for (int i = startNum; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);

                }
            }


        }
    }
}
