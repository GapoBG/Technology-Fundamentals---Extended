using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int numPhoto = int.Parse(Console.ReadLine());
            int DD = int.Parse(Console.ReadLine());
            int MM = int.Parse(Console.ReadLine());
            int YYYY = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double resultSize = 0;
            string sizeType = "";
            string orientationPhoto = "";

            if (size > 0 && size < 1000)
            {
                resultSize = size;
                sizeType = "B";
            }
            else if (size >= 1000 && size < 999999)
            {
                resultSize = size / 1000;
                sizeType = "KB";
            }
            else if (size >= 1000000)
            {
                resultSize = size / 1000000;
                sizeType = "MB";
            }

            if (width > height)
            {
                orientationPhoto = "landscape";
            }
            else if (width < height)
            {
                orientationPhoto = "portrait";
            }
            else if (width == height)
            {
                orientationPhoto = "square";
            }

            DateTime date = new DateTime(YYYY, MM, DD, hour, minute, 0);

            Console.WriteLine("Name: DSC_{0:d4}.jpg",numPhoto);
            Console.WriteLine("Date Taken: {0}",date.ToString("dd/MM/yyy HH:mm"));
            Console.WriteLine("Size: {0}{1}",resultSize,sizeType);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width,height,orientationPhoto);

        }
    }
}
