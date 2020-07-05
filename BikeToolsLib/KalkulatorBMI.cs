using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace BikeToolsLib
{
    class KalkulatorBMI
    {
        //Pobranie danych do kalkulatora BMI
        //Wyświetlenie BMI wraz z komentarzem
        public static void BMI()
        {
            Console.WriteLine("\nPodaj wagę: ");
            if (double.TryParse(Console.ReadLine(), out double weight))
            {
                Sounds.EnterSound();

                Console.WriteLine("\nPodaj wzrost ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    Sounds.EnterSound();
                    Loaders.ProgressBar();
                    BMIlogic(weight, height, out double result);
                    Console.WriteLine("\nTwoje BMI to: " + string.Format("{0:.0}", result));

                    if (result < 16)
                    {
                        Console.WriteLine("Waga zdecydowanie za niska");
                    }
                    else if (result < 18.5)
                    {
                        Console.WriteLine("Waga za nisaka");
                    }
                    else if (result < 25)
                    {
                        Console.WriteLine("Waga w normie");
                    }
                    else if (result < 30)
                    {
                        Console.WriteLine("Waga za wysoka");
                    }
                    else if (result > 30)
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

        //Logika BMI
        public static void BMIlogic(double weight, double height, out double result)
        {
            result = weight / ((height * 0.01) * (height * 0.01));
        }


    }
}
