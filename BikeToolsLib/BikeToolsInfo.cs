using System;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    class BikeToolsInfo
    {
        public static void Info()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nPaweł Sałata \nInformatyka i Ekonometria 2019/2020 niestacjonarne \nNumer indeku 12455");
            Console.ResetColor();

            BikeToolsMenu.Menu();
        }
    }
}
