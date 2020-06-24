using BikeToolsLib;
using System;
using System.Threading;
using System.ComponentModel.Design;

namespace BikeTools
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("WSEI 2019/2020\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(700);
            Console.WriteLine("++++++++++  +++  +++  +++  ++++++++++      ++++++++++  ++++++++++   ++++++++++   +++       ++++++++++");
            Thread.Sleep(400);
            Console.WriteLine("++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++       ++        ");
            Thread.Sleep(350);
            Console.WriteLine("++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++       ++        ");
            Thread.Sleep(300);
            Console.WriteLine("++++++++++  +++  ++++      ++++++++++          ++      ++      ++   ++      ++   +++       ++++++++++");
            Thread.Sleep(250);
            Console.WriteLine( "++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++               ++" );
            Thread.Sleep(200);
            Console.WriteLine("++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++               ++");
            Thread.Sleep(100);
            Console.WriteLine( "++++++++++  +++  +++  +++  ++++++++++          ++      ++++++++++   ++++++++++   +++++++   ++++++++++\n");
            Console.ResetColor();

            Console.Beep(670, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);


            BikeToolsMenu.Menu();

        }

     }
}
