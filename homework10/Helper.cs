using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace homework10
{
    public class Helper
    {
        public static void PrintByCountry(Employ[] employs, country country)
        {
            foreach (Employ employ in employs)
            {
                if (employ.Country == country)
                {
                    employ.PrintInfo();
                }
            }
        }

        internal static void PrintBycountry(Employ[] employs, country georgia)
        {
            throw new NotImplementedException();
        }
    }
}
