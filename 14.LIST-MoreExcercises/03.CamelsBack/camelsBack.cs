using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CamelsBack
{
    class camelsBack
    {
        static void Main(string[] args)
        {
 //           Console.Write("Enter Odd List Nunmber: ");
            List<int> numberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

 /*           while (numberList.Count % 2 == 0)
            {
                Console.WriteLine("Wrong!!!");
                Console.Write("Enter Odd List Nunmber: ");
                numberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            }

            Console.Write("Enter Camel's Back Number: ");
*/
            int numN = int.Parse(Console.ReadLine());

            while (numN <= 0 || numN > 1000 || numN > numberList.Count )
            {
//                Console.Write("Enter Camel's Back Number: ");
                numN = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            if (numberList.Count == numN)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", numberList));
            }
            else
            {
                while (numberList.Count != numN)
                {
                    numberList.RemoveAt(0);
                    numberList.RemoveAt(numberList.Count - 1);

                    counter++;
                }
                Console.WriteLine($"{counter} rounds \nremaining: {string.Join(" ", numberList)}");
            }
            
        }
    }
}
