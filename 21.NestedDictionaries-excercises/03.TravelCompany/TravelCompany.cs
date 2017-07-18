using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {

            var myDict = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "ready")
            {
                string[] inArr = input.Split(':');

                string city = inArr[0];
                if (!myDict.ContainsKey(city))
                {
                    myDict.Add(city, new Dictionary<string, int>());
                }

                string[] cityData = inArr[1].Split(',');
                for (int i = 0; i < cityData.Length; i++)
                {
                    string[] vehicleData = cityData[i].Split('-');

                    string vehicle = vehicleData[0];
                    int capacity = int.Parse(vehicleData[1]);

                    if (!myDict[city].ContainsKey(vehicle))
                    {
                        myDict[city].Add(vehicle, capacity);
                    }
                    else
                    {
                        myDict[city][vehicle] = capacity;
                    }

                }

                input = Console.ReadLine();
            }

            string output = Console.ReadLine();
            while (output != "travel time!")
            {
                string[] outArr = output.Split(' ');
                string outCity = outArr[0];
                int people = int.Parse(outArr[1]);

                int sum = myDict[outCity].Values.Sum();

                if (sum - people >= 0)
                {
                    Console.WriteLine($"{outCity} -> all {people} accommodated");
                }
                else
                {
                    Console.WriteLine($"{outCity} -> all except {people - sum} accommodated");
                }

                output = Console.ReadLine();
            }
        }
    }
}
