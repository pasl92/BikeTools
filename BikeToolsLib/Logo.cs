using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class Logo
    {
        static public void AppLogo(int k)
        {
            string[] logo = new string[] {
            "++++++++++  +++  +++  +++  ++++++++++      ++++++++++  ++++++++++   ++++++++++   +++       ++++++++++",
            "++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++       ++        ",
            "++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++       ++        ",
            "++++++++++  +++  ++++      ++++++++++          ++      ++      ++   ++      ++   +++       ++++++++++",
            "++      ++  +++  ++++++    ++                  ++      ++      ++   ++      ++   +++               ++",
            "++      ++  +++  +++ +++   ++                  ++      ++      ++   ++      ++   +++               ++",
            "++++++++++  +++  +++  +++  ++++++++++          ++      ++++++++++   ++++++++++   +++++++   ++++++++++\n" 
            };


            if (k == 1)
            {
                int t = 700;
                for (int i = 0; i < logo.Length; i++)
                {
                    Thread.Sleep(t);
                    t = t - 100;
                    Console.WriteLine(logo[i]);
                    Console.Beep(300, 30);
                }
            }
            else if(k == 0)
            {
                for (int i = 0; i < logo.Length; i++)
                {
                    Console.WriteLine(logo[i]);
                }
            }
        }

        public static void LogoAnim()
        {

            Console.WriteLine("WSEI 2019/2020\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Logo.AppLogo(1);
            Thread.Sleep(100);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Logo.AppLogo(0);
            Thread.Sleep(200);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Logo.AppLogo(0);
            Thread.Sleep(100);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Logo.AppLogo(0);
            Thread.Sleep(200);
            CursorPosition.WelcomeWindow(0, 2);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Logo.AppLogo(0);


        }

    }
}
