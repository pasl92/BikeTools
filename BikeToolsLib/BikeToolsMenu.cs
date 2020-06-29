using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class BikeToolsMenu
    {
        public static void Menu()
        {
            Console.WriteLine("\n1. Kalkulator rozmiaru ramy");
            Console.WriteLine("2. Kalkulator czasu jazdy Ebike");
            Console.WriteLine("3. Prezent urodzinowy");
            Console.WriteLine("4. Color mode");
            Console.WriteLine("5. INFO");
            Console.WriteLine("\n0. KONIEC\n");

            string h = "";

            while ((h != "0") && (h != "1") && (h != "2") && (h != "3") && (h != "4") && (h != "5"))
            {
                h = Console.ReadLine();
            }

            Sounds.EnterSound();

            switch (h)
            {
                case "1":
                    KalkulkatorRam.KalRam();

                    break;

                case "2":
                    KalkulatorCzasuEbike.KalDysEbike();
                    break;

                case "3":
                    Sounds.SupriseSound();
                    BikeToolsMenu.Menu();
                    break;

                case "4":
                    ColorMode.ColorMenu();
                    break;

                case "5":
                    BikeToolsInfo.Info();
                    break;

                case "0":
                    Console.Write("\nZamykanie");

                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(700);
                        Console.Write(".");
                    }

                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
