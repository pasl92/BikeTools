using System;
using System.ComponentModel.Design;

namespace BikeTools
{
    class Program
    {
        static void Menu()
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
            }
        }


        static void KalkulatorSzprych()
        {
            Console.WriteLine("In progress");
        }

        static void KalkulatorRam()
        {
            int wzrost;
            string[] frameSizeM = { "33-36 cm (13\" - 14\")", "35-38 cm (14\" - 15\")", "38-40 cm (15\" - 16\")", "40-43 cm (16\" - 17\")", "42-45 cm (16,5\" - 17, 5\")", "44-47 cm (17,5\" - 18, 5\")", "46-49 cm (18\" - 19\"), 49-52 cm (19\" - 20, 5\")", "51-56 cm (20,5\"-22\")", "od 56 cm (od 22\")" };
            string[] frameSizeR = { "47-49 cm", "49-51 cm", "51- 53 cm", "53-55 cm", "55-57 cm", "57-60 cm", "60- 62 cm", "62-64 cm", "od 64 cm" };


            Console.WriteLine("Podaj wzrost: ");
            wzrost = int.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz rodzaj roweru: \n");
            Console.WriteLine("1 - Rower MTB");
            Console.WriteLine("2 - Rower szosowy\n");


            while (1 != 0)
            {

                string b = Console.ReadLine();

                if (b == "1")
                {
                    int j = 155;

                    if (wzrost >= 150 && wzrost <= 200)

                    {

                        for (int n = 0; n <= 10; n++)
                        {
                            if (wzrost <= j)
                            {
                                Console.WriteLine("\nOdpowiedni rozmiar ramy MTB to " + frameSizeM[n]);

                                n = 10;
                            }

                            else
                            {
                                j += 5;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Aby dobrać odpowiedni rozmiar dla twojego wzrostu, polecamy udać się na konsultacje w sklepie rowerowym.");
                    }

                    Console.WriteLine("\n0 - KONIEC");
                    Console.WriteLine("3 - Menu główne\n");

                }

                else if (b == "2")
                {
                    int j = 160;

                    if (wzrost >= 155 && wzrost <= 200)

                    {

                        for (int n = 0; n <= 10; n++)
                        {
                            if (wzrost <= j)
                            {
                                Console.WriteLine("\nOdpowiedni rozmiar ramy szosowej to " + frameSizeR[n]);

                                n = 10;
                            }

                            else
                            {
                                j += 5;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Aby dobrać odpowiedni rozmiar dla twojego wzrostu, polecamy udać się na konsultacje w sklepie rowerowym.");
                    }

                    Console.WriteLine("\n0 - KONIEC");
                    Console.WriteLine("3 - Menu główne\n");
                }

                else if (b == "3")

                {
                    Menu();
                }


            }
        }



                static void Main(string[] args)
                {
                    Console.WriteLine("WSEI 2020/2021\n");

                    Console.WriteLine("++++++++++  +++  +++  +++  ++++++++++      ++++++++++  ++++++++++   ++++++++++   +++       ++++++++++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++       ++        \n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++       ++        \n++++++++++  +++  ++++      ++++++++++          ++      ++      ++   ++      ++   +++       ++++++++++\n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++               ++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++               ++\n++++++++++  +++  +++  +++  ++++++++++          ++      ++++++++++   ++++++++++   +++++++   ++++++++++\n");

                    Menu();
                   
                }


     }
}
