using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ResturantDiscount
{
    class ResturantDiscount
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double price = 0;
            double discount = 0;
            double priceHall = 0;
            string nameHall = "";

            if (people > 0 && people <= 50)
            {
                priceHall = 2500;
                nameHall = "Small Hall";

            }

            else if (people > 50 && people <= 100)
            {
                priceHall = 5000;
                nameHall = "Terrace";
            }

            else if (people > 100 && people <= 120)
            {
                priceHall = 7500;
                nameHall = "Great Hall";
            }


            if (package == "normal")
            {
                price = 500;
                discount = 0.05;
            }
            else if (package == "gold")
            {
                price = 750;
                discount = 0.1;
            }
            else if (package == "platinum")
            {
                price = 1000;
                discount = 0.15;
            }

            double totalPrice = priceHall + price;
            double priceDiscount = totalPrice - (totalPrice * discount);
            double pricePerson = priceDiscount / people;

            if (people > 0 && people < 120)
            {
                Console.WriteLine("We can offer you the {0}", nameHall);
                Console.WriteLine("The price per person is {0:f2}$", pricePerson);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
