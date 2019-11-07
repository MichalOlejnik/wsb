using System;

namespace wyjatki2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)
            {
                Console.WriteLine("Wprowadz liczbe calkowita: ");
                string x = Console.ReadLine();

                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie np. 4\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem");
                    Console.WriteLine("Zakres liczb: <0;4 294 967 295");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Wartość nie może być równa NULL");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wartość nie może być pusta");
                }

            }
            Console.WriteLine("\nLiczba całkowita: {0}", number);
            Console.ReadKey();

        }
    }
}
