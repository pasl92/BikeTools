using BikeToolsLib;
using System;
using System.Threading;
using System.ComponentModel.Design;

namespace BikeTools
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("WSEI 2019/2020\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Logo.AppLogo();
            CursorPosition.WelcomeWindow(0, 2);
            Logo.AppLogo();
            Sounds.WelcomeSound();

            BikeToolsMenu.Menu();

        }

     }
}
