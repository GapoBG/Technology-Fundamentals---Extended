using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3EqualString
{
    class Last3EqualStr
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = 1;
            string letter = "";

            for (int i = array.Length-1; i > 0; i--)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        letter = array[i];
                        break;
                    }
                }

                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0} ",letter);
            }
            Console.WriteLine();
        }
    }
}
