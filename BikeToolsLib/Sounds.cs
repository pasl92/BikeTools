using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class Sounds
    {
        public static void FailSound()
        {
            Console.Beep(670, 600);
        }

        public static void SuccessSound()
        {
            Console.Beep(650, 100);
        }

        public static void WelcomeSound()
        {
            Console.Beep(670, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
        }
    }
}
