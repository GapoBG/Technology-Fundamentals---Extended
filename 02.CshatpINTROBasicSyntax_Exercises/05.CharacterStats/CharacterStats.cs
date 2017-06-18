using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMAX = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMAX = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |" + new string('|', health) + new string('.', healthMAX - health) + "|");
            Console.WriteLine("Energy: |" + new string('|', energy) + new string('.', energyMAX - energy) + "|");
        }
    }
}
