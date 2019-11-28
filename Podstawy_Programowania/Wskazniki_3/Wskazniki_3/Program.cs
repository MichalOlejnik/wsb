using System;

namespace Wskazniki_3
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] tab = { 10, 20, 30, 40, 50 };

            fixed(int* x=tab)                   //fixed do używania wskaźników w tablicach
                for(int i=0; i<tab.Length; i++)
                {
                    Console.WriteLine("Adres tab[{0}] = {1}", i, (int)x+i);
                    Console.WriteLine(", wartość {0}", *(x+i));
                }
            Console.ReadKey();
        }
    }
}
