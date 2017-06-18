using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngred
    {
        static void Main(string[] args)
        {
            string inputIngred = Console.ReadLine();
            int counter = 0;
            while (inputIngred != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", inputIngred);
                inputIngred = Console.ReadLine();
                counter++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
