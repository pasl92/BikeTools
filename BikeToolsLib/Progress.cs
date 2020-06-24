using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    class Progress
    {
        public static void ProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rObliczanie... {i}%   ");
                Thread.Sleep(20);
            }
        }
    }
}
