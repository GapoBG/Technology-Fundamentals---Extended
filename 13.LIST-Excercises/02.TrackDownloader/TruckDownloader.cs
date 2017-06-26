using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class TruckDownloader
    {
        static void Main(string[] args)
        {
            List<string> blackList = Console.ReadLine()
                .Split()
                .ToList();
            List<string> fileNameList = new List<string>();
            string fileName = Console.ReadLine();

            while (fileName != "end")
            {
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (!fileName.Contains(blackList[i]))
                    {
                        fileNameList.Add(fileName);
                    }

                    else
                    {
                        break;
                    }
                }
                fileName = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\r\n", fileNameList.Distinct().OrderBy(X => X)));
        }
    }
}
