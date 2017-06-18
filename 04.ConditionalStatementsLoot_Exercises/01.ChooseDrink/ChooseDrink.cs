using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseDrink
{
    class ChooseDrink
    {
        static void Main(string[] args)
        {
            string nameProfession = Console.ReadLine();

            if (nameProfession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (nameProfession == "Businessman")
            {
                Console.WriteLine("Coffee");
            }
            else if (nameProfession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
