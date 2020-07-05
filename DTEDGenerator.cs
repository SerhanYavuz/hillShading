using System;
using System.Collections.Generic;
using System.Text;

namespace hs
{
    public static class DTEDGenerator
    {
        public static int[,] Generate()
        {
            Console.WriteLine("Generating DTED");
            int[,] data = new int[401,401];
            Random random = new Random();
            for (int i = 0; i< 401 ; i++)
            {
                for (int j = 0; j< 401; j++)
                {
                    data[i, j] = random.Next(999);
                }

            }
            Console.WriteLine("Generated");
            return data;
        }




    }
}
