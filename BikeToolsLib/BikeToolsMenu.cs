using System;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class BikeToolsMenu
    {
        public static void Menu()
        {
            Console.WriteLine("1. Kalkulator rozmiaru ramy");
            Console.WriteLine("2. Kalkulator długosci szprych");
            Console.WriteLine("3. INFO");
            Console.WriteLine("\n0. KONIEC");


            while (1 != 0)
            {
                string h = Console.ReadLine();

                if ((h == "0") || (h == "1") || (h == "2"))
                {

                    switch (h)
                    {
                        case "1":
                            KalkulkatorRam.KalRam();

                            break;

                        case "2":
                            KalkulatorSzprych.KalSzprych();
                            break;

                        case "0":
                            System.Environment.Exit(1);
                            break;
                    }
                }
            }
        }
    }
}
