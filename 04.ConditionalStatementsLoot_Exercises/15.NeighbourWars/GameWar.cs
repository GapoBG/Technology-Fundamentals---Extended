using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class GameWar
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthG = 100;
            int healthP = 100;
            int roundCount = 0;

            while (healthG > 0 && healthP > 0)
            {
                roundCount++;

                if (roundCount % 2 != 0)
                {
                    healthG -= damagePesho;
                    if (healthG <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and rediced Gosho to {healthG} health.");
                }
                if (roundCount % 2 == 0)
                {
                    healthP -= damageGosho;
                    if (healthP <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and rediced Pesho to {healthP} health.");
                }
                if (roundCount % 3 == 0)
                {
                    healthG += 10;
                    healthP += 10;
                }
            }
            if (healthP <= 0)
            {
                Console.WriteLine($"Gosho won in {roundCount}th round.");
            }
            if (healthG <= 0)
            {
                Console.WriteLine($"Pesho won in {roundCount}th round.");
            }

        }
    }
}
