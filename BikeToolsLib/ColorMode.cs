using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BikeToolsLib
{
    public class ColorMode

    {
        //Obsługa zmiany koloru interfejsu
        public static void ColorMenu()
        {
            Console.WriteLine("\n1. Dark Mode");
            Console.WriteLine("2. White Mode");
            Console.WriteLine("3. Random Mode");
            Console.WriteLine("0. Menu\n");


            string h = Console.ReadLine();

            while ((h != "0") && (h != "1") && (h != "2") && (h != "3"))
            {
                Sounds.FailSound();
                h = Console.ReadLine();
            }

            switch (h)
            {
                case "1":
                    Sounds.EnterSound();
                    DarkMode();
                    break;

                case "2":
                    Sounds.EnterSound();
                    WhiteMode();
                    break;

                case "3":
                    Sounds.EnterSound();
                    RandomMode();
                    break;

                case "0":
                    Sounds.EnterSound();
                    BikeToolsMenu.Menu();
                    break;
            }

        }

        //Zmiana koloru interfajsu na bialy
        public static void WhiteMode()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

        //Zmiana koloru interfejsu na czarny
        public static void DarkMode()
        {
            Console.ResetColor();
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

        //Zmina koloru interfesju na losowy kolor
        public static void RandomMode()
        {
            Random color = new Random();

            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)color.Next(0, 7);
            Console.BackgroundColor = (ConsoleColor)color.Next(8, 16);
            Console.Clear();
            Logo.AppLogo(1);
            BikeToolsMenu.Menu();
        }

    }
}
