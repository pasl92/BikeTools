using BikeToolsLib;
using System;
using System.Threading;
using System.ComponentModel.Design;

namespace BikeTools
{
    public class Program
    {
        //Ustalenie szerokosci konsoli oraz uruchomienie programu
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
