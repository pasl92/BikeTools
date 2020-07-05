using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    class Loaders
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

        //Loader zamykający 
        public static void ClosingLoader()
        {
            Console.Write("\nZamykanie");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(700);
                Console.Write(".");
            }
        }

    }
}
