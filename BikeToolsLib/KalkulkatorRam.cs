using System;

namespace BikeToolsLib
{
    public class KalkulkatorRam
    {

        public static void KalRam()
        {
            int wzrost;
            string[] frameSizeM = { "33-36 cm (13\" - 14\")", "35-38 cm (14\" - 15\")", "38-40 cm (15\" - 16\")", "40-43 cm (16\" - 17\")", "42-45 cm (16,5\" - 17, 5\")", "44-47 cm (17,5\" - 18, 5\")", "46-49 cm (18\" - 19\"), 49-52 cm (19\" - 20, 5\")", "51-56 cm (20,5\"-22\")", "od 56 cm (od 22\")" };
            string[] frameSizeR = { "47-49 cm", "49-51 cm", "51- 53 cm", "53-55 cm", "55-57 cm", "57-60 cm", "60- 62 cm", "62-64 cm", "od 64 cm" };


            Console.WriteLine("\nPodaj wzrost: ");
            wzrost = int.Parse(Console.ReadLine());
            Sounds.EnterSound();

            Console.WriteLine("\nWybierz rodzaj roweru: \n");
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
                                Sounds.SuccessSound();
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
                        Sounds.FailSound();
                        Console.WriteLine("\nAby dobrać odpowiedni rozmiar dla twojego wzrostu, polecamy udać się na konsultacje w sklepie rowerowym.");
                    }

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
                                Sounds.SuccessSound();
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
                        Sounds.FailSound();
                        Console.WriteLine("\nAby dobrać odpowiedni rozmiar dla twojego wzrostu, polecamy udać się na konsultacje w sklepie rowerowym.");
                    }

                }

                BikeToolsMenu.Menu();
            }
        }

    }
}
