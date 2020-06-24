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

            if(double.TryParse(Console.ReadLine(), out double x))
            {
                Sounds.SuccessSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }


            Console.WriteLine("Wprowadz napięcie");
            if (double.TryParse(Console.ReadLine(), out double z))
            {
                Sounds.SuccessSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }

            Console.WriteLine("Wprowadz moc silnika");
            if (double.TryParse(Console.ReadLine(), out double k))
            {
                Sounds.SuccessSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }



            Console.WriteLine("\nWybierz stopień wspomagania: \n 1 - Low\n 2 - Medium\n 3 - High\n");

            string h = Console.ReadLine();

            while ((h != "1") && (h != "2") && (h != "3"))
            {
                Sounds.FailSound();
                h = Console.ReadLine();
            }

            Sounds.SuccessSound();

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
                    mode = "high";
                    o = 1.0;
                    break;
            }


            double j;
            j = (((x * z) / k) * 60) * o;


            Progress.ProgressBar();
            Sounds.SuccessSound();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nSzacunkowy czas jazdy w trybie doładowania " + mode + " to " + string.Format("{0:.0}", j) + " minut");
            Console.ResetColor();
            BikeToolsMenu.Menu();

        }

    }
}
