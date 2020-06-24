using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BikeToolsLib
{
    public class KalkulatorCzasuEbike
    {
        public static void KalDysEbike()
        {
            Console.WriteLine("\nAby oszacować czas jazdy na Ebike wprowadz dane:\n - liczba aperogodzin (Ah)\n - Napięcie (V) \n - moc silnika (W) \n");

            Console.WriteLine("Wprowadz liczbę amperogodzin");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz napięcie");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz moc silnika");
            Console.WriteLine("Wprowadz moc silnika");
            double k = double.Parse(Console.ReadLine());


            double j;

            j = ((x * z) / k) * 60;

            Console.WriteLine("Oszacowany czas jazdy przy pełnym doładowaniu to " + string.Format("{0:.0}", j) + "m");

            BikeToolsMenu.Menu();

        }

    }
}
