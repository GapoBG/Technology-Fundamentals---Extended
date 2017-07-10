using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupContinents_Cpuntries_Cities
{
    class GroupContinentsCountriesCities
    {
        static void Main(string[] args)
        {
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new SortedSet<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in countries)
                {
                    var couuntryName = countryCities.Key;
                    var cities = countryCities.Value;

                    Console.WriteLine("  {0} -> {1}",
                        couuntryName, string.Join(", ", cities));
                }
            }
        }
    }
}
