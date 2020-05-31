using System;

namespace BikeTools
{
    class Program
    {
        static void KalkulatorSzprych()
        {
            Console.WriteLine("In progress");
        }

        static void KalkulatorRam()
        {
            Console.WriteLine("In progress");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("WSEI 2020/2021\n");

            Console.WriteLine("++++++++++  +++  +++  +++  ++++++++++      ++++++++++  ++++++++++   ++++++++++   +++       ++++++++++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++       ++        \n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++       ++        \n++++++++++  +++  ++++      ++++++++++          ++      ++      ++   ++      ++   +++       ++++++++++\n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++               ++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++               ++\n++++++++++  +++  +++  +++  ++++++++++          ++      ++++++++++   ++++++++++   +++++++   ++++++++++\n");

            Console.WriteLine("1. Kalkulator Rozmiaru Ramy");
            Console.WriteLine("2. Kalkulator długości szprych");
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
                            KalkulatorRam();
                            break;

                        case "2":
                            KalkulatorSzprych();
                            break;

                        case "0":
                            System.Environment.Exit(1);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nWprowadz poprawne dane\n0 - Exit\n1 - Kalkulator Rozmiaru Ramy \n2 - Kalkulator długości szprych");
                }
            }
        }
    }
}
