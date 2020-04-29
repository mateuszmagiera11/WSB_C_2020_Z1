using System;

namespace WSB_C_2020_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wybór;
            Console.WriteLine("Witaj w kalkulatorze. Wybierz co chcesz zrobić");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            
            wybór = Console.ReadLine();
            if (wybór == "1")
            {
                Calculator.Suma();
                
            }
            if (wybór == "2")
            {
                Calculator.Odejm();
            }
            switch (wybór)
            {
                case "3":
                    Calculator.Iloczyn();
                break;
            }        
            switch (wybór)
            {
                case "4":
                    Calculator.Iloraz();
                    break;
            }
           

            Console.ReadLine();
        }
    }
}
