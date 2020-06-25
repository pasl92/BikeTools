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
            Logo.AppLogo(1);
            Thread.Sleep(100);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Logo.AppLogo(0);
            Thread.Sleep(200);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Logo.AppLogo(0);
            Thread.Sleep(100);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Logo.AppLogo(0);
            Thread.Sleep(200);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Logo.AppLogo(0);

            Console.ResetColor();

            Sounds.WelcomeSound();

            BikeToolsMenu.Menu();

        }

     }
}
