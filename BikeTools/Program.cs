using BikeToolsLib;
using System;
using System.Threading;
using System.ComponentModel.Design;

namespace BikeTools
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.BufferWidth = 120;
            Logo.LogoAnim();
            Console.ResetColor();
            Sounds.WelcomeSound();
            BikeToolsMenu.Menu();
        }

     }
}
