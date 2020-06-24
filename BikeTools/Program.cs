using BikeToolsLib;
using System;
using System.ComponentModel.Design;

namespace BikeTools
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("WSEI 2019/2020\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("++++++++++  +++  +++  +++  ++++++++++      ++++++++++  ++++++++++   ++++++++++   +++       ++++++++++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++       ++        \n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++       ++        \n++++++++++  +++  ++++      ++++++++++          ++      ++      ++   ++      ++   +++       ++++++++++\n++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++               ++\n++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++               ++\n++++++++++  +++  +++  +++  ++++++++++          ++      ++++++++++   ++++++++++   +++++++   ++++++++++\n\n");
            Console.ResetColor();

            BikeToolsMenu.Menu();

        }

     }
}
