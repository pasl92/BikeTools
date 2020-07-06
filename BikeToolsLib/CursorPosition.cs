using System;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class CursorPosition
    {
        //Ustawianie pozycji kursora
        public static void WelcomeWindow(int x, int y)

        {
            Console.SetCursorPosition(x, y);
        }

    }
}
