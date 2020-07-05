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
                    double sl0 = Math.Sqrt(slx * slx + sly * sly); // slope

                    //calculate land direction (aspect)
                    double phi = 0 ;
                    double azimuth = 0;

                    if(sl0 != 0)
                    {
                        phi = Math.Acos(slx / sl0);
                    }

                    
                    if(slx > 0)
                    {
                        if(sly > 0 )
                        {
                            azimuth = phi + 1.5 * Math.PI;
                        }
                        else if (sly <0)
                        {
                            azimuth = 1.5 * Math.PI - phi;
                        }
                        else
                        {
                            phi = 1.5 * Math.PI;
                        }

                    }
                    else if (slx < 0)
                    {
                        if (sly > 0)
                        {
                            azimuth = phi + 0.5 * Math.PI;
                        }
                        else if (sly < 0)
                        {
                            azimuth = 0.5 * Math.PI - phi;
                        }
                        else
                        {
                            phi = 0.5 * Math.PI;
                        }
                    }
                    else
                    {
                        if (sly < 0)
                        {
                            azimuth = Math.PI;
                        }
                        else if(sly > 0)
                        { 
                             azimuth = 0;
                        } 
                    }

                    double sunAzimuth = 45;
                    double sunElev = 45;
                    var l = Math.Cos(azimuth - sunAzimuth) * Math.Cos(Math.PI * .5 - Math.Atan(sl0)) * Math.Cos(sunElev) + Math.Sin(Math.PI * .5 - Math.Atan(sl0)) * Math.Sin(sunElev);
                    if(l< 0)
                    {
                        l = 0;
                    }
                    l = Math.Sqrt(l * 0.8 + 0.2);

                    // convert to rgb data 
                    int red = Math.Min((int)(l * 256), 255);
                    int green = Math.Min((int)((l * 256 - red) * 256), 255);
                    int blue = Math.Min((int)(((l * 256 - red) * 256 - green) * 256), 255);

                    bmp.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }


            bmp.Save("visulalizedDTED.jpg", ImageFormat.Jpeg);
            Console.WriteLine("done!");

            Console.ReadKey();
        }


       
    }
}
