using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BikeToolsLib
{
    public class ColorMode

    {
        public static void ColorMenu()
        {
            Console.WriteLine("1 - Dark Mode");
            Console.WriteLine("2 - White Mode");
            Console.WriteLine("3 - Random Mode");
            Console.WriteLine("0 - Menu");

            string h = "";

            while ((h != "0") && (h != "1") && (h != "2") && (h != "3"))
            {
                h = Console.ReadLine();
            }

            switch (h)
            {
                case "1":
                    DarkMode();
                    break;

                case "2":
                    WhiteMode();
                    break;

                case "3":
                    RandomMode();
                    break;

                case "0":
                    BikeToolsMenu.Menu();
                    break;
            }

        }


        public static void WhiteMode()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

        public static void DarkMode()
        {
            Console.ResetColor();
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

        public static void RandomMode()
        {
            Random r = new Random();

            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
            Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

    }
}
