using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, wynik = 1;
            Console.WriteLine("Podaj liczbę jako podstawę silni do obliczenia: ");
            n = BigInteger.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            Console.WriteLine("Wynik to " + wynik);

            Console.ReadLine();
        }
    }
}
