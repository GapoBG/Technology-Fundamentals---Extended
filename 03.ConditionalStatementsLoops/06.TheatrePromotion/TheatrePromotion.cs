using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main(string[] args)
        {
            string week = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                if (week == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                if (week == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                if (week == "Holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (week == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                if (week == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                if (week == "Holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (week == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                if (week == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                if (week == "Holiday")
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            }
        }
    }
