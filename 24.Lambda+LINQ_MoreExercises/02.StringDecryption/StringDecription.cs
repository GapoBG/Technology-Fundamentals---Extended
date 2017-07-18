using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringDecryption
{
    class StringDecription
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            var givenArray = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            var result = givenArray.Where(x => x >= 65 && x <= 90).ToList().Skip(nums[0]).Take(nums[1]);
            Console.WriteLine(string.Join(string.Empty, result.Select(x => (char)x)));
        }
    }
}
