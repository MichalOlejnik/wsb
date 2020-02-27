using System;
namespace ProjektWzorcowy
{
    class Program
    {
        static ulong AddNumber;
        static uint fib(uint n)
        {
            switch (n)
            {
                case 0: return 1;
                case 1: return 1;
                default: AddNumber++; return fib(n - 1) + fib(n - 2);
            }
        } /* fib() */
        static void Main(string[] args)
        {
            Console.WriteLine("n\tAddNo");
            for (uint u = 1; u < 48; u++)
            {
                AddNumber = 0;
                ulong r = fib(u);
                Console.WriteLine("{0}\t{1}", u, AddNumber);
            }
        }
    }
}