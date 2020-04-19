using System;
using System.Collections.Generic;
using System.Text;

namespace WSB_C_2020_Z1
{
    class Pamiec
    {
        internal static double Sprawdz(bool pamiec, double wynik)
        {
            double x;
            if (pamiec)
            {
                return wynik;
            }
            else
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                x = double.Parse(Console.ReadLine());
                return x;
            }
        }
    }
}
