using System;
using System.Numerics;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9, wynik = 1;
            for (int i = 1; i <= n; i++)
            {

                wynik *= i;

            }
            Console.WriteLine("wynik to " + wynik);

            long o = 12, silnia = 1;
            for (int k = 1; k <= o; k++)
            {
                silnia *= k;
            }
            Console.WriteLine("wynik to " + silnia);

            BigInteger x = 20, z = 1;
            for (int l = 1; l <= x; l++)
            {
                z *= l;
            }
            Console.WriteLine("wynik to " + z);

            Console.ReadLine();
        }
    }
}
