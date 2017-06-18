using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightCount = int.Parse(Console.ReadLine());
            double discountStudio = 0.0;
            double discountDouble = 0.0;
            double discountSuite = 0.0;
            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;

            if (month == "may" || month == "october")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
                if (nightCount > 7)
                {
                    discountStudio = 0.05;
                    priceStudio = priceStudio - (priceStudio * discountStudio);
                }

            }

            if (month == "june" || month == "september")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;
                if (nightCount > 14)
                {
                    discountDouble = 0.1;
                    priceDouble = priceDouble - (priceDouble * discountDouble);
                }
            }

            if (month == "july" || month == "august" || month == "december")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;
                if (nightCount > 14)
                {
                    discountSuite = 0.15;
                    priceSuite = priceSuite - (priceSuite * discountSuite);
                }
            }


            double resultStudio = nightCount * priceStudio;
            double resulDouble = nightCount * priceDouble;
            double resultSuite = nightCount * priceSuite;

            if (month == "september" || month == "october")
            {
                if (nightCount > 7)
                {
                    nightCount = nightCount - 1;
                    resultStudio = nightCount * priceStudio;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", resultStudio);
            Console.WriteLine("Double: {0:f2} lv.", resulDouble);
            Console.WriteLine("Suite: {0:f2} lv.", resultSuite);

        }
    }
}
