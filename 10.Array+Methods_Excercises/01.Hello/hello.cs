using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello
{
    class hello
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            printName(name);
        }

        private static void printName(string names)
        {
            Console.WriteLine("Hello, {0}!", names);
        }
    }
}
