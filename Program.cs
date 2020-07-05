using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Net.NetworkInformation;

namespace hs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            //Generating DTED data
            int [,] randomGeneratedDTED = DTEDGenerator.Generate();
            Bitmap bmp = new Bitmap(401, 401);
            //calculate slope at each pixel except border pixels (will implement later)
            for (int x = 1; x< 400; x++)
            {
                for (int y = 1; y<400; y++)
                {
                    int top = randomGeneratedDTED[x, y - 1];
                    int left = randomGeneratedDTED[x - 1, y];
                    int right = randomGeneratedDTED[x + 1, y];
                    int bottom = randomGeneratedDTED[x, y + 1];

                    double slx = (right - left) / 3;
                    double sly = (bottom - top) / 3;
                    double sl0 = Math.Sqrt(slx * slx + sly * sly); // egim

          

                }
            }



            Console.WriteLine("done!");

            Console.ReadKey();
        }


       
    }
}
