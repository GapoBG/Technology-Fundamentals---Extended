using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoo = 150;
            int salami = 600;
            int pepper = 50;
            int result = 0;
            for (int i = 1; i <= number; i++)
            {
                string products = Console.ReadLine().ToLower();

                if (products == "cheese")
                {
                    result = result + cheese;
                }
                if (products == "tomato sauce")
                {
                    result = result + tomatoo;
                }
                if (products == "salami")
                {
                    result = result + salami;
                }
                if (products == "pepper")
                {
                    result = result + pepper;
                }
            }

            Console.WriteLine($"Total calories: {result}");
        }
    }
}
