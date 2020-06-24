using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace BikeToolsLib
{
    public class KalkulatorCzasuEbike
    {
        public static void KalDysEbike()
        {

            double o = 1.0;
            string mode = "high";

            Console.WriteLine("\nAby oszacować czas jazdy na Ebike wprowadz dane:\n - liczba aperogodzin (Ah)\n - Napięcie (V) \n - moc silnika (W) \n");

            Console.WriteLine("Wprowadz liczbę amperogodzin");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz napięcie");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz moc silnika");
            double k = double.Parse(Console.ReadLine());

            Console.WriteLine("\nWybierz stopień wspomagania: \n 1 - Low\n 2 - Medium\n 3 - High\n");


            string h = Console.ReadLine();

            if ((h == "1") || (h == "2") || (h == "3"))
            {

                switch (h)
                {
                    case "1":
                        mode = "low";
                        o = 1.75;
                        break;

                    case "2":
                        mode = "medium";
                        o = 1.50;
                        break;

                    case "3":
                        mode = "High";
                        o = 1.0;
                        break;

                }
            }

            double j;

            j = (((x * z) / k) * 60) * o;


            Console.WriteLine("\nSzacunkowy czas jazdy w trybie doładowania " + mode + " to " + string.Format("{0:.0}", j) + " minut\n");

            BikeToolsMenu.Menu();

        }

    }
}
