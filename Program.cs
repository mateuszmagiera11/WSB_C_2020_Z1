using System;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dziala = true;
            bool pamiec = false;
            double wynik = 0;

            do
            {
                string wybór;
                double a, b;
                
                Console.WriteLine("Witaj w kalkulatorze. Wybierz co chcesz zrobić");

                Console.WriteLine("\nWyświetlacz: " + wynik + "\n");

                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("x. Wynik");

                wybór = Console.ReadLine();

                switch (wybór)
                {
                    case "1":
                        Console.WriteLine("Wybrano operację dodawania");
                        a = Pamiec.Sprawdz(pamiec, wynik);
                        Console.WriteLine("Podaj drugą liczbę");
                        b = double.Parse(Console.ReadLine());
                        wynik = a + b;
                        pamiec = true;
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Wybrano operację odejmowania");
                        a = Pamiec.Sprawdz(pamiec, wynik);
                        Console.WriteLine("Podaj drugą liczbę:");
                        b = double.Parse(Console.ReadLine());
                        wynik = a - b;
                        pamiec = true;
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Wybrano operację mnożenia");
                        a = Pamiec.Sprawdz(pamiec, wynik);
                        Console.WriteLine("Podaj drugą liczbę:");
                        b = double.Parse(Console.ReadLine());
                        wynik = a * b;
                        pamiec = true;
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Wybrano operację dzielenia");
                        a = Pamiec.Sprawdz(pamiec, wynik);
                        do
                        {
                            Console.WriteLine("Podaj drugą liczbę:");
                            b = double.Parse(Console.ReadLine());
                            if (b == 0)
                            {
                                Console.WriteLine("Nie można dzielić przez zero!");
                            }
                        } while (b == 0);
                        wynik = a / b;
                        pamiec = true;
                        Console.Clear();
                        break;
                    case "x":
                        dziala = false;
                        Console.WriteLine("Wynik to: " + wynik);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nieznane polecenie. Wybierz ponownie.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (dziala);
        }
    }
}
