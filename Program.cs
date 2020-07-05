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
            int [,] randomGeneratedDTED = DTEDGenerator.GeneratePattern();
            DTEDGenerator.GenerateImage(randomGeneratedDTED, 10, 100);

            Console.ReadKey();
        }


       
    }
}
