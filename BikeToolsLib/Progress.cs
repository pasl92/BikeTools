using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    class Progress
    {
        //Loader procentowy
        public static void ProgressBar()
        {
            Console.WriteLine("");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rObliczanie... {i}%   ");
                Thread.Sleep(20);
            }
        }
    }
}
