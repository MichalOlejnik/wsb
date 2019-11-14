using System;

namespace funkcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Napisz funkcje, która wyświeli czy liczba jest parzysta/nieparzysta
             * funkcja zwraca string(liczba parzysta/nieparzysta)
             */
            int x = 11;
            Console.WriteLine(parzysta(x));
            Console.WriteLine("\n"+Sum(123));

        }
        static string parzysta(int x)
        {
            string wynik;

            if (x % 2 == 0)
            {
                return "liczba parzysta";
            }
            else
            {
                return "liczba nieparzysta";
            }
        }

        static int Sum(int x, int sum=0)
        {
            do
            {
                sum = sum + x % 10;
                x /= 10;        //x=x/10
            } while (x!=0);
            return sum;
        }
    }
}
