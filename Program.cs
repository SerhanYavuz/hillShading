using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace hs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            //Generating DTED data
            int [,] randomGeneratedDTED = DTEDGenerator.Generate();
            

            //Visualizing
            Bitmap bitmap;
            unsafe
            {
                fixed(int* intPtr = &randomGeneratedDTED[0, 0])
                {
                    
                    bitmap = new Bitmap(401, 401, 401 * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, new IntPtr(intPtr));
                    bitmap.Save("test", ImageFormat.Jpeg);
                }
            }

            Console.ReadKey();
        }
    }
}
