using System;
using System.Collections.Generic;
using System.Text;

namespace WSB_C_2020_Z1
{
    class Calculator
    {
        
        public static double Suma()
        {
            double a, b, x;
            Console.WriteLine("Wybrano dodawanie");
            Console.WriteLine("Podaj pierwszą liczbę");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = double.Parse(Console.ReadLine());
            x = a + b;
            Console.WriteLine("wynik to " + x);
            return x;
            
        }
        public static double Odejm()
        {
            double a, b, x;
            Console.WriteLine("Wybrano odejmowanie");
            Console.WriteLine("Podaj pierwszą liczbę");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = double.Parse(Console.ReadLine());
            x = a - b;
            Console.WriteLine("wynik to " + x);
            return x;
        }
        public static double Iloczyn()
        {
            double a, b, x;
            Console.WriteLine("Wybrano operację mnożenia");
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            b = double.Parse(Console.ReadLine());
            x = a * b;
            Console.WriteLine("wynik to " + x);
            return x;
            
        }
        public static double Iloraz()
        {
            double a, b, x;
            Console.WriteLine("Wybrano operację dzielenia");
            Console.WriteLine("Podaj pierwszą liczbę:");
            a = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Podaj drugą liczbę:");
                b = double.Parse(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero!");
                }
            } while (b == 0);
            x = a / b;
            Console.WriteLine("wynik to " + x);
            return x;
        }
    }
}
