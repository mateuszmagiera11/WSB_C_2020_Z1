﻿using System;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wybór;
            double a, b, x;
            Console.WriteLine("Witaj w kalkulatorze. Wybierz co chcesz zrobić");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            
            wybór = Console.ReadLine();
            if (wybór == "1")
            {
                Console.WriteLine("Wybrano operację dodawania");
                Console.WriteLine("Podaj pierwszą liczbę");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę");
                b = double.Parse(Console.ReadLine());
                
                Console.WriteLine("wynik to " + x);
            }
            if (wybór == "2")
            {
                Console.WriteLine("Wybrano operację odejmowania");
                Console.WriteLine("Podaj pierwszą liczbę:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę:");
                b = double.Parse(Console.ReadLine());
                x = a - b;
                Console.WriteLine("wynik to " + x);
            }
            switch (wybór)
            {
                case "3":
                    Console.WriteLine("Wybrano operację mnożenia");
                    Console.WriteLine("Podaj pierwszą liczbę:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę:");
                    b = double.Parse(Console.ReadLine());
                    x = a * b;
                    Console.WriteLine("wynik to " + x);
                    break;
                case "4":
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
                    break;
                default:
                    Console.WriteLine("Nieznane polecenie.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
