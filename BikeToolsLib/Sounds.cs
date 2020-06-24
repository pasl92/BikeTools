using System;
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
    }
}
