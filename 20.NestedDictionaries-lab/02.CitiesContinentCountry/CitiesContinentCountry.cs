using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesContinentCountry
{
    class CitiesContinentCountry
    {
        static void Main(string[] args)
        {
            var continentalsData = new Dictionary<string, Dictionary<string, List<string>>>();
            int inputCnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCnt; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');
                string continetnt = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];

                if (!continentalsData.ContainsKey(continetnt))
                {
                    continentalsData[continetnt] = new Dictionary<string, List<string>>();
                }
                if (!continentalsData[continetnt].ContainsKey(country))
                {
                    continentalsData[continetnt][country] = new List<string>();
                }
                continentalsData[continetnt][country].Add(city);
            }

            foreach (var continetCountries in continentalsData)
            {
                var countinetName = continetCountries.Key;
                var countries = continetCountries.Value;

                Console.WriteLine($"{countinetName}:");
                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine("  {0} -> {1}",
                        countryName, 
                        string.Join(", ", cities));
                }
            }
        }       
    }
}
