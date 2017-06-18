using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceStars
{
    class DistanceStars
    {
        static void Main(string[] args)
        {
            var lightYear = 9450000000000m;

            decimal distanceNarestStar = 4.22m * lightYear;
            Console.WriteLine("{0:f2}", distanceNarestStar.ToString("e2"));

            decimal distanceOurGalaxy = 26000m * lightYear;
            Console.WriteLine("{0:f2}", distanceOurGalaxy.ToString("e2"));

            decimal distanceMilkyWayy = 100000m * lightYear;
            Console.WriteLine("{0:f2}", distanceMilkyWayy.ToString("e2"));

            decimal distanceEarthToObservableUnivers = 46500000000m * lightYear;
            Console.WriteLine("{0:f2}", distanceEarthToObservableUnivers.ToString("e2"));
        }
    }
}
