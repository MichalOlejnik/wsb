using System;

namespace Funkcje6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            //ta tablica nie ma przypisanych żadnych wartośc do indeksów
            tab[0] = 5;
            tab[1] = 10;

            Console.WriteLine("Wartości tablicy przed wywołaniem funkcji: {0} i {1}", tab[0], tab[1]);
            Tab1(ref tab);
            Console.WriteLine("Wartości tablicy po wywołaniu funkcji: {0} i {1}", tab[0], tab[1]);

            ShowTab(tab);
            Console.ReadKey();
        }

        static void Tab1(ref int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;
            Console.WriteLine("Wartośći tablicy wewnątrz funkcji: {0} i {1}", tab[0], tab[1]);
        }

        static void ShowTab(int[] tab)
        {
            Console.Write("Wartości w tablicy: ");
            foreach (int item in tab)
            {
                Console.Write("{0} ", item);
            }
        }

    }
}
