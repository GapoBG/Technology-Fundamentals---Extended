using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantiti = int.Parse(Console.ReadLine());

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 0.70):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.70):f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.00):f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.00):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.20):f2}.");
                    break;
            }
        }
    }
}
