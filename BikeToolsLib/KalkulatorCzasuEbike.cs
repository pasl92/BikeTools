using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace BikeToolsLib
{
    public class KalkulatorCzasuEbike
    {

        //Pobranie danych dla kalkulatora czasu jazdy na rowerze elektrycznym
        //obliczenie czasu uwzględniająć poziom doładowania
        public static void KalDysEbike()
        {

            double level = 1.0;
            string mode = "high";

            Console.WriteLine("\nAby oszacować czas jazdy na Ebike wprowadz dane:\n - liczba aperogodzin (Ah)\n - Napięcie (V) \n - moc silnika (W) \n");

            Console.WriteLine("Wprowadz liczbę amperogodzin");

            if(double.TryParse(Console.ReadLine(), out double ah))
            {
                Sounds.EnterSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }


            Console.WriteLine("Wprowadz napięcie");
            if (double.TryParse(Console.ReadLine(), out double v))
            {
                Sounds.EnterSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }

            Console.WriteLine("Wprowadz moc silnika");
            if (double.TryParse(Console.ReadLine(), out double w))
            {
                Sounds.EnterSound();
            }
            else
            {
                Sounds.FailSound();
                KalDysEbike();
            }



            Console.WriteLine("\nWybierz stopień wspomagania: \n 1. Low\n 2. Medium\n 3. High\n");

            string h = Console.ReadLine();

            while ((h != "1") && (h != "2") && (h != "3"))
            {
                Sounds.FailSound();
                h = Console.ReadLine();
            }

            Sounds.EnterSound();

            switch (h)
            {
                case "1":
                    mode = "low";
                    level = 1.75;
                    break;

                case "2":
                    mode = "medium";
                    level = 1.50;
                    break;

                case "3":
                    mode = "high";
                    level = 1.0;
                    break;
            }


            double time;
            time = (((ah * v) / w) * 60) * level;


            Progress.ProgressBar();
            Sounds.SuccessSound();
            Console.WriteLine("\n\nSzacunkowy czas jazdy w trybie doładowania " + mode + " to " + string.Format("{0:.0}", time) + " minut"); 
            BikeToolsMenu.Menu();

        }

    }
}
