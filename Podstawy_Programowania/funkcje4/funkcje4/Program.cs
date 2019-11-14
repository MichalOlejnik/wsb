using System;

namespace funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            increment(out a);
            Console.WriteLine("wartość zmiennej po wywołaniu funkcji:{0}", a);
            Console.ReadKey();
        }
        static void increment(out int x)    //out
        {
            x = 1;
            x += 10;
            Console.WriteLine("zmienna x wewnątrz funkcji:{0}", x);
        }
    }
}
