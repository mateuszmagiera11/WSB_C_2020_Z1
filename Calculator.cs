using System;
using System.Collections.Generic;
using System.Text;

namespace WSB_C_2020_Z1
{
    class Calculator
    {
        
        public static double Suma()
        {
            Console.WriteLine("Wybrano dodawanie");
            Console.WriteLine("Podaj pierwszą liczbę");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = double.Parse(Console.ReadLine());

            double x;
            x = a + b;
            return x;
        }
    }
}
