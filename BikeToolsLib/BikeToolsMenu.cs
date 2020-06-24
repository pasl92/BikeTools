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
            Console.WriteLine("3. INFO");
            Console.WriteLine("\n0. KONIEC\n");

            string h = "";

            while ((h != "0") && (h != "1") && (h != "2") && (h != "3"))
            {
                h = Console.ReadLine();
            }


            switch (h)
            {
                case "1":
                    KalkulkatorRam.KalRam();

                    break;

                case "2":
                    KalkulatorCzasuEbike.KalDysEbike();
                    break;

                case "3":
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
