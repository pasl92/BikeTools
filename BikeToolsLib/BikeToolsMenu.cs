using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class BikeToolsMenu
    {
        //Menu główne programu obsługiwane za pomoca switcha
        public static void Menu()
        {
            Console.WriteLine("\n1. Kalkulator rozmiaru ramy");
            Console.WriteLine("2. Kalkulator czasu jazdy Ebike");
            Console.WriteLine("3. Kalkulator BMI");
            Console.WriteLine("4. Prezent urodzinowy");
            Console.WriteLine("5. Color mode");
            Console.WriteLine("6. INFO");
            Console.WriteLine("\n0. KONIEC\n");

            string h = "";

            while ((h != "0") && (h != "1") && (h != "2") && (h != "3") && (h != "4") && (h != "5") && (h != "6"))
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
                    KalkulatorBMI.BMI();
                    break;

                case "4":
                    Sounds.SupriseSound();
                    BikeToolsMenu.Menu();
                    break;

                case "5":
                    ColorMode.ColorMenu();
                    break;

                case "6":
                    BikeToolsInfo.Info();
                    break;

                case "0":
                    Loaders.ClosingLoader();
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
