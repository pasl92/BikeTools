using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace BikeToolsLib
{
    class KalkulatorBMI
    {
        public static void BMI()
        {

            Console.WriteLine("\nPodaj wagę: ");
            if (double.TryParse(Console.ReadLine(), out double w))
            {
                Sounds.EnterSound();

                Console.WriteLine("\nPodaj wzrost ");
                if (double.TryParse(Console.ReadLine(), out double h))
                {
                    Sounds.EnterSound();
                    Progress.ProgressBar();
                    BMIlogic(w, h, out double u);
                    Console.WriteLine("\nTwoje BMI to: " + string.Format("{0:.0}", u));

                    if (u < 16)
                    {
                        Console.WriteLine("Waga zdecydowanie za niska");
                    }
                    else if (u < 18.5)
                    {
                        Console.WriteLine("Waga za nisaka");
                    }
                    else if (u < 25)
                    {
                        Console.WriteLine("Waga w normie");
                    }
                    else if (u < 30)
                    {
                        Console.WriteLine("Waga za wysoka");
                    }
                    else if (u > 30)
                    {
                        Console.WriteLine("Waga zdecydowanie za wysoka");
                    }
                    Sounds.SuccessSound();
                    Console.WriteLine();

                }
                else
                {
                    Sounds.FailSound();
                    BMI();
                }

            }
            else
            {
                Sounds.FailSound();
                BMI();
            }

            BikeToolsMenu.Menu();

        }

        public static void BMIlogic(double w, double h, out double u)
        {
            u = w / ((h * 0.01) * (h * 0.01));
        }


    }
}
