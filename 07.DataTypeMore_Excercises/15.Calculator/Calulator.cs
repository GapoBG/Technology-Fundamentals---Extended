using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Calulator
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            switch (operand)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine($"{a} {operand} {b} = {result}");
        }
    }
}
