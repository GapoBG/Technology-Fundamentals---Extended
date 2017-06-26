using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            List<int> listNumber = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int num = int.Parse(Console.ReadLine());
            bool isContains = false;

            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i] == num)
                {
                    isContains = true;
                }                
            }

            printElement(isContains);
        }

        private static void printElement(bool isContains)
        {
            if (isContains == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
