using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] phoneName = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string name = Console.ReadLine();           
            while (name != "done")
            {
                printElement(phoneNumber, phoneName, name);
                name = Console.ReadLine();
            }

        }

        private static void printElement(string[] phoneNumber, string[] phoneName, string name)
        {
            for (int i = 0; i < phoneName.Length; i++)
            {
                if (name == phoneName[i])
                {
                    Console.WriteLine("{0} -> {1}", phoneName[i], phoneNumber[i]);
                }
            }
        }
    }
}
