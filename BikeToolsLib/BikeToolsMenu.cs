using System;
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


            while (1 != 0)
            {
                string h = Console.ReadLine();

                if ((h == "0") || (h == "1") || (h == "2") || (h == "3"))
                {

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
                            Console.WriteLine("\nZamykanie...");
                            System.Environment.Exit(1);
                            break;
                    }
                }
            }
        }
    }
}
