using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace BikeToolsLib
{
    public class Logo
    {
        static public void AppLogo()
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


            int t = 700;
            for (int i = 0; i < logo.Length; i++)
            {
                Thread.Sleep(t);
                t = t - 100;
                Console.WriteLine(logo[i]);
            }

            Console.ResetColor();
        }
    }
}
