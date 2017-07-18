using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string color = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }
                

                foreach (var cloth in clothes)
                {
                    Dictionary<string, int> clothDb = data[color];

                    if (!clothDb.ContainsKey(cloth))
                    {
                        clothDb.Add(cloth, 0);
                    }
                    clothDb[cloth]++;
                }
            }
            string[] searchToken = Console.ReadLine().Split(' ');
            string searchColor = searchToken[0];
            string seatchCloth = searchToken[1];

            foreach (var colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string,int> clothesData = colorData.Value;

                Console.WriteLine("{0} clothes:",color );
                foreach (var clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;

                    Console.Write("* {0} - {1}", cloth, quantity);

                    if (color == searchColor && cloth == seatchCloth)
                    {
                        Console.Write(" (found!)");
                    }
                        Console.WriteLine();
                }
            } 
        }
    }
}
