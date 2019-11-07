using System;

namespace tablice_cd
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 10;
            a--;
            b++;
                Console.WriteLine("zmienna a: {0}", a);    //9
                Console.WriteLine("Zmienna b: {0}", b);    //11

            //typ referencyjny

            int[] tabA = { 8, 2, 2 };
            int[] tabB = tabA;

            tabA[2] = 10;
            Console.WriteLine("\n\nWyświetlanie tablicy A:");
            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            Console.WriteLine("\n\nWyświetlanie tablicy B:");
            foreach(int item in tabA)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();


            //kopiowanie tablicy

            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            tab.CopyTo(tabCopy, 0);
            //tab.CopyTo(tabCopy, 0);


            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            //II sposob kopiowania tablic

            Array.Copy(tab, tabCopy, tab.Length);

            foreach(int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadKey();
        }
    }
}
